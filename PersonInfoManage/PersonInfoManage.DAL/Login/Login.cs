using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Login
{
    /// <summary>
    /// 登录
    /// </summary>
    public class Login
    {
        /// <summary>
        /// 登陆时，通过用户名查询用户信息
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>用户信息</returns>
        public List<sys_user> SelectLoginInfoByUserName(string userName)
        {
            Dictionary<string, object> conditions = new Dictionary<string, object>
            {
                { nameof(sys_user), userName }
            };

            return new DBOperationsSelect<sys_user>().SelectByConditions(conditions);
        }
    }
}
