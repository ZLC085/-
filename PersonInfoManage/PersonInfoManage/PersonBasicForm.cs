using PersonInfoManage.DAL.PersonInfo;
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
    public partial class PersonBasicForm : Form
    {
        public PersonBasicForm()
        {
            InitializeComponent();
        }

        private void LabelX1_Click(object sender, EventArgs e)
        {

        }

        private void LabelX6_Click(object sender, EventArgs e)
        {

        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            PersonBasic PB = new PersonBasic();
            person_basic pb = new person_basic();
            // 封装
            pb.name = "王大柱";
            pb.former_name = "酸菜";
            pb.gender = "女";
            pb.identity_number = "2016";
            pb.birth_date = DateTime.Now;
            pb.city = "成都";
            pb.province = "四川";
            pb.marry_status = true;
            pb.job_status = "餐厅服务员";
            pb.income = 2000;
            pb.temper = "火辣";
            pb.family = "";
            pb.person_type = "肇事";
            pb.qq = "";
            pb.address = "双流区北二街1号";
            pb.phone = "12345678910";
            pb.belong_place = "成都市双流区公安局";
            pb.nation = "汉";
            pb.input_time = DateTime.Now;
            pb.user_id = 1;
            pb.isdel = 1;
            // 插入判断
            if (PB.Add(pb) > 0)
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
            
        }

        private void TextBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelX2_Click(object sender, EventArgs e)
        {

        }
    }
}
