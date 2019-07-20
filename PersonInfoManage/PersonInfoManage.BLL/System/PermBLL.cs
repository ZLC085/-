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
    class PermBLL
    {
        /// <summary>
        /// 添加用户组
        /// </summary>
        /// <param name="group"></param>
        /// <returns>影响条数</returns>
        public Result add(sys_group group)
        {
            Result res = new Result();
            PermDAL perm = new PermDAL();
            try
            {
                if (perm.add(group) == 0)
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
        /// 添加用户组和用户关联
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="group_id"></param>
        /// <returns>影响条数</returns>
        public Result add(int user_id, int group_id)
        {
            Result res = new Result();
            PermDAL perm = new PermDAL();
            try
            {
                if (perm.add(user_id, group_id) == 0)
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
        /// 用户组权限修改
        /// </summary>
        /// <param name="group_id">用户组id</param>
        /// <param name="menu_id">菜单id</param>
        /// <returns>修改条数</returns>
        public Result Updateg2m(int group_id,int menu_id)
        {
            PermDAL perm = new PermDAL();
            Result res = new Result();
            try
            {
                if (perm.Updateg2m(group_id, menu_id) == 0)
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
        /// 用户所在用户组修改
        /// </summary>
        /// <param name="user_id">用户id</param>
        /// <param name="group_id">用户组id</param>
        /// <returns>修改条数</returns>
        public Result Updateu2g(int user_id, int group_id)
        {
            PermDAL perm = new PermDAL();
            Result res = new Result();
            try
            {
                if (perm.Updateg2m(user_id, group_id) == 0)
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
        /// 用户组信息修改
        /// </summary>
        /// <param name="user_id">用户id</param>
        /// <param name="group_id">用户组id</param>
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
                if (perm.Del(id) == 0)
                {
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
        /// 删除用户组和权限关联
        /// </summary>
        /// <param name="id"></param>
        /// <returns>影响条数</returns>
        public Result DelG2m(int id)
        {
            PermDAL perm = new PermDAL();
            Result res = new Result();
            try
            {
                if (perm.DelG2m(id) == 0)
                {
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
        /// 删除用户组和用户关联
        /// </summary>
        /// <param name="id"></param>
        /// <returns>影响条数</returns>
        public Result Delu2g(int id)
        {
            PermDAL perm = new PermDAL();
            Result res = new Result();
            try
            {
                if (perm.Delu2g(id) == 0)
                {
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
        /// 查询用户组
        /// </summary>
        /// <param name="group">查询条件</param>
        /// <returns>用户组信息</returns>
        public List<sys_group> Selectgroup(sys_group group)
        {
            PermDAL perm = new PermDAL();
            return perm.Selectgroup(group);
        }







    }
}
