using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonInfoManage.DAL.Cost;
using PersonInfoManage.Model;

namespace PersonInfoManage.BLL.Cost
{
    public class CostApplyBLL
    {
        /// <summary>
        /// 添加费用单
        /// </summary>
        /// <param name="costMain">费用单对象cost_main：applicant、apply_money、apply_time</param>
        /// <param name="detailList">费用类型明细列表cost_detail:cost_type、money</param>
        /// <returns>是否添加成功</returns>
        public bool Add(cost_main main,List<cost_detail> listDeatil)
        {
            bool flag = false;
            if (main == null || listDeatil == null || listDeatil.Count == 0)
            {
                return flag;
            }            
            int rows = new CostApplyDAL().Add(main, listDeatil);
            if(rows == 1 + listDeatil.Count)
            {
                flag = true;
            }
            return flag;
        }
        /// <summary>
        /// 更新费用单信息
        /// </summary>
        /// <param name="costMain">费用单对象cost_main：id、apply_money</param>
        /// <param name="detailList">费用类型明细列表cost_detail:cost_type、money</param>
        /// <returns>费用单信息是否更新成功</returns>
        public bool Update(cost_main main, List<cost_detail> listDeatil)
        {
            bool flag = false;
            if (main == null || listDeatil == null || listDeatil.Count == 0)
            {
                return flag;
            }
            CostApplyDAL apply = new CostApplyDAL();
            //获取该费用单的审批状态
            byte status = apply.QueryMain(new Dictionary<string, object>
            {
                {"id",main.id }
            }).First().status;
            //如果费用单不是未审批状态，则更新信息失败
            if (status != 0)
            {
                return flag;
            }
            //先获取未更新时费用详情记录数           
            int originDetailCount = apply.QueryDetail(main.id).Count;
            //再更新费用单
            int rows = apply.Update(main, listDeatil);
            if (rows == 1 + originDetailCount + listDeatil.Count)
            {
                flag = true;
            }
            return flag;
        }
        /// <summary>
        /// 删除费用单信息
        /// </summary>
        /// <param name="id">费用单id</param>
        /// <returns><费用单信息是否删除成功/returns>
        public bool Del(int id)
        {
            bool flag = false;
            CostApplyDAL apply = new CostApplyDAL();
            //获取该费用单的审批状态
            byte status = apply.QueryMain(new Dictionary<string, object>
            {
                {"id",id }
            }).First().status;
            //如果费用单不是未审批状态，则删除失败
            if (status != 0)
            {
                return flag;
            }
            List<cost_detail> listDetail = apply.QueryDetail(id);
            if (apply.Del(id) == listDetail.Count + 1)
                flag = true;
            return flag;
        }
        /// <summary>
        /// 费用类型列表属性
        /// </summary>
        public List<string> CostTypes
        {
            get
            {
                return new CostApplyDAL().GetCostTypes();
            }
        }
        
    }
}
