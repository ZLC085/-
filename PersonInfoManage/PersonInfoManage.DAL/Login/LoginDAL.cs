using PersonInfoManage.DAL.Logs;
using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Login
{
    /// <summary>
    /// 登录
    /// </summary>
    public class LoginDAL:DALBase
    {
        /// <summary>
        /// 登陆时，通过用户名查询用户信息
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns>用户信息</returns>
        public string SelectLogin(string UserName)
        {
            sys_user user = new sys_user();
            string sql = "select * from sys_user where username='" + UserName + "'";
            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            user.password= (string)ds.Tables[0].Rows[0][nameof(sys_user.password)];
            string username = (string)ds.Tables[0].Rows[0][nameof(sys_user.username)];
            int id = (int)ds.Tables[0].Rows[0][nameof(sys_user.id)];

            LogOperations.UserId = id;
            LogOperations.UserName = username;

            new LogUserDAL().Add(LogOperations.LogUser("登录"));

            return user.password;
        }
    }
}