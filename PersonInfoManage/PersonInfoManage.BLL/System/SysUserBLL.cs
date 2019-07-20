using System.Collections.Generic;
using System.Linq;
using PersonInfoManage.DAL.System;
using PersonInfoManage.Model;

namespace PersonInfoManage.BLL.System
{
    class SysUserBLL
    {
        public int add(sys_user user)
        {
            SysUserDAL login = new SysUserDAL();
            return login.add(user);
        }

        public int Update(sys_user user)
        {
            SysUserDAL login = new SysUserDAL();
            return login.Update(user);
        }

        public int Del(int user_id)
        {
            SysUserDAL login = new SysUserDAL();
            return login.Del(user_id);
        }

        public List<view_sys_u2g> Select(view_sys_u2g u2g)
        {
            SysUserDAL login = new SysUserDAL();
            return login.Select(u2g);
        }
    }
}
