using PersonInfoManage.BLL.System;
using PersonInfoManage.BLL.Utils;
using PersonInfoManage.Model;
using PersonInfoManage.Utils;
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
    public partial class AddCategoreTypeForm : Form
    {
        private string value;
        public AddCategoreTypeForm()
        {
            InitializeComponent();
            //labelX3.Text = selectStr.ToString();
        }
       
       
        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            if (Text.Equals("添加类别名称"))
            {
                sys_dict dict = new sys_dict();
               
             
                dict.category_name = textBoxX1.Text;
                dict.dict_name = SysDictTypeConvert.CToE(labelX3.Text);
                SysSettingBLL set = new SysSettingBLL();
                Result result = new Result();
                result = set.Add(dict);
                if (result.Message == "添加成功！")
                {
                    MessageBoxCustom.Show("添加成功", "提示", this);
                }
                else
                {
                    MessageBoxCustom.Show("添加失败", "提示", this);
                }

            }
            else
            {
                sys_dict dict = new sys_dict();
                dict.category_name = textBoxX1.Text;
                SysSettingBLL set = new SysSettingBLL();
                Result result = new Result();
                result = set.Update(dict);
                if (result.Message == "修改成功！")
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
}
