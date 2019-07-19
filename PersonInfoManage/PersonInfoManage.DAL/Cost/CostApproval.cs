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
        /// <param name="main">费用单对象cost_main:approver、approval_time、approval_money、status、id</param>
        /// <returns>数据表受影响的行数</returns>
        public int Update(cost_main main)
        {
            string sql = "update cost_main set "+nameof(cost_main.approver)+"=N'"+main.approver+"',"+
                nameof(cost_main.approval_time)+"='"+main.approval_time+"',"+
                nameof(cost_main.approval_money)+"='"+main.approval_money+"',"+
                nameof(cost_main.status)+"='"+main.status+"',"+
                nameof(cost_main.remark)+"=N'"+main.remark+"' where id='"+main.id+"'";
            return SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
        }
        /// <summary>
        /// 根据费用单id查询费用单详情
        /// </summary>
        /// <param name="costId">费用单编号</param>
        /// <returns>费用单对象与费用详情对象列表构成的词典键值对</returns>
        public Dictionary<cost_main, List<cost_detail>> GetById(int costId)
        {
            return new CostApply().GetById(costId);
        }
        /// <summary>
        /// 查询所有费用单详情
        /// </summary>
        /// <returns>费用单对象与费用详情对象列表构成的词典键值对</returns>
        public Dictionary<cost_main, List<cost_detail>> Query()
        {
            return new CostApply().Query();
        }
        /// <summary>
        /// 费用审批撤销
        /// </summary>
        /// <param name="costMain">费用单cost_main:id</param>
        /// <returns>数据表受影响的行数</returns>
        public int Del(cost_main costMain)
        {
            return new CostApply().Del(costMain);
        }
    }
}
