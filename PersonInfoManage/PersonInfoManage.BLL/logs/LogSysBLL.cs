using PersonInfoManage.BLL.Utils;
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
        public Result Del(int id)
        {
            Result r = new Result();
            if (new DAL.Logs.LogSysDAL().Del(id) > 0)
            {
                r.Code = RES.OK;
                r.Message = "删除成功！";
            }
            else
            {
                r.Code = RES.ERROR;
                r.Message = "删除失败！";
            }
            return r;
        }
        /// <summary>
        /// 系统日志查询
        /// 条件：时间段
        /// </summary>
        /// <param name="conditions"></param>
        /// <returns></returns>
        public List<log_sys> Query(Dictionary<string, object> conditions)
        {
            List<log_sys> userList = new DAL.Logs.LogSysDAL().Query(new DateTime());
            if (userList == null)
            {
                Console.WriteLine("没有查到相关信息！");
            }
            return userList;
        }


    }
}
