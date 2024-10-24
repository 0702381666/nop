namespace BaiTap_2024_10_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userName = textUserName.Text;
            string passWord = textPassWord.Text;
            if (userName == "admin" && passWord == "1234")
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //đóng ứng dụng
            this.Close();
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {
      
        }
    }
}
