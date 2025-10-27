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
using System.IO;
using System.Text.Json;
namespace Test_Winform_detai7
{
    public partial class InfoNhanVienVP : Form
    {
        public NhanVienVanPhongView NVVPMoi { get; private set; }
        private NhanVienVanPhongView nhanVien;
        private List<BuuCucView> danhSachBuuCuc = new List<BuuCucView>();

        public InfoNhanVienVP(NhanVienVanPhongView nv)
        {
            InitializeComponent();
            nhanVien = nv;
        }

        private void InfoNhanVienVP_Load(object sender, EventArgs e)
        {
            string path = "buucuc.json";

            if (File.Exists(path))
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    var doc = JsonDocument.Parse(json);
                    var buuCucsJson = doc.RootElement.GetProperty("buucuc").GetRawText();
                    danhSachBuuCuc = JsonSerializer.Deserialize<List<BuuCucView>>(buuCucsJson);

                    cbBuuCuc.DataSource = danhSachBuuCuc;
                    cbBuuCuc.DisplayMember = "tenbuucuc";
                    cbBuuCuc.ValueMember = "mabc";
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy file buuCuc.json!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (nhanVien != null)
            {
                txtMaNV.Text = nhanVien.manv;
                txtTenNV.Text = nhanVien.tennv;
                txtSDT.Text = nhanVien.sodienthoai;
                cbBuuCuc.SelectedItem = danhSachBuuCuc
                    .FirstOrDefault(b => b.tenbuucuc == nhanVien.buucuc.tenbuucuc);
                txtChucVu.Text = nhanVien.chucvu;
            }
        }

        private void btok_Click(object sender, EventArgs e)
        {
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
                buucuc = buuCucChonView,
                chucvu = txtChucVu.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
