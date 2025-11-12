namespace OOP_De_tai_7
{
    partial class InfoDonHang
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbMadh = new Label();
            txtDC = new TextBox();
            txtSDT = new TextBox();
            txtMa = new TextBox();
            label7 = new Label();
            cbTT = new ComboBox();
            dtNgayDat = new DateTimePicker();
            dtNgayGiao = new DateTimePicker();
            dgvSanPham = new DataGridView();
            label12 = new Label();
            btok = new Button();
            btnThemSanPham = new Button();
            btnSuaSanPham = new Button();
            btnXoaSanPham = new Button();
            cbKhachGui = new ComboBox();
            cbKhachNhan = new ComboBox();
            btnSort = new Button();
            cbSort = new ComboBox();
            btntim = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.875F);
            label6.Location = new Point(90, 422);
            label6.Name = "label6";
            label6.Size = new Size(183, 50);
            label6.TabIndex = 9;
            label6.Text = "Ngày đặt ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F);
            label5.Location = new Point(856, 340);
            label5.Name = "label5";
            label5.Size = new Size(185, 50);
            label5.TabIndex = 10;
            label5.Text = "Trạng thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.875F);
            label4.Location = new Point(93, 340);
            label4.Name = "label4";
            label4.Size = new Size(239, 50);
            label4.TabIndex = 11;
            label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F);
            label3.Location = new Point(90, 508);
            label3.Name = "label3";
            label3.Size = new Size(308, 50);
            label3.TabIndex = 12;
            label3.Text = "Địa chỉ giao hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F);
            label2.Location = new Point(86, 250);
            label2.Name = "label2";
            label2.Size = new Size(246, 50);
            label2.TabIndex = 13;
            label2.Text = "Tên khách gửi";
            // 
            // lbMadh
            // 
            lbMadh.AutoSize = true;
            lbMadh.Font = new Font("Segoe UI", 13.875F);
            lbMadh.Location = new Point(86, 155);
            lbMadh.Name = "lbMadh";
            lbMadh.Size = new Size(242, 50);
            lbMadh.TabIndex = 14;
            lbMadh.Text = "Mã đơn hàng";
            // 
            // txtDC
            // 
            txtDC.Font = new Font("Segoe UI", 13.875F);
            txtDC.Location = new Point(409, 508);
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(1116, 57);
            txtDC.TabIndex = 7;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Microsoft Sans Serif", 13.875F);
            txtSDT.Location = new Point(356, 340);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(399, 49);
            txtSDT.TabIndex = 3;
            // 
            // txtMa
            // 
            txtMa.Font = new Font("Microsoft Sans Serif", 13.875F);
            txtMa.Location = new Point(356, 155);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(310, 49);
            txtMa.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.875F);
            label7.Location = new Point(856, 422);
            label7.Name = "label7";
            label7.Size = new Size(322, 50);
            label7.TabIndex = 9;
            label7.Text = "Ngày giao dự kiến";
            // 
            // cbTT
            // 
            cbTT.Font = new Font("Microsoft Sans Serif", 13.875F);
            cbTT.FormattingEnabled = true;
            cbTT.Location = new Point(1203, 342);
            cbTT.Name = "cbTT";
            cbTT.Size = new Size(310, 50);
            cbTT.TabIndex = 4;
            // 
            // dtNgayDat
            // 
            dtNgayDat.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtNgayDat.Location = new Point(356, 432);
            dtNgayDat.Name = "dtNgayDat";
            dtNgayDat.Size = new Size(482, 40);
            dtNgayDat.TabIndex = 5;
            // 
            // dtNgayGiao
            // 
            dtNgayGiao.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtNgayGiao.Location = new Point(1203, 432);
            dtNgayGiao.Name = "dtNgayGiao";
            dtNgayGiao.Size = new Size(452, 46);
            dtNgayGiao.TabIndex = 6;
            dtNgayGiao.ValueChanged += dtNgayGiao_ValueChanged;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSanPham.BackgroundColor = SystemColors.ControlLightLight;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.GridColor = Color.WhiteSmoke;
            dgvSanPham.Location = new Point(30, 632);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersWidth = 82;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(1705, 281);
            dgvSanPham.TabIndex = 21;
            dgvSanPham.CellContentDoubleClick += dgvSanPham_CellContentDoubleClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.875F);
            label12.Location = new Point(856, 248);
            label12.Name = "label12";
            label12.Size = new Size(275, 50);
            label12.TabIndex = 13;
            label12.Text = "Tên khách nhận";
            // 
            // btok
            // 
            btok.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btok.Location = new Point(797, 977);
            btok.Name = "btok";
            btok.Size = new Size(150, 58);
            btok.TabIndex = 24;
            btok.Text = "OK";
            btok.UseVisualStyleBackColor = true;
            btok.Click += btok_Click;
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemSanPham.Location = new Point(67, 919);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(182, 64);
            btnThemSanPham.TabIndex = 25;
            btnThemSanPham.Text = "Thêm";
            btnThemSanPham.UseVisualStyleBackColor = true;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // btnSuaSanPham
            // 
            btnSuaSanPham.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuaSanPham.Location = new Point(298, 919);
            btnSuaSanPham.Name = "btnSuaSanPham";
            btnSuaSanPham.Size = new Size(182, 64);
            btnSuaSanPham.TabIndex = 25;
            btnSuaSanPham.Text = "Sửa";
            btnSuaSanPham.UseVisualStyleBackColor = true;
            btnSuaSanPham.Click += btnSuaSanPham_Click;
            // 
            // btnXoaSanPham
            // 
            btnXoaSanPham.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaSanPham.Location = new Point(537, 919);
            btnXoaSanPham.Name = "btnXoaSanPham";
            btnXoaSanPham.Size = new Size(182, 64);
            btnXoaSanPham.TabIndex = 25;
            btnXoaSanPham.Text = "Xóa";
            btnXoaSanPham.UseVisualStyleBackColor = true;
            btnXoaSanPham.Click += btnXoaSanPham_Click;
            // 
            // cbKhachGui
            // 
            cbKhachGui.Font = new Font("Microsoft Sans Serif", 13.875F);
            cbKhachGui.FormattingEnabled = true;
            cbKhachGui.Location = new Point(356, 250);
            cbKhachGui.Name = "cbKhachGui";
            cbKhachGui.Size = new Size(310, 50);
            cbKhachGui.TabIndex = 1;
            // 
            // cbKhachNhan
            // 
            cbKhachNhan.Font = new Font("Microsoft Sans Serif", 13.875F);
            cbKhachNhan.FormattingEnabled = true;
            cbKhachNhan.Location = new Point(1203, 248);
            cbKhachNhan.Name = "cbKhachNhan";
            cbKhachNhan.Size = new Size(310, 50);
            cbKhachNhan.TabIndex = 2;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(1563, 580);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(150, 46);
            btnSort.TabIndex = 30;
            btnSort.Text = "↑↓ Sắp xếp";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // cbSort
            // 
            cbSort.FormattingEnabled = true;
            cbSort.Location = new Point(1315, 586);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(242, 40);
            cbSort.TabIndex = 29;
            cbSort.Text = "Sắp xếp theo...";
            // 
            // btntim
            // 
            btntim.Location = new Point(981, 580);
            btntim.Name = "btntim";
            btntim.Size = new Size(150, 46);
            btntim.TabIndex = 28;
            btntim.Text = "Tìm🔍";
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(30, 576);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(945, 50);
            txtSearch.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(601, 33);
            label1.Name = "label1";
            label1.Size = new Size(549, 78);
            label1.TabIndex = 14;
            label1.Text = "Thông tin đơn hàng";
            // 
            // InfoDonHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1747, 1081);
            Controls.Add(btnSort);
            Controls.Add(cbSort);
            Controls.Add(btntim);
            Controls.Add(txtSearch);
            Controls.Add(cbKhachNhan);
            Controls.Add(cbKhachGui);
            Controls.Add(btnXoaSanPham);
            Controls.Add(btnSuaSanPham);
            Controls.Add(btnThemSanPham);
            Controls.Add(btok);
            Controls.Add(dgvSanPham);
            Controls.Add(dtNgayGiao);
            Controls.Add(dtNgayDat);
            Controls.Add(cbTT);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbMadh);
            Controls.Add(txtDC);
            Controls.Add(txtSDT);
            Controls.Add(txtMa);
            Name = "InfoDonHang";
            Text = "InfoDonHang";
            Load += InfoDonHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbMadh;
        private TextBox txtDC;
        private TextBox txtSDT;
        private TextBox txtMa;
        private Label label7;
        private ComboBox cbTT;
        private DateTimePicker dtNgayDat;
        private DateTimePicker dtNgayGiao;
        private DataGridView dgvSanPham;
        private Label label12;
        private Button btok;
        private Button btnThemSanPham;
        private Button btnSuaSanPham;
        private Button btnXoaSanPham;
        private ComboBox cbKhachGui;
        private ComboBox cbKhachNhan;
        private Button btnSort;
        private ComboBox cbSort;
        private Button btntim;
        private TextBox txtSearch;
        private Label label1;
    }
}