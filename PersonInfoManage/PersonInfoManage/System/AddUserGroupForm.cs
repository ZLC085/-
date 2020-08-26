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
    public partial class AddUserGroupForm : Form
    {
        private int number;
        public AddUserGroupForm(List<int> list)
        {
           
            
            foreach(var a in list)
            {
                number = a;              
            }
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
                Result result = new Result();
               result= perm.Add(group);
                if (result.Message == "添加成功！")
                {
                    MessageBoxCustom.Show("添加成功", "提示",this);
                }
                else
                {
                    MessageBoxCustom.Show("添加失败", "提示",this);
                }
               
            }
            else
            {
               
                PermBLL perm = new PermBLL();
               sys_group group1 = new sys_group();
                group1.group_name = textBoxX1.Text;
                group1.remark = textBoxX2.Text;
                group1.id = number;
                       
                Result result = new Result();
                result = perm.Update(group1);
                if (result.Message == "修改成功！")
                {
                    MessageBoxCustom.Show("修改成功", "提示", this);
                }else
                {
                    MessageBoxCustom.Show("修改失败", "提示", this);
                }
                
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddUserGroupForm_Load(object sender, EventArgs e)
        {

            PermBLL perm = new PermBLL();
            List<sys_group> group = new List<sys_group>();
            group = perm.SelectGroupByID(number);
            foreach (var z in group)
            {
                textBoxX1.Text = z.group_name;
                textBoxX2.Text = z.remark;
            }
        }
    }
}
