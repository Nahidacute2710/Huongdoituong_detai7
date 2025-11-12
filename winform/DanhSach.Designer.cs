namespace OOP_De_tai_7
{
    partial class DanhSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSach));
            dgvDanhSach = new DataGridView();
            toolStrip1 = new ToolStrip();
            sbtTaiXe = new ToolStripButton();
            sbtNVVP = new ToolStripButton();
            sbtKhachGui = new ToolStripButton();
            sbtKhachNhan = new ToolStripButton();
            sbtDonHang = new ToolStripButton();
            sbtBuuCuc = new ToolStripButton();
            sbtThanhToan = new ToolStripButton();
            sbtVanChuyen = new ToolStripButton();
            btthem = new Button();
            btxoa = new Button();
            btsua = new Button();
            txtSearch = new TextBox();
            btntim = new Button();
            cbSort = new ComboBox();
            btnSort = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDanhSach.BackgroundColor = SystemColors.ControlLightLight;
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.GridColor = Color.WhiteSmoke;
            dgvDanhSach.Location = new Point(42, 390);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.RowHeadersWidth = 82;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSach.Size = new Size(1822, 589);
            dgvDanhSach.TabIndex = 0;
            dgvDanhSach.CellContentDoubleClick += dgvDanhSach_CellContentDoubleClick;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(200, 200);
            toolStrip1.Items.AddRange(new ToolStripItem[] { sbtTaiXe, sbtNVVP, sbtKhachGui, sbtKhachNhan, sbtDonHang, sbtBuuCuc, sbtThanhToan, sbtVanChuyen });
            toolStrip1.Location = new Point(0, 22);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1905, 235);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // sbtTaiXe
            // 
            sbtTaiXe.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbtTaiXe.Image = (Image)resources.GetObject("sbtTaiXe.Image");
            sbtTaiXe.ImageTransparentColor = Color.Magenta;
            sbtTaiXe.Name = "sbtTaiXe";
            sbtTaiXe.Size = new Size(204, 229);
            sbtTaiXe.Text = "Tài xế";
            sbtTaiXe.TextImageRelation = TextImageRelation.ImageAboveText;
            sbtTaiXe.Click += sbtTaiXe_Click;
            // 
            // sbtNVVP
            // 
            sbtNVVP.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbtNVVP.Image = (Image)resources.GetObject("sbtNVVP.Image");
            sbtNVVP.ImageTransparentColor = Color.Magenta;
            sbtNVVP.Name = "sbtNVVP";
            sbtNVVP.Size = new Size(378, 229);
            sbtNVVP.Text = "Nhân viên văn phòng";
            sbtNVVP.TextImageRelation = TextImageRelation.ImageAboveText;
            sbtNVVP.Click += sbtNVVP_Click;
            // 
            // sbtKhachGui
            // 
            sbtKhachGui.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbtKhachGui.Image = (Image)resources.GetObject("sbtKhachGui.Image");
            sbtKhachGui.ImageTransparentColor = Color.Magenta;
            sbtKhachGui.Name = "sbtKhachGui";
            sbtKhachGui.Size = new Size(204, 229);
            sbtKhachGui.Text = "Khách gửi";
            sbtKhachGui.TextImageRelation = TextImageRelation.ImageAboveText;
            sbtKhachGui.Click += sbtKhachGui_Click;
            // 
            // sbtKhachNhan
            // 
            sbtKhachNhan.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbtKhachNhan.Image = (Image)resources.GetObject("sbtKhachNhan.Image");
            sbtKhachNhan.ImageTransparentColor = Color.Magenta;
            sbtKhachNhan.Name = "sbtKhachNhan";
            sbtKhachNhan.Size = new Size(217, 229);
            sbtKhachNhan.Text = "Khách nhận";
            sbtKhachNhan.TextImageRelation = TextImageRelation.ImageAboveText;
            sbtKhachNhan.Click += sbtKhachNhan_Click;
            // 
            // sbtDonHang
            // 
            sbtDonHang.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbtDonHang.Image = (Image)resources.GetObject("sbtDonHang.Image");
            sbtDonHang.ImageTransparentColor = Color.Magenta;
            sbtDonHang.Name = "sbtDonHang";
            sbtDonHang.Size = new Size(204, 229);
            sbtDonHang.Text = "Đơn hàng";
            sbtDonHang.TextImageRelation = TextImageRelation.ImageAboveText;
            sbtDonHang.Click += sbtDonHang_Click;
            // 
            // sbtBuuCuc
            // 
            sbtBuuCuc.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbtBuuCuc.Image = (Image)resources.GetObject("sbtBuuCuc.Image");
            sbtBuuCuc.ImageTransparentColor = Color.Magenta;
            sbtBuuCuc.Name = "sbtBuuCuc";
            sbtBuuCuc.Size = new Size(204, 229);
            sbtBuuCuc.Text = "Bưu cục";
            sbtBuuCuc.TextImageRelation = TextImageRelation.ImageAboveText;
            sbtBuuCuc.Click += sbtBuuCuc_Click;
            // 
            // sbtThanhToan
            // 
            sbtThanhToan.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbtThanhToan.Image = (Image)resources.GetObject("sbtThanhToan.Image");
            sbtThanhToan.ImageTransparentColor = Color.Magenta;
            sbtThanhToan.Name = "sbtThanhToan";
            sbtThanhToan.Size = new Size(212, 229);
            sbtThanhToan.Text = "Thanh toán";
            sbtThanhToan.TextImageRelation = TextImageRelation.ImageAboveText;
            sbtThanhToan.Click += sbtThanhToan_Click;
            // 
            // sbtVanChuyen
            // 
            sbtVanChuyen.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbtVanChuyen.Image = (Image)resources.GetObject("sbtVanChuyen.Image");
            sbtVanChuyen.ImageTransparentColor = Color.Magenta;
            sbtVanChuyen.Name = "sbtVanChuyen";
            sbtVanChuyen.Size = new Size(216, 229);
            sbtVanChuyen.Text = "Vận chuyển";
            sbtVanChuyen.TextImageRelation = TextImageRelation.ImageAboveText;
            sbtVanChuyen.Click += sbtVanChuyen_Click;
            // 
            // btthem
            // 
            btthem.Font = new Font("Microsoft Sans Serif", 13.875F);
            btthem.Location = new Point(425, 1027);
            btthem.Name = "btthem";
            btthem.Size = new Size(147, 63);
            btthem.TabIndex = 4;
            btthem.Text = "Thêm";
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // btxoa
            // 
            btxoa.Font = new Font("Microsoft Sans Serif", 13.875F);
            btxoa.Location = new Point(884, 1031);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(157, 63);
            btxoa.TabIndex = 4;
            btxoa.Text = "Xóa ";
            btxoa.UseVisualStyleBackColor = true;
            btxoa.Click += btxoa_Click;
            // 
            // btsua
            // 
            btsua.Font = new Font("Microsoft Sans Serif", 13.875F);
            btsua.Location = new Point(1327, 1031);
            btsua.Name = "btsua";
            btsua.Size = new Size(164, 55);
            btsua.TabIndex = 4;
            btsua.Text = "Sửa";
            btsua.UseVisualStyleBackColor = true;
            btsua.Click += btsua_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(42, 334);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(945, 50);
            txtSearch.TabIndex = 5;
            // 
            // btntim
            // 
            btntim.Location = new Point(993, 338);
            btntim.Name = "btntim";
            btntim.Size = new Size(150, 46);
            btntim.TabIndex = 6;
            btntim.Text = "Tìm🔍";
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // cbSort
            // 
            cbSort.FormattingEnabled = true;
            cbSort.Location = new Point(1327, 344);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(242, 40);
            cbSort.TabIndex = 7;
            cbSort.Text = "Sắp xếp theo...";
            // 
            // btnSort
            // 
            btnSort.Location = new Point(1575, 338);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(150, 46);
            btnSort.TabIndex = 8;
            btnSort.Text = "↑↓ Sắp xếp";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // DanhSach
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1914, 1154);
            Controls.Add(btnSort);
            Controls.Add(cbSort);
            Controls.Add(btntim);
            Controls.Add(txtSearch);
            Controls.Add(btsua);
            Controls.Add(btxoa);
            Controls.Add(btthem);
            Controls.Add(toolStrip1);
            Controls.Add(dgvDanhSach);
            Name = "DanhSach";
            Text = "DanhSach";
            Load += DanhSach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDanhSach;
        private ToolStrip toolStrip1;
        private ToolStripButton sbtNVVP;
        private ToolStripButton sbtKhachGui;
        private ToolStripButton sbtTaiXe;
        private ToolStripButton sbtKhachNhan;
        private ToolStripButton sbtDonHang;
        private ToolStripButton sbtThanhToan;
        private ToolStripButton sbtVanChuyen;
        private Button btthem;
        private Button btxoa;
        private Button btsua;
        private TextBox txtSearch;
        private Button btntim;
        private ComboBox cbSort;
        private Button btnSort;
        private ToolStripButton sbtBuuCuc;
    }
}