using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonInfoManage.BLL.Cost;
using PersonInfoManage.DAL.Cost;
using PersonInfoManage.DAL.System;
using PersonInfoManage.Model;
using PersonInfoManage.BLL.Utils;
using PersonInfoManage.DAL.Utils;

namespace PersonInfoManage
{
    public partial class CostApprovalForm : Form
    {
        private int costId;
        public CostApprovalForm()
        {
            InitializeComponent();
        }
        public CostApprovalForm(int costId)
        {
            this.costId = costId;
            InitializeComponent();
        }
        private void CostApprovalForm_Load(object sender, EventArgs e)
        {
            cost cost = new CostApplyBLL().Query(new Dictionary<string, object>
            {
                {"id",costId }
            }).First();
            cost_main main = cost.Main;
            view_sys_u2g applicant = new SysUserDAL().SelectById(main.apply_id).First();
            TexApplicant.Text = applicant.name;           
            foreach (cost_detail detail in cost.DetailList)
            {
                int index = this.DgvCostDetail.Rows.Add();
                this.DgvCostDetail.Rows[index].SetValues(new CostApplyDAL().GetCostTypeById(detail.cost_type_id), detail.money);
            }
            foreach (cost_approval approval in cost.ApprovalList)
            {
                int index = this.DgvApproval.Rows.Add();
                string approver = approval.approval_id + "." + new SysUserDAL().SelectById(approval.approval_id).First().name;
                this.DgvApproval.Rows[index].SetValues(approver, approval.result, approval.time, approval.opinion);
            }
            int userId = UserInfoBLL.UserId;
            //List<string> approverList = new CostApplyDAL().GetApprovalInfo(userId);
            List<string> approverList = new CostApplyDAL().GetApprovalInfo(32);
            if (approverList.Count == 0)
            {
                LblNextApprover.Visible = false;
                CmbNextApprover.Visible = false;
                return;
            }
            else
            {
                LblNextApprover.Visible = true;
                CmbNextApprover.Visible = true;
            }
            CmbNextApprover.Items.Clear();
            CmbNextApprover.Items.AddRange(approverList.ToArray());
        }

        private void BtnPass_Click(object sender, EventArgs e)
        {
            cost_main Main = new cost_main
            {
                id = costId,
                status = (byte)(CmbNextApprover.Visible ? 1 : 2)
            };
            List<cost_approval> ListApproval = new List<cost_approval>();
            cost_approval approval = new cost_approval
            {
                cost_id = costId,
                approval_id=32,
                //approval_id = UserInfoBLL.UserId,
                result = true,
                time = DateTime.Now,
                opinion = TexOpinion.Text
            };
            ListApproval.Add(approval);
            if (CmbNextApprover.Visible)
            {
                ListApproval.Add(new cost_approval
                {
                    cost_id = costId,
                    approval_id = int.Parse(CmbNextApprover.SelectedItem.ToString().Split('.')[0])
                }); 
            }
            Result res = new CostApprovalBLL().Update(new cost
            {
                Main = Main,
                ApprovalList = ListApproval
            });
            MessageBox.Show(res.Message, "操作结果提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnFailed_Click(object sender, EventArgs e)
        {
            cost_main Main = new cost_main
            {
                id = costId,
                status = 3
            };
            List<cost_approval> ListApproval = new List<cost_approval>();
            cost_approval approval = new cost_approval
            {
                cost_id = costId,
                approval_id = 29,
                //approval_id = UserInfoBLL.UserId,
                result = false,
                time = DateTime.Now,
                opinion = TexOpinion.Text
            };
            ListApproval.Add(approval);            
            Result res = new CostApprovalBLL().Update(new cost
            {
                Main = Main,
                ApprovalList = ListApproval
            });
            MessageBox.Show(res.Message, "操作结果提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
