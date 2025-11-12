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
using System.IO;
using System.Text.Json;
using OOP_De_tai_7.modalview;
using System.Runtime.CompilerServices;
namespace OOP_De_tai_7
{
    public partial class InfoNhanVienVP : Form
    {
        public NhanVienVanPhongView NVVPMoi { get; private set; }
        private NhanVienVanPhongView nhanVien;
        private List<BuuCucView> danhSachBuuCuc = new List<BuuCucView>();
        private List<NhanVienVanPhongView> danhSachChucvu = new List<NhanVienVanPhongView>();
        private string imagePath;
        private bool isEdit;
        public InfoNhanVienVP(NhanVienVanPhongView nv,bool isEdit = false)
        {
            InitializeComponent();
            nhanVien = nv;
            this.isEdit = isEdit;
        }

        private void InfoNhanVienVP_Load(object sender, EventArgs e)
        {
            string path = "database2.json";

            if (!File.Exists(path))
            {
                MessageBox.Show("Không tìm thấy file database.json!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Đọc danh sách bưu cục
            string json = File.ReadAllText(path);
            var doc = JsonDocument.Parse(json);
            var buuCucsJson = doc.RootElement.GetProperty("danhsach_buucuc").GetRawText();
            danhSachBuuCuc = JsonSerializer.Deserialize<List<BuuCucView>>(buuCucsJson);

            cbBuuCuc.DataSource = danhSachBuuCuc;
            cbBuuCuc.DisplayMember = "tenbuucuc";
            cbBuuCuc.ValueMember = "mabc";

            string json1 = File.ReadAllText(path);
            var doc1 = JsonDocument.Parse(json);
            var chucVusJson = doc1.RootElement.GetProperty("danhsach_nhanvienvanphong").GetRawText();
            danhSachChucvu = JsonSerializer.Deserialize<List<NhanVienVanPhongView>>(chucVusJson);

            var danhSachChucVuDuyNhat = danhSachChucvu
            .Select(nv => nv.chucvu)   
            .Distinct()                
            .ToList();

            cbChucVu.DataSource = danhSachChucVuDuyNhat;
            cbChucVu.DisplayMember = "chucvu";
            danhSachChucVuDuyNhat.AddRange(new string[] { "Quản lý", "Lễ tân", "Thư ký" });
            cbChucVu.DataSource = null;
            cbChucVu.DataSource = danhSachChucVuDuyNhat;
            if (nhanVien != null)
            {
                lbMaNV.Visible = true;
                txtMaNV.Visible = true; 
                txtMaNV.ReadOnly = true;
                txtTenNV.ReadOnly = !isEdit;
                txtSDT.ReadOnly = !isEdit;
                txtEmail.ReadOnly = !isEdit;
                cbBuuCuc.Enabled = isEdit;
                cbChucVu.Enabled = isEdit;
                picNVVP.Enabled = isEdit;

                txtMaNV.Text = nhanVien.manv;
                txtTenNV.Text = nhanVien.tennv;
                txtSDT.Text = nhanVien.sodienthoai;
                txtEmail.Text = nhanVien.email;
                cbBuuCuc.SelectedValue = nhanVien.mabuucuc;
                cbChucVu.SelectedItem = nhanVien.chucvu;
                imagePath = nhanVien.picnvvp;
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    using (var tempImage = Image.FromFile(imagePath))
                    {
                        picNVVP.Image = new Bitmap(tempImage);
                    }
                }
            }
            else
            {
                txtMaNV.ReadOnly = true;
                txtMaNV.Text = TaoMaNgauNhien("NVVP");
                cbBuuCuc.SelectedIndex = -1;
                cbChucVu.SelectedIndex = -1;
            }
        }

        private void btok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var buuCucChonView = cbBuuCuc.SelectedItem as BuuCucView;

            // Chuyển BuuCucView thành BuuCuc thật (để tương thích kiểu)
            BuuCuc buuCucChon = null;
            if (buuCucChonView != null)
            {
                buuCucChon = new BuuCuc(
                    buuCucChonView.mabc,
                    buuCucChonView.tenbuucuc,
                    buuCucChonView.diachi
                );
            }
            
            NVVPMoi = new NhanVienVanPhongView
            {
                manv = txtMaNV.Text,
                tennv = txtTenNV.Text,
                sodienthoai = txtSDT.Text,
                email = txtEmail.Text,
                mabuucuc = cbBuuCuc.SelectedValue?.ToString(),
                chucvu = cbChucVu.SelectedValue?.ToString(),
                picnvvp = imagePath
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void picNVVP_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = openFileDialog.FileName;

                    // Thư mục ảnh nằm trong app
                    string imageFolder = Path.Combine(Application.StartupPath, "data", "NVVP");
                    Directory.CreateDirectory(imageFolder);

                    // Lưu với tên theo mã khách hàng (vd: KH001.jpg)
                    string fileName = $"{txtMaNV.Text}{Path.GetExtension(sourcePath)}";
                    string destPath = Path.Combine(imageFolder, fileName);

                    File.Copy(sourcePath, destPath, true);

                    using (var tempImage = Image.FromFile(destPath))
                    {
                        picNVVP.Image = new Bitmap(tempImage);
                    }
                    imagePath = $"data\\NVVP\\{fileName}"; // 🔹 lưu đường dẫn TƯƠNG ĐỐI
                }
            }
        }
        private static string TaoMaNgauNhien(string prefix)
        {
            Random rand = new Random();
            int number = rand.Next(1, 1000); // 1–999
            return $"{prefix}{number:D3}";   // D3: luôn đủ 3 chữ số
        }
    }
}
