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
            cost_main main = cost.main;
            LblCostId.Text = main.id.ToString();
            view_sys_u2g applicant = new SysUserDAL().SelectById(main.apply_id).First();
            LblApplicant.Text = applicant.name;
            LblApplicant.Text = applicant.org_name;
            LblApplyTime.Text = main.apply_money.ToString();
            LblApplyMoney.Text = main.apply_money.ToString();
            foreach(cost_detail detail in cost.DetailList)
            {
                int index = this.DgvCostDetail.Rows.Add();
                this.DgvCostDetail.Rows[index].SetValues(detail.cost_type_name, detail.money);
            }
            switch (main.status)
            {
                case 0:LblStatus.Text = "未审核";break;
                case 1: LblStatus.Text = "正在审核"; break;
                case 2: LblStatus.Text = "审核通过"; break;
                case 3: LblStatus.Text = "审核驳回"; break;
            }
            view_sys_u2g approver = new SysUserDAL().SelectById(main.approval_id).First();
            LblApprover.Text = approver.name;
            LblApproverOrg.Text = approver.org_name;
            LblApprovalMoney.Text = main.approval_money.ToString();
            LblRemark.Text = main.remark;           
        }
    }
}
