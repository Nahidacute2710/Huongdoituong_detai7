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
    public partial class InfoDonHang : Form
    {
        private List<SanPhamView> dsSanPham = new();
        private DonHangView donHang;
        private List<KhachGuiView> khachGuiList;
        private List<KhachNhanView> khachNhanList;
        private KhachNhanView khachNhan;
        private bool isEdit;
        public DonHangView DonHangMoi { get; private set; }
        public InfoDonHang(DonHangView donHang, List<KhachNhanView> khachNhanList, List<SanPhamView> dsSanPham, List<KhachGuiView> khachGuiList, bool isEdit = false)
        {
            InitializeComponent();

            this.donHang = donHang ?? new DonHangView();
            this.khachGuiList = khachGuiList ?? new List<KhachGuiView>();
            this.khachNhanList = khachNhanList ?? new List<KhachNhanView>();
            this.dsSanPham = dsSanPham ?? new List<SanPhamView>();
            this.isEdit = isEdit;
            if (!string.IsNullOrEmpty(donHang.makhachnhan))
            {
                khachNhan = this.khachNhanList.FirstOrDefault(k => k.makh == donHang.makhachnhan);
            }

            if (dsSanPham == null)
            {
                dsSanPham = new List<SanPhamView>();
            }
            cbKhachNhan.SelectedIndexChanged += cbKhachNhan_SelectedIndexChanged;
            cbSort.Items.AddRange(new string[] {
                "Tên (A → Z)",
                "Tên (Z → A)",
                "Mã (A → Z)",
                "Mã (Z → A)"
            });
            cbSort.SelectedIndex = 0;
            this.isEdit = isEdit;
        }

        private void InfoDonHang_Load(object sender, EventArgs e)
        {

            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbKhachGui.DataSource = khachGuiList;
            cbKhachGui.DisplayMember = "tenkh";
            cbKhachGui.ValueMember = "makh";

            cbKhachNhan.DataSource = khachNhanList;
            cbKhachNhan.DisplayMember = "tenkh";
            cbKhachNhan.ValueMember = "makh";

            cbTT.Items.Clear();
            string[] trangThaiList = { "Đang tạo", "Đang xử lý", "Đang giao", "Đã giao", "Đã hủy" };
            cbTT.Items.AddRange(trangThaiList);

            cbKhachNhan.SelectedIndexChanged += (s, ev) =>
            {
                if (cbKhachNhan.SelectedItem is KhachNhanView khachNhan)
                {
                    txtSDT.Text = khachNhan.sodienthoai;
                    txtDC.Text = khachNhan.diachikhachnhan;
                }
            };


            if (donHang != null && !string.IsNullOrEmpty(donHang.madonhang))
            {
                lbMadh.Visible = true;
                txtMa.Visible = true;
                txtMa.ReadOnly = true;
                txtMa.Text = donHang.madonhang;

                cbKhachGui.SelectedValue = donHang.makhachgui;
                cbKhachNhan.SelectedValue = donHang.makhachnhan;


                dtNgayDat.Value = donHang.ngaytao != DateTime.MinValue ? donHang.ngaytao : DateTime.Now;

                var trangThaiChon = trangThaiList.FirstOrDefault(tt =>
                    !string.IsNullOrEmpty(donHang.TrangThai) &&
                    string.Equals(tt, donHang.TrangThai, StringComparison.OrdinalIgnoreCase));
                cbTT.SelectedItem = trangThaiChon ?? trangThaiList[0];


                var dsSanPhamTheoDon = dsSanPham
                    .Where(sp => sp.madonhang == donHang.madonhang)
                    .ToList();

                donHang.danhsachsanpham = dsSanPhamTheoDon;
                dgvSanPham.DataSource = null;
                dgvSanPham.DataSource = dsSanPhamTheoDon;

                dtNgayGiao.Value = dtNgayDat.Value.AddDays(5);
                if (dgvSanPham.Columns["picSanpham"] != null)
                    dgvSanPham.Columns["picSanpham"].Visible = false;
            }

            else
            {
                txtMa.ReadOnly = true;
                txtMa.Text = TaoMaNgauNhien("DH");

                txtSDT.Clear();
                txtDC.Clear();

                cbKhachGui.SelectedIndex = -1;
                cbKhachNhan.SelectedIndex = -1;
                cbTT.SelectedIndex = -1;

                dtNgayDat.Value = DateTime.Now;
                dtNgayGiao.Value = dtNgayDat.Value.AddDays(5);
                dgvSanPham.DataSource = null;
            
                
            }
            if (!isEdit)
            {
                txtMa.ReadOnly = !isEdit;
                cbKhachGui.Enabled = !isEdit;
                cbKhachNhan.Enabled = !isEdit;
                txtSDT.ReadOnly = !isEdit;
                cbKhachGui.Enabled = isEdit;
                cbKhachNhan.Enabled = isEdit;
                dtNgayDat.Enabled = isEdit;
                dtNgayGiao.Enabled = false;
                txtDC.ReadOnly = !isEdit;
                cbTT.Enabled = isEdit;

                btnThemSanPham.Visible = false;
                btnSuaSanPham.Visible = false;
                btnXoaSanPham.Visible = false;

                dgvSanPham.ReadOnly = true;
                dgvSanPham.AllowUserToAddRows = false;
                dgvSanPham.AllowUserToDeleteRows = false;
            }
        }


        private void dtNgayGiao_ValueChanged(object sender, EventArgs e)
        {
            dtNgayGiao.Value = dtNgayDat.Value.AddDays(5);
        }

        private void dgvSanPham_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (donHang == null || donHang.danhsachsanpham == null)
                return;

            var dsSanPhamTheoDon = donHang.danhsachsanpham;

            if (e.RowIndex >= 0 && e.RowIndex < dsSanPhamTheoDon.Count)
            {
                SanPhamView sp = dsSanPhamTheoDon[e.RowIndex];
                InfoSanPham form = new InfoSanPham(sp, false);
                form.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật lại hiển thị đúng sản phẩm của đơn này
                    dgvSanPham.DataSource = null;
                    dgvSanPham.DataSource = dsSanPhamTheoDon;
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm hợp lệ!");
            }

            if (dgvSanPham.Columns["picSanpham"] != null)
                dgvSanPham.Columns["picSanpham"].Visible = false;
        }

        private void btok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) ||
               cbKhachGui.SelectedItem == null ||
               cbKhachNhan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (donHang.danhsachsanpham != null)
            {
                foreach (var sp in donHang.danhsachsanpham)
                {
                    sp.madonhang = txtMa.Text.Trim();
                }
            }

            // Tạo đối tượng DonHangMoi
            DonHangMoi = new DonHangView
            {
                madonhang = txtMa.Text.Trim(),
                makhachgui = (cbKhachGui.SelectedItem as KhachGuiView)?.makh,
                makhachnhan = (cbKhachNhan.SelectedItem as KhachNhanView)?.makh,
                ngaytao = dtNgayDat.Value,
                danhsachsanpham = new List<SanPhamView>(donHang.danhsachsanpham ?? new List<SanPhamView>()),
                TrangThai = cbTT.SelectedItem?.ToString() ?? "Chưa xử lý"
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            string newMaSP;
            do
            {
                newMaSP = "SP" + new Random().Next(1, 999).ToString("D3");
            } while (
                (donHang?.danhsachsanpham != null && donHang.danhsachsanpham.Any(sp => sp.masanpham == newMaSP))
            );

            SanPhamView spMoi = new SanPhamView
            {
                masanpham = newMaSP,
                madonhang = donHang.madonhang
            };

            InfoSanPham form = new InfoSanPham(spMoi, true);
            form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (donHang.danhsachsanpham == null)
                    donHang.danhsachsanpham = new List<SanPhamView>();

                donHang.danhsachsanpham.Add(spMoi);
                if (dsSanPham != null && !dsSanPham.Any(sp => sp.masanpham == spMoi.masanpham))
                    dsSanPham.Add(spMoi);

                dgvSanPham.DataSource = null;
                dgvSanPham.DataSource = donHang.danhsachsanpham;

                if (dgvSanPham.Columns["picSanpham"] != null)
                    dgvSanPham.Columns["picSanpham"].Visible = false;

            }
            this.Show();
        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow?.DataBoundItem is SanPhamView sp)
            {
                InfoSanPham form = new InfoSanPham(sp, true);
                form.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dgvSanPham.DataSource = null;
                    dgvSanPham.DataSource = donHang.danhsachsanpham;

                }
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dgvSanPham.Columns["picSanpham"] != null)
                dgvSanPham.Columns["picSanpham"].Visible = false;
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

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dgvSanPham.Columns["picSanpham"] != null)
                dgvSanPham.Columns["picSanpham"].Visible = false;
        }

        private void cbKhachNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhachNhan.SelectedItem is KhachNhanView khachNhanChon)
            {
                khachNhan = khachNhanChon;

                txtDC.Text = khachNhan.diachikhachnhan;
                txtSDT.Text = khachNhan.sodienthoai;
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                dgvSanPham.DataSource = null;
                dgvSanPham.DataSource = donHang.danhsachsanpham;
                return;
            }

            var ketQua = donHang.danhsachsanpham
                .Where(sp =>
                    (sp.tensanpham != null && sp.tensanpham.ToLower().Contains(keyword)) ||
                    (sp.masanpham != null && sp.masanpham.ToLower().Contains(keyword)))
                .ToList();

            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = ketQua;

            if (ketQua.Count == 0)
                MessageBox.Show("Không tìm thấy sản phẩm nào phù hợp!", "Kết quả tìm kiếm");
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (donHang.danhsachsanpham == null || donHang.danhsachsanpham.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm để sắp xếp!");
                return;
            }

            string sortOption = cbSort.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(sortOption)) return;

            List<SanPhamView> sortedList = donHang.danhsachsanpham;

            switch (sortOption)
            {
                case "Tên (A → Z)":
                    sortedList = sortedList.OrderBy(sp => sp.tensanpham).ToList();
                    break;

                case "Tên (Z → A)":
                    sortedList = sortedList.OrderByDescending(sp => sp.tensanpham).ToList();
                    break;

                case "Mã (A → Z)":
                    sortedList = sortedList.OrderBy(sp => sp.masanpham).ToList();
                    break;

                case "Mã (Z → A)":
                    sortedList = sortedList.OrderByDescending(sp => sp.masanpham).ToList();
                    break;
            }

            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = sortedList;
        }
        private static string TaoMaNgauNhien(string prefix)
        {
            Random rand = new Random();
            int number = rand.Next(1, 1000);
            return $"{prefix}{number:D3}";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
