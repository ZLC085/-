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



            List<string> vs = new List<string>
            {
                "男","女"
            };
            Binding binding = new Binding("Text", vs, "Sex");
            textBoxDropDown1.DataBindings.Add(binding);
        }
    }
}
