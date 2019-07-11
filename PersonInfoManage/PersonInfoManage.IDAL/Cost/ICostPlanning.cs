using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.IDAL.Cost
{
    /// <summary>
    /// 费用规划
    /// </summary>
    public interface ICostPlanning
    {
        /// <summary>
        /// 费用规划添加
        /// </summary>
        /// <param name="planning">费用规划</param>
        /// <returns>添加条数</returns>
        int InsertCostPlanning(cost_planning planning);

        /// <summary>
        /// 费用规划添加
        /// </summary>
        /// <param name="planning">修改后的费用规划</param>
        /// <returns>修改条数</returns>
        int UpdateCostPlanning(cost_planning planning);

        /// <summary>
        /// 费用规划删除，通过费用规划id
        /// </summary>
        /// <param name="costPlanningId"></param>
        /// <returns>删除的条数</returns>
        int DeleteCostPlanning(long costPlanningId);

        /// <summary>
        /// 费用规划检索，通过费用规划类型
        /// </summary>
        /// <returns></returns>
        List<cost_planning> SelectCostPlanningByType();

        /// <summary>
        /// 费用规划检索，所有
        /// </summary>
        /// <returns></returns>
        List<cost_planning> SelectAllCostPlanning();
    }
}
