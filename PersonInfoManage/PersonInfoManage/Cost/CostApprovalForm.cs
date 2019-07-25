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
    public partial class CostApprovalForm : Form
    {
        private int costId;
        public CostApprovalForm()
        {
            InitializeComponent();
        }
        public CostApprovalForm(int costId)
        {
            this.costId = costId;
            InitializeComponent();
        }
        private void CostApprovalForm_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBoxX2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
