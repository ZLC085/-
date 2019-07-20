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
        public bool add(sys_user user)
        {
            SysUserDAL Sysuser = new SysUserDAL();
            try
            {
                Sysuser.Add(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>影响行数</returns>
        public bool Update(sys_user user)
        {
            SysUserDAL Sysuser = new SysUserDAL();
            try
            {
                Sysuser.Update(user);
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="UserId">用户id</param>
        /// <returns>影响行数</returns>
        public bool Del(int UserId)
        {
            SysUserDAL Sysuser = new SysUserDAL();
            PermDAL group = new PermDAL();
            try
            {
                group.Delu2g(UserId);
                Sysuser.Del(UserId);
                return true;
            }
            catch
            {
                return false;
            }
        }
         
        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="UserInfo">查询条件</param>
        /// <returns>用户信息</returns>
        public List<view_sys_u2g> Select(sys_user UserInfo)
        {
            SysUserDAL Sysuser = new SysUserDAL();
            return Sysuser.Select(UserInfo);
        }
    }
}
