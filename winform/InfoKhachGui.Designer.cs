namespace OOP_De_tai_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoKhachGui));
            txtMaKH = new TextBox();
            txtTenKH = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            label1 = new Label();
            labelMaKH = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            btok = new Button();
            txtEmail = new TextBox();
            label4 = new Label();
            picKhachgui = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picKhachgui).BeginInit();
            SuspendLayout();
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Times New Roman", 16.125F);
            txtMaKH.Location = new Point(865, 236);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(429, 57);
            txtMaKH.TabIndex = 5;
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Times New Roman", 16.125F);
            txtTenKH.Location = new Point(865, 339);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(429, 57);
            txtTenKH.TabIndex = 1;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Times New Roman", 16.125F);
            txtSDT.Location = new Point(865, 540);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(429, 57);
            txtSDT.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Times New Roman", 16.125F);
            txtDiaChi.Location = new Point(374, 726);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(953, 57);
            txtDiaChi.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.125F);
            label1.Location = new Point(559, 347);
            label1.Name = "label1";
            label1.Size = new Size(137, 49);
            label1.TabIndex = 5;
            label1.Text = "Họ tên";
            // 
            // labelMaKH
            // 
            labelMaKH.AutoSize = true;
            labelMaKH.Font = new Font("Times New Roman", 16.125F);
            labelMaKH.Location = new Point(559, 244);
            labelMaKH.Name = "labelMaKH";
            labelMaKH.Size = new Size(283, 49);
            labelMaKH.TabIndex = 5;
            labelMaKH.Text = "Mã khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.125F);
            label3.Location = new Point(559, 548);
            label3.Name = "label3";
            label3.Size = new Size(247, 49);
            label3.TabIndex = 5;
            label3.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.125F);
            label5.Location = new Point(132, 726);
            label5.Name = "label5";
            label5.Size = new Size(146, 49);
            label5.TabIndex = 5;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(441, 55);
            label6.Name = "label6";
            label6.Size = new Size(498, 71);
            label6.TabIndex = 6;
            label6.Text = "Thông tin khách gửi";
            // 
            // btok
            // 
            btok.Location = new Point(569, 878);
            btok.Name = "btok";
            btok.Size = new Size(150, 46);
            btok.TabIndex = 7;
            btok.Text = "OK";
            btok.UseVisualStyleBackColor = true;
            btok.Click += btok_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Times New Roman", 16.125F);
            txtEmail.Location = new Point(865, 442);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(429, 57);
            txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.125F);
            label4.Location = new Point(559, 450);
            label4.Name = "label4";
            label4.Size = new Size(123, 49);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // picKhachgui
            // 
            picKhachgui.Image = (Image)resources.GetObject("picKhachgui.Image");
            picKhachgui.Location = new Point(29, 167);
            picKhachgui.Name = "picKhachgui";
            picKhachgui.Size = new Size(436, 484);
            picKhachgui.SizeMode = PictureBoxSizeMode.StretchImage;
            picKhachgui.TabIndex = 8;
            picKhachgui.TabStop = false;
            picKhachgui.Click += picKhachgui_Click;
            // 
            // InfoKhachGui
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 978);
            Controls.Add(picKhachgui);
            Controls.Add(btok);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(labelMaKH);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtDiaChi);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtTenKH);
            Controls.Add(txtMaKH);
            Name = "InfoKhachGui";
            Text = "InfoNhanVien";
            Load += InfoKhachGui_Load;
            ((System.ComponentModel.ISupportInitialize)picKhachgui).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaKH;
        private TextBox txtTenKH;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private Label label1;
        private Label labelMaKH;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button btok;
        private TextBox txtEmail;
        private Label label4;
        private PictureBox picKhachgui;
    }
}
