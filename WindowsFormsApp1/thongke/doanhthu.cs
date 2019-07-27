using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.thongke
{
    public partial class doanhthu : Form
    {
        public doanhthu()
        {
            InitializeComponent();
            Load();
        }
        List<dulieu.hoadon> dl = dulieu.dulieu.dshoadon();
        private void Load()
        {
            grvTKHoaDon.DataSource = null;
            grvTKHoaDon.DataSource = dl;
          
        }

        private void grvTKHoaDon_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.grvTKHoaDon.Rows[e.RowIndex].Cells["stt"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnLamMoiDU_Click(object sender, EventArgs e)
        {
            Load();
            dtpkTuNgay.Text = "30/4/2018";
            dtpkDenNgay.Value = DateTime.Now;
            lblTong.Text = "2.000.000 vnđ";
            txtMaDU.Text = "";
            btntim.Enabled = false;
        }

        private void txtMaDU_KeyUp(object sender, KeyEventArgs e)
        {
            if (btntim.Text.Trim()!="")
            {
                btntim.Enabled = true;
            }
            else
            {
                btntim.Enabled = false;
            }
        }

        private void txtTimDU_Click(object sender, EventArgs e)
        {
            var d = new List<dulieu.hoadon>();
            var ds = dulieu.dulieu.dshoadon();
            foreach (var item in ds)
            {
                if (item.mahoadon.ToUpper().Trim().Contains(txtMaDU.Text.ToUpper().Trim()))
                {
                    d.Add(item);
                }
            }
            grvTKHoaDon.DataSource = null;
            grvTKHoaDon.DataSource = d;
            lblTong.Text = "10.000.000 vnđ";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Load();
            lblTong.Text = "52.000.000 vnđ";
            txtMaDU.Text = "";
            btntim.Enabled = false;
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            grvTKHoaDon.DataSource = null;
            grvTKHoaDon.DataSource = dulieu.dulieu.dshoadon2();
            lblTong.Text = "52.000.000 vnđ";
            
            dtpkTuNgay.Text = "30/4/2018";
            dtpkDenNgay.Value = DateTime.Now;
            txtMaDU.Text = "";
            btntim.Enabled = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook wb = Excel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)Excel.ActiveSheet;

                Excel.Visible = true;

                // MessageBox.Show(grvTD.Columns[0].HeaderText.ToString());
                for (int i = 1; i < grvTKHoaDon.ColumnCount + 1; i++)
                {
                    ws.Cells[1, i] = grvTKHoaDon.Columns[i - 1].HeaderText;

                }

                int sohang = grvTKHoaDon.RowCount;

                //  MessageBox.Show(sohang.ToString());

                for (int i = 0; i < sohang; i++)
                {
                    ws.Cells[i + 2, 1] = grvTKHoaDon.Rows[i].Cells[0].Value;
                    ws.Cells[i + 2, 2] = grvTKHoaDon.Rows[i].Cells[1].Value;
                    ws.Cells[i + 2, 3] = grvTKHoaDon.Rows[i].Cells[2].Value;
                    ws.Cells[i + 2, 4] = grvTKHoaDon.Rows[i].Cells[3].Value;
                    ws.Cells[i + 2, 5] = grvTKHoaDon.Rows[i].Cells[4].Value;
                    ws.Cells[i + 2, 6] = grvTKHoaDon.Rows[i].Cells[5].Value;
                    ws.Cells[i + 2, 7] = grvTKHoaDon.Rows[i].Cells[6].Value.ToString();
                    ws.Cells[i + 2, 8] = grvTKHoaDon.Rows[i].Cells[7].Value;
                }
            }
            catch (Exception)
            {
                return;
                throw;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTong_Click(object sender, EventArgs e)
        {

        }

        private void grvTKHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new chitiethoadon().ShowDialog();
        }
    }
}
