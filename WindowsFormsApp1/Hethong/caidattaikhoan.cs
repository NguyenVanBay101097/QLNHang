using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Hethong
{
    public partial class caidattaikhoan : Form
    {
        public caidattaikhoan()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            txtTenNhanVien.Text = "Nguyễn Văn Bảy";
            txtTenDN.Text = "nguyenvanbay";
            txtMatKhau.Text = "nguyenvanbay";
            txtMatKhauMoi.Text = "nguyenvanbay";
            txtNhapLaiMatKhau.Text = "nguyenvanbay";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtMatKhau.Enabled = true;
            txtMatKhauMoi.Enabled = true;
            txtNhapLaiMatKhau.Enabled = true;
            txtTenDN.Enabled = true;
            txtTenNhanVien.Enabled = true;
            btnluu.Enabled = true;
            btnCapNhat.Enabled = false;
            btnhuy.Enabled = true;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {

            txtMatKhau.Enabled = false;
            txtMatKhauMoi.Enabled = false;
            txtNhapLaiMatKhau.Enabled = false;
            txtTenDN.Enabled = false;
            txtTenNhanVien.Enabled = false;
            btnluu.Enabled = false;
            btnCapNhat.Enabled = true;
            btnhuy.Enabled = false;
            Load();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            txtMatKhau.Enabled = false;
            txtMatKhauMoi.Enabled = false;
            txtNhapLaiMatKhau.Enabled = false;
            txtTenDN.Enabled = false;
            txtTenNhanVien.Enabled = false;
            btnluu.Enabled = false;
            btnCapNhat.Enabled = true;
            btnhuy.Enabled = false;
        }
    }
}
