using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.IDAL.Login
{
    public interface ILogin
    {
        /// <summary>
        /// 是否允许登录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>bool，是否允许登录</returns>
        bool IsAllowLogin(string userName,string password);
    }
}
