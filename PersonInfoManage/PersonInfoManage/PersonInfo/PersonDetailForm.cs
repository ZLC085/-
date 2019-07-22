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
                string filePath = openFile.FileName;


                PersonFileBLL personFileBLL = new PersonFileBLL();
                //需要人员id
                Result result = personFileBLL.Add(1001, filePath);

                if (result.Code == RES.OK)
                {
                    MessageBox.Show(result.Message, "文件添加");
                }
                else if (result.Code == RES.ERROR)
                {
                    MessageBox.Show(result.Message, "文件添加");
                }
            }

        }

        private void BtnOutFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择保存文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;

                PersonFileBLL personFileBLL = new PersonFileBLL();

                //需要文件id
                Result result = personFileBLL.OutFile(28, foldPath);

                if (result.Code == RES.OK)
                {
                    MessageBox.Show(result.Message, "文件导出");
                }
                else if (result.Code == RES.ERROR)
                {
                    MessageBox.Show(result.Message, "文件导出");
                }
            }
        }
    }
}
