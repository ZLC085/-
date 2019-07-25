using PersonInfoManage.BLL.Cost;
using PersonInfoManage.BLL.Utils;
using PersonInfoManage.DAL.Cost;
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
            if (starttime.Date > endtime.Date)
            {
                MessageBox.Show("你输入的第一个日期没有小于第二个日期，请重输！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            CostPlanBLL costPlanBLL = new CostPlanBLL();
            List<cost_plan> listPlan = new List<cost_plan>();
            foreach (DataGridViewRow row in this.DgvAddPlan.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    continue;
                }
                int type = int.Parse(((string)row.Cells[0].Value).Split('.')[0]);
                decimal money = decimal.Parse((string)row.Cells[1].Value);
                listPlan.Add(new cost_plan
                {
                    cost_type_id = type,
                    money = money,
                    start_time= TimeStartPlan.Value,
                    end_time=TimeEndPlan.Value
                });
            }
            Result res = costPlanBLL.Add(listPlan);
            DialogResult dialogResult = MessageBox.Show(res.Message, "添加费用规划", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                if (res.Code == RES.OK)
                {
                    this.DgvAddPlan.Rows.Clear();
                    this.Close();
                }
            }
        }

        private void BtnAddCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("是否放弃添加", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }

        public void AddPlan(string costType, string count)
        {
            foreach (DataGridViewRow row in this.DgvAddPlan.Rows)
            {
                string type = (string)row.Cells[0].Value;
            }
            int index = this.DgvAddPlan.Rows.Add();
            this.DgvAddPlan.Rows[index].SetValues(costType, count);
        }

        private void CostPlanForm_Load(object sender, EventArgs e)
        {
            List<string> listCostType = new CostApplyDAL().GetCostTypes();
            
            foreach(string type in listCostType)
            {
                int index = this.DgvAddPlan.Rows.Add();
                this.DgvAddPlan.Rows[index].SetValues(type,0);
            }
        }
    }
}
