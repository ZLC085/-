using System;
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
using PersonInfoManage.Model;

namespace PersonInfoManage
{
    public partial class CostApplyForm : Form
    {
        DataTable dataTable = new DataTable();
        public CostApplyForm()
        {
            InitializeComponent();
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
            CostApplyBLL costApplyBLL = new CostApplyBLL();
            List<cost_detail> listDetail = new List<cost_detail>();
            decimal applyMoney = 0;
            foreach(DataGridViewRow row in this.DgvCostDetail.Rows)
            {
                if(row.Cells[0].Value == null)
                {
                    continue;
                }
                string type_name = ((string)row.Cells[0].Value).Split('.')[1];
                int type = int.Parse((((string)row.Cells[0].Value).Split('.')[0]));
                decimal money = decimal.Parse((string)row.Cells[1].Value);
                listDetail.Add(new cost_detail
                {
                    cost_type = type,
                    cost_type_name = type_name,
                    money = money
                });
                applyMoney += money;
            }
            cost_main main = new cost_main
            {
                apply_money = applyMoney,
                apply_time = DateTime.Now,
                apply_id=1,
                approval_id=2,

            };
            cost cost = new cost
            {
                main = main,
                DetailList = listDetail
            };
            //MessageBox.Show(cost.main.applicant + " " + cost.main.apply_money + " " + cost.main.apply_time);
            //foreach(cost_detail detail in cost.DetailList)
            //{
            //    MessageBox.Show(detail.cost_type + " " + detail.cost_type_name + " " + detail.money);
            //}
            Result res = costApplyBLL.Add(cost);
            MessageBox.Show(res.Message, "添加费用申请单状态提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
