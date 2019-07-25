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
        /// 根据组合条件查询已审核通过的费用信息
        /// </summary>
        /// <param name="conditions">条件键值对key: "id", "apply_id", "start_time", "end_time","page","limit"</param>
        /// <returns>费用信息列表</returns>
        public List<cost> Query(Dictionary<string, object> conditions)
        {
            conditions.Add("status", 2);
            List<cost> costList = new CostApprovaDAL().Query(conditions);            
            return costList;
        }
    }
}
