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
        /// <param name="main"></param>
        /// <param name="listDeatil"></param>
        /// <returns></returns>
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
        public bool Update(cost_main main, List<cost_detail> listDeatil)
        {
            bool flag = false;
            if (main == null || listDeatil == null || listDeatil.Count == 0)
            {
                return flag;
            }
            CostApplyDAL apply = new CostApplyDAL();
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
        public bool Del(int id)
        {
            bool flag = false;
            CostApplyDAL apply = new CostApplyDAL();
            List<cost_detail> listDetail = apply.QueryDetail(id);
            if (apply.Del(id) == listDetail.Count + 1)
                flag = true;
            return flag;
        }
    }
}
