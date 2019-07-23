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
    /// 用户组管理
    /// </summary>
    public class PermDAL : DALBase
    {
        /// <summary>
        ///添加用户组
        /// </summary>
        /// <param name="group">用户组信息</param>
        /// <returns>添加条数</returns>
        public int Add(sys_group group)
        {
            int res;
            string sql1 = "Insert into sys_group(group_name,remark,create_time,modify_time) values(@p1,@p2,getdate(),getdate())";
            SqlParameter sqlparameter1 = new SqlParameter("@p1", group.group_name);
            SqlParameter sqlparameter2 = new SqlParameter("@p2", group.remark);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql1, sqlparameter1, sqlparameter2);
            return res;

        }


        /// <summary>
        /// 关联用户与用户组
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="groupId">用户组id</param>
        /// <returns>返回添加条数</returns>
        public int AddU2g(int groupId, int userId)
        {
            int res;
            string sql = "insert into sys_u2g (user_id,group_id) values(@p1,@p2)";
            SqlParameter sqlparameter = new SqlParameter("@p1", userId);
            SqlParameter sqlparameter1 = new SqlParameter("@p2", groupId);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlparameter, sqlparameter1);
            return res;
        }


        /// <summary>
        /// 用户组权限添加
        /// </summary>
        /// <param name="groupId">用户组id</param>
        /// <param name="menuId">权限id</param>
        /// <returns>添加条数</returns>
        public int AddG2m(int groupId, int menuId)
        {

            int res;
            string sql = "Insert into sys_g2m(group_id,menu_id) values(@p1,@p2)";
            SqlParameter sqlParameter1 = new SqlParameter("@p1", groupId);
            SqlParameter sqlParameter2 = new SqlParameter("@p2", menuId);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter1, sqlParameter2);
            return res;
        }

        /// <summary>
        /// 用户组信息修改
        /// </summary>
        /// <param name="group">用户组信息</param>
        /// <returns>返回修改条数</returns>
        public int Update(sys_group group)
        {
            int res;
            string sql = "update sys_group set group_name = @p2,remark = @p3,modify_time = getdate() where id= @p1";
            SqlParameter sqlParameter1 = new SqlParameter("@p1", group.id);
            SqlParameter sqlParameter2 = new SqlParameter("@p2", group.group_name);
            SqlParameter sqlParameter3 = new SqlParameter("@p3", group.remark);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter1, sqlParameter2,sqlParameter3);
            return res;

        }


        /// <summary>
        /// 删除用户组和权限关联
        /// </summary>
        /// <param name="groupId">用户组id</param>
        /// <param name="menuId">权限id</param>
        /// <returns>删除条数</returns>
        public int DelG2m(int groupId,int menuId)
        {
            int res = 0;
            string sql = "Delete from sys_g2m where group_id='" + groupId + "' and menu_id='" + menuId + "'";
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
            return res;
        }

        /// <summary>
        /// 删除用户组
        /// </summary>
        /// <param name="id">用户组id</param>
        /// <returns>删除条数</returns>
        public int Del(int id)
        {
            string sql1 = "delete from sys_g2m where group_id='" + id + "'";
            string sql2 = "delete from sys_u2g where group_id='" + id + "'";
            string sql3 = "delete from sys_group where id='" + id + "'";
            List<String> SQLStringList = new List<string>();
            SQLStringList.Add(sql1);
            SQLStringList.Add(sql2);
            SQLStringList.Add(sql3);
            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlTransaction tx = conn.BeginTransaction();
                cmd.Transaction = tx;
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
                    tx.Commit();
                    return count;
                }
                catch (Exception e)
                {
                    tx.Rollback();
                    Console.WriteLine(e.Message);
                    return 0;
                }
                finally
                {
                    conn.Close();
                    tx.Dispose();
                    conn.Dispose();
                }
            }           
        }

        /// <summary>
        /// 删除用户组和用户关联
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="groupId">用户id</param>
        /// <returns>删除条数</returns>
        public int DelG2u(int groupId,int userId)
        {
            int res;
            string sql = "delete from sys_u2g where user_id='" + userId + "' and group_id= '" + groupId + "' ";
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
            return res;
        }


        /// <summary>
        /// 查询用户组基本信息
        /// </summary>
        /// <param name="group">查询条件</param>
        /// <returns>用户组信息</returns>
        public List<sys_group> SelectGroup(sys_group group)
        {
            DataSet ds = new DataSet();
            string sql = "Select * from sys_group where group_name=@group_name";
            List<SqlParameter> sqlPara = new List<SqlParameter>();
            sqlPara.Add(new SqlParameter("@group_name", group.group_name));
            sql += " and create_time >= @createtime";
            sqlPara.Add(new SqlParameter("@createtime", group.create_time));
            sql += " and modify_time <= @modifytime";
            sqlPara.Add(new SqlParameter("@modifytime", group.modify_time));
            List<sys_group> group2 = new List<sys_group>();
            try
            {
                ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql, sqlPara.ToArray());
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    sys_group group1 = new sys_group();
                    group1.id = (int)ds.Tables[0].Rows[i][nameof(sys_group.id)];
                    group1.group_name = (string)ds.Tables[0].Rows[i][nameof(sys_group.group_name)];
                    group1.remark = (string)ds.Tables[0].Rows[i][nameof(sys_group.remark)];
                    group1.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_group.create_time)];
                    group1.modify_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_group.modify_time)];
                    group2.Add(group1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return group2;
        }

        /// <summary>
        /// 查询用户组中的用户
        /// </summary>
        /// <param name="groupId">用户组id</param>
        /// <returns>用户组信息</returns>
        public List<view_sys_u2g> SelectU2g(int groupId)
        {
            DataSet ds = new DataSet();
            string sql = "Select * from view_sys_u2g where group_id= '"+groupId+"'";
            List<view_sys_u2g> group = new List<view_sys_u2g>();
            ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                view_sys_u2g group1 = new view_sys_u2g();
                group1.group_name = (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.group_name)];
                group1.username= (string)ds.Tables[0].Rows[i][nameof(view_sys_u2g.username)];
                group.Add(group1);
            }
            return group;
        }

        /// <summary>
        /// 查询用户组所有权限
        /// </summary>
        /// <param name="groupId">用户组id</param>
        /// <returns>用户组信息</returns>
        public List<view_sys_g2m> SelectG2m(int groupId)
        {
            DataSet ds = new DataSet();
            string sql = "Select * from view_sys_g2m where id= '" + groupId + "'";
            List<view_sys_g2m> group = new List<view_sys_g2m>();
            ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                view_sys_g2m group1 = new view_sys_g2m();
                group1.group_name = (string)ds.Tables[0].Rows[i][nameof(view_sys_g2m.group_name)];
                group1.menu_name = (string)ds.Tables[0].Rows[i][nameof(view_sys_g2m.menu_name)];
                group.Add(group1);
            }
            return group;
        }
    }
    }

