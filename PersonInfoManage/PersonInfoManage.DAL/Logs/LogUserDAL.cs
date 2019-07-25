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
    /// </summary 
    public class LogUserDAL : DALBase
    {

        /// <summary>
        /// 日志添加
        /// 字段：id，user_id,username,operation,ip,create_time
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        /// 

        public int Add(log_user user)
        {
   
            int res = 0;
            string sql = "insert  into log_user(user_id,username,operation,ip,create_time) values (@user_id,@username,@operation,@ip,@create_time)";
            SqlParameter user_id = new SqlParameter("@user_id", user.user_id);
            SqlParameter username = new SqlParameter("@username", user.username);
            SqlParameter operation = new SqlParameter("@operation", user.operation);
            SqlParameter ip = new SqlParameter("@ip", user.ip);
            SqlParameter create_time = new SqlParameter("@create_time", DateTime.Now);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, user_id, username, operation, ip, create_time);
            return res;

        }
        /// <summary>
        /// 用户日志删除根据日志ID
        /// </summary>
        /// <param name="id">用户日志id</param>
        /// <returns>删除条数</returns>
        public int Del(int id)
        {
            int res;
            string sql = "delete from log_user where id='" + id + "'";
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
            return res;
        }

        /// <summary>
        /// 用户日志删除根据用户ID
        /// </summary>
        /// <param name="UserId">用户id</param>
        /// <returns>删除条数</returns>
        public int DelUser(int UserId)
        {
            int res;
            string sql = "delete from log_user where user_id='" + UserId + "'";
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
            return res;
        }

        /// <summary>
        /// 用户日志查询，所有
        /// </summary>
        /// <returns>所有用户日志</returns>
        public List<log_user> Query()
        {
            List<log_user> loguser = new List<log_user>();
            string sql = "select * from log_user ";
            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                log_user user = new log_user();
                user.id = (int)ds.Tables[0].Rows[i][nameof(log_user.id)];
                user.user_id = (int)ds.Tables[0].Rows[i][nameof(log_user.user_id)];
                user.username = (string)ds.Tables[0].Rows[i][nameof(log_user.username)];
                user.operation = (string)ds.Tables[0].Rows[i][nameof(log_user.operation)];
                user.ip = (string)ds.Tables[0].Rows[i][nameof(log_user.ip)];
                user.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(log_user.create_time)];
                loguser.Add(user);
            }
            return loguser;
        }


        /// <summary>
        /// 通过输入条件查询用户日志
        /// </summary>
        /// <param name="conditions">输 入条件</param>
        /// <returns>通过输入条件查询到的用户日志</returns>
        ///    用户名，操作（模糊查询），起始时间，终止时间
        public List<log_user> Query(string username, string operation, DateTime start_time,DateTime end_time)
        {
            List<log_user> userlog = new List<log_user>();
            if (start_time.CompareTo(new DateTime(1, 1, 1)) == 0)//如果输入起始时间为空，则默认起始时间为2000年1月1日
            { 
               start_time = new DateTime(2000, 1, 1);
            }
            if (end_time.CompareTo(new DateTime(1, 1, 1)) == 0)//如果输入终止时间为空，则默认起始时间为6000年12月31日
            {
                end_time = new DateTime(6000, 12, 31);
            }
            string sql = "select * from log_user where username like N'%" + username + "%'and operation like N'%" + operation + "%' and create_time>='" + new DateTime(start_time.Year, start_time.Month, start_time.Day, 0, 0, 0) + "'and create_time<='" + new DateTime(end_time.Year, end_time.Month, end_time.Day, 23, 59, 59) + "'";
           
            Console.WriteLine(sql);
            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                log_user user = new log_user();
                user.id = (int)ds.Tables[0].Rows[i][nameof(log_user.id)];
                user.user_id = (int)ds.Tables[0].Rows[i][nameof(log_user.user_id)];
                user.username = (string)ds.Tables[0].Rows[i][nameof(log_user.username)];
                user.operation = (string)ds.Tables[0].Rows[i][nameof(log_user.operation)];
                user.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(log_user.create_time)];
                user.ip = (string)ds.Tables[0].Rows[i][nameof(log_user.ip)];
                userlog.Add(user);
            }
            
            return userlog;
        }      

    }
       
 }
















