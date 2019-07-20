using PersonInfoManage.DAL.Logs;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.BLL.logs
{
    class LogSysBLL
    {
        /// <summary>
        /// 系统日志删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Del(int id)
        {
            bool a = false;
            LogSysDAL logsys = new LogSysDAL();
            List<log_sys> sysList = new List<log_sys>();
            if (logsys.Del(id) == sysList.Count)
                a = true;
            return a;
        }




    }
}
