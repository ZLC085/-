using PersonInfoManage.IDAL.PersonInfo;
using PersonInfoManage.Models;
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
    public class BasicInfo : IBasicInfo
    {
        /// <summary>
        /// 人员信息录入
        /// </summary>
        /// <param name="info">人员信息</param>
        /// <returns>插入条数</returns>
        public int InsertBasicInfo(basic_info info)
        {
            return 0;
        }

        /// <summary>
        /// 人员信息修改
        /// </summary>
        /// <param name="info">人员信息</param>
        /// <returns>更新条数</returns>
        public int UpdateBasicInfoById(basic_info info)
        {
            return 0;
        }

        /// <summary>
        /// 人员信息删除
        /// </summary>
        /// <param name="id">人员信息id</param>
        /// <returns>删除条数</returns>
        public int DeleteBasicInfoById(long id)
        {
            return 0;
        }

        /// <summary>
        /// 人员信息检索（所有）
        /// </summary>
        /// <returns>所有的人员信息</returns>
        public List<basic_info> SelectAllBasicInfo()
        {
            return null;
        }

        /// <summary>
        /// 人员信息检索（单个）
        /// </summary>
        /// <returns>单个人员信息</returns>
        public basic_info SelectBasicInfo()
        {
            return null;
        }
    }
}
