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
    /// 系统运行日志
    /// </summary>
    public class LogSys
    {
        /// <summary>
        /// 系统运行日志查询，所有
        /// </summary>
        /// <returns>所有系统运行日志</returns>
        public List<log_sys> SelectAllLogSys()
        {
            return new DBOperationsSelect<log_sys>().SelectAll();
        }

        /// <summary>
        /// 通过输入条件查询系统运行日志
        /// </summary>
        /// <param name="conditions">输入条件</param>
        /// <returns>系统运行日志</returns>
        public List<log_sys> SelectLogSysByConditions(Dictionary<string, object> conditions)
        {
            return new DBOperationsSelect<log_sys>().SelectByConditions(conditions);
        }

        /// <summary>
        /// 系统运行日志删除
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>删除条数</returns>
        public int DeleteLogSysById(int id)
        {
            return new DBOperationsDelete<log_sys,DBNull>().DeleteById(id);
        }
    }
}
