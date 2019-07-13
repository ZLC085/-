using PersonInfoManage.DAL.Utils;
using PersonInfoManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.System
{
    /// <summary>
    /// 用户管理
    /// </summary>
    public class SysUser
    {
        /// <summary>
        /// 用户添加
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>添加条数</returns>
        public int InsertSysUser(sys_user user)
        {
            return new DBOperationsInsert<sys_user, DBNull>().Insert(user);
        }

        /// <summary>
        /// 用户信息修改
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newValues">用户信息</param>
        /// <returns>修改条数</returns>
        public int UpdateSysUser(int id, Dictionary<string, object> newValues)
        {
            return new DBOperationsUpdate<sys_user>().UpdateById(id, newValues);
        }

        /// <summary>
        /// 用户删除
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>删除条数</returns>
        public int DeleteSysUser(int userId)
        {
            return new DBOperationsDelete<sys_user, DBNull>().DeleteById(userId);
        }

        /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <returns>所有用户</returns>
        public List<sys_user> SelectAllSysUser()
        {
            return new DBOperationsSelect<sys_user>().SelectAll();
        }

        /// <summary>
        /// 通过输入条件查询用户
        /// </summary>
        /// <param name="conditions">查询条件</param>
        /// <returns>通过用户名查询到的用户</returns>
        public List<sys_user> SelectSysUserByConditions(Dictionary<string,object> conditions)
        {
            return new DBOperationsSelect<sys_user>().SelectByConditions(conditions);
        }
    }
}
