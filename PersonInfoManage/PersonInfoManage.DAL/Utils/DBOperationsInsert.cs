using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Utils
{
    /// <summary>
    /// 插入操作
    /// </summary>
    /// <typeparam name="T">泛型参数一</typeparam>
    /// <typeparam name="U">泛型参数二</typeparam>
    public class DBOperationsInsert<T, U> where T : class where U : class
    {
        /// <summary>
        /// 插入操作
        /// </summary>
        /// <param name="t">插入的对象</param>
        /// <returns>插入成功条数</returns>
        public int Insert(T t)
        {
            int result = 0;
            using (var db = new EFModel())
            {
                try
                {
                    db.Set<T>().Add(t);
                    result = db.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    Console.WriteLine(e.Message);
                    result = 0;
                }
            }

            return result;
        }

        /// <summary>
        /// 插入操作
        /// </summary>
        /// <param name="u">插入的对象</param>
        /// <returns>插入成功条数</returns>
        private int Insert(U u)
        {
            int result = 0;
            using (var db = new EFModel())
            {
                try
                {
                    db.Set<U>().Add(u);
                    result = db.SaveChanges();
                }
                catch
                {
                    result = 0;
                }
            }

            return result;
        }

        /// <summary>
        /// 通过事务进行查询操作
        /// </summary>
        /// <param name="t">第一个对象</param>
        /// <param name="u">第二个对象List</param>
        /// <returns>插入成功条数</returns>
        public int InsertByTransaction(T t, List<U> u)
        {
            int result = 0;
            using (var db = new EFModel())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        result = Insert(t);

                        if (u != null)
                        {
                            foreach (var item in u)
                            {
                                int res = Insert(item);
                                if (res != 1)
                                {
                                    transaction.Rollback();
                                    return 0;
                                }
                            }
                        }

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
