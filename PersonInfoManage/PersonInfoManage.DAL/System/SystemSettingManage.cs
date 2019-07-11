using PersonInfoManage.IDAL.System;
using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.System
{
    public class SystemSettingManage : ISystemSettingManage
    {
        /// <summary>
        /// 添加数据字典
        /// </summary>
        /// <param name="dataDictName">数据字典</param>
        /// <returns></returns>
        public int InsertDataDic(data_dict_name dataDictName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 数据字典修改
        /// </summary>
        /// <param name="dataDictName">数据字典</param>
        /// <returns>修改条数</returns>
        public int UpdateDataDic(data_dict_name dataDictName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 数据字典删除，通过Id
        /// </summary>
        /// <param name="id">数据字典id</param>
        /// <returns>删除条数</returns>
        public int DeleteDataDicById(long id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 数据字典检索， 所有
        /// </summary>
        /// <returns>所有数据字典</returns>
        public List<data_dict_name> SelectAllDataDic()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 数据字典检索，通过id
        /// </summary>
        /// <param name="id">数据字典id</param>
        /// <returns></returns>
        public data_dict_name SelectDataDic(long id)
        {
            throw new NotImplementedException();
        }
    }
}
