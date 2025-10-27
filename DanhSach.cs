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
    public partial class DanhSach : Form
    {
        public DanhSach()
        {
            InitializeComponent();
        }
        private string currentMode = "";
        private string path_khachgui = @"khachgui.json";
        private string path_nvvp = @"nhanvienvanphong.json";
        private string path_taixe = @"taixe.json";
        private string path_khachnhan = @"khachnhan.json";
        private string path_buucuc = @"buucuc.json";
        private string path_donhang = @"donhang.json";
        private string path_thanhtoan = @"thanhtoan.json";
        private string path_vanchuyen = @"vanchuyen.json";

        List<KhachGuiView> dsKhachGui = new();
        List<NhanVienVanPhongView> dsNVVP = new();
        List<TaiXeView> dsTaiXe = new();
        List<KhachNhanView> dsKhachNhan = new();
        
        List<DonHangView> dsDonHang = new();
        List<ThanhToanView> dsThanhToan = new();
        List<VanChuyenView> dsVanChuyen = new();

        private void DanhSach_Load(object sender, EventArgs e)
        {
 
            dsKhachGui = JsonActivity.ReadFromJsonFile<KhachGuiView>(path_khachgui);
            dsNVVP = JsonActivity.ReadFromJsonFile<NhanVienVanPhongView>(path_nvvp);
            dsTaiXe = JsonActivity.ReadFromJsonFile<TaiXeView>(path_taixe);
            dsKhachNhan = JsonActivity.ReadFromJsonFile<KhachNhanView>(path_khachnhan);
            dsDonHang = JsonActivity.ReadFromJsonFile<DonHangView>(path_donhang);
            dsThanhToan = JsonActivity.ReadFromJsonFile<ThanhToanView>(path_thanhtoan);
            dsVanChuyen = JsonActivity.ReadFromJsonFile<VanChuyenView>(path_vanchuyen);
       
            foreach (var k in dsKhachGui)
                k.Loai = "Gửi";

            foreach (var k in dsKhachNhan)
                k.Loai = "Nhận";
            string json = File.ReadAllText(path_buucuc);
        }
        private void dgvDanhSach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var data = dgvDanhSach.Rows[e.RowIndex].DataBoundItem;

            switch (data)
            {
                case KhachGuiView kg:
                    InfoKhachGui form = new InfoKhachGui(kg);
                    form.ShowDialog();
                    break;

                case NhanVienVanPhongView nv:
                    new InfoNhanVienVP(nv).ShowDialog();
                    break;

                case DonHangView dh:
                    new InfoDonHang(dh, dsKhachNhan).ShowDialog();
                    break;

                case TaiXeView tx:
                    new InfoTaiXe(tx).ShowDialog();
                    break;

                case KhachNhanView kn:
                    new InfoKhachNhan(kn).ShowDialog();
                    break;

                case VanChuyenView vc:
                    new InfoVanChuyen(vc, dsDonHang, dsTaiXe).ShowDialog();
                    break;
            }
        }
        private void sbtNVVP_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = dsNVVP;
           

            currentMode = "NVVP";
        }

        private void sbtKhachGui_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = dsKhachGui;
            currentMode = "KG";
        }

        private void sbtTaiXe_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = dsTaiXe;
            currentMode = "TX";
        }

        private void sbtKhachNhan_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = dsKhachNhan;
            currentMode = "KN";
        }

        private void sbtDonHang_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = dsDonHang;
            currentMode = "DH";
        }


        private void sbtThanhToan_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = dsThanhToan;
            currentMode = "TT";
        }

        private void sbtVanChuyen_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = dsVanChuyen;
            currentMode = "VC";
        }


        private void btthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentMode))
            {
                MessageBox.Show("Vui lòng chọn loại danh sách (Khách gửi hoặc Khách nhận) trước khi thêm.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (currentMode)
            {
                case "KG":
                    var formGui = new InfoKhachGui(null);
                    if (formGui.ShowDialog() == DialogResult.OK)
                    {
                        dsKhachGui.Add(formGui.KhachMoiGui);
                        JsonActivity.WriteToJsonFile(path_khachgui, dsKhachGui);
                        dgvDanhSach.DataSource = null;
                        dgvDanhSach.DataSource = dsKhachGui;
                    }
                    break;
                case "KN":
                    var formNhan = new InfoKhachNhan(null);
                    if (formNhan.ShowDialog() == DialogResult.OK)
                    {
                        dsKhachNhan.Add(formNhan.KhachMoiNhan);
                        JsonActivity.WriteToJsonFile(path_khachnhan, dsKhachNhan);
                        dgvDanhSach.DataSource = null;
                        dgvDanhSach.DataSource = dsKhachNhan;
                    }
                    break;
                case "NVVP":
                    var formNVVP = new InfoNhanVienVP(null);
                    if (formNVVP.ShowDialog() == DialogResult.OK)
                    {
                        dsNVVP.Add(formNVVP.NVVPMoi);
                        JsonActivity.WriteToJsonFile(path_nvvp, dsNVVP);
                        dgvDanhSach.DataSource = null;
                        dgvDanhSach.DataSource = dsNVVP;
                    }
                    break;
                case "TX":
                    var formTX = new InfoTaiXe(null);
                    if (formTX.ShowDialog() == DialogResult.OK)
                    {
                        dsTaiXe.Add(formTX.TaiXeMoi);
                        JsonActivity.WriteToJsonFile(path_taixe, dsTaiXe);
                        dgvDanhSach.DataSource = null;
                        dgvDanhSach.DataSource = dsTaiXe;
                    }
                    break;
                case "DH":
                    DonHangView donHangMoi = new DonHangView();
                    InfoDonHang formDH = new InfoDonHang(donHangMoi, dsKhachNhan);
                    if (formDH.ShowDialog() == DialogResult.OK)
                    {
                        dsDonHang.Add(formDH.DonHangMoi);
                        JsonActivity.WriteToJsonFile(path_donhang, dsDonHang);
                        dgvDanhSach.DataSource = null;
                        dgvDanhSach.DataSource = dsDonHang;
                    }
                    break;
                case "TT":
                    var formTT = new InfoThanhToan(null, dsDonHang);
                    if (formTT.ShowDialog() == DialogResult.OK)
                    {
                        dsThanhToan.Add(formTT.ThanhToanMoi);
                        JsonActivity.WriteToJsonFile(path_thanhtoan, dsThanhToan);
                        dgvDanhSach.DataSource = null;
                        dgvDanhSach.DataSource = dsThanhToan;
                    }
                    break;
                case "VC":
                    var formVC = new InfoVanChuyen(null, dsDonHang, dsTaiXe);
                    if (formVC.ShowDialog() == DialogResult.OK)
                    {
                        dsVanChuyen.Add(formVC.VanChuyenMoi);
                        JsonActivity.WriteToJsonFile(path_vanchuyen, dsVanChuyen);
                        dgvDanhSach.DataSource = null;
                        dgvDanhSach.DataSource = dsVanChuyen;
                    }
                    break;
                default:
                    MessageBox.Show("Chức năng thêm chưa được hỗ trợ cho loại này.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null)
                return;

            switch (currentMode)
            {
                case "KG": // Khách gửi
                    {
                        var khach = dgvDanhSach.CurrentRow.DataBoundItem as KhachGuiView;
                        if (khach == null) return;

                        var confirm = MessageBox.Show($"Bạn có chắc muốn xóa khách gửi '{khach.tenkh}' không?",
                                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirm == DialogResult.Yes)
                        {
                            dsKhachGui.Remove(khach);
                            JsonActivity.WriteToJsonFile(path_khachgui, dsKhachGui);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = dsKhachGui;
                        }
                        break;
                    }

                case "KN": // Khách nhận
                    {
                        var khach = dgvDanhSach.CurrentRow.DataBoundItem as KhachNhanView;
                        if (khach == null) return;

                        var confirm = MessageBox.Show($"Bạn có chắc muốn xóa khách nhận '{khach.tenkh}' không?",
                                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirm == DialogResult.Yes)
                        {
                            dsKhachNhan.Remove(khach);
                            JsonActivity.WriteToJsonFile(path_khachnhan, dsKhachNhan);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = dsKhachNhan;
                        }
                        break;
                    }

                case "NVVP": // Nhân viên văn phòng
                    {
                        var nv = dgvDanhSach.CurrentRow.DataBoundItem as NhanVienVanPhongView;
                        if (nv == null) return;

                        var confirm = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên '{nv.tennv}' không?",
                                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirm == DialogResult.Yes)
                        {
                            dsNVVP.Remove(nv);
                            JsonActivity.WriteToJsonFile(path_nvvp, dsNVVP);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = dsNVVP;
                        }
                        break;
                    }

                case "TX": // Tài xế
                    {
                        var tx = dgvDanhSach.CurrentRow.DataBoundItem as TaiXeView;
                        if (tx == null) return;

                        var confirm = MessageBox.Show($"Bạn có chắc muốn xóa tài xế '{tx.tennv}' không?",
                                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirm == DialogResult.Yes)
                        {
                            dsTaiXe.Remove(tx);
                            JsonActivity.WriteToJsonFile(path_taixe, dsTaiXe);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = dsTaiXe;
                        }
                        break;
                    }

                case "DH": // Đơn hàng
                    {
                        var dh = dgvDanhSach.CurrentRow.DataBoundItem as DonHangView;
                        if (dh == null) return;

                        var confirm = MessageBox.Show($"Bạn có chắc muốn xóa đơn hàng '{dh.madonhang}' không?",
                                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirm == DialogResult.Yes)
                        {
                            dsDonHang.Remove(dh);
                            JsonActivity.WriteToJsonFile(path_donhang, dsDonHang);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = dsDonHang;
                        }
                        break;
                    }
                case "TT": // Thanh toán
                    {
                        var tt = dgvDanhSach.CurrentRow.DataBoundItem as ThanhToanView;
                        if (tt == null) return;

                        var confirm = MessageBox.Show($"Bạn có chắc muốn xóa thanh toán '{tt.mathanhtoan}' không?",
                                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirm == DialogResult.Yes)
                        {
                            dsThanhToan.Remove(tt);
                            JsonActivity.WriteToJsonFile(path_thanhtoan, dsThanhToan);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = dsThanhToan;
                        }
                        break;
                    }
                default:
                    MessageBox.Show("Vui lòng chọn loại danh sách trước khi xóa!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null) return;

            var khach = dgvDanhSach.CurrentRow.DataBoundItem as KhachGuiView;
            if (khach == null) return;

            var form = new InfoKhachGui(khach); // truyền đối tượng hiện tại
            if (form.ShowDialog() == DialogResult.OK)
            {
                // cập nhật lại danh sách
                var index = dsKhachGui.FindIndex(x => x.makh == khach.makh);
                if (index >= 0)
                    dsKhachGui[index] = form.KhachMoiGui; // cập nhật mới

                JsonActivity.WriteToJsonFile(path_khachgui, dsKhachGui);
                dgvDanhSach.DataSource = null;
                dgvDanhSach.DataSource = dsKhachGui;
            }
        }
    }
}
