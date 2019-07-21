using PersonInfoManage.DAL.Logs;
using PersonInfoManage.DAL.PersonInfo;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonInfoManage.DAL.Cost;
using PersonInfoManage.BLL.System;

namespace PersonInfoManage.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试函数-数据字典bll set.Del(id)
            //SysSettingBLL set = new SysSettingBLL();
            //sys_dict SysDict = new sys_dict();
            //SysDict.category_name="";
            //SysDict.dict_name ="";
            //Console.WriteLine(set.Add(SysDict));

            //测试set.Update(SysDict)
            //SysSettingBLL set = new SysSettingBLL();
            //sys_dict SysDict = new sys_dict();
            //SysDict.category_name = "";
            //SysDict.dict_name = "";
            //SysDict.id = 11;
            //Console.WriteLine(set.Update(SysDict));

            //测试set.Del(id)
            //SysSettingBLL set = new SysSettingBLL();
            //sys_dict SysDict = new sys_dict();         
            //int id = 10;
            //Console.WriteLine(set.Del(id));

            //测试
            //SysSettingBLL set = new SysSettingBLL();
            //Console.WriteLine(set.SeleteAll());
            //List<sys_dict> listuser = set.SeleteAll();
            //foreach (sys_dict a in listuser)
            //{
            //    Console.WriteLine(a.category_name + "  " +a.dict_name + "  " +a.create_time + "  " + a.modify_time);
            //}


            //测试函数：login.Loginsever(user)  测试成功BLL
            //LoginBLL login = new LoginBLL();
            //sys_user user = new sys_user();
            //user.username = "lihua";
            //user.password = "456";
            //Console.WriteLine(login.Loginsever(user));

            //测试函数：Login.SelectLogin(user)  测试成功DAL
            //Login Login = new Login();
            //sys_user user = new sys_user();
            //user.username = "lihua";
            //Console.WriteLine(Login.SelectLogin(user));

            //测试函数：perm.add(group)  测试成功
            //PermDAL perm = new PermDAL();
            //sys_group group = new sys_group();
            //group.group_name = "管理员";
            ////group.remark = "局长";
            //Console.WriteLine(perm.add(group));

            //测试函数:perm.Update(group_id,grouplist) 测试成功
            //Perm perm = new Perm();
            //sys_group group = new sys_group();
            //group.id = 20;
            //string[] temp = { "人员信息管理", "费用管理", "日志管理", "系统管理" };
            //List<string> grouplist = new List<string>(temp);
            //Console.WriteLine(perm.Update(group, grouplist));

            //测试函数：perm.Del(group_id) 测试成功
            //Perm perm = new Perm();
            //int group_id = 17;
            //Console.WriteLine(perm.Del(group_id));

            //测试函数：perm.Selectall() 测试成功
            //Perm perm = new Perm();
            //Console.WriteLine(perm.Selectall());

            //PermDAL perm = new PermDAL();
            //sys_group group = new sys_group();
            //group.group_name = "管理员";
            //DateTime a = new DateTime(2011,1,1,0,0,0);
            //group.create_time = a;
            //group.modify_time = new DateTime(2022,1,1,1,1,1);
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
            //group.id = 15;
            //Console.WriteLine(sysuser.add(user, group));

            //测试函数：SysUser.Update(sys_user user,int groupid)  测试成功
            //SysUser sysuser = new SysUser();
            //sys_user user = new sys_user();
            //user.id = 27;
            //user.username = "lihua";
            //user.name = "李华";
            //user.password = "456";
            //user.gender = "男";
            //user.job = "领导";
            //user.phone = "17396226172";
            //user.email = "873257742@qq.com";
            //user.status = false;
            //user.isdel = 0;
            //sys_group group = new sys_group();
            //group.id = 15;
            //Console.WriteLine(sysuser.Update(user,group));

            //测试函数：SysUser.Del(id)  测试成功
            //sys_user user = new sys_user();
            //user.id = 35;
            //SysUser sysuser = new SysUser();
            //Console.WriteLine(sysuser.Del(user));

            //测试函数：SysUser.Selectall()  测试成功
            //SysUser sysuser = new SysUser();
            //Console.WriteLine(sysuser.Selectall());

            //测试函数：sysuser.SelectBy(user, group） 测试成功 
            //SysUser sysuser = new SysUser();
            //sys_user user = new sys_user();
            //sys_group group = new sys_group();
            //user.name = "李华";
            //group.group_name = "admin";
            //Console.WriteLine(sysuser.SelectBy(user, group));

            //数据字典测试开始
            //测试函数：set.Add(dict)  测试成功 
            //SysSetting set = new SysSetting();
            //sys_dict dict = new sys_dict();
            //dict.dict_name = "费用类别";
            //dict.category_name = "其他2";
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

            //CostApplyDAL apply = new CostApplyDAL();

            ///测试函数：costApply.Add(cost cost)
            ///返回类型：int
            ///测试结果：成功

            //cost_main main = new cost_main
            //{
            //    applicant = "小陈",
            //    apply_money = 951,
            //    apply_time = DateTime.Now
            //};
            //cost_detail detail = new cost_detail
            //{
            //    cost_type_name = "住宿",
            //    cost_type = 4,
            //    money = 451
            //};
            //cost_detail detail2 = new cost_detail
            //{
            //    cost_type_name = "餐饮",
            //    cost_type = 5,
            //    money = 160
            //};
            //cost_detail detail3 = new cost_detail
            //{
            //    cost_type_name = "出行",
            //    cost_type = 8,
            //    money = 340
            //};
            //List<cost_detail> listDetail = new List<cost_detail>
            //{
            //    detail,
            //    detail2,
            //    detail3
            //};
            //Console.WriteLine(apply.Add(new cost { main = main, DetailList = listDetail }));

            ///测试函数：costApply.Update(cost cost)
            ///返回类型：int
            ///测试结果：成功


            //cost_main main = new cost_main
            //{
            //    id = 1563613841,
            //    apply_money = 900
            //};

            //cost_detail detail = new cost_detail
            //{
            //    cost_type_name = "其他",
            //    cost_type=7,
            //    money = 500
            //};

            //cost_detail detail2 = new cost_detail
            //{
            //    cost_type_name = "餐饮",
            //    cost_type=5,
            //    money = 400
            //};

            //List<cost_detail> listDetail = new List<cost_detail>
            //{
            //    detail,
            //    detail2
            //};

            //Console.WriteLine(apply.Update(new cost { main=main,DetailList=listDetail}));



            ///测试函数：costApply.QueryMain(Dictionary<string, object> conditions)
            ///返回类型：
            ///测试结果：成功
            ///参数中必需的属性:


            Dictionary<string, object> conditions = new Dictionary<string, object>
            {
                //{ "id", 1563517332 },
                //{ "applicant", "测试add" },
                //{ "status", 1 },
                //{ "start_time", new DateTime(2019, 7, 20,19,20,0) },
                //{ "end_time", new DateTime(2017, 5, 5) }
                //{"page",2 },
                //{"limit",20 }
            };
            List<cost_main> list = apply.QueryMain(conditions);
            foreach (cost_main cm in list)
            {
                Console.WriteLine(cm.id + "  " + cm.applicant + "  " + cm.approver + "  " + cm.apply_time + "  " + cm.approval_time + "  " + cm.apply_money + "  " + cm.approval_money + "  " + cm.status + "  " + cm.remark);
                
            }

            ///测试函数：costApproval.Update(cost_main main)
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     main:approver、approval_time、approval_money、status、id

            //cost_main main = new cost_main
            //{
            //    id = 1563517332,
            //    approver = "小Abor",
            //    approval_time = new DateTime(2019, 7, 18),
            //    approval_money = 950,
            //    status = 1
            //};
            //Console.WriteLine(new CostApproval().Update(main));

            ///测试函数：costPlan.Add(List<cost_plan> listPlan)
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     plan:cost_type、money、start_time、end_time

            // CostPlan costplan = new CostPlan();
            //cost_plan plan = new cost_plan();
            //plan.cost_type = "出行";
            //plan.money = 99;
            //plan.start_time = new DateTime(2011, 1, 1);
            //plan.end_time = new DateTime(2017, 1, 1);


            //cost_plan plan2 = new cost_plan();
            //plan2.cost_type = "餐饮";
            //plan2.money = 222;
            //plan2.start_time = new DateTime(2013, 1, 1);
            //plan2.end_time = new DateTime(2017, 1, 1);

            //List<cost_plan> ListPlan = new List<cost_plan>();
            //ListPlan.Add(plan);
            //ListPlan.Add(plan2);

            //Console.WriteLine(costplan.Add(ListPlan));

            ///测试函数：costPlan.Update(List<cost_plan> ListPlan)
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     plan:id、cost_type、money、start_time、end_time

            //CostPlan costPlan = new CostPlan();
            //cost_plan plan = new cost_plan();
            //plan.cost_type = "出行";
            //plan.money = 999;
            //plan.start_time = new DateTime(2011, 1, 1);
            //plan.end_time = new DateTime(2017, 1, 1);

            //cost_plan plan2 = new cost_plan();
            //plan2.cost_type = "餐饮";
            //plan2.money = 999;
            //plan2.start_time = new DateTime(2011, 1, 1);
            //plan2.end_time = new DateTime(2017, 1, 1);

            //List<cost_plan> ListPlan = new List<cost_plan>();
            //ListPlan.Add(plan);
            //ListPlan.Add(plan2);

            //Console.WriteLine(costPlan.Update(ListPlan));

            ///测试函数：costPlan.Del(List<cost_plan> ListPlan )
            ///返回类型：int
            ///测试结果：成功
            ///参数中必需的属性:
            ///     plan:start_time,end_time

            //CostPlan costplan = new CostPlan();
            //cost_plan plan = new cost_plan();
            //plan.start_time = (new DateTime(2011, 1, 1));
            //plan.end_time = (new DateTime(2017, 1, 1));

            //cost_plan plan2 = new cost_plan();
            //plan2.start_time = (new DateTime(2011, 1, 9));
            //plan2.end_time = (new DateTime(2017, 1, 1));

            //List<cost_plan> ListPlan = new List<cost_plan>();
            //ListPlan.Add(plan);
            //ListPlan.Add(plan2);

            //Console.WriteLine(costplan.Del(ListPlan));

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





            ///添加文件
            //PersonFileDAL files = new PersonFileDAL();
            //person_file A = new person_file();
            //A.id = 22;
            //A.person_id = 1;
            //A.filename = "张安的XXX";
            //A.filetype = "222";
            //A.create_time = new DateTime(2019, 4, 1);
            //A.modify_time = new DateTime(2018, 1, 18);
            //Console.WriteLine(files.Add(A));


            ////更改文件名

            //PersonFileDAL files = new PersonFileDAL();
            //person_file A = new person_file();
            //A.id = 12;
            //A.filename = "zhao";
            //Console.WriteLine(files.Update(A));


            ////删除文件
            //PersonFileDAL files = new PersonFileDAL();
            //person_file A = new person_file();
            //A.id = 25;
            //Console.WriteLine(files.Del(A));


            //根据ID查询文件
            //PersonFileDAL files = new PersonFileDAL();
            //List<person_file> Listfile = files.GetById(26);
            //foreach (person_file B in Listfile)
            //{
            //    Console.WriteLine(B.id + " " + B.person_id + " " + B.filename + " " + B.file + " " + B.filetype + " " + B.create_time + " " + B.modify_time);

            //}





            // 删除信息，测试
            //根据id删除
            //测试结果：成功
            //LogSysDAL sys = new LogSysDAL();
            //Console.WriteLine(sys.Del(4));//1成功，0失败

            ////日志查询   测试
            //查询所有
            //测试结果：成功
            //LogUserDAL user = new LogUserDAL();
            //List<log_user> listuser = user.Query(18);
            //foreach (log_user loguser in listuser)
            //{
            //    Console.WriteLine(loguser.id + "  " + loguser.user_id + "  " + loguser.username + "  " + loguser.operation + "  " + loguser.ip + "  " + loguser.create_time);
            //}

            //////系统日志查询，所有
            //LogSysDAL sys = new LogSysDAL();
            //List<log_sys> listsys = sys.Query();
            //foreach (log_sys logsys in listsys)
            //{
            //    Console.WriteLine(logsys.id + "  " + logsys.log_message + "  " + logsys.create_time);
            //}
            //////日志查询   测试
            ////根据用户名查询
            ////测试结果：成功
            //LogUser user = new LogUser();
            //List<log_user> listuser = user.GetByUserName("1");
            //foreach (log_user loguser in listuser)
            //{
            //    Console.WriteLine(loguser.id + "  " + loguser.user_id + "  " + loguser.username + "  " + loguser.operation + "  " + loguser.ip + "  " + loguser.create_time);
            //}

            ////日志条件查询
            ////用户名，时间段查询
            ////测试结果：
            //Dictionary<string, object> conditions = new Dictionary<string, object>();
            //conditions.Add("username", "1");
            //conditions.Add("start_time", new DateTime(2017, 1, 1));
            //conditions.Add("end_time", new DateTime(2019, 7, 19));
            //List<log_user> user = new LogUser().GetByConditionns(conditions);
            //foreach (log_user loguser in user)
            //{
            //    Console.WriteLine(loguser.id + "  " + loguser.user_id + "  " + loguser.username + "  " + loguser.operation + "  " + loguser.ip + "  " + loguser.create_time);

            //}


            ////日志条件查询
            ////用户名，时间段查询
            ////测试结果：
            //Dictionary<string, object> conditions = new Dictionary<string, object>();
            //conditions.Add("start_time", new DateTime(2017,7,1));
            //conditions.Add("end_time", new DateTime(2019, 7, 20));
            //List<log_sys> sys = new LogSysDAL().GetByConditionns(conditions);
            //foreach (log_sys logsys in sys)
            //{
            //    Console.WriteLine(logsys.id + " " + logsys.create_time + "  " + logsys.log_message);

            //}

            //PersonBasicDAL PB = new PersonBasicDAL();
            //person_basic pb = new person_basic();

            //pb.name = "赵四";
            //pb.former_name = "尼古拉斯";
            //pb.gender = "男";
            //pb.identity_number = "123456789";
            //pb.birth_date = DateTime.Now;
            //pb.native_place = "四川成都";
            //pb.marry_status = true;
            //pb.job_status = "养猪";
            //pb.income = 2000;
            //pb.temper = "未知";
            //pb.family = "未知";
            //pb.person_type = 1;
            //pb.person_type_name = "未知";
            //pb.qq = "123456789";
            //pb.address = "成都市双流区养猪场";
            //pb.phone = "123456789";
            //pb.belong_place = 1;
            //pb.belong_place_name = "成都市双流区公安局";
            //pb.nation = "汉";
            //pb.input_time = DateTime.Now;
            //pb.user_id = 1001;
            //pb.isdel = 1;

            // 插入
            //if (PB.Add(pb) > 0)
            //{
            //    Console.WriteLine("插入成功！");
            //}
            //else
            //{
            //    Console.WriteLine("插入失败！");
            //}

            // 修改
            //pb.id = 1001;
            //if (PB.Update(pb) > 0)
            //{
            //    Console.WriteLine("修改成功！");
            //}
            //else
            //{
            //    Console.WriteLine("修改失败！");
            //}

            // 移除
            //int id = 1001;
            //if (PB.Remove(id) > 0)
            //{
            //    Console.WriteLine("移除成功！");
            //}
            //else
            //{
            //    Console.WriteLine("移除失败！");
            //}

            // 删除
            //int id = 1002;
            //if (PB.Del(id) > 0)
            //{
            //    Console.WriteLine("删除成功！");
            //}
            //else
            //{
            //    Console.WriteLine("删除失败！");
            //}

            //List<person_basic> list = new List<person_basic>();
            //pb.name = "赵四";
            //pb.identity_number = "123456789";
            //pb.person_type_name = "未知";
            //pb.native_place = "四川成都";

            // 查询
            //list = PB.Query(pb);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i].id + "\t" + list[i].name + "\t" + list[i].former_name + "\t" + list[i].gender + "\t" + list[i].identity_number + "\t"
            //        + list[i].birth_date + "\t" + list[i].native_place + "\t" + list[i].marry_status + "\t" + list[i].job_status + "\t"
            //        + list[i].income + "\t" + list[i].temper + "\t" + list[i].family + "\t" + list[i].person_type + "\t" + list[i].person_type_name + "\t" + list[i].qq + "\t"
            //        + list[i].address + "\t" + list[i].phone + "\t" + list[i].belong_place + "\t" + list[i].belong_place_name + "\t" + list[i].nation + "\t" + list[i].input_time + "\t"
            //        + list[i].user_id + "\t" + list[i].isdel + "\t\n");
            //}

            //Console.WriteLine("END...");

            Console.ReadKey();
        }
    }
}
