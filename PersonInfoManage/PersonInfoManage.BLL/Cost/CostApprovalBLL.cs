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
        /// 根据费用单id查询费用信息
        /// </summary>
        /// <param name="id">费用单id</param>
        /// <returns>费用信息列表</returns>
        public List<cost> GetCostById(int id)  
        {
            List<cost> listCost = new List<cost>
            {
                new cost
                {
                    main=new CostApplyDAL().QueryMain(new Dictionary<string, object>{ { "id", id } }).First(),
                    DetailList=new CostApplyDAL().QueryDetail(id)
                }
            };
            
            return listCost;
        }
        
    }
}
