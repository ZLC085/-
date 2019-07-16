using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.System
{
    /// <summary>
    /// 用户管理
    /// </summary>
    public class SysUser : DALBase
    {
        /// <summary>
        /// 用户添加
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>添加条数</returns>
        public int InsertSysUser(sys_user user, string role_sign)
        {
            int res = 0;
            int ress = 0;

            string sql = "Insert into sys_user (username,name,password,gender,job,phone,email) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
            string sql1 = "Insert into sys_role (role_sign) values(@p8)";
            SqlParameter sqlparameter = new SqlParameter("@p1", user.username);
            SqlParameter sqlparameter1 = new SqlParameter("@p2", user.name);
            SqlParameter sqlparameter2 = new SqlParameter("@p3", user.password);
            SqlParameter sqlparameter3 = new SqlParameter("@p4", user.gender);
            SqlParameter sqlparameter4 = new SqlParameter("@p5", user.job);
            SqlParameter sqlparameter5 = new SqlParameter("@p6", user.phone);
            SqlParameter sqlparameter6 = new SqlParameter("@p7", user.email);
            SqlParameter sqlparameter7 = new SqlParameter("@p8", role_sign);
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                connection.Open();
                SqlTransaction trans = connection.BeginTransaction();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = trans;
                try
                {

                    res = SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql, sqlparameter, sqlparameter1, sqlparameter2, sqlparameter3, sqlparameter4, sqlparameter5, sqlparameter6, sqlparameter7);
                    ress = SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql1, sqlparameter7);
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                }
            }
            return 1;
        }
        //return new DBOperationsInsert<sys_user, DBNull>().Insert(user);


        /// <summary>
        /// 用户信息修改
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newValues">用户信息</param>
        /// <returns>修改条数</returns>
        public int UpdateSysUser(int id, Dictionary<string, object> newValues)
        {
            return new DBOperationsUpdate<sys_user>().UpdateById(id, newValues);
        }

        /// <summary>
        /// 用户删除
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>删除条数</returns>
        public int DeleteSysUser(int userId)
        {
            return new DBOperationsDelete<sys_user, DBNull>().DeleteById(userId);
        }

        /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <returns>所有用户</returns>
        public List<sys_user> SelectAllSysUser()
        {
            return new DBOperationsSelect<sys_user>().SelectAll();
        }

        /// <summary>
        /// 通过输入条件查询用户
        /// </summary>
        /// <param name="conditions">查询条件</param>
        /// <returns>通过用户名查询到的用户</returns>
        public List<sys_user> SelectSysUserByConditions(Dictionary<string, object> conditions)
        {
            return new DBOperationsSelect<sys_user>().SelectByConditions(conditions);
        }
    }
}

