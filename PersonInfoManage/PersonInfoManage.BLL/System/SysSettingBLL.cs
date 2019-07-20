using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonInfoManage.DAL.System;
using PersonInfoManage.Model;

namespace PersonInfoManage.BLL.System
{
    class SysSettingBLL
    {
        /// <summary>
        /// 添加数据字典
        /// </summary>
        /// <param name="sysDict"></param>
        /// <returns>成功与否</returns>
        public int Add(sys_dict SysDict)          
      {
            SysSettingDAL set = new SysSettingDAL();
            return set.Add(SysDict);               
        }
        /// <summary>
        /// 删除数据字典
        /// </summary>
        /// <param name="sysDict"></param>
        /// <returns>成功与否</returns>
        public int Del(int id)
        {
            SysSettingDAL set = new SysSettingDAL();
            return set.Del(id);
        }

        /// <summary>
        /// 更新数据字典
        /// </summary>
        /// <param name="sysDict"></param>
        /// <returns></returns>
        public int Update(sys_dict SysDict)
        {
            SysSettingDAL set = new SysSettingDAL();
            return set.Update(SysDict);            
        }

        /// <summary>
        /// 查询数据字典
        /// </summary>
        /// <returns>数据字典信息</returns>
        public List<sys_dict> SeleteAll()
        {
            SysSettingDAL set = new SysSettingDAL();
            return set.SelectAll();
        }


    }
}
