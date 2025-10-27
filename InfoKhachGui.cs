using System.Security.Policy;
using Test_Winform_detai7.modal;

    namespace Test_Winform_detai7
    {
    public partial class InfoKhachGui : Form
    {
        public KhachGuiView KhachMoiGui { get; private set; }
        private KhachGuiView khach;
        public InfoKhachGui(KhachGuiView k)
        {
            InitializeComponent();
            khach = k;
        }

        private void InfoKhachGui_Load(object sender, EventArgs e)
        {
            if (khach != null)
            {
                txtMaKH.Text = khach.makh;
                txtTenKH.Text = khach.tenkh;
                txtSDT.Text = khach.sodienthoai;
                txtDiaChi.Text = khach.diachikhachgui;
            }
        }

        private void btok_Click(object sender, EventArgs e)
        {
            KhachMoiGui = new KhachGuiView
            {
                makh = txtMaKH.Text,
                tenkh = txtTenKH.Text,
                sodienthoai = txtSDT.Text,
                diachikhachgui = txtDiaChi.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

