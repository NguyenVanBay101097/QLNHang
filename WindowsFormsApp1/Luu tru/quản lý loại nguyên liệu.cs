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
    public partial class quản_lý_loại_đồ_uống : Form
    {
        public quản_lý_loại_đồ_uống()
        {
            InitializeComponent();
            Load();
        }
        List<dulieu.loaidouong> dl = dulieu.dulieu.dsloaidouong();

        private void Load()
        {
            grvDouong.DataSource = dl;
        }

        private void btnSuaDU_Click(object sender, EventArgs e)
        {
            var index = grvDouong.CurrentRow.Index;

            var du = new dulieu.loaidouong();
            du.maloai =txtMaLoai.Text;
            du.tenloai =txtTenLoai.Text;
            du.mota =txtmota.Text;
            

            {
                foreach (var item in dl)
                {
                    if (item.maloai == du.maloai)
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

        private void btnThemDU_Click(object sender, EventArgs e)
        {
            var du = new dulieu.loaidouong();
            du.maloai = "LOD 93243";
            du.tenloai = txtTenLoai.Text;
            du.mota = txtmota.Text;
            
            dl.Add(du);
            grvDouong.DataSource = null;

            grvDouong.DataSource = dl;
        }

        private void grvDouong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSuaDU.Enabled = true;
            btnXoaDU.Enabled = true;
            var index = grvDouong.CurrentRow.Index;
            txtMaLoai.Text = grvDouong.Rows[index].Cells[0].Value.ToString();
            txtTenLoai.Text = grvDouong.Rows[index].Cells[1].Value.ToString();
            txtmota.Text = grvDouong.Rows[index].Cells[2].Value.ToString();


        }

        private void btnXoaDU_Click(object sender, EventArgs e)
        {
            var index = grvDouong.CurrentRow.Index;


            {
                foreach (var item in dl)
                {
                    if (item.maloai == grvDouong.Rows[index].Cells[0].Value.ToString())
                    {
                        dl.Remove(item);
                        break;
                    }
                }
                grvDouong.DataSource = null;
                grvDouong.DataSource = dl;


            }
        }

        private void btnLamMoiDU_Click(object sender, EventArgs e)
        {
            btnXoaDU.Enabled = false;
            btnSuaDU.Enabled = false;
            txtMaLoai.Text = "";
            txtmota.Text = "";
             txtTenLoai.Text = "";
            grvDouong.DataSource = null;
            grvDouong.DataSource = dl;
        }

        private void txttim_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txttim_KeyUp(object sender, KeyEventArgs e)
        {
            if (txttim.Text.Trim() != "")
            {
                btntim.Enabled = true;
            }
            else
            {
                btntim.Enabled = false;
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            var d = new List<dulieu.loaidouong>();
            var ds = dulieu.dulieu.dsloaidouong();
            foreach (var item in ds)
            {
                if (item.tenloai.ToUpper().Trim().Contains(txttim.Text.ToUpper().Trim()))
                {
                    d.Add(item);
                }
            }
            grvDouong.DataSource = null;
            grvDouong.DataSource = d;
        }
    }
}
