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
                    res = SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql, sqlparameter, sqlparameter1, sqlparameter2, sqlparameter3, sqlparameter4, sqlparameter5, sqlparameter6);
                    ress = SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql1, sqlparameter7);
                    trans.Commit();
                    return 1;
                }
                catch
                {
                    trans.Rollback();
                    return 0;
                }
            }
            

            //return new DBOperationsInsert<sys_user, DBNull>().Insert(user);
        }

        /// <summary>
        /// 用户信息修改
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newValues">用户信息</param>
        /// <returns>修改条数</returns>
        public int UpdateSysUser(int user_id, sys_user user,int role_id,string role_sign)
        {
            int res = 0;
            int ress = 0;
            string sql = "updata sys_user set (username,name,password,gender,job,phone,email,status) = (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8) where id=user_id";
            string sql1 = "updata sys_role set role_sign=@p9 where id=role_id";
            SqlParameter sqlParameter = new SqlParameter("@p1",user.username);
            SqlParameter sqlParameter1 = new SqlParameter("@p2", user.name);
            SqlParameter sqlParameter2 = new SqlParameter("@p3", user.password);
            SqlParameter sqlParameter3 = new SqlParameter("@p4", user.gender);
            SqlParameter sqlParameter4 = new SqlParameter("@p5", user.job);
            SqlParameter sqlParameter5 = new SqlParameter("@p6", user.phone);
            SqlParameter sqlParameter6 = new SqlParameter("@p7", user.email);
            SqlParameter sqlParameter7 = new SqlParameter("@p8", user.status);
            SqlParameter sqlParameter8 = new SqlParameter("@p9", role_sign);
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                connection.Open();
                SqlTransaction trans = connection.BeginTransaction();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = trans;
                try
                {
                    res = SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, sqlParameter5, sqlParameter6, sqlParameter7);
                    ress = SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql1, sqlParameter8);
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                }
            }
            return 1;
            //return new DBOperationsUpdate<sys_dict>().UpdateById(id, newValues);
        }
        //return new DBOperationsUpdate<sys_user>().UpdateById(id, newValues);
    

        /// <summary>
        /// 用户删除
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>删除条数</returns>
        public int DeleteSysUser(int user_id,int role_id)
        {
            int res = 0;
            int ress = 0;
            string sql = "delete from sys_user where id=user_id";
            string sql1 = "delete from sys_role where id=role_id";
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                connection.Open();
                SqlTransaction trans = connection.BeginTransaction();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = trans;
                try
                {
                    res = SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql);
                    ress = SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql1);
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                }
            }
            return 1;
            //return new DBOperationsDelete<sys_user, DBNull>().DeleteById(userId);
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

