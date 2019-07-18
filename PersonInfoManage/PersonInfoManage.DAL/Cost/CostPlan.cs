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
    public class CostPlan : DALBase
    {
        /// <summary>
        /// 费用规划添加
        /// </summary>  
        /// <param name="plan">费用规划</param>
        /// <returns>添加条数</returns>
        public int Add(cost_plan plan)
        {
            //Add 插入
            //Update 更新
            //Del 删除
            //Query 查询
            //GetById 通过id查询
            int res = 0;
            string sql = "insert into cost_plan(cost_type,money,start_time,end_time) values(@cost_type,@money,@start_time,@end_time)";
            SqlParameter sqlParameter = new SqlParameter("@cost_type", plan.cost_type);
            SqlParameter sqlParameter1 = new SqlParameter("@money", plan.money);
            SqlParameter sqlParameter2 = new SqlParameter("@start_time", plan.start_time);
            SqlParameter sqlParameter3 = new SqlParameter("@end_time", plan.end_time);

            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter, sqlParameter1, sqlParameter2, sqlParameter3);

            return res;
            //return new DBOperationsInsert<cost_plan, DBNull>().Insert(plan);
        }
        /// <summary>
        /// 费用规划修改
        /// </summary>
        /// <param name="plan">费用规划</param>
        /// <returns>修改的条数</returns>
        public int Update(cost_plan plan)
        {
            int res = 0;

            string sql = "update cost_plan set cost_type = @cost_type, money = @money,start_time=@start_time,end_time=@end_time where id = @id";
            SqlParameter sqlParmeter = new SqlParameter("@cost_type", plan.cost_type);
            SqlParameter sqlParmeter1 = new SqlParameter("@money", plan.money);
            SqlParameter sqlParmeter2 = new SqlParameter("@start_time", plan.start_time);
            SqlParameter sqlParmeter3 = new SqlParameter("@end_time", plan.end_time);
            SqlParameter sqlParmeter4 = new SqlParameter("@id", plan.id);

            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParmeter, sqlParmeter1, sqlParmeter2, sqlParmeter3, sqlParmeter4);

            return res;

        }
        /// <summary>
        /// 费用规划删除，通过费用规划id
        /// </summary>
        /// <param name="plan"></param>
        /// <returns>删除的条数</returns>
        public int Del(cost_plan plan)
        {
            int res = 0;

            string sql = "delete from cost_plan where id = @id";
            SqlParameter sqlParmeter = new SqlParameter("@id", plan.id);

            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParmeter);

            return res;

            //return new DBOperationsDelete<cost_plan, DBNull>().DeleteById(costPlanId);
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
                    sql += " " + key + " like '%" + conditions[key] + "%'";
                }
            }
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