using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_De_tai_7.modal;
using OOP_De_tai_7.modalview;

namespace OOP_De_tai_7
{
    public partial class InfoThanhToan : Form
    {
        private List<DonHangView> danhSachDonHang;
        public ThanhToanView ThanhToanMoi { get; private set; }
        private ThanhToanView thanhToan;
        private bool isEdit;
        public InfoThanhToan(ThanhToanView tt, List<DonHangView> dsDonHang, bool isEdit = false)
        {
            InitializeComponent();
            thanhToan = tt;
            danhSachDonHang = dsDonHang ?? new List<DonHangView>();
            this.isEdit = isEdit;
        }



        private void InfoThanhToan_Load(object sender, EventArgs e)
        {

            string[] dsPTTT = { "Tiền mặt", "Chuyển khoản", "Ví điện tử", "Thẻ ngân hàng" };
            cbPhuongThuc.Items.AddRange(dsPTTT);

            string[] dsTrangThai = { "Chưa thanh toán", "Đã thanh toán", "Đang xử lý", "Đã hủy" };
            cbTrangThai.Items.AddRange(dsTrangThai);

            cbMaDH.DataSource = danhSachDonHang;
            cbMaDH.DisplayMember = "madonhang";
            cbMaDH.ValueMember = "madonhang";
            if (thanhToan != null)
            {
                txtMa.ReadOnly = true;
                cbMaDH.Enabled = isEdit;
                cbPhuongThuc.Enabled = isEdit;
                dtNgayTT.Enabled = isEdit;
                cbTrangThai.Enabled = isEdit;

                lbTT.Visible = true;
                txtMa.Visible = true;
                txtMa.Text = thanhToan.mathanhtoan;
                cbPhuongThuc.SelectedItem = thanhToan.phuongthucthanhtoan;
                dtNgayTT.Value = thanhToan.ngaythanhtoan;
                cbTrangThai.SelectedItem = thanhToan.trangthaithanhtoan;
                if (!string.IsNullOrEmpty(thanhToan.madonhang))
                    cbMaDH.SelectedValue = thanhToan.madonhang;
                else
                    cbMaDH.SelectedIndex = -1;
            

            }
            else
            {
                txtMa.ReadOnly = true;
                txtMa.Text = TaoMaNgauNhien("TT");
                dtNgayTT.Value = DateTime.Now;
                cbPhuongThuc.SelectedIndex = -1; 
                cbTrangThai.SelectedIndex = -1;  
                cbMaDH.SelectedIndex = -1;

            }

        }
        private void btok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) ||
               string.IsNullOrWhiteSpace(cbMaDH.Text)|| string.IsNullOrWhiteSpace(cbPhuongThuc.Text) ||
                string.IsNullOrWhiteSpace(cbTrangThai.Text))

                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

           

            // Gán dữ liệu cho ThanhToanMoi
            ThanhToanMoi = new ThanhToanView
            {
                mathanhtoan = txtMa.Text.Trim(),
                madonhang = cbMaDH.Text.Trim(),
                phuongthucthanhtoan = cbPhuongThuc.SelectedItem.ToString(),
                ngaythanhtoan = dtNgayTT.Value,
                trangthaithanhtoan = cbTrangThai.SelectedItem.ToString()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtMaDH_TextChanged(object sender, EventArgs e)
        {
            string maDH = cbMaDH.Text.Trim();
          
            // Tìm đơn hàng trong danh sách
            var donHang = danhSachDonHang.FirstOrDefault(d => d.madonhang == maDH);
            
        }
        private static string TaoMaNgauNhien(string prefix)
        {
            Random rand = new Random();
            int number = rand.Next(1, 1000); // 1–999
            return $"{prefix}{number:D3}";   // D3: luôn đủ 3 chữ số
        }
       
    }
}
