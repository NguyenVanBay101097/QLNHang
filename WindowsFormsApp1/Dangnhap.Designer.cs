namespace WindowsFormsApp1
{
    partial class Dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnthoát = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTenDN = new System.Windows.Forms.MaskedTextBox();
            this.lnlTenDN = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 334);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(101, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(153, 189);
            this.panel5.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(258, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 189);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtMatKhau);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(28, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 41);
            this.panel3.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(149, 13);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(198, 20);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.btnthoát);
            this.panel4.Controls.Add(this.btnLogin);
            this.panel4.Location = new System.Drawing.Point(24, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 37);
            this.panel4.TabIndex = 5;
            // 
            // btnthoát
            // 
            this.btnthoát.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnthoát.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoát.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoát.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoát.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnthoát.Image = ((System.Drawing.Image)(resources.GetObject("btnthoát.Image")));
            this.btnthoát.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoát.Location = new System.Drawing.Point(252, 3);
            this.btnthoát.Name = "btnthoát";
            this.btnthoát.Size = new System.Drawing.Size(99, 24);
            this.btnthoát.TabIndex = 5;
            this.btnthoát.Text = "Thoát";
            this.btnthoát.UseVisualStyleBackColor = false;
            this.btnthoát.Click += new System.EventHandler(this.btnthoát_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(141, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 24);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtTenDN);
            this.panel6.Controls.Add(this.lnlTenDN);
            this.panel6.Location = new System.Drawing.Point(28, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(353, 44);
            this.panel6.TabIndex = 4;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(149, 11);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(198, 20);
            this.txtTenDN.TabIndex = 2;
            // 
            // lnlTenDN
            // 
            this.lnlTenDN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlTenDN.Location = new System.Drawing.Point(3, 12);
            this.lnlTenDN.Name = "lnlTenDN";
            this.lnlTenDN.Size = new System.Drawing.Size(119, 20);
            this.lnlTenDN.TabIndex = 1;
            this.lnlTenDN.Text = "Tên đăng nhập:";
            // 
            // Dangnhap
            // 
            this.ClientSize = new System.Drawing.Size(738, 334);
            this.Controls.Add(this.panel1);
            this.Name = "Dangnhap";
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnthoát;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.MaskedTextBox txtTenDN;
        private System.Windows.Forms.Label lnlTenDN;
    }
}

