using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.IDAL.Cost
{
    /// <summary>
    /// 费用审批
    /// </summary>
    public interface ICostApproval
    {
        /// <summary>
        /// 费用审批添加 添加审批金额、审批状态（待审批，通过，驳回）以及审批意见
        /// </summary>
        /// <param name="amount">审批金额</param>
        /// <param name="status">审批状态（是否通过）</param>
        /// <param name="remark">审批意见</param>
        /// <returns></returns>
        int InsertApproval(decimal amount, byte status, string remark);

        /// <summary>
        /// 费用审批修改 修改审批金额、审批状态（待审批，通过，驳回）以及审批意见
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="status"></param>
        /// <param name="remark"></param>
        /// <returns></returns>
        int UpdateApproval(decimal amount, byte status, string remark);

        /// <summary>
        /// 费用审批查询，通过费用单编号
        /// </summary>
        /// <param name="costId"></param>
        /// <returns>通过费用单编号查询到的费用单</returns>
        Dictionary<cost_manage, List<cost_detail>> SelectBillByCostId(long costId);

        /// <summary>
        /// 费用审批查询，通过申请人
        /// </summary>
        /// <param name="person"></param>
        /// <returns>通过申请人查询到的费用单</returns>
        Dictionary<cost_detail, List<cost_detail>> SelectBillByApplyPerson(string person);

        /// <summary>
        /// 费用审批查询
        /// </summary>
        /// <returns>所有费用单</returns>
        Dictionary<cost_manage, List<cost_detail>> SelectBill();
    }
}
