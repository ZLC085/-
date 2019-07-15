using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonInfoManage.DAL.Cost;
using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Models;

namespace UnitTestProject
{
    [TestClass]
    public class DBUnitTest
    {
        [TestMethod]
        public void DBTestMethod()
        {
            int costId = TimeTools.Timestamp();
            List<cost_detail> details = new List<cost_detail>
            {
                new cost_detail { cost_id = costId, cost_type="出差",money=1213},
                new cost_detail{cost_id = costId,cost_type="住宿",money=2324}
            };

            cost_main costMain = new cost_main
            {
                applicant = "test",
                apply_money = 1213.12M,
                apply_time = DateTime.Now,
                approver = "test",
                id = costId,
                cost_detail = details,
                status = 1,
                approval_time = DateTime.Now,
                approval_money=131
            };
            CostApply costApply = new CostApply();
            int a = costApply.InsertBill(costMain);



           
            Console.WriteLine(a);
        }
    }
}
