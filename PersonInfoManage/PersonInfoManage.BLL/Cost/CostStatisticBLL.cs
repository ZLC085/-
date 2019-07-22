using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonInfoManage.DAL.Cost;
using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;

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
