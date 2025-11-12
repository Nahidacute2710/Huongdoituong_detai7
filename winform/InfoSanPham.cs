using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_De_tai_7.modal;
using OOP_De_tai_7.modalview;

namespace OOP_De_tai_7
{
    public partial class InfoSanPham : Form
    {
        private SanPhamView sanPham;
        private string imagePath;
        private bool isEdit;
        public InfoSanPham(SanPhamView sp, bool isEdit)
        {
            InitializeComponent();
            this.sanPham = sp;
            this.isEdit = isEdit;
        }

        private void InfoSanPham_Load(object sender, EventArgs e)
        {
            if (sanPham != null)
            {
                label1.Visible = true;
                txtMa.Visible = true;
                txtMa.ReadOnly = true;
                txtTen.ReadOnly = !isEdit;
                txtSoLuong.ReadOnly = !isEdit;
                txtGiaTri.ReadOnly = !isEdit;
                txtTinhChat.ReadOnly = !isEdit;
                picSanpham.Enabled = isEdit;

                txtMa.Text = sanPham.masanpham;
                txtTen.Text = sanPham.tensanpham;
                txtSoLuong.Text = sanPham.soluong.ToString();
                txtGiaTri.Text = sanPham.giatri.ToString();
                txtTinhChat.Text = sanPham.tinhchat;
                imagePath = sanPham.picSanpham;
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    using (var tempImage = Image.FromFile(imagePath))
                    {
                        picSanpham.Image = new Bitmap(tempImage);
                    }
                }
            }
            else
            {
                label1.Visible = false;
                txtMa.Visible = false;
                txtMa.Text = TaoMaNgauNhien("SP");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) ||
               string.IsNullOrWhiteSpace(txtTen.Text))

            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sanPham.masanpham = txtMa.Text.Trim();
            sanPham.tensanpham = txtTen.Text.Trim();

            if (int.TryParse(txtSoLuong.Text, out int soLuong))
                sanPham.soluong = soLuong;
            else
                sanPham.soluong = 0;

            if (double.TryParse(txtGiaTri.Text, out double giaTri))
                sanPham.giatri = giaTri;
            else
                sanPham.giatri = 0;

            sanPham.tinhchat = txtTinhChat.Text.Trim();
            sanPham.picSanpham = imagePath;
            sanPham.madonhang = sanPham.madonhang;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private static string TaoMaNgauNhien(string prefix)
        {
            Random rand = new Random();
            int number = rand.Next(1, 1000); // 1–999
            return $"{prefix}{number:D3}";   // D3: luôn đủ 3 chữ số
        }

        private void picSanpham_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = openFileDialog.FileName;


                    string imageFolder = Path.Combine(Application.StartupPath, "data", "Sản phẩm");
                    Directory.CreateDirectory(imageFolder);

                    string fileName = $"{txtMa.Text}{Path.GetExtension(sourcePath)}";
                    string destPath = Path.Combine(imageFolder, fileName);

                    File.Copy(sourcePath, destPath, true);

                    using (var tempImage = Image.FromFile(destPath))
                    {
                        picSanpham.Image = new Bitmap(tempImage);
                    }
                    imagePath = $"data\\Sản phẩm\\{fileName}";
                }
            }
        }
    }
}
