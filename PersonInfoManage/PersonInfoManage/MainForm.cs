﻿using PersonInfoManage.DAL.Cost;
using PersonInfoManage.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PersonInfoManage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            #region
            CostPlan costPlan = new CostPlan();
            Dictionary<string, object> conditions = new Dictionary<string, object>();
            conditions.Add(nameof(cost_plan.cost_type), "出差");
            conditions.Add(nameof(cost_plan.end_time), new DateTime(2019, 12, 12));

            List<cost_plan> cost_Plans = costPlan.SelectCostPlanByConditions(conditions);
            #endregion
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“person_info_manageDataSet.person_basic”中。您可以根据需要移动或删除它。

        }

        private void labelX10_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {

        }
    }
}
