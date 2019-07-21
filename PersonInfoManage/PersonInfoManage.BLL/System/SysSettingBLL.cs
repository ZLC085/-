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
            PermDAL perm = new PermDAL();
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
            PermDAL perm = new PermDAL();
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
            PermDAL perm = new PermDAL();
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

    }
}
