namespace BaiTap_2024_10_24
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
            textUserName = new TextBox();
            textPassWord = new TextBox();
            lblUserName = new Label();
            lblPassWord = new Label();
            btnLogIn = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // textUserName
            // 
            textUserName.Location = new Point(174, 122);
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(273, 31);
            textUserName.TabIndex = 0;
            textUserName.TextChanged += textUserName_TextChanged;
            // 
            // textPassWord
            // 
            textPassWord.Location = new Point(174, 210);
            textPassWord.Name = "textPassWord";
            textPassWord.Size = new Size(273, 31);
            textPassWord.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(174, 94);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(129, 25);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "Tên đăng nhập";
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Location = new Point(174, 182);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(86, 25);
            lblPassWord.TabIndex = 3;
            lblPassWord.Text = "Mật khẩu";
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(174, 317);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(112, 34);
            btnLogIn.TabIndex = 4;
            btnLogIn.Text = "Đăng nhập";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(335, 317);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 420);
            Controls.Add(btnExit);
            Controls.Add(btnLogIn);
            Controls.Add(lblPassWord);
            Controls.Add(lblUserName);
            Controls.Add(textPassWord);
            Controls.Add(textUserName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUserName;
        private TextBox textPassWord;
        private Label lblUserName;
        private Label lblPassWord;
        private Button btnLogIn;
        private Button btnExit;
    }
}
