using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.PersonInfo
{
    public class NativePlaceDAL
    {
        /// <summary>
        /// 三级查询
        /// </summary>
        /// <param name="type">选项类型</param>
        /// <param name="parent">父级类型</param>
        /// <returns>list类型</returns>
        public List<string> Query(PlaceType type, string parent)
        {
            // 用于返回的列表
            List<string> list = new List<string>();
            try
            {
                // sql语句
                string sql = "";
                if (type.Equals(PlaceType.Province))
                {
                    sql = "select province from native_place group by province order by province collate Chinese_PRC_CS_AS_KS_WS";
                }
                else if (type.Equals(PlaceType.City) && !string.IsNullOrEmpty(parent))
                {
                    sql = "select city from native_place where province = N'" + parent + "' group by city order by city collate Chinese_PRC_CS_AS_KS_WS";
                }
                else if (type.Equals(PlaceType.Place) && !string.IsNullOrEmpty(parent))
                {
                    sql = "select place from native_place where city = N'" + parent + "' group by place  order by place collate Chinese_PRC_CS_AS_KS_WS";
                }
                else
                {
                    // 返回空列表
                    return list;
                }

                DataSet ds = new DataSet();
                // 执行sql语句并返回数据集
                ds = SqlHelper.ExecuteDataset(DALBase.ConStr, CommandType.Text, sql);
                // 遍历表中的行
                string str = "";
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    // 封装
                    str = dr[0].ToString();
                    list.Add(str);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            // 返回列表
            return list;
        }
    }

    public enum PlaceType
    {
        Province, City, Place
    }
}
