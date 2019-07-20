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
    public class PermDAL :DALBase
    {
        /// <summary>
        ///添加用户组
        /// </summary>
        /// <param name="group">用户组信息</param>
        /// <returns>返回添加条数</returns>
        public int add(sys_group group)
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
        /// <param name="user_id">用户id</param>
        /// <param name="group_id">用户组id</param>
        /// <returns>返回添加条数</returns>
        public int add(int user_id,int group_id)
        {
            int res;
            string sql = "insert into sys_u2g (user_id,group_id) values(@p1,@p2)";
            SqlParameter sqlparameter = new SqlParameter("@p1", user_id);
            SqlParameter sqlparameter1 = new SqlParameter("@p2", group_id);
            res=SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlparameter, sqlparameter1);
            return res;
        }


        /// <summary>
        /// 用户组权限修改
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newValues">需要修改的值</param>
        /// <returns>修改条数</returns>
        public int Update(sys_group group, List<string> grouplist)
        {
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                SqlConnection conn = new SqlConnection(ConStr);
                SqlCommand command = new SqlCommand();
                SqlTransaction trans = null;
                DataSet ds = new DataSet();
                sys_menu menu = new sys_menu();
                try
                {
                    conn.Open();
                    trans = conn.BeginTransaction();
                    command.Transaction = trans;
                    command.Connection = conn;
                    string sql = "select * from sys_menu where menu_name=@p1";
                    string sql1 = "Insert into sys_g2m(group_id,menu_id) values(@p2,@p3)";
                    foreach (var name in grouplist)
                    {
                        SqlParameter sqlParameter = new SqlParameter("@p1", name);
                        ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, sql, sqlParameter);
                        menu.id = (int)ds.Tables[0].Rows[0][nameof(sys_menu.id)];
                        SqlParameter sqlParameter1 = new SqlParameter("@p2", group.id);
                        SqlParameter sqlParameter2 = new SqlParameter("@p3", menu.id);
                        SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql1, sqlParameter1, sqlParameter2);
                    }
                    trans.Commit();
                    return 1;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    return 0;
                }
            }
        }


        /// <summary>
        /// 用户组关联修改
        /// </summary>
        /// <param name="user_id">用户id</param>
        /// <param name="group_id">用户组id</param>
        /// <returns>返回添加条数</returns>
        public int Update(int user_id, int group_id)
        {
            int res;
            string sql = "update sys_u2g SET group_id= '"+group_id+"' where user_id= '" + user_id + "'";
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
            return res;
        }


        /// <summary>
        /// 删除用户组
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>删除失败与否</returns>
        public int DelG2t(int id)
        {
            int res = 0;            
            string sql= "Delete from sys_g2m where group_id=@p1";           
            SqlParameter sqlparameter1 = new SqlParameter("@p1",id);  
            res=SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlparameter1);
            return res;
        }
        public int Del(int id)
        {
            int res = 0;
            string sql = "Delete from sys_group where id=@p1";
            SqlParameter sqlparameter1 = new SqlParameter("@p1", id);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlparameter1);
            return res;
        }

        /// <summary>
        /// 用户组关联删除
        /// </summary>
        /// <param name="user_id">用户id</param>
        /// <returns>删除条数</returns>
        public int Delu2g(int user_id)
        {
            int res;
            string sql = "delete from sys_u2g where user_id='" + user_id + "'";
            res=SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
            return res;
        }

        /// <summary>
        /// 权限检索,所有
        /// </summary>
        /// <returns>所有权限信息</returns>
        public List<sys_group> Selectall()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from sys_group ";
            ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            List<sys_group> group1 = new List<sys_group>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                sys_group group = new sys_group();
                group.id = (int)ds.Tables[0].Rows[i][nameof(sys_group.id)];
                group.group_name = (string)ds.Tables[0].Rows[i][nameof(sys_group.group_name)];
                group.remark = (string)ds.Tables[0].Rows[i][nameof(sys_group.remark)];
                group.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_group.create_time)];
                group.modify_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_group.modify_time)];
                group1.Add(group);
            }
            return group1;

        }

        /// <summary>
        /// 通过输入条件进行权限检索
        /// </summary>
        /// <param name="conditions">输入条件</param>
        /// <returns>权限信息</returns>
        public List<sys_group> Selectgroup(sys_group group)
        {
            DataSet ds = new DataSet();
            string sql1 = "Select * from sys_group where group_name = @p1 ";
            SqlParameter sqlparameter1 = new SqlParameter("@p1", group.group_name);
            ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql1, sqlparameter1);
            List<sys_group> group2 = new List<sys_group>();        
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                sys_group group1 = new sys_group();
                group1.id = (int)ds.Tables[0].Rows[i][nameof(sys_group.id)];
                group1.group_name= (string)ds.Tables[0].Rows[i][nameof(sys_group.group_name)];  
                group1.remark = (string)ds.Tables[0].Rows[i][nameof(sys_group.remark)];
                group1.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_group.create_time)];
                group1.modify_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_group.modify_time)];
                group2.Add(group1);
            }
            return group2;

           
        }
    }
}
