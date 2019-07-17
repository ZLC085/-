using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Utils
{
    /// <summary>
    /// 删除操作
    /// </summary>
    public class DBOperationsDelete<T, U> where T : class
    {
        /// <summary>
        /// 删除操作，根据id进行删除
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>删除成功条数</returns>
        public int DeleteById(int id)
        {
            int result = 0;
            using (var db = new EFModel())
            {
                try
                {
                    T tt = db.Set<T>().Find(id);
                    if (tt != null)
                    {
                        db.Set<T>().Remove(tt);
                        result = db.SaveChanges();
                    }
                    else
                    {
                        result = 0;
                    }
                }
                catch
                {
                    result = 0;
                }
            }

            return result;
        }

        /// <summary>
        /// 通过事务进行删除操作
        /// </summary>
        /// <param name="conditionKey">删除条件</param>
        /// <param name="conditionValue">删除条件值</param>
        /// <returns>成功删除条数</returns>
        public int DeleteTransaction(string conditionKey, object conditionValue)
        {
            int result = 0;
            using (var db = new EFModel())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        string sql = ConditionsToSql<U>.DeleteSql(conditionKey, conditionValue);
                        int res = db.Database.ExecuteSqlCommand(sql);
                        if (res != 1)
                        {
                            transaction.Rollback();
                            return 0;
                        }
                        result = DeleteById((int)conditionValue);
                        transaction.Commit();
                    }
                    catch
                    {
                        result = 0;
                        transaction.Rollback();
                    }
                }
            }

            return result;
        }
    }
}
