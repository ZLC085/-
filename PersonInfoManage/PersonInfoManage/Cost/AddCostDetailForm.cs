using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void BtnAddCostKind_Click(object sender, EventArgs e)
        {
            string CountPattern = @"^[0-9]*$";
            if (texCostCount.Text ==""|| !Regex.Match(texCostCount.Text, CountPattern).Success || comboBoxCostType.SelectedItem == null || (string)comboBoxCostType.SelectedItem == "")
            {
                MessageBox.Show("您输入的数据不正确！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string TypeStr = comboBoxCostType.SelectedItem.ToString().Trim();
                string CountStr = texCostCount.Text.Trim();
                CostApplyForm form = (CostApplyForm)this.Owner;
                form.addDetail(TypeStr, CountStr);
                this.Close();
            }
            
        }
        private void BtnCostDetailCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
