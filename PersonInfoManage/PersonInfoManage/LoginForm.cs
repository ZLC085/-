using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static PersonInfoManage.LocalUserInfo;

namespace PersonInfoManage
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoadUserName();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = UserNameTextBox.Text;
            string psd = PsdTextBox.Text;

            string md5psd = MD5Psd(psd);

            if ("aa" == "aa")
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
                    flag= false;
                }
                else
                {
                    User user = new User
                    {
                        UserName = UserNameTextBox.Text,
                        UserId=111,//查询得到
                        IsChecked = true
                    };
                    LoginInfo = user;
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
