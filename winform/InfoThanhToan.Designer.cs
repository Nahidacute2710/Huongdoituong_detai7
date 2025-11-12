namespace OOP_De_tai_7
{
    partial class InfoThanhToan
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
            txtMa = new TextBox();
            dtNgayTT = new DateTimePicker();
            lbTT = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btok = new Button();
            cbPhuongThuc = new ComboBox();
            cbTrangThai = new ComboBox();
            label3 = new Label();
            cbMaDH = new ComboBox();
            SuspendLayout();
            // 
            // txtMa
            // 
            txtMa.Font = new Font("Segoe UI", 12F);
            txtMa.Location = new Point(466, 193);
            txtMa.Margin = new Padding(4);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(275, 50);
            txtMa.TabIndex = 5;
            // 
            // dtNgayTT
            // 
            dtNgayTT.Location = new Point(466, 520);
            dtNgayTT.Margin = new Padding(4);
            dtNgayTT.Name = "dtNgayTT";
            dtNgayTT.Size = new Size(552, 50);
            dtNgayTT.TabIndex = 3;
            // 
            // lbTT
            // 
            lbTT.AutoSize = true;
            lbTT.Font = new Font("Segoe UI", 13.875F);
            lbTT.Location = new Point(116, 193);
            lbTT.Margin = new Padding(4, 0, 4, 0);
            lbTT.Name = "lbTT";
            lbTT.Size = new Size(264, 50);
            lbTT.TabIndex = 6;
            lbTT.Text = "Mã thanh toán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F);
            label2.Location = new Point(116, 297);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(242, 50);
            label2.TabIndex = 6;
            label2.Text = "Mã đơn hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.875F);
            label4.Location = new Point(116, 410);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(234, 50);
            label4.TabIndex = 6;
            label4.Text = "Phương thức";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F);
            label5.Location = new Point(116, 521);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(299, 50);
            label5.TabIndex = 6;
            label5.Text = "Ngày thanh toán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.875F);
            label6.Location = new Point(116, 631);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(185, 50);
            label6.TabIndex = 6;
            label6.Text = "Trạng thái";
            // 
            // btok
            // 
            btok.Font = new Font("Segoe UI", 12F);
            btok.Location = new Point(466, 742);
            btok.Margin = new Padding(4);
            btok.Name = "btok";
            btok.Size = new Size(208, 65);
            btok.TabIndex = 9;
            btok.Text = "OK";
            btok.UseVisualStyleBackColor = true;
            btok.Click += btok_Click;
            // 
            // cbPhuongThuc
            // 
            cbPhuongThuc.Font = new Font("Segoe UI", 12F);
            cbPhuongThuc.FormattingEnabled = true;
            cbPhuongThuc.Location = new Point(466, 407);
            cbPhuongThuc.Margin = new Padding(4);
            cbPhuongThuc.Name = "cbPhuongThuc";
            cbPhuongThuc.Size = new Size(334, 53);
            cbPhuongThuc.TabIndex = 2;
            // 
            // cbTrangThai
            // 
            cbTrangThai.Font = new Font("Segoe UI", 12F);
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(466, 628);
            cbTrangThai.Margin = new Padding(4);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(334, 53);
            cbTrangThai.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(290, 50);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(527, 71);
            label3.TabIndex = 6;
            label3.Text = "Thông tin thanh toán";
            // 
            // cbMaDH
            // 
            cbMaDH.Font = new Font("Segoe UI", 12F);
            cbMaDH.FormattingEnabled = true;
            cbMaDH.Location = new Point(466, 294);
            cbMaDH.Margin = new Padding(4);
            cbMaDH.Name = "cbMaDH";
            cbMaDH.Size = new Size(334, 53);
            cbMaDH.TabIndex = 1;
            // 
            // InfoThanhToan
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 911);
            Controls.Add(cbTrangThai);
            Controls.Add(cbMaDH);
            Controls.Add(cbPhuongThuc);
            Controls.Add(btok);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lbTT);
            Controls.Add(dtNgayTT);
            Controls.Add(txtMa);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "InfoThanhToan";
            Text = "InfoThanhToan";
            Load += InfoThanhToan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMa;
        private DateTimePicker dtNgayTT;
        private Label lbTT;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btok;
        private ComboBox cbPhuongThuc;
        private ComboBox cbTrangThai;
        private Label label3;
        private ComboBox cbMaDH;
    }
}