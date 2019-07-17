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
            string sql1 = "Insert into sys_role(role_name,rolo_sign,remark) values(@p1,@p2,@p3)";
            SqlParameter sqlparameter1 = new SqlParameter("@p1", role.role_name);
            SqlParameter sqlparameter2 = new SqlParameter("@p2", role.role_sign);
            SqlParameter sqlparameter3 = new SqlParameter("@p3", role.remark );
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql1, sqlparameter1, sqlparameter2, sqlparameter3);       
            return res;
        }

        /// <summary>
        /// 用户组权限修改
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newValues">需要修改的值</param>
        /// <returns>修改条数</returns>
        public int UpdatePermission(int role_id,  string menu_name)
        {
            //  string sql1 = "Update sys_role set role_name=@p1,role_sign=@p2 where id=@4";
            //SqlParameter sqlparameter1 = new SqlParameter("@p1", role.role_name);
            //SqlParameter sqlparameter2 = new SqlParameter("@p2", role.role_sign);
            int res = 0;
            string sql1 = "Update sys_menu set menu_name=@p3 where id=@p4";
            SqlParameter sqlparameter3 = new SqlParameter("@p3", menu_name);
            SqlParameter sqlparameter4 = new SqlParameter("@p4", role_id);
            res=SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql1,  sqlparameter3, sqlparameter4);
            return res;
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
            //    }

            //}
            // return new DBOperationsUpdate<sys_u2r>().UpdateById(id, newValues);
        }

        /// <summary>
        /// 删除用户组
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>删除条数</returns>
        public int DeletePermission(int role_id)
        {
            int res;
            string sql1 = "Delete from sys_role where id=@p1";
            SqlParameter sqlparameter1 = new SqlParameter("@p1", role_id);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql1, sqlparameter1);
            return res;
            // return new DBOperationsDelete<sys_u2r, DBNull>().DeleteById(userId);
        }

        /// <summary>
        /// 通过输入条件进行权限检索
        /// </summary>
        /// <param name="conditions">输入条件</param>
        /// <returns>权限信息</returns>
        public List<sys_role> SelectPermissionByConditions(string role_name,string role_sign)
        {
            DataSet ds = new DataSet();
            string sql1 = "Select id as 序号,role_name as 角色名称 ,role_sign as 身份标识,remark as 权限描述,create_time as 创建时间,modify_time as 修改时间 from sys_role where role_name=@p1 or role_sign=@p2";
            SqlParameter sqlparameter1 = new SqlParameter("@p1", role_name);
            SqlParameter sqlparameter2 = new SqlParameter("@p2", role_sign);
            ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql1);
            sys_role dict1 = new sys_role();
            List<sys_role> dict = new List<sys_role>();        
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dict1.id = int.Parse((string)ds.Tables[0].Rows[i][nameof(sys_role.id)]);
                dict1. role_name= (string)ds.Tables[0].Rows[i][nameof(sys_role.role_name)];
                dict1.role_sign = (string)ds.Tables[0].Rows[i][nameof(sys_role.role_sign)];
                dict1.remark = (string)ds.Tables[0].Rows[i][nameof(sys_role.remark)];
                dict1.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_role.create_time)];
                dict1.modify_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_role.modify_time)];
            }
            dict.Add(dict1);
            return dict;

            //return new DBOperationsSelect<sys_u2r>().SelectByConditions(conditions);
        }
    }
}
