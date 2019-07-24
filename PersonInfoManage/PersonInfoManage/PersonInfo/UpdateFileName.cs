using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonInfoManage.PersonInfo
{
    public partial class UpdateFileName : Form
    {
        public UpdateFileName()
        {
            InitializeComponent();
        }

        private void LblFileName_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection("server = (47.106.235.197); database = localhost; uid = SA; pwd = qwer-123456");
            con.Open();

            //String find = "select * from person_file where filename = ' " + filename + " '";
            //SqlDataAdapter myDa = new SqlDataAdapter(find, con);
            DataSet Ds = new DataSet();
            //myDa.Fill(Ds, "name");
            //DataGridView1_CellContentClick.DataSourse = Ds.Tables["name"];

        }
    }
}
