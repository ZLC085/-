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
    public partial class CostPlanForm : Form
    {
        public CostPlanForm()
        {
            InitializeComponent();
        }

        private void BtnAddTure_Click(object sender, EventArgs e)
        {
            DateTime starttime = TimeStartPlan.Value;
            DateTime endtime = TimeEndPlan.Value;
            if (starttime.Date <= endtime.Date)
            {
                MessageBox.Show("是否添加", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("你输入的第一个日期没有小于第二个日期，请重输！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
        }

        private void BtnAddCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("是否放弃添加", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            return;
        }

       
    }
}
