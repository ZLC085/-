using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Cost
{
    /// <summary>
    /// 费用统计
    /// </summary>
    public class CostStatistic : DALBase
    {
        /// <summary>
        /// 根据组合条件查询已审核通过的费用单
        /// </summary>
        /// <param name="conditions">条件键值对key: "applicant","start_time", "end_time"</param>
        /// <returns>费用单对象与费用详情对象列表构成的词典键值对</returns>
        public Dictionary<cost_main, List<cost_detail>> Query(Dictionary<string, object> conditions)
        {
            string[] keys = new string[] { "start_time", "end_time", "applicant" };
            Dictionary<cost_main, List<cost_detail>> retDic = new Dictionary<cost_main, List<cost_detail>>();
            List<string> listKey = new List<string>();
            foreach (string key in conditions.Keys)
            {
                if (keys.Contains(key))
                {
                    listKey.Add(key);
                }

            }
            string sql = "select * from cost_main where status ='1' ";
            foreach (string key in listKey)
            {
                sql += " and ";
                if (key.Equals("start_time"))
                {
                    sql += " approval_time >='" + conditions[key] + "'";
                }
                else if (key.Equals("end_time"))
                {
                    sql += " approval_time<='" + conditions[key] + "'";
                }
                else
                {
                    sql += " " + key + " like N'%" + conditions[key] + "%'";
                }
            }
            DataTable dt = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cost_main main = new cost_main();
                main.id = (int)dt.Rows[i][nameof(cost_main.id)];
                main.applicant = (string)dt.Rows[i][nameof(cost_main.applicant)];
                main.approver = (string)dt.Rows[i][nameof(cost_main.approver)];
                main.apply_time = (DateTime)dt.Rows[i][nameof(cost_main.apply_time)];
                //判断approval_time单元格是否为null
                if (dt.Rows[i][nameof(cost_main.approval_time)] != DBNull.Value)
                    main.approval_time = (DateTime)dt.Rows[i][nameof(cost_main.approval_time)];
                else
                    main.approval_time = null;
                main.apply_money = (decimal)dt.Rows[i][nameof(cost_main.apply_money)];
                main.approval_money = (decimal)dt.Rows[i][nameof(cost_main.approval_money)];
                main.status = (byte)dt.Rows[i][nameof(cost_main.status)];
                main.remark = (string)dt.Rows[i][nameof(cost_main.remark)];

                string sql2 = "select * from cost_detail where cost_id='" + main.id + "'";
                DataTable dt2 = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql2).Tables[0];

                List<cost_detail> listDetail = new List<cost_detail>();
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    cost_detail detail = new cost_detail();
                    detail.id = (int)dt2.Rows[j][nameof(cost_detail.id)];
                    detail.cost_id = (int)dt2.Rows[j][nameof(cost_detail.cost_id)];
                    detail.cost_type = (string)dt2.Rows[j][nameof(cost_detail.cost_type)];
                    detail.money = (decimal)dt2.Rows[j][nameof(cost_detail.money)];
                    listDetail.Add(detail);
                }
                retDic.Add(main, listDetail);
            }
            return retDic;

        }

    }
}
