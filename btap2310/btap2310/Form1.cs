using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btap2310
{
    public partial class Form1 : Form
    {
        private List<SanPham> danhSachSanPham = new SanPham();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các TextBox và ComboBox
                string maSP = txtMasp.Text; // Lấy mã sản phẩm từ TextBox
                string tenSP = txtTensp.Text;
                decimal donGia;
                if (!decimal.TryParse(txtDongia.Text, out donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ.");
                    return;
                }
                string hinhAnh = txtHinhanh.Text;
                string moTaNgan = txtMtngan.Text;
                string moTaChiTiet = txtMtctiet.Text;
                string loaiSP = comboLoaisp.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(loaiSP))
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm.");
                    return;
                }

                // Tạo đối tượng SanPham và thêm vào danh sách
                SanPham sanPham = new SanPham()
                {
                    MaSP = maSP,
                    TenSP = tenSP,
                    DonGia = donGia,
                    HinhAnh = hinhAnh,
                    MoTaNgan = moTaNgan,
                    MoTaChiTiet = moTaChiTiet,
                    LoaiSP = loaiSP
                };

                danhSachSanPham.Add(sanPham); // Thêm sản phẩm vào danh sách

                // Insert db

                // Cập nhật lại DataGridView
                dataGridView1.DataSource = null; // Đặt lại nguồn dữ liệu để làm mới
                dataGridView1.DataSource = danhSachSanPham; // Cập nhật nguồn dữ liệu

                // query db => set datasource

                // Xóa các TextBox và ComboBox
                txtMasp.Clear();
                txtTensp.Clear();
                txtDongia.Clear();
                txtHinhanh.Clear();
                txtMtngan.Clear();
                txtMtctiet.Clear();
                comboLoaisp.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Lấy mã sản phẩm của dòng đang được chọn
                    string maSP = dataGridView1.CurrentRow.Cells["MaSP"].Value.ToString();

                    // Tìm sản phẩm theo mã
                    SanPham sanPham = danhSachSanPham.Find(p => p.MaSP == maSP);

                    if (sanPham != null)
                    {
                        // Cập nhật thông tin sản phẩm
                        sanPham.TenSP = txtTensp.Text;
                        sanPham.DonGia = decimal.Parse(txtDongia.Text);
                        sanPham.HinhAnh = txtHinhanh.Text;
                        sanPham.MoTaNgan = txtMtngan.Text;
                        sanPham.MoTaChiTiet = txtMtctiet.Text;
                        sanPham.LoaiSP = comboLoaisp.SelectedItem?.ToString();

                        CapNhatDataGridView(); // Cập nhật lại DataGridView
                        LamMoiForm(); // Làm mới form sau khi sửa
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Lấy mã sản phẩm của dòng đang được chọn
                    string maSP = dataGridView1.CurrentRow.Cells["MaSP"].Value.ToString();

                    // Xóa sản phẩm khỏi danh sách
                    danhSachSanPham.RemoveAll(p => p.MaSP == maSP);

                    CapNhatDataGridView(); // Cập nhật lại DataGridView
                    LamMoiForm(); // Làm mới form sau khi xóa
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void CapNhatDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachSanPham;
        }

        // Làm mới form, xóa toàn bộ thông tin trong các TextBox và ComboBox
        private void LamMoiForm()
        {
            txtMasp.Clear();
            txtTensp.Clear();
            txtDongia.Clear();
            txtHinhanh.Clear();
            txtMtngan.Clear();
            txtMtctiet.Clear();
            comboLoaisp.SelectedIndex = -1;
        }

        // Khi chọn một dòng trên DataGridView, hiển thị dữ liệu lên form
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy sản phẩm từ danh sách dựa trên dòng được chọn
                SanPham sanPham = danhSachSanPham[e.RowIndex];

                // Hiển thị thông tin sản phẩm lên form
                txtMasp.Text = sanPham.MaSP;
                txtTensp.Text = sanPham.TenSP;
                txtDongia.Text = sanPham.DonGia.ToString();
                txtHinhanh.Text = sanPham.HinhAnh;
                txtMtngan.Text = sanPham.MoTaNgan;
                txtMtctiet.Text = sanPham.MoTaChiTiet;
                comboLoaisp.SelectedItem = sanPham.LoaiSP;
            }
        }
    }
}
