using PersonInfoManage.BLL.System;
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
    public partial class AddUserGroupForm : Form
    {
        public AddUserGroupForm()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (Text.Equals("添加用户组"))
            {
                sys_group group = new sys_group();
                group.group_name = textBoxX1.Text;
                group.remark = textBoxX2.Text;
                PermBLL perm = new PermBLL();
                perm.Add(group);
                MessageBoxCustom.Show("添加成功", "提示", this);
            }
            else
            {
                sys_group group = new sys_group();
                group.group_name = textBoxX1.Text;
                group.remark = textBoxX2.Text;
                PermBLL perm = new PermBLL();
                perm.Update(group);
                MessageBoxCustom.Show("修改成功", "提示", this);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
