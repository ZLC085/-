using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.IDAL.PersonInfo
{
    /// <summary>
    /// 基本信息管理
    /// </summary>
    public interface IBasicInfo
    {
        /// <summary>
        /// 人员信息录入
        /// </summary>
        /// <param name="info">人员信息</param>
        /// <returns>插入条数</returns>
        int InsertBasicInfo(basic_info info);

        /// <summary>
        /// 人员信息修改
        /// </summary>
        /// <param name="info">人员信息</param>
        /// <returns>更新条数</returns>
        int UpdateBasicInfoById(basic_info info);

        /// <summary>
        /// 人员信息删除
        /// </summary>
        /// <param name="id">人员信息id</param>
        /// <returns>删除条数</returns>
        int DeleteBasicInfoById(long id);

        /// <summary>
        /// 人员信息检索（所有）
        /// </summary>
        /// <returns>所有的人员信息</returns>
        List<basic_info> SelectAllBasicInfo();

        /// <summary>
        /// 人员信息检索（单个）
        /// </summary>
        /// <returns>单个人员信息</returns>
        basic_info SelectBasicInfo();
    }
}
