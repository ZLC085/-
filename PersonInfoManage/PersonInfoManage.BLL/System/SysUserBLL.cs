using System.Collections.Generic;
using System.Linq;
using PersonInfoManage.DAL.System;
using PersonInfoManage.Model;

namespace PersonInfoManage.BLL.System
{
    class SysUserBLL
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>影响行数</returns>
        public int add(sys_user user)
        {
            SysUserDAL login = new SysUserDAL();
            return login.add(user);
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>影响行数</returns>
        public int Update(sys_user user)
        {
            SysUserDAL login = new SysUserDAL();
            return login.Update(user);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="user_id">用户id</param>
        /// <returns>影响行数</returns>
        public int Del(int user_id)
        {
            SysUserDAL login = new SysUserDAL();
            return login.Del(user_id);
        }

        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="u2g"></param>
        /// <returns>用户信息</returns>
        public List<view_sys_u2g> Select(sys_user user)
        {
            SysUserDAL login = new SysUserDAL();
            return login.Select(user);
        }
    }
}
