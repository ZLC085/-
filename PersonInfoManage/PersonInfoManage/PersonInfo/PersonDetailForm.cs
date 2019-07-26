using Loading;
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
        private readonly int PersonId;
        private int FileId = -1;
        public PersonDetailForm(int personId)
        {
            InitializeComponent();
            PersonId = personId;
        }

        // 页面加载
        private void PersonDetailForm_Load(object sender, EventArgs e)
        {
            person_basic pb = new person_basic { id = PersonId };
            pb.user_id = UserInfoBLL.UserId;
            List<person_basic> list = new PersonBasicBLL().Query(pb);
            LblName.Text = list[0].name;
            LblFormerName.Text = list[0].former_name;
            LblGender.Text = list[0].gender;
            LblID.Text = list[0].identity_number;
            LblBirthDate.Text = list[0].birth_date.ToString();
            LblNation.Text = list[0].nation;
            LblNativePlace.Text = list[0].native_place;
            LblAddress.Text = list[0].address;
            LblPhone.Text = list[0].phone;
            LblQQ.Text = list[0].qq;
            foreach (var item in new SysSettingBLL().SelectByDictName(sys_dict_type.Person))
            {
                if (item.id.Equals(list[0].person_type_id))
                {
                    LblPersonType.Text = item.category_name;
                }
            }
            foreach (var item in new SysSettingBLL().SelectByDictName(sys_dict_type.BelongPlace))
            {
                if (item.id.Equals(list[0].belong_place_id))
                {
                    LblBelongPlace.Text = item.category_name;
                }
            }
            if (list[0].marry_status)
            {
                LblMarry.Text = "已婚";
            }
            else
            {
                LblMarry.Text = "未婚";
            }
            LblJob.Text = list[0].job_status;
            LblIncome.Text = list[0].income.ToString();
            LblTemper.Text = list[0].temper;
            LblFamily.Text = list[0].family;
            LblInputTime.Text = list[0].input_time.ToString();
            LblUserId.Text = list[0].user_id.ToString();
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
                    result = personFileBLL.Add(PersonId, filePath);
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
                //PersonFileBLL a = new PersonFileBLL();
                //a.Del(id);
                //PersonFileBLL file = new PersonFileBLL();
                //file.Del(id);
                String file = " PersonFileBLL ";
                String del = " Del ";

                Type type;
                Object obj;

                type = Type.GetType(file);
                obj = System.Activator.CreateInstance(type);

                MethodInfo method = type.GetMethod(del, new Type[] { });
                object[] parameters = null;
                //method.Invoke(obj, parameters);


                method = type.GetMethod(del, new Type[] { typeof(string) });
                parameters = new[] { "id" };
                method.Invoke(obj, parameters);

            }
            else
            {
                this.Close();
            }
        }

        
    }
}
