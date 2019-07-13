using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Cost
{
    /// <summary>
    /// 费用规划
    /// </summary>
    public class CostPlan
    {
        /// <summary>
        /// 费用规划添加
        /// </summary>
        /// <param name="plan">费用规划</param>
        /// <returns>添加条数</returns>
        public int InsertCostPlan(cost_plan plan)
        {
            return new DBOperationsInsert<cost_plan, DBNull>().Insert(plan);
        }

        /// <summary>
        /// 费用规划添加
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newValues">需要更新的值</param>
        /// <returns>修改条数</returns>
        public int UpdateCostPlan(int id,Dictionary<string,object> newValues)
        {
            return new DBOperationsUpdate<cost_plan>().UpdateById(id, newValues);
        }

        /// <summary>
        /// 费用规划删除，通过费用规划id
        /// </summary>
        /// <param name="costPlanId"></param>
        /// <returns>删除的条数</returns>
        public int DeleteCostPlan(int costPlanId)
        {
            return new DBOperationsDelete<cost_plan, DBNull>().DeleteById(costPlanId);
        }

        /// <summary>
        /// 根据条件检索费用规划
        /// </summary>
        /// <param name="conditions">查询条件</param>
        /// <returns>费用规划</returns>
        public List<cost_plan> SelectCostPlanByConditions(Dictionary<string, object> conditions)
        {
            return new DBOperationsSelect<cost_plan>().SelectByConditions(conditions);
        }

        /// <summary>
        /// 费用规划检索，所有
        /// </summary>
        /// <returns>费用规划</returns>
        public List<cost_plan> SelectAllCostPlan()
        {
            return new DBOperationsSelect<cost_plan>().SelectAll();
        }
    }
}
