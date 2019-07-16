using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.System
{
    public class SysSetting
    {
        /// <summary>
        /// 添加数据字典
        /// </summary>
        /// <param name="sysDict">数据字典</param>
        /// <returns></returns>
        public int InsertSysDict(sys_dict sysDict)
        {
            return new DBOperationsInsert<sys_dict, DBNull>().Insert(sysDict);
        }

        /// <summary>
        /// 根据id数据字典修改
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newValues">需要更新的值</param>
        /// <returns>修改条数</returns>
        public int UpdateSysDict(int id, Dictionary<string,object> newValues)
        {
            return new DBOperationsUpdate<sys_dict>().UpdateById(id, newValues);
        }

        /// <summary>
        /// 通过Id删除数据字典
        /// </summary>
        /// <param name="id">数据字典id</param>
        /// <returns>删除条数</returns>
        public int DeleteSysDictById(int id)
        {
            return new DBOperationsDelete<sys_dict, DBNull>().DeleteById(id);
        }

        /// <summary>
        /// 数据字典检索， 所有
        /// </summary>
        /// <returns>所有数据字典</returns>
        public List<sys_dict> SelectAllSysDict()
        {
            return new DBOperationsSelect<sys_dict>().SelectAll();
        }

        /// <summary>
        /// 通过输入条件检索数据字典
        /// </summary>
        /// <param name="conditions">输入条件</param>
        /// <returns>数据字典</returns>
        public List<sys_dict> SelectSysDictByConditions(Dictionary<string,object> conditions)
        {
            return new DBOperationsSelect<sys_dict>().SelectByConditions(conditions);
        }
    }
}
