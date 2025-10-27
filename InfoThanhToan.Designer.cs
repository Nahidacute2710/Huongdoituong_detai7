namespace Test_Winform_detai7
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
            txtMaDH = new TextBox();
            txtThanhTien = new TextBox();
            dtNgayTT = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btok = new Button();
            cbPhuongThuc = new ComboBox();
            cbTrangThai = new ComboBox();
            SuspendLayout();
            // 
            // txtMa
            // 
            txtMa.Location = new Point(340, 92);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(200, 39);
            txtMa.TabIndex = 0;
            // 
            // txtMaDH
            // 
            txtMaDH.Location = new Point(340, 182);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(200, 39);
            txtMaDH.TabIndex = 1;
            txtMaDH.TextChanged += txtMaDH_TextChanged;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(340, 275);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(200, 39);
            txtThanhTien.TabIndex = 2;
            // 
            // dtNgayTT
            // 
            dtNgayTT.Location = new Point(340, 448);
            dtNgayTT.Name = "dtNgayTT";
            dtNgayTT.Size = new Size(400, 39);
            dtNgayTT.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 92);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 182);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 6;
            label2.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 282);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 6;
            label3.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 379);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 6;
            label4.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 455);
            label5.Name = "label5";
            label5.Size = new Size(78, 32);
            label5.TabIndex = 6;
            label5.Text = "label1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(172, 540);
            label6.Name = "label6";
            label6.Size = new Size(78, 32);
            label6.TabIndex = 6;
            label6.Text = "label1";
            // 
            // btok
            // 
            btok.Location = new Point(850, 310);
            btok.Name = "btok";
            btok.Size = new Size(150, 46);
            btok.TabIndex = 9;
            btok.Text = "OK";
            btok.UseVisualStyleBackColor = true;
            btok.Click += btok_Click;
            // 
            // cbPhuongThuc
            // 
            cbPhuongThuc.FormattingEnabled = true;
            cbPhuongThuc.Location = new Point(331, 371);
            cbPhuongThuc.Name = "cbPhuongThuc";
            cbPhuongThuc.Size = new Size(242, 40);
            cbPhuongThuc.TabIndex = 10;
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(331, 537);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(242, 40);
            cbTrangThai.TabIndex = 10;
            // 
            // InfoThanhToan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 768);
            Controls.Add(cbTrangThai);
            Controls.Add(cbPhuongThuc);
            Controls.Add(btok);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtNgayTT);
            Controls.Add(txtThanhTien);
            Controls.Add(txtMaDH);
            Controls.Add(txtMa);
            Name = "InfoThanhToan";
            Text = "InfoThanhToan";
            Load += InfoThanhToan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMa;
        private TextBox txtMaDH;
        private TextBox txtThanhTien;
        private DateTimePicker dtNgayTT;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btok;
        private ComboBox cbPhuongThuc;
        private ComboBox cbTrangThai;
    }
}