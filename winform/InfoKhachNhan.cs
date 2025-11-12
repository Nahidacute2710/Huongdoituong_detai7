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
    public partial class InfoKhachNhan : Form
    {
        public KhachNhanView KhachMoiNhan { get; private set; }
        private KhachNhanView khach;
        private string imagePath;
        private bool isEdit;
        public InfoKhachNhan(KhachNhanView k, bool isEdit = false)
        {
            InitializeComponent();
            khach = k;
            this.isEdit = isEdit;
        }


        private void InfoKhachNhan_Load(object sender, EventArgs e)
        {
            if (khach != null)
            {
                lbMaKH.Visible = true;
                txtMaKH.Visible = true;
                txtMaKH.ReadOnly = true;
                txtTenKH.ReadOnly = !isEdit;
                txtSDT.ReadOnly = !isEdit;
                txtEmail.ReadOnly = !isEdit;
                txtDiaChi.ReadOnly = !isEdit;
                picKhachnhan.Enabled = isEdit;

                txtMaKH.Text = khach.makh;
                txtTenKH.Text = khach.tenkh;
                txtSDT.Text = khach.sodienthoai;
                txtEmail.Text = khach.email;
                txtDiaChi.Text = khach.diachikhachnhan;
                imagePath = khach.pickhachnhan;
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    using (var tempImage = Image.FromFile(imagePath))
                    {
                        picKhachnhan.Image = new Bitmap(tempImage);
                    }
                }
                txtMaKH.ReadOnly = true;
            }
            else
            {
                txtMaKH.ReadOnly = true;
                txtMaKH.Text = TaoMaNgauNhien("KN");
            }
        }


        private void btok_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách nhận.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            KhachMoiNhan = new KhachNhanView
            {
                makh = txtMaKH.Text,
                tenkh = txtTenKH.Text,
                email = txtEmail.Text,
                sodienthoai = txtSDT.Text,
                diachikhachnhan = txtDiaChi.Text,
                pickhachnhan = imagePath
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void picKhachgui_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = openFileDialog.FileName;

                    // Thư mục ảnh nằm trong app
                    string imageFolder = Path.Combine(Application.StartupPath, "data", "Khách nhận");
                    Directory.CreateDirectory(imageFolder);

                    // Lưu với tên theo mã khách hàng (vd: KH001.jpg)
                    string fileName = $"{txtMaKH.Text}{Path.GetExtension(sourcePath)}";
                    string destPath = Path.Combine(imageFolder, fileName);

                    File.Copy(sourcePath, destPath, true);

                    using (var tempImage = Image.FromFile(destPath))
                    {
                        picKhachnhan.Image = new Bitmap(tempImage);
                    }
                    imagePath = $"data\\Khách nhận\\{fileName}"; // 🔹 lưu đường dẫn TƯƠNG ĐỐI
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
