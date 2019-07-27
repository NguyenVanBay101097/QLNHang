namespace WindowsFormsApp1.thongke
{
    partial class doanhthu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doanhthu));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Ngày hôm nay");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tháng trước");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Qúy trước");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Năm trước");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Tuần trước");
            this.lblTong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.dtpkDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkTuNgay = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLamMoiDU = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btntim = new System.Windows.Forms.Button();
            this.txtMaDU = new System.Windows.Forms.MaskedTextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grvTKHoaDon = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienkm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANCAFFEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.imglThhongKe = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTKHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANCAFFEDataSetBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.Color.Red;
            this.lblTong.Location = new System.Drawing.Point(820, 509);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(90, 13);
            this.lblTong.TabIndex = 11;
            this.lblTong.Text = "2.000.000 vnđ";
            this.lblTong.Click += new System.EventHandler(this.lblTong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(745, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng tiền:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(546, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(78, 23);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dtpkDenNgay
            // 
            this.dtpkDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpkDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDenNgay.Location = new System.Drawing.Point(336, 3);
            this.dtpkDenNgay.Name = "dtpkDenNgay";
            this.dtpkDenNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpkDenNgay.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày";
            // 
            // dtpkTuNgay
            // 
            this.dtpkTuNgay.CalendarMonthBackground = System.Drawing.Color.CornflowerBlue;
            this.dtpkTuNgay.CausesValidation = false;
            this.dtpkTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpkTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTuNgay.Location = new System.Drawing.Point(62, 3);
            this.dtpkTuNgay.Name = "dtpkTuNgay";
            this.dtpkTuNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpkTuNgay.TabIndex = 0;
            this.dtpkTuNgay.Value = new System.DateTime(2018, 4, 30, 18, 50, 12, 0);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnLamMoiDU);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btnXem);
            this.panel3.Controls.Add(this.dtpkDenNgay);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpkTuNgay);
            this.panel3.Location = new System.Drawing.Point(129, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1019, 32);
            this.panel3.TabIndex = 8;
            // 
            // btnLamMoiDU
            // 
            this.btnLamMoiDU.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLamMoiDU.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoiDU.Image")));
            this.btnLamMoiDU.Location = new System.Drawing.Point(633, 2);
            this.btnLamMoiDU.Name = "btnLamMoiDU";
            this.btnLamMoiDU.Size = new System.Drawing.Size(80, 25);
            this.btnLamMoiDU.TabIndex = 6;
            this.btnLamMoiDU.Text = "Refresh";
            this.btnLamMoiDU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoiDU.UseVisualStyleBackColor = false;
            this.btnLamMoiDU.Click += new System.EventHandler(this.btnLamMoiDU_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btntim);
            this.panel5.Controls.Add(this.txtMaDU);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(731, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(286, 30);
            this.panel5.TabIndex = 5;
            // 
            // btntim
            // 
            this.btntim.Enabled = false;
            this.btntim.Image = ((System.Drawing.Image)(resources.GetObject("btntim.Image")));
            this.btntim.Location = new System.Drawing.Point(213, 1);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(67, 23);
            this.btntim.TabIndex = 2;
            this.btntim.Text = "Tìm";
            this.btntim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.txtTimDU_Click);
            // 
            // txtMaDU
            // 
            this.txtMaDU.Location = new System.Drawing.Point(13, 3);
            this.txtMaDU.Name = "txtMaDU";
            this.txtMaDU.Size = new System.Drawing.Size(191, 20);
            this.txtMaDU.TabIndex = 3;
            this.txtMaDU.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaDU_KeyUp);
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(943, 506);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(87, 23);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.grvTKHoaDon);
            this.panel2.Location = new System.Drawing.Point(413, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 454);
            this.panel2.TabIndex = 7;
            // 
            // grvTKHoaDon
            // 
            this.grvTKHoaDon.AutoGenerateColumns = false;
            this.grvTKHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvTKHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grvTKHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTKHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.IDHoaDon,
            this.phong,
            this.tienphong,
            this.tienkm,
            this.NhanVien,
            this.NgayLap,
            this.TongTien});
            this.grvTKHoaDon.DataSource = this.qUANCAFFEDataSetBindingSource;
            this.grvTKHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvTKHoaDon.Location = new System.Drawing.Point(0, 0);
            this.grvTKHoaDon.Name = "grvTKHoaDon";
            this.grvTKHoaDon.ReadOnly = true;
            this.grvTKHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvTKHoaDon.Size = new System.Drawing.Size(735, 454);
            this.grvTKHoaDon.TabIndex = 0;
            this.grvTKHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTKHoaDon_CellDoubleClick);
            this.grvTKHoaDon.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grvTKHoaDon_RowPostPaint);
            // 
            // stt
            // 
            this.stt.DataPropertyName = "stt";
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // IDHoaDon
            // 
            this.IDHoaDon.DataPropertyName = "mahoadon";
            this.IDHoaDon.HeaderText = "Hóa đơn";
            this.IDHoaDon.Name = "IDHoaDon";
            this.IDHoaDon.ReadOnly = true;
            // 
            // phong
            // 
            this.phong.DataPropertyName = "phong";
            this.phong.HeaderText = "Phòng/Bàn";
            this.phong.Name = "phong";
            this.phong.ReadOnly = true;
            // 
            // tienphong
            // 
            this.tienphong.DataPropertyName = "tienphong";
            this.tienphong.HeaderText = "Tiền Phòng";
            this.tienphong.Name = "tienphong";
            this.tienphong.ReadOnly = true;
            // 
            // tienkm
            // 
            this.tienkm.DataPropertyName = "tienkm";
            this.tienkm.HeaderText = "Tiền Khuyến mãi";
            this.tienkm.Name = "tienkm";
            this.tienkm.ReadOnly = true;
            // 
            // NhanVien
            // 
            this.NhanVien.DataPropertyName = "nhanvienlap";
            this.NhanVien.HeaderText = "Nhân viên lập";
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "ngaylap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "tongtien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê theo";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 29);
            this.panel4.TabIndex = 0;
            // 
            // imglThhongKe
            // 
            this.imglThhongKe.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglThhongKe.ImageStream")));
            this.imglThhongKe.TransparentColor = System.Drawing.Color.Transparent;
            this.imglThhongKe.Images.SetKeyName(0, "icons8-calendar-18.png");
            this.imglThhongKe.Images.SetKeyName(1, "icons8-calendar-18.png");
            this.imglThhongKe.Images.SetKeyName(2, "icons8-calendar-18.png");
            this.imglThhongKe.Images.SetKeyName(3, "icons8-calendar-18.png");
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imglThhongKe;
            this.treeView1.Location = new System.Drawing.Point(3, 35);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "TKNgayHomNay";
            treeNode1.Text = "Ngày hôm nay";
            treeNode2.Name = "TKThangTruoc";
            treeNode2.Text = "Tháng trước";
            treeNode3.Name = "TKQuyTruoc";
            treeNode3.Text = "Qúy trước";
            treeNode4.Name = "TKNamTruoc";
            treeNode4.Text = "Năm trước";
            treeNode5.Name = "TKTuanTruoc";
            treeNode5.Text = "Tuần trước";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(274, 416);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(129, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 454);
            this.panel1.TabIndex = 6;
            // 
            // doanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1268, 562);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "doanhthu";
            this.Text = "doanh thu";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTKHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANCAFFEDataSetBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DateTimePicker dtpkDenNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkTuNgay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource qUANCAFFEDataSetBindingSource;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grvTKHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ImageList imglThhongKe;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.MaskedTextBox txtMaDU;
        private System.Windows.Forms.Button btnLamMoiDU;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienkm;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}