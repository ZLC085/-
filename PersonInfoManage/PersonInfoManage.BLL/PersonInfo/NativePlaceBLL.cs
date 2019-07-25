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
        /// 三级查询
        /// </summary>
        /// <param name="type">选项类型</param>
        /// <param name="parent">父级类型</param>
        /// <returns>list类型</returns>
        public List<string> QueryProvince()
        {
            // 接收列表
            List<string> list = new NativePlaceDAL().Query(PlaceType.Province, null);
            // 返回列表
            return list;
        }


        public List<string> QueryCity(string province)
        {
            // 接收列表
            List<string> list = new NativePlaceDAL().Query(PlaceType.City, province);
            // 返回列表
            return list;
        }

        public List<string> QueryPlace(string city)
        {
            // 接收列表
            List<string> list = new NativePlaceDAL().Query(PlaceType.Place, city);
            // 返回列表
            return list;
        }
    }

    
}
