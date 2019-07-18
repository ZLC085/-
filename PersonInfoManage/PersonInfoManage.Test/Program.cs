using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonInfoManage.Model;
using PersonInfoManage.DAL.Utils;
using PersonInfoManage.DAL.System;
using PersonInfoManage.DAL.Cost;
using PersonInfoManage.DAL.Login;
namespace PersonInfoManage.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试函数：Login.SelectLogin(user)  测试成功
            //Login Login = new Login();
            //sys_user user = new sys_user();
            //user.username = "1";
            //Console.WriteLine(Login.SelectLogin(user));

            //测试函数：SysUser.add(sys_user user,int groupid)  测试成功
            //SysUser sysuser = new SysUser();
            //sys_user user = new sys_user();
            //user.username = "lihua";
            //user.name = "李华";
            //user.password = "123456";
            //user.gender = "男";
            //user.job = "员工";
            //user.phone = "18990533905";
            //user.email = "873257742@qq.com";
            //user.status = false;
            //user.isdel = 0;
            //sys_group group = new sys_group();
            //int groupid = 11;
            //Console.WriteLine(sysuser.add(user, groupid));

            //测试函数：SysUser.Update(sys_user user,int groupid)  测试成功
            //SysUser sysuser = new SysUser();
            //sys_user user = new sys_user();
            //user.username = "lihua";
            //user.name = "李华";
            //user.password = "123";
            //user.gender = "男";
            //user.job = "员工";
            //user.phone = "18990533905";
            //user.email = "873257742@qq.com";
            //user.status = false;
            //user.isdel = 0;
            //sys_group group = new sys_group();
            //int groupid = 11;
            //int id = 20;
            //Console.WriteLine(sysuser.Update(id,user, groupid));

            //测试函数：SysUser.Del(id)  测试成功
            //int id = 20;
            //SysUser sysuser = new SysUser();
            //Console.WriteLine(sysuser.Del(id));

            //测试函数：SysUser.Selectall()  测试成功
            //SysUser sysuser = new SysUser();
            //Console.WriteLine(sysuser.Selectall());

            //测试函数：set.SelectAllSysDict()  测试成功
            //SysSetting set = new SysSetting();
            //Console.WriteLine(set.SelectAllSysDict());

            CostApply apply = new CostApply();

            ///测试函数：costApply.Add(cost_main costMain, List<cost_detail> detailList)
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     costMain:applicant、apply_money、apply_time
            ///     detailList：
            ///         cost_detail：cost_type、money

            //cost_main main = new cost_main();
            //main.applicant = "成创空间";
            //main.apply_money = 120;
            //main.apply_time = new DateTime(2011, 5, 1);

            //cost_detail detail = new cost_detail();
            //detail.cost_type = "出行";
            //detail.money = 40;

            //cost_detail detail2 = new cost_detail();
            //detail2.cost_type = "住宿";
            //detail2.money = 30;

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

            //cost_main main = new cost_main();
            //main.id = 1563342091;
            //main.approver = "小Abor";
            //main.approval_time = new DateTime(2019, 7, 17);
            //main.approval_money = 99;
            //main.status = 1;

            //Console.WriteLine(new CostApproval().Update(main));

            ///测试函数：costPlan.Add(cost_plan plan)
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     plan:cost_type、money、start_time、end_time

            //CostPlan costPlan = new CostPlan();
            //cost_plan plan = new cost_plan();
            //plan.cost_type = "出行";
            //plan.money = 99;
            //plan.start_time = new DateTime(2011, 1, 1);
            //plan.end_time = new DateTime(2017, 1, 1);
            //Console.WriteLine(costPlan.Add(plan));

            ///测试函数：costPlan.Update(cost_plan plan)
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     plan:id、cost_type、money、start_time、end_time

            //CostPlan costPlan = new CostPlan();
            //cost_plan plan = new cost_plan();
            //plan.id = 14;
            //plan.cost_type = "玩";
            //plan.money = 999;
            //plan.start_time = new DateTime(2017, 1, 1);
            //plan.end_time = new DateTime(2017, 5, 1);
            //Console.WriteLine(costPlan.Update(plan));

            ///测试函数：costPlan.Del(cost_plan plan)
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     plan:id

            //CostPlan costPlan = new CostPlan();
            //cost_plan plan = new cost_plan();
            //plan.id = 14;

            //Console.WriteLine(costPlan.Del(plan));

            ///测试函数：costPlan.GetById(int id)
            ///返回类型：List<cost_plan> 
            ///测试结果：成功
            ///参数中必需的属性:
            ///     id:费用规划id

            //CostPlan costPlan = new CostPlan();
            //List<cost_plan> listPlan = costPlan.GetById(15);
            //foreach(cost_plan plan in listPlan)
            //{
            //    Console.WriteLine(plan.id+"  "+plan.cost_type+"  "+plan.start_time+"  "+plan.end_time+"  "+plan.money);
            //}

            ///测试函数：costPlan.Query()
            ///返回类型：List<cost_plan> 
            ///测试结果：成功
            ///参数中必需的属性:
            ///     无

            //CostPlan costPlan = new CostPlan();
            //List<cost_plan> listPlan = costPlan.Query();
            //foreach (cost_plan plan in listPlan)
            //{
            //    Console.WriteLine(plan.id + "  " + plan.cost_type + "  " + plan.start_time + "  " + plan.end_time + "  " + plan.money);
            //}

            ///测试函数：CostStatistic.GetById(int id)
            ///返回类型：Dictionary<cost_main, List<cost_detail>>
            ///测试结果：
            ///参数中必需的属性:
            ///     id：费用单id

            //Dictionary<cost_main, List<cost_detail>> dic = new CostStatistic().GetById(1563342091);
            //foreach (cost_main cm in dic.Keys)
            //{
            //    Console.WriteLine(cm.id + "  " + cm.applicant + "  " + cm.approval_time);
            //    foreach (cost_detail cd in dic[cm])
            //    {
            //        Console.WriteLine("\t"+cd.id + cd.cost_id + "  " + cd.cost_type + "  " + cd.money);
            //    }
            //}

            ///测试函数：CostStatistic.Query()
            ///返回类型：Dictionary<cost_main, List<cost_detail>>
            ///测试结果：
            ///参数中必需的属性:
            ///     无
            Dictionary<cost_main, List<cost_detail>> dic = new CostStatistic().Query();
            foreach (cost_main cm in dic.Keys)
            {
                Console.WriteLine(cm.id + "  " + cm.applicant + "  " + cm.approval_time);
                foreach (cost_detail cd in dic[cm])
                {
                    Console.WriteLine("\t" + cd.id + cd.cost_id + "  " + cd.cost_type + "  " + cd.money);
                }
            }

            Console.ReadKey();

        }
    }
}
