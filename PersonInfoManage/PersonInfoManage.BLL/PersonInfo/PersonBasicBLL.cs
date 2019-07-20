using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoManage.BLL.PersonInfo
{
    public class PersonBasicBLL
    {
        public bool Add(person_basic info)
        {
            if (new DAL.PersonInfo.PersonBasicDAL().Add(info) > 0)
            {
                return true;
            }
            return false;
        }


    }
}
