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
    class LogUserBLL
    {
        /// <summary>
        /// 用户日志删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Result Del(int id)
        {
            Result r = new Result();
            if (new DAL.Logs.LogUserDAL().Del(id)>0)
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
        /// 用户日志，根据条件（用户名，时间）查询
        /// </summary>
        /// <param name="username"></param>
        /// <param name="create_time"></param>
        /// <returns></returns>
        public List<log_user> Query(Dictionary<string, object> conditions)
        {
            List<log_user> userList = new DAL.Logs.LogUserDAL().GetByConditionns(conditions);
            if (userList == null)
            {
                Console.WriteLine("没有查到相关信息！");
            }
            return userList;
        }

    }
}
