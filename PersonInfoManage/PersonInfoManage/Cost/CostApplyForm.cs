﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonInfoManage.BLL.Cost;
using PersonInfoManage.BLL.Utils;
using PersonInfoManage.DAL.Cost;
using PersonInfoManage.Model;

namespace PersonInfoManage
{
    public partial class CostApplyForm : Form
    {
        public int costId=0;
        public CostApplyForm()
        {
            InitializeComponent();
            btnCostApply.Click += new EventHandler(BtnCostApply_Click);
        }
        public CostApplyForm(int costId)
        {
            this.costId = costId;            
            InitializeComponent();
            btnCostApply.Click += new EventHandler(BtnCostApplyUpdate_Click);
            List<cost_detail> listDetail = new CostApplyDAL().QueryDetail(costId);
            foreach(cost_detail detail in listDetail)
            {
                string type = new CostApplyDAL().GetCostTypeById(detail.cost_type_id);
                addDetail(detail.cost_type_id+"." +type, detail.money.ToString());
            }
            CmbApprover.Visible = false;
            LblApprover.Visible = false;
            btnCostApply.Text = "修改";

        }
        public CostApplyForm(string costType, string count)
        {
            InitializeComponent();
            DataGridViewRow dgr = this.DgvCostDetail.Rows[this.DgvCostDetail.NewRowIndex];
            dgr.Cells[0].Value = costType;
            dgr.Cells[0].Value = count;
            this.DgvCostDetail.Rows.Add();

        }
        private void AddCostDeatil_Click(object sender, EventArgs e)
        {
            AddCostDetailForm addCostDetailForm = new AddCostDetailForm();
            //以对话框的方式显示添加详情的窗口
            addCostDetailForm.Owner = this;
            addCostDetailForm.ShowDialog();
        }

        private void BtnCostApply_Click(object sender, EventArgs e)
        {
            if (CmbApprover.SelectedItem == null)
            {
                MessageBox.Show("请选择一个审批人负责您的费用申请","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            CostApplyBLL costApplyBLL = new CostApplyBLL();
            List<cost_detail> listDetail = new List<cost_detail>();
            decimal applyMoney = 0;
            foreach(DataGridViewRow row in this.DgvCostDetail.Rows)
            {
                if(row.Cells[0].Value == null)
                {
                    continue;
                }
                int type = int.Parse((((string)row.Cells[0].Value).Split('.')[0]));
                decimal money = decimal.Parse((string)row.Cells[1].Value);
                listDetail.Add(new cost_detail
                {
                    cost_type_id = type,
                    money = money
                }) ;
                applyMoney += money;
            }
            cost_main main = new cost_main
            {
                apply_money = applyMoney,
                apply_time = DateTime.Now,
                apply_id=UserInfoBLL.UserId,
                status=0,
                remark=TexRemark.Text
            };
            List<cost_approval> ListApproval = new List<cost_approval>
            {
                new cost_approval
                {
                    approval_id=int.Parse(CmbApprover.SelectedItem.ToString().Split('.')[0])
                }
            };
            cost cost = new cost
            {
                Main = main,
                DetailList = listDetail,
                ApprovalList=ListApproval
            };
            Result res = costApplyBLL.Add(cost);
            DialogResult dialogResult= MessageBox.Show(res.Message, "添加费用申请单状态提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(dialogResult == DialogResult.OK)
            {
                if (res.Code == RES.OK)
                {
                    this.DgvCostDetail.Rows.Clear();
                    this.Close();
                }
            }
        }
        private void BtnCostApplyUpdate_Click(object sender,EventArgs e)
        {
            List<cost_detail> listDetail = new List<cost_detail>();
            decimal applyMoney = 0;
            foreach (DataGridViewRow row in this.DgvCostDetail.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    continue;
                }
                int type = int.Parse((((string)row.Cells[0].Value).Split('.')[0]));
                decimal money = decimal.Parse((string)row.Cells[1].Value);
                listDetail.Add(new cost_detail
                {
                    cost_type_id = type,
                    money = money
                });
                applyMoney += money;
            }
            Result res =new CostApplyBLL().Update(new cost
            {
                Main=new cost_main
                {
                    id=costId,
                    apply_money=applyMoney,
                    remark=TexRemark.Text
                },
                DetailList=listDetail
            });
            DialogResult dialogResult = MessageBox.Show(res.Message, "修改费用申请单状态提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                if (res.Code == RES.OK)
                {
                    this.DgvCostDetail.Rows.Clear();
                    this.Close();
                }
            }
        }
        public void addDetail(string costType,string count)
        {
            foreach(DataGridViewRow row in this.DgvCostDetail.Rows)
            {
                string type = (string)row.Cells[0].Value;
                if (type!=null && type.Equals(costType))
                {
                    MessageBox.Show("已存在 "+ costType + " 费用，请移除该项后再进行添加","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
            }
            int index = this.DgvCostDetail.Rows.Add();
            this.DgvCostDetail.Rows[index].SetValues(costType, count);
        }

        private void BtnRemoveDetail_Click(object sender, EventArgs e)
        {
            int count=this.DgvCostDetail.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("请至少选择一行进行删除","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            DialogResult result= MessageBox.Show("您确定要删除已选中的" + count + "行吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in this.DgvCostDetail.SelectedRows)
                {
                    this.DgvCostDetail.Rows.Remove(row);
                }
            }            
        }

        private void BtnCancelCostApply_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CostApplyForm_Load(object sender, EventArgs e)
        {
            List<string> listApprover = new CostApplyBLL().ApproverInfo(UserInfoBLL.UserId);
            CmbApprover.Items.Clear();
            CmbApprover.Items.AddRange(listApprover.ToArray());
        }
    }
}
