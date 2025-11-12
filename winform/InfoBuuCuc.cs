using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_De_tai_7.modal;
using OOP_De_tai_7.modalview;

namespace OOP_De_tai_7
{
    public partial class InfoBuuCuc : Form
    {
        public BuuCucView BuuCucMoi { get; private set; }
        private BuuCucView buucuc;
        private string imagePath;
        private bool isEdit;
        public InfoBuuCuc(BuuCucView bc, bool isEdit =false)
        {
            InitializeComponent();
            buucuc = bc;
            this.isEdit = isEdit;
        }

        private void InfoBuuCuc_Load(object sender, EventArgs e)
        {
            if (buucuc != null)
            {
                txtMaBC.ReadOnly = !isEdit;
                txtTenBC.ReadOnly = !isEdit;
                txtDiaChi.ReadOnly = !isEdit;
                picBuucuc.Enabled = isEdit;

                txtMaBC.Text = buucuc.mabc;
                txtTenBC.Text = buucuc.tenbuucuc;
                txtDiaChi.Text = buucuc.diachi;
                if (!string.IsNullOrEmpty(buucuc.pickbuucuc))
                {
                    string fullPath = Path.Combine(Application.StartupPath, buucuc.pickbuucuc);
                    if (File.Exists(fullPath))
                    {
                        picBuucuc.Image = Image.FromFile(fullPath);
                    }
                }
                txtMaBC.ReadOnly = true;
            }
            else
            {
                txtMaBC.ReadOnly = true;
                txtMaBC.Text = TaoMaNgauNhien("BC");
            }
        }

        private void picBuucuc_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = openFileDialog.FileName;

                    string imageFolder = Path.Combine(Application.StartupPath, "data", "Bưu cục");
                    Directory.CreateDirectory(imageFolder);

                    string fileName = $"{txtMaBC.Text}{Path.GetExtension(sourcePath)}";
                    string destPath = Path.Combine(imageFolder, fileName);

                    File.Copy(sourcePath, destPath, true);

                    using (var tempImage = Image.FromFile(destPath))
                    {
                        picBuucuc.Image = new Bitmap(tempImage);
                    }
                    imagePath = $"data\\Bưu cục\\{fileName}"; 
                }
            }
        }

        private void btok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBC.Text) ||
               string.IsNullOrWhiteSpace(txtTenBC.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BuuCucMoi = new BuuCucView
            {
                mabc = txtMaBC.Text,
                tenbuucuc = txtTenBC.Text,
                diachi = txtDiaChi.Text,
                pickbuucuc = imagePath
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private static string TaoMaNgauNhien(string prefix)
        {
            Random rand = new Random();
            int number = rand.Next(1, 1000); // 1–999
            return $"{prefix}{number:D3}";   // D3: luôn đủ 3 chữ số
        }
    }
}
