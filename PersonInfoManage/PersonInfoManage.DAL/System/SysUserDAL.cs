﻿using PersonInfoManage.DAL.Logs;
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
        #region 用户添加
        /// <summary>
        /// 用户添加
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>添加条数</returns>
        public int Add(sys_user user)
        {
            try
            {
                int res;
                string sql = "insert into sys_user (username,name,password,gender,job,org_id,phone,email,status,create_time,modify_time) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,getdate(),getdate())";
                SqlParameter sqlparameter = new SqlParameter("@p1", user.username);
                SqlParameter sqlparameter1 = new SqlParameter("@p2", user.name);
                SqlParameter sqlparameter2 = new SqlParameter("@p3", user.password);
                SqlParameter sqlparameter3 = new SqlParameter("@p4", user.gender);
                SqlParameter sqlparameter4 = new SqlParameter("@p5", user.job);
                SqlParameter sqlparameter5 = new SqlParameter("@p6", user.org_id);
                SqlParameter sqlparameter6 = new SqlParameter("@p7", user.phone);
                SqlParameter sqlparameter7 = new SqlParameter("@p8", user.email);
                SqlParameter sqlparameter8 = new SqlParameter("@p9", user.status);
                res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlparameter, sqlparameter1, sqlparameter2, sqlparameter3, sqlparameter4, sqlparameter5, sqlparameter6, sqlparameter7, sqlparameter8);
                new LogUserDAL().Add(LogOperations.LogUser("添加用户"));
                return res;
            }
            catch (Exception e)
            {
                new LogSysDAL().Add(LogOperations.LogSys("添加用户"+e.Message));
                return 0;
            }
        }
        //return new DBOperationsInsert<sys_user, DBNull>().Insert(user);    
        #endregion

        #region 用户信息修改
        /// <summary>
        /// 用户信息修改
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>修改条数</returns>
        public int Update(sys_user user,int userid)
        {
            try
            {
                int res;
                string sql = "Update sys_user SET username = @p1,name = @p2,password = @p3,gender = @p4,org_id = @p6,job = @p5,phone = @p7,email = @p8,status = @p9,modify_time=getdate() where id = '" + userid + "'";
                SqlParameter sqlParameter = new SqlParameter("@p1", user.username);
                SqlParameter sqlParameter1 = new SqlParameter("@p2", user.name);
                SqlParameter sqlParameter2 = new SqlParameter("@p3", user.password);
                SqlParameter sqlParameter3 = new SqlParameter("@p4", user.gender);
                SqlParameter sqlParameter4 = new SqlParameter("@p5", user.job);
                SqlParameter sqlParameter5 = new SqlParameter("@p6", user.org_id);
                SqlParameter sqlParameter6 = new SqlParameter("@p7", user.phone);
                SqlParameter sqlParameter7 = new SqlParameter("@p8", user.email);
                SqlParameter sqlParameter8 = new SqlParameter("@p9", user.status);
                res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, sqlParameter5, sqlParameter6, sqlParameter7, sqlParameter8);
                new LogUserDAL().Add(LogOperations.LogUser("修改用户信息"));
                return res;
            }
            catch (Exception e)
            {
                new LogSysDAL().Add(LogOperations.LogSys("修改用户信息"+e.Message));
                return 0;
            }
            //return new DBOperationsUpdate<sys_dict>().UpdateById(id, newValues);
        }
        #endregion

        #region 重置用户密码
        /// <summary>
        /// 重置用户密码
        /// </summary>
        /// <param name="uesrid">用户id</param>
        /// <returns>修改条数</returns>
        public int RePassword(int userid)
        {
            try
            {
                int res;
                string sql = "Update sys_user SET password = '"+123456+"' modify_time=getdate() where id = '" + userid + "'";
                res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
                new LogUserDAL().Add(LogOperations.LogUser("重置密码"));
                return res;
            }
            catch (Exception e)
            {
                new LogSysDAL().Add(LogOperations.LogSys("重置密码" + e.Message));
                return 0;
            }
        }
        #endregion

        #region 用户删除
        /// <summary>
        /// 用户删除
        /// </summary>
        /// <param name="user_id">用户id</param>
        /// <returns>删除条数</returns>
        public int Del(int UserId)
        {
            string sql1 = "delete from sys_u2g where user_id='" + UserId + "'";
            string sql2 = "delete from log_user where user_id='" + UserId + "'";
            string sql3 = "delete from sys_user where id= '" + UserId + "'";
            List<String> SQLStringList = new List<string>();
            SQLStringList.Add(sql1);
            SQLStringList.Add(sql2);
            SQLStringList.Add(sql3);
            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlTransaction trans = conn.BeginTransaction();
                cmd.Transaction = trans;
                try
                {
                    int count = 0;
                    for (int n = 0; n < SQLStringList.Count; n++)
                    {
                        string strsql = SQLStringList[n];
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    trans.Commit();
                    new LogUserDAL().Add(LogOperations.LogUser("删除用户"));
                    return count;
                }
                catch (Exception e)
                {
                    trans.Rollback();
                    new LogSysDAL().Add(LogOperations.LogSys("删除用户"+e.Message));
                    return 0;
                }
                finally
                {
                    conn.Close();
                    trans.Dispose();
                    conn.Dispose();
                }
                //return new DBOperationsDelete<sys_user, DBNull>().DeleteById(userId);
            }
        }
        #endregion

        #region  查询所有用户
        /// <summary>
        /// 查询用户
        /// </summary>
        /// <returns>查询到的用户信息</returns>
        public List<view_sys_u2g> SelectAll()
        {
            try
            {
                List<view_sys_u2g> user = new List<view_sys_u2g>();
                string sql = "SELECT * from view_sys_u2g";
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    view_sys_u2g user1 = new view_sys_u2g();
                    user1.id = (int)ds.Tables[0].Rows[i][nameof(view_sys_u2g.id)];
                    user1.name = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.name)];
                    user1.username = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.username)];
                    user1.gender = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.gender)];
                    user1.phone = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.phone)];
                    user1.job = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.job)];
                    user1.status = (bool)ds.Tables[0].Rows[i][nameof(view_sys_u2g.status)];
                    user1.org_name = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.org_name)];
                    user.Add(user1);
                }
                return user;
            }
            catch (Exception e)
            {
                new LogSysDAL().Add(LogOperations.LogSys("查询用户信息" + e.Message));
                return null;
            }
            //return new DBOperationsSelect<sys_user>().SelectByConditions(conditions);
        }
        #endregion

        #region  通过输入条件查询用户
        /// <summary>
        /// 通过输入条件查询用户
        /// </summary>
        /// <param name="UserInfo">查询条件</param>
        /// <returns>查询到的用户信息</returns>
        public List<view_sys_u2g> Select(sys_user UserInfo)
        {
            try
            {
                List<view_sys_u2g> user = new List<view_sys_u2g>();
                string sql = "SELECT * from view_sys_u2g where 1=1  ";
                List<SqlParameter> SqlPara = new List<SqlParameter>();
                if (!string.IsNullOrEmpty(UserInfo.username))
                {
                    sql += " and username like @username";
                    SqlPara.Add(new SqlParameter("@username", "%" + UserInfo.username + "%"));
                }
                if (!string.IsNullOrEmpty(UserInfo.name))
                {
                    sql += " and name like @name";
                    SqlPara.Add(new SqlParameter("@name", "%" + UserInfo.name + "%"));
                }

                if (!string.IsNullOrEmpty(UserInfo.gender))
                {
                    sql += " and gender like @gender";
                    SqlPara.Add(new SqlParameter("@gender", "%" + UserInfo.gender + "%"));
                }
                if (!string.IsNullOrEmpty(UserInfo.job))
                {
                    sql += " and job like @job";
                    SqlPara.Add(new SqlParameter("@job", "%" + UserInfo.job + "%"));
                }
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql, SqlPara.ToArray());
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    view_sys_u2g user1 = new view_sys_u2g();
                    user1.id = (int)ds.Tables[0].Rows[i][nameof(view_sys_u2g.id)];
                    user1.name = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.name)];
                    user1.username = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.username)];
                    user1.gender = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.gender)];
                    user1.phone = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.phone)];
                    user1.job = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.job)];
                    user1.status = (bool)ds.Tables[0].Rows[i][nameof(view_sys_u2g.status)];
                    user1.org_name = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.org_name)];
                    user.Add(user1);
                }
                return user;
            }
            catch (Exception e)
            {
                new LogSysDAL().Add(LogOperations.LogSys("查询用户信息"+e.Message));
                return null;
            }
            //return new DBOperationsSelect<sys_user>().SelectByConditions(conditions);
        }
        #endregion

        #region 通过id查询用户
        /// <summary>
        /// 通过id查询用户
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns>查询到的用户信息</returns>
        public List<view_sys_u2g> SelectById(int id)
        {
            try
            {
                List<view_sys_u2g> user = new List<view_sys_u2g>();
                string sql = "SELECT * from view_sys_u2g where id ='"+id+"'";
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    view_sys_u2g user1 = new view_sys_u2g();
                    user1.id = (int)ds.Tables[0].Rows[i][nameof(view_sys_u2g.id)];
                    user1.name = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.name)];
                    user1.username = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.username)];
                    user1.password = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.password)];
                    user1.gender = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.gender)];
                    user1.phone = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.phone)];
                    user1.email = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.email)];
                    user1.job = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.job)];
                    user1.status = (bool)ds.Tables[0].Rows[i][nameof(view_sys_u2g.status)];
                    user1.org_name = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.org_name)];
                    user.Add(user1);
                }
                return user;
            }
            catch (Exception e)
            {
                new LogSysDAL().Add(LogOperations.LogSys("查询用户信息"+e.Message));
                return null;
            }
        }
        #endregion
    }
}


