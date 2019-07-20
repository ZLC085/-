using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.BLL.PersonInfo
{
    class PersonBasicBLL
    {
        /// <summary>
        /// 人员信息录入
        /// </summary>
        /// <param name="info">人员信息</param>
        /// <returns>bool类型</returns>
        public bool Add(person_basic info)
        {
            // 判断是否操作成功
            if (new DAL.PersonInfo.PersonBasicDAL().Add(info) > 0)
            {
                // 成功
                return true;
            }
            // 失败
            return false;
        }

        /// <summary>
        /// 人员信息修改
        /// </summary>
        /// <param name="info">人员信息</param>
        /// <returns>bool类型</returns>
        public bool Update(person_basic info)
        {
            // 判断是否操作成功
            if (new DAL.PersonInfo.PersonBasicDAL().Update(info) > 0)
            {
                // 成功
                return true;
            }
            // 失败
            return false;
        }

        /// <summary>
        /// 人员信息移除
        /// </summary>
        /// <param name="id">人员id</param>
        /// <returns>bool类型</returns>
        public bool Remove(int id)
        {
            // 判断是否操作成功
            if (new DAL.PersonInfo.PersonBasicDAL().Remove(id) > 0)
            {
                // 成功
                return true;
            }
            // 失败
            return false;
        }

        /// <summary>
        /// 人员信息删除
        /// </summary>
        /// <param name="id">人员id</param>
        /// <returns>bool类型</returns>
        public bool Del(int id)
        {
            // 判断是否操作成功
            if (new DAL.PersonInfo.PersonBasicDAL().Del(id) > 0)
            {
                // 成功
                return true;
            }
            // 失败
            return false;
        }

        /// <summary>
        /// 人员信息检索
        /// </summary>
        /// <param name="info">查询条件</param>
        /// <returns>List类型</returns>
        public List<person_basic> Query(person_basic info)
        {
            // 接收列表
            List<person_basic> list = new DAL.PersonInfo.PersonBasicDAL().Query(info);
            // 返回列表
            return list;
        }
    }
}
