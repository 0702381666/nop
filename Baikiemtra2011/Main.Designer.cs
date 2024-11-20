namespace Baikiemtra2011
{
    partial class Main
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
            this.Danhmucsanpham = new System.Windows.Forms.MenuStrip();
            this.danhMụcSảmPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Danhmucsanpham.SuspendLayout();
            this.SuspendLayout();
            // 
            // Danhmucsanpham
            // 
            this.Danhmucsanpham.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Danhmucsanpham.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Danhmucsanpham.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcSảmPhẩmToolStripMenuItem,
            this.danhMụcKháchHàngToolStripMenuItem,
            this.đơnHàngToolStripMenuItem});
            this.Danhmucsanpham.Location = new System.Drawing.Point(0, 0);
            this.Danhmucsanpham.Name = "Danhmucsanpham";
            this.Danhmucsanpham.Size = new System.Drawing.Size(1001, 33);
            this.Danhmucsanpham.TabIndex = 1;
            this.Danhmucsanpham.Text = "Danh mục sản phẩm";
            // 
            // danhMụcSảmPhẩmToolStripMenuItem
            // 
            this.danhMụcSảmPhẩmToolStripMenuItem.Name = "danhMụcSảmPhẩmToolStripMenuItem";
            this.danhMụcSảmPhẩmToolStripMenuItem.Size = new System.Drawing.Size(203, 29);
            this.danhMụcSảmPhẩmToolStripMenuItem.Text = "Danh mục sảm phẩm ";
            this.danhMụcSảmPhẩmToolStripMenuItem.Click += new System.EventHandler(this.danhMụcSảmPhẩmToolStripMenuItem_Click);
            // 
            // danhMụcKháchHàngToolStripMenuItem
            // 
            this.danhMụcKháchHàngToolStripMenuItem.Name = "danhMụcKháchHàngToolStripMenuItem";
            this.danhMụcKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(205, 29);
            this.danhMụcKháchHàngToolStripMenuItem.Text = "Danh mục khách hàng";
            this.danhMụcKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.danhMụcKháchHàngToolStripMenuItem_Click);
            // 
            // đơnHàngToolStripMenuItem
            // 
            this.đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            this.đơnHàngToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.đơnHàngToolStripMenuItem.Text = "Đơn hàng";
            this.đơnHàngToolStripMenuItem.Click += new System.EventHandler(this.đơnHàngToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 537);
            this.Controls.Add(this.Danhmucsanpham);
            this.MainMenuStrip = this.Danhmucsanpham;
            this.Name = "Main";
            this.Text = "Main";
            this.Danhmucsanpham.ResumeLayout(false);
            this.Danhmucsanpham.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Danhmucsanpham;
        private System.Windows.Forms.ToolStripMenuItem danhMụcSảmPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
    }
}