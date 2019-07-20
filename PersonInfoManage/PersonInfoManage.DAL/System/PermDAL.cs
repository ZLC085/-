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
        /// <returns>返回添加条数</returns>
        public int add(sys_group group)
        {
            int res;
            string sql1 = "Insert into sys_group(group_name,remark,create_time,modify_time) values(@p1,@p2,@p3,@p4)";
            SqlParameter sqlparameter1 = new SqlParameter("@p1", group.group_name);
            SqlParameter sqlparameter2 = new SqlParameter("@p2", group.remark);
            SqlParameter sqlparameter3 = new SqlParameter("@p3", group.create_time);
            SqlParameter sqlparameter4 = new SqlParameter("@p4", group.modify_time);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql1, sqlparameter1, sqlparameter2, sqlparameter3, sqlparameter4);
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
            string sql = "update sys_u2g SET group_id= '" + group_id + "' where user_id= '" + user_id + "'";
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
            return res;
        }


        /// <summary>
        /// 删除用户组和权限关联
        /// </summary>
        /// <param name="id">用户组id</param>
        /// <returns>删除条数</returns>
        public int DelG2m(int id)
        {
            int res = 0;
            string sql = "Delete from sys_g2m where group_id=@p1";
            SqlParameter sqlparameter1 = new SqlParameter("@p1", id);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlparameter1);
            return res;
        }

        /// <summary>
        /// 删除用户组
        /// </summary>
        /// <param name="id">用户组id</param>
        /// <returns>删除条数</returns>
        public int Del(int id)
        {
            int res = 0;
            string sql = "Delete from sys_group where id=@p1";
            SqlParameter sqlparameter1 = new SqlParameter("@p1", id);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlparameter1);
            return res;
        }

        /// <summary>
        /// 删除用户组关联用户
        /// </summary>
        /// <param name="user_id">用户id</param>
        /// <returns>删除条数</returns>
        public int Delu2g(int user_id)
        {
            int res;
            string sql = "delete from sys_u2g where user_id='" + user_id + "'";
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
            return res;
        }



        /// <summary>
        /// 通过输入条件进行权限检索
        /// </summary>
        /// <param name="conditions">输入条件</param>
        /// <returns>权限信息</returns>
        public List<sys_group> Selectgroup(sys_group group)
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
    }
}
