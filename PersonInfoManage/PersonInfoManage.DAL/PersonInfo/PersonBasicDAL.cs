using PersonInfoManage.DAL.Logs;
using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.PersonInfo
{
    /// <summary>
    /// 基本信息管理
    /// </summary>
    public class PersonBasicDAL : DALBase
    {
        private int res = 0; //用于返回受影响行

        /// <summary>
        /// 人员信息录入
        /// </summary>
        /// <param name="info">人员信息</param>
        /// <returns>插入条数</returns>
        public int Add(person_basic info)
        {
            try
            {
                // sql语句
                string sql = "insert into person_basic (name, former_name, gender, identity_number, birth_date, native_place, marry_status, job_status, income, temper, family, person_type_id, qq, address, phone, belong_place_id, nation, input_time, user_id, isdel) "
                    + "values(@name, @former_name, @gender, @identity_number, @birth_date, @native_place, @marry_status, @job_status, @income, @temper, @family, @person_type_id, @qq, @address, @phone, @belong_place_id, @nation, @input_time, @user_id, @isdel)";
                // 参数赋值
                SqlParameter name = new SqlParameter("@name", info.name);
                SqlParameter former_name = new SqlParameter("@former_name", info.former_name);
                SqlParameter gender = new SqlParameter("@gender", info.gender);
                SqlParameter identity_number = new SqlParameter("@identity_number", info.identity_number);
                SqlParameter birth_date = new SqlParameter("@birth_date", info.birth_date);
                SqlParameter native_place = new SqlParameter("@native_place", info.native_place);
                SqlParameter marry_status = new SqlParameter("@marry_status", info.marry_status);
                SqlParameter job_status = new SqlParameter("@job_status", info.job_status);
                SqlParameter income = new SqlParameter("@income", info.income);
                SqlParameter temper = new SqlParameter("@temper", info.temper);
                SqlParameter family = new SqlParameter("@family", info.family);
                SqlParameter person_type_id = new SqlParameter("@person_type_id", info.person_type_id);
                SqlParameter qq = new SqlParameter("@qq", info.qq);
                SqlParameter address = new SqlParameter("@address", info.address);
                SqlParameter phone = new SqlParameter("@phone", info.phone);
                SqlParameter belong_place_id = new SqlParameter("@belong_place_id", info.belong_place_id);
                SqlParameter nation = new SqlParameter("@nation", info.nation);
                SqlParameter input_time = new SqlParameter("@input_time", info.input_time);
                SqlParameter user_id = new SqlParameter("@user_id", info.user_id);
                SqlParameter isdel = new SqlParameter("@isdel", info.isdel);
                // 执行sql语句
                res = SqlHelper.ExecuteNonQuery(DALBase.ConStr, CommandType.Text, sql, name, former_name, gender, identity_number, birth_date, native_place, marry_status, job_status, income, temper, family, person_type_id, qq, address, phone, belong_place_id, nation, input_time, user_id, isdel);
                // 添加用户日志
                new LogUserDAL().Add(LogOperations.LogUser("人员信息录入"));
            }
            catch (Exception e)
            {
                //添加系统日志
                new LogSysDAL().Add(LogOperations.LogSys("人员信息录入：" + e.Message));
                //return 0;
            }
            // 返回执行成功条数
            return res;
        }

        /// <summary>
        /// 人员信息修改
        /// </summary>
        /// <param name="info">需要更新的人员信息</param>
        /// <returns>更新条数</returns>
        public int Update(person_basic info)
        {
            try
            {
                // sql语句
                string sql = "update person_basic set "
                + "name = @name, former_name = @former_name, gender = @gender, identity_number = @identity_number, birth_date = @birth_date, native_place = @native_place, marry_status = @marry_status, job_status = @job_status, income = @income, temper = @temper, family = @family, person_type_id = @person_type_id, qq = @qq, address = @address, phone = @phone, belong_place_id = @belong_place_id, nation = @nation, input_time = @input_time, user_id = @user_id, isdel = @isdel "
                + "where id = @id";
                // 参数赋值
                SqlParameter name = new SqlParameter("@name", info.name);
                SqlParameter former_name = new SqlParameter("@former_name", info.former_name);
                SqlParameter gender = new SqlParameter("@gender", info.gender);
                SqlParameter identity_number = new SqlParameter("@identity_number", info.identity_number);
                SqlParameter birth_date = new SqlParameter("@birth_date", info.birth_date);
                SqlParameter native_place = new SqlParameter("@native_place", info.native_place);
                SqlParameter marry_status = new SqlParameter("@marry_status", info.marry_status);
                SqlParameter job_status = new SqlParameter("@job_status", info.job_status);
                SqlParameter income = new SqlParameter("@income", info.income);
                SqlParameter temper = new SqlParameter("@temper", info.temper);
                SqlParameter family = new SqlParameter("@family", info.family);
                SqlParameter person_type_id = new SqlParameter("@person_type_id", info.person_type_id);
                SqlParameter qq = new SqlParameter("@qq", info.qq);
                SqlParameter address = new SqlParameter("@address", info.address);
                SqlParameter phone = new SqlParameter("@phone", info.phone);
                SqlParameter belong_place_id = new SqlParameter("@belong_place_id", info.belong_place_id);
                SqlParameter nation = new SqlParameter("@nation", info.nation);
                SqlParameter input_time = new SqlParameter("@input_time", info.input_time);
                SqlParameter user_id = new SqlParameter("@user_id", info.user_id);
                SqlParameter isdel = new SqlParameter("@isdel", info.isdel);
                SqlParameter id = new SqlParameter("@id", info.id);
                // 执行sql语句
                res = SqlHelper.ExecuteNonQuery(DALBase.ConStr, CommandType.Text, sql, name, former_name, gender, identity_number, birth_date, native_place, marry_status, job_status, income, temper, family, person_type_id, qq, address, phone, belong_place_id, nation, input_time, user_id, isdel, id);
                // 添加用户日志
                new LogUserDAL().Add(LogOperations.LogUser("人员信息修改"));
            }
            catch (Exception e)
            {
                // 添加系统日志
                new LogSysDAL().Add(LogOperations.LogSys("人员信息修改：" + e.Message));
                //return 0;
            }
            // 返回执行成功条数
            return res;
        }

        /// <summary>
        /// 人员信息移除
        /// </summary>
        /// <param name="id"></param>
        /// <returns>移除条数</returns>
        public int Remove(int id)
        {
            try
            {
                // sql语句
                string sql = "update person_basic set isdel = 1 where id = @id";
                // 参数赋值
                SqlParameter sp_id = new SqlParameter("@id", id);
                // 执行sql语句
                res = SqlHelper.ExecuteNonQuery(DALBase.ConStr, CommandType.Text, sql, sp_id);
                // 添加用户日志
                new LogUserDAL().Add(LogOperations.LogUser("人员信息移除"));
            }
            catch (Exception e)
            {
                // 添加系统日志
                new LogSysDAL().Add(LogOperations.LogSys("人员信息移除：" + e.Message));
                //return 0;
            }
            // 返回成功条数
            return res;
        }

        /// <summary>
        /// 人员信息删除
        /// </summary>
        /// <param name="id">人员信息id</param>
        /// <returns>删除条数</returns>
        public int Del(int id)
        {
            try
            {
                // sql语句
                string sql = "delete from person_basic where id = @id";
                // 参数赋值
                SqlParameter sp_id = new SqlParameter("@id", id);
                // 执行sql语句
                res = SqlHelper.ExecuteNonQuery(DALBase.ConStr, CommandType.Text, sql, sp_id);
                // 添加用户日志
                new LogUserDAL().Add(LogOperations.LogUser("人员信息删除"));
            }
            catch (Exception e)
            {
                // 添加系统日志
                new LogSysDAL().Add(LogOperations.LogSys("人员信息删除：" + e.Message));
                //return 0;
            }
            // 返回成功条数
            return res;
        }

        /// <summary>
        /// 人员信息检索
        /// </summary>
        /// <param name="info">查询条件</param>
        /// <returns>List类型</returns>
        public List<person_basic> Query(person_basic info)
        {
            // 用于返回的列表
            List<person_basic> list = new List<person_basic>();
            if (info.Equals(null)) return list;
            try
            {
                // sql语句
                string sql = "select * from person_basic where isdel = " + info.isdel + " and user_id = " + info.user_id;
                // 用于拼接查询
                List<SqlParameter> sqlPara = new List<SqlParameter>();
                // 判断参数
                if (info.id != 0) // id
                {
                    sql += " and id = " + info.id;
                }
                if (!string.IsNullOrEmpty(info.name)) // name
                {
                    sql += " and name like @name";
                    sqlPara.Add(new SqlParameter("@name", "%" + info.name + "%"));
                }
                if (!string.IsNullOrEmpty(info.identity_number)) // identity_number
                {
                    sql += " and identity_number like @identity_number";
                    sqlPara.Add(new SqlParameter("@identity_number", "%" + info.identity_number + "%"));
                }
                if (info.person_type_id > 0) // person_type_id
                {
                    sql += " and person_type_id = " + info.person_type_id;
                }
                if (!string.IsNullOrEmpty(info.native_place)) // native_place
                {
                    sql += " and native_place like @native_place";
                    sqlPara.Add(new SqlParameter("@native_place", "%" + info.native_place + "%"));
                }

                DataSet ds = new DataSet();
                // 执行sql语句并返回数据集
                ds = SqlHelper.ExecuteDataset(DALBase.ConStr, CommandType.Text, sql, sqlPara.ToArray());
                // 遍历表中的行
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    // 封装实体类
                    person_basic pb = new person_basic();
                    pb.id = int.Parse(dr[0].ToString());
                    pb.name = dr[1].ToString();
                    pb.former_name = dr[2].ToString();
                    pb.gender = dr[3].ToString();
                    pb.identity_number = dr[4].ToString();
                    pb.birth_date = DateTime.Parse(dr[5].ToString());
                    pb.native_place = dr[6].ToString();
                    pb.marry_status = bool.Parse(dr[7].ToString());
                    pb.job_status = dr[8].ToString();
                    if (!(dr[9] is DBNull))
                    {
                        pb.income = decimal.Parse(dr[9].ToString());
                    }
                    pb.temper = dr[10].ToString();
                    pb.family = dr[11].ToString();
                    pb.person_type_id = int.Parse(dr[12].ToString());
                    pb.qq = dr[13].ToString();
                    pb.address = dr[14].ToString();
                    pb.phone = dr[15].ToString();
                    pb.belong_place_id = int.Parse(dr[16].ToString());
                    pb.nation = dr[17].ToString();
                    pb.input_time = DateTime.Parse(dr[18].ToString());
                    pb.user_id = int.Parse(dr[19].ToString());
                    pb.isdel = int.Parse(dr[20].ToString());
                    list.Add(pb);
                }
                // 添加用户日志
                new LogUserDAL().Add(LogOperations.LogUser("人员信息检索"));
            }
            catch (Exception e)
            {
                // 添加系统日志
                new LogSysDAL().Add(LogOperations.LogSys("人员信息检索：" + e.Message));
            }
            // 返回列表
            return list;
        }
    }
}
