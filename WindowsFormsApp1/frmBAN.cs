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
    public partial class frmBAN : Form
    {
        public frmBAN()
        {
            InitializeComponent();
            Loadban_phong();
        }
        private void Loadban_phong()
        {
            for (int i = 1; i <= 100; i++)
            {
                Button button = new Button() { Width = 60, Height = 60 };
                button.Text = "Bàn " + i.ToString();
                this.flpDSBan.Controls.Add(button);
                if (i == 3 || i == 5 || i == 10 || i == 18)
                {
                    button.BackColor = Color.OrangeRed;
                }
                button.Click += Button_Click;
               
            }
            for (int i = 1; i <= 30; i++)
            {
                Button button = new Button() { Width = 60, Height = 60 };
                button.Text = "Phòng " + i.ToString();
                this.flpPhong.Controls.Add(button);
                if (i == 3 || i == 5 || i == 10 || i == 18)
                {
                    button.BackColor = Color.OrangeRed;
                }
                button.Click += Button_Click;

            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Chitiethoadon.tenban = (sender as Button).Text;
            this.Close();

        }
    }
}
