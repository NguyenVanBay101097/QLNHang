namespace WindowsFormsApp1
{
    partial class chitiethoadon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chitiethoadon));
            this.grvCTBanTest = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel26 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvCTBanTest)).BeginInit();
            this.panel26.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvCTBanTest
            // 
            this.grvCTBanTest.AllowUserToAddRows = false;
            this.grvCTBanTest.AllowUserToOrderColumns = true;
            this.grvCTBanTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvCTBanTest.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCTBanTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvCTBanTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCTBanTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.TenMatHang,
            this.DonViTinh,
            this.SoL,
            this.GiaBan1,
            this.ThanhTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvCTBanTest.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvCTBanTest.EnableHeadersVisualStyles = false;
            this.grvCTBanTest.Location = new System.Drawing.Point(56, 36);
            this.grvCTBanTest.Name = "grvCTBanTest";
            this.grvCTBanTest.ReadOnly = true;
            this.grvCTBanTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvCTBanTest.Size = new System.Drawing.Size(689, 323);
            this.grvCTBanTest.TabIndex = 14;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // TenMatHang
            // 
            this.TenMatHang.DataPropertyName = "mathang";
            this.TenMatHang.HeaderText = "Mặt hàng";
            this.TenMatHang.Name = "TenMatHang";
            this.TenMatHang.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "soluong";
            this.DonViTinh.HeaderText = "Số lượng";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // SoL
            // 
            this.SoL.DataPropertyName = "donvi";
            this.SoL.HeaderText = "Đơn vị";
            this.SoL.Name = "SoL";
            this.SoL.ReadOnly = true;
            this.SoL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GiaBan1
            // 
            this.GiaBan1.DataPropertyName = "gia";
            this.GiaBan1.HeaderText = "Giá";
            this.GiaBan1.Name = "GiaBan1";
            this.GiaBan1.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "thanhtien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.Color.Red;
            this.lblTong.Location = new System.Drawing.Point(522, 365);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(90, 13);
            this.lblTong.TabIndex = 17;
            this.lblTong.Text = "2.000.000 vnđ";
            this.lblTong.Click += new System.EventHandler(this.lblTong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tiền món ăn:";
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(658, 365);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(87, 23);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "In hóa đơn";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel26.Controls.Add(this.label1);
            this.panel26.Controls.Add(this.label24);
            this.panel26.Location = new System.Drawing.Point(56, 4);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(689, 32);
            this.panel26.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "H00012";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(128, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "thông tin chi tiết hóa đơn ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(522, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "2.000.000 vnđ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tiền Dịch vụ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(522, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "2.000.000 vnđ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tiền đồ uống:";
            // 
            // chitiethoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel26);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.grvCTBanTest);
            this.Name = "chitiethoadon";
            this.Text = "chi tiết";
            ((System.ComponentModel.ISupportInitialize)(this.grvCTBanTest)).EndInit();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvCTBanTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}