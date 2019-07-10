
using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL
{
    public class Add
    {
        public void AddCostPlaning()
        {
            using(var cp = new EFModel())
            {
                var query = from b in cp.cost_planning
                            select b;
                
                foreach (var item in query)
                {
                    Console.WriteLine(item.cost_id);
                }
            }
        }
    }
}
