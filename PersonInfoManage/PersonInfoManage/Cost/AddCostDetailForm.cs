using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonInfoManage.BLL.Cost;

namespace PersonInfoManage
{
    public partial class AddCostDetailForm : Form
    {
        public AddCostDetailForm()
        {
            InitializeComponent();
        }

        private void AddCostDetailForm_Load(object sender, EventArgs e)
        {
            //先清空下拉列表
            comboBoxCostType.Items.Clear();
            //再加载数据进去
            comboBoxCostType.Text = "请选择一项费用类型...";
            comboBoxCostType.Items.AddRange(new CostApplyBLL().CostTypes.ToArray());
        }
    }
}
