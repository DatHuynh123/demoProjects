namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khuVựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuHienThi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đóngTrangHiệnTạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngTấtCảTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabHienThi = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.contextMenuHienThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.khuVựcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // khuVựcToolStripMenuItem
            // 
            this.khuVựcToolStripMenuItem.Name = "khuVựcToolStripMenuItem";
            this.khuVựcToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.khuVựcToolStripMenuItem.Text = "Khu Vực";
            // 
            // contextMenuHienThi
            // 
            this.contextMenuHienThi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đóngTrangHiệnTạiToolStripMenuItem,
            this.đóngTấtCảTrangToolStripMenuItem});
            this.contextMenuHienThi.Name = "contextMenuHienThi";
            this.contextMenuHienThi.Size = new System.Drawing.Size(185, 48);
            // 
            // đóngTrangHiệnTạiToolStripMenuItem
            // 
            this.đóngTrangHiệnTạiToolStripMenuItem.Name = "đóngTrangHiệnTạiToolStripMenuItem";
            this.đóngTrangHiệnTạiToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.đóngTrangHiệnTạiToolStripMenuItem.Text = "Đóng Trang Hiện Tại";
            // 
            // đóngTấtCảTrangToolStripMenuItem
            // 
            this.đóngTấtCảTrangToolStripMenuItem.Name = "đóngTấtCảTrangToolStripMenuItem";
            this.đóngTấtCảTrangToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.đóngTấtCảTrangToolStripMenuItem.Text = "Đóng Tất Cả Trang";
            // 
            // tabHienThi
            // 
            this.tabHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHienThi.Location = new System.Drawing.Point(0, 24);
            this.tabHienThi.Name = "tabHienThi";
            this.tabHienThi.SelectedIndex = 0;
            this.tabHienThi.Size = new System.Drawing.Size(788, 237);
            this.tabHienThi.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 261);
            this.Controls.Add(this.tabHienThi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuHienThi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khuVựcToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuHienThi;
        private System.Windows.Forms.ToolStripMenuItem đóngTrangHiệnTạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngTấtCảTrangToolStripMenuItem;
        private System.Windows.Forms.TabControl tabHienThi;
    }
}

