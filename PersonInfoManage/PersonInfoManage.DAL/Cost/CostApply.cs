using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace PersonInfoManage.DAL.Cost
{
    /// <summary>
    /// 费用申请
    /// </summary>
    public class CostApply:DALBase
    {
        /// <summary>
        /// 添加费用单
        /// </summary>
        /// <param name="costMain">费用单对象cost_main：applicant、apply_money、apply_time</param>
        /// <param name="detailList">费用类型明细列表cost_detail:cost_type、money</param>
        /// <returns>数据表受影响的行数</returns>
        public int Add(cost_main costMain, List<cost_detail> detailList)
        {
            //先构造所有的sql语句
            string[] sqlArray = new string[1 + detailList.Count];
            //先构造插入cost_main表的语句
            int timeStamp = TimeTools.Timestamp();
            costMain.id = timeStamp;//主键(费用单id)是时间戳
            costMain.approval_money = 0;
            sqlArray[0] = ConditionsToSql<cost_main>.InsertSql(costMain);
            //再构造插入cost_detail表语句
            int count = 0;
            foreach(cost_detail detail in detailList)
            {
                detail.cost_id = timeStamp;
                sqlArray[count + 1] = ConditionsToSql<cost_detail>.InsertSql(detail);
                count++;
            }
            //调用方法以事务方式执行sql数组里的语句
            return sqlArrayToTran.doTran(sqlArray);            
        }
        /// <summary>
        /// 更新费用单信息
        /// </summary>
        /// <param name="costMain">费用单对象cost_main：id、apply_money</param>
        /// <param name="detailList">费用类型明细列表cost_detail:cost_type、money</param>
        /// <returns>数据表受影响的行数</returns>
        public int Update(cost_main costMain, List<cost_detail> detailList)
        {
            //构造sql语句数组
            string[] sqlArray = new string[2+detailList.Count];
            //先更新cost_main表
            sqlArray[0]= "update cost_main set " +
                nameof(cost_main.apply_money) + "=" + costMain.apply_money +
                " where id='" + costMain.id + "'";
            //再删除cost_detail表数据
            sqlArray[1] = "delete from cost_detail where "+nameof(cost_detail.cost_id)+"='"+costMain.id+"'";
            //再插入cost_detail表数据
            int count = 1;
            foreach(cost_detail detail in detailList)
            {
                detail.cost_id = costMain.id;
                sqlArray[count + 1] = ConditionsToSql<cost_detail>.InsertSql(detail);
                count++;
            }
            //调用方法以事务方式执行sql数组里的语句
            return sqlArrayToTran.doTran(sqlArray);            
        }
        /// <summary>
        /// 撤销费用单
        /// </summary>
        /// <param name="costMain">费用单对象cost_main：id</param>
        /// <returns>数据表受影响的行数</returns>
        public int Del(cost_main costMain)
        {
            //构造sql语句数组
            string[] sqlArray = new string[2];
            //先删除费用类型表记录
            sqlArray[0] = "delete from cost_detail where "+nameof(cost_detail.cost_id)+"="+costMain.id;
            //再删除费用单表记录
            sqlArray[1] = "delete from cost_main where id='" + costMain.id + "'";
            //调用方法以事务方式执行sql数组里的语句
            return sqlArrayToTran.doTran(sqlArray);            
        }
        /// <summary>
        /// 通过费用单编号查询费用单详情
        /// </summary>
        /// <param name="id">费用单编号</param>
        /// <returns>费用单对象与费用详情对象列表构成的词典键值对</returns>
        public Dictionary<cost_main, List<cost_detail>> GetById(int id)
        {
            Dictionary<cost_main, List<cost_detail>> bills = new Dictionary<cost_main, List<cost_detail>>();
            cost_main main = new cost_main();
            List<cost_detail> listDetail = new List<cost_detail>();

            string sql1 = "select * from cost_main where id='"+id+"'";
            string sql2 = "select * from cost_detail where cost_id='" + id + "'";

            DataSet ds1 = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql1);

            main.id=(int)ds1.Tables[0].Rows[0][nameof(cost_main.id)];
            main.applicant = (string)ds1.Tables[0].Rows[0][nameof(cost_main.applicant)];
            main.approver = (string)ds1.Tables[0].Rows[0][nameof(cost_main.approver)];
            main.apply_time = (DateTime)ds1.Tables[0].Rows[0][nameof(cost_main.apply_time)];
            //判断approval_time单元格是否为null
            if (ds1.Tables[0].Rows[0][nameof(cost_main.approval_time)] != DBNull.Value)
                main.approval_time = (DateTime)ds1.Tables[0].Rows[0][nameof(cost_main.approval_time)];
            else
                main.approval_time = null;
            main.apply_money = (decimal)ds1.Tables[0].Rows[0][nameof(cost_main.apply_money)];
            main.approval_money = (decimal)ds1.Tables[0].Rows[0][nameof(cost_main.approval_money)];
            main.status =(byte)ds1.Tables[0].Rows[0][nameof(cost_main.status)];
            main.remark = (string)ds1.Tables[0].Rows[0][nameof(cost_main.remark)];

            DataSet ds2 = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql2);
            for(int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                cost_detail detail = new cost_detail();
                detail.id = (int)ds2.Tables[0].Rows[i][nameof(cost_detail.id)];
                detail.cost_id = (int)ds2.Tables[0].Rows[i][nameof(cost_detail.cost_id)];
                detail.cost_type = (string)ds2.Tables[0].Rows[i][nameof(cost_detail.cost_type)];
                detail.money = (decimal)ds2.Tables[0].Rows[i][nameof(cost_detail.money)];
                listDetail.Add(detail);
            }
            bills.Add(main, listDetail);
            return bills;
        }
        /// <summary>
        /// 查询所有费用单
        /// </summary>
        /// <returns>费用单对象与费用详情对象列表构成的词典键值对</returns>
        public Dictionary<cost_main, List<cost_detail>> Query()
        {
            Dictionary<cost_main, List<cost_detail>> bills = new Dictionary<cost_main, List<cost_detail>>();
            

            string sql1 = "select * from cost_main";

            DataSet ds1 = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql1);

            for(int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                cost_main main = new cost_main();
                List<cost_detail> listDetail = new List<cost_detail>();
                main.id = (int)ds1.Tables[0].Rows[i][nameof(cost_main.id)];
                main.applicant = (string)ds1.Tables[0].Rows[i][nameof(cost_main.applicant)];
                main.approver = (string)ds1.Tables[0].Rows[i][nameof(cost_main.approver)];
                main.apply_time = (DateTime)ds1.Tables[0].Rows[i][nameof(cost_main.apply_time)];
                //判断approval_time单元格是否为null
                if (ds1.Tables[0].Rows[i][nameof(cost_main.approval_time)] != DBNull.Value)
                    main.approval_time = (DateTime)ds1.Tables[0].Rows[i][nameof(cost_main.approval_time)];
                else
                    main.approval_time = null;
                main.apply_money = (decimal)ds1.Tables[0].Rows[i][nameof(cost_main.apply_money)];
                main.approval_money = (decimal)ds1.Tables[0].Rows[i][nameof(cost_main.approval_money)];
                main.status = (byte)ds1.Tables[0].Rows[i][nameof(cost_main.status)];
                main.remark = (string)ds1.Tables[0].Rows[i][nameof(cost_main.remark)];

                string sql2 = "select * from cost_detail where cost_id='" + main.id + "'";
                DataSet ds2 = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql2);
                for (int j = 0; j < ds2.Tables[0].Rows.Count; j++)
                {
                    cost_detail detail = new cost_detail();
                    detail.id = (int)ds2.Tables[0].Rows[j][nameof(cost_detail.id)];
                    detail.cost_id = (int)ds2.Tables[0].Rows[j][nameof(cost_detail.cost_id)];
                    detail.cost_type = (string)ds2.Tables[0].Rows[j][nameof(cost_detail.cost_type)];
                    detail.money = (decimal)ds2.Tables[0].Rows[j][nameof(cost_detail.money)];
                    listDetail.Add(detail);
                }
                bills.Add(main, listDetail);
            }

            
            return bills;
        }
        /// <summary>
        /// 根据组合条件查询费用单
        /// </summary>
        /// <param name="consitions">条件键值对key: "id", "applicant", "status", "start_time", "end_time"</param>
        /// <returns>费用单对象与费用详情对象列表构成的词典键值对</returns>
        public Dictionary<cost_main, List<cost_detail>> Query(Dictionary<string, object> conditions)
        {
            string[] keys = new string[] {"id", "applicant", "status", "start_time", "end_time" };
            Dictionary<cost_main, List<cost_detail>> retDic = new Dictionary<cost_main, List<cost_detail>>();
            List<string> keyList = new List<string>();

            
            foreach (string key in conditions.Keys)
            {   //对参数进行合法性检验
                if (keys.Contains(key))
                    keyList.Add(key);

            }
            string sql = "select * from cost_main ";
            if (keyList.Count != 0)
            {
                sql += "where ";
                foreach (string key in keyList)
                {   //根据参数列表，拼接sql语句
                    if (!key.Equals(keyList.First()))
                    {
                        sql += "and ";
                    }
                    if (key.Equals("start_time"))
                    {
                        sql += " apply_time>='" + conditions["start_time"] + "'";
                    }
                    else if (key.Equals("end_time"))
                    {
                        sql += " apply_time<='" + conditions["end_time"] + "'";
                    }
                    else
                    {   //增加对中文的支持
                        sql += " " + key + " like N'%" + conditions[key] + "%'";
                    }

                }
            }

            
            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cost_main main = new cost_main();
                main.id = (int)ds.Tables[0].Rows[i][nameof(cost_main.id)];
                main.applicant = (string)ds.Tables[0].Rows[i][nameof(cost_main.applicant)];
                main.approver = (string)ds.Tables[0].Rows[i][nameof(cost_main.approver)];
                main.apply_time = (DateTime)ds.Tables[0].Rows[i][nameof(cost_main.apply_time)];
                //判断approval_time单元格是否为null
                if (ds.Tables[0].Rows[i][nameof(cost_main.approval_time)] != DBNull.Value)
                    main.approval_time = (DateTime)ds.Tables[0].Rows[i][nameof(cost_main.approval_time)];
                else
                    main.approval_time = null;
                main.apply_money = (decimal)ds.Tables[0].Rows[i][nameof(cost_main.apply_money)];
                main.approval_money = (decimal)ds.Tables[0].Rows[i][nameof(cost_main.approval_money)];
                main.status = (byte)ds.Tables[0].Rows[i][nameof(cost_main.status)];
                main.remark = (string)ds.Tables[0].Rows[i][nameof(cost_main.remark)];

                List<cost_detail> listDetail = new List<cost_detail>();
                string sql2 = "select * from cost_detail where cost_id='" + main.id + "'";
                DataSet ds2 = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql2);
                for (int j = 0; j < ds2.Tables[0].Rows.Count; j++)
                {
                    cost_detail detail = new cost_detail();
                    detail.id = (int)ds2.Tables[0].Rows[j][nameof(cost_detail.id)];
                    detail.cost_id = (int)ds2.Tables[0].Rows[j][nameof(cost_detail.cost_id)];
                    detail.cost_type = (string)ds2.Tables[0].Rows[j][nameof(cost_detail.cost_type)];
                    detail.money = (decimal)ds2.Tables[0].Rows[j][nameof(cost_detail.money)];
                    listDetail.Add(detail);
                }

                retDic.Add(main, listDetail);
            }
            return retDic;
        }
    }
}
