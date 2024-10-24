namespace btap2310
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLmoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMtctiet = new System.Windows.Forms.TextBox();
            this.txtMtngan = new System.Windows.Forms.TextBox();
            this.txtHinhanh = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.lbLoaisp = new System.Windows.Forms.Label();
            this.lbMtchitiet = new System.Windows.Forms.Label();
            this.lbMtngan = new System.Windows.Forms.Label();
            this.lbHinhanh = new System.Windows.Forms.Label();
            this.lbDongia = new System.Windows.Forms.Label();
            this.lbtTensp = new System.Windows.Forms.Label();
            this.lbMasp = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTkiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTimkiem = new System.Windows.Forms.Label();
            this.comboLoaisp = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motachitiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnLmoi);
            this.panel2.Location = new System.Drawing.Point(21, 596);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnLmoi
            // 
            this.btnLmoi.Location = new System.Drawing.Point(3, 33);
            this.btnLmoi.Name = "btnLmoi";
            this.btnLmoi.Size = new System.Drawing.Size(78, 34);
            this.btnLmoi.TabIndex = 0;
            this.btnLmoi.Text = "Làm mới";
            this.btnLmoi.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(99, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 34);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(193, 33);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(288, 33);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 34);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboLoaisp);
            this.groupBox1.Controls.Add(this.txtMtctiet);
            this.groupBox1.Controls.Add(this.txtMtngan);
            this.groupBox1.Controls.Add(this.txtHinhanh);
            this.groupBox1.Controls.Add(this.txtDongia);
            this.groupBox1.Controls.Add(this.txtTensp);
            this.groupBox1.Controls.Add(this.txtMasp);
            this.groupBox1.Controls.Add(this.lbLoaisp);
            this.groupBox1.Controls.Add(this.lbMtchitiet);
            this.groupBox1.Controls.Add(this.lbMtngan);
            this.groupBox1.Controls.Add(this.lbHinhanh);
            this.groupBox1.Controls.Add(this.lbDongia);
            this.groupBox1.Controls.Add(this.lbtTensp);
            this.groupBox1.Controls.Add(this.lbMasp);
            this.groupBox1.Location = new System.Drawing.Point(21, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 553);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // txtMtctiet
            // 
            this.txtMtctiet.Location = new System.Drawing.Point(134, 383);
            this.txtMtctiet.Multiline = true;
            this.txtMtctiet.Name = "txtMtctiet";
            this.txtMtctiet.Size = new System.Drawing.Size(195, 88);
            this.txtMtctiet.TabIndex = 26;
            // 
            // txtMtngan
            // 
            this.txtMtngan.Location = new System.Drawing.Point(134, 311);
            this.txtMtngan.Multiline = true;
            this.txtMtngan.Name = "txtMtngan";
            this.txtMtngan.Size = new System.Drawing.Size(195, 26);
            this.txtMtngan.TabIndex = 25;
            // 
            // txtHinhanh
            // 
            this.txtHinhanh.Location = new System.Drawing.Point(134, 241);
            this.txtHinhanh.Name = "txtHinhanh";
            this.txtHinhanh.Size = new System.Drawing.Size(195, 26);
            this.txtHinhanh.TabIndex = 24;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(134, 167);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(195, 26);
            this.txtDongia.TabIndex = 23;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(134, 96);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(195, 26);
            this.txtTensp.TabIndex = 22;
            // 
            // txtMasp
            // 
            this.txtMasp.Location = new System.Drawing.Point(134, 32);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(119, 26);
            this.txtMasp.TabIndex = 21;
            // 
            // lbLoaisp
            // 
            this.lbLoaisp.AutoSize = true;
            this.lbLoaisp.Location = new System.Drawing.Point(30, 494);
            this.lbLoaisp.Name = "lbLoaisp";
            this.lbLoaisp.Size = new System.Drawing.Size(68, 20);
            this.lbLoaisp.TabIndex = 20;
            this.lbLoaisp.Text = "Loại SP:";
            // 
            // lbMtchitiet
            // 
            this.lbMtchitiet.AutoSize = true;
            this.lbMtchitiet.Location = new System.Drawing.Point(30, 383);
            this.lbMtchitiet.Name = "lbMtchitiet";
            this.lbMtchitiet.Size = new System.Drawing.Size(103, 20);
            this.lbMtchitiet.TabIndex = 19;
            this.lbMtchitiet.Text = "Mô tả chi tiết:";
            // 
            // lbMtngan
            // 
            this.lbMtngan.AutoSize = true;
            this.lbMtngan.Location = new System.Drawing.Point(30, 311);
            this.lbMtngan.Name = "lbMtngan";
            this.lbMtngan.Size = new System.Drawing.Size(93, 20);
            this.lbMtngan.TabIndex = 18;
            this.lbMtngan.Text = "Mô tả ngắn:";
            // 
            // lbHinhanh
            // 
            this.lbHinhanh.AutoSize = true;
            this.lbHinhanh.Location = new System.Drawing.Point(30, 241);
            this.lbHinhanh.Name = "lbHinhanh";
            this.lbHinhanh.Size = new System.Drawing.Size(77, 20);
            this.lbHinhanh.TabIndex = 17;
            this.lbHinhanh.Text = "Hình ảnh:";
            // 
            // lbDongia
            // 
            this.lbDongia.AutoSize = true;
            this.lbDongia.Location = new System.Drawing.Point(30, 167);
            this.lbDongia.Name = "lbDongia";
            this.lbDongia.Size = new System.Drawing.Size(68, 20);
            this.lbDongia.TabIndex = 16;
            this.lbDongia.Text = "Đơn giá:";
            // 
            // lbtTensp
            // 
            this.lbtTensp.AutoSize = true;
            this.lbtTensp.Location = new System.Drawing.Point(30, 96);
            this.lbtTensp.Name = "lbtTensp";
            this.lbtTensp.Size = new System.Drawing.Size(65, 20);
            this.lbtTensp.TabIndex = 15;
            this.lbtTensp.Text = "Tên SP:";
            // 
            // lbMasp
            // 
            this.lbMasp.AutoSize = true;
            this.lbMasp.Location = new System.Drawing.Point(30, 35);
            this.lbMasp.Name = "lbMasp";
            this.lbMasp.Size = new System.Drawing.Size(60, 20);
            this.lbMasp.TabIndex = 14;
            this.lbMasp.Text = "Mã SP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnTkiem);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lbTimkiem);
            this.groupBox2.Location = new System.Drawing.Point(411, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1040, 669);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ Liệu";
            // 
            // btnTkiem
            // 
            this.btnTkiem.Location = new System.Drawing.Point(883, 35);
            this.btnTkiem.Name = "btnTkiem";
            this.btnTkiem.Size = new System.Drawing.Size(100, 38);
            this.btnTkiem.TabIndex = 5;
            this.btnTkiem.Text = "Tìm kiếm";
            this.btnTkiem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(643, 41);
            this.textBox1.TabIndex = 4;
            // 
            // lbTimkiem
            // 
            this.lbTimkiem.AutoSize = true;
            this.lbTimkiem.Location = new System.Drawing.Point(58, 38);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(75, 20);
            this.lbTimkiem.TabIndex = 3;
            this.lbTimkiem.Text = "Tìm kiếm:";
            // 
            // comboLoaisp
            // 
            this.comboLoaisp.FormattingEnabled = true;
            this.comboLoaisp.Location = new System.Drawing.Point(134, 494);
            this.comboLoaisp.Name = "comboLoaisp";
            this.comboLoaisp.Size = new System.Drawing.Size(195, 28);
            this.comboLoaisp.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masp,
            this.Ten,
            this.Dongia,
            this.Hinhanh,
            this.Motangan,
            this.Motachitiet,
            this.Loaisp});
            this.dataGridView1.Location = new System.Drawing.Point(6, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 573);
            this.dataGridView1.TabIndex = 6;
            // 
            // Masp
            // 
            this.Masp.HeaderText = "Masp";
            this.Masp.MinimumWidth = 8;
            this.Masp.Name = "Masp";
            this.Masp.Width = 150;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Ten";
            this.Ten.MinimumWidth = 8;
            this.Ten.Name = "Ten";
            this.Ten.Width = 150;
            // 
            // Dongia
            // 
            this.Dongia.HeaderText = "Dongia";
            this.Dongia.MinimumWidth = 8;
            this.Dongia.Name = "Dongia";
            this.Dongia.Width = 150;
            // 
            // Hinhanh
            // 
            this.Hinhanh.HeaderText = "HInhanh";
            this.Hinhanh.MinimumWidth = 8;
            this.Hinhanh.Name = "Hinhanh";
            this.Hinhanh.Width = 150;
            // 
            // Motangan
            // 
            this.Motangan.HeaderText = "Motangan";
            this.Motangan.MinimumWidth = 8;
            this.Motangan.Name = "Motangan";
            this.Motangan.Width = 150;
            // 
            // Motachitiet
            // 
            this.Motachitiet.HeaderText = "Motachitiet";
            this.Motachitiet.MinimumWidth = 8;
            this.Motachitiet.Name = "Motachitiet";
            this.Motachitiet.Width = 150;
            // 
            // Loaisp
            // 
            this.Loaisp.HeaderText = "Loaisp";
            this.Loaisp.MinimumWidth = 8;
            this.Loaisp.Name = "Loaisp";
            this.Loaisp.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 708);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Thông tin";
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLmoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMtctiet;
        private System.Windows.Forms.TextBox txtMtngan;
        private System.Windows.Forms.TextBox txtHinhanh;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.Label lbLoaisp;
        private System.Windows.Forms.Label lbMtchitiet;
        private System.Windows.Forms.Label lbMtngan;
        private System.Windows.Forms.Label lbHinhanh;
        private System.Windows.Forms.Label lbDongia;
        private System.Windows.Forms.Label lbtTensp;
        private System.Windows.Forms.Label lbMasp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboLoaisp;
        private System.Windows.Forms.Button btnTkiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbTimkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motachitiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loaisp;
    }
}

