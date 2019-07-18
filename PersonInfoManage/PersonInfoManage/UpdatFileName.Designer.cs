namespace PersonInfoManage
{
    partial class UpdatFileName
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
            this.btnUpdateFileName = new DevComponents.DotNetBar.ButtonX();
            this.btn = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtOldFileName = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateFileName
            // 
            this.btnUpdateFileName.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdateFileName.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdateFileName.Location = new System.Drawing.Point(120, 260);
            this.btnUpdateFileName.Name = "btnUpdateFileName";
            this.btnUpdateFileName.Size = new System.Drawing.Size(80, 25);
            this.btnUpdateFileName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdateFileName.Symbol = "";
            this.btnUpdateFileName.SymbolColor = System.Drawing.Color.Green;
            this.btnUpdateFileName.TabIndex = 4;
            this.btnUpdateFileName.Text = "修改";
            // 
            // btn
            // 
            this.btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn.Location = new System.Drawing.Point(280, 260);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(80, 25);
            this.btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn.Symbol = "";
            this.btn.SymbolColor = System.Drawing.Color.Red;
            this.btn.TabIndex = 5;
            this.btn.Text = "取消";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.txtOldFileName);
            this.panelEx1.Controls.Add(this.btnUpdateFileName);
            this.panelEx1.Controls.Add(this.textBoxX1);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(484, 315);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 6;
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(195, 163);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(176, 21);
            this.textBoxX1.TabIndex = 2;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(103, 163);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "修改为：";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(103, 86);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(90, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "原文件名：";
            // 
            // txtOldFileName
            // 
            // 
            // 
            // 
            this.txtOldFileName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOldFileName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOldFileName.Location = new System.Drawing.Point(220, 85);
            this.txtOldFileName.Name = "txtOldFileName";
            this.txtOldFileName.Size = new System.Drawing.Size(75, 23);
            this.txtOldFileName.TabIndex = 3;
            this.txtOldFileName.Text = "labelX3";
            // 
            // UpdatFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 315);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.panelEx1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdatFileName";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "修改文件名";
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnUpdateFileName;
        private DevComponents.DotNetBar.ButtonX btn;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX txtOldFileName;
    }
}