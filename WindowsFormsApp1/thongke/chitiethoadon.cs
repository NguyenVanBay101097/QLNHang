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
    public partial class chitiethoadon : Form
    {
        public chitiethoadon()
        {
            InitializeComponent();
            Load();
        }
        List<Chitiethoadon> dl = dulieu.dulieu.dsChitietHD2();
        private void Load()
        {
            grvCTBanTest.DataSource = null;
            grvCTBanTest.DataSource = dl;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            new frmthanhtoan().ShowDialog();
        }

        private void lblTong_Click(object sender, EventArgs e)
        {

        }

      
    }
}
