using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonInfoManage.DAL.Login;
using PersonInfoManage.Model;

namespace PersonInfoManage.BLL.Login
{
    public class LoginBLL
    {
        public bool Login(string userName,string password)
        {
            LoginDAL login = new LoginDAL();
            string password1 = login.SelectLogin(userName);
            if (password.Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
