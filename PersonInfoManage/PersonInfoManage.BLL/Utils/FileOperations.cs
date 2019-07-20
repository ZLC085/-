using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Utils
{
    /// <summary>
    /// 文件与文件流相互转换
    /// </summary>
    public class FileOperations
    {
        /// <summary>
        /// 添加文件
        /// </summary>
        /// <param name="pesonId">人员编号</param>
        /// <param name="fullFileName">文件名</param>
        /// <returns>person_file</returns>
        public person_file SetFile(int pesonId, string fullFileName)
        {
            person_file file = new person_file
            {
                filename = GetFileName(fullFileName),
                file = ReadFile(fullFileName),
                filetype = GetFileType(fullFileName),
                person_id = pesonId,
                create_time = DateTime.Now,
                modify_time = DateTime.Now
            };

            return file;
        }

        /// <summary>
        /// 获取文件类型
        /// </summary>
        /// <param name="fullFileName">完整文件名（文件路径+文件名）</param>
        /// <returns>文件类型</returns>
        private string GetFileType(string fullFileName)
        {
            int index = fullFileName.LastIndexOf(".") + 1;
            string fileType = fullFileName.Substring(index);

            return fileType;
        }

        /// <summary>
        /// 获取文件名
        /// </summary>
        /// <param name="fullFileName">完整文件名（文件路径+文件名）</param>
        /// <returns>文件名</returns>
        private string GetFileName(string fullFileName)
        {
            int index = fullFileName.LastIndexOf(@"\") + 1;
            string fileName = fullFileName.Substring(index);

            return fileName;
        }

        /// <summary>
        /// 将本地文件转换为文件流
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns>文件流</returns>
        private byte[] ReadFile(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            byte[] fileBytes = new byte[fileStream.Length];
            fileStream.Read(fileBytes, 0, (int)fileStream.Length);
            fileStream.Close();

            return fileBytes;
        }

        /// <summary>
        /// 将数据库文件流写入本地，创建文件
        /// </summary>
        /// <param name="fileBytes">文件流</param>
        /// <param name="path">文件路径</param>
        /// <param name="fileName">文件名</param>
        /// <param name="fileType">文件类型</param>
        private void WriteFile(byte[] fileBytes, string path, string fileName, string fileType)
        {
            string filePath = path + fileName + fileType;
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            fs.Write(fileBytes, 0, fileBytes.Length);
            fs.Close();
        }
    }
}
