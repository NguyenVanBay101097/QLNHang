namespace WindowsFormsApp1
{
    partial class frmBAN
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
            this.tcdanhsachban_phong = new System.Windows.Forms.TabControl();
            this.tpBan = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpDSBan = new System.Windows.Forms.FlowLayoutPanel();
            this.tpPhong = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.flpPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.tcdanhsachban_phong.SuspendLayout();
            this.tpBan.SuspendLayout();
            this.tpPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcdanhsachban_phong
            // 
            this.tcdanhsachban_phong.Controls.Add(this.tpBan);
            this.tcdanhsachban_phong.Controls.Add(this.tpPhong);
            this.tcdanhsachban_phong.Location = new System.Drawing.Point(12, 5);
            this.tcdanhsachban_phong.Name = "tcdanhsachban_phong";
            this.tcdanhsachban_phong.SelectedIndex = 0;
            this.tcdanhsachban_phong.Size = new System.Drawing.Size(504, 522);
            this.tcdanhsachban_phong.TabIndex = 1;
            // 
            // tpBan
            // 
            this.tpBan.Controls.Add(this.label5);
            this.tpBan.Controls.Add(this.label2);
            this.tpBan.Controls.Add(this.panel5);
            this.tpBan.Controls.Add(this.panel2);
            this.tpBan.Controls.Add(this.flpDSBan);
            this.tpBan.Location = new System.Drawing.Point(4, 22);
            this.tpBan.Name = "tpBan";
            this.tpBan.Padding = new System.Windows.Forms.Padding(3);
            this.tpBan.Size = new System.Drawing.Size(496, 496);
            this.tpBan.TabIndex = 0;
            this.tpBan.Text = "Bàn";
            this.tpBan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "bàn trống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "bàn đang sử dụng";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel5.Location = new System.Drawing.Point(226, 474);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(41, 19);
            this.panel5.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(9, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(41, 19);
            this.panel2.TabIndex = 3;
            // 
            // flpDSBan
            // 
            this.flpDSBan.AutoScroll = true;
            this.flpDSBan.BackColor = System.Drawing.SystemColors.Control;
            this.flpDSBan.Location = new System.Drawing.Point(3, 3);
            this.flpDSBan.Name = "flpDSBan";
            this.flpDSBan.Size = new System.Drawing.Size(490, 465);
            this.flpDSBan.TabIndex = 1;
            // 
            // tpPhong
            // 
            this.tpPhong.Controls.Add(this.label9);
            this.tpPhong.Controls.Add(this.label10);
            this.tpPhong.Controls.Add(this.panel7);
            this.tpPhong.Controls.Add(this.panel9);
            this.tpPhong.Controls.Add(this.flpPhong);
            this.tpPhong.Location = new System.Drawing.Point(4, 22);
            this.tpPhong.Name = "tpPhong";
            this.tpPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tpPhong.Size = new System.Drawing.Size(496, 496);
            this.tpPhong.TabIndex = 1;
            this.tpPhong.Text = "Phòng";
            this.tpPhong.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(280, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "phòng trống";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "phòng đang sử dụng";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel7.Location = new System.Drawing.Point(233, 474);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(41, 19);
            this.panel7.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.OrangeRed;
            this.panel9.Location = new System.Drawing.Point(16, 472);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(41, 19);
            this.panel9.TabIndex = 7;
            // 
            // flpPhong
            // 
            this.flpPhong.AutoScroll = true;
            this.flpPhong.BackColor = System.Drawing.SystemColors.Control;
            this.flpPhong.Location = new System.Drawing.Point(3, 2);
            this.flpPhong.Name = "flpPhong";
            this.flpPhong.Size = new System.Drawing.Size(490, 464);
            this.flpPhong.TabIndex = 2;
            // 
            // frmBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 539);
            this.Controls.Add(this.tcdanhsachban_phong);
            this.Name = "frmBAN";
            this.Text = "frmBAN";
            this.tcdanhsachban_phong.ResumeLayout(false);
            this.tpBan.ResumeLayout(false);
            this.tpBan.PerformLayout();
            this.tpPhong.ResumeLayout(false);
            this.tpPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcdanhsachban_phong;
        private System.Windows.Forms.TabPage tpBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpDSBan;
        private System.Windows.Forms.TabPage tpPhong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.FlowLayoutPanel flpPhong;
    }
}