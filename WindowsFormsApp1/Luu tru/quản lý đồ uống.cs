using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Luu_tru
{
    public partial class quản_lý_đồ_uống : Form
    {
        public quản_lý_đồ_uống()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            loaddouong();
        }
        List<dulieu.nguyenlieu> dl = dulieu.dulieu.dsnguyenlieu();
        Bitmap bmp;
        OpenFileDialog open;

        private void loaddouong()
        {
            var a = dulieu.dulieu.dsnguyenlieu();
            grvDouong.DataSource = a;
           

            //foreach (DataGridViewRow item in grvDouong.Rows)
            //{
            //    item.Cells[0].Value = "0";
            //}


        }

        private void grvDouong_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grvDouong.Rows[0].Selected = false;
        }

        private void btnThemDU_Click(object sender, EventArgs e)
        {
            var du = new dulieu.nguyenlieu();
            du.giaban = int.Parse(txtGiaBan.Text);
            du.soluong = int.Parse(txtsoluong.Text);
            du.donvi = donvi.Selected.ToString();
            du.manguyenlieu = txt2MaDU.Text;
            du.tennguyenlieu = txtTenDU.Text;
            du.loainguyenlieu = cbbLoaiDU.Text;
            var index = grvDouong.CurrentRow.Index;
            if ( open!=null)
            {
                if (open.FileName != grvDouong.Rows[index].Cells[6].Value.ToString())
                {
                    du.hinhanh = System.IO.Path.GetFileName(open.FileName);

                }
                else
                {
                    du.hinhanh = grvDouong.Rows[index].Cells[6].Value.ToString();

                }
            }
            else
            {
                du.hinhanh = grvDouong.Rows[index].Cells[6].Value.ToString();
            }
           
            dl.Add(du);

            grvDouong.DataSource = null;
            grvDouong.DataSource = dl;
        }

        private void btnXoaDU_Click(object sender, EventArgs e)
        {
            var index = grvDouong.CurrentRow.Index;


            {
                foreach (var item in dl)
                {
                    if (item.manguyenlieu == grvDouong.Rows[index].Cells[0].Value.ToString())
                    {
                        dl.Remove(item);
                        break;
                    }
                }
                grvDouong.DataSource = null;
                grvDouong.DataSource = dl;


            }
        }

        private void grvDouong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaDU.Enabled = true;
            btnSuaDU.Enabled = true;
            var index = grvDouong.CurrentRow.Index;
            txtTenDU.Text = grvDouong.Rows[index].Cells[1].Value.ToString();
            cbbDVT.Text = grvDouong.Rows[index].Cells[4].Value.ToString();
            txtGiaBan.Text = grvDouong.Rows[index].Cells[3].Value.ToString();
            txtsoluong.Text = grvDouong.Rows[index].Cells[2].Value.ToString();
            cbbLoaiDU.Text = grvDouong.Rows[index].Cells[5].Value.ToString();
            txt2MaDU.Text = grvDouong.Rows[index].Cells[0].Value.ToString();

            pictureBox1.Image = Image.FromFile(@"D:\HOC KY 1 2018-2019\Mon PTTK he thong\QLnhahang\WindowsFormsApp1\hinhanh\" + grvDouong.Rows[index].Cells[6].Value.ToString());
        }

        private void btnDoiHinh_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = "D:";
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromStream(open.OpenFile());

            }
        }

        private void btnSuaDU_Click(object sender, EventArgs e)
        {
            var index = grvDouong.CurrentRow.Index;

            var du = new dulieu.nguyenlieu();
            du.giaban = int.Parse(txtGiaBan.Text);
            du.soluong = int.Parse(txtsoluong.Text);
            du.donvi = donvi.Selected.ToString();
            du.manguyenlieu = txt2MaDU.Text;
            du.tennguyenlieu = txtTenDU.Text;
            du.loainguyenlieu = cbbLoaiDU.Text;
            du.hinhanh = grvDouong.Rows[index].Cells[6].Value.ToString();

            {
                foreach (var item in dl)
                {
                    if (item.manguyenlieu == grvDouong.Rows[index].Cells[0].Value.ToString())
                    {
                        dl.Remove(item);
                        break;
                    }
                }
            }
           
            dl.Add(du);
            grvDouong.DataSource = null;

            grvDouong.DataSource = dl;
        }

        private void btnLamMoiDU_Click(object sender, EventArgs e)
        {
            btnXoaDU.Enabled = false;
            btnSuaDU.Enabled = false;
            grvDouong.Rows[0].Selected = false;
            txt2MaDU.Text = "";
            txtGiaBan.Text = "";
            txtsoluong.Text = "";
            txtTenDU.Text = "";
            cbbDVT.SelectedIndex = -1;
            cbbLoaiDU.SelectedIndex = -1;
            pictureBox1.Image = Image.FromFile(@"D:\HOC KY 1 2018-2019\Mon PTTK he thong\QLnhahang\WindowsFormsApp1\hinhanh\noneimage.jpg");
            grvDouong.DataSource = null;
            grvDouong.DataSource = dl;
        }

        private void txtMaDU_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtMaDU.Text.Trim() != "")
            {
                txtMaDU.Enabled = true;
            }
        }
     

        

        private void txtMaDU_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMaDU.Text.Trim() != "")
            {
                txtTimDU.Enabled = true;
            }
            else
            {
                txtTimDU.Enabled = false;

            }
        }

        private void txtTimDU_Click(object sender, EventArgs e)
        {
            var d = new List<dulieu.nguyenlieu>();
            var ds = dulieu.dulieu.dsnguyenlieu();
            foreach (var item in ds)
            {
                if (item.tennguyenlieu.ToUpper().Trim().Contains(txtMaDU.Text.ToUpper().Trim()))
                {
                    d.Add(item);
                }
            }
            grvDouong.DataSource = null;
            grvDouong.DataSource = d;
        }

        
    }
}
