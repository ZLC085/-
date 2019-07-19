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
    public class LogUser : DALBase
    {
        /// <summary>
        /// 用户日志删除
        /// </summary>
        /// <param name="id">用户日志id</param>
        /// <returns>删除条数</returns>
        public int Del(log_user userlog)
        {
            int result;
            string Del = "delete from log_user where id=@id";
            SqlParameter sqlParameter = new SqlParameter("@id", userlog.id);
            result = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, Del, sqlParameter);
            return result;
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
        /// <param name="conditions">输入用户名</param>
        /// <returns>通过输入条件查询到的用户日志</returns>
        public List<log_user> GetByUserName(string username)
        {

            string sql = "select * from log_user where username='" + username + "'";
            List<log_user> loguser = new List<log_user>();
            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
          
                log_user user = new log_user();
                user.id = (int)ds.Tables[0].Rows[0][nameof(log_user.id)];
                user.user_id =(int)ds.Tables[0].Rows[0][nameof(log_user.user_id)];
                user.username = (string)ds.Tables[0].Rows[0][nameof(log_user.username)];
                user.operation = (string)ds.Tables[0].Rows[0][nameof(log_user.operation)];
                user.ip = (string)ds.Tables[0].Rows[0][nameof(log_user.ip)];
                user.create_time = (DateTime)ds.Tables[0].Rows[0][nameof(log_user.create_time)];
                loguser.Add(user);
            
            return loguser;
        }

        /// <summary>
        /// 通过输入条件查询用户日志
        /// </summary>
        /// <param name="conditions">输入时间段</param>
        /// <returns>通过输入时间段查询到的用户日志</returns>    

        //public List<log_user> GetByTimeQuantum(string CBeginYear, string CBeginMouth, string CBeginDay, string CEndYear, string CEndMouth, string CEndDay)
        //{


        //    string strBack = "";
        //    string strBegin = CBeginYear + "-" + CBeginMouth + "-" + CBeginDay+"   "+"00:00:00";
        //    string strEnd = CEndYear + "-" + CEndMouth + "-" + CEndDay + "   "+"23:59:59";
        //    strBack += strBegin + " AND " + strEnd;

        //   // string sql = "select * from log_user where create_time between strBegin and strEnd";
        //    string sql1= "select * from log_user where create_time between (yyyy-mm-dd) and (yyyy-mm-dd)";
        //    List<log_user> loguser = new List<log_user>();
        //    DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text,sql1);

        //    log_user user = new log_user();
        //    user.id = (int)ds.Tables[0].Rows[0][nameof(log_user.id)];
        //    user.user_id = (int)ds.Tables[0].Rows[0][nameof(log_user.user_id)];
        //    user.username = (string)ds.Tables[0].Rows[0][nameof(log_user.username)];
        //    user.operation = (string)ds.Tables[0].Rows[0][nameof(log_user.operation)];
        //    user.ip = (string)ds.Tables[0].Rows[0][nameof(log_user.ip)];
        //    user.create_time = (DateTime)ds.Tables[0].Rows[0][nameof(log_user.create_time)];
        //    loguser.Add(user);

        //    return loguser;
        //}






    }
}
