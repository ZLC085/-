using PersonInfoManage.BLL.PersonInfo;
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
    public partial class UpdateFileName : Form
    {
        public UpdateFileName()
        {
            InitializeComponent();
        }

        private void LblFileName_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtNewFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdateFile_Click(object sender, EventArgs e)
        {
            person_file A = new person_file();
            A.filename = LblFileName.Text;
            PersonFileBLL set = new PersonFileBLL();
            Result res = new Result();
            res = set.Update(A.filename, A.id);
            if (res.Message == "修改成功!")
            {
                MessageBoxCustom.Show("修改成功", "提示", this);
            }
            else
            {
                MessageBoxCustom.Show("修改失败", "提示", this);
            }

        }
    }
}
