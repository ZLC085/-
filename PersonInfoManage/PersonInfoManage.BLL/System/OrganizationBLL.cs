using PersonInfoManage.BLL.Utils;
using PersonInfoManage.DAL.System;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.BLL
{
    public class OrganizationBLL
    {
        /// <summary>
        /// 添加组织机构
        /// </summary>
        /// <param name="org"></param>
        /// <returns>执行结果</returns>
        public Result Add(sys_org org)
        {
            Result res = new Result();
            OrganizationDAL orgDAL = new OrganizationDAL();
            try
            {
                if (orgDAL.Add(org) == 0)
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
        /// 修改用户组
        /// </summary>
        /// <param name="org"></param>
        /// <returns>执行结果</returns>
        public Result Update(sys_org org)
        {
            Result res = new Result();
            OrganizationDAL orgDAL = new OrganizationDAL();
            try
            {
                if (orgDAL.Update(org) == 0)
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
        /// 删除组织机构
        /// </summary>
        /// <param name="id"></param>
        /// <returns>执行结果</returns>
        public Result Del(int id)
        {
            Result res = new Result();
            OrganizationDAL orgDAL = new OrganizationDAL();
            try
            {
                List<sys_org> org = orgDAL.SelectByparentid(id);
                foreach (var item in org)
                {
                    Del(item.id);
                }
                if (orgDAL.Del(id) == 1)
                {
                    res.Code = RES.OK;
                    res.Message = "删除成功！";
                    return res;
                }
                else
                {
                    res.Code = RES.ERROR;
                    res.Message = "删除失败！";
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
        /// 通过parent_id查询组织机构
        /// </summary>
        /// <param name="pid"></param>
        /// <returns>List<sys_org></returns>
        public List<sys_org> SelectByparentid(int pid)
        {
            OrganizationDAL orgDAL = new OrganizationDAL();
            return orgDAL.SelectByparentid(pid);
        }

        /// <summary>
        /// 查询组织机构
        /// </summary>
        /// <returns>List</returns>
        public List<sys_org> SelectAll(string orgname)
        {
            OrganizationDAL orgDAL = new OrganizationDAL();
            return orgDAL.SelectByName(orgname);
        }
    }
}
