using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.IDAL.System
{
    public interface ISystemSettingManage
    {
        /// <summary>
        /// 添加数据字典
        /// </summary>
        /// <param name="dataDictName">数据字典</param>
        /// <returns></returns>
        int InsertDataDic(data_dict_name dataDictName);

        /// <summary>
        /// 数据字典修改
        /// </summary>
        /// <param name="dataDictName">数据字典</param>
        /// <returns>修改条数</returns>
        int UpdateDataDic(data_dict_name dataDictName);

        /// <summary>
        /// 数据字典删除，通过Id
        /// </summary>
        /// <param name="id">数据字典id</param>
        /// <returns>删除条数</returns>
        int DeleteDataDicById(long id);

        /// <summary>
        /// 数据字典检索， 所有
        /// </summary>
        /// <returns>所有数据字典</returns>
        List<data_dict_name> SelectAllDataDic();

        /// <summary>
        /// 数据字典检索，通过id
        /// </summary>
        /// <param name="id">数据字典id</param>
        /// <returns></returns>
        data_dict_name SelectDataDic(long id);
    }
}
