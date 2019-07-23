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
            sys_user sys_User = new sys_user();
            //sys_User.name = 

            SysUserBLL sysUserBLL = new SysUserBLL();
            Result result = sysUserBLL.add(sys_User);

            if(result.Code == RES.OK)
            {
                MessageBox.Show(result.Message, "添加用户");
                Close();
            }
            else if(result.Code==RES.ERROR)
            {
                MessageBox.Show(result.Message, "添加用户");
            }
        }
    }
}
