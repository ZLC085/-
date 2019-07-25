using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.System
{
    /// <summary>
    /// 组织机构管理
    /// </summary>
    public class OrganizationDAL:DALBase
    {
        /// <summary>
        ///添加组织机构
        /// </summary>
        /// <param name="org">用户组信息</param>
        /// <returns>添加条数</returns>
        public int Add(sys_org org)
        {
            int res = 0;
            string sql = "insert into sys_menu(parent_id,org_name,creat_time,modify_time) values(@p1,@p2,@p3,@p4)";
            SqlParameter sqlParameter1 = new SqlParameter("@p1", org.parent_id);
            SqlParameter sqlParameter2 = new SqlParameter("@p2", org.org_name);
            SqlParameter sqlParameter3 = new SqlParameter("@p3", org.create_time);
            SqlParameter sqlParameter4 = new SqlParameter("@p4", org.modify_time);
            try
            {
                res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return res;
        }

    }
}
