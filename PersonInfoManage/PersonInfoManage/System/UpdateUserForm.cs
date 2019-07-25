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
    public partial class UpdateUserForm : Form
    {
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            List<sys_org> orginfo = new List<sys_org>();
            //orginfo =
            comboBox1.DataSource = orginfo;
            comboBox1.DisplayMember = "org_name";
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            sys_org org = new sys_org();
            org.org_name = comboBox1.SelectedItem.ToString();
            List<sys_org> orginfo = new List<sys_org>();
            //orginfo =//查询组织机构Id方法
            sys_user sys_User = new sys_user();
            sys_User.name = textBoxX1.Text;
            sys_User.username = textBoxX2.Text;
            if (radioButton1.Checked)
            {
                sys_User.gender = "男";
            }
            else
            {
                sys_User.gender = "女";
            }
            sys_User.phone = textBoxX4.Text;
            sys_User.email = textBoxX5.Text;
            sys_User.job = textBoxX6.Text;
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
