using PersonInfoManage.BLL.Login;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static PersonInfoManage.LocalUserInfo;
using PersonInfoManage.Model;
using PersonInfoManage.BLL.System;
using Loading;

namespace PersonInfoManage
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoadUserName();
            loginTipLabel.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = UserNameTextBox.Text;
            string psd = PsdTextBox.Text;
            string md5psd = psd;//MD5Psd(psd);
            if (userName == "")
            {
                loginTipLabel.Text = "用户名不能为空！";
                return;
            }
            else if(psd=="")
            {
                loginTipLabel.Text = "密码不能为空！";
                return;
            }
            LoginBLL loginBLL = new LoginBLL();
            bool res=loginBLL.Login(userName, md5psd);

            if (res == true)
            {
                if (SaveUserInfoToLocal()) {
                    new Thread(() => Application.Run(new MainForm())).Start();
                    Close();
                }
            }
            else
            {
                loginTipLabel.Text = "用户名或密码错误！";
            }
        }

        

        private void LoadUserName()
        {
            User user = LoginInfo;

            if (user != null)
            {
                UserNameTextBox.Text = user.UserName;
                remUserNamecheckBox.Checked = user.IsChecked;
            }
        }

        private bool SaveUserInfoToLocal()
        {
            bool flag = true;

            if (remUserNamecheckBox.Checked)
            {
                if (UserNameTextBox.Text == "")
                {
                    loginTipLabel.Text = "用户名不能为空！";
                    flag = false;
                }
                else
                {
                    List<view_sys_u2g> userinfo = new List<view_sys_u2g>();
                    sys_user user1 = new sys_user();
                    SysUserBLL userbll = new SysUserBLL();
                    user1.username = UserNameTextBox.Text;
                    userinfo = userbll.Select(user1);
                    int id;
                    foreach (var user2 in userinfo)
                    {
                        id = user2.id;
                        string idcode = userinfo[0].ToString();
                        User user = new User()
                        {
                            UserName = UserNameTextBox.Text,
                            UserId = id,
                            IsChecked = true,
                        };
                        LoginInfo = user;    //尚未测试
                    } 
                }
            }
            else
            {
                if (loginTipLabel.Text != "") loginTipLabel.Text = "";

                LoginInfo = new User { IsChecked = false };
            }

            return flag;
        }

        private string MD5Psd(string psd)
        {
            MD5 mD5 = MD5.Create();
            byte[] b = mD5.ComputeHash(Encoding.UTF8.GetBytes(psd));

            string md5psd = "";

            foreach (byte item in b)
            {
                md5psd += item.ToString();
            }

            return md5psd;
        }
    }
}
