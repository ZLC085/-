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
    public class PermDAL : DALBase
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
        public int add(int user_id, int group_id)
        {
            int res;
            string sql = "insert into sys_u2g (user_id,group_id) values(@p1,@p2)";
            SqlParameter sqlparameter = new SqlParameter("@p1", user_id);
            SqlParameter sqlparameter1 = new SqlParameter("@p2", group_id);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlparameter, sqlparameter1);
            return res;
        }


        /// <summary>
        /// 用户组权限修改
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newValues">需要修改的值</param>
        /// <returns>修改条数</returns>
        public int Updateg2m(int menu_id, int group_id)
        {

            int res;
            string sql1 = "Insert into sys_g2m(group_id,menu_id) values(@p1,@p2)";
            SqlParameter sqlParameter1 = new SqlParameter("@p1", group_id);
            SqlParameter sqlParameter2 = new SqlParameter("@p2", menu_id);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql1, sqlParameter1, sqlParameter2);
            return res;
        }
    


        /// <summary>
        /// 用户组关联修改
        /// </summary>
        /// <param name="user_id">用户id</param>
        /// <param name="group_id">用户组id</param>
        /// <returns>返回添加条数</returns>
        public int Updateu2g(int user_id, int group_id)
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
        public int DelG2m(int id)
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

            //string sql = "SELECT dbo.sys_user.create_time, dbo.sys_user.email, dbo.sys_user.gender, dbo.sys_user.id, dbo.sys_user.job,"
            //     + "dbo.sys_user.modify_time, dbo.sys_user.name, dbo.sys_user.password,dbo.sys_user.phone,dbo.sys_user.status,"
            //     + "dbo.sys_user.username,dbo.sys_group.id AS group_id,dbo.sys_group.remark,dbo.sys_group.group_name"
            //     + "FROM dbo.sys_user INNER JOIN dbo.sys_u2g ON dbo.sys_u2g.user_id = dbo.sys_user.id INNER JOIN dbo.sys_group "
            //     + "ON dbo.sys_u2g.group_id = dbo.sys_group.id  ";
            //List<SqlParameter> sqlPara = new List<SqlParameter>();
            //if (!string.IsNullOrEmpty(user.username))
            //{
            //    sql += " and username like @username";
            //    sqlPara.Add(new SqlParameter("@username", "%" + user.username + "%"));
            //}
            //if (!string.IsNullOrEmpty(user.name))
            //{
            //    sql += " and name like @name";
            //    sqlPara.Add(new SqlParameter("@name", "%" + user.name + "%"));
            //}

            //if (!string.IsNullOrEmpty(user.gender))
            //{
            //    sql += " and gender like @gender";
            //    sqlPara.Add(new SqlParameter("@gender", "%" + user.gender + "%"));
            //}
            //if (!string.IsNullOrEmpty(user.phone))
            //{
            //    sql += " and phone like @phone";
            //    sqlPara.Add(new SqlParameter("@phone", "%" + user.phone + "%"));
            //}
        
        }
    }
}
