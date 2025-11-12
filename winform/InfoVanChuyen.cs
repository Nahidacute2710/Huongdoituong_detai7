using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_De_tai_7.DataManagerClass;
using OOP_De_tai_7.modal;
using OOP_De_tai_7.modalview;

namespace OOP_De_tai_7
{
    internal partial class InfoVanChuyen : Form
    {
        private DataManager database;
        private List<DonHangView> danhSachDonHang;
        private List<TaiXeView> danhSachTaiXe;
        public VanChuyenView VanChuyenMoi { get; private set; }
        private VanChuyenView vc;
        private bool isEdit;
        public InfoVanChuyen(VanChuyenView vc, List<DonHangView> dsDonHang, List<TaiXeView> dsTaiXe, DataManager database, bool isEdit = false)
        {
            InitializeComponent();
            this.database = database ?? new DataManager();
            this.vc = vc;
            this.danhSachDonHang = dsDonHang ?? new List<DonHangView>();
            this.danhSachTaiXe = dsTaiXe ?? new List<TaiXeView>();
            this.isEdit = isEdit;
        }
        private void InfoVanChuyen_Load(object sender, EventArgs e)
        {
           
            cbDonHang.DataSource = danhSachDonHang;
            cbDonHang.DisplayMember = "madonhang";
            cbDonHang.ValueMember = "madonhang";
            cbDonHang.SelectedIndex = -1;
            cbDonHang.SelectedIndexChanged += (s, ev) =>
            {
                if (cbDonHang.SelectedItem is DonHangView donHangChon)
                {
                    HienThiThongTinDonHang(donHangChon);
                }
            };
            cbTaiXe.DataSource = danhSachTaiXe;
            cbTaiXe.DisplayMember = "manv";
            cbTaiXe.ValueMember = "manv";
            cbTaiXe.SelectedIndex = -1;
            cbTaiXe.SelectedIndexChanged += (s, ev) =>
            {
                if (cbTaiXe.SelectedItem is TaiXeView taiXeChon)
                {
                    HienThiThongTinTaiXe(taiXeChon);
                }
            };
            var dsTrangThaiDH = database.danhsach_vanchuyen
               .Select(v => v.trangThaiDh)
               .Where(s => !string.IsNullOrEmpty(s))
               .Distinct()
               .ToList();

            var dsTrangThaiTX = database.danhsach_vanchuyen
               .Select(v => v.trangThaiTx)
               .Where(s => !string.IsNullOrEmpty(s))
               .Distinct()
               .ToList();

            // Gán DataSource
            cbTTDH.DataSource = dsTrangThaiDH;
            cbTTTX.DataSource = dsTrangThaiTX;
            if (vc != null)
            {
                txtMaVC.ReadOnly = true;
                txtKhachGui.ReadOnly = true;
                txtKhachNhan.ReadOnly = true;
                cbTTDH.Enabled = isEdit;
                cbTTTX.Enabled = isEdit;
                txtHanhTrinh.ReadOnly = !isEdit;
                txtGhiChu.ReadOnly = !isEdit;
                dtNgayBatDau.Enabled = isEdit;
                dtNgayKetThuc.Enabled = isEdit;
                cbDonHang.Enabled = isEdit;
                cbTaiXe.Enabled = isEdit;
                txtTenTx.ReadOnly = true;

                txtMaVC.Text = vc.mavc;

                var khachGui = database.danhsach_khachgui.FirstOrDefault(k => k.makh == vc.makhachgui);
                var khachNhan = database.danhsach_khachnhan.FirstOrDefault(k => k.makh == vc.makhachnhan);

                txtKhachGui.Text = khachGui?.tenkh ?? "(Không tìm thấy)";
                txtKhachNhan.Text = khachNhan?.tenkh ?? "(Không tìm thấy)";
                txtHanhTrinh.Text = vc.hanhtrinh;
                txtGhiChu.Text = vc.takenote;
                dtNgayBatDau.Value = vc.ngaybatdau;
                dtNgayKetThuc.Value = vc.ngayketthucdukien;

                cbTTDH.SelectedItem = vc.trangThaiDh;
                cbTTTX.SelectedItem = vc.trangThaiTx;
                cbDonHang.SelectedValue = vc.madonhang;
                cbTaiXe.SelectedValue = vc.mataixe;

                var dh = danhSachDonHang.FirstOrDefault(x => x.madonhang == vc.madonhang);
                if (dh != null) HienThiThongTinDonHang(dh);

                var tx = danhSachTaiXe.FirstOrDefault(x => x.manv == vc.mataixe);
                if (tx != null) HienThiThongTinTaiXe(tx);
            }
            else
            {
                txtMaVC.ReadOnly = true;
                txtKhachGui.ReadOnly = true;
                txtKhachNhan.ReadOnly = true;
                txtTenTx.ReadOnly = true;
                txtMaVC.Text = TaoMaNgauNhien("VC");
                txtKhachGui.Text = "";
                txtKhachNhan.Text = "";
                txtHanhTrinh.Text = "";
                txtGhiChu.Text = "";
                dtNgayBatDau.Value = DateTime.Now;
                dtNgayKetThuc.Value = DateTime.Now;
                cbDonHang.SelectedIndex = -1;
                cbTaiXe.SelectedIndex = -1;
                txtTenTx.Text = "";

                cbTTDH.SelectedIndex = -1; // rỗng mặc định
                cbTTTX.SelectedIndex = -1;
            }
        }

        private void btok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaVC.Text) ||
              string.IsNullOrWhiteSpace(cbDonHang.Text) || string.IsNullOrWhiteSpace(cbTaiXe.Text))

            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbDonHang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbTaiXe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tài xế!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu người dùng chọn
            var donHangView = (DonHangView)cbDonHang.SelectedItem;
            var taiXeView = (TaiXeView)cbTaiXe.SelectedItem;
            DonHang donHang = donHangView.ToModel();

            TaiXe taiXe = new TaiXe(
                taiXeView.manv,
                taiXeView.tennv,
                taiXeView.sodienthoai,
                taiXeView.email,
                taiXeView.bienSoXe,
                taiXeView.loaiXe,
                taiXeView.mabuucuc
            );
            KhachGui khachgui = new KhachGui();
            khachgui.setMaKH(donHangView.makhachgui);


            KhachNhan khachnhan = new KhachNhan();

            VanChuyenMoi = new VanChuyenView
            {
                mavc = txtMaVC.Text.Trim(),
                madonhang = donHangView.madonhang,
                mataixe = taiXeView.manv,
                makhachgui = donHangView.makhachgui,
                makhachnhan = donHangView.makhachnhan,
                trangThaiDh = cbTTDH.SelectedItem?.ToString() ?? "", 
                trangThaiTx = cbTTTX.SelectedItem?.ToString() ?? "",
                hanhtrinh = txtHanhTrinh.Text.Trim(),
                takenote = txtGhiChu.Text.Trim(),
                ngaybatdau = dtNgayBatDau.Value,
                ngayketthucdukien = dtNgayKetThuc.Value
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void HienThiThongTinDonHang(DonHangView dh)
        {
            if (dh == null) return;

            var khachGui = database.danhsach_khachgui.FirstOrDefault(k => k.makh == dh.makhachgui);
            var khachNhan = database.danhsach_khachnhan.FirstOrDefault(k => k.makh == dh.makhachnhan);

            txtKhachGui.Text = khachGui?.tenkh ?? "(Không tìm thấy)";
            txtKhachNhan.Text = khachNhan?.tenkh ?? "(Không tìm thấy)";

            dtNgayBatDau.Value = dh.ngaytao;

        }
        private void HienThiThongTinTaiXe(TaiXeView taiXe)
        {
            if (taiXe == null) return;
            txtTenTx.Text = taiXe.tennv;

        }

        private static string TaoMaNgauNhien(string prefix)
        {
            Random rand = new Random();
            int number = rand.Next(1, 1000); // 1–999
            return $"{prefix}{number:D3}";   // D3: luôn đủ 3 chữ số
        }

    }
}
