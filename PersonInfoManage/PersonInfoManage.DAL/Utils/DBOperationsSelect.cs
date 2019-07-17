using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Utils
{
    /// <summary>
    /// 查询操作
    /// </summary>
    public class DBOperationsSelect<T> where T : class
    {
        /// <summary>
        /// 查询操作，更具条件u进行查询
        /// </summary>
        /// <param name="u">查询条件</param>
        /// <returns>查询结果</returns>
        public List<T> SelectByConditions(Dictionary<string, object> whereConditions)
        {
            List<T> result = new List<T>();
            using (var db = new EFModel())
            {
                try
                {
                    string sql = ConditionsToSql<T>.SelectSql(whereConditions);

                    result = db.Database.SqlQuery<T>(sql).ToList();
                }
                catch
                {
                    result.Clear();
                }
            }

            return result;
        }

        /// <summary>
        /// 查询操作，查询所有
        /// </summary>
        /// <returns>查询结果</returns>
        public List<T> SelectAll()
        {
            List<T> result = new List<T>();
            using (var db = new EFModel())
            {
                try
                {
                    var items = from item in db.Set<T>() select item;
                    result = items.ToList();
                }
                catch
                {
                    result.Clear();
                }
            }

            return result;
        }
    }
}
