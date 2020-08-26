using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonInfoManage.DAL.System;
using PersonInfoManage.Model;
using PersonInfoManage.BLL.Utils;

namespace PersonInfoManage.BLL.System
{
    public class SysSettingBLL
    {
        /// <summary>
        /// 添加数据字典
        /// </summary>
        /// <param name="sysDict"></param>
        /// <returns>成功与否</returns>
        public Result Add(sys_dict SysDict)
        {
            SysSettingDAL set = new SysSettingDAL();
            Result res = new Result();         
            try
            {
                if (set.Add(SysDict) == 0)
                {
                    res.Code = RES.ERROR;
                    res.Message = "添加失败！";
                    return res;
                }
                else
                {
                    res.Code = RES.OK;
                    res.Message = "添加成功！";
                    return res;
                }
            }
            catch
            {
                res.Code = RES.ERROR;
                res.Message = "添加失败！";
                return res;
            }
        }


        /// <summary>
        /// 删除数据字典
        /// </summary>
        /// <param name="sysDict"></param>
        /// <returns>成功与否</returns>
        public Result Del(int id)
        {
            SysSettingDAL set = new SysSettingDAL();
            Result res = new Result();      
            try
            {
                if (set.Del(id) == 0)
                {
                    res.Code = RES.ERROR;
                    res.Message = "删除失败！";
                    return res;
                }
                else
                {
                    res.Code = RES.OK;
                    res.Message = "删除成功！";
                    return res;
                }
            }
            catch
            {
                res.Code = RES.ERROR;
                res.Message = "删除失败！";
                return res;
            }
        }

        /// <summary>
        /// 更新数据字典
        /// </summary>
        /// <param name="sysDict"></param>
        /// <returns></returns>
        public Result Update(sys_dict SysDict)
        {
            SysSettingDAL set = new SysSettingDAL();
            Result res = new Result();
            try
            {
                if (set.Update(SysDict) == 0)
                {
                    res.Code = RES.ERROR;
                    res.Message = "修改失败！";
                    return res;
                }
                else
                {
                    res.Code = RES.OK;
                    res.Message = "修改成功！";
                    return res;
                }
            }
            catch
            {
                res.Code = RES.ERROR;
                res.Message = "修改失败！";
                return res;
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
        public List<string> SelectAllDictName()
        {
            SysSettingDAL set = new SysSettingDAL();
            return set.SelectAllDictName();

        }


        /// <summary>
        /// 根据数据字典名字查分类所有
        /// </summary>
        /// <param name="dictName"></param>
        /// <returns></returns>
        public List<sys_dict> SelectByDictName(sys_dict_type dictName)
        {
            SysSettingDAL set = new SysSettingDAL();
            return set.SelectByDictName(dictName);
        }

        /// <summary>
        /// 根据id查询所有
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<sys_dict> Select(int id)
        {
            SysSettingDAL set = new SysSettingDAL();
            return set.Select(id);

        }
        /// <summary>
        /// 删除多个数据字典
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public Result  DelAll(List<int> list)
        {      
            SysSettingDAL set = new SysSettingDAL();
            Result res = new Result();
            try
            {
                foreach (int a in list)
                {
                    set.Del(a);
                 
                }
                res.Code = RES.OK;
                res.Message = "删除成功！";
                return res;
            }
            catch
            {
                res.Code = RES.ERROR;
                res.Message = "删除失败！";
                return res;
            }
            
        }
        }
}
