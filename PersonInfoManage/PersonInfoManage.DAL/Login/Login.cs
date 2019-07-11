using PersonInfoManage.IDAL.Login;
using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Login
{
    public class Login : ILogin
    {
        /// <summary>
        /// 是否允许登录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>bool，是否允许登录</returns>
        public bool IsAllowLogin(string userName, string password)
        {
            return true;
        }
    }
}
