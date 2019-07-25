namespace PersonInfoManage
{
    partial class CostPlanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.PnlAddPlan = new DevComponents.DotNetBar.PanelEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.TimeEndPlan = new System.Windows.Forms.DateTimePicker();
            this.TimeStartPlan = new System.Windows.Forms.DateTimePicker();
            this.LblTimePlan = new DevComponents.DotNetBar.LabelX();
            this.BtnAddCancel = new DevComponents.DotNetBar.ButtonX();
            this.BtnAddTure = new DevComponents.DotNetBar.ButtonX();
            this.DgvAddPlan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            this.PnlAddPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.PnlAddPlan);
            this.panelEx1.Controls.Add(this.BtnAddCancel);
            this.panelEx1.Controls.Add(this.BtnAddTure);
            this.panelEx1.Controls.Add(this.DgvAddPlan);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(645, 551);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // PnlAddPlan
            // 
            this.PnlAddPlan.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlAddPlan.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PnlAddPlan.Controls.Add(this.labelX2);
            this.PnlAddPlan.Controls.Add(this.TimeEndPlan);
            this.PnlAddPlan.Controls.Add(this.TimeStartPlan);
            this.PnlAddPlan.Controls.Add(this.LblTimePlan);
            this.PnlAddPlan.DisabledBackColor = System.Drawing.Color.Empty;
            this.PnlAddPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlAddPlan.Location = new System.Drawing.Point(0, 0);
            this.PnlAddPlan.Margin = new System.Windows.Forms.Padding(4);
            this.PnlAddPlan.Name = "PnlAddPlan";
            this.PnlAddPlan.Size = new System.Drawing.Size(645, 78);
            this.PnlAddPlan.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlAddPlan.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.PnlAddPlan.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.PnlAddPlan.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.PnlAddPlan.Style.GradientAngle = 90;
            this.PnlAddPlan.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(344, 30);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(45, 29);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "——";
            // 
            // TimeEndPlan
            // 
            this.TimeEndPlan.Location = new System.Drawing.Point(397, 30);
            this.TimeEndPlan.Margin = new System.Windows.Forms.Padding(4);
            this.TimeEndPlan.Name = "TimeEndPlan";
            this.TimeEndPlan.Size = new System.Drawing.Size(161, 25);
            this.TimeEndPlan.TabIndex = 2;
            // 
            // TimeStartPlan
            // 
            this.TimeStartPlan.Location = new System.Drawing.Point(172, 30);
            this.TimeStartPlan.Margin = new System.Windows.Forms.Padding(4);
            this.TimeStartPlan.Name = "TimeStartPlan";
            this.TimeStartPlan.Size = new System.Drawing.Size(161, 25);
            this.TimeStartPlan.TabIndex = 1;
            // 
            // LblTimePlan
            // 
            // 
            // 
            // 
            this.LblTimePlan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblTimePlan.Location = new System.Drawing.Point(16, 30);
            this.LblTimePlan.Margin = new System.Windows.Forms.Padding(4);
            this.LblTimePlan.Name = "LblTimePlan";
            this.LblTimePlan.Size = new System.Drawing.Size(160, 29);
            this.LblTimePlan.TabIndex = 0;
            this.LblTimePlan.Text = "请选择规划时间段：";
            // 
            // BtnAddCancel
            // 
            this.BtnAddCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnAddCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnAddCancel.Location = new System.Drawing.Point(373, 500);
            this.BtnAddCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddCancel.Name = "BtnAddCancel";
            this.BtnAddCancel.Size = new System.Drawing.Size(107, 31);
            this.BtnAddCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnAddCancel.Symbol = "";
            this.BtnAddCancel.SymbolColor = System.Drawing.Color.Red;
            this.BtnAddCancel.TabIndex = 2;
            this.BtnAddCancel.Text = "取消";
            this.BtnAddCancel.Click += new System.EventHandler(this.BtnAddCancel_Click);
            // 
            // BtnAddTure
            // 
            this.BtnAddTure.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnAddTure.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnAddTure.Location = new System.Drawing.Point(160, 500);
            this.BtnAddTure.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddTure.Name = "BtnAddTure";
            this.BtnAddTure.Size = new System.Drawing.Size(107, 31);
            this.BtnAddTure.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnAddTure.Symbol = "";
            this.BtnAddTure.SymbolColor = System.Drawing.Color.Green;
            this.BtnAddTure.TabIndex = 1;
            this.BtnAddTure.Text = "确定";
            this.BtnAddTure.Click += new System.EventHandler(this.BtnAddTure_Click);
            // 
            // DgvAddPlan
            // 
            this.DgvAddPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAddPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvAddPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAddPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAddPlan.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvAddPlan.EnableHeadersVisualStyles = false;
            this.DgvAddPlan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DgvAddPlan.Location = new System.Drawing.Point(0, 78);
            this.DgvAddPlan.Margin = new System.Windows.Forms.Padding(4);
            this.DgvAddPlan.Name = "DgvAddPlan";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAddPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvAddPlan.RowHeadersVisible = false;
            this.DgvAddPlan.RowHeadersWidth = 51;
            this.DgvAddPlan.RowTemplate.Height = 23;
            this.DgvAddPlan.Size = new System.Drawing.Size(645, 386);
            this.DgvAddPlan.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "费用类型";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "金额";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // CostPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 551);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CostPlanForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增费用规划";
            this.panelEx1.ResumeLayout(false);
            this.PnlAddPlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX BtnAddCancel;
        private DevComponents.DotNetBar.ButtonX BtnAddTure;
        private DevComponents.DotNetBar.Controls.DataGridViewX DgvAddPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private DevComponents.DotNetBar.PanelEx PnlAddPlan;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DateTimePicker TimeEndPlan;
        private System.Windows.Forms.DateTimePicker TimeStartPlan;
        private DevComponents.DotNetBar.LabelX LblTimePlan;
    }
}