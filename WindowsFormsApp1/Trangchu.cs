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
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
            Loadban_phong();
            nudSoLuong.Minimum = 1;
            
        }
        List<Chitiethoadon> dl = dulieu.dulieu.dsChitietHD2();


        private void Loadban_phong()
        {
            comboBox1.SelectedIndex = 0;
            for (int i = 1; i <= 101; i++)
            {
                Button button = new Button() { Width = 60, Height = 60 };
                button.Text = "Bàn " + i.ToString();
                if (i==101)
                {
                    button.Text ="NoneNumber";

                }
                this.flpDSBan.Controls.Add(button);
                if (i == 3 || i == 5 || i == 10 || i == 18)
                {
                    button.BackColor = Color.OrangeRed;
                }
                if (i == 12 || i == 15 || i == 16 || i == 8)
                {
                    button.BackColor = SystemColors.ActiveCaption;
                }
                button.Click += Button_Click;
                button.MouseHover += Button_MouseHover;
                if (i == 1)
                {
                    button.Select();
                    string idban = "bàn 1";
                    lblTenBan.Text = idban.ToString();
                    grvCTBanTest.DataSource = null;


                    btnXoaDU.Enabled = false;
                    btnThanhToan.Enabled = false;
                    btngopban.Enabled = false;
                    txtTamTinh.Text = "0";
                    txtGiamGia.Text = "0";
                    txtTongTien.Text = "0";
                }
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
                if (i == 12 || i == 15 )
                {
                    button.BackColor = SystemColors.ActiveCaption;
                }
                button.Click += Button_Click;
                button.MouseHover += Button_MouseHover;
                
            }

        }
        
        

        private void Button_MouseHover(object sender, EventArgs e)
        {
            if ((sender as Button).BackColor == SystemColors.ActiveCaption)
            {
                toolTip1.Show("19:25 tối", sender as Button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string idban = (sender as Button).Text;
            lblTenBan.Text = idban.ToString();
            List<Chitiethoadon> dl = new dulieu.dulieu().dsChitietHD();


            if ((sender as Button).BackColor.Name == "OrangeRed")
            {

                grvCTBanTest.DataSource = dl;


                btnXoaDU.Enabled = true;
                btnThanhToan.Enabled = true;
                btngopban.Enabled = true;
                txtTamTinh.Text = "36000000";
                txtGiamGia.Text = "10";
                txtTongTien.Text = "34000000";
            }
            else
            {
                var a = new List<Chitiethoadon>();
                grvCTBanTest.DataSource = a;


                btnXoaDU.Enabled = false;
                btngopban.Enabled = false;
                btnThanhToan.Enabled = false;
                txtTamTinh.Text = "0";
                txtGiamGia.Text = "0";
                txtTongTien.Text = "0";
            }

        }



        private void trviewDoAn_Click(object sender, EventArgs e)
        {

            var ds = new List<Chitiethoadon>()
            {
            new Chitiethoadon(){mathang="tôm hùm nướng phô mai",gia=23000,donvi="kg"},
            new Chitiethoadon(){mathang="tôm hùm lẩu",gia=23000,donvi="kg"},
            new Chitiethoadon(){mathang="tôm hùm nướng mọi",gia=23000,donvi="kg"},
            new Chitiethoadon(){mathang="tôm hùm ăn sống",gia=23000,donvi="kg"}
            };
            TreeViewHitTestInfo info = trviewDoAn.HitTest(trviewDoAn.PointToClient(Cursor.Position));
            if (info.Node.Index == 0)
            {
                grvDSDoUongF.DataSource = ds;

            }
            btnThemMon.Enabled = true;

        }
        List<Chitiethoadon> dlthem = dulieu.dulieu.dsChitietHD2();
        private void btnThemMon_Click(object sender, EventArgs e)
        {
           
            int rowSelected = grvDSDoUongF.CurrentRow.Index;

            var hd = new Chitiethoadon()
            {
                mathang = grvDSDoUongF.Rows[rowSelected].Cells[0].Value.ToString(),

                donvi = grvDSDoUongF.Rows[rowSelected].Cells[2].Value.ToString(),
                gia = int.Parse(grvDSDoUongF.Rows[rowSelected].Cells[3].Value.ToString()),
                soluong = int.Parse(nudSoLuong.Value.ToString())

            };
            foreach (Button item in flpDSBan.Controls)
            {
                if (item.Text == lblTenBan.Text)
                {
                    if (item.BackColor.Name == "Control" || item.BackColor == SystemColors.ActiveCaption)
                    {
                        item.BackColor = Color.OrangeRed;
                    }
                   
                }
            }



            int c = 0;
            for (int i = 0; i < grvCTBanTest.Rows.Count; i++)
            {
                if (grvCTBanTest.Rows[i].Cells[0].Value.ToString() == grvDSDoUongF.CurrentRow.Cells[0].Value.ToString())
                {
                    grvCTBanTest.Rows[i].Cells[1].Value = int.Parse(grvCTBanTest.Rows[i].Cells[1].Value.ToString()) + nudSoLuong.Value;
                    c = 1; break;
                }
            }
            if (c == 0)
            {
                dlthem.Add(hd);
                grvCTBanTest.DataSource = null;
                grvCTBanTest.DataSource = dlthem;
            }

            btnXoaDU.Enabled = true;
            btnThanhToan.Enabled = true;
            btngopban.Enabled = true;
        }

        private void btngopban_Click(object sender, EventArgs e)
        {
            new frmBAN().ShowDialog();

            foreach (Button item in flpDSBan.Controls)
            {
                if (item.Text == lblTenBan.Text)
                {
                    if (item.BackColor.Name == "OrangeRed")
                    {
                        item.BackColor = Control.DefaultBackColor;
                    }

                }
                if (item.Text == Chitiethoadon.tenban)
                {
                    if (item.BackColor.Name == "Control")
                    {
                        item.BackColor = Color.OrangeRed;
                    }

                }
            }
            lblTenBan.Text = Chitiethoadon.tenban;
        }

        private void btnXoaDU_Click(object sender, EventArgs e)
        {
            var index = grvCTBanTest.CurrentRow.Index;
            if (int.Parse(grvCTBanTest.Rows[index].Cells[1].Value.ToString()) > nudSoLuong.Value)
            {
                grvCTBanTest.Rows[index].Cells[1].Value = int.Parse(grvCTBanTest.Rows[index].Cells[1].Value.ToString()) - nudSoLuong.Value;

            }
            else
            {
                foreach (var item in dl)
                {
                    if (item.mathang == grvCTBanTest.Rows[index].Cells[0].Value.ToString())
                    {
                        dl.Remove(item);
                        break;
                    }
                }
                grvCTBanTest.DataSource =null;
                grvCTBanTest.DataSource = dl;
                if (dl.Count==0)
                {

                    foreach (Button item in flpDSBan.Controls)
                    {
                        if (item.Text == lblTenBan.Text)
                        {

                            item.BackColor = Control.DefaultBackColor;
                            grvCTBanTest.DataSource = new List<Chitiethoadon>();


                            btnXoaDU.Enabled = false;
                            btnThanhToan.Enabled = false;
                            btngopban.Enabled = false;
                            txtTamTinh.Text = "0";
                            txtGiamGia.Text = "0";
                            txtTongTien.Text = "0";

                        }
                    }
                   
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Chitiethoadon.tenban = lblTenBan.Text;
            Chitiethoadon.cohieu = 0;
            
            new frmthanhtoan().ShowDialog();
            if (Chitiethoadon.cohieu == 1)
            {
                foreach (Button item in flpDSBan.Controls)
                {
                    if (item.Text == Chitiethoadon.tenban)
                    {
                        item.BackColor = Control.DefaultBackColor;

                        if (item.Text == "Bàn 8"|| item.Text == "Bàn 15" || item.Text == "Bàn 16" || item.Text == "Phòng 12" || item.Text == "Phòng 15" )
                        {
                            item.BackColor = SystemColors.ActiveCaption;
                        }
                        grvCTBanTest.DataSource = new List<Chitiethoadon>() ;


                        btnXoaDU.Enabled = false;
                        btnThanhToan.Enabled = false;
                        btngopban.Enabled = false;
                        txtTamTinh.Text = "0";
                        txtGiamGia.Text = "0";
                        txtTongTien.Text = "0";

                    }
                }
            }

        }

        private void btnTimDoUong_Click(object sender, EventArgs e)
        {
            var d = new List<Chitiethoadon>();
            foreach (var item in new dulieu.dulieu().dsChitietHD())
            {
                if (item.mathang.ToUpper().Trim().Contains(txtTimDoUong.Text.ToUpper().Trim()))
                {
                    d.Add(item);
                }
            }
            grvDSDoUongF.DataSource = d;

        }

        private void txtTimDoUong_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtTimDoUong.Text.Trim() != "")
            {
                btnTimDoUong.Enabled = true;
            }
        }

        private void txtTimDoUong_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTimDoUong.Text.Trim() != "")
            {
                btnTimDoUong.Enabled = true;
            }
            else
            {
                btnTimDoUong.Enabled = false;

            }
        }

        private void đặtTrựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);

        } 
        //thêm page
        private int KTFormTonTai(Form frm)
        {
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                if (tabControl1.TabPages[i].Text == frm.Text.Trim())
                {
                    
                    return i;
                }
            }
            return -1;
        }
        public void addpage(Form f)
        {
            int t = KTFormTonTai(f);
            if (t >= 0)
            {
                if (tabControl1.SelectedTab == tabControl1.TabPages[t])
                {
                    MessageBox.Show("chức năng  đã được chọn!");
                    
                }
                else
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[t];
                    

                };

            }
            else //them tab moi
            {
                TabPage newTab = new TabPage(f.Text.Trim());
                
                tabControl1.TabPages.Add(newTab);
                f.TopLevel = false;
                TabPage a = tabControl1.SelectedTab;
                f.Parent = newTab;
                tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabCount - 1];
                f.Show();
                f.Dock = DockStyle.Fill;
            }
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString("x", e.Font, Brushes.Red, e.Bounds.Right - 12, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }
        private void tabControl1_MouseDown_1(object sender, MouseEventArgs e)
        {

            for (int i = 1; i < this.tabControl1.TabPages.Count; i++)
            {
                Rectangle r = tabControl1.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    this.tabControl1.TabPages.RemoveAt(i);
                }
            }
        }

        private void lưuTrữĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addpage(new Luu_tru.quản_lý_đồ_uống());
        }

        private void uôiuoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addpage(new nhập_hàng());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addpage(new Hethong.caidattaikhoan());
        }

        private void loạiĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addpage(new Luu_tru.quản_lý_loại_đồ_uống());
        }

        private void Trangchu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.T)
            {
                đặtTrựcToolStripMenuItem_Click(sender,e);
            }
            if (e.Control && e.KeyCode == Keys.Y)
            {
                //trước
                
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                uôiuoToolStripMenuItem_Click(sender, e);
            }
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addpage(new thongke.doanhthu());
        }

      

       
    }
}
