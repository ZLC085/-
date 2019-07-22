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
        public List<log_sys> Query(DateTime create_time)
        {
            List<log_sys> syslog = new List<log_sys>();                 
            string sql = "select * from log_sys where create_time>='"+new DateTime(create_time.Year, create_time.Month, create_time.Day,0,0,0)+"'and create_time<='"+new DateTime(create_time.Year, create_time.Month, create_time.Day,23,59,59) +"'";
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
        //public List<log_sys> GetByConditionns(Dictionary<string, object> conditions)
        //{
        //    string[] keys = new string[] { "create_time", "start_time", "end_time" };
        //    List<log_sys> sysList = new List<log_sys>();
        //    List<string> listKey = new List<string>();
        //    foreach (string key in conditions.Keys)
        //    {
        //        if (keys.Contains(key))
        //        {
        //            listKey.Add(key);
        //        }
        //    }
        //    string sql = "select * from log_sys where ";
        //    foreach (string key in listKey)
        //    {
        //        if (!key.Equals(listKey.First()))
        //        {
        //            sql += " and ";
        //        }
        //        if (key.Equals("create_time"))
        //        {
        //            DateTime st = new DateTime();
        //            sql += " create_time >='" + new DateTime(st.Year,st.Month,st.Day,0,0,0) + "'";
        //        }
        //        else 
        //        {
        //            DateTime et = new DateTime();
        //            sql += " create_time <='" + new DateTime(et.Year,et.Month,et.Day,23,59,59) + "'";
        //        }               
        //    }
        //    Console.WriteLine(sql);
        //    DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
        //    DataTable dt = ds.Tables[0];
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        log_sys logsys = new log_sys();
        //        logsys.id = (int)dt.Rows[i]["id"];
        //        logsys.create_time = (DateTime)dt.Rows[i]["create_time"];
        //        logsys.log_message = (string)dt.Rows[i]["log_message"];
        //        sysList.Add(logsys);
        //    }
        //    return sysList;
        //    // return new DBOperationsSelect<log_sys>().SelectByConditions(conditions);
        //}


    }
}