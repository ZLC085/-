namespace PersonInfoManage
{
    partial class AddCostDetailForm
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.comboBoxCostType = new System.Windows.Forms.ComboBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX32 = new DevComponents.DotNetBar.LabelX();
            this.btnCostDetailCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnAddCostKind = new DevComponents.DotNetBar.ButtonX();
            this.texCostCount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.comboBoxCostType);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.labelX32);
            this.panelEx1.Controls.Add(this.btnCostDetailCancel);
            this.panelEx1.Controls.Add(this.btnAddCostKind);
            this.panelEx1.Controls.Add(this.texCostCount);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(645, 382);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // comboBoxCostType
            // 
            this.comboBoxCostType.FormattingEnabled = true;
            this.comboBoxCostType.Items.AddRange(new object[] {
            "test1",
            "test2",
            "test3"});
            this.comboBoxCostType.Location = new System.Drawing.Point(260, 108);
            this.comboBoxCostType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCostType.Name = "comboBoxCostType";
            this.comboBoxCostType.Size = new System.Drawing.Size(233, 23);
            this.comboBoxCostType.TabIndex = 69;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Red;
            this.labelX4.Location = new System.Drawing.Point(351, 238);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(144, 29);
            this.labelX4.TabIndex = 68;
            this.labelX4.Text = "请填写费用金额！";
            // 
            // labelX32
            // 
            // 
            // 
            // 
            this.labelX32.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX32.ForeColor = System.Drawing.Color.Red;
            this.labelX32.Location = new System.Drawing.Point(351, 140);
            this.labelX32.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX32.Name = "labelX32";
            this.labelX32.Size = new System.Drawing.Size(144, 29);
            this.labelX32.TabIndex = 67;
            this.labelX32.Text = "请选择费用类型！";
            // 
            // btnCostDetailCancel
            // 
            this.btnCostDetailCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCostDetailCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCostDetailCancel.Location = new System.Drawing.Point(373, 325);
            this.btnCostDetailCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCostDetailCancel.Name = "btnCostDetailCancel";
            this.btnCostDetailCancel.Size = new System.Drawing.Size(107, 31);
            this.btnCostDetailCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCostDetailCancel.Symbol = "";
            this.btnCostDetailCancel.SymbolColor = System.Drawing.Color.Red;
            this.btnCostDetailCancel.TabIndex = 5;
            this.btnCostDetailCancel.Text = "取消";
            this.btnCostDetailCancel.Click += new System.EventHandler(this.BtnCostDetailCancel_Click);
            // 
            // btnAddCostKind
            // 
            this.btnAddCostKind.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddCostKind.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddCostKind.Location = new System.Drawing.Point(160, 325);
            this.btnAddCostKind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCostKind.Name = "btnAddCostKind";
            this.btnAddCostKind.Size = new System.Drawing.Size(107, 31);
            this.btnAddCostKind.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddCostKind.Symbol = "";
            this.btnAddCostKind.SymbolColor = System.Drawing.Color.Green;
            this.btnAddCostKind.TabIndex = 4;
            this.btnAddCostKind.Text = "添加";
            this.btnAddCostKind.Click += new System.EventHandler(this.BtnAddCostKind_Click);
            // 
            // texCostCount
            // 
            // 
            // 
            // 
            this.texCostCount.Border.Class = "TextBoxBorder";
            this.texCostCount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.texCostCount.Location = new System.Drawing.Point(260, 204);
            this.texCostCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.texCostCount.Name = "texCostCount";
            this.texCostCount.PreventEnterBeep = true;
            this.texCostCount.Size = new System.Drawing.Size(235, 25);
            this.texCostCount.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(137, 204);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(121, 29);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "费用金额：";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(137, 108);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(121, 29);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "费用类型：";
            // 
            // AddCostDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 382);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCostDetailForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加费用明细";
            this.Load += new System.EventHandler(this.AddCostDetailForm_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnCostDetailCancel;
        private DevComponents.DotNetBar.ButtonX btnAddCostKind;
        private DevComponents.DotNetBar.Controls.TextBoxX texCostCount;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX32;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.ComboBox comboBoxCostType;
    }
}