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
        private int Id;
        public UpdateUserForm(List<int> idlist)
        {
            foreach (var userid in idlist)
            {
                Id = userid;
            }
            InitializeComponent();
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            //List<sys_org> orginfo = new List<sys_org>();
            ////orginfo =
            //comboBox1.DataSource = orginfo;
            //comboBox1.DisplayMember = "org_name";
            SysUserBLL sysUserBLL = new SysUserBLL();
            List<view_sys_u2g> userinfo = new List<view_sys_u2g>();
            userinfo = sysUserBLL.SelectById(Id);
            foreach(var user in userinfo)
            {
                textBoxX1.Text = user.name;
                textBoxX2.Text = user.username;
                if (user.gender == "男")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                textBoxX4.Text = user.phone;
                textBoxX5.Text = user.email;
                textBoxX6.Text = user.job;
                //职位
                if (user.status)
                {
                    radioButton4.Checked = true;
                }
                else
                {
                    radioButton3.Checked = true;
                }
            }           
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
            if (radioButton3.Checked)
            {
                sys_User.status = false;
            }
            else
            {
                sys_User.status = true;
            }
            SysUserBLL sysUserBLL = new SysUserBLL();
            Result result = sysUserBLL.add(sys_User);

            if (result.Code == RES.OK)
            {
                MessageBoxCustom.Show("修改成功", "提示", MessageBoxButtons.OK, this);
                Close();
            }
            else if (result.Code == RES.ERROR)
            {
                MessageBoxCustom.Show("修改失败", "提示", MessageBoxButtons.OK, this);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }
