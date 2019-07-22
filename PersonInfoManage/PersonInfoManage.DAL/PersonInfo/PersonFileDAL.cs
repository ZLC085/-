using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.PersonInfo
{
    /// <summary>
    /// 相关文件管理
    /// </summary>
    public class PersonFileDAL : DALBase
    {
        /// <summary>
        /// 文件添加
        /// </summary>
        /// <param name="file">文件信息</param>
        /// <returns>添加条数</returns>
        public int Add(person_file file)
        {
            int res = 0;
            String sql = "insert into person_file(person_id,[file],filename,filetype,create_time,modify_time) values(@p1,@p2,@p3,@p4,@p5,@p6)";
            SqlParameter sqlParameter1 = new SqlParameter("@p1", file.person_id);
            SqlParameter sqlParameter2 = new SqlParameter("@p2", file.file);
            SqlParameter sqlParameter3 = new SqlParameter("@p3", file.filename);
            SqlParameter sqlParameter4 = new SqlParameter("@p4", file.filetype);
            SqlParameter sqlParameter5 = new SqlParameter("@p5", file.create_time);
            SqlParameter sqlParameter6 = new SqlParameter("@p6", file.modify_time);


            try
            {
                res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, sqlParameter5, sqlParameter6);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return res;
        }

        /// <summary>
        /// 文件修改
        /// </summary>
        /// <param name="fileId">文件编号</param>
        /// <param name="newFileName">新文件名</param>
        /// <returns>修改条数</returns>
        public int Update(string filename, int id)
        {
            int res = 0;
            string sql = "update person_file set filename ='" + filename + "'  where id = '" + id + "'";
            try
            {
                res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return res;
        }

        /// <summary>
        /// 文件删除
        /// </summary>
        /// <param name="fileId">文件编号</param>
        /// <returns>删除条数</returns>
        public int Del(int id)
        {
            int res = 0;
            string sql = "delete from person_file where id = '" + id + "'";

            try
            {
                res = SqlHelper.ExecuteNonQuery(DALBase.ConStr, CommandType.Text, sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return res;
        }

        /// <summary>
        /// 文件查询
        /// </summary>
        /// <param name="conditions"></param>id</param>
        /// <returns>通过输入id查询到的文件信息</returns>
        public person_file GetById(int id)
        {
            string sql = "select * from person_file where id = '" + id + "'";
            person_file file = new person_file();
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql);

                file.id = (int)ds.Tables[0].Rows[0][nameof(person_file.id)];
                file.person_id = (int)ds.Tables[0].Rows[0][nameof(person_file.person_id)];
                file.filename = (string)ds.Tables[0].Rows[0][nameof(person_file.filename)];
                file.file = (byte[])ds.Tables[0].Rows[0][nameof(person_file.file)];
                file.filetype = (string)ds.Tables[0].Rows[0][nameof(person_file.filetype)];
                file.create_time = (DateTime)ds.Tables[0].Rows[0][nameof(person_file.create_time)];
                file.modify_time = (DateTime)ds.Tables[0].Rows[0][nameof(person_file.modify_time)];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return file;
        }
        /// <summary>
        /// 通过personId查询问价
        /// </summary>
        /// <param name="personId">personId</param>
        /// <returns>文件信息</returns>
        public List<person_file> GetByPersonId(int personId)
        {
            List<person_file> personFileList = new List<person_file>();
            string sql = "select id,person_id,filename,filename,create_time,modify_time from person_file where person_id=" + personId;

            try
            {
                DataTable dataTable = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql).Tables[0];

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    person_file personFile = new person_file
                    {
                        id = (int)row["id"],
                        person_id = (int)row["person_id"],
                        filename = (string)row["filename"],
                        filetype = (string)row["filename"],
                        create_time = (DateTime)row["create_time"],
                        modify_time = (DateTime)row["modify_time"]
                    };
                    personFileList.Add(personFile);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return personFileList;
        }
    }
}
