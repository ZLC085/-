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

        /// <summary>
        /// 通过personId查询问价
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        public List<person_file> GetByPersonId(int personId)
        {
            return new PersonFileDAL().GetByPersonId(personId);
        }

        /// <summary>
        /// 文件导出
        /// </summary>
        /// <param name="id">文件id</param>
        /// <param name="path">导出路径</param>
        /// <returns>导出Result</returns>
        public Result OutFile(int id,string path)
        {
            Result result = new Result();
            person_file pf = new PersonFileDAL().GetById(id);

            FileOperations operations = new FileOperations();
            bool flag = operations.WriteFile(pf.file, path, pf.filename, pf.filetype);
            if (flag)
            {
                result.Code = RES.OK;
                result.Message = "文件成功导出到：" + path + "！";
            }
            else
            {
                result.Code = RES.ERROR;
                result.Message = "文件导出失败！";
            }

            return result;
        }
    }
}
