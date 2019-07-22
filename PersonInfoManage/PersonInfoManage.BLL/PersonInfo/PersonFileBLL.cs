using PersonInfoManage.BLL.Utils;
using PersonInfoManage.DAL.PersonInfo;
using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.BLL.PersonInfo
{
    public class PersonFileBLL
    {
        /// <summary>
        /// 文件添加
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public Result Add(person_file file)
        {
            Result r = new Result();
            if (new PersonFileDAL().Add(file) > 0)
            {
                r.Code = RES.OK;
                r.Message = "添加成功！";
            }
            else
            {
                r.Code = RES.ERROR;
                r.Message = "添加失败！";
            }
            return r;
        }


        /// <summary>
        /// 文件修改
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public Result Update(string filename, int id)
        {
            Result r = new Result();
            if (new PersonFileDAL().Update(filename, id) > 0)
            {
                r.Code = RES.OK;
                r.Message = "修改成功！";
            }
            else
            {
                r.Code = RES.ERROR;
                r.Message = "修改失败！";
            }
            return r;
        }


        /// <summary>
        /// 文件删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Result Del(int id)
        {
            Result r = new Result();
            if (new PersonFileDAL().Del(id) > 0)
            {
                r.Code = RES.OK;
                r.Message = "删除成功！";
            }
            else
            {
                r.Code = RES.ERROR;
                r.Message = "删除失败！";
            }
            return r;
        }



        /// <summary>
        /// 文件查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public person_file GetById(int id)
        {
            person_file pf = new PersonFileDAL().GetById(id);
            return pf;
        }
    }
}
