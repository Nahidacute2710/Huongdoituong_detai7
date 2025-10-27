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
    public partial class InfoKhachNhan : Form
    {
        public KhachNhanView KhachMoiNhan { get; private set; }
        private KhachNhanView khach;
        public InfoKhachNhan(KhachNhanView k)
        {
            InitializeComponent();
            khach = k;
        }


        private void InfoKhachNhan_Load(object sender, EventArgs e)
        {
            if (khach != null)
            {
                txtMaKH.Text = khach.makh;
                txtTenKH.Text = khach.tenkh;
                txtSDT.Text = khach.sodienthoai;
                txtDiaChi.Text = khach.diachikhachnhan;
            }
        }


        private void btok_Click_1(object sender, EventArgs e)
        {
            KhachMoiNhan = new KhachNhanView
            {
                makh = txtMaKH.Text,
                tenkh = txtTenKH.Text,
                sodienthoai = txtSDT.Text,
                diachikhachnhan = txtDiaChi.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
