﻿namespace PersonInfoManage
{
    partial class UpdateFileName
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
            this.BtnCancel = new DevComponents.DotNetBar.ButtonX();
            this.BtnUpdateFile = new DevComponents.DotNetBar.ButtonX();
            this.TxtNewFileName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.LblFileName = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.BtnCancel);
            this.panelEx1.Controls.Add(this.BtnUpdateFile);
            this.panelEx1.Controls.Add(this.TxtNewFileName);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.LblFileName);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(484, 255);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // BtnCancel
            // 
            this.BtnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnCancel.Location = new System.Drawing.Point(276, 186);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnCancel.Symbol = "";
            this.BtnCancel.SymbolColor = System.Drawing.Color.Red;
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnUpdateFile
            // 
            this.BtnUpdateFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnUpdateFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnUpdateFile.Location = new System.Drawing.Point(117, 186);
            this.BtnUpdateFile.Name = "BtnUpdateFile";
            this.BtnUpdateFile.Size = new System.Drawing.Size(80, 25);
            this.BtnUpdateFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnUpdateFile.Symbol = "";
            this.BtnUpdateFile.SymbolColor = System.Drawing.Color.Green;
            this.BtnUpdateFile.TabIndex = 4;
            this.BtnUpdateFile.Text = "确定";
            this.BtnUpdateFile.Click += new System.EventHandler(this.BtnUpdateFile_Click);
            // 
            // TxtNewFileName
            // 
            // 
            // 
            // 
            this.TxtNewFileName.Border.Class = "TextBoxBorder";
            this.TxtNewFileName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtNewFileName.Location = new System.Drawing.Point(195, 112);
            this.TxtNewFileName.Name = "TxtNewFileName";
            this.TxtNewFileName.PreventEnterBeep = true;
            this.TxtNewFileName.Size = new System.Drawing.Size(194, 21);
            this.TxtNewFileName.TabIndex = 3;
            this.TxtNewFileName.TextChanged += new System.EventHandler(this.TxtNewFileName_TextChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(86, 111);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(85, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "修 改 为：";
            // 
            // LblFileName
            // 
            // 
            // 
            // 
            this.LblFileName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblFileName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblFileName.Location = new System.Drawing.Point(211, 49);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(85, 23);
            this.LblFileName.TabIndex = 1;
            this.LblFileName.Text = "加载内容";
            this.LblFileName.Click += new System.EventHandler(this.LblFileName_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(86, 49);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(85, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "原文件名：";
            // 
            // UpdateFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 255);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateFileName";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改文件名";
            this.Load += new System.EventHandler(this.UpdateFileName_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX BtnCancel;
        private DevComponents.DotNetBar.ButtonX BtnUpdateFile;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtNewFileName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX LblFileName;
    }
}