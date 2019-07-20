using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonInfoManage.DAL.System;
using PersonInfoManage.Model;


namespace PersonInfoManage.BLL.System
{
    class PermBLL
    {
        /// <summary>
        /// 添加用户组
        /// </summary>
        /// <param name="group"></param>
        /// <returns>影响条数</returns>
        public int add(sys_group group)
        {
            PermDAL perm = new PermDAL();
            return perm.add(group);

        }

        /// <summary>
        /// 添加用户组和用户关联
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="group_id"></param>
        /// <returns>影响条数</returns>
        public int add(int user_id,int group_id)
        {
            PermDAL perm = new PermDAL();
            return perm.add(user_id,group_id);

        }




        /// <summary>
        /// 删除用户组
        /// </summary>
        /// <param name="id"></param>
        /// <returns>影响条数</returns>
        public int Del(int id)
        {
            PermDAL perm = new PermDAL();
            return perm.Del(id);

        }
        /// <summary>
        /// 删除用户组和权限关联
        /// </summary>
        /// <param name="id"></param>
        /// <returns>影响条数</returns>
        public int DelG2m(int id)
        {
            PermDAL perm = new PermDAL();
            return perm.DelG2m(id);

        }
        /// <summary>
        /// 删除用户组和用户关联
        /// </summary>
        /// <param name="id"></param>
        /// <returns>影响条数</returns>
        public int Delu2g(int id)
        {
            PermDAL perm = new PermDAL();
            return perm.Delu2g(id);

        }

        public List<sys_group> Selectgroup(sys_group group)
        {
            PermDAL perm = new PermDAL();
            return perm.Selectgroup(group);

        }







    }
}
