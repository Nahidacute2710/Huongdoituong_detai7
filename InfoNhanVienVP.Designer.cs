namespace Test_Winform_detai7
{
    partial class InfoNhanVienVP
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
            label1 = new Label();
            txtChucVu = new TextBox();
            txtSDT = new TextBox();
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            btok = new Button();
            cbBuuCuc = new ComboBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(249, 65);
            label6.Name = "label6";
            label6.Size = new Size(499, 71);
            label6.TabIndex = 17;
            label6.Text = "Thông tin nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.125F);
            label5.Location = new Point(104, 649);
            label5.Name = "label5";
            label5.Size = new Size(163, 49);
            label5.TabIndex = 12;
            label5.Text = "Bưu cục";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.125F);
            label4.Location = new Point(104, 544);
            label4.Name = "label4";
            label4.Size = new Size(166, 49);
            label4.TabIndex = 13;
            label4.Text = "Chức vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.125F);
            label3.Location = new Point(104, 448);
            label3.Name = "label3";
            label3.Size = new Size(247, 49);
            label3.TabIndex = 14;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.125F);
            label2.Location = new Point(104, 232);
            label2.Name = "label2";
            label2.Size = new Size(256, 49);
            label2.TabIndex = 15;
            label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.125F);
            label1.Location = new Point(104, 336);
            label1.Name = "label1";
            label1.Size = new Size(137, 49);
            label1.TabIndex = 16;
            label1.Text = "Họ tên";
            // 
            // txtChucVu
            // 
            txtChucVu.Font = new Font("Times New Roman", 16.125F);
            txtChucVu.Location = new Point(410, 533);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(429, 57);
            txtChucVu.TabIndex = 10;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Times New Roman", 16.125F);
            txtSDT.Location = new Point(410, 423);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(429, 57);
            txtSDT.TabIndex = 9;
            // 
            // txtTenNV
            // 
            txtTenNV.Font = new Font("Times New Roman", 16.125F);
            txtTenNV.Location = new Point(410, 321);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(429, 57);
            txtTenNV.TabIndex = 8;
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Times New Roman", 16.125F);
            txtMaNV.Location = new Point(410, 224);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(429, 57);
            txtMaNV.TabIndex = 7;
            // 
            // btok
            // 
            btok.Location = new Point(357, 704);
            btok.Name = "btok";
            btok.Size = new Size(150, 46);
            btok.TabIndex = 18;
            btok.Text = "OK";
            btok.UseVisualStyleBackColor = true;
            btok.Click += btok_Click;
            // 
            // cbBuuCuc
            // 
            cbBuuCuc.FormattingEnabled = true;
            cbBuuCuc.Location = new Point(426, 628);
            cbBuuCuc.Name = "cbBuuCuc";
            cbBuuCuc.Size = new Size(242, 40);
            cbBuuCuc.TabIndex = 19;
            // 
            // InfoNhanVienVP
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 762);
            Controls.Add(cbBuuCuc);
            Controls.Add(btok);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtChucVu);
            Controls.Add(txtSDT);
            Controls.Add(txtTenNV);
            Controls.Add(txtMaNV);
            Name = "InfoNhanVienVP";
            Text = "InfoNhanVienVP";
            Load += InfoNhanVienVP_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtChucVu;
        private TextBox txtSDT;
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private Button btok;
        private ComboBox cbBuuCuc;
    }
}