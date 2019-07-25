using PersonInfoManage.Model;
using System.Collections.Generic;
using PersonInfoManage.DAL.Cost;

namespace PersonInfoManage.BLL.Cost
{
    public class CostStatisticBLL
    {
        /// <summary>
        /// 费用统计
        /// </summary>
        /// <param name="conditions"></param>
        /// <returns></returns>
        public List<cost> Query(Dictionary<string, object> conditions)
        {
            return new CostStatisticDAL().Query(conditions);
        }
    }
}
