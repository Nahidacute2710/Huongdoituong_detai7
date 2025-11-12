using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_De_tai_7.modal;
using OOP_De_tai_7.modalview;

namespace OOP_De_tai_7
{
    public partial class InfoTaiXe : Form
    {
        public TaiXeView TaiXeMoi { get; private set; }
        private TaiXeView TaiXe;
        private List<BuuCucView> danhSachBuuCuc = new List<BuuCucView>();
        private string imagePath;
        private bool isEdit;
        public InfoTaiXe(TaiXeView tx, bool isEdit = false)
        {
            InitializeComponent();
            TaiXe = tx;
            this.isEdit = isEdit;
        }

        private void InfoTaiXe_Load(object sender, EventArgs e)
        {
            string path = "database2.json";
            string json = File.ReadAllText(path);
            var doc = JsonDocument.Parse(json);
            var buuCucsJson = doc.RootElement.GetProperty("danhsach_buucuc").GetRawText();
            danhSachBuuCuc = JsonSerializer.Deserialize<List<BuuCucView>>(buuCucsJson);

            cbBuuCuc.DataSource = danhSachBuuCuc;
            cbBuuCuc.DisplayMember = "tenbuucuc";
            cbBuuCuc.ValueMember = "mabc";
            if (TaiXe != null)
            {

                lbMaNV.Visible = true;
                txtMa.Visible = true;
                txtMa.ReadOnly = true;
                txtTen.ReadOnly = !isEdit;
                txtSDT.ReadOnly = !isEdit;
                txtEmail.ReadOnly = !isEdit;
                txtBSX.ReadOnly = !isEdit;
                txtLX.ReadOnly = !isEdit;
                cbBuuCuc.Enabled = isEdit;
                picTaixe.Enabled = isEdit;

                txtMa.Text = TaiXe.manv;
                txtTen.Text = TaiXe.tennv;
                txtSDT.Text = TaiXe.sodienthoai;
                txtEmail.Text = TaiXe.email;
                txtBSX.Text = TaiXe.bienSoXe;
                txtLX.Text = TaiXe.loaiXe;
                cbBuuCuc.SelectedValue = TaiXe.mabuucuc;
                imagePath = TaiXe.pictaixe;

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    using (var tempImage = Image.FromFile(imagePath))
                    {
                        picTaixe.Image = new Bitmap(tempImage);
                    }
                }
            }
            else
            {
                txtMa.ReadOnly = true;
                cbBuuCuc.SelectedIndex = -1;
                txtMa.Text = TaoMaNgauNhien("TX");
            }
           
            if (!File.Exists(path))
            {
                MessageBox.Show("Không tìm thấy file database.json!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

        }

        private void btok_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMa.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text))

            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var buuCucChonView = cbBuuCuc.SelectedItem as BuuCucView;

            BuuCuc buuCucChon = null;
            if (buuCucChonView != null)
            {
                buuCucChon = new BuuCuc(
                    buuCucChonView.mabc,
                    buuCucChonView.tenbuucuc,
                    buuCucChonView.diachi
                );
            }

            TaiXeMoi = new TaiXeView
            {
                manv = txtMa.Text,
                tennv = txtTen.Text,
                sodienthoai = txtSDT.Text,
                email = txtEmail.Text,
                bienSoXe = txtBSX.Text,
                loaiXe = txtLX.Text,
                mabuucuc = cbBuuCuc.SelectedValue?.ToString(),
                pictaixe = imagePath

            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void picTaixe_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = openFileDialog.FileName;


                    string imageFolder = Path.Combine(Application.StartupPath, "data", "Tài xế");
                    Directory.CreateDirectory(imageFolder);

                    string fileName = $"{txtMa.Text}{Path.GetExtension(sourcePath)}";
                    string destPath = Path.Combine(imageFolder, fileName);

                    File.Copy(sourcePath, destPath, true);

                    using (var tempImage = Image.FromFile(destPath))
                    {
                        picTaixe.Image = new Bitmap(tempImage);
                    }
                    imagePath = $"data\\Tài xế\\{fileName}"; 
                }
            }   
        }
        private static string TaoMaNgauNhien(string prefix)
        {
            Random rand = new Random();
            int number = rand.Next(1, 1000); 
            return $"{prefix}{number:D3}";  
        }
    }
}
