using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class nhập_hàng : Form
    {
        public nhập_hàng()
        {
            InitializeComponent();
            Load();
        }
        List<dulieu.hangnhap> dl = dulieu.dulieu.dshangnhap();

        private void Load()
        {
            grvDanhsach.DataSource = dl;
        }

        private void btnLamMoiDU_Click(object sender, EventArgs e)
        {
            txtmadon.Text = "";
            txtsoluong.Text = "";
            cbbdanhmuc.SelectedIndex = -1;
            cbbDVT.SelectedIndex = -1;
            cbbtenmathang.SelectedIndex = -1;
            cbbloaihang.SelectedIndex = -1;
            txtgianhap.Text = "";
            dtpkNgayNhap.Text = DateTime.Now.ToShortDateString();
            btnThemDU.Enabled = true;
            btnluu.Enabled = false;
            btnSuaDU.Enabled = false;
            btnXoaDU.Enabled = false;
            btnhuy.Enabled = false;
            btnLamMoiDU.Enabled = true;
            textTrue();
            txtmadon.Enabled = false;
            grvDanhsach.DataSource = null;
            grvDanhsach.DataSource = dl;
        }

        private void grvDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = grvDanhsach.CurrentRow.Index;
            txtmadon.Text = grvDanhsach.Rows[index].Cells[0].Value.ToString();
            txtsoluong.Text = grvDanhsach.Rows[index].Cells[5].Value.ToString();
            cbbdanhmuc.Text = grvDanhsach.Rows[index].Cells[1].Value.ToString();
            cbbDVT.Text = grvDanhsach.Rows[index].Cells[4].Value.ToString(); 
            cbbtenmathang.Text= grvDanhsach.Rows[index].Cells[3].Value.ToString();
            cbbloaihang.Text = grvDanhsach.Rows[index].Cells[2].Value.ToString();
            txtgianhap.Text = grvDanhsach.Rows[index].Cells[6].Value.ToString();
            dtpkNgayNhap.Text = grvDanhsach.Rows[index].Cells[7].Value.ToString();
            btnThemDU.Enabled = true;
            btnSuaDU.Enabled = true;
            btnXoaDU.Enabled = true;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }

        private void btnThemDU_Click(object sender, EventArgs e)
        {
            var h = new dulieu.hangnhap() {
                danhmuc = cbbdanhmuc.Text,
                donvi=cbbDVT.Text,
                gianhap=int.Parse(txtgianhap.Text),
                loaihang=cbbloaihang.Text,
                madon=txtmadon.Text,
                ngaynhap=dtpkNgayNhap.Value,
                soluong=int.Parse(txtsoluong.Text),
                tenmathang=cbbtenmathang.Text
            };
            dl.Add(h);
            grvDanhsach.DataSource = null;
            grvDanhsach.DataSource = dl;
        }

        private void btnXoaDU_Click(object sender, EventArgs e)
        {
            var index = grvDanhsach.CurrentRow.Index;


            {
                foreach (var item in dl)
                {
                    if (item.madon == grvDanhsach.Rows[index].Cells[0].Value.ToString())
                    {
                        dl.Remove(item);
                        break;
                    }
                }
                grvDanhsach.DataSource = null;
                grvDanhsach.DataSource = dl;


            }
            if (grvDanhsach.RowCount==0)
            {
                btnXoaDU.Enabled = false;
            }
        }

        private void grvDanhsach_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        }

        private void btnSuaDU_Click(object sender, EventArgs e)
        {
            btnThemDU.Enabled = false;
            btnluu.Enabled = true;
            btnSuaDU.Enabled = false;
            btnXoaDU.Enabled = false;
            btnhuy.Enabled = true;
            btnLamMoiDU.Enabled = false;
            textTrue();
            txtmadon.Enabled = false;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnThemDU.Enabled = true;
            btnluu.Enabled = false;
            btnSuaDU.Enabled = true;
            btnXoaDU.Enabled = true;
            btnhuy.Enabled = false;
            btnLamMoiDU.Enabled = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnThemDU.Enabled = true;
            btnluu.Enabled = false;
            btnSuaDU.Enabled = false;
            btnXoaDU.Enabled = false;
            btnhuy.Enabled = false;
            btnLamMoiDU.Enabled = true;
        }

        private void textFalse()
        {
            txtmadon.Enabled = false;
            txtsoluong.Enabled = false;
            cbbdanhmuc.Enabled = false;
            cbbDVT.Enabled = false;
            cbbtenmathang.Enabled = false;
            cbbloaihang.Enabled = false;
            txtgianhap.Enabled = false;
            dtpkNgayNhap.Enabled = false;
        }
        private void textTrue()
        {
            txtmadon.Enabled = true;
            txtsoluong.Enabled = true;
            cbbdanhmuc.Enabled = true;
            cbbDVT.Enabled = true;
            cbbtenmathang.Enabled = true;
            cbbloaihang.Enabled = true;
            txtgianhap.Enabled = true;
            dtpkNgayNhap.Enabled = true;
        }

        private void btnTimDoUong_Click(object sender, EventArgs e)
        {
            var dl1 = new List<dulieu.hangnhap>();
            foreach (var item in dl)
            {
                if (item.tenmathang.ToUpper().Trim().Contains(txttim.Text.ToUpper()))
                {
                    dl1.Add(item);
                }
            }
            grvDanhsach.DataSource = null;
            grvDanhsach.DataSource = dl1;
        }

        private void txttim_KeyDown(object sender, KeyEventArgs e)
        {
            if (txttim.Text.Trim()!="")
            {
                btnTimDoUong.Enabled = true;
            }
            else
            {
                btnTimDoUong.Enabled = false;
            }
        }

        private void txttim_KeyUp(object sender, KeyEventArgs e)
        {

            if (txttim.Text.Trim() != "")
            {
                btnTimDoUong.Enabled = true;
            }
            else
            {
                btnTimDoUong.Enabled = false;
            }
        }
    }
}
