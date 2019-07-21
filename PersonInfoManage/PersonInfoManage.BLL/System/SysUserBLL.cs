using System.Collections.Generic;
using System.Linq;
using PersonInfoManage.DAL.System;
using PersonInfoManage.Model;
using PersonInfoManage.BLL.Utils;

namespace PersonInfoManage.BLL.System
{
   public class SysUserBLL
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>影响行数</returns>
        public Result add(sys_user user)
        {
            SysUserDAL Sysuser = new SysUserDAL();
            Result res = new Result();
            try
            {
                if (Sysuser.Add(user) == 0)
                {
                    res.Code = RES.ERROR;
                    res.Message = "添加失败！";
                    return res;
                }
                else
                {
                    res.Code = RES.OK;
                    res.Message = "添加成功！";
                    return res;
                }
            }
            catch
            {
                res.Code = RES.ERROR;
                res.Message = "添加失败！";
                return res;
            }
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>影响行数</returns>
        public Result Update(sys_user user)
        {
            SysUserDAL Sysuser = new SysUserDAL();
            Result res = new Result();
            try
            {
                if (Sysuser.Update(user) == 0)
                {
                    res.Code = RES.ERROR;
                    res.Message = "修改失败！";
                    return res;
                }
                else
                {
                    res.Code = RES.OK;
                    res.Message = "修改成功！";
                    return res;
                }
            }
            catch
            {
                res.Code = RES.ERROR;
                res.Message = "修改失败！";
                return res;
            }
        }


        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="UserId">用户id</param>
        /// <returns>影响行数</returns>
        public Result Del(int UserId)
        {
            SysUserDAL Sysuser = new SysUserDAL();
            PermDAL group = new PermDAL();
            Result res = new Result();
            try
            {
                if (group.Delu2g(UserId) == 0)
                {
                    Sysuser.Del(UserId);
                    res.Code = RES.ERROR;
                    res.Message = "删除失败！";
                    return res;
                }
                else
                {
                    res.Code = RES.OK;
                    res.Message = "删除成功！";
                    return res;
                }
            }
            catch
            {
                res.Code = RES.ERROR;
                res.Message = "删除失败！";
                return res;
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
