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
    public class CostApprovaDAL:DALBase
    {
        /// <summary>
        /// 费用审批添加/修改 添加/修改审批金额、审批状态（待审批，通过，驳回）以及审批意见
        /// </summary>
        /// <param name="main">费用单对象cost_main:approval_id、approval_time、approval_money、status、id</param>
        /// <returns>数据表受影响的行数</returns>
        public int Update(cost cost)
        {
            /*
             * ApprovalList最多只有两个元素（前端并不会将已审核通过的cost_approval对象封装到此列表）
             * 第一个元素是正在审批的cost_approval对象：
             * 第二个元素是需要再提交到上级进行审批的cost_approval对象
             */
            string[] sqlArray = new string[1+cost.ApprovalList.Count];
            sqlArray[0] = "update cost_main set "+
                nameof(cost_main.status)+"='"+cost.Main.status+"' where id='"+ cost.Main.id+"'";
            cost_approval approvalFirst = cost.ApprovalList.First();
            sqlArray[1] = "update cost_approval set result="+ ((bool)approvalFirst.result?1:0)+
                ",time='"+ approvalFirst.time + "',opinion=N'"+ approvalFirst.opinion
                + "' where cost_id='"+ approvalFirst.cost_id + "' and approval_id='"+ approvalFirst.approval_id + "'";
            if (sqlArray.Length > 2)
            {
                sqlArray[2] = ConditionsToSql<cost_approval>.InsertSql(cost.ApprovalList[1]);
            }
            return sqlArrayToTran.doTran(sqlArray);
        }
        /// <summary>
        /// 根据条件查询费用信息
        /// </summary>
        /// <param name="conditions">条件键值对 "id", "apply_id", "status", "start_time", "end_time","page","limit"</param>
        /// <returns>费用信息列表</returns>
        public List<cost> Query(Dictionary<string, object> conditions)
        {
            List<cost> CostList = new List<cost>();
            CostApplyDAL costApplyDAL = new CostApplyDAL();
            List<cost_main> MainList = costApplyDAL.QueryMain(conditions);
            foreach(cost_main Main in MainList)
            {
                List<cost_detail> DetailList = costApplyDAL.QueryDetail(Main.id);
                List<cost_approval> ApprovalList = costApplyDAL.QueryApproval(Main.id);
                CostList.Add(new cost
                {
                    Main = Main,
                    DetailList = DetailList,
                    ApprovalList = ApprovalList
                }) ;
            }
            return CostList;
        }
    }
}
