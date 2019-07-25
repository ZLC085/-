using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Utils
{
    /// <summary>
    /// 日志操作
    /// </summary>
    public class LogOperations
    {
        /// <summary>
        /// 系统日志
        /// </summary>
        /// <param name="logMessage">日志内容</param>
        /// <returns>log_sys</returns>
        public static log_sys LogSys(string logMessage)
        {
            log_sys logSys = new log_sys
            {
                create_time = DateTime.Now,
                log_message = logMessage
            };

            return logSys;
        }

        /// <summary>
        /// 用户日志
        /// </summary>
        /// <param name="operation">用户操作内容</param>
        /// <returns>log_user</returns>
        public static log_user LogUser(string operation)
        {
            log_user logUser = new log_user
            {
                username = UserInfoDAL.UserName,
                user_id = UserInfoDAL.UserId,
                operation = operation,
                create_time = DateTime.Now,
                ip = IpAddress
            };

            return logUser;
        }

        private static string IpAddress
        {
            get
            {
                string ip = "";
                foreach (var i in Dns.GetHostAddresses(Dns.GetHostName()))
                {
                    if (i.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ip = i.ToString();
                    }
                }

                return ip;
            }
        }
    }
}
