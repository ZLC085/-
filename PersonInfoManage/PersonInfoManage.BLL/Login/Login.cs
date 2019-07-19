using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonInfoManage.DAL.Login;
using PersonInfoManage.Model;

namespace PersonInfoManage.BLL.Login
{
    public class  Login
    {
        public int Loginsever(sys_user user)
        {
            DAL.Login.Login login = new DAL.Login.Login();
            string password = login.SelectLogin(user);
            if(password == user.password)
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
