using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PersonInfoManage.DAL.Cost
{
    /// <summary>
    /// 费用申请
    /// </summary>
    public class CostApply:DALBase
    {
        /// <summary>
        /// 添加费用单
        /// </summary>
        /// <param name="costMain">费用单</param>
        /// <param name="detailList">费用明细</param>
        /// <returns>插入条数</returns>
        public int Add(cost_main costMain, List<cost_detail> detailList)
        {
            int res = 0;
            string[] sqlArray = new string[1 + detailList.Count];
            costMain.approval_time = new DateTime(1754, 01, 01);
            costMain.approval_money = 0;
            sqlArray[0] = ConditionsToSql<cost_main>.InsertSql(costMain);

            
            int count = 0;
            foreach(cost_detail detail in detailList)
            {
                sqlArray[count + 1] = ConditionsToSql<cost_detail>.InsertSql(detail);
                count++;
            }

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
                    command.ExecuteNonQuery();
                    res++;
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return 0;
            }
            finally
            {
                conn.Close();
            }
            return res;            
        }


        /// <summary>
        /// 更新费用单信息
        /// </summary>
        /// <param name="costMain">费用单</param>
        /// <param name="detailList">费用详情列表</param>
        /// <returns>更新记录的行数</returns>
        public int Update(cost_main costMain, List<cost_detail> detailList)
        {
            int res = 0;

            string[] sqlArray = new string[1+detailList.Count];
            sqlArray[0]= "update cost_main set " +
                nameof(cost_main.apply_money) + "=" + costMain.apply_money +
                " where id='" + costMain.id + "'";
            int count = 0;
            foreach (cost_detail detail in detailList)
            {
                string querySql = "select * from cost_detail where " + nameof(cost_detail.cost_id) + "='" + detail.cost_id + "' and " + nameof(cost_detail.cost_type) + "='" + detail.cost_type + "'";
                DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, querySql);
                if (ds.Tables.Count == 0)
                {
                    //说明表中原没有这一项费用
                    sqlArray[count + 1] = ConditionsToSql<cost_detail>.InsertSql(detail);
                }
                else
                {
                    //说明原表中有相应数据
                    sqlArray[count + 1] = "update cost_detail set " + nameof(cost_detail.cost_type) +
                    "='" + detail.cost_type + "', " + nameof(cost_detail.money) + "=" + detail.money +
                    " where id='" + detail.id + "'";
                }
                count++;
            }
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
                tran.Rollback();
                return 0;
            }
            finally
            {
                conn.Close();
            }
            return res;            
        }

        /// <summary>
        /// 撤销费用单
        /// </summary>
        /// <param name="costMain">费用单</param>
        /// <returns>删除记录数</returns>
        public int Del(cost_main costMain)
        {
            int res = 0;
            string[] sqlArray = new string[2];
            sqlArray[0] = "delete from cost_main where id='"+costMain.id+"'";
            sqlArray[1] = "delete from cost_detail where "+nameof(cost_detail.cost_id)+"="+costMain.id;

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
                tran.Rollback();
                return 0;
            }
            finally
            {
                conn.Close();
            }
            return res;
            //return new DBOperationsDelete<cost_main, cost_detail>().DeleteTransaction(nameof(cost_detail.cost_id), costId);
        }

        /// <summary>
        /// 费用单查询，通过费用单编号
        /// </summary>
        /// <param name="id">费用单编号</param>
        /// <returns>通过费用单编号查询到的费用单</returns>
        public Dictionary<cost_main, List<cost_detail>> GetById(int id)
        {
            Dictionary<cost_main, List<cost_detail>> bills = new Dictionary<cost_main, List<cost_detail>>();
            cost_main main = new cost_main();
            List<cost_detail> listDetail = new List<cost_detail>();

            string sql1 = "select * from cost_main where id='"+id+"'";
            string sql2 = "select * from cost_detail where cost_id='" + id + "'";

            DataSet ds1 = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql1);

            main.id=int.Parse((string)ds1.Tables[0].Rows[0][nameof(cost_main.id)]);
            main.applicant = (string)ds1.Tables[0].Rows[0][nameof(cost_main.applicant)];
            main.approver = (string)ds1.Tables[0].Rows[0][nameof(cost_main.approver)];
            main.apply_time = (DateTime)ds1.Tables[0].Rows[0][nameof(cost_main.apply_time)];
            main.approval_time = (DateTime)ds1.Tables[0].Rows[0][nameof(cost_main.approval_time)];
            main.apply_money = (decimal)ds1.Tables[0].Rows[0][nameof(cost_main.apply_money)];
            main.approval_money = (decimal)ds1.Tables[0].Rows[0][nameof(cost_main.approval_money)];
            main.status =(byte)ds1.Tables[0].Rows[0][nameof(cost_main.status)];
            main.remark = (string)ds1.Tables[0].Rows[0][nameof(cost_main.remark)];

            DataSet ds2 = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql2);
            for(int i = 0; i < ds2.Tables.Count; i++)
            {
                cost_detail detail = new cost_detail();
                detail.id = int.Parse((string)ds2.Tables[0].Rows[i][nameof(cost_detail.id)]);
                detail.cost_id = int.Parse((string)ds2.Tables[0].Rows[i][nameof(cost_detail.cost_id)]);
                detail.cost_type = (string)ds2.Tables[0].Rows[i][nameof(cost_detail.cost_type)];
                detail.money = (decimal)ds2.Tables[0].Rows[i][nameof(cost_detail.money)];
                listDetail.Add(detail);
            }
            bills.Add(main, listDetail);
            return bills;
        }        
        /// <summary>
        /// 查询所有费用单
        /// </summary>
        /// <returns>费用单的词典</returns>
        public Dictionary<cost_main, List<cost_detail>> Query()
        {
            Dictionary<cost_main, List<cost_detail>> bills = new Dictionary<cost_main, List<cost_detail>>();
            cost_main main = new cost_main();
            List<cost_detail> listDetail = new List<cost_detail>();

            string sql1 = "select * from cost_main";

            DataSet ds1 = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql1);

            for(int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                main.id = int.Parse((string)ds1.Tables[0].Rows[i][nameof(cost_main.id)]);
                main.applicant = (string)ds1.Tables[0].Rows[i][nameof(cost_main.applicant)];
                main.approver = (string)ds1.Tables[0].Rows[i][nameof(cost_main.approver)];
                main.apply_time = (DateTime)ds1.Tables[0].Rows[i][nameof(cost_main.apply_time)];
                main.approval_time = (DateTime)ds1.Tables[0].Rows[i][nameof(cost_main.approval_time)];
                main.apply_money = (decimal)ds1.Tables[0].Rows[i][nameof(cost_main.apply_money)];
                main.approval_money = (decimal)ds1.Tables[0].Rows[i][nameof(cost_main.approval_money)];
                main.status = (byte)ds1.Tables[0].Rows[i][nameof(cost_main.status)];
                main.remark = (string)ds1.Tables[0].Rows[i][nameof(cost_main.remark)];

                string sql2 = "select * from cost_detail where cost_id='" + main.id + "'";
                DataSet ds2 = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql2);
                for (int j = 0; i < ds2.Tables.Count; i++)
                {
                    cost_detail detail = new cost_detail();
                    detail.id = int.Parse((string)ds2.Tables[0].Rows[j][nameof(cost_detail.id)]);
                    detail.cost_id = int.Parse((string)ds2.Tables[0].Rows[j][nameof(cost_detail.cost_id)]);
                    detail.cost_type = (string)ds2.Tables[0].Rows[j][nameof(cost_detail.cost_type)];
                    detail.money = (decimal)ds2.Tables[0].Rows[j][nameof(cost_detail.money)];
                    listDetail.Add(detail);
                }
                bills.Add(main, listDetail);
            }

            
            return bills;
        }
    }
}
