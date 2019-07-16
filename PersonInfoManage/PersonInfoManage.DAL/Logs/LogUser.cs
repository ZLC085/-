using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Logs
{
    /// <summary>
    /// 用户日志
    /// </summary>
    public class LogUser
    {
        /// <summary>
        /// 用户日志查询，所有
        /// </summary>
        /// <returns>所有用户日志</returns>
        public List<log_user> SelectAllLogUser()
        {
            return new DBOperationsSelect<log_user>().SelectAll();
        }

        /// <summary>
        /// 通过输入条件查询用户日志
        /// </summary>
        /// <param name="conditions">输入条件</param>
        /// <returns>通过输入条件查询到的用户日志</returns>
        public List<log_user> SelectLogUserByConditions(Dictionary<string, object> conditions)
        {
            return new DBOperationsSelect<log_user>().SelectByConditions(conditions);
        }

        /// <summary>
        /// 用户日志删除
        /// </summary>
        /// <param name="id">用户日志id</param>
        /// <returns>删除条数</returns>
        public int DeleteUserLogByUserName(int id)
        {
            return new DBOperationsDelete<log_user, DBNull>().DeleteById(id);
        }
    }
}
