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
    public class SysSettingDAL : DALBase
    {

        /// <summary>
        /// 添加数据字典
        /// </summary>
        /// <param name="SysDict">数据字典</param>
        /// <returns>
        /// 返回修改条数
        /// </returns>
        public int Add(sys_dict SysDict)
        {
            int res = 0;
            string sql = "insert into sys_dict (category_name,create_time,modify_time) values(@p1,getdate(),getdate()) where dict_name = @p2";
            SqlParameter sqlParameter = new SqlParameter("@p1", SysDict.category_name);
            SqlParameter sqlParameter2 = new SqlParameter("@p2", SysDict.dict_name);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter, sqlParameter2);
            return res;
           

        }

        /// <summary>
        /// 根据id进行数据字典修改
        /// </summary>
        /// <param name="SysDict">数据字典信息</param>
        /// <returns>修改修改条数</returns>
        public int Update(sys_dict SysDict)
        {
            int res = 0;
            SqlParameter sqlParameter = new SqlParameter("@p1", SysDict.category_name);
            SqlParameter sqlparameter2 = new SqlParameter("@p2", SysDict.id);

            string sql = "update sys_dict set category_name = @p1,modify_time = getdate() where id = @p2";
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter, sqlparameter2);
            return res;

        }
        /// <summary>
        /// 通过Id删除数据字典
        /// </summary>
        /// <param name="id">数据字典id</param>
        /// <returns>返回删除条数</returns>
        public int Del(int id)
        {
            int res = 0;
            string sql = "delete from sys_dict where id=@p";
            SqlParameter sqlparameter1 = new SqlParameter("@p", id);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlparameter1);
            return res;          
        }

        /// <summary>
        /// 数据字典检索
        /// </summary>
        /// <returns>数据字典list表</returns>
        public List<sys_dict> SelectAll()
        {
            List<sys_dict> dict = new List<sys_dict>();
            DataSet ds = new DataSet();
            string sql = "select * from sys_dict";
            ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                sys_dict dict1 = new sys_dict();
                dict1.id = (int)ds.Tables[0].Rows[i][nameof(sys_dict.id)];
                dict1.dict_name = (string)ds.Tables[0].Rows[i][nameof(sys_dict.dict_name)];
                dict1.category_name = (string)ds.Tables[0].Rows[i][nameof(sys_dict.category_name)];
                dict1.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_dict.create_time)];
                dict1.modify_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_dict.modify_time)];
                dict.Add(dict1);
            }
            return dict;
        }
        public List<string> SelectAllDictName()
        {
            DataSet ds = new DataSet();
            List<string> dict = new List<string>();
            string sql = "select dict_name from sys_dict group by dict_name";
            ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string name;
                name = (string)ds.Tables[0].Rows[i][nameof(sys_dict.dict_name)];
                dict.Add(name);
            }

            return dict;
        }
        /// <summary>
        /// 返回数据字典
        /// </summary>
        /// <param name="info">字典名</param>
        /// <returns>List类型</returns>
        public List<sys_dict> GetTheType(string info)
        {
            // 用于返回的列表
            List<sys_dict> list = new List<sys_dict>();
            try
            {
                // sql语句
                string sql = "select id, category_name from sys_dict where dict_name = N'" + info + "'";

                DataSet ds = new DataSet();
                // 执行sql语句并返回数据集
                ds = SqlHelper.ExecuteDataset(DALBase.ConStr, CommandType.Text, sql);
                // 遍历表中的行
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    // 封装
                    sys_dict sd = new sys_dict();
                    sd.id = int.Parse(dr[0].ToString());
                    sd.category_name = dr[1].ToString();
                    list.Add(sd);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            // 返回列表
            return list;
        }
    }
}