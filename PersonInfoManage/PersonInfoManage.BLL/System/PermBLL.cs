using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonInfoManage.DAL.System;
using PersonInfoManage.Model;
using PersonInfoManage.BLL.Utils;

namespace PersonInfoManage.BLL.System
{
     public class PermBLL
    {
        /// <summary>
        /// 添加用户组
        /// </summary>
        /// <param name="group"></param>
        /// <returns>影响条数</returns>
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
        /// 关联用户和用户组
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="groupId"></param>
        /// <returns>影响条数</returns>
        public Result AddU2g(int groupId,List<int> user_id)
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
        /// 用户组权限添加
        /// </summary>
        /// <param name="groupId">用户组id</param>
        /// <param name="menuId">菜单id</param>
        /// <returns>修改条数</returns>
        public Result AddG2m(int groupId, List<int> menu_id)
        {
            PermDAL perm = new PermDAL();
            Result res = new Result();
            try
            {
                foreach (var menuId in menu_id)
                {
                    perm.AddG2m(groupId, menuId);                    
                }
                res.Code = RES.OK;
                res.Message = "修改成功！";
                return res;
            }
            catch
            {
                res.Code = RES.ERROR;
                res.Message = "修改失败！";
                return res;
            }
        }


        /// <summary>
        /// 用户组信息修改
        /// </summary>
        /// <param name="group">用户组信息</param>
        /// <returns>修改条数</returns>
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
        /// <returns>影响条数</returns>
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
        /// 删除用户组和权限关联
        /// </summary>
        /// <param name="id"></param>
        /// <returns>影响条数</returns>
        public Result DelG2m(int groupId, List<int> menu_id)
        {
            PermDAL perm = new PermDAL();
            Result res = new Result();
            try
            {
                foreach (var menuId in menu_id)
                {
                    perm.DelG2m(groupId, menuId);
                }
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
        /// 删除用户组和用户关联
        /// </summary>
        /// <param name="id"></param>
        /// <returns>影响条数</returns>
        public Result DelG2u(int groupId, List<int> user_id)
        {
            PermDAL perm = new PermDAL();
            Result res = new Result();
            try
            {
                foreach (var userId in user_id)
                {
                    perm.DelG2u(groupId, userId);
                }             
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
