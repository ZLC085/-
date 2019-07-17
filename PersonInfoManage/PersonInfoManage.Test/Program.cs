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
            CostApply apply = new CostApply();
            ///测试函数：costApply.Add(cost_main costMain, List<cost_detail> detailList)
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     costMain:applicant、apply_money、apply_time
            ///     detailList：
            ///         cost_detail：cost_type、money

            //cost_main main = new cost_main();
            //main.applicant = "小明";
            //main.apply_money = 1200;
            //main.apply_time = new DateTime(2019, 1, 1);

            //cost_detail detail = new cost_detail();
            //detail.cost_type = "出行";
            //detail.money = 500;

            //cost_detail detail2 = new cost_detail();
            //detail2.cost_type = "住宿";
            //detail2.money = 700;

            //List<cost_detail> listDetail = new List<cost_detail>();
            //listDetail.Add(detail);
            //listDetail.Add(detail2);

            //Console.WriteLine(apply.Add(main, listDetail));

            ///测试函数：costApply.Update(cost_main costMain, List<cost_detail> detailList)
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     costMain:id、apply_money
            ///     detailList：
            ///         cost_detail：cost_type、money

            //cost_main main = new cost_main();
            //main.id = 1563345759;
            //main.apply_money = 700;

            //cost_detail detail = new cost_detail();
            //detail.cost_type = "出行test";
            //detail.money = 500;

            //cost_detail detail2 = new cost_detail();
            //detail2.cost_type = "饮食";
            //detail2.money = 200;

            //List<cost_detail> listDetail = new List<cost_detail>();
            //listDetail.Add(detail);
            //listDetail.Add(detail2);

            //Console.WriteLine(apply.Update(main,listDetail));

            ///测试函数：costApply.Del(cost_main costMain)
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     costMain:id

            //cost_main main = new cost_main();
            //main.id = 1563345759;
            //Console.WriteLine(apply.Del(main));

            ///测试函数：costApply.GetById(int id)
            ///返回类型：Dictionary<cost_main, List<cost_detail>> 
            ///测试结果：成功
            ///参数中必需的属性:
            ///     id:费用单编号

            //Dictionary<cost_main, List<cost_detail>> dic = apply.GetById(1563342091);
            //foreach(cost_main cm in dic.Keys)
            //{
            //    Console.WriteLine(cm.id+"  "+cm.apply_money+"  "+cm.applicant);
            //    foreach(cost_detail cd in dic[cm])
            //    {
            //        Console.WriteLine("\t"+cd.cost_id+"  "+cd.cost_type+"  "+cd.money);
            //    }
            //}

            ///测试函数：costApply.Query()
            ///返回类型：Dictionary<cost_main, List<cost_detail>> 
            ///测试结果：成功
            ///参数中必需的属性:
            ///     无

            //Dictionary<cost_main, List<cost_detail>> dic = apply.Query();
            //foreach (cost_main cm in dic.Keys)
            //{
            //    Console.WriteLine(cm.id + "  " + cm.apply_money + "  " + cm.applicant);
            //    foreach (cost_detail cd in dic[cm])
            //    {
            //        Console.WriteLine("\t" + cd.cost_id + "  " + cd.cost_type + "  " + cd.money);
            //    }
            //}

            ///测试函数：costApply.Query(Dictionary<string, object> conditions)
            ///返回类型：Dictionary<cost_main, List<cost_detail>> 
            ///测试结果：成功
            ///参数中必需的属性:
            ///     conditions:键值对 key建议是 "id", "applicant", "status", "start_time", "end_time"其中的，否则无效

            //Dictionary<string, object> conditions = new Dictionary<string, object>();
            //conditions.Add("id", 156);
            //conditions.Add("applicant", "小明");
            //conditions.Add("status", 0);
            //conditions.Add("start_time", new DateTime(2017, 1, 1));
            //conditions.Add("end_time", new DateTime(2017, 5, 1));
            //Dictionary<cost_main, List<cost_detail>> dic = apply.Query(conditions);
            //foreach (cost_main cm in dic.Keys)
            //{
            //    Console.WriteLine(cm.id + "  " + cm.apply_money + "  " + cm.applicant);
            //    foreach (cost_detail cd in dic[cm])
            //    {
            //        Console.WriteLine("\t" + cd.cost_id + "  " + cd.cost_type + "  " + cd.money);
            //    }
            //}

            ///测试函数：costApproval.Update(cost_main main)
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     main:approver、approval_time、approval_money、status、id
            cost_main main = new cost_main();
            main.id = 1563342091;
            main.approver = "小Abor";
            main.approval_time = new DateTime(2019,7,17);
            main.approval_money = 99;
            main.status = 1;

            Console.WriteLine(new CostApproval().Update(main));

            Console.ReadKey();
        }
    }
}
