using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baikiemtra2011
{
    public partial class DanhmucKhachhang : Form
    {
        public DanhmucKhachhang()
        {
            InitializeComponent();
            dataGridViewKhachhang.CellClick += dataGridViewKhachhang_CellContentClick;
        }
        Connect db = new Connect();
        public void getData()
        {
            string query = "select * from Khachhang";
            DataSet ds = db.Laydulieu(query);
            dataGridViewKhachhang.DataSource = ds.Tables[0];
        }

        private void dataGridViewKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DanhmucKhachhang_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
