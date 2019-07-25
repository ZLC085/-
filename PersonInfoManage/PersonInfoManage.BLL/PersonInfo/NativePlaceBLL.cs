using PersonInfoManage.DAL.PersonInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.BLL.PersonInfo
{
    public class NativePlaceBLL
    {
        /// <summary>
        /// 查询省
        /// </summary>
        /// <returns>List类型</returns>
        public List<string> QueryProvince()
        {
            List<string> list;
            try
            {
                // 接收列表
                list = new NativePlaceDAL().Query(PlaceType.Province, null);
            }
            catch (Exception e)
            {
                throw e;
            }
            // 返回列表
            return list;
        }

        /// <summary>
        /// 查询市
        /// </summary>
        /// <param name="province">父级</param>
        /// <returns>List类型</returns>
        public List<string> QueryCity(string province)
        {
            List<string> list;
            try
            {
                // 接收列表
                list = new NativePlaceDAL().Query(PlaceType.City, province);
            }
            catch (Exception e)
            {
                throw e;
            }
            // 返回列表
            return list;
        }

        /// <summary>
        /// 查询县/区
        /// </summary>
        /// <param name="city">父级</param>
        /// <returns>List类型</returns>
        public List<string> QueryPlace(string city)
        {
            List<string> list;
            try
            {
                // 接收列表
                list = new NativePlaceDAL().Query(PlaceType.Place, city);
            }
            catch (Exception e)
            {
                throw e;
            }
            // 返回列表
            return list;
        }
    }

    
}
