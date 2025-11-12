namespace OOP_De_tai_7
{
    partial class InfoSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoSanPham));
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGiaTri = new TextBox();
            txtTinhChat = new TextBox();
            txtSoLuong = new TextBox();
            txtTen = new TextBox();
            txtMa = new TextBox();
            btnLuu = new Button();
            label6 = new Label();
            picSanpham = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picSanpham).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F);
            label5.Location = new Point(580, 607);
            label5.Name = "label5";
            label5.Size = new Size(120, 50);
            label5.TabIndex = 10;
            label5.Text = "Giá trị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.875F);
            label4.Location = new Point(580, 510);
            label4.Name = "label4";
            label4.Size = new Size(170, 50);
            label4.TabIndex = 11;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F);
            label3.Location = new Point(580, 414);
            label3.Name = "label3";
            label3.Size = new Size(172, 50);
            label3.TabIndex = 12;
            label3.Text = "Tính chất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F);
            label2.Location = new Point(580, 325);
            label2.Name = "label2";
            label2.Size = new Size(247, 50);
            label2.TabIndex = 13;
            label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F);
            label1.Location = new Point(580, 221);
            label1.Name = "label1";
            label1.Size = new Size(244, 50);
            label1.TabIndex = 14;
            label1.Text = "Mã sản phẩm";
            // 
            // txtGiaTri
            // 
            txtGiaTri.Font = new Font("Segoe UI", 13.875F);
            txtGiaTri.Location = new Point(940, 607);
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.Size = new Size(342, 57);
            txtGiaTri.TabIndex = 4;
            // 
            // txtTinhChat
            // 
            txtTinhChat.Font = new Font("Segoe UI", 13.875F);
            txtTinhChat.Location = new Point(940, 407);
            txtTinhChat.Name = "txtTinhChat";
            txtTinhChat.Size = new Size(342, 57);
            txtTinhChat.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 13.875F);
            txtSoLuong.Location = new Point(940, 510);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(179, 57);
            txtSoLuong.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 13.875F);
            txtTen.Location = new Point(940, 318);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(342, 57);
            txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            txtMa.Font = new Font("Segoe UI", 13.875F);
            txtMa.Location = new Point(940, 214);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(342, 57);
            txtMa.TabIndex = 5;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(580, 730);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 64);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Ok";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(301, 52);
            label6.Name = "label6";
            label6.Size = new Size(739, 78);
            label6.TabIndex = 16;
            label6.Text = "Thông tin hàng vận chuyển";
            // 
            // picSanpham
            // 
            picSanpham.Image = (Image)resources.GetObject("picSanpham.Image");
            picSanpham.Location = new Point(76, 173);
            picSanpham.Name = "picSanpham";
            picSanpham.Size = new Size(436, 484);
            picSanpham.SizeMode = PictureBoxSizeMode.StretchImage;
            picSanpham.TabIndex = 17;
            picSanpham.TabStop = false;
            picSanpham.Click += picSanpham_Click;
            // 
            // InfoSanPham
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 844);
            Controls.Add(picSanpham);
            Controls.Add(label6);
            Controls.Add(btnLuu);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGiaTri);
            Controls.Add(txtTinhChat);
            Controls.Add(txtSoLuong);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Name = "InfoSanPham";
            Text = "InfoSanPham";
            Load += InfoSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)picSanpham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtGiaTri;
        private TextBox txtTinhChat;
        private TextBox txtSoLuong;
        private TextBox txtTen;
        private TextBox txtMa;
        private Button btnLuu;
        private Label label6;
        private PictureBox picSanpham;
    }
}