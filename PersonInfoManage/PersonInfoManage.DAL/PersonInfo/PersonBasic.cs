using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.PersonInfo
{
    /// <summary>
    /// 基本信息管理
    /// </summary>
    public class PersonBasic
    {
        /// <summary>
        /// 人员信息录入
        /// </summary>
        /// <param name="info">人员信息</param>
        /// <returns>插入条数</returns>
        public int InsertPersonBasic(person_basic info)
        {
            return new DBOperationsInsert<person_basic, DBNull>().Insert(info);
        }

        /// <summary>
        /// 人员信息修改
        /// </summary>
        /// <param name="id">人员编号</param>
        /// <param name="newValues">需要更新的值</param>
        /// <returns>更新条数</returns>
        public int UpdatePersonBasicById(int id, Dictionary<string, object> newValues)
        {
            return new DBOperationsUpdate<person_basic>().UpdateById(id, newValues);
        }

        /// <summary>
        /// 人员信息删除
        /// </summary>
        /// <param name="id">人员信息id</param>
        /// <returns>删除条数</returns>
        public int DeletePersonBasicById(int id)
        {
            return new DBOperationsDelete<person_basic, person_file>().DeleteTransaction(nameof(person_file.person_id), id);
        }

        /// <summary>
        /// 人员信息检索（所有）
        /// </summary>
        /// <returns>所有的人员信息</returns>
        public List<person_basic> SelectAllPersonBasic()
        {
            return new DBOperationsSelect<person_basic>().SelectAll();
        }
       
        /// 根据条件对人员信息检索
        /// </summary>
        /// <param name="conditions">输入的条件</param>
        /// <returns>人员信息</returns>
        public List<person_basic> SelectPersonBasicByConditions(Dictionary<string, object> conditions)
        {
            return new DBOperationsSelect<person_basic>().SelectByConditions(conditions);
        }
    }
}
