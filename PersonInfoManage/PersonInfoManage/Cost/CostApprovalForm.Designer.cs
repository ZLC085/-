namespace PersonInfoManage
{
    partial class CostApprovalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.DgvApproval = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.approver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.CmbNextApprover = new System.Windows.Forms.ComboBox();
            this.LblNextApprover = new DevComponents.DotNetBar.LabelX();
            this.BtnFailed = new DevComponents.DotNetBar.ButtonX();
            this.BtnPass = new DevComponents.DotNetBar.ButtonX();
            this.TexOpinion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.DgvCostDetail = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.TexApplicant = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvApproval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCostDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.DgvApproval);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.CmbNextApprover);
            this.panelEx1.Controls.Add(this.LblNextApprover);
            this.panelEx1.Controls.Add(this.BtnFailed);
            this.panelEx1.Controls.Add(this.BtnPass);
            this.panelEx1.Controls.Add(this.TexOpinion);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.DgvCostDetail);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.TexApplicant);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(732, 825);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // DgvApproval
            // 
            this.DgvApproval.AllowUserToAddRows = false;
            this.DgvApproval.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DgvApproval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvApproval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.approver,
            this.result,
            this.time,
            this.remark});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvApproval.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvApproval.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DgvApproval.Location = new System.Drawing.Point(207, 300);
            this.DgvApproval.Name = "DgvApproval";
            this.DgvApproval.ReadOnly = true;
            this.DgvApproval.RowHeadersVisible = false;
            this.DgvApproval.RowHeadersWidth = 51;
            this.DgvApproval.RowTemplate.Height = 27;
            this.DgvApproval.Size = new System.Drawing.Size(436, 230);
            this.DgvApproval.TabIndex = 72;
            // 
            // approver
            // 
            this.approver.HeaderText = "审核人";
            this.approver.MinimumWidth = 6;
            this.approver.Name = "approver";
            this.approver.ReadOnly = true;
            this.approver.Width = 80;
            // 
            // result
            // 
            this.result.HeaderText = "审核结果";
            this.result.MinimumWidth = 6;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Width = 125;
            // 
            // time
            // 
            this.time.HeaderText = "审批时间";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 125;
            // 
            // remark
            // 
            this.remark.HeaderText = "审批意见";
            this.remark.MinimumWidth = 6;
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Width = 125;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.Location = new System.Drawing.Point(59, 296);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(141, 29);
            this.labelX5.TabIndex = 71;
            this.labelX5.Text = "审 批 记 录：";
            // 
            // CmbNextApprover
            // 
            this.CmbNextApprover.FormattingEnabled = true;
            this.CmbNextApprover.Items.AddRange(new object[] {
            "test1",
            "test2",
            "test3"});
            this.CmbNextApprover.Location = new System.Drawing.Point(207, 683);
            this.CmbNextApprover.Margin = new System.Windows.Forms.Padding(4);
            this.CmbNextApprover.Name = "CmbNextApprover";
            this.CmbNextApprover.Size = new System.Drawing.Size(315, 23);
            this.CmbNextApprover.TabIndex = 70;
            this.CmbNextApprover.Text = "请选择一个上级审批人...";
            // 
            // LblNextApprover
            // 
            // 
            // 
            // 
            this.LblNextApprover.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblNextApprover.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblNextApprover.Location = new System.Drawing.Point(57, 683);
            this.LblNextApprover.Margin = new System.Windows.Forms.Padding(4);
            this.LblNextApprover.Name = "LblNextApprover";
            this.LblNextApprover.Size = new System.Drawing.Size(141, 29);
            this.LblNextApprover.TabIndex = 10;
            this.LblNextApprover.Text = "上级 审批人：";
            // 
            // BtnFailed
            // 
            this.BtnFailed.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnFailed.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnFailed.Location = new System.Drawing.Point(373, 738);
            this.BtnFailed.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFailed.Name = "BtnFailed";
            this.BtnFailed.Size = new System.Drawing.Size(107, 31);
            this.BtnFailed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnFailed.Symbol = "";
            this.BtnFailed.SymbolColor = System.Drawing.Color.Red;
            this.BtnFailed.TabIndex = 9;
            this.BtnFailed.Text = "驳回";
            this.BtnFailed.Click += new System.EventHandler(this.BtnFailed_Click);
            // 
            // BtnPass
            // 
            this.BtnPass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnPass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnPass.Location = new System.Drawing.Point(160, 738);
            this.BtnPass.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPass.Name = "BtnPass";
            this.BtnPass.Size = new System.Drawing.Size(107, 31);
            this.BtnPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnPass.Symbol = "";
            this.BtnPass.SymbolColor = System.Drawing.Color.Green;
            this.BtnPass.TabIndex = 8;
            this.BtnPass.Text = "通过";
            this.BtnPass.Click += new System.EventHandler(this.BtnPass_Click);
            // 
            // TexOpinion
            // 
            // 
            // 
            // 
            this.TexOpinion.Border.Class = "TextBoxBorder";
            this.TexOpinion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TexOpinion.Location = new System.Drawing.Point(207, 555);
            this.TexOpinion.Margin = new System.Windows.Forms.Padding(4);
            this.TexOpinion.MaxLength = 200;
            this.TexOpinion.Multiline = true;
            this.TexOpinion.Name = "TexOpinion";
            this.TexOpinion.PreventEnterBeep = true;
            this.TexOpinion.Size = new System.Drawing.Size(315, 93);
            this.TexOpinion.TabIndex = 7;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.Location = new System.Drawing.Point(57, 555);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(141, 29);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "审 批 意 见：";
            // 
            // DgvCostDetail
            // 
            this.DgvCostDetail.AllowUserToAddRows = false;
            this.DgvCostDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCostDetail.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DgvCostDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCostDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCostDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCostDetail.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCostDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DgvCostDetail.Location = new System.Drawing.Point(209, 122);
            this.DgvCostDetail.Margin = new System.Windows.Forms.Padding(4);
            this.DgvCostDetail.Name = "DgvCostDetail";
            this.DgvCostDetail.ReadOnly = true;
            this.DgvCostDetail.RowHeadersVisible = false;
            this.DgvCostDetail.RowHeadersWidth = 51;
            this.DgvCostDetail.RowTemplate.Height = 23;
            this.DgvCostDetail.Size = new System.Drawing.Size(434, 171);
            this.DgvCostDetail.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "费用类别";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "金额";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(59, 122);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(141, 29);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "申请金额详情：";
            // 
            // TexApplicant
            // 
            // 
            // 
            // 
            this.TexApplicant.Border.Class = "TextBoxBorder";
            this.TexApplicant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TexApplicant.CausesValidation = false;
            this.TexApplicant.Enabled = false;
            this.TexApplicant.Location = new System.Drawing.Point(209, 56);
            this.TexApplicant.Margin = new System.Windows.Forms.Padding(4);
            this.TexApplicant.Name = "TexApplicant";
            this.TexApplicant.PreventEnterBeep = true;
            this.TexApplicant.ReadOnly = true;
            this.TexApplicant.Size = new System.Drawing.Size(315, 25);
            this.TexApplicant.TabIndex = 1;
            this.TexApplicant.TabStop = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(59, 56);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(143, 29);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "申   请   人：";
            // 
            // CostApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 825);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CostApprovalForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "审批费用";
            this.Load += new System.EventHandler(this.CostApprovalForm_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvApproval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCostDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX BtnFailed;
        private DevComponents.DotNetBar.ButtonX BtnPass;
        private DevComponents.DotNetBar.Controls.TextBoxX TexOpinion;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.DataGridViewX DgvCostDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX TexApplicant;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX LblNextApprover;
        private System.Windows.Forms.ComboBox CmbNextApprover;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.DataGridViewX DgvApproval;
        private System.Windows.Forms.DataGridViewTextBoxColumn approver;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
    }
}