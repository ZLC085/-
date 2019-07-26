using PersonInfoManage.BLL.System;
using PersonInfoManage.BLL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInfoManage
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            List<view_sys_u2g> orginfo = new SysUserBLL().SelectAll();
            CmbOrg.DataSource = orginfo;
            CmbOrg.DisplayMember = "org_name";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            sys_org org = new sys_org();
            org.org_name = CmbOrg.SelectedItem.ToString();
            List<sys_org> orginfo = new List<sys_org>();
            //orginfo =//查询组织机构Id方法
            sys_user sys_User = new sys_user();
            sys_User.name = TxtName.Text;
            sys_User.username = TxtUsername.Text;
            if (RdoSex1.Checked)
            {
                sys_User.gender = "男";
            }
            else
            {
                sys_User.gender = "女";
            }
            sys_User.password = TxtPassword.Text;
            sys_User.phone = TxtPhone.Text;
            sys_User.email = TxtEmail.Text;
            sys_User.job = TxtJob.Text;
            foreach (var id in orginfo)
            {
                sys_User.org_id = id.id;
            }
            SysUserBLL sysUserBLL = new SysUserBLL();
            Result result = sysUserBLL.add(sys_User);

            if (result.Code == RES.OK)
            {
                MessageBoxCustom.Show("添加成功", "提示", MessageBoxButtons.OK, this);
                Close();
            }
            else if (result.Code == RES.ERROR)
            {
                MessageBoxCustom.Show("添加失败", "提示", MessageBoxButtons.OK, this);
            }
        }
    }
}

