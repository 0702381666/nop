namespace Baikiemtra2011
{
    partial class DanhmucSanpham
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
            this.dataGridViewSanpham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSanpham
            // 
            this.dataGridViewSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanpham.Location = new System.Drawing.Point(23, 12);
            this.dataGridViewSanpham.Name = "dataGridViewSanpham";
            this.dataGridViewSanpham.RowHeadersWidth = 62;
            this.dataGridViewSanpham.RowTemplate.Height = 28;
            this.dataGridViewSanpham.Size = new System.Drawing.Size(749, 398);
            this.dataGridViewSanpham.TabIndex = 0;
            this.dataGridViewSanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanpham_CellContentClick);
            // 
            // DanhmucSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSanpham);
            this.Name = "DanhmucSanpham";
            this.Text = "DanhmucSanpham";
            this.Load += new System.EventHandler(this.DanhmucSanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanpham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSanpham;
    }
}