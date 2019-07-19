using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonInfoManage.DAL.Cost;
using PersonInfoManage.Model;

namespace PersonInfoManage.BLL.Cost
{
    public class CostApply_BLL
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
            int rows = new CostApply().Add(main, listDeatil);
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
            CostApply apply = new CostApply();
            //先获取未更新时费用详情记录数
            Dictionary<cost_main, List<cost_detail>> dic = apply.GetById(main.id);
            int originDetailCount = dic[dic.Keys.First()].Count;
            //再更新费用单
            int rows = apply.Update(main, listDeatil);
            if (rows == 1 + originDetailCount + listDeatil.Count)
            {
                flag = true;
            }
            return flag;
        }
        public bool Del(cost_main main)
        {
            bool flag = false;
            if (main == null)
            {
                return flag;
            }
            CostApply apply = new CostApply();
            Dictionary<cost_main, List<cost_detail>> dic = apply.GetById(main.id);
            if (dic.Count != 0)
            {
                int rows = apply.Del(main);
                if(rows == dic[dic.Keys.First()].Count + 1)
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}
