using PersonInfoManage.Model;
using PersonInfoManage.BLL.Utils;
using PersonInfoManage.DAL.Cost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.BLL.Cost
{
    public class CostApprovalBLL
    {
        /// <summary>
        /// 费用审批添加/修改 、审批状态（待审批，通过，驳回）以及审批意见
        /// </summary>
        /// <param name="cost">费用单主表对象Main:id、status 
        /// DetailList 费用详情列表：
        /// ApprovalList 费用审批表列表：详见方法体注释</param>
        public Result Update(cost Cost)
        {            
            Result res = new Result()
            {
                Code = RES.ERROR,
                Message = "更新失败"
            };
            if(Cost == null)
            {
                return res;
            }

            if(new CostApprovaDAL().Update(Cost) == 1+Cost.ApprovalList.Count)
            {
                res.Code = RES.OK;
                res.Message = "更新成功";
            }
            return res;
        }
        /// <summary>
        /// 费用单删除
        /// </summary>
        /// <param name="id">费用单id</param>
        /// <returns>删除是否成功</returns>
        public Result Del(int id)
        {
            Result res = new Result
            {
                Code = RES.ERROR,
                Message = "删除失败"
            };
            int rows = new CostApplyDAL().Del(id);
            cost cost = new CostApprovaDAL().Query(new Dictionary<string, object>
            {
                {"id",id }
            }).First();
            int rightRows = cost.DetailList.Count+cost.ApprovalList.Count+1;

            if (rows == rightRows)
            {
                res.Code = RES.OK;
                res.Message = "删除成功";
            }
            return res;
        }
        /// <summary>
        /// 根据条件查询费用信息(可分页)
        /// </summary>
        /// <param name="conditions">条件键值对 "id", "apply_id", "status", "start_time", "end_time","page","limit"</param>
        /// <returns>费用信息列表</returns>
        public List<cost> Query(Dictionary<string, object> conditions)
        {
            return new CostApprovaDAL().Query(conditions);
        }
        
    }
}
