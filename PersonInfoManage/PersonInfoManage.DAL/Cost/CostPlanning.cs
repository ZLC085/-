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
    public class CostPlanning : ICostPlanning
    {
        /// <summary>
        /// 费用规划添加
        /// </summary>
        /// <param name="planning">费用规划</param>
        /// <returns>添加条数</returns>
        public int InsertCostPlanning(cost_planning planning)
        {
            return 0;
        }

        /// <summary>
        /// 费用规划添加
        /// </summary>
        /// <param name="planning">修改后的费用规划</param>
        /// <returns>修改条数</returns>
        public int UpdateCostPlanning(cost_planning planning)
        {
            return 0;
        }

        /// <summary>
        /// 费用规划删除，通过费用规划id
        /// </summary>
        /// <param name="costPlanningId"></param>
        /// <returns>删除的条数</returns>
        public int DeleteCostPlanning(long costPlanningId)
        {
            return 0;
        }

        /// <summary>
        /// 费用规划检索，通过费用规划类型
        /// </summary>
        /// <returns></returns>
        public List<cost_planning> SelectCostPlanningByType()
        {
            return null;
        }

        /// <summary>
        /// 费用规划检索，所有
        /// </summary>
        /// <returns></returns>
        public List<cost_planning> SelectAllCostPlanning()
        {
            return null;
        }
    }
}
