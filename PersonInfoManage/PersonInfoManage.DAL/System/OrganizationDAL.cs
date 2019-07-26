using PersonInfoManage.DAL.Logs;
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
        /// 添加组织机构
        /// </summary>
        /// <param name="org"></param>
        /// <returns></returns>
        public int Add(sys_org org)
        {
            try
            {
                int res = 0;
                string sql = "insert into sys_menu(parent_id,org_name,creat_time,modify_time) values(@p1,@p2,@p3,@p4)";
                SqlParameter sqlParameter1 = new SqlParameter("@p1", org.parent_id);
                SqlParameter sqlParameter2 = new SqlParameter("@p2", org.org_name);
                SqlParameter sqlParameter3 = new SqlParameter("@p3", org.create_time);
                SqlParameter sqlParameter4 = new SqlParameter("@p4", org.modify_time);
                res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4);
                new LogUserDAL().Add(LogOperations.LogUser("添加组织机构"));
                return res;
            }
            catch(Exception e)
            {
                new LogSysDAL().Add(LogOperations.LogSys(e.Message));
                return 0;
            }
            
        }

        /// <summary>
        /// 修改组织机构
        /// </summary>
        /// <param name="org"></param>
        /// <returns></returns>
        public int Update(sys_org org)
        {
            try
            {
                int res = 0;
                string sql = "upadate sys_menu SET parent_id = @p1,org_name = @p2,create_time = @p3,modify_time = @p4 where id = '" + org.id + "'";
                SqlParameter sqlParameter1 = new SqlParameter("@p1", org.parent_id);
                SqlParameter sqlParameter2 = new SqlParameter("@p2", org.org_name);
                SqlParameter sqlParameter3 = new SqlParameter("@p3", org.create_time);
                SqlParameter sqlParameter4 = new SqlParameter("@p4", org.modify_time);
                res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4);
                new LogUserDAL().Add(LogOperations.LogUser("修改组织机构"));
                return res;
            }
            catch (Exception e)
            {
                new LogSysDAL().Add(LogOperations.LogSys(e.Message));
                return 0;
            }
        }

        //public int Del(int orgid)
        //{
        //    string sql = "delete from sys_org where id='" + orgid + "'";
        //}

        /// <summary>
        /// 通过id查询组织机构
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<sys_org> SelectById(int id)
        {
            try
            {
                List<sys_org> org = new List<sys_org>();
                string sql = "SELECT * from sys_org where id = '" + id + "'";
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    sys_org orgs = new sys_org();
                    orgs.id = (int)ds.Tables[0].Rows[i][nameof(sys_org.id)];
                    orgs.parent_id = (int)ds.Tables[0].Rows[i][nameof(sys_org.parent_id)];
                    orgs.org_name = (string)ds.Tables[0].Rows[i][nameof(sys_org.org_name)];
                    orgs.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_org.create_time)];
                    orgs.modify_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_org.modify_time)];
                    org.Add(orgs);
                }
                new LogUserDAL().Add(LogOperations.LogUser("查询组织机构"));
                return org;
            }
            catch (Exception e)
            {
                new LogSysDAL().Add(LogOperations.LogSys(e.Message));
                return null;
            }
        }
    }
}
