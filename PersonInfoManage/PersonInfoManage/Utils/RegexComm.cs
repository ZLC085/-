using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonInfoManage.Utils
{
    public class RegexComm
    {
        private const string REG_NAME = @"^(([a-zA-Z+\.?\·?a-zA-Z+]{2,30}$)|([\u4e00-\u9fa5+\·?\u4e00-\u9fa5+]{2,30}$))";
        private const string REG_IDNUM = @"^[1-9]\d{7}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}$|^[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}([0-9]|X)$";
        private const string REG_PHONE = @"^[0-9]*$";

        #region 名字有效性验证
        /// <summary>
        /// 名字有效性验证
        /// </summary>
        /// <param name="name">名字字符串</param>
        /// <returns>有效:true,否则:false</returns>
        public static bool IsValidName(string name)
        {
            return Regex.IsMatch(name, RegexComm.REG_NAME);
        }
        #endregion

        #region 身份证号有效性验证
        /// <summary>
        /// 身份证号有效性验证
        /// </summary>
        /// <param name="idNum">身份证号字符串</param>
        /// <returns>有效:true,否则:false</returns>
        public static bool IsValidIdNum(string idNum)
        {
            return Regex.IsMatch(idNum, RegexComm.REG_IDNUM);
        }
        #endregion

        #region 电话有效性验证
        /// <summary>
        /// 电话有效性验证
        /// </summary>
        /// <param name="phone">电话字符串</param>
        /// <returns>有效:true,否则:false</returns>
        public static bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, RegexComm.REG_PHONE);
        }
        #endregion
    }
}
