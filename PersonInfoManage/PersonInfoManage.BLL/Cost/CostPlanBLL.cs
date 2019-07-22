using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonInfoManage.BLL.Utils;
using PersonInfoManage.Model;
using PersonInfoManage.DAL.Cost;

namespace PersonInfoManage.BLL.Cost
{
    public class CostPlanBLL
    {
        /// <summary>
        /// 费用规划添加
        /// </summary>
        /// <param name="ListPlan"></param>
        /// <returns></returns>
        public Result Add(List<cost_plan> ListPlan)
        {

            Result res = new Result();
            int rows = new CostPlanDAL().Add(ListPlan);
            if(rows==ListPlan.Count)
            {
                res.Code = RES.OK;
                res.Message = "添加成功！";
            }
            else
            {
                res.Code = RES.ERROR;
                res.Message = "添加失败！";
            }
            return res;
        }

        /// <summary>
        /// 费用规划修改
        /// </summary>
        /// <param name="ListPlan"></param>
        /// <returns></returns>
        public Result Update(List<cost_plan> ListPlan)
        {
            Result res = new Result();
            int rows = new CostPlanDAL().Update(ListPlan);
            if (rows == ListPlan.Count)
            {
                res.Code = RES.OK;
                res.Message = "修改成功！";
            }
            else
            {
                res.Code = RES.ERROR;
                res.Message = "修改失败！";
            }
            return res;
        }

        /// <summary>
        /// 费用规划删除
        /// </summary>
        /// <param name="period"></param>
        /// <returns></returns>
        public Result Del(Dictionary<string, DateTime> period)
        {
            Result res = new Result();
            
            if (new CostPlanDAL().Del(period)>0)
            {
                res.Code = RES.OK;
                res.Message = "删除成功！";
            }
            else
            {
                res.Code = RES.ERROR;
                res.Message = "删除失败！";
            }
            return res;
        }

        /// <summary>
        /// 费用规划检索
        /// </summary>
        /// <param name="conditions"></param>
        /// <returns></returns>
        public List<cost_plan> Query(Dictionary<string, object> conditions)
        {
            return new CostPlanDAL().Query(conditions);
        }

       
    }
}
