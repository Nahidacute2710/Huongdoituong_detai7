namespace Test_Winform_detai7
{
    partial class InfoKhachGui
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMaKH = new TextBox();
            txtTenKH = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            btok = new Button();
            SuspendLayout();
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Times New Roman", 16.125F);
            txtMaKH.Location = new Point(382, 237);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(429, 57);
            txtMaKH.TabIndex = 0;
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Times New Roman", 16.125F);
            txtTenKH.Location = new Point(382, 334);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(429, 57);
            txtTenKH.TabIndex = 1;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Times New Roman", 16.125F);
            txtSDT.Location = new Point(382, 436);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(429, 57);
            txtSDT.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Times New Roman", 16.125F);
            txtDiaChi.Location = new Point(373, 583);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(429, 57);
            txtDiaChi.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.125F);
            label1.Location = new Point(76, 349);
            label1.Name = "label1";
            label1.Size = new Size(137, 49);
            label1.TabIndex = 5;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.125F);
            label2.Location = new Point(76, 245);
            label2.Name = "label2";
            label2.Size = new Size(283, 49);
            label2.TabIndex = 5;
            label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.125F);
            label3.Location = new Point(76, 461);
            label3.Name = "label3";
            label3.Size = new Size(247, 49);
            label3.TabIndex = 5;
            label3.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.125F);
            label5.Location = new Point(86, 591);
            label5.Name = "label5";
            label5.Size = new Size(146, 49);
            label5.TabIndex = 5;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(221, 78);
            label6.Name = "label6";
            label6.Size = new Size(498, 71);
            label6.TabIndex = 6;
            label6.Text = "Thông tin khách gửi";
            // 
            // btok
            // 
            btok.Location = new Point(453, 714);
            btok.Name = "btok";
            btok.Size = new Size(150, 46);
            btok.TabIndex = 7;
            btok.Text = "OK";
            btok.UseVisualStyleBackColor = true;
            btok.Click += btok_Click;
            // 
            // InfoKhachGui
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 875);
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
            Name = "InfoKhachGui";
            Text = "InfoNhanVien";
            Load += InfoKhachGui_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaKH;
        private TextBox txtTenKH;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button btok;
    }
}
