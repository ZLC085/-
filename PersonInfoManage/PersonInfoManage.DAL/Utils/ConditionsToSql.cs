using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                sql += key + " LIKE '%" + value + "%'";

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
            string sql = "UPDATE "+ typeof(T).Name + " SET ";

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
    }
}
