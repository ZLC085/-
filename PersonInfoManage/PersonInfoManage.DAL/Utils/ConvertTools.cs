using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Utils
{
    public class ConvertTools
    {
        public static object DbNullConvert(object obj)
        {
            if (obj == DBNull.Value)
            {
                return null;
            }
            else
            {
                return obj;
            }
        }
        public static int Bool2Bit(bool flag)
        {
            if (flag)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public static bool? Bit2Bool(int flag)
        {
            if (flag == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
