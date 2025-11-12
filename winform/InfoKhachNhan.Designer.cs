namespace OOP_De_tai_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoKhachNhan));
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            lbMaKH = new Label();
            label1 = new Label();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            btok = new Button();
            txtEmail = new TextBox();
            label4 = new Label();
            picKhachnhan = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picKhachnhan).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(414, 71);
            label6.Name = "label6";
            label6.Size = new Size(540, 71);
            label6.TabIndex = 15;
            label6.Text = "Thông tin khách nhận";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.125F);
            label5.Location = new Point(108, 725);
            label5.Name = "label5";
            label5.Size = new Size(146, 49);
            label5.TabIndex = 11;
            label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.125F);
            label3.Location = new Point(527, 483);
            label3.Name = "label3";
            label3.Size = new Size(247, 49);
            label3.TabIndex = 12;
            label3.Text = "Số điện thoại";
            // 
            // lbMaKH
            // 
            lbMaKH.AutoSize = true;
            lbMaKH.Font = new Font("Times New Roman", 16.125F);
            lbMaKH.Location = new Point(527, 248);
            lbMaKH.Name = "lbMaKH";
            lbMaKH.Size = new Size(283, 49);
            lbMaKH.TabIndex = 13;
            lbMaKH.Text = "Mã khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.125F);
            label1.Location = new Point(527, 357);
            label1.Name = "label1";
            label1.Size = new Size(137, 49);
            label1.TabIndex = 14;
            label1.Text = "Họ tên";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Times New Roman", 16.125F);
            txtDiaChi.Location = new Point(359, 717);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(899, 57);
            txtDiaChi.TabIndex = 4;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Times New Roman", 16.125F);
            txtSDT.Location = new Point(859, 459);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(429, 57);
            txtSDT.TabIndex = 2;
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Times New Roman", 16.125F);
            txtTenKH.Location = new Point(859, 333);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(429, 57);
            txtTenKH.TabIndex = 1;
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Times New Roman", 16.125F);
            txtMaKH.Location = new Point(859, 230);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(429, 57);
            txtMaKH.TabIndex = 5;
            // 
            // btok
            // 
            btok.Location = new Point(568, 910);
            btok.Name = "btok";
            btok.Size = new Size(150, 46);
            btok.TabIndex = 16;
            btok.Text = "OK";
            btok.UseVisualStyleBackColor = true;
            btok.Click += btok_Click_1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Times New Roman", 16.125F);
            txtEmail.Location = new Point(859, 571);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(429, 57);
            txtEmail.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.125F);
            label4.Location = new Point(527, 571);
            label4.Name = "label4";
            label4.Size = new Size(123, 49);
            label4.TabIndex = 12;
            label4.Text = "Email";
            // 
            // picKhachnhan
            // 
            picKhachnhan.Image = (Image)resources.GetObject("picKhachnhan.Image");
            picKhachnhan.Location = new Point(39, 183);
            picKhachnhan.Name = "picKhachnhan";
            picKhachnhan.Size = new Size(451, 484);
            picKhachnhan.SizeMode = PictureBoxSizeMode.StretchImage;
            picKhachnhan.TabIndex = 17;
            picKhachnhan.TabStop = false;
            picKhachnhan.Click += picKhachgui_Click;
            // 
            // InfoKhachNhan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 1014);
            Controls.Add(picKhachnhan);
            Controls.Add(btok);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbMaKH);
            Controls.Add(label1);
            Controls.Add(txtDiaChi);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtTenKH);
            Controls.Add(txtMaKH);
            Name = "InfoKhachNhan";
            Text = "InfoKhachNhan";
            Load += InfoKhachNhan_Load;
            ((System.ComponentModel.ISupportInitialize)picKhachnhan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label3;
        private Label lbMaKH;
        private Label label1;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private Button btok;
        private TextBox txtEmail;
        private Label label4;
        private PictureBox picKhachnhan;
    }
}