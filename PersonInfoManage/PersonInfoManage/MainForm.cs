using System;
using System.Windows.Forms;

namespace PersonInfoManage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            PersonBasicForm pbForm = new PersonBasicForm();
            pbForm.Show();
        }
    }
}
