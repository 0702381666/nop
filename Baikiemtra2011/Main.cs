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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void danhMụcSảmPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Visible = false;
            }

            foreach (Form form in this.MdiChildren)
            {
                if (form is DanhmucSanpham)
                {
                    form.Visible = true;
                    form.Activate();
                    return;
                }
            }

            DanhmucSanpham kh = new DanhmucSanpham();
            kh.MdiParent = this;
            kh.Show();

            
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ẩn các form khác
            foreach (Form form in this.MdiChildren)
            {
                form.Visible = false;
            }

            foreach (Form form in this.MdiChildren)
            {
                if (form is DanhmucKhachhang)
                {
                    form.Visible = true;
                    form.Activate();
                    return;
                }
            }

            DanhmucKhachhang kh = new DanhmucKhachhang();
            kh.MdiParent = this;
           kh.Show();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ẩn các form khác
            foreach (Form form in this.MdiChildren)
            {
                form.Visible = false;
            }

                foreach (Form form in this.MdiChildren)
            {
                if (form is Donhang)
                {
                    form.Visible = true;
                    form.Activate();
                    return;
                }
            }
            Donhang donHangForm = new Donhang();
            donHangForm.MdiParent = this;
            donHangForm.Show();
        }
    }
}
