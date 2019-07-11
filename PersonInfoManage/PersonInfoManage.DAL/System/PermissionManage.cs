using PersonInfoManage.IDAL.System;
using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.System
{
    /// <summary>
    /// 权限管理
    /// </summary>
    public class PermissionManage : IPermissionManage
    {
        /// <summary>
        /// 权限添加
        /// </summary>
        /// <param name="role">权限信息</param>
        /// <returns>添加条数</returns>
        public int InsertPermission(sys_user_role role)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 权限修改
        /// </summary>
        /// <param name="role">权限信息</param>
        /// <returns>修改条数</returns>
        public int UpdatePermission(sys_user_role role)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除权限，通过用户id
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>删除条数</returns>
        public int DeletePermission(long userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 权限检索，通过用户id
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>权限信息</returns>
        public List<sys_user_role> SelectPermissionByUserId(long userId)
        {
            throw new NotImplementedException();
        }

    }
}
