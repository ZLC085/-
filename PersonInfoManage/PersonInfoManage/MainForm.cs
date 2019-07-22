using System;
using System.Windows.Forms;

namespace PersonInfoManage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lableTime.Text = DateTime.Now.ToString("yyyy年MM月dd日-HH:mm:ss");
        }
        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            PersonBasicForm pbForm = new PersonBasicForm();
            pbForm.Show();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出系统吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
