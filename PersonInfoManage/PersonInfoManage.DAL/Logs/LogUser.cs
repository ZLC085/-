using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Logs
{
    /// <summary>
    /// 用户日志
    /// </summary>
    public class LogUser:DALBase
    {
        /// <summary>
        /// 用户日志查询，所有
        /// </summary>
        /// <returns>所有用户日志</returns>
        public List<log_user> SelectAllLogUser()
        {
            List<log_user> loguser = new List<log_user>();

            string sql = "select * from log_user ";
            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                log_user user = new log_user();
                user.id = int.Parse((string)ds.Tables[0].Rows[0][nameof(log_user.id)]);
                user.user_id = int.Parse((string)ds.Tables[0].Rows[0][nameof(log_user.user_id)]);
                user.username = (string)ds.Tables[0].Rows[0][nameof(log_user.username)];
                user.operation = (string)ds.Tables[0].Rows[0][nameof(log_user.operation)];
                user.ip = (string)ds.Tables[0].Rows[0][nameof(log_user.ip)];
                user.create_time = (DateTime)ds.Tables[0].Rows[0][nameof(log_user.create_time)];
                loguser.Add(user);
            }

            return loguser;
        }
        /// <summary>
        /// 通过输入条件查询用户日志
        /// </summary>
        /// <param name="conditions">输入条件</param>
        /// <returns>通过输入条件查询到的用户日志</returns>
        public List<log_user> SelectLogUserByConditions(Dictionary<string, object> conditions)
        {
            List<log_user> loguser = new List<log_user>();
            log_user user = new log_user();
            string sql = "select * from log_user where conditions='" + conditions + "' ";

            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);

            user.id = int.Parse((string)ds.Tables[0].Rows[0][nameof(log_user.id)]);
            user.user_id = int.Parse((string)ds.Tables[0].Rows[0][nameof(log_user.user_id)]);
            user.username = (string)ds.Tables[0].Rows[0][nameof(log_user.username)];
            user.operation = (string)ds.Tables[0].Rows[0][nameof(log_user.operation)];
            user.ip = (string)ds.Tables[0].Rows[0][nameof(log_user.ip)];
            user.create_time = (DateTime)ds.Tables[0].Rows[0][nameof(log_user.create_time)];

            loguser.Add(user);
            return loguser;
            //return new DBOperationsSelect<log_user>().SelectByConditions(conditions);
        }

        /// <summary>
        /// 用户日志删除
        /// </summary>
        /// <param name="id">用户日志id</param>
        /// <returns>删除条数</returns>
        public int DeleteUserLogByUserName(log_user userlog)
        {
            int result;
            string Del = "delete from log_user where id=@id";
            SqlParameter sqlParameter = new SqlParameter("@id", userlog.id);
            result = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, Del, sqlParameter);
            return result;
        }
    }
}
