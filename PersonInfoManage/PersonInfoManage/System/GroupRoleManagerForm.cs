using PersonInfoManage.BLL.System;
using PersonInfoManage.BLL.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInfoManage
{
    public partial class GroupRoleManageForm : Form
    {
        public GroupRoleManageForm()
        {
            InitializeComponent();
        }

        private void GroupRoleManageForm_Load(object sender, EventArgs e)
        {
            //labelX5.Text = groupname;
            dataGridViewX1.AutoGenerateColumns = false;
            dataGridViewX1.DataSource = new PermBLL().SelectAllG2m();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            int groupId = 0;//待定
            List<int> menuid = new List<int>();
            //等数据
            Result result = new PermBLL().Perm(groupId,menuid);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
