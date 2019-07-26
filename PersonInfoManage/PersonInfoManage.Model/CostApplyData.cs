using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Cost
{
    public class CostApplyData
    {
        public int Number { get; set; }
        public int cost_id { get; set; }
        public string applicant { get; set; }
        public decimal apply_money { get; set; }
        public DateTime apply_time { get; set; }
        public string status { get; set; }
        
    }
}
