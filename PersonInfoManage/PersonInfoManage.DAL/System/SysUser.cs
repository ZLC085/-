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
    public class SysUserDAL : DALBase
    {
        /// <summary>
        /// 用户添加
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>添加条数</returns>
        public int add(sys_user user)
        {
            int res;
            string sql = "insert into sys_user (username,name,password,gender,job,phone,email,status,create_time,modify_time) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,getdate(),getdate())";
            SqlParameter sqlparameter = new SqlParameter("@p1", user.username);
            SqlParameter sqlparameter1 = new SqlParameter("@p2", user.name);
            SqlParameter sqlparameter2 = new SqlParameter("@p3", user.password);
            SqlParameter sqlparameter3 = new SqlParameter("@p4", user.gender);
            SqlParameter sqlparameter4 = new SqlParameter("@p5", user.job);
            SqlParameter sqlparameter5 = new SqlParameter("@p6", user.phone);
            SqlParameter sqlparameter6 = new SqlParameter("@p7", user.email);
            SqlParameter sqlparameter7 = new SqlParameter("@p8", user.status);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlparameter, sqlparameter1, sqlparameter2, sqlparameter3, sqlparameter4, sqlparameter5, sqlparameter6, sqlparameter7);
            return res;
        }
            //return new DBOperationsInsert<sys_user, DBNull>().Insert(user);    

        /// <summary>
        /// 用户信息修改
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>修改条数</returns>
        public int Update(sys_user user)
        {
            int res;
            string sql = "update sys_user SET username = @p1,name = @p2,password = @p3,gender = @p4,job = @p5,phone = @p6,email = @p7,status = @p8,modify_time=getdate() where id = '" + user.id + "'";
            SqlParameter sqlParameter = new SqlParameter("@p1", user.username);
            SqlParameter sqlParameter1 = new SqlParameter("@p2", user.name);
            SqlParameter sqlParameter2 = new SqlParameter("@p3", user.password);
            SqlParameter sqlParameter3 = new SqlParameter("@p4", user.gender);
            SqlParameter sqlParameter4 = new SqlParameter("@p5", user.job);
            SqlParameter sqlParameter5 = new SqlParameter("@p6", user.phone);
            SqlParameter sqlParameter6 = new SqlParameter("@p7", user.email);
            SqlParameter sqlParameter7 = new SqlParameter("@p8", user.status);
            res =SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, sqlParameter5, sqlParameter6, sqlParameter7);
            return res;
            //return new DBOperationsUpdate<sys_dict>().UpdateById(id, newValues);
        }


        /// <summary>
        /// 用户删除
        /// </summary>
        /// <param name="user_id">用户id</param>
        /// <returns>删除条数</returns>
        public int Del(int user_id)
        {
            int res;
            string sql = "delete from sys_user where id= '" + user_id + "'";
            res=SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
            return res;
            //return new DBOperationsDelete<sys_user, DBNull>().DeleteById(userId);
        }


        /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <returns>所有用户</returns>
        public Dictionary<sys_user, sys_group> Selectall()
        {
            Dictionary<sys_user, sys_group> user = new Dictionary<sys_user,sys_group>();
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            string sql = "select * from sys_user";
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                SqlConnection conn = new SqlConnection(ConStr);
                SqlCommand command = new SqlCommand();
                SqlTransaction trans = null;
                try
                {
                    conn.Open();
                    trans = conn.BeginTransaction();
                    ds = SqlHelper.ExecuteDataset(trans, CommandType.Text, sql);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        sys_user user1 = new sys_user();
                        sys_group group = new sys_group();
                        sys_u2g u2g = new sys_u2g();
                        user1.id = (int)ds.Tables[0].Rows[i][nameof(sys_user.id)];
                        user1.username = (string)ds.Tables[0].Rows[i][nameof(sys_user.username)];
                        user1.name = (string)ds.Tables[0].Rows[i][nameof(sys_user.name)];
                        user1.gender = (string)ds.Tables[0].Rows[i][nameof(sys_user.gender)];
                        user1.phone = (string)ds.Tables[0].Rows[i][nameof(sys_user.phone)];
                        user1.job = (string)ds.Tables[0].Rows[i][nameof(sys_user.job)];
                        user1.status = (Boolean)ds.Tables[0].Rows[i][nameof(sys_user.status)];
                        string sql1 = "select * from sys_u2g where user_id = '" + user1.id + "' ";
                        ds1 = SqlHelper.ExecuteDataset(trans, CommandType.Text, sql1);
                        u2g.group_id = (int)ds1.Tables[0].Rows[0][nameof(sys_u2g.group_id)];
                        string sql2 = "select * from sys_group where id='" + u2g.group_id + "'";
                        ds2 = SqlHelper.ExecuteDataset(trans, CommandType.Text, sql2);
                        group.group_name = (string)ds2.Tables[0].Rows[0][nameof(sys_group.group_name)];
                        user.Add(user1, group);
                    }
                    trans.Commit();
                    return user;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    return null;
                }
            }
            //return new DBOperationsSelect<sys_user>().SelectAll();
        }


        /// <summary>
        /// 通过输入条件查询用户
        /// </summary>
        /// <param name="conditions">查询条件</param>
        /// <returns>通过用户名查询到的用户</returns>
        public List<sys_user> SelectBy(sys_user user)
        {
            List<sys_user> user1 = new List<sys_user>();
            string sql = "SELECT dbo.sys_user.create_time, dbo.sys_user.email, dbo.sys_user.gender, dbo.sys_user.id, dbo.sys_user.job,"
                + "dbo.sys_user.modify_time, dbo.sys_user.name, dbo.sys_user.password,dbo.sys_user.phone,dbo.sys_user.status,"
                + "dbo.sys_user.username,dbo.sys_group.id AS group_id,dbo.sys_group.remark,dbo.sys_group.group_name"
                + "FROM dbo.sys_user INNER JOIN dbo.sys_u2g ON dbo.sys_u2g.user_id = dbo.sys_user.id INNER JOIN dbo.sys_group "
                +"ON dbo.sys_u2g.group_id = dbo.sys_group.id  ";
            List<SqlParameter> sqlPara = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(user.username))
            {
                sql += " and username like @username";
                sqlPara.Add(new SqlParameter("@username", "%" + user.username + "%"));
            }
            if (!string.IsNullOrEmpty(user.name))
            {
                sql += " and name like @name";
                sqlPara.Add(new SqlParameter("@name", "%" + user.name + "%"));
            }

            if (!string.IsNullOrEmpty(user.gender))
            {
                sql += " and gender like @gender";
                sqlPara.Add(new SqlParameter("@gender", "%" + user.gender + "%"));
            }
            if (!string.IsNullOrEmpty(user.phone))
            {
                sql += " and phone like @phone";
                sqlPara.Add(new SqlParameter("@phone", "%" + user.phone + "%"));
            }
            if (!string.IsNullOrEmpty(user.job))
            {
                sql += " and job like @job";
                sqlPara.Add(new SqlParameter("@job", "%" + user.job + "%"));
            }
                    DataSet ds = new DataSet();
                    ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql, sqlPara.ToArray());
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i ++)
                    {
                        sys_user user1 = new sys_user();
                        sys_u2g u2g = new sys_u2g();
                        sys_group group1 = new sys_group();
                        user1.id = (int)ds.Tables[0].Rows[i][nameof(sys_user.id)];
                        user1.name = (string)ds.Tables[0].Rows[i][nameof(sys_user.name)];
                        user1.username = (string)ds.Tables[0].Rows[i][nameof(sys_user.username)];
                        user1.gender = (string)ds.Tables[0].Rows[i][nameof(sys_user.gender)];
                        user1.phone = (string)ds.Tables[0].Rows[i][nameof(sys_user.phone)];
                        user1.job = (string)ds.Tables[0].Rows[i][nameof(sys_user.job)];
                        string sql1 ="select * from sys_u2g where user_id = '" + user1.id + "' ";
                        ds1 = SqlHelper.ExecuteDataset(connection, CommandType.Text, sql1);
                        u2g.group_id= (int)ds1.Tables[0].Rows[0][nameof(sys_u2g.group_id)];
                        string sql2 = "select * from sys_group where id= '" + u2g.group_id + "'";
                        ds2 = SqlHelper.ExecuteDataset(connection, CommandType.Text, sql2);
                        group1.group_name= (string)ds2.Tables[0].Rows[0][nameof(sys_group.group_name)];
                        if (!string.IsNullOrEmpty(group.group_name))
                        {
                           if(group1.group_name == group.group_name)
                            {
                                Dic.Add(user1, group1);  
                                                            
                            }
                            else
                            {                               
                            }
                        }
                        else
                        {
                            Dic.Add(user1, group1);
                        }
                    }
                    trans.Commit();
                    return Dic;   
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    return null;
                }
                //return new DBOperationsSelect<sys_user>().SelectByConditions(conditions);
            }
        }
    }
}


