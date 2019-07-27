namespace WindowsFormsApp1.Luu_tru
{
    partial class quản_lý_loại_đồ_uống
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quản_lý_loại_đồ_uống));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThemDU = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.MaskedTextBox();
            this.btnLamMoiDU = new System.Windows.Forms.Button();
            this.btnSuaDU = new System.Windows.Forms.Button();
            this.btnXoaDU = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grvDouong = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel45 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.MaskedTextBox();
            this.panel48 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.MaskedTextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.MaskedTextBox();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDouong)).BeginInit();
            this.panel45.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel48.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.btnThemDU);
            this.panel4.Controls.Add(this.btntim);
            this.panel4.Controls.Add(this.txttim);
            this.panel4.Controls.Add(this.btnLamMoiDU);
            this.panel4.Controls.Add(this.btnSuaDU);
            this.panel4.Controls.Add(this.btnXoaDU);
            this.panel4.Location = new System.Drawing.Point(90, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1098, 41);
            this.panel4.TabIndex = 8;
            // 
            // btnThemDU
            // 
            this.btnThemDU.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDU.Image")));
            this.btnThemDU.Location = new System.Drawing.Point(0, 6);
            this.btnThemDU.Name = "btnThemDU";
            this.btnThemDU.Size = new System.Drawing.Size(103, 27);
            this.btnThemDU.TabIndex = 4;
            this.btnThemDU.Text = "Thêm";
            this.btnThemDU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemDU.UseVisualStyleBackColor = true;
            this.btnThemDU.Click += new System.EventHandler(this.btnThemDU_Click);
            // 
            // btntim
            // 
            this.btntim.Enabled = false;
            this.btntim.Image = ((System.Drawing.Image)(resources.GetObject("btntim.Image")));
            this.btntim.Location = new System.Drawing.Point(824, 8);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(99, 23);
            this.btntim.TabIndex = 0;
            this.btntim.Text = "Tìm";
            this.btntim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(617, 9);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(189, 20);
            this.txttim.TabIndex = 1;
            this.txttim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttim_KeyDown);
            this.txttim.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttim_KeyUp);
            // 
            // btnLamMoiDU
            // 
            this.btnLamMoiDU.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLamMoiDU.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoiDU.Image")));
            this.btnLamMoiDU.Location = new System.Drawing.Point(333, 5);
            this.btnLamMoiDU.Name = "btnLamMoiDU";
            this.btnLamMoiDU.Size = new System.Drawing.Size(106, 29);
            this.btnLamMoiDU.TabIndex = 3;
            this.btnLamMoiDU.Text = "Refresh";
            this.btnLamMoiDU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoiDU.UseVisualStyleBackColor = false;
            this.btnLamMoiDU.Click += new System.EventHandler(this.btnLamMoiDU_Click);
            // 
            // btnSuaDU
            // 
            this.btnSuaDU.Enabled = false;
            this.btnSuaDU.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDU.Image")));
            this.btnSuaDU.Location = new System.Drawing.Point(220, 6);
            this.btnSuaDU.Name = "btnSuaDU";
            this.btnSuaDU.Size = new System.Drawing.Size(107, 27);
            this.btnSuaDU.TabIndex = 2;
            this.btnSuaDU.Text = "Cập nhật";
            this.btnSuaDU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaDU.UseVisualStyleBackColor = true;
            this.btnSuaDU.Click += new System.EventHandler(this.btnSuaDU_Click);
            // 
            // btnXoaDU
            // 
            this.btnXoaDU.Enabled = false;
            this.btnXoaDU.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDU.Image")));
            this.btnXoaDU.Location = new System.Drawing.Point(111, 6);
            this.btnXoaDU.Name = "btnXoaDU";
            this.btnXoaDU.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnXoaDU.Size = new System.Drawing.Size(103, 27);
            this.btnXoaDU.TabIndex = 1;
            this.btnXoaDU.Text = "    Xóa";
            this.btnXoaDU.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoaDU.UseVisualStyleBackColor = true;
            this.btnXoaDU.Click += new System.EventHandler(this.btnXoaDU_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.grvDouong);
            this.panel2.Controls.Add(this.panel45);
            this.panel2.Location = new System.Drawing.Point(90, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 421);
            this.panel2.TabIndex = 10;
            // 
            // grvDouong
            // 
            this.grvDouong.AllowUserToOrderColumns = true;
            this.grvDouong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvDouong.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvDouong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvDouong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDouong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ten,
            this.mota});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvDouong.DefaultCellStyle = dataGridViewCellStyle4;
            this.grvDouong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grvDouong.EnableHeadersVisualStyles = false;
            this.grvDouong.Location = new System.Drawing.Point(0, 44);
            this.grvDouong.MultiSelect = false;
            this.grvDouong.Name = "grvDouong";
            this.grvDouong.ReadOnly = true;
            this.grvDouong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDouong.Size = new System.Drawing.Size(505, 375);
            this.grvDouong.TabIndex = 12;
            this.grvDouong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDouong_CellClick);
            // 
            // ma
            // 
            this.ma.DataPropertyName = "maloai";
            this.ma.HeaderText = "Mã loại";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "tenloai";
            this.ten.HeaderText = "Tên loại";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // mota
            // 
            this.mota.DataPropertyName = "mota";
            this.mota.HeaderText = "Mô tả";
            this.mota.Name = "mota";
            this.mota.ReadOnly = true;
            // 
            // panel45
            // 
            this.panel45.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel45.Controls.Add(this.label30);
            this.panel45.Location = new System.Drawing.Point(3, 2);
            this.panel45.Name = "panel45";
            this.panel45.Size = new System.Drawing.Size(499, 36);
            this.panel45.TabIndex = 3;
            // 
            // label30
            // 
            this.label30.Image = ((System.Drawing.Image)(resources.GetObject("label30.Image")));
            this.label30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label30.Location = new System.Drawing.Point(3, 3);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(100, 23);
            this.label30.TabIndex = 0;
            this.label30.Text = "Danh sách loại";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel48);
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Controls.Add(this.panel16);
            this.panel1.Location = new System.Drawing.Point(612, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 421);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aqua;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtmota);
            this.panel3.Location = new System.Drawing.Point(4, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 43);
            this.panel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mô tả:";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(93, 13);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(464, 20);
            this.txtmota.TabIndex = 0;
            // 
            // panel48
            // 
            this.panel48.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel48.Controls.Add(this.label33);
            this.panel48.Location = new System.Drawing.Point(1, 1);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(565, 36);
            this.panel48.TabIndex = 12;
            // 
            // label33
            // 
            this.label33.Image = ((System.Drawing.Image)(resources.GetObject("label33.Image")));
            this.label33.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label33.Location = new System.Drawing.Point(3, 3);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(100, 23);
            this.label33.TabIndex = 0;
            this.label33.Text = "Thông tin loại";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Aqua;
            this.panel17.Controls.Add(this.label9);
            this.panel17.Controls.Add(this.txtTenLoai);
            this.panel17.Location = new System.Drawing.Point(4, 121);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(561, 43);
            this.panel17.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên loại:";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(93, 13);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(464, 20);
            this.txtTenLoai.TabIndex = 0;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Aqua;
            this.panel16.Controls.Add(this.label8);
            this.panel16.Controls.Add(this.txtMaLoai);
            this.panel16.Location = new System.Drawing.Point(3, 56);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(561, 43);
            this.panel16.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã Loại:";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Enabled = false;
            this.txtMaLoai.Location = new System.Drawing.Point(93, 14);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.ReadOnly = true;
            this.txtMaLoai.Size = new System.Drawing.Size(465, 20);
            this.txtMaLoai.TabIndex = 0;
            // 
            // quản_lý_loại_đồ_uống
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "quản_lý_loại_đồ_uống";
            this.Text = "Loại đồ uống";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDouong)).EndInit();
            this.panel45.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel48.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThemDU;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.MaskedTextBox txttim;
        private System.Windows.Forms.Button btnLamMoiDU;
        private System.Windows.Forms.Button btnSuaDU;
        protected internal System.Windows.Forms.Button btnXoaDU;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtmota;
        private System.Windows.Forms.Panel panel48;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtTenLoai;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtMaLoai;
        private System.Windows.Forms.Panel panel45;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView grvDouong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
    }
}