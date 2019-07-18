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
    public class PersonFile:DALBase
    {
        /// <summary>
        /// 文件添加
        /// </summary>
        /// <param name="file">文件信息</param>
        /// <returns>添加条数</returns>
        public int InsertPersonFile(person_file file)
        {
            int res = 0;
            String sql = "insert into person_file(filetype,person_basic) values(@p1,@p2)";
            SqlParameter sqlParameter = new SqlParameter("@p1", file.filetype);
            SqlParameter sqlParameter1 = new SqlParameter("@p2", file.person_basic);

            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter, sqlParameter1);

            return res;
            //return new DBOperationsInsert<person_file, DBNull>().Insert(file);
        }

        /// <summary>
        /// 文件修改
        /// </summary>
        /// <param name="fileId">文件编号</param>
        /// <param name="newFileName">新文件名</param>
        /// <returns>修改条数</returns>
        public int UpdatePersonFile(int fileId, string newFileName)
        {
            int res = 0;
            String sql = "update PersonFile set filename = @newFileName" + "where id = @id";
            SqlParameter sqlParameter = new SqlParameter("@newFileName", fileId);

            res = SqlHelper.ExecuteNonQuery(ConStr, CommandType.Text, sql, sqlParameter);

            return res;
            //Dictionary<string, object> newValues = new Dictionary<string, object>
            //{
            //    { nameof(person_file.filename), newFileName }
            //};

            //return new DBOperationsUpdate<person_file>().UpdateById(fileId, newValues);
        }

        /// <summary>
        /// 文件删除
        /// </summary>
        /// <param name="fileId">文件编号</param>
        /// <returns>删除条数</returns>
        public int DeletePersonFile(int fileId)
        {
            int res;
            String sql = "delete from person_file where id = @id";
            SqlParameter sqlParameter = new SqlParameter("@id", fileId);

            res = SqlHelper.ExecuteNonQuery(DALBase.ConStr, CommandType.Text, sql, sqlParameter);

            return res;
            //return new DBOperationsDelete<person_file, DBNull>().DeleteById(fileId);
        }

        /// <summary>
        /// 文件查询
        /// </summary>
        /// <param name="conditions">条件</param>
        /// <returns>通过输入条件查询到的文件信息</returns>
        //public List<person_file> SelectPersonFilesByconditions(Dictionary<string,object> conditions)
        //{

        //    return new DBOperationsSelect<person_file>().SelectByConditions(conditions);
        //}


        /// <summary>
        /// 文件查询
        /// </summary>
        /// <param name="conditions"></param>id</param>
        /// <returns>通过输入id查询到的文件信息</returns>
        public Dictionary<person_basic, List<person_file>> GetById(int id)
        {
            Dictionary<person_basic, List<person_file>> files = new Dictionary<person_basic, List<person_file>>();
            person_basic basic = new person_basic();
            List<person_file> listFile = new List<person_file>();

            String sql1 = "select * from person_basic where id = '" + id + "'";
            String sql2 = "select * from person_file where person_id = '" + id + "'";

            DataSet ds = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql1);

            basic.id = int.Parse((string)ds.Tables[0].Rows[0][nameof(person_basic.id)]);
            basic.name = ((string)ds.Tables[0].Rows[0][nameof(person_basic.name)]);
            basic.former_name = ((string)ds.Tables[0].Rows[0][nameof(person_basic.former_name)]);
            basic.gender = ((string)ds.Tables[0].Rows[0][nameof(person_basic.gender)]);
            basic.identity_number = ((string)ds.Tables[0].Rows[0][nameof(person_basic.identity_number)]);
            basic.birth_date = ((DateTime)ds.Tables[0].Rows[0][nameof(person_basic.birth_date)]);
            basic.city = ((string)ds.Tables[0].Rows[0][nameof(person_basic.city)]);
            basic.province = ((string)ds.Tables[0].Rows[0][nameof(person_basic.province)]);
            basic.marry_status = ((bool)ds.Tables[0].Rows[0][nameof(person_basic.marry_status)]);
            basic.job_status = ((string)ds.Tables[0].Rows[0][nameof(person_basic.job_status)]);
            basic.income = ((decimal)ds.Tables[0].Rows[0][nameof(person_basic.income)]);
            basic.temper = ((string)ds.Tables[0].Rows[0][nameof(person_basic.temper)]);
            basic.family = ((string)ds.Tables[0].Rows[0][nameof(person_basic.family)]);
            basic.person_type = ((string)ds.Tables[0].Rows[0][nameof(person_basic.person_type)]);
            basic.qq = ((string)ds.Tables[0].Rows[0][nameof(person_basic.qq)]);
            basic.address = ((string)ds.Tables[0].Rows[0][nameof(person_basic.address)]);
            basic.phone = ((string)ds.Tables[0].Rows[0][nameof(person_basic.phone)]);
            basic.belong_place = ((string)ds.Tables[0].Rows[0][nameof(person_basic.belong_place)]);
            basic.nation = ((string)ds.Tables[0].Rows[0][nameof(person_basic.nation)]);
            basic.input_time = ((DateTime)ds.Tables[0].Rows[0][nameof(person_basic.input_time)]);
            basic.user_id = int.Parse((string)ds.Tables[0].Rows[0][nameof(person_basic.user_id)]);
            basic.isdel = int.Parse((string)ds.Tables[0].Rows[0][nameof(person_basic.isdel)]);
            

            DataSet ds1 = SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql2);
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                person_file file = new person_file();
                file.id = int.Parse((string)ds.Tables[0].Rows[i][nameof(person_file.id)]);
                file.person_id = int.Parse((string)ds.Tables[0].Rows[i][nameof(person_file.person_id)]);
                file.filename = ((string)ds.Tables[0].Rows[i][nameof(person_file.filename)]);
                file.file = ((byte[])ds.Tables[0].Rows[i][nameof(person_file.file)]);
                file.filetype = ((string)ds.Tables[0].Rows[i][nameof(person_file.filetype)]);
                file.create_time = ((DateTime)ds.Tables[0].Rows[i][nameof(person_file.create_time)]);
                file.modify_time = ((DateTime)ds.Tables[0].Rows[i][nameof(person_file.modify_time)]);
                file.person_basic = ((person_basic)ds.Tables[0].Rows[i][nameof(person_file.person_basic)]);
                listFile.Add(file);
            }
            files.Add(basic, listFile);
            return files;
        }
        
    }
}
