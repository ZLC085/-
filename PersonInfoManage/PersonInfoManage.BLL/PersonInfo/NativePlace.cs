using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.BLL.PersonInfo
{
    public class NativePlace
    {
        /// <summary>
        /// 三级查询
        /// </summary>
        /// <param name="type">选项类型</param>
        /// <param name="parent">父级类型</param>
        /// <returns>list类型</returns>
        public List<string> Query(string type, string parent)
        {
            // 接收列表
            List<string> list = new DAL.PersonInfo.NativePlaceDAL().Query(type, parent);
            // 返回列表
            return list;
        }
    }
}
