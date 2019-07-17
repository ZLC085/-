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
    /// 费用审批
    /// </summary>
    public class CostApproval
    {
        /// <summary>
        /// 费用审批添加/修改 添加/修改审批金额、审批状态（待审批，通过，驳回）以及审批意见
        /// </summary>
        /// <param name="amount">审批金额</param>
        /// <param name="status">审批状态（待审批，通过，驳回）</param>
        /// <param name="remark">审批意见</param>
        /// <returns></returns>
        public int UpdateApproval(int id, decimal amount, byte status, string remark)
        {
            Dictionary<string, object> newValues = new Dictionary<string, object>
            {
                { nameof(cost_main.apply_money), amount },
                {nameof(cost_main.status),status },
                {nameof(cost_main.remark),remark }
            };

            return new DBOperationsUpdate<cost_main>().UpdateById(id, newValues);
        }

        /// <summary>
        /// 费用审批查询
        /// </summary>
        /// <param name="costId"></param>
        /// <returns>查询到的费用单</returns>
        public Dictionary<cost_main, List<cost_detail>> SelectBillByConditions(Dictionary<string, object> conditions)
        {
            return new CostApply().SelectBillByConditions(conditions);
        }

        /// <summary>
        /// 费用审批查询
        /// </summary>
        /// <returns>所有费用单</returns>
        public Dictionary<cost_main, List<cost_detail>> SelectBill()
        {
            return new CostApply().SelectAllBill();
        }
    }
}
