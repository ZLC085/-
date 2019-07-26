using PersonInfoManage.BLL.Utils;
using PersonInfoManage.DAL.PersonInfo;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInfoManage.Utils
{
    public class DGVOperations:UserInfoBLL
    {
        private static List<person_basic> PersonBasics { get; set; }
        public static person_basic GetSelectPersonBasic(string identityNumber)
        {
            person_basic personBasic = null;
            foreach(person_basic pb in PersonBasics)
            {
                if (identityNumber.Equals(pb.identity_number))
                {
                    personBasic = pb;
                    break;
                }
            }

            return personBasic;
        }

        public static List<string> SelectPersonBasic(DataGridView dgv)
        {
            List<string> ids = new List<string>();
            foreach(DataGridViewRow row in dgv.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    ids.Add(row.Cells[2].Value.ToString());
                }
            }

            return ids;
        }

        public static void DGVPersonBasicNotDelDataSource(DataGridView dgv)
        {
            var dataSource = new PersonBasicDAL().Query(new person_basic { isdel = 0, user_id = UserId });
            DGVDataSource(dgv, dataSource);

            PersonBasics = dataSource;
        }

        public static void DGVPersonBasicDelDataSource(DataGridView dgv)
        {
            var dataSource = new PersonBasicDAL().Query(new person_basic { isdel = 1, user_id = UserId });
            DGVDataSource(dgv, dataSource);
        }

        private static void DGVDataSource(DataGridView dgv, object dataSource)
        {
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = dataSource;
        }
    }
}
