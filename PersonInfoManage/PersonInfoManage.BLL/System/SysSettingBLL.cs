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
        public int Add(sys_dict sysDict)          
      {
            SysSettingDAL set = new SysSettingDAL();
            if (set.Add(sysDict) == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
               
        }
        /// <summary>
        /// 删除数据字典
        /// </summary>
        /// <param name="sysDict"></param>
        /// <returns>成功与否</returns>
        public int Del(int id)
        {
            SysSettingDAL set = new SysSettingDAL();
           
                if (set.Del(id) == 0)
                {
                    return 0;
                }
            else
            {
                return 1;
            }
                
        
        }

       /// <summary>
       /// 更新数据字典
       /// </summary>
       /// <param name="sysDict"></param>
       /// <returns></returns>
        public int Update(sys_dict sysDict)
        {
            SysSettingDAL set = new SysSettingDAL();
            if (set.Update(sysDict) == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public List<sys_dict> SeleteAll()
        {
            SysSettingDAL set = new SysSettingDAL();
            return set.SelectAll();
        }


    }
}
