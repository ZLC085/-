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
    public partial class PersonDetailForm : Form
    {
        public PersonDetailForm()
        {
            InitializeComponent();
        }

        private void BtnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;
            openFile.Title = "请选择文件";
            openFile.Filter = "所有文件(*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filePath= openFile.FileName;
                string fileName = openFile.SafeFileName;

                
                int index = fileName.LastIndexOf('.');
                string fileType = fileName.Substring(index);

                //return fileType;
            }
           
        }
    }
}
