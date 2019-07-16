using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.System
{
    /// <summary>
    /// 权限管理
    /// </summary>
    public class Perm :DALBase
    {
        /// <summary>
        /// 权限添加
        /// </summary>
        /// <param name="role">权限信息</param>
        /// <returns>添加条数</returns>
        public int InsertPermission(sys_u2r role)
        {
            int res = 0;
            string sql = "insert into sys_u2r (user_id,role_id,sys_role,sys_user) values(@p1,@p2,@p3,@p4)";
            SqlParameter sqlParameter = new SqlParameter("@p1",role.user_id );
            SqlParameter sqlParameter1 = new SqlParameter("@p2",role.role_id );
            SqlParameter sqlParameter2 = new SqlParameter("@p3",role.sys_role );
            SqlParameter sqlParameter3 = new SqlParameter("@p4",role.sys_user );
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter, sqlParameter1,sqlParameter2,sqlParameter3);

            return res;
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
