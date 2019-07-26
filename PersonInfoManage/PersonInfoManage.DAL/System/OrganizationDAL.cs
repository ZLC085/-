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
        /// <returns>添加条数</returns>
        public int Add(sys_org org)
        {
            try
            {
                int res = 0;
                string sql = "insert into sys_menu(parent_id,org_name,creat_time,modify_time) values(@p1,@p2,@p3,@p4) where parent_id = @id";
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
        /// <returns>修改条数</returns>
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

        /// <summary>
        /// 删除组织机构
        /// </summary>
        /// <param name="orgid"></param>
        /// <returns>删除条数</returns>
        public int Del(int orgid)
        {
            try
            {
                int res = 0;
                string sql = "delete from sys_org where id=@p1";
                SqlParameter sqlparameter1 = new SqlParameter("@p", orgid);
                res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlparameter1);
                new LogUserDAL().Add(LogOperations.LogUser("删除组织机构"));
                return res;
            }
            catch (Exception e)
            {
                new LogSysDAL().Add(LogOperations.LogSys("删除组织机构" + e.Message));
                return 0;
            }
        }

        /// <summary>
        /// 通过parent_id查询组织机构
        /// </summary>
        /// <param name="pid"></param>
        /// <returns>List<sys_org></returns>
        public List<sys_org> SelectByparentid(int pid)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "Select * from sys_org where parent_id= '" + pid + "'";
                List<sys_org> org = new List<sys_org>();
                ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    sys_org org1 = new sys_org();
                    org1.id = (int)ds.Tables[0].Rows[i][nameof(sys_org.id)];
                    org1.org_name = (string)ds.Tables[0].Rows[i][nameof(sys_org.org_name)];
                    org1.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_org.create_time)];
                    org1.modify_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_org.modify_time)];
                    org.Add(org1);
                }
                new LogUserDAL().Add(LogOperations.LogUser("查询组织机构"));
                return org;
            }
            catch (Exception e)
            {
                new LogSysDAL().Add(LogOperations.LogSys("查询组织机构" + e.Message));
                return null;
            }
        }
            /// <summary>
            /// 查询组织机构
            /// </summary>
            /// <returns>List<sys_org></returns>
        public List<sys_org> SelectByName(string orgname)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "Select * from sys_org where org_name='"+orgname+"'";
                List<sys_org> org = new List<sys_org>();
                ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    sys_org org1 = new sys_org();
                    org1.id = (int)ds.Tables[0].Rows[i][nameof(sys_org.id)];
                    org1.org_name = (string)ds.Tables[0].Rows[i][nameof(sys_org.org_name)];
                    org1.create_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_org.create_time)];
                    org1.modify_time = (DateTime)ds.Tables[0].Rows[i][nameof(sys_org.modify_time)];
                    org.Add(org1);
                }
                return org;
            }
            catch (Exception e)
            {
                new LogSysDAL().Add(LogOperations.LogSys("查询组织机构" + e.Message));
                return null;
            }

        }
    }
}
