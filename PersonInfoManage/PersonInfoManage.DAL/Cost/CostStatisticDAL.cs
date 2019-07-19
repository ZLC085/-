using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Cost
{
    /// <summary>
    /// 费用统计
    /// </summary>
    public class CostStatisticDAL : DALBase
    {
        /// <summary>
        /// 根据组合条件查询已审核通过的费用单
        /// </summary>
        /// <param name="conditions">条件键值对key: "applicant","start_time", "end_time"</param>
        /// <returns>费用单对象与费用详情对象列表构成的词典键值对</returns>
        public List<cost_main> Query(Dictionary<string, object> conditions)
        {
            conditions.Add("status", 1);
            return new CostApplyDAL().QueryMain(conditions);
        }

    }
}
