using PersonInfoManage.IDAL.Cost;
using PersonInfoManage.Models;
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
    public class CostApply : ICostApply
    {
        /// <summary>
        /// 添加费用单
        /// </summary>
        /// <param name="manage">费用单</param>
        /// <param name="detailList">费用明细</param>
        /// <returns>插入条数</returns>
        public int InsertBill(cost_manage manage, List<cost_detail> detailList)
        {
            return 0;
        }

        /// <summary>
        /// 修改费用单
        /// </summary>
        /// <param name="manage">需要修改的费用单</param>
        /// <param name="detailList">需要修改的费用明细</param>
        /// <returns></returns>
        public int UpdateBill(cost_manage manage, List<cost_detail> detailList)
        {
            return 0;
        }

        /// <summary>
        /// 撤销费用单
        /// </summary>
        /// <param name="costId">费用单id</param>
        /// <returns>删除条数</returns>
        public int DeleteBill(long costId)
        {
            return 0;
        }

        /// <summary>
        /// 费用单查询，通过费用单编号
        /// </summary>
        /// <param name="costId"></param>
        /// <returns>通过费用单编号查询到的费用单</returns>
        public Dictionary<cost_manage, List<cost_detail>> SelectBillByCostId(int costId)
        {
            return null;
        }

        /// <summary>
        /// 费用单查询，通过申请人
        /// </summary>
        /// <param name="person"></param>
        /// <returns>通过申请人查询到的费用单</returns>
        public Dictionary<cost_detail, List<cost_detail>> SelectBillByApplyPerson(string person)
        {
            return null;
        }

        /// <summary>
        /// 费用单查询
        /// </summary>
        /// <returns>所有费用单</returns>
        public Dictionary<cost_manage, List<cost_detail>> SelectBill()
        {
            return null;
        }
    }
}
