using Loading;
using PersonInfoManage.BLL.PersonInfo;
using PersonInfoManage.BLL.Utils;
using System;
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
            OpenFileDialog openFile = new OpenFileDialog
            {
                Multiselect = false,
                Title = "请选择文件",
                Filter = "所有文件(*.*)|*.*"
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFile.FileName;
                Result result = null;
                LoadingHelper.ShowLoading("文件上传中...", this, o =>
                {
                    //这里写处理耗时的代码，代码处理完成则自动关闭该窗口
                    PersonFileBLL personFileBLL = new PersonFileBLL();
                    result = personFileBLL.Add(1001, filePath);
                });

                FileStatus(result, "文件添加");
            }
        }
        
        private void BtnOutFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择保存文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                Result result = null;
                LoadingHelper.ShowLoading("文件导出中...", this, o => 
                {
                    PersonFileBLL personFileBLL = new PersonFileBLL();

                    //需要文件id
                    result = personFileBLL.OutFile(28, foldPath);
                });

                FileStatus(result, "文件导出");
            }
        }

        private void FileStatus(Result result, string title)
        {
            if (result?.Code == RES.OK)
            {
                MessageBoxCustom.Show(result.Message, title, this);
            }
            else if (result?.Code == RES.ERROR)
            {
                MessageBoxCustom.Show(result.Message, title, this);
            }
        }

        private void BtnUpdateFile_Click(object sender, EventArgs e)
        {
            PersonDetailForm pdForm = new PersonDetailForm();
            pdForm.Text = "修改文件名";
            pdForm.ShowDialog();
        }

        private void BtnDelFile_Click(object sender, EventArgs e)
        {
           
        }
    }
}
