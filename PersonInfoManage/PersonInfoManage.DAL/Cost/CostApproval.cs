using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PersonInfoManage.DAL.Cost
{
    /// <summary>
    /// 费用审批
    /// </summary>
    public class CostApproval:DALBase
    {
        /// <summary>
        /// 费用审批添加/修改 添加/修改审批金额、审批状态（待审批，通过，驳回）以及审批意见
        /// </summary>
        /// <param name="amount">审批金额</param>
        /// <param name="status">审批状态（待审批，通过，驳回）</param>
        /// <param name="remark">审批意见</param>
        /// <returns></returns>
        public int Update(cost_main main)
        {
            int res = 0;
            string sql = "update cost_main set "+nameof(cost_main.approver)+"=N'"+main.approver+"',"+
                nameof(cost_main.approval_time)+"='"+main.approval_time+"',"+
                nameof(cost_main.approval_money)+"='"+main.approval_money+"',"+
                nameof(cost_main.status)+"='"+main.status+"',"+
                nameof(cost_main.remark)+"=N'"+main.remark+"' where id='"+main.id+"'";
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
            return res;
        }

        /// <summary>
        /// 费用审批查询
        /// </summary>
        /// <param name="costId"></param>
        /// <returns>查询到的费用单</returns>
        public Dictionary<cost_main, List<cost_detail>> SelectBillByConditions(Dictionary<string, object> conditions)
        {
            return null; //new CostApply().SelectBillByConditions(conditions);
        }

        /// <summary>
        /// 费用审批查询
        /// </summary>
        /// <returns>所有费用单</returns>
        public Dictionary<cost_main, List<cost_detail>> Query()
        {
            return new CostApply().Query();
        }
        /// <summary>
        /// 费用审批撤销
        /// </summary>
        /// <param name="costMain">费用单</param>
        /// <returns>删除记录数</returns>
        public int Del(cost_main costMain)
        {
            return new CostApply().Del(costMain);
        }
    }
}
