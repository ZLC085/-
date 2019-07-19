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
using PersonInfoManage.DAL.PersonInfo;

namespace PersonInfoManage.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试函数：Login.SelectLogin(user)  测试成功
            //Login Login = new Login();
            //sys_user user = new sys_user();
            //user.username = "lihua";
            //Console.WriteLine(Login.SelectLogin(user));

            //测试函数：perm.add(group)  测试成功
            //Perm perm = new Perm();
            //sys_group group = new sys_group();
            //group.group_name = "普通用户1";
            //group.remark = "no";
            //Console.WriteLine(perm.add(group));

            //测试函数:perm.Update(group_id,grouplist) 测试成功
            //Perm perm = new Perm();
            //int group_id = 15;
            //string[] temp = { "per", "cost", "sys", "test" };
            //List<string> grouplist = new List<string>(temp);
            //Console.WriteLine(perm.Update(group_id, grouplist));

            //测试函数：perm.Del(group_id) 测试成功
            Perm perm = new Perm();
            int group_id = 22;
            Console.WriteLine(perm.Del(group_id));

            //测试函数：perm.Selectgroup(group) 测试成功
            //Perm perm = new Perm();
            //sys_group group = new sys_group();
            //group.group_name = "admin";
            //Console.WriteLine(perm.Selectgroup(group));

            //测试函数：SysUser.add(sys_user user,int groupid)  测试成功
            //SysUser sysuser = new SysUser();
            //sys_user user = new sys_user();
            //user.username = "xiaoming";
            //user.name = "小明";
            //user.password = "789";
            //user.gender = "男";
            //user.job = "领导";
            //user.phone = "17396226172";
            //user.email = "1258323278@qq.com";
            //user.status = false;
            //user.isdel = 0;
            //sys_group group = new sys_group();
            //int groupid = 15;
            //Console.WriteLine(sysuser.add(user, groupid));

            //测试函数：SysUser.Update(sys_user user,int groupid)  测试成功
            //SysUser sysuser = new SysUser();
            //sys_user user = new sys_user();
            //user.username = "lihua";
            //user.name = "李华";
            //user.password = "456";
            //user.gender = "女";
            //user.job = "员工";
            //user.phone = "18990533905";
            //user.email = "873257742@qq.com";
            //user.status = false;
            //user.isdel = 0;
            //sys_group group = new sys_group();
            //int groupid = 11;
            //int id = 27;
            //Console.WriteLine(sysuser.Update(id, user, groupid));

            //测试函数：SysUser.Del(id)  测试成功
            //int id = 33;
            //SysUser sysuser = new SysUser();
            //Console.WriteLine(sysuser.Del(id));

            //测试函数：SysUser.Selectall()  测试成功
            //SysUser sysuser = new SysUser();
            //Console.WriteLine(sysuser.Selectall());

            //测试函数：sysuser.SelectBy(user, group） 测试成功 
            //SysUser sysuser = new SysUser();
            //sys_user user = new sys_user();
            //sys_group group = new sys_group();
            //group.group_name = "admin";
            //Console.WriteLine(sysuser.SelectBy(user, group));

            //数据字典测试开始
            //测试函数：set.Add(dict)  测试成功 
            //SysSetting set = new SysSetting();
            //sys_dict dict = new sys_dict();
            //dict.dict_name = "费用类别";
            //dict.category_name = "其他";
            //Console.WriteLine(set.Add(dict));

            //测试函数：set.Update(dict)  测试成功 
            //SysSetting set = new SysSetting();
            //sys_dict dict = new sys_dict();
            //dict.category_name = "其他1";
            //dict.dict_name = "费用类别";
            //dict.id = 6;
            //Console.WriteLine(set.Update(dict));

            //测试函数：set.Del(dict)  测试成功 
            //SysSetting set = new SysSetting();
            //sys_dict dict = new sys_dict();
            //dict.id = 6;
            //Console.WriteLine(set.Del(dict));

            //测试函数：set.SelectAll()  测试成功
            //SysSetting set = new SysSetting();
            //Console.WriteLine(set.SelectAll());

            //CostApply apply = new CostApply();

            ///测试函数：costApply.Add(cost_main costMain, List<cost_detail> detailList)
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     costMain:applicant、apply_money、apply_time
            ///     detailList：
            ///         cost_detail：cost_type、money

            //cost_main main = new cost_main();
            //main.applicant = "测试add";
            //main.apply_money = 130;
            //main.apply_time = new DateTime(2014, 5, 5, 21, 12, 34);

            //cost_detail detail = new cost_detail();
            //detail.cost_type = "出行";
            //detail.money = 30;

            //cost_detail detail2 = new cost_detail();
            //detail2.cost_type = "住宿";
            //detail2.money = 100;

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
            //main.id = 1563464932;
            //main.apply_money = 700;

            //cost_detail detail = new cost_detail();
            //detail.cost_type = "测试类型1";
            //detail.money = 500;

            //cost_detail detail2 = new cost_detail();
            //detail2.cost_type = "住宿测试2";
            //detail2.money = 200;

            //List<cost_detail> listDetail = new List<cost_detail>();
            //listDetail.Add(detail);
            //listDetail.Add(detail2);

            //Console.WriteLine(apply.Update(main, listDetail));

            ///测试函数：costApply.Del(cost_main costMain)
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     costMain:id

            //cost_main main = new cost_main();
            //main.id = 1563464932;
            //Console.WriteLine(apply.Del(main));

            ///测试函数：costApply.GetById(int id)
            ///返回类型：Dictionary<cost_main, List<cost_detail>> 
            ///测试结果：成功
            ///参数中必需的属性:
            ///     id:费用单编号

            //Dictionary<cost_main, List<cost_detail>> dic = apply.GetById(1563464932);
            //foreach (cost_main cm in dic.Keys)
            //{
            //    Console.WriteLine(cm.id + "  " + cm.applicant + "  " + cm.approver + "  " + cm.apply_time + "  " + cm.approval_time + "  " + cm.apply_money + "  " + cm.approval_money + "  " + cm.status + "  " + cm.remark);
            //    foreach (cost_detail cd in dic[cm])
            //    {
            //        Console.WriteLine("\t" + cd.id + "  " + cd.cost_id + "  " + cd.cost_type + "  " + cd.money);
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
            //    Console.WriteLine(cm.id + "  " + cm.applicant + "  " + cm.approver + "  " + cm.apply_time + "  " + cm.approval_time + "  " + cm.apply_money + "  " + cm.approval_money + "  " + cm.status + "  " + cm.remark);
            //    foreach (cost_detail cd in dic[cm])
            //    {
            //        Console.WriteLine("\t" + cd.id + "  " + cd.cost_id + "  " + cd.cost_type + "  " + cd.money);
            //    }
            //}

            ///测试函数：costApply.Query(Dictionary<string, object> conditions)
            ///返回类型：Dictionary<cost_main, List<cost_detail>> 
            ///测试结果：成功
            ///参数中必需的属性:
            ///     conditions:键值对 key建议是 "id", "applicant", "status", "start_time", "end_time"其中的，否则无效

            //Dictionary<string, object> conditions = new Dictionary<string, object>();
            //conditions.Add("id", 156);
            //conditions.Add("applicant", "测试add");
            //conditions.Add("status", 0);
            //conditions.Add("start_time", new DateTime(2017, 1, 1));
            //conditions.Add("end_time", new DateTime(2017, 5, 1));
            //Dictionary<cost_main, List<cost_detail>> dic = apply.Query(conditions);
            //foreach (cost_main cm in dic.Keys)
            //{
            //    Console.WriteLine(cm.id + "  " + cm.applicant + "  " + cm.approver + "  " + cm.apply_time + "  " + cm.approval_time + "  " + cm.apply_money + "  " + cm.approval_money + "  " + cm.status + "  " + cm.remark);
            //    foreach (cost_detail cd in dic[cm])
            //    {
            //        Console.WriteLine("\t" + cd.id + "  " + cd.cost_id + "  " + cd.cost_type + "  " + cd.money);
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

            ///测试函数：costPlan.Add(List<cost_plan> listPlan)
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     plan:cost_type、money、start_time、end_time

            //CostPlan costPlan = new CostPlan();
            //List<cost_plan> planList = new List<cost_plan>();
            //cost_plan plan = new cost_plan();
            //plan.cost_type = "测试规划1";
            //plan.money = 199;
            //plan.start_time = new DateTime(2020, 1, 1);
            //plan.end_time = new DateTime(2020, 2, 1);

            //cost_plan plan2 = new cost_plan();
            //plan2.cost_type = "测试规划2";
            //plan2.money = 299;
            //plan2.start_time = new DateTime(2020, 1, 1);
            //plan2.end_time = new DateTime(2020, 2, 1);

            //cost_plan plan3 = new cost_plan();
            //plan3.cost_type = "测试规划3";
            //plan3.money = 399;
            //plan3.start_time = new DateTime(2020, 1, 1);
            //plan3.end_time = new DateTime(2020, 2, 1);

            //cost_plan plan4 = new cost_plan();
            //plan4.cost_type = "测试规划4";
            //plan4.money = 499;
            //plan4.start_time = new DateTime(2020, 1, 1);
            //plan4.end_time = new DateTime(2020, 2, 1);

            //planList.Add(plan);
            //planList.Add(plan2);
            //planList.Add(plan3);
            //planList.Add(plan4);
            //Console.WriteLine(costPlan.Add(planList));

            ///测试函数：costPlan.Update(cost_plan plan)
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     plan:id、cost_type、money、start_time、end_time

            //CostPlan costPlan = new CostPlan();
            //cost_plan plan = new cost_plan();
            //plan.id = 19;
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


            ///测试函数：costPlan.Query(Dictionary<string, object> conditions)
            ///返回类型：List<cost_plan> 
            ///测试结果：成功
            ///参数中必需的属性:
            ///     conditions：条件键值对词典  key建议是"start_time", "end_time", "cost_type", "id"其中的，否则无效

            //Dictionary<string, object> conditions = new Dictionary<string, object>();
            //conditions.Add("cost_type","餐饮");
            //List<cost_plan> listPlan = new CostPlan().Query(conditions);
            //foreach(cost_plan plan in listPlan)
            //{
            //Console.WriteLine(plan.id+" "+plan.cost_type+" "+plan.start_time+" "+plan.end_time+" "+plan.money);
            //}

            ///测试函数：CostStastic.Query(Dictionary<string, object> conditions)
            ///返回类型：Dictionary<cost_main, List<cost_detail>> 
            ///测试结果：成功
            ///参数中必需的属性:
            ///     conditions：条件键值对词典  key建议是"start_time", "end_time", "applicant"其中的，否则无效

            //Dictionary<string, object> conditions = new Dictionary<string, object>();
            //conditions.Add("applicant", "小明");
            //conditions.Add("start_time", new DateTime(2017, 1, 1));
            //conditions.Add("end_time",new DateTime(2019,7,19));
            //Dictionary<cost_main, List<cost_detail>> retDic = new CostStatistic().Query(conditions);
            //foreach (cost_main cm in retDic.Keys)
            //{
            //    Console.WriteLine(cm.id + "  " + cm.applicant + "  " + cm.approver + "  " + cm.apply_time + "  " + cm.approval_time + "  " + cm.apply_money + "  " + cm.approval_money + "  " + cm.status + "  " + cm.remark);
            //    foreach (cost_detail cd in retDic[cm])
            //    {
            //        Console.WriteLine("\t" + cd.id + "  " + cd.cost_id + "  " + cd.cost_type + "  " + cd.money);
            //    }
            //}





            /////添加文件
            //PersonFile files = new PersonFile();
            //person_file A = new person_file();
            //A.id = 22;
            //A.person_id = 1;
            //A.filename = "张安的XXX";
            //A.filetype = "222";
            //A.create_time = new DateTime(2019, 4, 1);
            //A.modify_time = new DateTime(2018, 1, 18);
            //Console.WriteLine(files.Add(A));


            //更改文件名

            //PersonFile files = new PersonFile();
            //person_file A = new person_file();
            //A.id = 12;
            //A.filename = "zhao";
            //Console.WriteLine(files.Update(A));


            ////删除文件
            //PersonFile files = new PersonFile();
            //person_file A = new person_file();
            //A.id = 25;
            //Console.WriteLine(files.Del(A));


            //根据ID查询文件
            //PersonFile files = new PersonFile();
            //List<person_file> Listfile = files.GetById(26);
            //foreach (person_file B in Listfile)
            //{
            //    Console.WriteLine(B.id + " " + B.person_id + " " + B.filename + " " + B.file + " " + B.filetype + " " + B.create_time + " " + B.modify_time);

            //}


            Console.ReadKey();
        }
    }
}
