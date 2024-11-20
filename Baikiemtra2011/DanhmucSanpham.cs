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
    public partial class DanhmucSanpham : Form
    {
        public DanhmucSanpham()
        {
            InitializeComponent();
            dataGridViewSanpham.CellClick += dataGridViewSanpham_CellContentClick;
        }
        Connect db = new Connect();
        public void getData()
        {
            string query = "select * from Khachhang";
            DataSet ds = db.Laydulieu(query);
            dataGridViewSanpham.DataSource = ds.Tables[0];
        }

        private void DanhmucSanpham_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void dataGridViewSanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
