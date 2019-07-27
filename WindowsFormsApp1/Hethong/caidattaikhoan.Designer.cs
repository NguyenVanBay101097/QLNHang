namespace WindowsFormsApp1.Hethong
{
    partial class caidattaikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(caidattaikhoan));
            this.opHinh = new System.Windows.Forms.OpenFileDialog();
            this.lnlTenDN = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.MaskedTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.MaskedTextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // opHinh
            // 
            this.opHinh.FileName = "openFileDialog1";
            // 
            // lnlTenDN
            // 
            this.lnlTenDN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlTenDN.Location = new System.Drawing.Point(20, 12);
            this.lnlTenDN.Name = "lnlTenDN";
            this.lnlTenDN.Size = new System.Drawing.Size(119, 20);
            this.lnlTenDN.TabIndex = 1;
            this.lnlTenDN.Text = "Tên đăng nhập:";
            this.lnlTenDN.UseWaitCursor = true;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Enabled = false;
            this.txtTenDN.Location = new System.Drawing.Point(172, 13);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.ReadOnly = true;
            this.txtTenDN.Size = new System.Drawing.Size(212, 20);
            this.txtTenDN.TabIndex = 0;
            this.txtTenDN.Text = "Nguyễn Văn Bảy";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lnlTenDN);
            this.panel6.Controls.Add(this.txtTenDN);
            this.panel6.Location = new System.Drawing.Point(137, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(401, 46);
            this.panel6.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nhân viên:";
            this.label1.UseWaitCursor = true;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Enabled = false;
            this.txtTenNhanVien.Location = new System.Drawing.Point(172, 13);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(212, 20);
            this.txtTenNhanVien.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTenNhanVien);
            this.panel2.Location = new System.Drawing.Point(137, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 52);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            this.label2.UseWaitCursor = true;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Enabled = false;
            this.txtMatKhau.Location = new System.Drawing.Point(172, 13);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(212, 20);
            this.txtMatKhau.TabIndex = 0;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu mới:";
            this.label3.UseWaitCursor = true;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Enabled = false;
            this.txtMatKhauMoi.Location = new System.Drawing.Point(172, 13);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(212, 20);
            this.txtMatKhauMoi.TabIndex = 0;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtMatKhauMoi);
            this.panel4.Location = new System.Drawing.Point(137, 185);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 52);
            this.panel4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập lại mật khẩu:";
            this.label4.UseWaitCursor = true;
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Enabled = false;
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(172, 13);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(212, 20);
            this.txtNhapLaiMatKhau.TabIndex = 0;
            this.txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Silver;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(137, 306);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(96, 35);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "Sửa";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtNhapLaiMatKhau);
            this.panel5.Location = new System.Drawing.Point(137, 243);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(401, 44);
            this.panel5.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtMatKhau);
            this.panel3.Location = new System.Drawing.Point(137, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 52);
            this.panel3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(233)))), ((int)(((byte)(247)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnhuy);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(263, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 375);
            this.panel1.TabIndex = 2;
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.Silver;
            this.btnluu.Enabled = false;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(281, 306);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(96, 35);
            this.btnluu.TabIndex = 15;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.Silver;
            this.btnhuy.Enabled = false;
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuy.Location = new System.Drawing.Point(422, 306);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(99, 35);
            this.btnhuy.TabIndex = 14;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // caidattaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 562);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "caidattaikhoan";
            this.Text = "tài khoản";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog opHinh;
        private System.Windows.Forms.Label lnlTenDN;
        private System.Windows.Forms.MaskedTextBox txtTenDN;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTenNhanVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtMatKhauMoi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
    }
}