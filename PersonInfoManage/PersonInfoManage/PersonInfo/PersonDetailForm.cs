﻿using Loading;
using PersonInfoManage.BLL.PersonInfo;
using PersonInfoManage.BLL.System;
using PersonInfoManage.BLL.Utils;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace PersonInfoManage
{
    public partial class PersonDetailForm : Form
    {
        private readonly person_basic PersonBasic;
        private int FileId = -1;
        public PersonDetailForm(person_basic personBasic)
        {
            InitializeComponent();
            PersonBasic = personBasic;
        }

        // 页面加载
        private void PersonDetailForm_Load(object sender, EventArgs e)
        {
            DGVFile.AutoGenerateColumns = false;
            DGVFile.DataSource = new PersonFileBLL().GetByPersonId(PersonBasic.id);

            LblName.Text = PersonBasic.name;
            LblFormerName.Text = PersonBasic.former_name;
            LblGender.Text = PersonBasic.gender;
            LblID.Text = PersonBasic.identity_number;
            LblBirthDate.Text = PersonBasic.birth_date.ToString();
            LblNation.Text = PersonBasic.nation;
            LblNativePlace.Text = PersonBasic.native_place;
            LblAddress.Text = PersonBasic.address;
            LblPhone.Text = PersonBasic.phone;
            LblQQ.Text = PersonBasic.qq;
            foreach (var item in new SysSettingBLL().SelectByDictName(sys_dict_type.Person))
            {
                if (item.id.Equals(PersonBasic.person_type_id))
                {
                    LblPersonType.Text = item.category_name;
                }
            }
            foreach (var item in new SysSettingBLL().SelectByDictName(sys_dict_type.BelongPlace))
            {
                if (item.id.Equals(PersonBasic.belong_place_id))
                {
                    LblBelongPlace.Text = item.category_name;
                }
            }
            if (PersonBasic.marry_status)
            {
                LblMarry.Text = "已婚";
            }
            else
            {
                LblMarry.Text = "未婚";
            }
            LblJob.Text = PersonBasic.job_status;
            LblIncome.Text = PersonBasic.income.ToString();
            LblTemper.Text = PersonBasic.temper;
            LblFamily.Text = PersonBasic.family;
            LblInputTime.Text = PersonBasic.input_time.ToString();
            foreach(var item in new SysUserBLL().SelectById(PersonBasic.user_id))
            {
                if(item.id== PersonBasic.user_id)
                {
                    LblUserId.Text = item.name;
                }
            }
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
                    result = personFileBLL.Add(PersonBasic.id, filePath);
                });

                FileStatus(result, "文件添加");
            }
        }
        
        private void BtnOutFile_Click(object sender, EventArgs e)
        {
            if (FileId == -1)
            {
                MessageBoxCustom.Show("请选择需要导出的文件！", "提示", this);
                return;
            }

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择保存文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                Result result = null;
                LoadingHelper.ShowLoading("文件导出中...", this, o => 
                {
                    PersonFileBLL personFileBLL = new PersonFileBLL();

                    result = personFileBLL.OutFile(FileId, foldPath);
                    FileId = -1;
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
            //var frm = new UpdateFileName();
            //frm.ShowDialog();
            UpdateFileName updateFileNameForm = new UpdateFileName();
            updateFileNameForm.ShowDialog();

        }

        private void BtnDelFile_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBoxCustom.Show("确认删除", "提示", MessageBoxButtons.YesNo, this);
            if (res == DialogResult.Yes)
            {
                int id = 0;
                person_file file= new person_file();
                /*file.id = 0*/;
                file.person_id = 0;
                List<person_file> pf = new List<person_file>();
                pf = new PersonFileBLL().GetByPersonId(PersonBasic.id);
                List<int> file1 = new List<int>();

                foreach (var file2 in pf)
                {
                    file1.Add(file2.id);
                }
                Result result = new PersonFileBLL().Del(id);
                if (result.Code == RES.OK)
                {
                    MessageBoxCustom.Show("删除成功", "提示", MessageBoxButtons.OK, this);
                    Close();
                }
                else if (result.Code == RES.ERROR)
                {
                    MessageBoxCustom.Show("删除失败", "提示", MessageBoxButtons.OK, this);
                }
            }
        }
        
    }
}
