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
        private string conStr = "SERVER=47.106.235.197;DATABASE=person_info_manage;UID=SA;PASSWORD=qwer-123456;";
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
                string sql = "insert into person_basic (name, former_name, gender, identity_number, birth_date, native_place, marry_status, job_status, income, temper, family, person_type, person_type_name, qq, address, phone, belong_place, nation, input_time, user_id, isdel) "
                    + "values(@name, @former_name, @gender, @identity_number, @birth_date, @native_place, @marry_status, @job_status, @income, @temper, @family, @person_type, @person_type_name, @qq, @address, @phone, @belong_place, @nation, @input_time, @user_id, @isdel)";
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
                SqlParameter person_type = new SqlParameter("@person_type", info.person_type);
                SqlParameter person_type_name = new SqlParameter("@person_type_name", info.person_type_name);
                SqlParameter qq = new SqlParameter("@qq", info.qq);
                SqlParameter address = new SqlParameter("@address", info.address);
                SqlParameter phone = new SqlParameter("@phone", info.phone);
                SqlParameter belong_place = new SqlParameter("@belong_place", info.belong_place);
                SqlParameter nation = new SqlParameter("@nation", info.nation);
                SqlParameter input_time = new SqlParameter("@input_time", info.input_time);
                SqlParameter user_id = new SqlParameter("@user_id", info.user_id);
                SqlParameter isdel = new SqlParameter("@isdel", info.isdel);
                // 执行sql语句
                res = SqlHelper.ExecuteNonQuery(conStr, CommandType.Text, sql, name, former_name, gender, identity_number, birth_date, native_place, marry_status, job_status, income, temper, family, person_type, person_type_name, qq, address, phone, belong_place, nation, input_time, user_id, isdel);
                Console.WriteLine("执行成功！");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
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
                + "name = @name, former_name = @former_name, gender = @gender, identity_number = @identity_number, birth_date = @birth_date, native_place = @native_place, marry_status = @marry_status, job_status = @job_status, income = @income, temper = @temper, family = @family, person_type = @person_type, person_type_name = @person_type_name, qq = @qq, address = @address, phone = @phone, belong_place = @belong_place, nation = @nation, input_time = @input_time, user_id = @user_id, isdel = @isdel "
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
                SqlParameter person_type = new SqlParameter("@person_type", info.person_type);
                SqlParameter person_type_name = new SqlParameter("@person_type_name", info.person_type_name);
                SqlParameter qq = new SqlParameter("@qq", info.qq);
                SqlParameter address = new SqlParameter("@address", info.address);
                SqlParameter phone = new SqlParameter("@phone", info.phone);
                SqlParameter belong_place = new SqlParameter("@belong_place", info.belong_place);
                SqlParameter nation = new SqlParameter("@nation", info.nation);
                SqlParameter input_time = new SqlParameter("@input_time", info.input_time);
                SqlParameter user_id = new SqlParameter("@user_id", info.user_id);
                SqlParameter isdel = new SqlParameter("@isdel", info.isdel);
                SqlParameter id = new SqlParameter("@id", info.id);
                // 执行sql语句
                res = SqlHelper.ExecuteNonQuery(conStr, CommandType.Text, sql, name, former_name, gender, identity_number, birth_date, native_place, marry_status, job_status, income, temper, family, person_type, person_type_name, qq, address, phone, belong_place, nation, input_time, user_id, isdel, id);
                Console.WriteLine("执行成功！");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
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
                string sql = "update person_basic set isdel = 0 where id = @id";
                // 参数赋值
                SqlParameter sp_id = new SqlParameter("@id", id);
                // 执行sql语句
                res = SqlHelper.ExecuteNonQuery(conStr, CommandType.Text, sql, sp_id);
            }
            catch (Exception)
            {
                return 0;
            }
            //返回成功条数
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
                res = SqlHelper.ExecuteNonQuery(conStr, CommandType.Text, sql, sp_id);
            }
            catch (Exception)
            {
                return 0;
            }
            //返回成功条数
            return res;
        }

        /// <summary>
        /// 人员信息检索
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public List<person_basic> Query(person_basic info)
        {
            // 用于返回的列表
            List<person_basic> list = new List<person_basic>();
            try
            {
                // sql语句
                string sql = "select * from person_basic where isdel = 1 ";
                // 用于拼接查询
                List<SqlParameter> sqlPara = new List<SqlParameter>();
                // 判断参数
                if (info.id != 0)
                {
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
                    if (!string.IsNullOrEmpty(info.person_type_name)) // person_type_name
                    {
                        sql += " and person_type_name like @person_type_name";
                        sqlPara.Add(new SqlParameter("@person_type_name", "%" + info.person_type_name + "%"));
                    }
                    //if (!string.IsNullOrEmpty(info.city)) // city
                    //{
                    //    sql += " and city like @city";
                    //    sqlPara.Add(new SqlParameter("@city", "%" + info.city + "%"));
                    //}
                }

                DataSet ds = new DataSet();
                // 执行sql语句并返回数据集
                ds = SqlHelper.ExecuteDataset(conStr, CommandType.Text, sql, sqlPara.ToArray());
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
                    pb.income = decimal.Parse(dr[9].ToString());
                    pb.temper = dr[10].ToString();
                    pb.family = dr[11].ToString();
                    pb.person_type = int.Parse(dr[12].ToString());
                    pb.person_type_name = dr[13].ToString();
                    pb.qq = dr[14].ToString();
                    pb.address = dr[15].ToString();
                    pb.phone = dr[16].ToString();
                    pb.belong_place = dr[17].ToString();
                    pb.nation = dr[18].ToString();
                    pb.input_time = DateTime.Parse(dr[19].ToString());
                    pb.user_id = int.Parse(dr[20].ToString());
                    pb.isdel = int.Parse(dr[21].ToString());
                    list.Add(pb);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            // 返回列表
            return list;
        }
    }
}
