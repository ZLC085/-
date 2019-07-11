using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.IDAL.Cost
{
    /// <summary>
    /// 费用申请
    /// </summary>
    public interface ICostApply
    {
        /// <summary>
        /// 添加费用单
        /// </summary>
        /// <param name="manage">费用单</param>
        /// <param name="detailList">费用明细</param>
        /// <returns>插入条数</returns>
        int InsertBill(cost_manage manage, List<cost_detail> detailList);

        /// <summary>
        /// 修改费用单
        /// </summary>
        /// <param name="manage">需要修改的费用单</param>
        /// <param name="detailList">需要修改的费用明细</param>
        /// <returns></returns>
        int UpdateBill(cost_manage manage, List<cost_detail> detailList);

        /// <summary>
        /// 撤销费用单
        /// </summary>
        /// <param name="costId">费用单id</param>
        /// <returns>删除条数</returns>
        int DeleteBill(long costId);

        /// <summary>
        /// 费用单查询，通过费用单编号
        /// </summary>
        /// <param name="costId"></param>
        /// <returns>通过费用单编号查询到的费用单</returns>
        Dictionary<cost_manage, List<cost_detail>> SelectBillByCostId(int costId);

        /// <summary>
        /// 费用单查询，通过申请人
        /// </summary>
        /// <param name="person"></param>
        /// <returns>通过申请人查询到的费用单</returns>
        Dictionary<cost_detail, List<cost_detail>> SelectBillByApplyPerson(string person);

        /// <summary>
        /// 费用单查询
        /// </summary>
        /// <returns>所有费用单</returns>
        Dictionary<cost_manage, List<cost_detail>> SelectBill();
    }
}
