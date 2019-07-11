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
    public class RelatedFiles : IRelatedFiles
    {
        /// <summary>
        /// 文件添加
        /// </summary>
        /// <param name="file">文件信息</param>
        /// <returns>添加条数</returns>
        public int InsertFile(related_files file)
        {
            return 0;
        }

        /// <summary>
        /// 文件修改
        /// </summary>
        /// <param name="fileId">文件编号</param>
        /// <param name="newFileName">新文件名</param>
        /// <returns>修改条数</returns>
        public int UpdateFile(long fileId, string newFileName)
        {
            return 0;
        }

        /// <summary>
        /// 文件删除
        /// </summary>
        /// <param name="fileId">文件编号</param>
        /// <returns>删除条数</returns>
        public int DeleteFile(long fileId)
        {
            return 0;
        }

        /// <summary>
        /// 文件查询，通过人员编号
        /// </summary>
        /// <param name="personId">人员编号</param>
        /// <returns>通过人员编号查询到的文件信息</returns>
        public List<related_files> SelectFilesByPersonId(long personId)
        {
            return null;
        }

        /// <summary>
        /// 文件查询，通过文件编号
        /// </summary>
        /// <param name="fileId">文件编号</param>
        /// <returns>通过文件编号查询到的文件信息</returns>
        public related_files SelectFileByFileId(long fileId)
        {
            return null;
        }
    }
}
