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
    public class CostApplyDAL:DALBase
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
            //更新费用金额信息和状态
            sqlArray[0]= "update cost_main " +
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
        public int Del(int id)
        {
            //构造sql语句数组
            string[] sqlArray = new string[2];
            //先删除费用类型表记录
            sqlArray[0] = "delete from cost_detail where "+nameof(cost_detail.cost_id)+"="+id;
            //再删除费用单表记录
            sqlArray[1] = "delete from cost_main where id='" + id + "'";
            //调用方法以事务方式执行sql数组里的语句
            return sqlArrayToTran.doTran(sqlArray);            
        }        
        /// <summary>
        /// 根据费用单id查询费用详情列表
        /// </summary>
        /// <param name="costId">费用单id</param>
        /// <returns>指定费用单id的费用详情列表</returns>
        public List<cost_detail> QueryDetail(int costId)
        {
            List<cost_detail> listDetail = new List<cost_detail>();
            string sql = "select * from cost_detail where cost_id=" + costId;
            DataTable dataTable = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql).Tables[0];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                cost_detail detail = new cost_detail
                {
                    id = (int)row["id"],
                    cost_id = (int)row["cost_id"],
                    cost_type = (int)row["cost_type"],
                    money = (decimal)row["money"]
                };
                listDetail.Add(detail);
            }
            return listDetail;
        }        
        /// <summary>
        /// 根据组合条件查询费用单
        /// </summary>
        /// <param name="consitions">条件键值对key: "id", "applicant", "status", "start_time", "end_time"</param>
        /// <returns>费用单对象与费用详情对象列表构成的词典键值对</returns>
        public List<cost_main> QueryMain(Dictionary<string, object> conditions)
        {
            //对参数进行合法性检验，获取合法的查询参数列表
            string[] keys = new string[] {"id", "applicant", "status", "start_time", "end_time" };            
            List<string> keyList = new List<string>();            
            foreach (string key in conditions.Keys)
            {   
                if (keys.Contains(key))
                    keyList.Add(key);

            }
            //根据参数列表，拼接sql语句
            string sql = "select * from cost_main ";
            if (keyList.Count != 0)
            {
                sql += "where ";
                foreach (string key in keyList)
                {   
                    //对第一个key特殊处理
                    if (!key.Equals(keyList.First()))
                    {
                        sql += "and ";
                    }
                    //对比较特别的关键字做不同的处理方式
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
            //执行查询获取数据并封装返回
            List<cost_main> listMain = new List<cost_main>();
            DataTable dataTable = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql).Tables[0];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                cost_main main = new cost_main
                {
                    id = (int)row["id"],
                    applicant = (string)row["applicant"],
                    approver = (string)row["approver"],
                    apply_time = (DateTime)row["apply_time"],
                    approval_time = (DateTime)(row["approval_time"] == DBNull.Value ? null : row["approval_time"]),
                    apply_money = (decimal)row["apply_money"],
                    approval_money = (decimal)row["approval_money"],
                    status = (byte)row["status"],
                    remark = (string)row["remark"]
                };
                listMain.Add(main);
            }
            return listMain;
        }
        /// <summary>
        /// 获取数据字典中的费用类别
        /// </summary>
        /// <returns>费用类别的列表</returns>
        public List<string> GetCostTypes()
        {
            List<string> list = new List<string>();
            string sql = "select * from sys_dict where dict_name=N'费用类别'";
            DataTable db = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql).Tables[0];
            for(int i = 0; i < db.Rows.Count; i++)
            {
                DataRow row = db.Rows[i];
                list.Add((string)row["category_name"]);
            }
            return list;
        }
    }
}
