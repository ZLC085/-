using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.Model
{
    public class cost
    {
        /// <summary>
        /// 费用单主表对象
        /// </summary>
        public cost_main Main { get; set; }
        /// <summary>
        /// 费用单审批详情列表
        /// </summary>
        public List<cost_approval> ApprovalList { get; set; }
        /// <summary>
        /// 费用详情列表
        /// </summary>
        public List<cost_detail> DetailList { get; set; }
    }
}
