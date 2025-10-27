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
using Test_Winform_detai7.modal;

namespace Test_Winform_detai7
{
    internal partial class InfoVanChuyen : Form
    {
        private List<DonHangView> danhSachDonHang;
        private List<TaiXeView> danhSachTaiXe;
        public VanChuyenView VanChuyenMoi { get; private set; }
        private VanChuyenView vc;
        public InfoVanChuyen(VanChuyenView vc, List<DonHangView> dsDonHang, List<TaiXeView> dsTaiXe)
        {
            InitializeComponent();
            this.vc = vc ?? new VanChuyenView();
            this.danhSachDonHang = dsDonHang ?? new List<DonHangView>();
            this.danhSachTaiXe = dsTaiXe ?? new List<TaiXeView>();
        }
        private List<DonHangView> LayDanhSachDonHang()
        {
            string path = "donhang.json";
            if (!File.Exists(path)) return new List<DonHangView>();

            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<DonHangView>>(json);
        }
        private List<TaiXeView> LayDanhSachTaiXe()
        {
            string path = "donhang.json";
            if (!File.Exists(path)) return new List<TaiXeView>();

            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<TaiXeView>>(json);
        }
        private void InfoVanChuyen_Load(object sender, EventArgs e)
        {
            danhSachDonHang = LayDanhSachDonHang(); 

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
            cbTaiXe.ValueMember = "tennv";   
            cbTaiXe.SelectedIndex = -1;          
            cbTaiXe.SelectedIndexChanged += (s, ev) =>
            {
                if (cbTaiXe.SelectedItem is TaiXeView taiXeChon)
                {
                    HienThiThongTinTaiXe(taiXeChon);
                }
            };
            if (vc != null)
            {
                txtMaVC.Text = vc.mavc;
                txtKhachGui.Text = vc.khachgui.getTenKH();
                txtKhachNhan.Text = vc.khachnhan.getTenKH();
                txtTrangThaiDH.Text = vc.trangThaiDh;
                txtTrangThaiTX.Text = vc.trangThaiTx;
                txtHanhTrinh.Text = vc.hanhtrinh;
                txtGhiChu.Text = vc.takenote;
                dtNgayBatDau.Value = vc.ngaybatdau;
                dtNgayKetThuc.Value = vc.ngayketthucdukien;
            }
        }

        private void btok_Click(object sender, EventArgs e)
        {

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
                taiXeView.bienSoXe,
                taiXeView.loaiXe,
                new BuuCuc(
                    taiXeView.buucuc.mabc,
                    taiXeView.buucuc.tenbuucuc,
                    taiXeView.buucuc.diachi
                )
            );
            KhachGui khachgui = new KhachGui();
            khachgui.setMaKH(donHangView.makhachgui);


            KhachNhan khachnhan = new KhachNhan();

            VanChuyenMoi = new VanChuyenView
            {
                mavc = txtMaVC.Text.Trim(),
                dh = donHang,
                tx = taiXe,
                khachgui = khachgui,
                khachnhan = khachnhan,
                trangThaiDh = txtTrangThaiDH.Text.Trim(),
                trangThaiTx = txtTrangThaiTX.Text.Trim(),
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
            txtKhachGui.Text = dh.makhachgui;
            txtKhachNhan.Text = dh.makhachnhan;
            dtNgayBatDau.Value = dh.ngaytao;

        }
        private void HienThiThongTinTaiXe(TaiXeView taiXe)
        {
            if (taiXe == null) return;
            txtTenTx.Text = taiXe.tennv;

        }
        private void cbDonHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

   

    }
}
