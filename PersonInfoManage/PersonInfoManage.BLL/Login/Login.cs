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
        public int Loginsever(sys_user user)
        {
            DAL.Login.LoginDAL login = new DAL.Login.LoginDAL();
            string password = login.SelectLogin(user.username);
            if (password == user.password)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
