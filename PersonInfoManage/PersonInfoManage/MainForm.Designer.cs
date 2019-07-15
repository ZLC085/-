namespace PersonInfoManage
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dockContainerItem5 = new DevComponents.DotNetBar.DockContainerItem();
            this.SuspendLayout();
            // 
            // dockContainerItem5
            // 
            this.dockContainerItem5.Name = "dockContainerItem5";
            this.dockContainerItem5.Text = "dockContainerItem5";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1269, 883);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "重点人员信息管理系统";
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem5;
    }
}

