using PersonInfoManage.BLL.System;
using PersonInfoManage.BLL.Utils;
using PersonInfoManage.Model;
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
    public partial class AddUserToGroupForm : Form
    {
        public AddUserToGroupForm()
        {
            InitializeComponent();
        }

        private void AddUserToGroupForm_Load(object sender, EventArgs e)
        {
            //labelX3.Text = group_name;
            //dataGridViewX1
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            int groupId = 0;//待定
            List<int> userid = new List<int>();
            ///待定
            Result result = new PermBLL().AddU2g(groupId, userid);
            if (result.Code == RES.OK)
            {
                MessageBoxCustom.Show("添加成功", "提示", MessageBoxButtons.OK, this);
                Close();
            }
            else if (result.Code == RES.ERROR)
            {
                MessageBoxCustom.Show("添加失败", "提示", MessageBoxButtons.OK, this);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
