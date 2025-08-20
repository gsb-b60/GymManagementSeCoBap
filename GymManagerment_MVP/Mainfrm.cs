using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP
{
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
           

        }
        public void loadUserControl(UserControl userControl)
        {
            pnlContent.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            loadUserControl(new DanhSachHocVienUC());
        }

        private void btnDanhSachThietBi_Click(object sender, EventArgs e)
        {
            loadUserControl(new DanhSachThietBiUC());
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            loadUserControl(new ThongKeDoanhThuUC());
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            loadUserControl(new QuanLyNhanVienUC());
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            loadUserControl(new XuatHoaDonUC());
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            loadUserControl(new CheckinKhachVaoUC());
        }
    }
}
