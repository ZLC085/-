using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.PersonInfo
{
    /// <summary>
    /// 相关文件管理
    /// </summary>
    public class PersonFile
    {
        /// <summary>
        /// 文件添加
        /// </summary>
        /// <param name="file">文件信息</param>
        /// <returns>添加条数</returns>
        public int InsertPersonFile(person_file file)
        {
            return new DBOperationsInsert<person_file, DBNull>().Insert(file);
        }

        /// <summary>
        /// 文件修改
        /// </summary>
        /// <param name="fileId">文件编号</param>
        /// <param name="newFileName">新文件名</param>
        /// <returns>修改条数</returns>
        public int UpdatePersonFile(int fileId, string newFileName)
        {
            Dictionary<string, object> newValues = new Dictionary<string, object>
            {
                { nameof(person_file.filename), newFileName }
            };

            return new DBOperationsUpdate<person_file>().UpdateById(fileId, newValues);
        }

        /// <summary>
        /// 文件删除
        /// </summary>
        /// <param name="fileId">文件编号</param>
        /// <returns>删除条数</returns>
        public int DeletePersonFile(int fileId)
        {
            return new DBOperationsDelete<person_file, DBNull>().DeleteById(fileId);
        }

        /// <summary>
        /// 文件查询
        /// </summary>
        /// <param name="conditions">条件</param>
        /// <returns>通过输入条件查询到的文件信息</returns>
        public List<person_file> SelectPersonFilesByconditions(Dictionary<string,object> conditions)
        {
            return new DBOperationsSelect<person_file>().SelectByConditions(conditions);
        }
    }
}
