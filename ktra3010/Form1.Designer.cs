namespace BaiKiemTra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button_Add = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            label_Total = new Label();
            textBox_Total = new TextBox();
            button_Pay = new Button();
            button_Remove = new Button();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column_Name = new DataGridViewTextBoxColumn();
            Column_Image = new DataGridViewTextBoxColumn();
            Column_Price = new DataGridViewTextBoxColumn();
            Column_Quantity = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_Add);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(606, 629);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // button_Add
            // 
            button_Add.Location = new Point(182, 574);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(180, 40);
            button_Add.TabIndex = 1;
            button_Add.Text = "Thêm vào giỏ hàng";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column_Name, Column_Image, Column_Price, Column_Quantity });
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(597, 504);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label_Total);
            groupBox2.Controls.Add(textBox_Total);
            groupBox2.Controls.Add(button_Pay);
            groupBox2.Controls.Add(button_Remove);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(624, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(622, 629);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ hàng";
            // 
            // label_Total
            // 
            label_Total.AutoSize = true;
            label_Total.Location = new Point(244, 414);
            label_Total.Name = "label_Total";
            label_Total.Size = new Size(96, 25);
            label_Total.TabIndex = 5;
            label_Total.Text = "Tổng tiền: ";
            label_Total.Click += label1_Click;
            // 
            // textBox_Total
            // 
            textBox_Total.Location = new Point(358, 408);
            textBox_Total.Name = "textBox_Total";
            textBox_Total.ReadOnly = true;
            textBox_Total.Size = new Size(258, 31);
            textBox_Total.TabIndex = 4;
            // 
            // button_Pay
            // 
            button_Pay.Location = new Point(383, 574);
            button_Pay.Name = "button_Pay";
            button_Pay.Size = new Size(180, 40);
            button_Pay.TabIndex = 3;
            button_Pay.Text = "Thanh toán";
            button_Pay.UseVisualStyleBackColor = true;
            button_Pay.Click += button_Pay_Click;
            // 
            // button_Remove
            // 
            button_Remove.Location = new Point(91, 574);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(180, 40);
            button_Remove.TabIndex = 2;
            button_Remove.Text = "Xóa khỏi giỏ hàng";
            button_Remove.UseVisualStyleBackColor = true;
            button_Remove.Click += button_Remove_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView2.Location = new Point(6, 30);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(610, 362);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Image";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Price";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Column_Name
            // 
            Column_Name.HeaderText = "Name";
            Column_Name.MinimumWidth = 8;
            Column_Name.Name = "Column_Name";
            Column_Name.Width = 150;
            // 
            // Column_Image
            // 
            Column_Image.HeaderText = "Image";
            Column_Image.MinimumWidth = 8;
            Column_Image.Name = "Column_Image";
            Column_Image.Width = 150;
            // 
            // Column_Price
            // 
            Column_Price.HeaderText = "Price";
            Column_Price.MinimumWidth = 8;
            Column_Price.Name = "Column_Price";
            Column_Price.Width = 150;
            // 
            // Column_Quantity
            // 
            Column_Quantity.HeaderText = "Quantity";
            Column_Quantity.MinimumWidth = 8;
            Column_Quantity.Name = "Column_Quantity";
            Column_Quantity.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 653);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button_Add;
        private GroupBox groupBox2;
        private Label label_Total;
        private TextBox textBox_Total;
        private Button button_Pay;
        private Button button_Remove;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column_Name;
        private DataGridViewTextBoxColumn Column_Image;
        private DataGridViewTextBoxColumn Column_Price;
        private DataGridViewTextBoxColumn Column_Quantity;
    }
}
