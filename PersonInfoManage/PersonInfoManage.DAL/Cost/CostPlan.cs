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
            string sql = "insert into cost_plan (cost_type,money,start_time,end_time) values(@cost_type,@money,@start_time,@end_time)";
            SqlParameter sqlParameter = new SqlParameter("@cost_type",plan.cost_type);
            SqlParameter sqlParameter1 = new SqlParameter("@money", plan.money);
            SqlParameter sqlParameter2 = new SqlParameter("@stsrt_time", plan.start_time);
            SqlParameter sqlParameter3 = new SqlParameter("@end_time", plan.end_time);

            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter, sqlParameter1,sqlParameter2,sqlParameter3);

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
        
            string sql = "update cost_plan set cost_type = @cost_type , money = @money,start_time=@start_time,end_time=@end_time" + " where id = @id";
            SqlParameter sqlParmeter = new SqlParameter("@cost_type", plan.cost_type);
            SqlParameter sqlParmeter1 = new SqlParameter("@money", plan.money);
            SqlParameter sqlParmeter2 = new SqlParameter("@start_time", plan.start_time);
            SqlParameter sqlParmeter3 = new SqlParameter("@end_time", plan.end_time);
            SqlParameter sqlParmeter4 = new SqlParameter("@id", plan.id);

            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql,sqlParmeter,sqlParmeter1,sqlParmeter2,sqlParmeter3,sqlParmeter4);

            return res;

            //return new DBOperationsUpdate<cost_plan>().UpdateById(id, newValues);
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
        /// 根据条件检索费用规划
        /// </summary>
        /// <param name="conditions">查询条件</param>
        /// <returns>费用规划</returns>
        //public List<cost_plan> SelectCostPlanByConditions(Dictionary<string, object> conditions)
        //{
            //return new DBOperationsSelect<cost_plan>().SelectByConditions(conditions);
        //}

        

        /// <summary>
        /// 费用规划检索，所有
        /// </summary>
        /// <returns>费用规划</returns>
        //public List<cost_plan> SelectAllCostPlan()
        //{
            //return new DBOperationsSelect<cost_plan>().SelectAll();
        //}
    }
}
