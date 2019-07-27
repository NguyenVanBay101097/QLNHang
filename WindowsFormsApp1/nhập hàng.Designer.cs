namespace WindowsFormsApp1
{
    partial class nhập_hàng
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhập_hàng));
            this.panel70 = new System.Windows.Forms.Panel();
            this.cbbDVT = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dtpkNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbtenmathang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbdanhmuc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grvDanhsach = new System.Windows.Forms.DataGridView();
            this.madon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhmuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaihang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel26 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnThemDU = new System.Windows.Forms.Button();
            this.btnLamMoiDU = new System.Windows.Forms.Button();
            this.btnSuaDU = new System.Windows.Forms.Button();
            this.btnXoaDU = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmadon = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbloaihang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtsoluong = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtgianhap = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimDoUong = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.MaskedTextBox();
            this.panel70.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhsach)).BeginInit();
            this.panel26.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel70
            // 
            this.panel70.Controls.Add(this.cbbDVT);
            this.panel70.Controls.Add(this.label51);
            this.panel70.Location = new System.Drawing.Point(114, 158);
            this.panel70.Name = "panel70";
            this.panel70.Size = new System.Drawing.Size(662, 24);
            this.panel70.TabIndex = 14;
            // 
            // cbbDVT
            // 
            this.cbbDVT.AutoCompleteCustomSource.AddRange(new string[] {
            "ly",
            "lon",
            "chai",
            "thùng",
            "ds"});
            this.cbbDVT.BackColor = System.Drawing.Color.White;
            this.cbbDVT.DisplayMember = "IDCV";
            this.cbbDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDVT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbDVT.FormattingEnabled = true;
            this.cbbDVT.Items.AddRange(new object[] {
            "Ly",
            "Lon",
            "Chai",
            "Hộp"});
            this.cbbDVT.Location = new System.Drawing.Point(111, 1);
            this.cbbDVT.Name = "cbbDVT";
            this.cbbDVT.Size = new System.Drawing.Size(547, 21);
            this.cbbDVT.TabIndex = 2;
            this.cbbDVT.ValueMember = "IDLoai";
            // 
            // label51
            // 
            this.label51.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(3, 1);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(84, 20);
            this.label51.TabIndex = 1;
            this.label51.Text = "Đơn vị tính";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dtpkNgayNhap);
            this.panel15.Controls.Add(this.label22);
            this.panel15.Location = new System.Drawing.Point(114, 263);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(662, 28);
            this.panel15.TabIndex = 16;
            // 
            // dtpkNgayNhap
            // 
            this.dtpkNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayNhap.Location = new System.Drawing.Point(111, 4);
            this.dtpkNgayNhap.Name = "dtpkNgayNhap";
            this.dtpkNgayNhap.Size = new System.Drawing.Size(547, 20);
            this.dtpkNgayNhap.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 20);
            this.label22.TabIndex = 1;
            this.label22.Text = "Ngày nhập";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbtenmathang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(114, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 24);
            this.panel1.TabIndex = 17;
            // 
            // cbbtenmathang
            // 
            this.cbbtenmathang.AutoCompleteCustomSource.AddRange(new string[] {
            "ly",
            "lon",
            "chai",
            "thùng",
            "ds"});
            this.cbbtenmathang.BackColor = System.Drawing.Color.White;
            this.cbbtenmathang.DisplayMember = "IDCV";
            this.cbbtenmathang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbtenmathang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbtenmathang.FormattingEnabled = true;
            this.cbbtenmathang.Items.AddRange(new object[] {
            "bia tiger",
            "bia sài gòn",
            "bia bababa"});
            this.cbbtenmathang.Location = new System.Drawing.Point(111, 3);
            this.cbbtenmathang.Name = "cbbtenmathang";
            this.cbbtenmathang.Size = new System.Drawing.Size(547, 21);
            this.cbbtenmathang.TabIndex = 4;
            this.cbbtenmathang.ValueMember = "IDLoai";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên mặt hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbdanhmuc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(114, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 24);
            this.panel2.TabIndex = 18;
            // 
            // cbbdanhmuc
            // 
            this.cbbdanhmuc.AutoCompleteCustomSource.AddRange(new string[] {
            "ly",
            "lon",
            "chai",
            "thùng",
            "ds"});
            this.cbbdanhmuc.BackColor = System.Drawing.Color.White;
            this.cbbdanhmuc.DisplayMember = "IDCV";
            this.cbbdanhmuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbdanhmuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbdanhmuc.FormattingEnabled = true;
            this.cbbdanhmuc.Items.AddRange(new object[] {
            "nguyên liệu",
            "đồ uống"});
            this.cbbdanhmuc.Location = new System.Drawing.Point(111, 2);
            this.cbbdanhmuc.Name = "cbbdanhmuc";
            this.cbbdanhmuc.Size = new System.Drawing.Size(547, 21);
            this.cbbdanhmuc.TabIndex = 3;
            this.cbbdanhmuc.ValueMember = "IDLoai";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh mục";
            // 
            // grvDanhsach
            // 
            this.grvDanhsach.AllowUserToOrderColumns = true;
            this.grvDanhsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvDanhsach.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvDanhsach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grvDanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madon,
            this.danhmuc,
            this.loaihang,
            this.tenmathang,
            this.donvi,
            this.soluong,
            this.gianhap,
            this.ngaynhap});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvDanhsach.DefaultCellStyle = dataGridViewCellStyle6;
            this.grvDanhsach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grvDanhsach.EnableHeadersVisualStyles = false;
            this.grvDanhsach.Location = new System.Drawing.Point(0, 381);
            this.grvDanhsach.MultiSelect = false;
            this.grvDanhsach.Name = "grvDanhsach";
            this.grvDanhsach.ReadOnly = true;
            this.grvDanhsach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDanhsach.Size = new System.Drawing.Size(1284, 220);
            this.grvDanhsach.TabIndex = 20;
            this.grvDanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDanhsach_CellClick);
            this.grvDanhsach.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grvDanhsach_DataBindingComplete);
            // 
            // madon
            // 
            this.madon.DataPropertyName = "madon";
            this.madon.HeaderText = "Mã đơn";
            this.madon.Name = "madon";
            this.madon.ReadOnly = true;
            // 
            // danhmuc
            // 
            this.danhmuc.DataPropertyName = "danhmuc";
            this.danhmuc.HeaderText = "Danh mục";
            this.danhmuc.Name = "danhmuc";
            this.danhmuc.ReadOnly = true;
            // 
            // loaihang
            // 
            this.loaihang.DataPropertyName = "loaihang";
            this.loaihang.HeaderText = "Loại hàng";
            this.loaihang.Name = "loaihang";
            this.loaihang.ReadOnly = true;
            // 
            // tenmathang
            // 
            this.tenmathang.DataPropertyName = "tenmathang";
            this.tenmathang.HeaderText = "Tên mặt hàng";
            this.tenmathang.Name = "tenmathang";
            this.tenmathang.ReadOnly = true;
            // 
            // donvi
            // 
            this.donvi.DataPropertyName = "donvi";
            this.donvi.HeaderText = "Đơn vị";
            this.donvi.Name = "donvi";
            this.donvi.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // gianhap
            // 
            this.gianhap.DataPropertyName = "gianhap";
            this.gianhap.HeaderText = "Giá nhập";
            this.gianhap.Name = "gianhap";
            this.gianhap.ReadOnly = true;
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "ngày nhập";
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.ReadOnly = true;
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel26.Controls.Add(this.btnTimDoUong);
            this.panel26.Controls.Add(this.txttim);
            this.panel26.Controls.Add(this.label24);
            this.panel26.Location = new System.Drawing.Point(0, 303);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(1284, 32);
            this.panel26.TabIndex = 19;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(135, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Danh sách đơn hàng nhập";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnluu);
            this.panel3.Controls.Add(this.btnhuy);
            this.panel3.Controls.Add(this.btnThemDU);
            this.panel3.Controls.Add(this.btnLamMoiDU);
            this.panel3.Controls.Add(this.btnSuaDU);
            this.panel3.Controls.Add(this.btnXoaDU);
            this.panel3.Location = new System.Drawing.Point(874, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 293);
            this.panel3.TabIndex = 21;
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(58, 151);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(103, 32);
            this.btnluu.TabIndex = 11;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(58, 204);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(103, 27);
            this.btnhuy.TabIndex = 10;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnThemDU
            // 
            this.btnThemDU.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDU.Image")));
            this.btnThemDU.Location = new System.Drawing.Point(58, 13);
            this.btnThemDU.Name = "btnThemDU";
            this.btnThemDU.Size = new System.Drawing.Size(103, 27);
            this.btnThemDU.TabIndex = 8;
            this.btnThemDU.Text = "Thêm";
            this.btnThemDU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemDU.UseVisualStyleBackColor = true;
            this.btnThemDU.Click += new System.EventHandler(this.btnThemDU_Click);
            // 
            // btnLamMoiDU
            // 
            this.btnLamMoiDU.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLamMoiDU.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoiDU.Image")));
            this.btnLamMoiDU.Location = new System.Drawing.Point(58, 247);
            this.btnLamMoiDU.Name = "btnLamMoiDU";
            this.btnLamMoiDU.Size = new System.Drawing.Size(106, 29);
            this.btnLamMoiDU.TabIndex = 7;
            this.btnLamMoiDU.Text = "Refresh";
            this.btnLamMoiDU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoiDU.UseVisualStyleBackColor = false;
            this.btnLamMoiDU.Click += new System.EventHandler(this.btnLamMoiDU_Click);
            // 
            // btnSuaDU
            // 
            this.btnSuaDU.Enabled = false;
            this.btnSuaDU.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDU.Image")));
            this.btnSuaDU.Location = new System.Drawing.Point(58, 105);
            this.btnSuaDU.Name = "btnSuaDU";
            this.btnSuaDU.Size = new System.Drawing.Size(103, 27);
            this.btnSuaDU.TabIndex = 6;
            this.btnSuaDU.Text = "Sửa";
            this.btnSuaDU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaDU.UseVisualStyleBackColor = true;
            this.btnSuaDU.Click += new System.EventHandler(this.btnSuaDU_Click);
            // 
            // btnXoaDU
            // 
            this.btnXoaDU.Enabled = false;
            this.btnXoaDU.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDU.Image")));
            this.btnXoaDU.Location = new System.Drawing.Point(58, 56);
            this.btnXoaDU.Name = "btnXoaDU";
            this.btnXoaDU.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnXoaDU.Size = new System.Drawing.Size(103, 27);
            this.btnXoaDU.TabIndex = 5;
            this.btnXoaDU.Text = "    Xóa";
            this.btnXoaDU.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoaDU.UseVisualStyleBackColor = true;
            this.btnXoaDU.Click += new System.EventHandler(this.btnXoaDU_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.txtmadon);
            this.panel10.Location = new System.Drawing.Point(114, 10);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(662, 24);
            this.panel10.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã đơn nhập";
            // 
            // txtmadon
            // 
            this.txtmadon.Enabled = false;
            this.txtmadon.Location = new System.Drawing.Point(112, 2);
            this.txtmadon.Name = "txtmadon";
            this.txtmadon.Size = new System.Drawing.Size(547, 20);
            this.txtmadon.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbbloaihang);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(114, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(662, 24);
            this.panel4.TabIndex = 23;
            // 
            // cbbloaihang
            // 
            this.cbbloaihang.AutoCompleteCustomSource.AddRange(new string[] {
            "ly",
            "lon",
            "chai",
            "thùng",
            "ds"});
            this.cbbloaihang.BackColor = System.Drawing.Color.White;
            this.cbbloaihang.DisplayMember = "IDCV";
            this.cbbloaihang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbloaihang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbloaihang.FormattingEnabled = true;
            this.cbbloaihang.Items.AddRange(new object[] {
            "bia",
            "nước ngọt",
            "nước  pha chế"});
            this.cbbloaihang.Location = new System.Drawing.Point(111, 2);
            this.cbbloaihang.Name = "cbbloaihang";
            this.cbbloaihang.Size = new System.Drawing.Size(547, 21);
            this.cbbloaihang.TabIndex = 3;
            this.cbbloaihang.ValueMember = "IDLoai";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại hàng";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtsoluong);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(114, 196);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(662, 24);
            this.panel5.TabIndex = 24;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(112, 2);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(547, 20);
            this.txtsoluong.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtgianhap);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(114, 230);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(662, 24);
            this.panel6.TabIndex = 25;
            // 
            // txtgianhap
            // 
            this.txtgianhap.Location = new System.Drawing.Point(112, 2);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(547, 20);
            this.txtgianhap.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "giá nhập(vnđ)";
            // 
            // btnTimDoUong
            // 
            this.btnTimDoUong.Enabled = false;
            this.btnTimDoUong.Image = ((System.Drawing.Image)(resources.GetObject("btnTimDoUong.Image")));
            this.btnTimDoUong.Location = new System.Drawing.Point(713, 3);
            this.btnTimDoUong.Name = "btnTimDoUong";
            this.btnTimDoUong.Size = new System.Drawing.Size(68, 27);
            this.btnTimDoUong.TabIndex = 12;
            this.btnTimDoUong.Text = "Tìm";
            this.btnTimDoUong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimDoUong.UseVisualStyleBackColor = true;
            this.btnTimDoUong.Click += new System.EventHandler(this.btnTimDoUong_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(247, 6);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(460, 20);
            this.txttim.TabIndex = 11;
            this.txttim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttim_KeyDown);
            this.txttim.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttim_KeyUp);
            // 
            // nhập_hàng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 601);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grvDanhsach);
            this.Controls.Add(this.panel26);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel70);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nhập_hàng";
            this.Text = "nhập hàng";
            this.panel70.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhsach)).EndInit();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel70;
        private System.Windows.Forms.ComboBox cbbDVT;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DateTimePicker dtpkNgayNhap;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbdanhmuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grvDanhsach;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThemDU;
        private System.Windows.Forms.Button btnLamMoiDU;
        private System.Windows.Forms.Button btnSuaDU;
        protected internal System.Windows.Forms.Button btnXoaDU;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtmadon;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbbloaihang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox txtsoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.MaskedTextBox txtgianhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn madon;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhmuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaihang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.ComboBox cbbtenmathang;
        private System.Windows.Forms.Button btnTimDoUong;
        private System.Windows.Forms.MaskedTextBox txttim;
    }
}