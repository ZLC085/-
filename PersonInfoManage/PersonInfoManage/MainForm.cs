using System;
using System.Windows.Forms;

namespace PersonInfoManage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Timer1.Interval = 1000;
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer1.Start();
            metroShell1.SelectedTab = MenuHome;
        }

        //<王继能_1>
        //
        //</王继能_1>

        //<毛宇航_1>
        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            PersonBasicForm pbForm = new PersonBasicForm();
            pbForm.ShowDialog();
        }

        private void BtnQueryPerson_Click(object sender, EventArgs e)
        {
            PersonDetailForm personDetailForm = new PersonDetailForm();
            personDetailForm.ShowDialog();
        }

        private void BtnUpdatePerson_Click(object sender, EventArgs e)
        {
            PersonBasicForm pbForm = new PersonBasicForm();
            pbForm.Text = "人员信息修改";
            pbForm.ShowDialog();
        }
        //</毛宇航_1>

        //<李鸽鸽_1>
        //
        //</李鸽鸽_1>

        //<坤吉心_1>
        //
        //</坤吉心_1>

        //<苏文杰_2>

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lableTime.Text = DateTime.Now.ToString("yyyy年MM月dd日-HH:mm:ss");
        }

        private void BtnEsc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出系统吗？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //</苏文杰_2>

        //<王尔沛_2>

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void BtnQueryUser_Click(object sender, EventArgs e)
        {
            UserDetailForm userDetailForm = new UserDetailForm();
            userDetailForm.ShowDialog();
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            CostPlanForm costPlanForm = new CostPlanForm();
            costPlanForm.Text = "用户信息修改";
            costPlanForm.ShowDialog();
        }

        private void BtnGroupManage_Click(object sender, EventArgs e)
        {
            GroupManageForm groupManageForm = new GroupManageForm();
            groupManageForm.ShowDialog();
        }

        private void BtnRoleManage_Click(object sender, EventArgs e)
        {
            GroupRoleManageForm groupRoleManageForm = new GroupRoleManageForm();
            groupRoleManageForm.ShowDialog();
        }

        //</王尔沛_2>

        //<曾丽川_2>

        private void BtnAddRole_Click(object sender, EventArgs e)
        {
            AddUserGroupForm addUserGroupForm = new AddUserGroupForm();
            addUserGroupForm.ShowDialog();
        }

        private void BtnUpdateRole_Click(object sender, EventArgs e)
        {
            AddUserGroupForm addUserGroupForm = new AddUserGroupForm();
            addUserGroupForm.Text = "修改用户组";
            addUserGroupForm.ShowDialog();
        }

        private void BtnAddKind_Click(object sender, EventArgs e)
        {
            AddCategoreTypeForm addCategoreTypeForm = new AddCategoreTypeForm();
            addCategoreTypeForm.ShowDialog();
        }

        private void BtnUpdateKind_Click(object sender, EventArgs e)
        {
            AddCategoreTypeForm addCategoreTypeForm = new AddCategoreTypeForm();
            addCategoreTypeForm.Text = "修改数据字典";
            addCategoreTypeForm.ShowDialog();
        }

        //</曾丽川_2>

        //<张乐_3>
        //
        //</张乐_3>

        //<陈波_3>
        //
        private void BtnAddCost_Click(object sender, EventArgs e)
        {
            CostApplyForm costApplyForm = new CostApplyForm();
            costApplyForm.ShowDialog();
        }

        private void BtnQueryCost_Click(object sender, EventArgs e)
        {
            CostApplyDetailForm costApplyDetailForm = new CostApplyDetailForm();
            costApplyDetailForm.ShowDialog();
        }

        private void BtnUpdateCost_Click(object sender, EventArgs e)
        {
            CostApplyForm costApplyForm = new CostApplyForm();
            costApplyForm.Text = "费用单修改";
            costApplyForm.ShowDialog();
        }

        private void BtnQueryAudit_Click(object sender, EventArgs e)
        {
            CostApplyDetailForm costApplyDetailForm = new CostApplyDetailForm();
            costApplyDetailForm.ShowDialog();
        }

        private void BtnAudit_Click(object sender, EventArgs e)
        {
            CostApprovalForm costApprovalForm = new CostApprovalForm();
            costApprovalForm.ShowDialog();
        }

        //</陈波_3>

        //<蒋媛_3>

        private void BtnUpdatePlan_Click(object sender, EventArgs e)
        {
            CostPlanForm costPlanForm = new CostPlanForm();
            costPlanForm.Text = "修改费用规划";
            costPlanForm.ShowDialog();
        }

        private void BtnPlanCost_Click(object sender, EventArgs e)
        {
            CostPlanForm costPlanForm = new CostPlanForm();
            costPlanForm.ShowDialog();
        }
        
        //</蒋媛_3>
    }
}
