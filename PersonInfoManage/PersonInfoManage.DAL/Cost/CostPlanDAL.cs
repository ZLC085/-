using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Cost
{
    /// <summary>
    /// 费用规划
    /// </summary>
    public class CostPlanDAL : DALBase
    {
       
        /// <summary>
        /// 费用规划添加
        /// </summary>
        /// <param name="ListPlan"></param>
        /// <returns>添加数目</returns>
        public int Add(List<cost_plan> ListPlan)
        {
            string[] sqlPlan = new string[ListPlan.Count];

            int count = 0;
            foreach (cost_plan plan in ListPlan)
            {
                sqlPlan[count] = "insert into cost_plan(cost_type,money,start_time,end_time) values(N'"+plan .cost_type+ "','"+plan.money+"','"+plan.start_time+"','"+plan.end_time+"')";
                count++;
            }

            return sqlArrayToTran.doTran(sqlPlan);
        }
       
        /// <summary>
        /// 费用规划修改
        /// </summary>
        /// <param name="ListPlan"></param>
        /// <returns>修改条数</returns>
        public int Update(List<cost_plan> ListPlan)
        {
            string[] sqlPlan = new string[ListPlan.Count];

            int count = 0;
            foreach (cost_plan plan in ListPlan)
            {
                sqlPlan[count] = "update cost_plan set  "+nameof(cost_plan.money)+"= '"+plan.money+ "' where " +
                    "" + nameof(cost_plan.cost_type) + " =N'" + plan.cost_type + "' and " + 
                    nameof(cost_plan.start_time) + "='" + plan.start_time + "' and " + 
                    nameof(cost_plan.end_time) + "='" + plan.end_time + "'";
                count++;
            }

            return sqlArrayToTran.doTran(sqlPlan); 
        }
     
        /// <summary>
        /// 费用规划删除，根据时间
        /// </summary>
        /// <param name="ListPlan"></param>
        /// <returns>删除条数</returns>
        public int Del(List<cost_plan> ListPlan)
        {
            string[] sqlPlan = new string[ListPlan.Count];

            int count = 0;
            foreach (cost_plan plan in ListPlan)
            {
                sqlPlan[count] = "delete from cost_plan where " + nameof(cost_plan.start_time) + "='" + plan.start_time + "' and " + nameof(cost_plan.end_time) + "='" + plan.end_time + "'";
                count++;
            }

            return sqlArrayToTran.doTran(sqlPlan);
        }
        /// <summary>
        /// 费用规划检索，根据id
        /// </summary>
        /// <param name="id">费用规划表id</param>
        /// <returns></returns>
        public List<cost_plan> GetById(int id)
        {
            List<cost_plan> Listplan = new List<cost_plan>();

            string sql = "select * from cost_plan where id='" + id + "'";

            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            cost_plan plan = new cost_plan();
            plan.id = (int)ds.Tables[0].Rows[0][nameof(cost_plan.id)];
            plan.cost_type = (string)ds.Tables[0].Rows[0][nameof(cost_plan.cost_type)];
            plan.money = (decimal)ds.Tables[0].Rows[0][nameof(cost_plan.money)];
            plan.start_time = (DateTime)ds.Tables[0].Rows[0][nameof(cost_plan.start_time)];
            plan.end_time = (DateTime)ds.Tables[0].Rows[0][nameof(cost_plan.end_time)];
            Listplan.Add(plan);

            return Listplan;
        }
        /// <summary>
        /// 费用规划检索，所有
        /// </summary>
        /// <returns>费用规划</returns>
        public List<cost_plan> Query()
        {
            List<cost_plan> Listplan = new List<cost_plan>();

            string sql = "select * from cost_plan";

            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cost_plan plan = new cost_plan();
                plan.id = (int)ds.Tables[0].Rows[i][nameof(cost_plan.id)];
                plan.cost_type = (string)ds.Tables[0].Rows[i][nameof(cost_plan.cost_type)];
                plan.money = (decimal)ds.Tables[0].Rows[i][nameof(cost_plan.money)];
                plan.start_time = (DateTime)ds.Tables[0].Rows[i][nameof(cost_plan.start_time)];
                plan.end_time = (DateTime)ds.Tables[0].Rows[i][nameof(cost_plan.end_time)];
                Listplan.Add(plan);
            }
            return Listplan;
        }
        /// <summary>
        /// 费用规划检索，根据组合条件
        /// </summary>
        /// <param name="conditions">组合条件词典</param>
        /// <returns>费用规划列表</returns>
        public List<cost_plan> Query(Dictionary<string, object> conditions)
        {
            Console.WriteLine(1);
            string[] keys = new string[] { "start_time", "end_time", "cost_type", "id" };
            List<cost_plan> retList = new List<cost_plan>();
            List<string> listKey = new List<string>();
            foreach (string key in conditions.Keys)
            {
                if (keys.Contains(key))
                {
                    listKey.Add(key);
                }

            }
            string sql = "select * from cost_plan where ";
            foreach (string key in listKey)
            {
                if (!key.Equals(listKey.First()))
                {
                    sql += " and ";
                }
                if (key.Equals("start_time"))
                {
                    sql += " start_time >='" + conditions[key] + "'";
                }
                else if (key.Equals("end_time"))
                {
                    sql += " end_time<='" + conditions[key] + "'";
                }
                else
                {
                    sql += " " + key + " like N'%" + conditions[key] + "%'";
                }
            }
            Console.WriteLine(sql);
            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cost_plan plan = new cost_plan();
                plan.id = (int)dt.Rows[i]["id"];
                plan.cost_type = (string)dt.Rows[i]["cost_type"];
                plan.start_time = (DateTime)dt.Rows[i]["start_time"];
                plan.end_time = (DateTime)dt.Rows[i]["end_time"];
                retList.Add(plan);
            }

            return retList;
        }
    }
}