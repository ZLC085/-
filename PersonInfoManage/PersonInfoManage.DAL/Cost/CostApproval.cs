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
    { //000
        /// <summary>
        /// 费用审批添加/修改 添加/修改审批金额、审批状态（待审批，通过，驳回）以及审批意见
        /// </summary>
        /// <param name="main">费用单对象</param>
        /// <returns>更新成功的记录数</returns>
        public int Update(cost_main main)
        {
            int res = 0;
            string sql = "update cost_main set "+nameof(cost_main.approver)+"=N'"+main.approver+"',"+
                nameof(cost_main.approval_time)+"='"+main.approval_time+"',"+
                nameof(cost_main.approval_money)+"='"+main.approval_money+"',"+
                nameof(cost_main.status)+"='"+main.status+"',"+
                nameof(cost_main.remark)+"=N'"+main.remark+"' where id='"+main.id+"'";
            Console.WriteLine(sql);
            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
            return res;
        }

        /// <summary>
        /// 根据费用单id查询
        /// </summary>
        /// <param name="costId">费用单编号</param>
        /// <returns>费用单与费用详情的键值对词典</returns>
        public Dictionary<cost_main, List<cost_detail>> GetById(int costId)
        {
            return new CostApply().GetById(costId);
        }

        /// <summary>
        /// 所有费用审批查询
        /// </summary>
        /// <returns>所有费用单与费用详情的键值对词典</returns>
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
