namespace GymManagerment_MVP
{
    partial class DanhSachHocVienUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpNhapThongTinHV = new System.Windows.Forms.GroupBox();
            this.gbDanhSachHocVien = new System.Windows.Forms.GroupBox();
            this.lvDanhSachHV = new System.Windows.Forms.ListView();
            this.chMaHocVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTen = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblNgayDangKy = new System.Windows.Forms.Label();
            this.lblGoiTap = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.cbGioiTap = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pbHinhHV = new System.Windows.Forms.PictureBox();
            this.lblHinhHocVien = new System.Windows.Forms.Label();
            this.tbDuongDan = new System.Windows.Forms.TextBox();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.gbLichSuTap = new System.Windows.Forms.GroupBox();
            this.lvLichSuTap = new System.Windows.Forms.ListView();
            this.chNgay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTongLan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpNhapThongTinHV.SuspendLayout();
            this.gbDanhSachHocVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhHV)).BeginInit();
            this.gbLichSuTap.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpNhapThongTinHV
            // 
            this.gpNhapThongTinHV.Controls.Add(this.gbLichSuTap);
            this.gpNhapThongTinHV.Controls.Add(this.btnChonHinh);
            this.gpNhapThongTinHV.Controls.Add(this.tbDuongDan);
            this.gpNhapThongTinHV.Controls.Add(this.lblHinhHocVien);
            this.gpNhapThongTinHV.Controls.Add(this.pbHinhHV);
            this.gpNhapThongTinHV.Controls.Add(this.maskedTextBox1);
            this.gpNhapThongTinHV.Controls.Add(this.cbGioiTap);
            this.gpNhapThongTinHV.Controls.Add(this.dtpNgayDangKy);
            this.gpNhapThongTinHV.Controls.Add(this.tbTen);
            this.gpNhapThongTinHV.Controls.Add(this.lblGoiTap);
            this.gpNhapThongTinHV.Controls.Add(this.lblNgayDangKy);
            this.gpNhapThongTinHV.Controls.Add(this.lblSDT);
            this.gpNhapThongTinHV.Controls.Add(this.lblTen);
            this.gpNhapThongTinHV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpNhapThongTinHV.Location = new System.Drawing.Point(0, 0);
            this.gpNhapThongTinHV.Name = "gpNhapThongTinHV";
            this.gpNhapThongTinHV.Size = new System.Drawing.Size(1064, 249);
            this.gpNhapThongTinHV.TabIndex = 0;
            this.gpNhapThongTinHV.TabStop = false;
            this.gpNhapThongTinHV.Text = "Thong Tin Hoc Vien";
            // 
            // gbDanhSachHocVien
            // 
            this.gbDanhSachHocVien.Controls.Add(this.lvDanhSachHV);
            this.gbDanhSachHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDanhSachHocVien.Location = new System.Drawing.Point(0, 249);
            this.gbDanhSachHocVien.Name = "gbDanhSachHocVien";
            this.gbDanhSachHocVien.Size = new System.Drawing.Size(1064, 418);
            this.gbDanhSachHocVien.TabIndex = 1;
            this.gbDanhSachHocVien.TabStop = false;
            this.gbDanhSachHocVien.Text = "Danh Sach Hoc Vien";
            // 
            // lvDanhSachHV
            // 
            this.lvDanhSachHV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMaHocVien});
            this.lvDanhSachHV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSachHV.GridLines = true;
            this.lvDanhSachHV.HideSelection = false;
            this.lvDanhSachHV.Location = new System.Drawing.Point(3, 16);
            this.lvDanhSachHV.Name = "lvDanhSachHV";
            this.lvDanhSachHV.Size = new System.Drawing.Size(1058, 399);
            this.lvDanhSachHV.TabIndex = 0;
            this.lvDanhSachHV.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachHV.View = System.Windows.Forms.View.Details;
            // 
            // chMaHocVien
            // 
            this.chMaHocVien.Text = "Ma Hoc Vien";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(275, 16);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(73, 13);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Ten Hoc Vien";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(275, 48);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(29, 13);
            this.lblSDT.TabIndex = 1;
            this.lblSDT.Text = "SDT";
            // 
            // lblNgayDangKy
            // 
            this.lblNgayDangKy.AutoSize = true;
            this.lblNgayDangKy.Location = new System.Drawing.Point(275, 82);
            this.lblNgayDangKy.Name = "lblNgayDangKy";
            this.lblNgayDangKy.Size = new System.Drawing.Size(76, 13);
            this.lblNgayDangKy.TabIndex = 2;
            this.lblNgayDangKy.Text = "Ngay Dang Ky";
            // 
            // lblGoiTap
            // 
            this.lblGoiTap.AutoSize = true;
            this.lblGoiTap.Location = new System.Drawing.Point(278, 121);
            this.lblGoiTap.Name = "lblGoiTap";
            this.lblGoiTap.Size = new System.Drawing.Size(45, 13);
            this.lblGoiTap.TabIndex = 3;
            this.lblGoiTap.Text = "Goi Tap";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(386, 16);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(200, 20);
            this.tbTen.TabIndex = 4;
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.CustomFormat = "dd\\MM\\yyyy";
            this.dtpNgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDangKy.Location = new System.Drawing.Point(386, 82);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayDangKy.TabIndex = 6;
            // 
            // cbGioiTap
            // 
            this.cbGioiTap.FormattingEnabled = true;
            this.cbGioiTap.Items.AddRange(new object[] {
            "1 Thang",
            "3 Thang",
            "6 Thang",
            "1 Nam",
            "2 Nam"});
            this.cbGioiTap.Location = new System.Drawing.Point(386, 121);
            this.cbGioiTap.Name = "cbGioiTap";
            this.cbGioiTap.Size = new System.Drawing.Size(200, 21);
            this.cbGioiTap.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(386, 48);
            this.maskedTextBox1.Mask = "0000.000.000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // pbHinhHV
            // 
            this.pbHinhHV.Location = new System.Drawing.Point(32, 35);
            this.pbHinhHV.Name = "pbHinhHV";
            this.pbHinhHV.Size = new System.Drawing.Size(190, 193);
            this.pbHinhHV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinhHV.TabIndex = 9;
            this.pbHinhHV.TabStop = false;
            // 
            // lblHinhHocVien
            // 
            this.lblHinhHocVien.AutoSize = true;
            this.lblHinhHocVien.Location = new System.Drawing.Point(278, 167);
            this.lblHinhHocVien.Name = "lblHinhHocVien";
            this.lblHinhHocVien.Size = new System.Drawing.Size(76, 13);
            this.lblHinhHocVien.TabIndex = 10;
            this.lblHinhHocVien.Text = "Hinh Hoc Vien";
            // 
            // tbDuongDan
            // 
            this.tbDuongDan.Location = new System.Drawing.Point(386, 167);
            this.tbDuongDan.Name = "tbDuongDan";
            this.tbDuongDan.ReadOnly = true;
            this.tbDuongDan.Size = new System.Drawing.Size(179, 20);
            this.tbDuongDan.TabIndex = 11;
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(587, 167);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(75, 23);
            this.btnChonHinh.TabIndex = 12;
            this.btnChonHinh.Text = "...";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            // 
            // gbLichSuTap
            // 
            this.gbLichSuTap.Controls.Add(this.lvLichSuTap);
            this.gbLichSuTap.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbLichSuTap.Location = new System.Drawing.Point(668, 16);
            this.gbLichSuTap.Name = "gbLichSuTap";
            this.gbLichSuTap.Size = new System.Drawing.Size(393, 230);
            this.gbLichSuTap.TabIndex = 13;
            this.gbLichSuTap.TabStop = false;
            this.gbLichSuTap.Text = "Lich Su Tap";
            // 
            // lvLichSuTap
            // 
            this.lvLichSuTap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNgay,
            this.chGio,
            this.chTongLan});
            this.lvLichSuTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLichSuTap.GridLines = true;
            this.lvLichSuTap.HideSelection = false;
            this.lvLichSuTap.Location = new System.Drawing.Point(3, 16);
            this.lvLichSuTap.Name = "lvLichSuTap";
            this.lvLichSuTap.Size = new System.Drawing.Size(387, 211);
            this.lvLichSuTap.TabIndex = 0;
            this.lvLichSuTap.UseCompatibleStateImageBehavior = false;
            this.lvLichSuTap.View = System.Windows.Forms.View.Details;
            // 
            // chNgay
            // 
            this.chNgay.Text = "Ngay";
            // 
            // chGio
            // 
            this.chGio.Text = "Gio";
            this.chGio.Width = 151;
            // 
            // chTongLan
            // 
            this.chTongLan.Text = "Tong Lan Quet The";
            this.chTongLan.Width = 173;
            // 
            // DanhSachHocVienUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDanhSachHocVien);
            this.Controls.Add(this.gpNhapThongTinHV);
            this.Name = "DanhSachHocVienUC";
            this.Size = new System.Drawing.Size(1064, 667);
            this.gpNhapThongTinHV.ResumeLayout(false);
            this.gpNhapThongTinHV.PerformLayout();
            this.gbDanhSachHocVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhHV)).EndInit();
            this.gbLichSuTap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpNhapThongTinHV;
        private System.Windows.Forms.GroupBox gbDanhSachHocVien;
        private System.Windows.Forms.ListView lvDanhSachHV;
        private System.Windows.Forms.ColumnHeader chMaHocVien;
        private System.Windows.Forms.ComboBox cbGioiTap;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label lblGoiTap;
        private System.Windows.Forms.Label lblNgayDangKy;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.PictureBox pbHinhHV;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox gbLichSuTap;
        private System.Windows.Forms.ListView lvLichSuTap;
        private System.Windows.Forms.ColumnHeader chNgay;
        private System.Windows.Forms.ColumnHeader chGio;
        private System.Windows.Forms.ColumnHeader chTongLan;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.TextBox tbDuongDan;
        private System.Windows.Forms.Label lblHinhHocVien;
    }
}
