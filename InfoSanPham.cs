using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Winform_detai7.modal;

namespace Test_Winform_detai7
{
    public partial class InfoSanPham : Form
    {
        private SanPhamView sanPham;
        public InfoSanPham(SanPhamView sp)
        {
            InitializeComponent();
            this.sanPham = sp;
        }

        private void InfoSanPham_Load(object sender, EventArgs e)
        {
            txtMa.Text = sanPham.masanpham;
            txtTen.Text = sanPham.tensanpham;
            txtSoLuong.Text = sanPham.soluong.ToString();
            txtGiaTri.Text = sanPham.giatri.ToString();
            txtTinhChat.Text = sanPham.tinhchat;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sanPham.masanpham = txtMa.Text;
            sanPham.tensanpham = txtTen.Text;

            if (int.TryParse(txtSoLuong.Text, out int sl))
                sanPham.soluong = sl;

            if (double.TryParse(txtGiaTri.Text, out double gt))
                sanPham.giatri = gt;

            sanPham.tinhchat = txtTinhChat.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
