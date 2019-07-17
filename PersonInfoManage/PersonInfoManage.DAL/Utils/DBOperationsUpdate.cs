using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Utils
{
    /// <summary>
    /// 更新操作
    /// </summary>
    public class DBOperationsUpdate<T> where T : class
    {
        /// <summary>
        /// 更新操作，通过id进行更新
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="t">更新对象</param>
        /// <returns>更新成功条数</returns>
        public int UpdateById(int id, Dictionary<string, object> newValues)
        {
            int result = 0;
            using (var db = new EFModel())
            {
                try
                {
                    string sql = ConditionsToSql<T>.UpdateSql(id, newValues);

                    result = db.Database.ExecuteSqlCommand(sql);
                }
                catch
                {
                    result = 0;
                }
            }

            return result;
        }
    }
}
