using PersonInfoManage.DAL.Utils;
using System;
using System.Windows.Forms;

namespace PersonInfoManage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.GetSqlConnection();
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“person_info_manageDataSet.person_basic”中。您可以根据需要移动或删除它。
            this.person_basicTableAdapter.Fill(this.person_info_manageDataSet.person_basic);

        }

        private void labelX10_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {

        }
    }
}
