using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.Utils
{
    /// <summary>
    /// 数据字典中英转换
    /// </summary>
    public class SysDictTypeConvert
    {
        /// <summary>
        /// 英文转中文
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string EToC(sys_dict_type type)
        {
            string res = "";
            switch (type)
            {
                case sys_dict_type.Cost:
                    res = "费用类别";
                    break;
                case sys_dict_type.Person:
                    res = "重点人员类别";
                    break;
                case sys_dict_type.BelongPlace:
                    res = "归属地";
                    break;
                default: break;
            }

            return res;
        }

       /// <summary>
       /// 中文转英文
       /// </summary>
       /// <param name="type"></param>
       /// <returns></returns>
        public static string  CToE(string type)
        {
            sys_dict_type res = sys_dict_type.None;
            switch (type)
            {
                case "费用类别":
                    res = sys_dict_type.Cost;
                    break;
                case "重点人员类别":
                    res = sys_dict_type.Person;
                    break;
                case "归属地":
                    res = sys_dict_type.BelongPlace;
                    break;
                default: break;
            }

            return res.ToString();
        }


        public  static sys_dict_type Change(string type)
        {
            sys_dict_type res = sys_dict_type.None;
            switch (type)
            {
                case "费用类别":
                    res = sys_dict_type.Cost;
                    break;
                case "重点人员类别":
                    res = sys_dict_type.Person;
                    break;
                case "归属地":
                    res = sys_dict_type.BelongPlace;
                    break;
                default: break;
            }

            return res;
        }
    }
}
