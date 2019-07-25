﻿namespace PersonInfoManage
{
    partial class CostApplyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.CmbApprover = new System.Windows.Forms.ComboBox();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.addCostDeatil = new DevComponents.DotNetBar.ButtonItem();
            this.btnRemoveDetail = new DevComponents.DotNetBar.ButtonItem();
            this.LblApprover = new DevComponents.DotNetBar.LabelX();
            this.DgvCostDetail = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.texCostCount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnCancelCostApply = new DevComponents.DotNetBar.ButtonX();
            this.btnCostApply = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCostDetail)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.CmbApprover);
            this.panelEx1.Controls.Add(this.ribbonBar1);
            this.panelEx1.Controls.Add(this.LblApprover);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(484, 75);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // CmbApprover
            // 
            this.CmbApprover.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmbApprover.FormattingEnabled = true;
            this.CmbApprover.Items.AddRange(new object[] {
            "test1",
            "test2",
            "test3"});
            this.CmbApprover.Location = new System.Drawing.Point(242, 25);
            this.CmbApprover.Name = "CmbApprover";
            this.CmbApprover.Size = new System.Drawing.Size(176, 20);
            this.CmbApprover.TabIndex = 71;
            this.CmbApprover.Text = "请选择一个审批人...";
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.addCostDeatil,
            this.btnRemoveDetail});
            this.ribbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(122, 75);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // addCostDeatil
            // 
            this.addCostDeatil.Image = global::PersonInfoManage.Properties.Resources.添加;
            this.addCostDeatil.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.addCostDeatil.Name = "addCostDeatil";
            this.addCostDeatil.SubItemsExpandWidth = 14;
            this.addCostDeatil.Text = "添加明细";
            this.addCostDeatil.Click += new System.EventHandler(this.AddCostDeatil_Click);
            // 
            // btnRemoveDetail
            // 
            this.btnRemoveDetail.Image = global::PersonInfoManage.Properties.Resources.删除;
            this.btnRemoveDetail.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRemoveDetail.Name = "btnRemoveDetail";
            this.btnRemoveDetail.SubItemsExpandWidth = 14;
            this.btnRemoveDetail.Text = "移除";
            this.btnRemoveDetail.Click += new System.EventHandler(this.BtnRemoveDetail_Click);
            // 
            // LblApprover
            // 
            // 
            // 
            // 
            this.LblApprover.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblApprover.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblApprover.Location = new System.Drawing.Point(178, 23);
            this.LblApprover.Name = "LblApprover";
            this.LblApprover.Size = new System.Drawing.Size(91, 23);
            this.LblApprover.TabIndex = 70;
            this.LblApprover.Text = "审批人：";
            // 
            // DgvCostDetail
            // 
            this.DgvCostDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCostDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCostDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCostDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCostDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCostDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCostDetail.EnableHeadersVisualStyles = false;
            this.DgvCostDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DgvCostDetail.Location = new System.Drawing.Point(0, 75);
            this.DgvCostDetail.Name = "DgvCostDetail";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCostDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCostDetail.RowHeadersWidth = 51;
            this.DgvCostDetail.RowTemplate.Height = 23;
            this.DgvCostDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvCostDetail.Size = new System.Drawing.Size(484, 358);
            this.DgvCostDetail.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "费用类型";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "费用金额";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.texCostCount);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.Controls.Add(this.btnCancelCostApply);
            this.panelEx2.Controls.Add(this.btnCostApply);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx2.Location = new System.Drawing.Point(0, 266);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(484, 167);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 9;
            // 
            // texCostCount
            // 
            // 
            // 
            // 
            this.texCostCount.Border.Class = "TextBoxBorder";
            this.texCostCount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.texCostCount.Location = new System.Drawing.Point(85, 14);
            this.texCostCount.Multiline = true;
            this.texCostCount.Name = "texCostCount";
            this.texCostCount.PreventEnterBeep = true;
            this.texCostCount.Size = new System.Drawing.Size(364, 112);
            this.texCostCount.TabIndex = 73;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(10, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(91, 23);
            this.labelX1.TabIndex = 72;
            this.labelX1.Text = "申请备注：";
            // 
            // btnCancelCostApply
            // 
            this.btnCancelCostApply.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelCostApply.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelCostApply.Location = new System.Drawing.Point(306, 143);
            this.btnCancelCostApply.Name = "btnCancelCostApply";
            this.btnCancelCostApply.Size = new System.Drawing.Size(80, 24);
            this.btnCancelCostApply.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelCostApply.Symbol = "";
            this.btnCancelCostApply.SymbolColor = System.Drawing.Color.Red;
            this.btnCancelCostApply.TabIndex = 1;
            this.btnCancelCostApply.Text = "取消";
            this.btnCancelCostApply.Click += new System.EventHandler(this.BtnCancelCostApply_Click);
            // 
            // btnCostApply
            // 
            this.btnCostApply.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCostApply.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCostApply.Location = new System.Drawing.Point(95, 143);
            this.btnCostApply.Name = "btnCostApply";
            this.btnCostApply.Size = new System.Drawing.Size(80, 24);
            this.btnCostApply.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCostApply.Symbol = "";
            this.btnCostApply.SymbolColor = System.Drawing.Color.Green;
            this.btnCostApply.TabIndex = 0;
            this.btnCostApply.Text = "申请";
            this.btnCostApply.Click += new System.EventHandler(this.BtnCostApply_Click);
            // 
            // CostApplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 433);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.DgvCostDetail);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CostApplyForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增费用申请";
            this.Load += new System.EventHandler(this.CostApplyForm_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCostDetail)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem addCostDeatil;
        private DevComponents.DotNetBar.ButtonItem btnRemoveDetail;
        private DevComponents.DotNetBar.Controls.DataGridViewX DgvCostDetail;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX btnCancelCostApply;
        private DevComponents.DotNetBar.ButtonX btnCostApply;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox CmbApprover;
        private DevComponents.DotNetBar.LabelX LblApprover;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX texCostCount;
    }
}