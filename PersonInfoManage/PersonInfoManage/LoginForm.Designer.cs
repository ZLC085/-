namespace PersonInfoManage
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.UserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PsdTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginButton = new DevComponents.DotNetBar.ButtonX();
            this.remUserNamecheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.loginTipLabel = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(110, 220);
            this.labelX1.Margin = new System.Windows.Forms.Padding(1);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(79, 25);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "用 户 名：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(110, 270);
            this.labelX2.Margin = new System.Windows.Forms.Padding(1);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(88, 25);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "密    码：";
            // 
            // UserNameTextBox
            // 
            // 
            // 
            // 
            this.UserNameTextBox.Border.Class = "TextBoxBorder";
            this.UserNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.UserNameTextBox.Location = new System.Drawing.Point(200, 220);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PreventEnterBeep = true;
            this.UserNameTextBox.Size = new System.Drawing.Size(196, 21);
            this.UserNameTextBox.TabIndex = 2;
            // 
            // PsdTextBox
            // 
            // 
            // 
            // 
            this.PsdTextBox.Border.Class = "TextBoxBorder";
            this.PsdTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PsdTextBox.Location = new System.Drawing.Point(200, 270);
            this.PsdTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.PsdTextBox.Name = "PsdTextBox";
            this.PsdTextBox.PasswordChar = '*';
            this.PsdTextBox.PreventEnterBeep = true;
            this.PsdTextBox.Size = new System.Drawing.Size(196, 21);
            this.PsdTextBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PersonInfoManage.Properties.Resources.警徽01;
            this.pictureBox1.Location = new System.Drawing.Point(100, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.LoginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.LoginButton.Location = new System.Drawing.Point(184, 350);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(1);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(150, 30);
            this.LoginButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "登    录";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // remUserNamecheckBox
            // 
            // 
            // 
            // 
            this.remUserNamecheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.remUserNamecheckBox.Location = new System.Drawing.Point(110, 311);
            this.remUserNamecheckBox.Margin = new System.Windows.Forms.Padding(1);
            this.remUserNamecheckBox.Name = "remUserNamecheckBox";
            this.remUserNamecheckBox.Size = new System.Drawing.Size(73, 13);
            this.remUserNamecheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.remUserNamecheckBox.TabIndex = 7;
            this.remUserNamecheckBox.Text = "记住用户名";
            // 
            // loginTipLabel
            // 
            // 
            // 
            // 
            this.loginTipLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.loginTipLabel.ForeColor = System.Drawing.Color.Red;
            this.loginTipLabel.Location = new System.Drawing.Point(200, 311);
            this.loginTipLabel.Margin = new System.Windows.Forms.Padding(1);
            this.loginTipLabel.Name = "loginTipLabel";
            this.loginTipLabel.Size = new System.Drawing.Size(110, 17);
            this.loginTipLabel.TabIndex = 8;
            this.loginTipLabel.Text = "提示";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(100, 24);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(316, 23);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "重点人员信息管理系统";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.loginTipLabel);
            this.Controls.Add(this.remUserNamecheckBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PsdTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX UserNameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX PsdTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX LoginButton;
        private DevComponents.DotNetBar.Controls.CheckBoxX remUserNamecheckBox;
        private DevComponents.DotNetBar.LabelX loginTipLabel;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}