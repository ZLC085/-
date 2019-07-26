using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.Model
{
    public class CostApprovalData
    {
        public int ApprNumber { get; set; }
        public int ApprCostId { get; set; }
        public string ApprApplicant { get; set; }
        public decimal ApprApplyMoney { get; set; }
        public DateTime ApprApplyTime { get; set; }
        public DateTime? ApprApprovalTime { get; set; }
        public string ApprResult { get; set; }
        public string ApprOpinion { get; set; }
    }
}
