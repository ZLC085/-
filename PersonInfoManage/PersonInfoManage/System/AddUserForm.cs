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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            if (Text.Equals("添加用户"))
            {
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
                sys_User.password = textBoxX3.Text;
                sys_User.phone = textBoxX4.Text;
                sys_User.email = textBoxX5.Text;
                sys_User.job = textBoxX6.Text;
                //sys_User.org_id = 
                SysUserBLL sysUserBLL = new SysUserBLL();
                Result result = sysUserBLL.add(sys_User);

                if (result.Code == RES.OK)
                {
                    MessageBox.Show(result.Message, "添加用户");
                    Close();
                }
                else if (result.Code == RES.ERROR)
                {
                    MessageBox.Show(result.Message, "添加用户");
                }
            }
            if (Text.Equals("用户信息修改"))
            {

            }
        }
    }
}
