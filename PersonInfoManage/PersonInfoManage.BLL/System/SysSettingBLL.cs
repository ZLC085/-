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
        public bool Add(sys_dict SysDict)          
      {
            SysSettingDAL set = new SysSettingDAL();
            try
            {
                set.Add(SysDict);
                return true;
            }
            catch
            {
                return false;
            }                         
        }
        /// <summary>
        /// 删除数据字典
        /// </summary>
        /// <param name="sysDict"></param>
        /// <returns>成功与否</returns>
        public bool Del(int id)
        {
            SysSettingDAL set = new SysSettingDAL();
            try
            {
                set.Del(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 更新数据字典
        /// </summary>
        /// <param name="sysDict"></param>
        /// <returns></returns>
        public bool Update(sys_dict SysDict)
        {
            SysSettingDAL set = new SysSettingDAL();
            try
            {
                set.Update(SysDict);
                return true;
            }
            catch
            {
                return false;
            }           
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
