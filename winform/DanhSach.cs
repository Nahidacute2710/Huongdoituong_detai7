using OOP_De_tai_7.DataManagerClass;
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
using System.Security.Policy;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace OOP_De_tai_7
{
    public partial class DanhSach : Form
    {
        private DataManager database;
        private string currentMode = "";
        private string path = @"database2.json";
        public DanhSach()
        {
            InitializeComponent();
            database = new DataManager();
            cbSort.Items.AddRange(new string[] {
                "Tên (A → Z)",
                "Tên (Z → A)",
                "Mã (A → Z)",
                "Mã (Z → A)"
            });
            cbSort.SelectedIndex = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
  
        private void DanhSach_Load(object sender, EventArgs e)
        {
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    
            if (File.Exists(path))
            {
                database = JsonActivity.ReadFromJsonFile(path);
            }
            else
            {
                // Nếu chưa có file JSON, khởi tạo DataManager rỗng
                database = new DataManager();
            }
            RefreshDgv();

        }
        private void dgvDanhSach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var data = dgvDanhSach.Rows[e.RowIndex].DataBoundItem;
            Form infoForm = null;

            switch (data)
            {
                case KhachGuiView kg:
                    infoForm = new InfoKhachGui(kg, false);
                    break;
                case NhanVienVanPhongView nv:
                    infoForm = new InfoNhanVienVP(nv, false);
                    break;
                case DonHangView dh:
                    infoForm = new InfoDonHang(dh, database.danhsach_khachnhan, database.danhsach_sanpham, database.danhsach_khachgui, false);
                    break;
                case TaiXeView tx:
                    infoForm = new InfoTaiXe(tx, false);
                    break;
                case KhachNhanView kn:
                    infoForm = new InfoKhachNhan(kn, false);
                    break;
                case BuuCucView bc:
                    infoForm = new InfoBuuCuc(bc, false);
                    break;
                case ThanhToanView tt:
                    infoForm = new InfoThanhToan(tt, database.danhsach_donhang, false);
                    break;
                case VanChuyenView vc:
                    infoForm = new InfoVanChuyen(vc, database.danhsach_donhang, database.danhsach_taixe, database, false);
                    break;
            }

            if (infoForm != null)
            {
                this.Hide();
                infoForm.StartPosition = FormStartPosition.CenterScreen;
                infoForm.ShowDialog();   
                this.Show();             
            }
        }
        private void sbtNVVP_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = database.danhsach_nhanvienvanphong;

            currentMode = "NVVP";
            RefreshDgv();
        }

        private void sbtKhachGui_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = database.danhsach_khachgui;

            currentMode = "KG";
            RefreshDgv();
        }

        private void sbtTaiXe_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = database.danhsach_taixe;

            currentMode = "TX";
            RefreshDgv();

        }

        private void sbtKhachNhan_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = database.danhsach_khachnhan;
            currentMode = "KN";
            RefreshDgv();
        }

        private void sbtDonHang_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = database.danhsach_donhang;
            currentMode = "DH";
        }
        private void sbtBuuCuc_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = database.danhsach_buucuc;
            currentMode = "BC";
            RefreshDgv();
        }

        private void sbtThanhToan_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = database.danhsach_thanhtoan;
            currentMode = "TT";
            
        }

        private void sbtVanChuyen_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = null;
            dgvDanhSach.DataSource = database.danhsach_vanchuyen;
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
                    string newMaKG;
                    do
                    {
                        newMaKG = "KG" + new Random().Next(1, 999).ToString("D3");
                    } while (database.danhsach_khachgui.Any(k => k.makh == newMaKG));   

                    var formGui = new InfoKhachGui(null);
                    formGui.StartPosition = FormStartPosition.CenterScreen; 
                    this.Hide(); 
                    if (formGui.ShowDialog() == DialogResult.OK)
                    {
                        database.danhsach_khachgui.Add(formGui.KhachMoiGui);
                        JsonActivity.WriteToJsonFile(path, database);
                        dgvDanhSach.DataSource = null;
                        dgvDanhSach.DataSource = database.danhsach_khachgui;
                        RefreshDgv();
                    }
                    this.Show();
                    break;
                case "KN":
                    string newMaKN;
                    do
                    {
                        newMaKN = "KN" + new Random().Next(1, 999).ToString("D3");
                    } while (database.danhsach_khachnhan.Any(k => k.makh == newMaKN));
                    var formNhan = new InfoKhachNhan(null);
                    formNhan.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                    if (formNhan.ShowDialog() == DialogResult.OK)
                    {
                        database.danhsach_khachnhan.Add(formNhan.KhachMoiNhan);
                        JsonActivity.WriteToJsonFile(path, database);
                        dgvDanhSach.DataSource = null;
                        dgvDanhSach.DataSource = database.danhsach_khachnhan;
                        RefreshDgv();
                    }
                    this.Show();
                    break;
                case "NVVP":
                    string newMaNVVP;
                    do
                    {
                        newMaNVVP = "NVVP" + new Random().Next(1, 999).ToString("D3");

                    } while (database.danhsach_nhanvienvanphong.Any(nv => nv.manv == newMaNVVP));
                    var formNVVP = new InfoNhanVienVP(null);
                    formNVVP.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                    if (formNVVP.ShowDialog() == DialogResult.OK)
                    {
                        database.danhsach_nhanvienvanphong.Add(formNVVP.NVVPMoi);
                        JsonActivity.WriteToJsonFile(path, database);
                        dgvDanhSach.DataSource = null;
                        dgvDanhSach.DataSource = database.danhsach_nhanvienvanphong;
                        RefreshDgv();
                    }
                    this.Show();
                    break;
                case "BC":
                    string newMaBC;
                    do
                    {
                        newMaBC = "BC" + new Random().Next(1, 999).ToString("D3");
                    } while (database.danhsach_buucuc.Any(bc => bc.mabc == newMaBC));

                    var formBC = new InfoBuuCuc(null);
                    formBC.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                    if (formBC.ShowDialog() == DialogResult.OK)
                    {
                        database.danhsach_buucuc.Add(formBC.BuuCucMoi);
                        JsonActivity.WriteToJsonFile(path, database);
                        dgvDanhSach.DataSource = null;
                        dgvDanhSach.DataSource = database.danhsach_buucuc;
                        RefreshDgv();
                    }
                    this.Show();
                    break;
                case "TX":
                    string newMaTX;
                    do
                    {
                        newMaTX = "TX" + new Random().Next(1, 999).ToString("D3");
                    } while (database.danhsach_taixe.Any(tx => tx.manv == newMaTX));
                    var formTX = new InfoTaiXe(null);
                    formTX.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                    if (formTX.ShowDialog() == DialogResult.OK)
                    {
                        database.danhsach_taixe.Add(formTX.TaiXeMoi);
                        JsonActivity.WriteToJsonFile(path, database);
                        dgvDanhSach.DataSource = null;
                        dgvDanhSach.DataSource = database.danhsach_taixe;
                        RefreshDgv();
                    }
                    this.Show();
                    break;
                case "DH":
                    string newMaDH;
                    do
                    {
                        newMaDH = "DH" + new Random().Next(1, 999).ToString("D3");
                    } while (database.danhsach_donhang.Any(dh => dh.madonhang == newMaDH));
                    DonHangView donHangMoi = new DonHangView();
                    InfoDonHang formDH = new InfoDonHang(donHangMoi, database.danhsach_khachnhan, database.danhsach_sanpham, database.danhsach_khachgui, true);
                    formDH.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                    if (formDH.ShowDialog() == DialogResult.OK)
                    {
                        database.danhsach_donhang.Add(formDH.DonHangMoi);
                        JsonActivity.WriteToJsonFile(path, database);
                        dgvDanhSach.DataSource = null;
                        dgvDanhSach.DataSource = database.danhsach_donhang;
                        RefreshDgv();
                    }
                    this.Show();
                    break;
                case "TT":
                    string newMaTT;
                    do
                    {
                        newMaTT = "TT" + new Random().Next(1, 999).ToString("D3");
                    } while (database.danhsach_thanhtoan.Any(tt => tt.mathanhtoan == newMaTT));
                    var formTT = new InfoThanhToan(null, database.danhsach_donhang, true);
                    formTT.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                    if (formTT.ShowDialog() == DialogResult.OK)
                    {
                        database.danhsach_thanhtoan.Add(formTT.ThanhToanMoi);
                        JsonActivity.WriteToJsonFile(path, database);
                        dgvDanhSach.DataSource = null;
                        dgvDanhSach.DataSource = database.danhsach_thanhtoan;
                        RefreshDgv();
                    }
                    this.Show();
                    break;
                case "VC":
                    string newMaVC;
                    do
                    {
                        newMaVC = "VC" + new Random().Next(1, 999).ToString("D3");
                    } while (database.danhsach_vanchuyen.Any(vc => vc.mavc == newMaVC));
                    var formVC = new InfoVanChuyen(null, database.danhsach_donhang, database.danhsach_taixe, database, true);
                    formVC.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                    if (formVC.ShowDialog() == DialogResult.OK)
                    {
                        database.danhsach_vanchuyen.Add(formVC.VanChuyenMoi);
                        JsonActivity.WriteToJsonFile(path, database);
                        dgvDanhSach.DataSource = null;
                        dgvDanhSach.DataSource = database.danhsach_vanchuyen;
                        RefreshDgv();
                    }
                    this.Show();
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
                            //Xoa hinh
                            if (!string.IsNullOrEmpty(khach.pickhachgui))
                            {
                                string fullPath = Path.Combine(Application.StartupPath, khach.pickhachgui);
                                if (File.Exists(fullPath))
                                {
                                    try
                                    {
                                        File.Delete(fullPath);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Không xóa được hình: " + ex.Message);
                                    }
                                }
                            }
                            //Xoa du lieu
                            database.danhsach_khachgui.Remove(khach);
                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_khachgui;
                            RefreshDgv();
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
                            if (!string.IsNullOrEmpty(khach.pickhachnhan))
                            {
                                string fullPath = Path.Combine(Application.StartupPath, khach.pickhachnhan);
                                if (File.Exists(fullPath))
                                {
                                    try
                                    {
                                        File.Delete(fullPath);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Không xóa được hình: " + ex.Message);
                                    }
                                }
                            }
                            database.danhsach_khachnhan.Remove(khach);
                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_khachnhan;
                            RefreshDgv();
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
                            if (!string.IsNullOrEmpty(nv.picnvvp))
                            {
                                string fullPath = Path.Combine(Application.StartupPath, nv.picnvvp);
                                if (File.Exists(fullPath))
                                {
                                    try
                                    {
                                        File.Delete(fullPath);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Không xóa được hình: " + ex.Message);
                                    }
                                }
                            }
                            database.danhsach_nhanvienvanphong.Remove(nv);
                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_nhanvienvanphong;
                            RefreshDgv();
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
                            if (!string.IsNullOrEmpty(tx.pictaixe))
                            {
                                string fullPath = Path.Combine(Application.StartupPath, tx.pictaixe);
                                if (File.Exists(fullPath))
                                {
                                    try
                                    {
                                        File.Delete(fullPath);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Không xóa được hình: " + ex.Message);
                                    }
                                }
                            }
                            database.danhsach_taixe.Remove(tx);
                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_taixe;
                            RefreshDgv();
                        }
                        break;
                    }
                case "BC":
                    {
                        var bc = dgvDanhSach.CurrentRow.DataBoundItem as BuuCucView;
                        if (bc == null) return;
                        var confirm = MessageBox.Show($"Bạn có chắc muốn xóa bưu cục '{bc.tenbuucuc}' không?",
                                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirm == DialogResult.Yes)
                        {
                            if (!string.IsNullOrEmpty(bc.pickbuucuc))
                            {
                                string fullPath = Path.Combine(Application.StartupPath, bc.pickbuucuc);
                                if (File.Exists(fullPath))
                                {
                                    try
                                    {
                                        File.Delete(fullPath);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Không xóa được hình: " + ex.Message);
                                    }
                                }
                            }
                            database.danhsach_buucuc.Remove(bc);
                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_buucuc;
                            RefreshDgv();
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
                            database.danhsach_donhang.Remove(dh);
                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_donhang;
                            RefreshDgv();
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
                            database.danhsach_thanhtoan.Remove(tt);
                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_thanhtoan;
                            RefreshDgv();
                        }
                        break;
                    }
                case "VC": // Vận chuyển
                    {
                        var vc = dgvDanhSach.CurrentRow.DataBoundItem as VanChuyenView;
                        if (vc == null) return;

                        var confirm = MessageBox.Show($"Bạn có chắc muốn xóa thanh toán '{vc.mavc}' không?",
                                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirm == DialogResult.Yes)
                        {
                            database.danhsach_vanchuyen.Remove(vc);
                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_thanhtoan;
                            RefreshDgv();
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
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (currentMode)
            {
                case "KG":
                    {

                        var khach = dgvDanhSach.CurrentRow.DataBoundItem as KhachGuiView;
                        if (khach == null) return;

                        var form = new InfoKhachGui(khach, true);
                        form.StartPosition = FormStartPosition.CenterScreen;
                        this.Hide();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var khachMoi = form.KhachMoiGui;
                            var index = database.danhsach_khachgui.FindIndex(x => x.makh == khach.makh);
                            if (index >= 0)
                                database.danhsach_khachgui[index] = khachMoi;

                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_khachgui;
                            MessageBox.Show("Đã sửa thông tin khách gửi!", "Thành công");
                            RefreshDgv();
                        }
                        this.Show();
                        break;
                    }

                case "KN":
                    {
                        var khach = dgvDanhSach.CurrentRow.DataBoundItem as KhachNhanView;
                        if (khach == null) return;

                        var form = new InfoKhachNhan(khach, true);
                        form.StartPosition = FormStartPosition.CenterScreen;
                        this.Hide();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var khachMoi = form.KhachMoiNhan;
                            var index = database.danhsach_khachnhan.FindIndex(x => x.makh == khach.makh);
                            if (index >= 0)
                                database.danhsach_khachnhan[index] = khachMoi;

                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_khachnhan;
                            MessageBox.Show("Đã sửa thông tin khách nhận!", "Thành công");
                            RefreshDgv();
                        }
                        this.Show();
                        break;
                    }
                case "NVVP":
                    {
                        var nv = dgvDanhSach.CurrentRow.DataBoundItem as NhanVienVanPhongView;
                        if (nv == null) return;

                        var form = new InfoNhanVienVP(nv, true);
                        form.StartPosition = FormStartPosition.CenterScreen;
                        this.Hide();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var nvMoi = form.NVVPMoi;
                            var index = database.danhsach_nhanvienvanphong.FindIndex(x => x.manv == nv.manv);
                            if (index >= 0)
                                database.danhsach_nhanvienvanphong[index] = nvMoi;

                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_nhanvienvanphong;
                            MessageBox.Show("Đã sửa thông tin nhân viên văn phòng!", "Thành công");
                            RefreshDgv();
                        }
                        this.Show();
                        break;
                    }
                case "TX":
                    {
                        var tx = dgvDanhSach.CurrentRow.DataBoundItem as TaiXeView;
                        if (tx == null) return;

                        var form = new InfoTaiXe(tx, true);
                        form.StartPosition = FormStartPosition.CenterScreen;
                        this.Hide();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var txMoi = form.TaiXeMoi;
                            var index = database.danhsach_taixe.FindIndex(x => x.manv == tx.manv);
                            if (index >= 0)
                                database.danhsach_taixe[index] = txMoi;

                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_taixe;
                            MessageBox.Show("Đã sửa thông tin tài xế!", "Thành công");
                            RefreshDgv();
                        }
                        this.Show();
                        break;
                    }
                case "BC":
                    {
                        var bc = dgvDanhSach.CurrentRow.DataBoundItem as BuuCucView;
                        if (bc == null) return;
                        var form = new InfoBuuCuc(bc, true);
                        form.StartPosition = FormStartPosition.CenterScreen;
                        this.Hide();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var bcMoi = form.BuuCucMoi;
                            var index = database.danhsach_buucuc.FindIndex(x => x.mabc == bc.mabc);
                            if (index >= 0)
                                database.danhsach_buucuc[index] = bcMoi;

                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_buucuc;
                            MessageBox.Show("Đã sửa thông tin bưu cục!", "Thành công");
                            RefreshDgv();
                        }    
                        this.Show();
                        break;
                    }
                case "DH":
                    {
                        var dh = dgvDanhSach.CurrentRow.DataBoundItem as DonHangView;
                        if (dh == null) return;

                        var form = new InfoDonHang(
                            dh,
                            database.danhsach_khachnhan,
                            database.danhsach_sanpham,
                            database.danhsach_khachgui,
                            true
                        );
                        form.StartPosition = FormStartPosition.CenterScreen;
                        this.Hide();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var dhMoi = form.DonHangMoi;
                            var index = database.danhsach_donhang.FindIndex(x => x.madonhang == dh.madonhang);
                            if (index >= 0)
                                database.danhsach_donhang[index] = dhMoi;

                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_donhang;
                            MessageBox.Show("Đã sửa thông tin đơn hàng!", "Thành công");
                            RefreshDgv();
                        }
                        this.Show();
                        break;
                    }

                case "VC":
                    {
                        var vc = dgvDanhSach.CurrentRow.DataBoundItem as VanChuyenView;
                        if (vc == null) return;

                        var form = new InfoVanChuyen(
                            vc,
                            database.danhsach_donhang,
                            database.danhsach_taixe,
                            database,
                            true
                        );
                        form.StartPosition = FormStartPosition.CenterScreen;
                        this.Hide();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var vcMoi = form.VanChuyenMoi;
                            var index = database.danhsach_vanchuyen.FindIndex(x => x.mavc == vc.mavc);
                            if (index >= 0)
                                database.danhsach_vanchuyen[index] = vcMoi;

                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_vanchuyen;
                            MessageBox.Show("Đã sửa thông tin vận chuyển!", "Thành công");
                            RefreshDgv();
                        }
                        this.Show();
                        break;
                    }

                case "TT":
                    {
                        var tt = dgvDanhSach.CurrentRow.DataBoundItem as ThanhToanView;
                        if (tt == null) return;

                        var form = new InfoThanhToan(tt, database.danhsach_donhang, true);
                        form.StartPosition = FormStartPosition.CenterScreen;
                        this.Hide();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var ttMoi = form.ThanhToanMoi;
                            var index = database.danhsach_thanhtoan.FindIndex(x => x.mathanhtoan == tt.mathanhtoan);
                            if (index >= 0)
                                database.danhsach_thanhtoan[index] = ttMoi;

                            JsonActivity.WriteToJsonFile(path, database);
                            dgvDanhSach.DataSource = null;
                            dgvDanhSach.DataSource = database.danhsach_thanhtoan;
                            MessageBox.Show("Đã sửa thông tin thanh toán!", "Thành công");
                            RefreshDgv();
                        }
                        this.Show();
                        break;
                    }

                default:
                    MessageBox.Show("Chưa chọn loại dữ liệu để sửa!", "Cảnh báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
        private void RefreshDgv()
        {
            dgvDanhSach.DataSource = null;
            switch (currentMode)
            {
                case "KG":
                    dgvDanhSach.DataSource = database.danhsach_khachgui;
                    break;
                case "KN":
                    dgvDanhSach.DataSource = database.danhsach_khachnhan;
                    break;
                case "NVVP":
                    dgvDanhSach.DataSource = database.danhsach_nhanvienvanphong;
                    break;
                case "TX":
                    dgvDanhSach.DataSource = database.danhsach_taixe;
                    break;
                case "BC":
                    dgvDanhSach.DataSource = database.danhsach_buucuc;
                    break;
                case "DH":
                    dgvDanhSach.DataSource = database.danhsach_donhang;
                    break;
                case "TT":
                    dgvDanhSach.DataSource = database.danhsach_thanhtoan;
                    break;
                case "VC":
                    dgvDanhSach.DataSource = database.danhsach_vanchuyen;
                    break;

            }
            if (dgvDanhSach.Columns["pickhachgui"] != null)
                dgvDanhSach.Columns["pickhachgui"].Visible = false;
            if (dgvDanhSach.Columns["pickhachnhan"] != null)
                dgvDanhSach.Columns["pickhachnhan"].Visible = false;
            if (dgvDanhSach.Columns["pictaixe"] != null)
                dgvDanhSach.Columns["pictaixe"].Visible = false;
            if (dgvDanhSach.Columns["pickbuucuc"] != null)
                dgvDanhSach.Columns["pickbuucuc"].Visible = false;
            if (dgvDanhSach.Columns["picnvvp"] != null)
                dgvDanhSach.Columns["picnvvp"].Visible = false;

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                RefreshDgv(); 
                return;
            }

            switch (currentMode)
            {
                case "KG":
                    dgvDanhSach.DataSource = database.danhsach_khachgui
                        .Where(k => k.makh.ToLower().Contains(keyword)
                                 || k.tenkh.ToLower().Contains(keyword)
                                 || k.sodienthoai.ToLower().Contains(keyword)
                                 || k.email.ToLower().Contains(keyword))
                        .ToList();
                    break;
                case "KN":
                    dgvDanhSach.DataSource = database.danhsach_khachnhan
                        .Where(k => k.makh.ToLower().Contains(keyword)
                                 || k.tenkh.ToLower().Contains(keyword)
                                 || k.sodienthoai.ToLower().Contains(keyword)
                                 || k.email.ToLower().Contains(keyword))
                        .ToList();
                    break;
                case "TX":
                    dgvDanhSach.DataSource = database.danhsach_taixe
                        .Where(t => t.manv.ToLower().Contains(keyword)
                                 || t.tennv.ToLower().Contains(keyword)
                                 || t.sodienthoai.ToLower().Contains(keyword)
                                 || t.email.ToLower().Contains(keyword)
                                 || t.bienSoXe.ToLower().Contains(keyword)
                                 || t.loaiXe.ToLower().Contains(keyword))
                        .ToList();
                    break;
                case "NVVP":
                    dgvDanhSach.DataSource = database.danhsach_nhanvienvanphong
                        .Where(n => n.manv.ToLower().Contains(keyword)
                                 || n.tennv.ToLower().Contains(keyword)
                                 || n.sodienthoai.ToLower().Contains(keyword)
                                 || n.email.ToLower().Contains(keyword)
                                 || n.chucvu.ToLower().Contains(keyword))
                        .ToList();
                    break;
                case "BC":
                    dgvDanhSach.DataSource = database.danhsach_buucuc
                        .Where(b => b.mabc.ToLower().Contains(keyword)
                                 || b.tenbuucuc.ToLower().Contains(keyword)
                                 || b.diachi.ToLower().Contains(keyword))
                        .ToList();
                    break;
                case "DH":
                    dgvDanhSach.DataSource = database.danhsach_donhang
                        .Where(d => d.madonhang.ToLower().Contains(keyword)
                                 || d.makhachgui.ToLower().Contains(keyword)
                                 || d.makhachnhan.ToLower().Contains(keyword))
                        .ToList();
                    break;
                case "TT":
                    dgvDanhSach.DataSource = database.danhsach_thanhtoan
                        .Where(t => t.mathanhtoan.ToLower().Contains(keyword)
                                 || t.madonhang.ToLower().Contains(keyword))
                        .ToList();
                    break;
                case "VC":
                    dgvDanhSach.DataSource = database.danhsach_vanchuyen
                        .Where(v => v.mavc.ToLower().Contains(keyword)
                                 || v.madonhang.ToLower().Contains(keyword)
                                 || v.mataixe.ToLower().Contains(keyword))
                        .ToList();
                    break;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string sortOption = cbSort.SelectedItem.ToString();

            switch (currentMode)
            {
                case "KG":
                    var listKG = database.danhsach_khachgui;
                    switch (sortOption)
                    {
                        case "Tên (A → Z)": listKG = listKG.OrderBy(k => k.tenkh).ToList(); break;
                        case "Tên (Z → A)": listKG = listKG.OrderByDescending(k => k.tenkh).ToList(); break;
                        case "Mã (A → Z)": listKG = listKG.OrderBy(k => k.makh).ToList(); break;
                        case "Mã (Z → A)": listKG = listKG.OrderByDescending(k => k.makh).ToList(); break;
                    }
                    dgvDanhSach.DataSource = listKG;
                    break;

                case "KN":
                    var listKN = database.danhsach_khachnhan;
                    switch (sortOption)
                    {
                        case "Tên (A → Z)": listKN = listKN.OrderBy(k => k.tenkh).ToList(); break;
                        case "Tên (Z → A)": listKN = listKN.OrderByDescending(k => k.tenkh).ToList(); break;
                        case "Mã (A → Z)": listKN = listKN.OrderBy(k => k.makh).ToList(); break;
                        case "Mã (Z → A)": listKN = listKN.OrderByDescending(k => k.makh).ToList(); break;
                    }
                    dgvDanhSach.DataSource = listKN;
                    break;
                case "NVVP":
                    var listNVVP = database.danhsach_nhanvienvanphong;
                    switch (sortOption)
                    {
                        case "Tên (A → Z)": listNVVP = listNVVP.OrderBy(n => n.tennv).ToList(); break;
                        case "Tên (Z → A)": listNVVP = listNVVP.OrderByDescending(n => n.tennv).ToList(); break;
                        case "Mã (A → Z)": listNVVP = listNVVP.OrderBy(n => n.manv).ToList(); break;
                        case "Mã (Z → A)": listNVVP = listNVVP.OrderByDescending(n => n.manv).ToList(); break;
                    }
                    dgvDanhSach.DataSource = listNVVP;
                    break;
                case "TX":
                    var listTX = database.danhsach_taixe;
                    switch (sortOption)
                    {
                        case "Tên (A → Z)": listTX = listTX.OrderBy(t => t.tennv).ToList(); break;
                        case "Tên (Z → A)": listTX = listTX.OrderByDescending(t => t.tennv).ToList(); break;
                        case "Mã (A → Z)": listTX = listTX.OrderBy(t => t.manv).ToList(); break;
                        case "Mã (Z → A)": listTX = listTX.OrderByDescending(t => t.manv).ToList(); break;
                    }
                    dgvDanhSach.DataSource = listTX;
                    break;
                case "BC":
                    var listBC = database.danhsach_buucuc;
                    switch (sortOption)
                    {
                        case "Tên (A → Z)": listBC = listBC.OrderBy(t => t.tenbuucuc).ToList(); break;
                        case "Tên (Z → A)": listBC = listBC.OrderByDescending(t => t.tenbuucuc).ToList(); break;
                        case "Mã (A → Z)": listBC = listBC.OrderBy(t => t.mabc).ToList(); break;
                        case "Mã (Z → A)": listBC = listBC.OrderByDescending(t => t.mabc).ToList(); break;
                    }
                    dgvDanhSach.DataSource = listBC;
                    break;
                case "DH":
                    var listDH = database.danhsach_donhang;
                    switch (sortOption)
                    {
                        case "Tên (A → Z)": listDH = listDH.OrderBy(d => d.madonhang).ToList(); break;
                        case "Tên (Z → A)": listDH = listDH.OrderByDescending(d => d.madonhang).ToList(); break;
                        case "Mã (A → Z)": listDH = listDH.OrderBy(d => d.madonhang).ToList(); break;
                        case "Mã (Z → A)": listDH = listDH.OrderByDescending(d => d.madonhang).ToList(); break;
                    }
                    dgvDanhSach.DataSource = listDH;
                    break;
                case "TT":
                    var listTT = database.danhsach_thanhtoan;
                    switch (sortOption)
                    {
                        case "Tên (A → Z)": listTT = listTT.OrderBy(t => t.mathanhtoan).ToList(); break;
                        case "Tên (Z → A)": listTT = listTT.OrderByDescending(t => t.mathanhtoan).ToList(); break;
                        case "Mã (A → Z)": listTT = listTT.OrderBy(t => t.mathanhtoan).ToList(); break;
                        case "Mã (Z → A)": listTT = listTT.OrderByDescending(t => t.mathanhtoan).ToList(); break;
                    }
                    dgvDanhSach.DataSource = listTT;
                    break;
                case "VC":
                    var listVC = database.danhsach_vanchuyen;
                    switch (sortOption)
                    {
                        case "Tên (A → Z)": listVC = listVC.OrderBy(v => v.mavc).ToList(); break;
                        case "Tên (Z → A)": listVC = listVC.OrderByDescending(v => v.mavc).ToList(); break;
                        case "Mã (A → Z)": listVC = listVC.OrderBy(v => v.mavc).ToList(); break;
                        case "Mã (Z → A)": listVC = listVC.OrderByDescending(v => v.mavc).ToList(); break;
                    }
                    dgvDanhSach.DataSource = listVC;
                    break;
                case "":
                    MessageBox.Show("Vui lòng chọn loại danh sách để sắp xếp!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
            if (dgvDanhSach.Columns["pickhachgui"] != null)
                dgvDanhSach.Columns["pickhachgui"].Visible = false;
        }

        
    }
}
