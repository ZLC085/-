using System.Collections.Generic;
using System.Linq;
using System;
using System.Reflection;

namespace PersonInfoManage.DAL.Utils
{
    public class ConditionsToSql<T>
    {
        /// <summary>
        /// 将所给的条件参数转为查询sql语句
        /// </summary>
        /// <param name="conditions">条件参数字典</param>
        /// <returns>查询sql语句</returns>
        public static string SelectSql(Dictionary<string, object> conditions)
        {
            string sql = "SELECT * FROM " + typeof(T).Name + " where ";

            foreach (KeyValuePair<string, object> kv in conditions)
            {
                string key = kv.Key;
                object value = kv.Value;

                sql += key + "LIKE %" + value + "%'";

                if (!key.Equals(conditions.Last().Key))
                {
                    sql += " AND ";
                }
            }

            return sql;
        }

        /// <summary>
        /// 将所给的条件参数转为更新sql语句
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newValues">更新参数</param>
        /// <returns>更新sql语句</returns>
        public static string UpdateSql(int id, Dictionary<string, object> newValues)
        {
            string sql = "UPDATE " + typeof(T).Name + " SET ";

            foreach (KeyValuePair<string, object> kv in newValues)
            {
                string key = kv.Key;
                object value = kv.Value;

                sql += key + "='" + value + "'";

                if (!key.Equals(newValues.Last().Key))
                {
                    sql += ",";
                }
            }
            sql += " WHERE id=" + id;

            return sql;
        }

        /// <summary>
        /// 将所给的条件参数转为删除sql语句
        /// </summary>
        /// <param name="conditionKey">key</param>
        /// <param name="conditionValue">value</param>
        /// <returns>删除sql语句</returns>
        public static string DeleteSql(string conditionKey, object conditionValue)
        {
            string sql = "DELETE FROM " + typeof(T) + " WHERE " + conditionKey + "=" + conditionValue;

            return sql;
        }
        /// <summary>
        /// 将所给的数据对象转化为插入sql语句
        /// </summary>
        /// <param name="t">封装好的数据对象</param>
        /// <returns>插入sql语句</returns>
        public static string InsertSql(T t)
        {
            if (t ==null)
            {
                return null;
            }
            var properties = typeof(T).GetProperties();
            string sql = "insert into " + typeof(T).Name + "(";
            foreach (PropertyInfo info in properties)
            {
                
                if (info.Name.Equals("id") && !typeof(T).Name.Equals("cost_main"))
                {   //id是自增(除了cost_main表)，不需要加在sql语句里面
                    continue;
                }

                sql = sql.Insert(sql.Length, info.Name);
                if (!info.Equals(properties.Last()))
                {   //最后一个数据的处理
                    sql = sql.Insert(sql.Length, ",");
                }
                else
                {
                    sql = sql.Insert(sql.Length, ") values(");
                }
                
            }
            foreach (PropertyInfo info in properties)
            {
                if (info.Name.Equals("id") && !typeof(T).Name.Equals("cost_main"))
                {   //id是自增(除了cost_main表)，不需要加在sql语句里面
                    continue;
                }
                if (info.PropertyType.FullName.Equals("System.String"))
                {   //对字符串数据的中文处理    
                    sql = sql.Insert(sql.Length, "N'" + t.GetType().GetProperty(info.Name).GetValue(t) + "'");
                }
                else
                {   if(info.Name.Equals("id"))
                    {
                        sql = sql.Insert(sql.Length, "'" + TimeTools.Timestamp() + "'");
                    }
                    else
                    {
                        sql = sql.Insert(sql.Length, "'" + t.GetType().GetProperty(info.Name).GetValue(t) + "'");
                    }                
                    
                }   
                             
                if (!info.Equals(properties.Last()))
                {   //最后一个数据的处理
                    sql = sql.Insert(sql.Length, ",");
                }
                else
                {
                    sql = sql.Insert(sql.Length, ");");
                }
            }
            return sql;
        }
    }
}
