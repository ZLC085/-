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
    public class SysSetting : DALBase
    {
        /// <summary>
        /// 添加数据字典
        /// </summary>
        /// <param name="sysDict">数据字典</param>
        /// <returns></returns>
        public int Insert(sys_dict sysDict)
        {
            int res = 0;
            string sql = "insert into sys_dict (category_name) values(@p1)";
            SqlParameter sqlParameter = new SqlParameter("@p1", sysDict.category_name);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter);
            return res;
            // return new DBOperationsInsert<sys_dict, DBNull>().Insert(sysDict);
        }

        /// <summary>
        /// 根据id数据字典修改
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newValues">需要更新的值</param>
        /// <returns>修改条数</returns>
        public int Update(int id, sys_dict sysDict)
        {
            int res = 0;
            SqlParameter sqlParameter = new SqlParameter("@p1", sysDict.category_name);
            SqlParameter sqlparameter2 = new SqlParameter("@p2", id);
            string sql = "updata sys_dict set category_name=@p1 where id=@p2";
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter);
            return res;
            //return new DBOperationsUpdate<sys_dict>().UpdateById(id, newValues);
        }

        /// <summary>
        /// 通过Id删除数据字典
        /// </summary>
        /// <param name="id">数据字典id</param>
        /// <returns>删除条数</returns>
        public int Del(int id)
        {
            int res = 0;
            string sql = "delete from sys_dict where id=@p";
            SqlParameter sqlparameter1 = new SqlParameter("@p", id);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
            return res;
            //return new DBOperationsDelete<sys_dict, DBNull>().DeleteById(id);
        }

        /// <summary>
        /// 数据字典检索， 所有
        /// </summary>
        /// <returns>所有数据字典</returns>
        public List<sys_dict> SelectAll()
        {
            sys_dict dict1 = new sys_dict();
            List<sys_dict> dict = new List<sys_dict>();
            DataSet ds = new DataSet();
            string sql = "select * from sys_dict";
            ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dict1.id = (int)ds.Tables[0].Rows[i][nameof(sys_dict.id)];
                dict1.category_name = (string)ds.Tables[0].Rows[i][nameof(sys_dict.category_name)];
                dict1.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_dict.create_time)];
                dict1.modify_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_dict.modify_time)];
                dict.Add(dict1);
            }
            return dict;

        }


    }
}