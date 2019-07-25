using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonInfoManage.DAL.System;
using PersonInfoManage.Model;
using PersonInfoManage.BLL.Utils;
using PersonInfoManage.DAL.Logs;
using PersonInfoManage.DAL.Utils;

namespace PersonInfoManage.BLL.System
{
     public class PermBLL
    {
        /// <summary>
        /// 添加用户组
        /// </summary>
        /// <param name="group"></param>
        /// <returns>执行结果</returns>
        public Result Add(sys_group group)
        {
            Result res = new Result();
            PermDAL perm = new PermDAL();
            try
            {
                if (perm.Add(group) == 0)
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
        /// 用户组信息修改
        /// </summary>
        /// <param name="group">用户组信息</param>
        /// <returns>执行结果</returns>
        public Result Update(sys_group group)
        {
            PermDAL perm = new PermDAL();
            Result res = new Result();
            try
            {
                if (perm.Update(group) == 0)
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
        /// 删除用户组
        /// </summary>
        /// <param name="id"></param>
        /// <returns>执行结果</returns>
        public Result Del(int id)
        {
            PermDAL perm = new PermDAL();
            Result res = new Result();
            try
            {

                perm.Del(id);
                res.Code = RES.OK;
                res.Message = "删除成功！";
                return res;
            }
            catch
            {
                res.Code = RES.ERROR;
                res.Message = "删除失败！";
                return res;
            }
        }

        /// <summary>
        /// 查询用户组
        /// </summary>
        /// <param name="group">查询条件</param>
        /// <returns>用户组信息</returns>
        public List<sys_group> SelectGroup(sys_group group)
        {
            PermDAL perm = new PermDAL();
            return perm.SelectGroup(group);
        }

        /// <summary>
        /// 添加用户进用户组
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="groupId"></param>
        /// <returns>执行结果</returns>
        public Result AddU2g(int groupId, List<int> user_id)
        {
            Result res = new Result();
            PermDAL perm = new PermDAL();
            try
            {
                foreach (var userId in user_id)
                {
                    perm.AddU2g(groupId, userId);
                }
                res.Code = RES.OK;
                res.Message = "添加成功！";
                return res;
            }
            catch
            {
                res.Code = RES.ERROR;
                res.Message = "添加失败！";
                return res;
            }
        }

        /// <summary>
        /// 删除用户组中的用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns>执行结果</returns>
        public Result DelG2u(int groupId, List<int> user_id)
        {
            PermDAL perm = new PermDAL();
            Result res = new Result();
            int re = 0;
            try
            {
                foreach (var userId in user_id)
                {
                    re += perm.DelG2u(groupId, userId);
                }
                if (re == 0)
                {
                    res.Code = RES.ERROR;
                    res.Message = "删除失败！";
                    return res;
                }else
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
        /// 用户组权限管理
        /// </summary>
        /// <param name="groupId">用户组ID</param>
        /// <param name="menu_id">权限ID列表</param>
        /// <returns>执行结果</returns>
        public Result Perm(int groupId, List<int> menu_id)
        {
            PermDAL perm = new PermDAL();
            Result res = new Result();
            int re = 0;
            try
            {
                re +=perm.DelG2m(groupId);
                foreach (var menuId in menu_id)
                {
                    re +=perm.AddG2m(groupId, menuId);
                }
                if (re == 0)
                {
                    res.Code = RES.ERROR;
                    res.Message = "修改失败！";
                    return res;
                }
                else
                {
                    res.Code = RES.OK;
                    res.Message = "修改成功！";
                    new LogUserDAL().Add(LogOperations.LogUser("用户组权限修改"));
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
        /// 查询用户组中用户
        /// </summary>
        /// <param name="groupId">用户组id</param>
        /// <returns>用户组信息</returns>
        public List<view_sys_u2g> SelectU2g(int groupId)
        {
            PermDAL perm = new PermDAL();
            return perm.SelectU2g(groupId);
        }

        /// <summary>
        /// 查询用户组权限
        /// </summary>
        /// <param name="groupId">用户组id</param>
        /// <returns>用户组信息</returns>
        public List<view_sys_g2m> SelectG2m(int groupId)
        {
            PermDAL perm = new PermDAL();
            return perm.SelectG2m(groupId);
        }

    }
}
