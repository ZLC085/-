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
    public partial class GroupManageForm : Form
    {
        public GroupManageForm()
        {
            InitializeComponent();
        }

        private void GroupManageForm_Load(object sender, EventArgs e)
        {
            dataGridViewX1.AutoGenerateColumns = false;
            dataGridViewX1.DataSource = new PermBLL().SelectU2g(21); 
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            AddUserToGroupForm AddForm = new AddUserToGroupForm();
            AddForm.ShowDialog();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBoxCustom.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo, this);
            if (res == DialogResult.Yes)
            {
                int groupid = 0;//待定
                sys_user user = new sys_user();
                user.username = "test";
                user.name = "test";
                List<view_sys_u2g> userinfo = new List<view_sys_u2g>();
                userinfo = new SysUserBLL().Select(user);
                List<int> userid = new List<int>();
                foreach (var user1 in userinfo)
                {

                    userid.Add(user1.id);
                }
                Result result = new PermBLL().DelG2u(groupid, userid);
                if (result.Code == RES.OK)
                {
                    MessageBoxCustom.Show("删除成功", "提示", MessageBoxButtons.OK, this);
                    Close();
                }
                else if (result.Code == RES.ERROR)
                {
                    MessageBoxCustom.Show("删除失败", "提示", MessageBoxButtons.OK, this);
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

