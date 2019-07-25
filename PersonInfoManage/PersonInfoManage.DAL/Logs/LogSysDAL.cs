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
    /// 系统运行日志
    /// </summary>
    public class LogSysDAL : DALBase
    {


	/// <summary>
        /// 系统运行日志添加
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        public  int Add(log_sys sys)
        {
            int res = 0;
            string sql = "insert  into log_user(log_message,create_time) values (@log_message,@create_time)";
            SqlParameter log_message = new SqlParameter("@log_message", sys.log_message);          
            SqlParameter create_time = new SqlParameter("@create_time", DateTime.Now);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, log_message, create_time);
            return res;
        }

        /// <summary>
        /// 系统运行日志删除
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>删除条数</returns>
            public  int Del(int id)
        {
            int res;
            string sql = "delete from log_sys where id='"+id+"' ";
            res = SqlHelper.ExecuteNonQuery(ConStr,CommandType.Text,sql);
            return res;
        }
        /// <summary>
        /// 系统运行日志查询，所有
        /// </summary>
        /// <returns>所有系统运行日志</returns>
        public List<log_sys> Query()
        {
            List<log_sys> logsys = new List<log_sys>();
            string sql = "select * from log_sys";
            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                log_sys sys = new log_sys();
                sys.id = (int)ds.Tables[0].Rows[i][nameof(log_sys.id)];
                sys.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(log_sys.create_time)];
                sys.log_message = (string)ds.Tables[0].Rows[i][nameof(log_sys.log_message)];
                logsys.Add(sys);
            }
            return logsys;
            // return new DBOperationsSelect<log_sys>().SelectAll();
        }

        /// <summary>
        /// 通过输入条件查询系统运行日志
        /// </summary>
        /// <param name="conditions">输入条件</param>
        /// <returns>系统运行日志</returns>
        public List<log_sys> Query(DateTime start_time,DateTime end_time)
        {
            List<log_sys> syslog = new List<log_sys>();
            if (start_time.CompareTo(new DateTime(1, 1, 1)) == 0)//如果输入起始时间为空，则默认起始时间为2000年1月1日
            {
                start_time = new DateTime(2000, 1, 1);
            }
            if (end_time.CompareTo(new DateTime(1, 1, 1)) == 0)//如果输入终止时间为空，则默认起始时间为6000年12月31日
            {
                end_time = new DateTime(6000, 12, 31);
            }
            string sql = "select * from log_sys where create_time>='"+new DateTime(start_time.Year, start_time.Month, start_time.Day,0,0,0)+"'and create_time<='"+new DateTime(end_time.Year, end_time.Month, end_time.Day,23,59,59) +"'";
           // Console.WriteLine(sql);
            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                log_sys sys = new log_sys();
                sys.id = (int)ds.Tables[0].Rows[i][nameof(log_sys.id)];
                sys.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(log_sys.create_time)];
                sys.log_message = (string)ds.Tables[0].Rows[i][nameof(log_sys.log_message)];
                syslog.Add(sys);
            }
            return syslog;
        }     
    }
}