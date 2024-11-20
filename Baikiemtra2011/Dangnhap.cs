using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baikiemtra2011
{
    public partial class Dangnhap : Form
    {
        Connect db = new Connect();
        //private SqlConnection conn;

        public Dangnhap()
        {
            InitializeComponent();
        }

        public void getData()
        {
            string query = "select * from Nguoidung";
            DataSet ds = db.Laydulieu(query);
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string user = txtTendangnhap.Text;
            string pass = txtMatkhau.Text;

            if (KiemTraDangNhap(user, pass))
            {
                MessageBox.Show("Bạn đã đăng nhập thành công ");
                txtTendangnhap.Clear();
                txtMatkhau.Clear();

                Main Mainform = new Main();
                Mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui long nhap lai day du thong tin .");
                txtTendangnhap.Focus(); // di chuyen ve hang 
            }
        }
        private bool KiemTraDangNhap(string username, string password)
        {
            string truyvan = "SELECT COUNT(*) FROM Nguoidung WHERE Tendangnhap = @username AND Matkhau = @password";

            using (SqlCommand cmd = new SqlCommand(truyvan, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    db.GetConnection().Open();
                    int result = Convert.ToInt32(cmd.ExecuteScalar()); // Executes query and gets the first column of the first row
                    db.GetConnection().Close();

                    return result > 0; // If result > 0, login is successful
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
