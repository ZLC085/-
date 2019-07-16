using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Cost
{
    /// <summary>
    /// 费用申请
    /// </summary>
    public class CostApply
    {
        /// <summary>
        /// 添加费用单
        /// </summary>
        /// <param name="costMain">费用单</param>
        /// <param name="detailList">费用明细</param>
        /// <returns>插入条数</returns>
        public int InsertBill(cost_main costMain, List<cost_detail> detailList)
        {
            return new DBOperationsInsert<cost_main, cost_detail>().InsertByTransaction(costMain, detailList);
        }

        public int InsertBill(cost_main costMain)
        {
            return new DBOperationsInsert<cost_main, cost_detail>().Insert(costMain);
        }

        /// <summary>
        /// 更新cost_main
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newValues">更新的值</param>
        /// <returns>更新条数</returns>
        public int UpdateBillForCostMain(int id, Dictionary<string, object> newValues)
        {
            return new DBOperationsUpdate<cost_main>().UpdateById(id, newValues);
        }

        /// <summary>
        /// 更新cost_detail
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newValues">更新的值</param>
        /// <returns>更新条数</returns>
        public int UpdateBillForCostDetail(int id, Dictionary<string, object> newValues)
        {
            return new DBOperationsUpdate<cost_detail>().UpdateById(id, newValues);
        }

        /// <summary>
        /// 撤销费用单
        /// </summary>
        /// <param name="costId">费用单编号</param>
        /// <returns>删除条数</returns>
        public int DeleteBill(int costId)
        {
            return new DBOperationsDelete<cost_main, cost_detail>().DeleteTransaction(nameof(cost_detail.cost_id), costId);
        }

        /// <summary>
        /// 费用单查询，通过费用单编号
        /// </summary>
        /// <param name="costId">费用单编号</param>
        /// <returns>通过费用单编号查询到的费用单</returns>
        public Dictionary<cost_main, List<cost_detail>> SelectBillByConditions(Dictionary<string, object> conditions)
        {
            Dictionary<cost_main, List<cost_detail>> bills = new Dictionary<cost_main, List<cost_detail>>();
            List<cost_main> mains = new DBOperationsSelect<cost_main>().SelectByConditions(conditions);

            foreach (var item in mains)
            {
                Dictionary<string, object> detailCondition = new Dictionary<string, object>
                {
                    { nameof(cost_detail.cost_id), item.id }
                };
                List<cost_detail> details = new DBOperationsSelect<cost_detail>().SelectByConditions(detailCondition);

                bills.Add(item, details);
            }

            return bills;
        }

        /// <summary>
        /// 费用所有单查询
        /// </summary>
        /// <returns>所有费用单</returns>
        public Dictionary<cost_main, List<cost_detail>> SelectAllBill()
        {
            Dictionary<cost_main, List<cost_detail>> bills = new Dictionary<cost_main, List<cost_detail>>();
            List<cost_main> mains = new DBOperationsSelect<cost_main>().SelectAll();

            foreach (var item in mains)
            {
                Dictionary<string, object> detailCondition = new Dictionary<string, object>
                {
                    { nameof(cost_detail.cost_id), item.id }
                };
                List<cost_detail> details = new DBOperationsSelect<cost_detail>().SelectByConditions(detailCondition);

                bills.Add(item, details);
            }

            return bills;
        }
    }
}
