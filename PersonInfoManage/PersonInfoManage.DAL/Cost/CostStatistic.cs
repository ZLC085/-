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
    public class CostStatistic:DALBase
    {
        /// <summary>
        /// 费用统计，根据id
        /// </summary>
        /// <param name="id">费用单id</param>
        /// <returns></returns>
        public Dictionary<cost_main, List<cost_detail>> GetById(int id)
        {
            Dictionary<cost_main, List<cost_detail>> bills = new Dictionary<cost_main, List<cost_detail>>();
            cost_main main = new cost_main();
            List<cost_detail> listDetail = new List<cost_detail>();

            string sql1 = "select id,applicant,approval_time from cost_main where id='" + id + "'";
            string sql2 = "select * from cost_detail where cost_id='" + id + "'";

            DataSet ds1 = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql1);

            main.id = (int)ds1.Tables[0].Rows[0][nameof(cost_main.id)];
            main.applicant = (string)ds1.Tables[0].Rows[0][nameof(cost_main.applicant)];
            main.approval_time = (DateTime)ds1.Tables[0].Rows[0][nameof(cost_main.approval_time)];
            
            DataSet ds2 = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql2);
            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                cost_detail detail = new cost_detail();
                detail.id = (int)ds2.Tables[0].Rows[i][nameof(cost_detail.id)];
                detail.cost_id = int.Parse((string)ds2.Tables[0].Rows[i][nameof(cost_detail.cost_id)]);
                detail.cost_type = (string)ds2.Tables[0].Rows[i][nameof(cost_detail.cost_type)];
                detail.money = (decimal)ds2.Tables[0].Rows[i][nameof(cost_detail.money)];
                listDetail.Add(detail);
            }
            bills.Add(main, listDetail);
            return bills;
        }

        public Dictionary<cost_main, List<cost_detail>> Query()
        {
            Dictionary<cost_main, List<cost_detail>> bills = new Dictionary<cost_main, List<cost_detail>>();
            cost_main main = new cost_main();
            List<cost_detail> listDetail = new List<cost_detail>();

            string sql1 = "select id,applicant,approval_time from cost_main";

            DataSet ds1 = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql1);

            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                main.id = (int)ds1.Tables[0].Rows[i][nameof(cost_main.id)];
                main.applicant = (string)ds1.Tables[0].Rows[i][nameof(cost_main.applicant)];
                main.approval_time = (DateTime)ds1.Tables[0].Rows[i][nameof(cost_main.approval_time)];
               
                string sql2 = "select * from cost_detail where cost_id='" + main.id + "'";
                DataSet ds2 = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql2);
                for (int j = 0; j < ds2.Tables[0].Rows.Count; j++)
                {
                    cost_detail detail = new cost_detail();
                    detail.id = (int)ds2.Tables[0].Rows[j][nameof(cost_detail.id)];
                    detail.cost_id = int.Parse((string)ds2.Tables[0].Rows[j][nameof(cost_detail.cost_id)]);
                    detail.cost_type = (string)ds2.Tables[0].Rows[j][nameof(cost_detail.cost_type)];
                    detail.money = (decimal)ds2.Tables[0].Rows[j][nameof(cost_detail.money)];
                    listDetail.Add(detail);
                }
                bills.Add(main, listDetail);
            }
            return bills;
        }
    }
}
