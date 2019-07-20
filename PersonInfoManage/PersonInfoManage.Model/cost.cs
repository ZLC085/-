using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.Model
{
    public partial class cost
    {
        public cost_main main { get; set; }
        public List<cost_detail> listDetail { get; set; }
    }
}
