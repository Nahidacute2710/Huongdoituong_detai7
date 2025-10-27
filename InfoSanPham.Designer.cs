namespace Test_Winform_detai7
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
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F);
            label5.Location = new Point(191, 533);
            label5.Name = "label5";
            label5.Size = new Size(120, 50);
            label5.TabIndex = 10;
            label5.Text = "Giá trị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.875F);
            label4.Location = new Point(191, 436);
            label4.Name = "label4";
            label4.Size = new Size(170, 50);
            label4.TabIndex = 11;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F);
            label3.Location = new Point(191, 333);
            label3.Name = "label3";
            label3.Size = new Size(172, 50);
            label3.TabIndex = 12;
            label3.Text = "Tính chất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F);
            label2.Location = new Point(191, 251);
            label2.Name = "label2";
            label2.Size = new Size(247, 50);
            label2.TabIndex = 13;
            label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F);
            label1.Location = new Point(191, 147);
            label1.Name = "label1";
            label1.Size = new Size(244, 50);
            label1.TabIndex = 14;
            label1.Text = "Mã sản phẩm";
            // 
            // txtGiaTri
            // 
            txtGiaTri.Font = new Font("Segoe UI", 13.875F);
            txtGiaTri.Location = new Point(540, 533);
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.Size = new Size(200, 57);
            txtGiaTri.TabIndex = 6;
            // 
            // txtTinhChat
            // 
            txtTinhChat.Font = new Font("Segoe UI", 13.875F);
            txtTinhChat.Location = new Point(540, 333);
            txtTinhChat.Name = "txtTinhChat";
            txtTinhChat.Size = new Size(200, 57);
            txtTinhChat.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 13.875F);
            txtSoLuong.Location = new Point(540, 436);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(200, 57);
            txtSoLuong.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 13.875F);
            txtTen.Location = new Point(540, 244);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(200, 57);
            txtTen.TabIndex = 8;
            // 
            // txtMa
            // 
            txtMa.Font = new Font("Segoe UI", 13.875F);
            txtMa.Location = new Point(540, 147);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(200, 57);
            txtMa.TabIndex = 4;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(540, 707);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 46);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(725, 707);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(150, 46);
            btnHuy.TabIndex = 15;
            btnHuy.Text = "Huy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // InfoSanPham
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 858);
            Controls.Add(btnHuy);
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
        private Button btnHuy;
    }
}