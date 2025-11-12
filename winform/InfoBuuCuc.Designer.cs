namespace OOP_De_tai_7
{
    partial class InfoBuuCuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoBuuCuc));
            lbMabc = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaBC = new TextBox();
            txtTenBC = new TextBox();
            txtDiaChi = new TextBox();
            picBuucuc = new PictureBox();
            btok = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBuucuc).BeginInit();
            SuspendLayout();
            // 
            // lbMabc
            // 
            lbMabc.AutoSize = true;
            lbMabc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMabc.Location = new Point(501, 246);
            lbMabc.Name = "lbMabc";
            lbMabc.Size = new Size(187, 45);
            lbMabc.TabIndex = 0;
            lbMabc.Text = "Mã bưu cục";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(501, 361);
            label2.Name = "label2";
            label2.Size = new Size(191, 45);
            label2.TabIndex = 0;
            label2.Text = "Tên bưu cục";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 579);
            label3.Name = "label3";
            label3.Size = new Size(116, 45);
            label3.TabIndex = 0;
            label3.Text = "Địa chỉ";
            // 
            // txtMaBC
            // 
            txtMaBC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaBC.Location = new Point(726, 241);
            txtMaBC.Name = "txtMaBC";
            txtMaBC.Size = new Size(317, 50);
            txtMaBC.TabIndex = 3;
            // 
            // txtTenBC
            // 
            txtTenBC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenBC.Location = new Point(726, 358);
            txtTenBC.Name = "txtTenBC";
            txtTenBC.Size = new Size(317, 50);
            txtTenBC.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi.Location = new Point(194, 579);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(684, 50);
            txtDiaChi.TabIndex = 2;
            // 
            // picBuucuc
            // 
            picBuucuc.Image = (Image)resources.GetObject("picBuucuc.Image");
            picBuucuc.Location = new Point(63, 160);
            picBuucuc.Name = "picBuucuc";
            picBuucuc.Size = new Size(370, 401);
            picBuucuc.SizeMode = PictureBoxSizeMode.StretchImage;
            picBuucuc.TabIndex = 9;
            picBuucuc.TabStop = false;
            picBuucuc.Click += picBuucuc_Click;
            // 
            // btok
            // 
            btok.Location = new Point(452, 666);
            btok.Name = "btok";
            btok.Size = new Size(150, 46);
            btok.TabIndex = 10;
            btok.Text = "OK";
            btok.UseVisualStyleBackColor = true;
            btok.Click += btok_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, 48);
            label1.Name = "label1";
            label1.Size = new Size(505, 78);
            label1.TabIndex = 11;
            label1.Text = "Thông tin bưu cục";
            // 
            // InfoBuuCuc
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 755);
            Controls.Add(label1);
            Controls.Add(btok);
            Controls.Add(picBuucuc);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenBC);
            Controls.Add(txtMaBC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbMabc);
            Name = "InfoBuuCuc";
            Text = "InfoBuuCuc";
            Load += InfoBuuCuc_Load;
            ((System.ComponentModel.ISupportInitialize)picBuucuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMabc;
        private Label label2;
        private Label label3;
        private TextBox txtMaBC;
        private TextBox txtTenBC;
        private TextBox txtDiaChi;
        private PictureBox picBuucuc;
        private Button btok;
        private Label label1;
    }
}