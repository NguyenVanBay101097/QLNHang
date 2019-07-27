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
    public partial class frmthanhtoan : Form
    {
        public frmthanhtoan()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            lblSoban.Text = Chitiethoadon.tenban;
            lblNhanVienLap.Text = "nguyen van bay";
            lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            grvCTHD.DataSource = new dulieu.dulieu().dsChitietHD();
            lblGiamGia.Text = "220.000  vnđ";
            lblTongTien.Text = "2.220.000  vnđ";

        }

        private void grvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Bitmap bmp;

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            btnInHoaDon.Visible = false;
            btnThoat.Visible = false;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();


            //PrintDialog printDialog1 = new PrintDialog();
            //printDialog1.Document = printDocument1;
            //DialogResult result = printDialog1.ShowDialog();
            //if (result == DialogResult.OK)
            //    printDocument1.Print();
            Chitiethoadon.cohieu = 1;
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }
    }
}
