namespace GymManagerment_MVP
{
    partial class Mainfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnDanhSachKhachHang = new System.Windows.Forms.Button();
            this.btnDanhSachThietBi = new System.Windows.Forms.Button();
            this.btnThongKeDoanhThu = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.btnThemHocVien = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinGóiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinHãngSảnXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinChuyểnKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAccName = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.pnlHome.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.lblChucVu);
            this.pnlHome.Controls.Add(this.lblAccName);
            this.pnlHome.Controls.Add(this.pbAvatar);
            this.pnlHome.Controls.Add(this.btnDangXuat);
            this.pnlHome.Controls.Add(this.btnThemHocVien);
            this.pnlHome.Controls.Add(this.menuStrip1);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1264, 94);
            this.pnlHome.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnCheckin);
            this.pnlMenu.Controls.Add(this.btnXuatHoaDon);
            this.pnlMenu.Controls.Add(this.btnQuanLyNhanVien);
            this.pnlMenu.Controls.Add(this.btnThongKeDoanhThu);
            this.pnlMenu.Controls.Add(this.btnDanhSachThietBi);
            this.pnlMenu.Controls.Add(this.btnDanhSachKhachHang);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 94);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 667);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 94);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1064, 667);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // btnDanhSachKhachHang
            // 
            this.btnDanhSachKhachHang.Location = new System.Drawing.Point(0, 0);
            this.btnDanhSachKhachHang.Name = "btnDanhSachKhachHang";
            this.btnDanhSachKhachHang.Size = new System.Drawing.Size(200, 55);
            this.btnDanhSachKhachHang.TabIndex = 0;
            this.btnDanhSachKhachHang.Text = "Danh Sach Khac Hang";
            this.btnDanhSachKhachHang.UseVisualStyleBackColor = true;
            this.btnDanhSachKhachHang.Click += new System.EventHandler(this.btnDanhSachKhachHang_Click);
            // 
            // btnDanhSachThietBi
            // 
            this.btnDanhSachThietBi.Location = new System.Drawing.Point(0, 50);
            this.btnDanhSachThietBi.Name = "btnDanhSachThietBi";
            this.btnDanhSachThietBi.Size = new System.Drawing.Size(200, 55);
            this.btnDanhSachThietBi.TabIndex = 1;
            this.btnDanhSachThietBi.Text = "Danh Sach Thiet Bi";
            this.btnDanhSachThietBi.UseVisualStyleBackColor = true;
            this.btnDanhSachThietBi.Click += new System.EventHandler(this.btnDanhSachThietBi_Click);
            // 
            // btnThongKeDoanhThu
            // 
            this.btnThongKeDoanhThu.Location = new System.Drawing.Point(0, 102);
            this.btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            this.btnThongKeDoanhThu.Size = new System.Drawing.Size(200, 55);
            this.btnThongKeDoanhThu.TabIndex = 2;
            this.btnThongKeDoanhThu.Text = "Thong Ke Doanh Thu";
            this.btnThongKeDoanhThu.UseVisualStyleBackColor = true;
            this.btnThongKeDoanhThu.Click += new System.EventHandler(this.btnThongKeDoanhThu_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(0, 152);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(200, 55);
            this.btnQuanLyNhanVien.TabIndex = 3;
            this.btnQuanLyNhanVien.Text = "Quan Ly Nhan Vien";
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = true;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.Location = new System.Drawing.Point(0, 204);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(200, 55);
            this.btnXuatHoaDon.TabIndex = 4;
            this.btnXuatHoaDon.Text = "Xuat Hoa Don";
            this.btnXuatHoaDon.UseVisualStyleBackColor = true;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // btnThemHocVien
            // 
            this.btnThemHocVien.Location = new System.Drawing.Point(31, 65);
            this.btnThemHocVien.Name = "btnThemHocVien";
            this.btnThemHocVien.Size = new System.Drawing.Size(95, 23);
            this.btnThemHocVien.TabIndex = 1;
            this.btnThemHocVien.Text = "Thêm Học Vien";
            this.btnThemHocVien.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(147, 65);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(75, 23);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(923, 3);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(109, 79);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 3;
            this.pbAvatar.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinGóiTậpToolStripMenuItem,
            this.thôngTinHãngSảnXuấtToolStripMenuItem,
            this.thôngTinChuyểnKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinGóiTậpToolStripMenuItem
            // 
            this.thôngTinGóiTậpToolStripMenuItem.Name = "thôngTinGóiTậpToolStripMenuItem";
            this.thôngTinGóiTậpToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.thôngTinGóiTậpToolStripMenuItem.Text = "Thông Tin Gói Tập";
            // 
            // thôngTinHãngSảnXuấtToolStripMenuItem
            // 
            this.thôngTinHãngSảnXuấtToolStripMenuItem.Name = "thôngTinHãngSảnXuấtToolStripMenuItem";
            this.thôngTinHãngSảnXuấtToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.thôngTinHãngSảnXuấtToolStripMenuItem.Text = "Thông Tin Hãng Sản Xuất";
            // 
            // thôngTinChuyểnKhoảnToolStripMenuItem
            // 
            this.thôngTinChuyểnKhoảnToolStripMenuItem.Name = "thôngTinChuyểnKhoảnToolStripMenuItem";
            this.thôngTinChuyểnKhoảnToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.thôngTinChuyểnKhoảnToolStripMenuItem.Text = "Thông Tin Chuyển Khoản";
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Location = new System.Drawing.Point(1076, 24);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(94, 13);
            this.lblAccName.TabIndex = 6;
            this.lblAccName.Text = "Nguyen Dinh Hieu";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(1091, 52);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(60, 13);
            this.lblChucVu.TabIndex = 7;
            this.lblChucVu.Text = "Chu Phong";
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(0, 256);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(200, 55);
            this.btnCheckin.TabIndex = 5;
            this.btnCheckin.Text = "Check In";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHome);
            this.Name = "Mainfrm";
            this.Text = "Mainfrm";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnDanhSachKhachHang;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Button btnThongKeDoanhThu;
        private System.Windows.Forms.Button btnDanhSachThietBi;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThemHocVien;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinGóiTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinHãngSảnXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinChuyểnKhoảnToolStripMenuItem;
        private System.Windows.Forms.Button btnCheckin;
    }
}