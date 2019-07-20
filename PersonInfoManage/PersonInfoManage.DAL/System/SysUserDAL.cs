﻿using PersonInfoManage.DAL.Utils;
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
        /// 通过输入条件查询用户
        /// </summary>
        /// <param name="conditions">查询条件</param>
        /// <returns>通过用户名查询到的用户</returns>
        public List<view_sys_u2g> Select(view_sys_u2g u2g)
        {
            List<view_sys_u2g> user = new List<view_sys_u2g>();
            string sql = "SELECT * from view_sys_u2g";
            List<SqlParameter> sqlPara = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(u2g.username))
            {
                sql += " and username like @username";
                sqlPara.Add(new SqlParameter("@username", "%" + u2g.username + "%"));
            }
            if (!string.IsNullOrEmpty(u2g.name))
            {
                sql += " and name like @name";
                sqlPara.Add(new SqlParameter("@name", "%" + u2g.name + "%"));
            }

            if (!string.IsNullOrEmpty(u2g.gender))
            {
                sql += " and gender like @gender";
                sqlPara.Add(new SqlParameter("@gender", "%" + u2g.gender + "%"));
            }
            if (!string.IsNullOrEmpty(u2g.job))
            {
                sql += " and job like @job";
                sqlPara.Add(new SqlParameter("@job", "%" + u2g.job + "%"));
            }
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql, sqlPara.ToArray());
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) 
            {
                view_sys_u2g u2g1 = new view_sys_u2g();
                u2g1.id = (int)ds.Tables[0].Rows[i][nameof(view_sys_u2g.id)];
                u2g1.name = (string)ds.Tables[0].Rows[i][nameof(sys_user.name)];
                u2g1.username = (string)ds.Tables[0].Rows[i][nameof(sys_user.username)];
                u2g1.gender = (string)ds.Tables[0].Rows[i][nameof(sys_user.gender)];
                u2g1.phone = (string)ds.Tables[0].Rows[i][nameof(sys_user.phone)];
                u2g1.job = (string)ds.Tables[0].Rows[i][nameof(sys_user.job)];
                u2g1.status = (bool)ds.Tables[0].Rows[i][nameof(view_sys_u2g.status)];
                u2g1.group_name = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.group_name)];
                user.Add(u2g1);               
                }
            return user;
            //return new DBOperationsSelect<sys_user>().SelectByConditions(conditions);
        }
        }
    }

