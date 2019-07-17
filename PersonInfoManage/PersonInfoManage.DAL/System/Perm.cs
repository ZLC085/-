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
        ///添加用户组
        /// </summary>
        /// <param name="role">用户组信息</param>
        /// <returns>添加条数</returns>
        public int InsertPermission(sys_role role)
        {
           

            int res;
            string sql1 = "Insert into sys_role(role_name,rolo_sign) values(@p1,@p2)";
            SqlParameter sqlparameter1 = new SqlParameter("@p1", role.role_name);
            SqlParameter sqlparameter2 = new SqlParameter("@p2", role.role_sign);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql1, sqlparameter1, sqlparameter2);       
            return res;
        }

        /// <summary>
        /// 用户组权限修改
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newValues">需要修改的值</param>
        /// <returns>修改条数</returns>
        public int UpdatePermission(int id,  string menu_name)
        {
          //  string sql1 = "Update sys_role set role_name=@p1,role_sign=@p2 where id=@4";
            string sql2 = "Update sys_menu set menu_name=@p3 where id=@p4";
            //SqlParameter sqlparameter1 = new SqlParameter("@p1", role.role_name);
            //SqlParameter sqlparameter2 = new SqlParameter("@p2", role.role_sign);
            SqlParameter sqlparameter3 = new SqlParameter("@p3", menu_name);
            SqlParameter sqlparameter4 = new SqlParameter("@p4", id);
            //using (SqlConnection connection = new SqlConnection(ConStr))
            //{
            //    connection.Open();
            //    SqlTransaction trans = connection.BeginTransaction();
            //    SqlCommand command = new SqlCommand();
            //    command.Connection = connection;
            //    command.Transaction = trans;
            //    try
            //    {
            //       // SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql1, sqlparameter1, sqlparameter2);
            //        SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql2, sqlparameter3);
            //        trans.Commit();
            //        return 1;
            //    }
            //    catch
            //    {
            //        trans.Rollback();
                   return 0;
            //    }

            //}
           // return new DBOperationsUpdate<sys_u2r>().UpdateById(id, newValues);
        }

        /// <summary>
        /// 删除权限，通过用户id
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>删除条数</returns>
        public int DeletePermission(int user_id)
        {
            string sql1 = "Delete from sys_role where id=user_id";
            string sql2 = "Delete from sys_mune where id=user_id";
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                connection.Open();
                SqlTransaction trans = connection.BeginTransaction();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = trans;
                try
                {
                    SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql1);
                    SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql2);
                    trans.Commit();
                    return 1;
                }
                catch
                {
                    trans.Rollback();
                    return 0;
                }
                // return new DBOperationsDelete<sys_u2r, DBNull>().DeleteById(userId);
            }

        /// <summary>
        /// 通过输入条件进行权限检索
        /// </summary>
        /// <param name="conditions">输入条件</param>
        /// <returns>权限信息</returns>
        public List<sys_u2r> SelectPermissionByConditions(string role_name,string role_sign)
        {
           
            string sql1 = "Select id as 序号,role_name as 角色名称 ,role_sign as 身份标识,remark as 权限描述,create_time as 创建时间,modify_time as 修改时间 from sys_role where role_name=role_name or role_sign=role_sign";
            DataSet ds=SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql1);
           
            //return new DBOperationsSelect<sys_u2r>().SelectByConditions(conditions);
        }
    }
}
