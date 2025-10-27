namespace Test_Winform_detai7
{
    partial class InfoTaiXe
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
            txtTen = new TextBox();
            txtSDT = new TextBox();
            txtBSX = new TextBox();
            txtLX = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btok = new Button();
            cbBuuCuc = new ComboBox();
            SuspendLayout();
            // 
            // txtMa
            // 
            txtMa.Font = new Font("Segoe UI", 13.875F);
            txtMa.Location = new Point(444, 116);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(200, 57);
            txtMa.TabIndex = 0;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 13.875F);
            txtTen.Location = new Point(444, 213);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(200, 57);
            txtTen.TabIndex = 1;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 13.875F);
            txtSDT.Location = new Point(444, 302);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(200, 57);
            txtSDT.TabIndex = 1;
            // 
            // txtBSX
            // 
            txtBSX.Font = new Font("Segoe UI", 13.875F);
            txtBSX.Location = new Point(444, 405);
            txtBSX.Name = "txtBSX";
            txtBSX.Size = new Size(200, 57);
            txtBSX.TabIndex = 0;
            // 
            // txtLX
            // 
            txtLX.Font = new Font("Segoe UI", 13.875F);
            txtLX.Location = new Point(444, 502);
            txtLX.Name = "txtLX";
            txtLX.Size = new Size(200, 57);
            txtLX.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F);
            label1.Location = new Point(95, 116);
            label1.Name = "label1";
            label1.Size = new Size(243, 50);
            label1.TabIndex = 2;
            label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F);
            label2.Location = new Point(95, 220);
            label2.Name = "label2";
            label2.Size = new Size(133, 50);
            label2.TabIndex = 2;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F);
            label3.Location = new Point(95, 302);
            label3.Name = "label3";
            label3.Size = new Size(239, 50);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.875F);
            label4.Location = new Point(95, 405);
            label4.Name = "label4";
            label4.Size = new Size(186, 50);
            label4.TabIndex = 2;
            label4.Text = "Biển số xe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F);
            label5.Location = new Point(95, 502);
            label5.Name = "label5";
            label5.Size = new Size(135, 50);
            label5.TabIndex = 2;
            label5.Text = "Loại xe";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.875F);
            label6.Location = new Point(95, 595);
            label6.Name = "label6";
            label6.Size = new Size(151, 50);
            label6.TabIndex = 2;
            label6.Text = "Bưu cục";
            // 
            // btok
            // 
            btok.Location = new Point(373, 692);
            btok.Name = "btok";
            btok.Size = new Size(150, 46);
            btok.TabIndex = 8;
            btok.Text = "OK";
            btok.UseVisualStyleBackColor = true;
            btok.Click += btok_Click;
            // 
            // cbBuuCuc
            // 
            cbBuuCuc.FormattingEnabled = true;
            cbBuuCuc.Location = new Point(444, 605);
            cbBuuCuc.Name = "cbBuuCuc";
            cbBuuCuc.Size = new Size(242, 40);
            cbBuuCuc.TabIndex = 9;
            // 
            // InfoTaiXe
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 827);
            Controls.Add(cbBuuCuc);
            Controls.Add(btok);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLX);
            Controls.Add(txtSDT);
            Controls.Add(txtBSX);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Name = "InfoTaiXe";
            Text = "InfoTaiXe";
            Load += InfoTaiXe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtSDT;
        private TextBox txtBSX;
        private TextBox txtLX;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btok;
        private ComboBox cbBuuCuc;
    }
}