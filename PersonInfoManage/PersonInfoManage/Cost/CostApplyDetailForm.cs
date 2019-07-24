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

        private void CostApplyDetailForm_Load(object sender, EventArgs e)
        {
            cost cost = new CostApplyBLL().Query(new Dictionary<string, object>
            {
                {"id",costId }
            }).First();
            cost_main main = cost.main;
            LblCostId.Text = main.id.ToString();
            //申请人
            //所属部门
            LblApplyTime.Text = main.apply_money.ToString();
            LblApplyMoney.Text = main.apply_money.ToString();
            //申请明细
            switch (main.status)
            {
                case 0:LblStatus.Text = "未审核";break;
                case 1: LblStatus.Text = "正在审核"; break;
                case 2: LblStatus.Text = "审核通过"; break;
                case 3: LblStatus.Text = "审核驳回"; break;
            }
            //审批人
            //所属部门
            LblApprovalMoney.Text = main.approval_money.ToString();
            LblRemark.Text = main.remark;


            
        }
    }
}
