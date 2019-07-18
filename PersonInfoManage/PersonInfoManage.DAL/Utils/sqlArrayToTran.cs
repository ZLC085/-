using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Utils
{
    public class sqlArrayToTran:DALBase
    {
        /// <summary>
        /// 将sqlString数组里的sql语句使用事务写入数据库
        /// </summary>
        /// <param name="sqlArray">sql语句数组</param>
        /// <returns>数据表受影响的行数</returns>
        public static int doTran(string[] sqlArray)
        {
            int res = 0;
            SqlConnection conn = new SqlConnection(ConStr);
            SqlCommand command = new SqlCommand();
            SqlTransaction tran = null;
            try
            {
                conn.Open();
                tran = conn.BeginTransaction();
                command.Transaction = tran;
                command.Connection = conn;

                foreach (string sql in sqlArray)
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;
                    res += command.ExecuteNonQuery();

                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                tran.Rollback();
                return 0;
            }
            finally
            {
                conn.Close();
            }
            return res;
        }
    }
}
