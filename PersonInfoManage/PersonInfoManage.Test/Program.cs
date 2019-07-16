using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonInfoManage.Model;
using PersonInfoManage.DAL.Utils;
using PersonInfoManage.DAL.Cost;

namespace PersonInfoManage.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //cost_plan plan = new cost_plan();
            //plan.id = 1;
            //plan.cost_type = "出行";
            //plan.start_time = new DateTime(2019, 07, 16);
            //plan.end_time = new DateTime(2019, 07, 17);
            //plan.money = 500;
            //CostPlan costPlan = new CostPlan();
            //Console.WriteLine(costPlan.InsertCostPlan(plan));
            cost_main main = new cost_main();
            main.applicant = "小明";
            main.apply_money = 1200;
            main.apply_time = new DateTime(2019, 1, 1);

            cost_detail detail = new cost_detail();
            detail.cost_id = 123;
            detail.cost_type = "出行";
            detail.money = 500;

            cost_detail detail2 = new cost_detail();
            detail2.cost_id = 124;
            detail2.cost_type = "住宿";
            detail2.money = 700;

            List<cost_detail> listDetail = new List<cost_detail>();
            listDetail.Add(detail);
            listDetail.Add(detail2);


            CostApply apply = new CostApply();            
            Console.WriteLine(apply.Add(main, listDetail));
            Console.ReadKey();
        }
    }
}
