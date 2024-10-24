namespace btap1610
{
    public partial class Form1 : Form
    {
        private string input = string.Empty;   // Lưu chuỗi nhập vào từ các nút
        private string operand1 = string.Empty;  // Lưu toán hạng thứ nhất
        private string operand2 = string.Empty;  // Lưu toán hạng thứ hai
        private char operation;  // Lưu phép toán (cộng, trừ, nhân, chia)
        private double result = 0.0;  // Lưu kết quả phép tính
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            input += "2";
            txtKetqua.Text = input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            input += "3";
            txtKetqua.Text = input;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            input += "1";
            txtKetqua.Text = input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            input += "4";
            txtKetqua.Text = input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            input += "5";
            txtKetqua.Text = input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            input += "6";
            txtKetqua.Text = input;
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input += "7";
            txtKetqua.Text = input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            input += "8";
            txtKetqua.Text = input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input += "9";
            txtKetqua.Text = input;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
            txtKetqua.Text = string.Empty;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            input += "0";
            txtKetqua.Text = input;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    txtKetqua.Text = result.ToString();
                    break;
                case '-':
                    result = num1 - num2;
                    txtKetqua.Text = result.ToString();
                    break;
                case '*':
                    result = num1 * num2;
                    txtKetqua.Text = result.ToString();
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        txtKetqua.Text = result.ToString();
                    }
                    else
                    {
                        txtKetqua.Text = "DIV/Zero!";
                    }
                    break;
                default:
                    break;
            }
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }
    }
}
