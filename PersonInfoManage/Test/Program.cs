using PersonInfoManage.DAL.PersonInfo;
using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonBasic PB = new PersonBasic();
            person_basic pb = new person_basic();

            //pb.name = "毛宇航";
            //pb.former_name = "";
            //pb.gender = "男";
            //pb.identity_number = "1";
            //pb.birth_date = DateTime.Now;
            //pb.city = "1";
            //pb.province = "1";
            //pb.marry_status = true;
            //pb.job_status = "1";
            //pb.income = 1;
            //pb.temper = "1";
            //pb.family = "1";
            //pb.person_type = "1";
            //pb.qq = "1";
            //pb.address = "1";
            //pb.phone = "1";
            //pb.belong_place = "1";
            //pb.nation = "1";
            //pb.input_time = DateTime.Now;
            //pb.user_id = 1;
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
            //int id = 1006;
            //if (PB.update(id, pb) > 0)
            //{
            //    Console.WriteLine("修改成功！");
            //}
            //else
            //{
            //    Console.WriteLine("修改失败！");
            //}

            // 删除
            //int id = 1005;
            //if (PB.Del(id) > 0)
            //{
            //    Console.WriteLine("删除成功！");
            //}
            //else
            //{
            //    Console.WriteLine("删除失败！");
            //}


            List<person_basic> list = new List<person_basic>();
            pb.name = "毛宇航";
            pb.identity_number = "1";

            // 查询
            //list = PB.Query();
            // 查询(按条件)
            list = PB.QueryByCond(pb);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].id + "\t" + list[i].name + "\t" + list[i].former_name + "\t" + list[i].gender + "\t" + list[i].identity_number + "\t"
                    + list[i].birth_date + "\t" + list[i].city + "\t" + list[i].province + "\t" + list[i].marry_status + "\t" + list[i].job_status + "\t"
                    + list[i].income + "\t" + list[i].temper + "\t" + list[i].family + "\t" + list[i].person_type + "\t" + list[i].qq + "\t"
                    + list[i].address + "\t" + list[i].phone + "\t" + list[i].belong_place + "\t" + list[i].nation + "\t" + list[i].input_time + "\t"
                    + list[i].user_id + "\t" + list[i].isdel + "\t\n");
            }


            Console.ReadKey();
        }
    }
}
