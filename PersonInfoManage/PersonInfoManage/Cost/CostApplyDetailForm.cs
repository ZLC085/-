using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonInfoManage.Model;
using PersonInfoManage.BLL.Cost;
using PersonInfoManage.DAL.System;
using PersonInfoManage.DAL.Cost;

namespace PersonInfoManage
{
    public partial class CostApplyDetailForm : Form
    {
        private int costId;
        public CostApplyDetailForm(int costId)
        {
            this.costId = costId;
            InitializeComponent();
        }
        public CostApplyDetailForm()
        {
            InitializeComponent();
        }
        private void CostApplyDetailForm_Load(object sender, EventArgs e)
        {            
            cost cost = new CostApplyBLL().Query(new Dictionary<string, object>
            {
                {"id",costId }
            }).First();
            cost_main main = cost.Main;
            LblCostId.Text = main.id.ToString();
            view_sys_u2g applicant = new SysUserDAL().SelectById(main.apply_id).First();
            LblApplicant.Text = applicant.name;
            LblApplicantOrg.Text = applicant.org_name;
            LblApplyTime.Text = main.apply_time.ToString("yyyy-MM-dd HH:mm:ss");
            LblApplyMoney.Text = main.apply_money.ToString();
            foreach (cost_detail detail in cost.DetailList)
            {
                int index = this.DgvCostDetail.Rows.Add();
                this.DgvCostDetail.Rows[index].SetValues(new CostApplyDAL().GetCostTypeById(detail.cost_type_id), detail.money);
            }
            switch (main.status)
            {
                case 0: LblStatus.Text = "未审核"; break;
                case 1: LblStatus.Text = "正在审核"; break;
                case 2: LblStatus.Text = "审核通过"; break;
                case 3: LblStatus.Text = "审核驳回"; break;
            }
            foreach(cost_approval approval in cost.ApprovalList)
            {
                int index = this.DgvApproval.Rows.Add();
                string approver = approval.approval_id+"."+ new SysUserDAL().SelectById(approval.approval_id).First().name;
                this.DgvApproval.Rows[index].SetValues(approver, approval.result, approval.time, approval.opinion);
            }
            
        }

    }
}
