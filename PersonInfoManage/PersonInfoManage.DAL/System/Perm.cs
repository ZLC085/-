using PersonInfoManage.DAL.Utils;
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
    public class Perm
    {
        /// <summary>
        /// 权限添加
        /// </summary>
        /// <param name="role">权限信息</param>
        /// <returns>添加条数</returns>
        public int InsertPermission(sys_u2r role)
        {
            return new DBOperationsInsert<sys_u2r, DBNull>().Insert(role);
        }

        /// <summary>
        /// 权限修改
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newValues">需要修改的值</param>
        /// <returns>修改条数</returns>
        public int UpdatePermission(int id, Dictionary<string, object> newValues)
        {
            return new DBOperationsUpdate<sys_u2r>().UpdateById(id, newValues);
        }

        /// <summary>
        /// 删除权限，通过用户id
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>删除条数</returns>
        public int DeletePermission(int userId)
        {
            return new DBOperationsDelete<sys_u2r, DBNull>().DeleteById(userId);
        }

        /// <summary>
        /// 通过输入条件进行权限检索
        /// </summary>
        /// <param name="conditions">输入条件</param>
        /// <returns>权限信息</returns>
        public List<sys_u2r> SelectPermissionByConditions(Dictionary<string, object> conditions)
        {
            return new DBOperationsSelect<sys_u2r>().SelectByConditions(conditions);
        }
    }
}
