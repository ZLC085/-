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
        /// 费用单更新
        /// </summary>
        /// <param name="main">费用单对象cost_main:approver、approval_time、approval_money、status、id</param>
        /// <returns>更新是否成功</returns>
        public Result Update(cost_main main)
        {
            Result res = new Result()
            {
                Code = RES.ERROR,
                Message = "更新失败"
            };
            if(main == null)
            {
                return res;
            }
            if(new CostApprovaDAL().Update(main) == 1)
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
            int rightRows = new CostApprovaDAL().Query(new Dictionary<string, object>
            {
                {"id",id }
            }).First().DetailList.Count+1;

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
        /// <param name="conditions">条件键值对 "id", "applicant", "status", "start_time", "end_time","page","limit"</param>
        /// <returns>费用信息列表</returns>
        public List<cost> Query(Dictionary<string, object> conditions)
        {
            return new CostApprovaDAL().Query(conditions);
        }
        
    }
}
