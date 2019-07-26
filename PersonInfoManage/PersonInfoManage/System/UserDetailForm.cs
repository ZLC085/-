﻿using PersonInfoManage.BLL.System;
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
    public partial class UserDetailForm : Form
    {
        public UserDetailForm()
        {
            InitializeComponent();
        }

        private void UserDetailForm_Load(object sender, EventArgs e)
        {
            int UserId =32 ;//未赋值
            List<view_sys_u2g> userinfo = new List<view_sys_u2g>();
            userinfo =new SysUserBLL().SelectById(UserId);
            foreach(var user in userinfo)
            {
                labelX8.Text = user.name;
                labelX9.Text = user.username;
                labelX10.Text = user.gender;
                labelX12.Text = user.phone;
                labelX13.Text = user.email;
                labelX14.Text = user.job;
            }
        }
    }
}
