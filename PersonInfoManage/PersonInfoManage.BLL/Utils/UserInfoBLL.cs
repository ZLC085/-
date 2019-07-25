using PersonInfoManage.DAL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.BLL.Utils
{
    /// <summary>
    /// 获取运行时的用户信息
    /// </summary>
    public class UserInfoBLL
    {
        public static int UserId
        {
            get
            {
                return UserInfoDAL.UserId;
            }
        }

        public static string UserName
        {
            get
            {
                return UserInfoDAL.UserName;
            }
        }
    }
}
