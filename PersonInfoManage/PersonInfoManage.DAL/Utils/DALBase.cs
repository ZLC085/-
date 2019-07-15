using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.DAL.Utils
{
    public class DALBase
    {
        public static string ConStr
        {
            get
            {
                string constr = ConfigurationManager.ConnectionStrings["PersonInfoManage.Properties.Settings.person_info_manageConnectionString"].ConnectionString;
                return constr;
            }
        }
    }
}
