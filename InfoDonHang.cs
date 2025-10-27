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
    public partial class InfoDonHang : Form
    {
        private List<SanPhamView> dsSanPham = new();
        private DonHangView donHang;
        private List<KhachNhanView> khachHangList;
        private KhachNhanView khachNhan;
        public DonHangView DonHangMoi { get; private set; }
        public InfoDonHang(DonHangView donHang, List<KhachNhanView> khachHangList)
        {
            InitializeComponent();

            this.donHang = donHang ?? new DonHangView();
            this.khachHangList = khachHangList ?? new List<KhachNhanView>();

            if (!string.IsNullOrEmpty(donHang.makhachnhan))
            {
                khachNhan = this.khachHangList.FirstOrDefault(k => k.makh == donHang.makhachnhan);
            }

            if (donHang.danhsachsanpham == null)
            {
                donHang.danhsachsanpham = new List<SanPhamView>();
            }
            txtKhachNhan.TextChanged += txtKhachNhan_TextChanged;
        }

        private void InfoDonHang_Load(object sender, EventArgs e)
        {
            if (donHang != null)
            {
                txtMa.Text = donHang.madonhang;
                txtKhachGui.Text = donHang.makhachgui;
                txtKhachNhan.Text = donHang.makhachnhan;
                txtPhiVC.Text = donHang.chiphivanchuyen.ToString();
                if (khachNhan != null)
                {
                    txtSDT.Text = khachNhan.sodienthoai;
                }
                else
                {
                    txtSDT.Text = "Không tìm thấy";
                }
                // Gán ngày đặt đơn (nếu có sẵn thì lấy từ đơn hàng)
                if (donHang.ngaytao != DateTime.MinValue)
                {
                    dtNgayDat.Value = donHang.ngaytao;
                }
                else
                {
                    dtNgayDat.Value = DateTime.Now;
                }

                string[] trangThaiList = { "Đang tạo", "Đang xử lý", "Đang giao", "Đã giao", "Đã hủy" };
                cbTT.Items.Clear();
                cbTT.Items.AddRange(trangThaiList);
                var trangThaiChon = trangThaiList.FirstOrDefault(tt =>
                    !string.IsNullOrEmpty(donHang.TrangThai) &&
                    string.Equals(tt, donHang.TrangThai, StringComparison.OrdinalIgnoreCase));

                if (trangThaiChon != null)
                {
                    cbTT.SelectedItem = trangThaiChon;
                }
                else
                {
                    cbTT.SelectedIndex = 0;
                }

                // Hiển thị danh sách sản phẩm / hàng hóa của đơn hàng
                dgvSanPham.DataSource = null;
                dgvSanPham.DataSource = donHang.danhsachsanpham;

                // Tính ngày giao dự kiến ban đầu
                dtNgayGiao.Value = dtNgayDat.Value.AddDays(5);
                double tongTien = donHang.giatrihanghoa + donHang.chiphivanchuyen;
                txtTongTien.Text = tongTien.ToString("N0");
            }
        }


        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow?.DataBoundItem is SanPhamView sanPham)
            {
                InfoSanPham formThongTinSanPham = new InfoSanPham(sanPham);
                formThongTinSanPham.ShowDialog();
            }
        }

        private void dtNgayGiao_ValueChanged(object sender, EventArgs e)
        {
            dtNgayGiao.Value = dtNgayDat.Value.AddDays(5);
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= donHang.danhsachsanpham.Count)
                return;

            // Lấy sản phẩm tương ứng
            var sp = donHang.danhsachsanpham[e.RowIndex];
            if (sp == null)
                return;

            // Mở form chi tiết sản phẩm
            InfoSanPham form = new InfoSanPham(sp);
            form.ShowDialog();
        }

        private void txtKhachGui_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < donHang.danhsachsanpham.Count)
            {
                SanPhamView sp = donHang.danhsachsanpham[e.RowIndex];
                InfoSanPham form = new InfoSanPham(sp);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Làm mới lại DataGridView sau khi chỉnh sửa
                    dgvSanPham.DataSource = null;
                    dgvSanPham.DataSource = donHang.danhsachsanpham;
                    CapNhatTongTien();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm hợp lệ!");
            }

        }
        private void CapNhatTongTien()
        {
            double tongHangHoa = donHang.danhsachsanpham.Sum(sp => sp.giatri);
            double tongTien = tongHangHoa + donHang.chiphivanchuyen;
            txtTongTien.Text = tongTien.ToString("N0");
        }

        private void btok_Click(object sender, EventArgs e)
        {
            DonHangMoi = new DonHangView
            {
                madonhang = txtMa.Text.Trim(),
                makhachgui = txtKhachGui.Text.Trim(),
                makhachnhan = txtKhachNhan.Text.Trim(),
                chiphivanchuyen = double.TryParse(txtPhiVC.Text, out double phiVC) ? phiVC : 0,
                ngaytao = dtNgayDat.Value,
                danhsachsanpham = donHang.danhsachsanpham,
                TrangThai = cbTT.SelectedItem.ToString()
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            SanPhamView spMoi = new SanPhamView(); // tạo đối tượng trống
            InfoSanPham form = new InfoSanPham(spMoi);

            if (form.ShowDialog() == DialogResult.OK)
            {
                // thêm sản phẩm vào danh sách
                donHang.danhsachsanpham.Add(spMoi);

                // làm mới lại lưới
                dgvSanPham.DataSource = null;
                dgvSanPham.DataSource = donHang.danhsachsanpham;
                CapNhatTongTien();
            }
        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow?.DataBoundItem is SanPhamView sp)
            {
                InfoSanPham form = new InfoSanPham(sp);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    dgvSanPham.DataSource = null;
                    dgvSanPham.DataSource = donHang.danhsachsanpham;
                    CapNhatTongTien();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow?.DataBoundItem is SanPhamView sp)
            {
                var confirm = MessageBox.Show(
                    $"Bạn có chắc muốn xóa sản phẩm '{sp.tensanpham}' không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    donHang.danhsachsanpham.Remove(sp);
                    dgvSanPham.DataSource = null;
                    dgvSanPham.DataSource = donHang.danhsachsanpham;
                    CapNhatTongTien();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtKhachNhan_TextChanged(object sender, EventArgs e)
        {
            string maKhach = txtKhachNhan.Text.Trim();
            khachNhan = khachHangList.FirstOrDefault(k => k.makh.Equals(maKhach, StringComparison.OrdinalIgnoreCase));

            if (khachNhan != null)
            {
                txtSDT.Text = khachNhan.sodienthoai;
                txtDC.Text = khachNhan.diachikhachnhan;
            }
            else
            {
                txtSDT.Text = "Không tìm thấy";
                txtDC.Text = "";
            }
        }
    }
}
