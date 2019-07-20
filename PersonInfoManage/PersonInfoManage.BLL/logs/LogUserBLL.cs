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
        public bool Del(int id)
        {
            bool a = false;
            LogUserDAL loguser = new LogUserDAL();
            List<log_user> userList = new List<log_user>();
            if (loguser.Del(id) == userList.Count)         
                a = true;        
            return a;
        }
        /// <summary>
        /// 用户日志，根据条件（用户名，时间）查询
        /// </summary>
        /// <param name="username"></param>
        /// <param name="create_time"></param>
        /// <returns></returns>
        //public bool GetByName(string username)
        //{
        //    bool a = false;
        //    LogUserDAL loguser = new LogUserDAL();
        //    List<log_user> userList = new List<log_user>();
        //    if (loguser.)
        //    {

        //    }



        //    return a;
        //}

    }
}
