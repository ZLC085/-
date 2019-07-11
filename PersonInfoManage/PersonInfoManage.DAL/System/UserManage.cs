﻿using PersonInfoManage.IDAL.System;
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
    public class UserManage : IUserManage
    {
        /// <summary>
        /// 用户添加
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>添加条数</returns>
        public int InsertUser(sys_user user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 用户信息修改
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>修改条数</returns>
        public int UpdateUser(sys_user user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 用户删除
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns>删除条数</returns>
        public int DeleteUser(long userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <returns>所有用户</returns>
        public List<sys_user> SelectAllUser()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 查询用户，通过用户名
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>通过用户名查询到的用户</returns>
        public sys_user SelectUserByUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}