namespace Test_Winform_detai7
{
    partial class InfoKhachNhan
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            btok = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(178, 82);
            label6.Name = "label6";
            label6.Size = new Size(540, 71);
            label6.TabIndex = 15;
            label6.Text = "Thông tin khách nhận";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.125F);
            label5.Location = new Point(43, 595);
            label5.Name = "label5";
            label5.Size = new Size(146, 49);
            label5.TabIndex = 11;
            label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.125F);
            label3.Location = new Point(33, 465);
            label3.Name = "label3";
            label3.Size = new Size(247, 49);
            label3.TabIndex = 12;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.125F);
            label2.Location = new Point(33, 249);
            label2.Name = "label2";
            label2.Size = new Size(283, 49);
            label2.TabIndex = 13;
            label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.125F);
            label1.Location = new Point(33, 353);
            label1.Name = "label1";
            label1.Size = new Size(137, 49);
            label1.TabIndex = 14;
            label1.Text = "Họ tên";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Times New Roman", 16.125F);
            txtDiaChi.Location = new Point(330, 587);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(429, 57);
            txtDiaChi.TabIndex = 10;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Times New Roman", 16.125F);
            txtSDT.Location = new Point(339, 440);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(429, 57);
            txtSDT.TabIndex = 9;
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Times New Roman", 16.125F);
            txtTenKH.Location = new Point(339, 338);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(429, 57);
            txtTenKH.TabIndex = 8;
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Times New Roman", 16.125F);
            txtMaKH.Location = new Point(339, 241);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(429, 57);
            txtMaKH.TabIndex = 7;
            // 
            // btok
            // 
            btok.Location = new Point(415, 712);
            btok.Name = "btok";
            btok.Size = new Size(150, 46);
            btok.TabIndex = 16;
            btok.Text = "OK";
            btok.UseVisualStyleBackColor = true;
            btok.Click += btok_Click_1;
            // 
            // InfoKhachNhan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 862);
            Controls.Add(btok);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDiaChi);
            Controls.Add(txtSDT);
            Controls.Add(txtTenKH);
            Controls.Add(txtMaKH);
            Name = "InfoKhachNhan";
            Text = "InfoKhachNhan";
            Load += InfoKhachNhan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private Button btok;
    }
}