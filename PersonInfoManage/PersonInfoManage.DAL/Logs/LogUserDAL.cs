﻿using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Logs
{
    /// <summary>
    /// 用户日志
    /// </summary 
    public class LogUserDAL : DALBase
    {
        /// <summary>
        /// 用户日志删除根据日志ID
        /// </summary>
        /// <param name="id">用户日志id</param>
        /// <returns>删除条数</returns>
        public int Del(int id)
        {
            int res;
            string sql = "delete from log_user where id='" + id + "'";
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
            return res;
        }

        /// <summary>
        /// 用户日志删除根据用户ID
        /// </summary>
        /// <param name="UserId">用户id</param>
        /// <returns>删除条数</returns>
        public int DelUser(int UserId)
        {
            int res;
            string sql = "delete from log_user where user_id='" + UserId + "'";
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
            return res;
        }

        /// <summary>
        /// 用户日志查询，所有
        /// </summary>
        /// <returns>所有用户日志</returns>
        public List<log_user> Query()
        {
            List<log_user> loguser = new List<log_user>();
            string sql = "select * from log_user ";
            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                log_user user = new log_user();
                user.id = (int)ds.Tables[0].Rows[i][nameof(log_user.id)];
                user.user_id = (int)ds.Tables[0].Rows[i][nameof(log_user.user_id)];
                user.username = (string)ds.Tables[0].Rows[i][nameof(log_user.username)];
                user.operation = (string)ds.Tables[0].Rows[i][nameof(log_user.operation)];
                user.ip = (string)ds.Tables[0].Rows[i][nameof(log_user.ip)];
                user.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(log_user.create_time)];
                loguser.Add(user);
            }
            return loguser;
        }


        /// <summary>
        /// 通过输入条件查询用户日志
        /// </summary>
        /// <param name="conditions">输 入条件</param>
        /// <returns>通过输入条件查询到的用户日志</returns>
        /// 
        public  List<log_user> Query(string username,DateTime create_time)
        {
            List<log_user> userlog = new List<log_user>();
            string sql = "select * from log_user where username='"+username+ "'and create_time>='" + new DateTime(create_time.Year, create_time.Month, create_time.Day, 0, 0, 0) + "'and create_time<='" + new DateTime(create_time.Year, create_time.Month, create_time.Day, 23, 59, 59) + "'";
            Console.WriteLine(sql);
            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                log_user user = new log_user();
                user.id = (int)ds.Tables[0].Rows[i][nameof(log_user.id)];
                user.user_id = (int)ds.Tables[0].Rows[i][nameof(log_user.user_id)];
                user.username = (string)ds.Tables[0].Rows[i][nameof(log_user.username)];
                user.operation = (string)ds.Tables[0].Rows[i][nameof(log_user.operation)];
                user.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(log_user.create_time)];
                user.ip = (string)ds.Tables[0].Rows[i][nameof(log_user.ip)];
                userlog.Add(user);
            }
            return userlog;
        }      
        }
       
    }








