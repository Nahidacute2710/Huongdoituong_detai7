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
using Test_Winform_detai7.modal;

namespace Test_Winform_detai7
{
    public partial class InfoTaiXe : Form
    {
        public TaiXeView TaiXeMoi { get; private set; }
        private TaiXeView TaiXe;
        private List<BuuCucView> danhSachBuuCuc = new List<BuuCucView>();
        public InfoTaiXe(TaiXeView tx)
        {
            InitializeComponent();
            TaiXe = tx;
        }

        private void InfoTaiXe_Load(object sender, EventArgs e)
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
                else
                {
                    MessageBox.Show("Không tìm thấy file buuCuc.json!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (TaiXe != null)
                {
                    txtMa.Text = TaiXe.manv;
                    txtTen.Text = TaiXe.tennv;
                    txtSDT.Text = TaiXe.sodienthoai;
                    txtBSX.Text = TaiXe.bienSoXe;
                    txtLX.Text = TaiXe.loaiXe;

                    if (TaiXe.buucuc != null)
                    {
                        cbBuuCuc.SelectedItem = danhSachBuuCuc
                            .FirstOrDefault(b => b.tenbuucuc == TaiXe.buucuc.tenbuucuc);
                    }
                    else
                    {
                        cbBuuCuc.SelectedIndex = 0; // Không chọn gì nếu chưa có
                    }
                }
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
            TaiXeMoi = new TaiXeView
            {
                manv = txtMa.Text,
                tennv = txtTen.Text,
                sodienthoai = txtSDT.Text,
                bienSoXe = txtBSX.Text,
                loaiXe = txtLX.Text,
                buucuc = buuCucChonView

            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
