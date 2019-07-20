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
        /// <param name="userName">用户名</param>
        /// <returns>用户信息</returns>
        public string SelectLogin(string username)
        {
            sys_user user = new sys_user();
            string sql = "select * from sys_user where username='" + username + "'";
            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            user.password= (string)ds.Tables[0].Rows[0][nameof(sys_user.password)];  
            return user.password;
            //Dictionary<string, object> conditions = new Dictionary<string, object>
            //{
            //    { nameof(sys_user), userName }
            //};
            //return new DBOperationsSelect<sys_user>().SelectByConditions(conditions);
        }
    }
}