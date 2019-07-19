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
        /// <returns>
        /// 返回修改条数
        /// </returns>
        public int Add(sys_dict sysDict)
        {
            int res = 0;
            string sql = "insert into sys_dict (dict_name,category_name,create_time,modify_time) values(@p2,@p1,getdate(),getdate())";
            SqlParameter sqlParameter = new SqlParameter("@p1", sysDict.category_name);
            SqlParameter sqlParameter2 = new SqlParameter("@p2", sysDict.dict_name);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter,sqlParameter2);
            return res;
            // return new DBOperationsInsert<sys_dict, DBNull>().Insert(sysDict);
        }

        /// <summary>
        /// 根据id进行数据字典修改
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newValues">需要更新的值</param>
        /// <returns>修改条数</returns>
        public int Update(sys_dict sysDict)
        {
            int res = 0;
            SqlParameter sqlParameter = new SqlParameter("@p1", sysDict.category_name);
            SqlParameter sqlparameter2 = new SqlParameter("@p2", sysDict.id);
            SqlParameter sqlparameter3 = new SqlParameter("@p3", sysDict.dict_name);
            string sql = "update sys_dict set category_name = @p1,dict_name = @p3 where id = @p2";
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter, sqlparameter2,sqlparameter3);
            return res;
            
        }

        /// <summary>
        /// 通过Id删除数据字典
        /// </summary>
        /// <param name="id">数据字典id</param>
        /// <returns>删除条数</returns>
        public int Del(sys_dict sysDict)
        {
            int res = 0;
            string sql = "delete from sys_dict where id=@p";
            SqlParameter sqlparameter1 = new SqlParameter("@p", sysDict.id);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlparameter1);
            return res;
           
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
                dict1.dict_name = (string)ds.Tables[0].Rows[i][nameof(sys_dict.dict_name)];
                dict1.category_name = (string)ds.Tables[0].Rows[i][nameof(sys_dict.category_name)];
                dict1.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_dict.create_time)];
                dict1.modify_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_dict.modify_time)];
                dict.Add(dict1);
            }
            return dict;

        }


    }
}