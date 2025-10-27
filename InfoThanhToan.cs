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
    public partial class InfoThanhToan : Form
    {
        private List<DonHangView> danhSachDonHang;
        public ThanhToanView ThanhToanMoi { get; private set; }
        private ThanhToanView thanhToan;
        public InfoThanhToan(ThanhToanView tt, List<DonHangView> dsDonHang)
        {
            InitializeComponent();
            thanhToan = tt;
            danhSachDonHang = dsDonHang ?? new List<DonHangView>();
        }



        private void InfoThanhToan_Load(object sender, EventArgs e)
        {
            string[] dsPTTT = { "Tiền mặt", "Chuyển khoản", "Ví điện tử", "Thẻ ngân hàng" };
            cbPhuongThuc.Items.AddRange(dsPTTT);

            // Danh sách trạng thái thanh toán
            string[] dsTrangThai = { "Chưa thanh toán", "Đã thanh toán", "Đang xử lý", "Đã hủy" };
            cbTrangThai.Items.AddRange(dsTrangThai);

            // Nếu là sửa thì điền sẵn dữ liệu
            if (thanhToan != null)
            {
                txtMa.Text = thanhToan.mathanhtoan;
                txtMaDH.Text = thanhToan.madonhang;
                txtThanhTien.Text = thanhToan.thanhtien.ToString("N0");
                cbPhuongThuc.SelectedItem = thanhToan.phuongthucthanhtoan;
                dtNgayTT.Value = thanhToan.ngaythanhtoan;

                cbTrangThai.SelectedItem = thanhToan.trangthaithanhtoan;
            }
            else
            {
                // Nếu thêm mới
                dtNgayTT.Value = DateTime.Now;
                cbPhuongThuc.SelectedIndex = 0;
                cbTrangThai.SelectedIndex = 0;
            }

        }
        private void btok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) ||
               string.IsNullOrWhiteSpace(txtMaDH.Text) ||
               string.IsNullOrWhiteSpace(txtThanhTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtThanhTien.Text, out double thanhTien))
            {
                MessageBox.Show("Thành tiền không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gán dữ liệu cho ThanhToanMoi
            ThanhToanMoi = new ThanhToanView
            {
                mathanhtoan = txtMa.Text.Trim(),
                madonhang = txtMaDH.Text.Trim(),
                thanhtien = thanhTien,
                phuongthucthanhtoan = cbPhuongThuc.SelectedItem.ToString(),
                ngaythanhtoan = dtNgayTT.Value,
                trangthaithanhtoan = cbTrangThai.SelectedItem.ToString()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtMaDH_TextChanged(object sender, EventArgs e)
        {
            string maDH = txtMaDH.Text.Trim();
            if (string.IsNullOrEmpty(maDH))
            {
                txtThanhTien.Text = "";
                return;
            }

            // Tìm đơn hàng trong danh sách
            var donHang = danhSachDonHang.FirstOrDefault(d => d.madonhang == maDH);
            if (donHang != null)
            {
                double tongTien = donHang.giatrihanghoa + donHang.chiphivanchuyen;
                txtThanhTien.Text = tongTien.ToString("N0");
            }
            else
            {
                txtThanhTien.Text = "Không tìm thấy đơn hàng";
            }
        }
    }
}
