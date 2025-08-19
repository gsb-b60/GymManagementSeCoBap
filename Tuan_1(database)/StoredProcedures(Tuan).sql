----------------------------------------------------
create proc Themcv
	@id int, @cvu nvarchar(100), @mt nvarchar(100)
as
	if exists(select * from ChiTietChucVu where @id = ID)
	begin
		print N'Đã tồn tại mã chức vụ.'
		return;
	end
	insert into ChiTietChucVu values (@id, @cvu, @mt)
	print N'Thêm thành công.'
go
select * from ChiTietChucVu
drop proc Themcv
exec Themcv 5, N'Kỹ thuật', N'Sửa chữa các máy'
go
-------------------------------------------------------------------------
create proc Themgt
	@id int, @ThoiGian int, @mt nvarchar(1000), @GiaTri bigint
as
	if exists(select * from ChiTietGoiTap where @id = ID)
	begin
		print N'Đã tồn tại mã gói tập.'
		return;
	end
	insert into ChiTietGoiTap values (@id, @ThoiGian, @mt, @GiaTri)
	print N'Thêm thành công.'
go
select * from ChiTietGoiTap
drop proc Themgt
exec Themgt 5, 12, N'Gói tập 12 tháng', 2000000
go
-------------------------------------------------------------------------
create procedure ThemHang
	@id int, @TenHang nvarchar(100), @DiaChiHang nvarchar(1000), @SDTHang nvarchar(10)
as
	if exists(select * from ChiTietHangThietBi where @id = ID)
		begin
			print N'Bị trùng ID'
			return;
		end
	if exists(select * from ChiTietHangThietBi where @TenHang = TenHangThietBi and @DiaChiHang = DiaChiMuaHang and @SDTHang = SDT)
		begin
			print N'Đã tồn tại hãng ' + @TenHang
			return;
		end
	insert into ChiTietHangThietBi values(@id, @TenHang, @DiaChiHang, @SDTHang)
	print N'Thêm thành công.'
go
select * from ChiTietHangThietBi
drop proc ThemHang
exec ThemHang 4, N'Kaitashi', N'1 Thông Thiên Học', N'0138771827'
exec ThemHang 3, N'Ki', N'1 Thông Thiên Học', N'0138771827'
go
---------------------------------------------------------------
create proc ThemThietBi
	@id int, @Tentb nvarchar(1000), @IDHang int, @ThoiGianMua date, @ThoiGianBaoDuong date, @khananghd bit
as
	if exists(select * from DanhSachThietBi where @id = ID)
	begin
		print N'Đã tồn tại ID'
		return;
	end
	if not exists(select * from ChiTietHangThietBi where @IDHang = ID)
	begin
		print N'Không tồn tại hãng'
		return;
	end
	insert into DanhSachThietBi values(@id, @Tentb, @IDHang, @ThoiGianMua, @ThoiGianBaoDuong, @khananghd)
	print N'Thêm thành công'
go
select * from DanhSachThietBi
drop proc ThemThietBi
exec ThemThietBi 3, N'Máy chạy bộ', 5, N'2025-01-10', N'2025-11-11', 1
go
-----------------------------------------------------------
create proc ThemNV
	@id int, @tennv nvarchar(1000), @nsinh date, @sdt nvarchar(10), @luong money, @NgayVao date, @idcvu int
as
	if exists(select * from DanhSachNhanVien where @id = ID)
	begin
		print N'Đã tồn tại ID nhân viên.'
		return;
	end
	if not exists(select * from ChiTietChucVu where @idcvu = ID)
	begin
		print N'Không tồn tại chức vụ'
		return;
	end
	insert into DanhSachNhanVien values(@id, @tennv, @nsinh, @sdt, @luong, @NgayVao, @idcvu)
	print N'Thêm thành công'
go
select * from DanhSachNhanVien
drop proc ThemNV
exec ThemNV 1, N'Nguyễn Thái Hà', N'1997-04-12', N'083212522', 12000000.0000, N'2020-01-10', 1
exec ThemNV 2, N'Lê Hồ Anh Tiến', N'2005-12-02' , N'082312322', 7000000.0000, N'2023-07-02' , 2
exec ThemNV 3, N'Nguyễn Đình Hiếu', N'2005-07-24' , N'082143123', 8500000.0000, N'2022-08-10' , 3

exec ThemNV 1, N'Lê Nguyễn Đức Minh', N'07/02/2005', N'0863155279', 12000000, N'04/10/2024', 1
exec ThemNV 4, N'Lê Nguyễn Đức Minh', N'07/02/2005', N'0863155279', 12000000, N'04/10/2024', 2
exec ThemNV 4, N'Lê Nguyễn Đức Minh', N'07/02/2005', N'0863155279', 12000000, N'04/10/2024', 1
go
-----------------------------------------------------------------------------------------
create proc ThemHV 
	@id int, @Ten nvarchar(1000), @sdt nvarchar(10), @Ngaydk smalldatetime, @Ngaykt smalldatetime, @idthe nvarchar(5), @idgt int
as
	if exists(select * from HocVien where @id = ID)
	begin
		print N'Đã tồn tại ID khách.'
		return;
	end
	if exists(select * from HocVien where @idthe = IDThe)
	begin
		print N'Đã tồn tại thẻ.'
		return;
	end
	if not exists(select * from ChiTietGoiTap where @idgt = ID)
	begin
		print N'Không tồn tại gói tập.'
		return;
	end
	insert into HocVien values(@id, @Ten, @sdt, @Ngaydk, @Ngaykt, @idthe, @idgt)
	print N'Thêm thành công'
go
select * from HocVien
drop proc ThemHV
exec ThemHV 1, N'Võ Ngọc Minh Anh', N'064729861', N'01/09/2023', N'01/12/2023', N'B0001', 5
exec ThemHV 4, N'Võ Ngọc Minh Anh', N'064729871', N'01/09/2023', N'01/12/2023', N'B0004', 1
exec ThemHV 5, N'Võ Ngọc Minh Anh', N'064729871', N'01/09/2023', N'01/12/2023', N'B0004', 3
exec ThemHV 3, N'Cao Thiên Nausica', N'082341232', N'2025-08-01T11:30:00', N'2025-12-01T11:30:00', N'B0003', 2

go
----------------------------------------------------------------------------------
create proc ThemHD
	@idhd int, @idhv int, @km money, @Thu money, @Ngaytra date, @idgoi int
as
	if exists(select * from HoaDon where @idhd = IDHoaDon)
	begin
		print N'Đã tồn tại ID hóa đơn.'
		return;
	end
	if not exists(select * from HocVien where @idhv = ID)
	begin
		print N'Không tồn tại học viên.'
		return;
	end
	if not exists(select * from ChiTietGoiTap where @idgoi = ID)
	begin
		print N'Không tồn tại gói tập.'
		return;
	end
	insert into HoaDon values(@idhd, @idhv, @km, @Thu, @Ngaytra, @idgoi)
	print N'Thêm thành công'
go
select * from HoaDon
drop proc ThemHD
exec ThemHD 3, 4, 0, 2000000, N'11/11/2024', 2
exec ThemHD 5, 3, 0, 2000000, N'11/11/2024', 6
exec ThemHD 3, 3, 79000.0000, 600000.0000, N'2025-08-01', 2
go

------------==========================================================================
create proc SuaCV
	@id int, @cvu nvarchar(100), @mt nvarchar(100)
as
	if exists (select * from ChiTietChucVu where @id = ID)
	begin
		update ChiTietChucVu set ID = @id, ChucVu = @cvu, MoTa = @mt where @id = ID
		print N'Đã sửa thành công.'
	end
	else
	begin
		print N'Không tồn tại ID chức vụ.'
		return;
	end
go
select * from ChiTietChucVu
drop proc SuaCV
exec Suacv 3, N'Vệ Sinh', N'Vệ sinh phòng tập'
exec Suacv 4, N'Vệ Sinh', N'Vệ sinh phòng tập'
go

create proc SuaGT
	@id int, @ThoiGian int, @mt nvarchar(1000), @GiaTri bigint
as
	if exists (select * from ChiTietGoiTap where @id = ID)
	begin
		update ChiTietGoiTap set ID = @id, ThoiGianGoi_Thang = @ThoiGian, MoTa = @mt, GiaTriGoi = @GiaTri where @id = ID
		print N'Đã sửa thành công.'
	end
	else
	begin
		print N'Không tồn tại ID gói tập.'
		return;
	end
go
select * from ChiTietGoiTap
drop proc SuaGT
exec SuaGT 1, 1, N'Gói tập 1 tháng', 300000
exec SuaGT 4, 1, N'Gói tập 1 tháng', 120000
go

create proc SuaHang
	@id int, @TenHang nvarchar(100), @DiaChiHang nvarchar(1000), @SDTHang nvarchar(10)
as
	if exists (select * from ChiTietHangThietBi where @id = ID)
	begin
		update ChiTietHangThietBi set ID = @id, TenHangThietBi = @TenHang, DiaChiMuaHang = @DiaChiHang, SDT = @SDTHang where @id = ID
		print N'Đã sửa thành công.'
	end
	else
	begin
		print N'Không tồn tại ID hãng.'
		return;
	end
go
select * from ChiTietHangThietBi
drop proc SuaHang
exec SuaHang 2, N'Kaitashi', N'07,Tôn Đức Thắng,Bến Nghé,TP HCM', 0912233789
exec SuaHang 4, N'Kaitashi', N'07,Tôn Đức Thắng,Bến Nghé,TP HCM', 0912233789
go

create proc SuaTB
	@id int, @Tentb nvarchar(1000), @IDHang int, @ThoiGianMua date, @ThoiGianBaoDuong date, @khananghd bit
as
	if exists (select * from DanhSachThietBi where @id = ID)
	begin
		if not exists (select * from ChiTietHangThietBi where @IDHang = ID)
		begin
			print N'Không tồn tại ID hãng thiết bị.'
			return;
		end
		else
		begin
			update DanhSachThietBi set ID = @id, TenThietBi = @Tentb, IDHangSanXuat = @IDHang, ThoiGianMua = @ThoiGianMua, 
				ThoiGianBaoDuong = @ThoiGianBaoDuong, KhaNangHoatDong = @khananghd 
				where @id = ID
			print N'Đã sửa thành công.'
		end
	end
	else
	begin
		print N'Không tồn tại ID thiết bị.'
		return;
	end
go
select * from DanhSachThietBi
drop proc SuaTB
exec SuaTB 3, N'Máy chạy bộ', 2, '08/10/2023', '08/10/2024', 0
exec SuaTB 2, N'Máy chạy bộ', 4, '08/10/2023', '08/10/2024', 0
exec SuaTB 2, N'Máy chạy bộ', 2, '08/10/2023', '08/10/2024', 0
go

create proc SuaNV
	@id int, @tennv nvarchar(1000), @nsinh date, @sdt nvarchar(10), @luong money, @NgayVao date, @idcvu int
as
	if exists (select * from DanhSachNhanVien where @id = ID)
	begin
		if not exists (select * from ChiTietChucVu where @idcvu = ID)
		begin
			print N'Không tồn tại ID chức vụ.'
			return;
		end
		else
		begin
			update DanhSachNhanVien set ID = @id, TenNhanVien = @tennv, NgaySinh = @nsinh, SDT = @sdt, 
				Luong = @luong, NgayVao = @NgayVao, IDChucVu = @idcvu 
				where @id = ID
			print N'Đã sửa thành công.'
		end
	end
	else
	begin
		print N'Không tồn tại ID nhân viên.'
		return;
	end
go
select * from DanhSachNhanVien
drop proc SuaNV
exec SuaNV 1, N'Nguyễn Hà', '1997-04-12', N'083212522', 12000000, '2020-01-10', 1
exec SuaNV 4, N'Nguyễn Hà', '1997-04-12', N'083212522', 12000000, '2020-01-10', 1
exec SuaNV 1, N'Nguyễn Hà', '1997-04-12', N'083212522', 12000000, '2020-01-10', 5
go

create proc SuaHV
	@id int, @Ten nvarchar(1000), @sdt nvarchar(10), @Ngaydk smalldatetime, @Ngaykt smalldatetime, @idgt int-- 
as
	if exists (select * from HocVien where @id = ID)
	begin
		if not exists (select * from ChiTietGoiTap where @idgt = ID)
		begin
			print N'Không tồn tại ID gói tập.'
			return;
		end
		update HocVien set ID = @id, Ten = @Ten, SDT = @sdt, NgayDangKy = @Ngaydk, 
			NgayKetThuc = @Ngaykt, IDGoiTap = @idgt 
			where @id = ID
		print N'Đã sửa thành công.'
	end
	else
	begin
		print N'Không tồn tại ID khách hàng.'
		return;
	end
go
select * from HocVien
drop proc SuaHV
exec SuaHV 1, N'Naruto', '083242323', '2023-10-27 10:00:00', '2024-10-27 10:00:00', 1
exec SuaHV 4, N'Naruto', '083242323', '2023-10-27 10:00:00', '2024-10-27 10:00:00', 1
exec SuaHV 1, N'Naruto', '083242323', '2023-10-27 10:00:00', '2024-10-27 10:00:00', 9
go

create proc SuaHD
	@idhd int, @idhv int, @km money, @Thu money, @Ngaytra date, @idgoi int 
as
	if exists (select * from HoaDon where @idhd = IDHoaDon)
	begin
		if not exists (select * from HocVien where @idhv = ID)
		begin
			print N'Không tồn tại ID học viên.'
			return;
		end
		if not exists (select * from ChiTietGoiTap where @idgoi = ID)
		begin
			print N'Không tồn tại ID gói tập.'
			return;
		end
		update HoaDon set IDHoaDon = @idhd, IDHocVien = @idhv, KhuyenMai = @km, SoTienThu = @Thu, 
			NgayTra = @Ngaytra, IDGoiDangKy = @idgoi
			where @idhd = IDHoaDon
		print N'Đã sửa thành công.'
	end
	else
	begin
		print N'Không tồn tại ID hóa đơn.'
		return;
	end
go
select * from HoaDon
drop proc SuaHD
exec SuaHD 2, 1, 30000, 1070000, '2024-10-27 10:00:00', 3
exec SuaHD 5, 1, 30000, 1070000, '2024-10-27 10:00:00', 3
exec SuaHD 2, 1, 30000, 1070000, '2024-10-27 10:00:00', 9
exec SuaHD 2, 2, 30000, 1070000, '2025-08-01', 3
go
--=====================================================================================
create proc XoaNV @id int
as
	if exists (select * from DanhSachNhanVien where @id = ID)
	begin
		delete from DanhSachNhanVien where @id = ID
		print N'Đã xóa thành công.'
	end
	else
	begin
		print N'Không tồn tại ID nhân viên.'
	end
go
select * from DanhSachNhanVien
drop proc XoaNV
exec XoaNV 1
go

create proc XoaHV @id int
as
	if exists (select * from HocVien where @id = ID)
	begin
		if exists (select * from HoaDon where @id = IDHocVien)
		begin
			delete from HoaDon where @id = IDHocVien
			print N'Đã xóa hóa đơn có học viên muốn xóa.'
		end
		delete from HocVien where @id = ID
		print N'Đã xóa thành công.'
	end
	else
	begin
		print N'Không tồn tại ID khách hàng.'
	end
go
select * from HoaDon
select * from HocVien
drop proc XoaHV
exec XoaHV 3
go

create proc XoaTB @id int
as
	if exists (select * from DanhSachThietBi where @id = ID)
	begin
		delete from DanhSachThietBi where @id = ID
		print N'Đã xóa thành công.'
	end
	else
	begin
		print N'Không tồn tại ID thiết bị.'
	end
go
select * from DanhSachThietBi
drop proc XoaTB
exec XoaTB 2
exec ThemThietBi 1, N'Bộ Thiết bị Cable đa năng', 1, '2021-05-01', '2022-05-01', 1
exec ThemThietBi 2, N'Máy chạy bộ', 2, '2023-08-10', '2024-08-10', 1
go

create proc XoaHang @id int
as
	if exists (select * from ChiTietHangThietBi where @id = ID)
	begin
		if exists (select * from DanhSachThietBi where @id = IDHangSanXuat)
		begin
			delete from DanhSachThietBi where @id = IDHangSanXuat
			print N'Đã xóa thiết bị của hãng muốn xóa.'
		end
		delete from ChiTietHangThietBi where @id = ID
		print N'Đã xóa thành công.'
	end
	else
	begin
		print N'Không tồn tại ID hãng.'
	end
go
select * from DanhSachThietBi
select * from ChiTietHangThietBi
drop proc XoaHang
exec ThemHang 2, N'Humanity', N'12,Đinh Tiên Hoàng, Quận 1,TP HCM', N'0928382938'
exec ThemThietBi 2, N'Máy chạy bộ', 2, '2023-08-10', '2024-08-10', 1
exec XoaHang 2
go
---------------------------------------------------------------------------------------
--Lập danh sách khách hàng theo gói tập cho trước
create proc Dskh @idgt int
as
	if exists(select * from ChiTietGoiTap where @idgt = ID)
	begin
		select a.ID as [ID khách], a.Ten, a.SDT, b.MoTa, b.ThoiGianGoi_Thang, 
		a.NgayDangKy, a.NgayKetThuc, b.GiaTriGoi 
		from HocVien a, ChiTietGoiTap b where a.IDGoiTap = b.ID and @idgt = b.ID
	end
	else 
	begin
		print N'Không có ID gói tập.'
	end
go
drop proc Dskh
exec Dskh '1'
select * from ChiTietGoiTap
select * from HocVien
go
--Lập danh sách khách hàng theo gói tập cho trước
create proc Dstb @idh int
as
	if exists(select * from ChiTietHangThietBi where @idh = ID)
	begin
		select a.ID as [ID hãng], a.TenHangThietBi as [Tên hãng], a.DiaChiMuaHang, a.SDT, 
			b.TenThietBi, b.ThoiGianMua, b.ThoiGianBaoDuong, 
			case when b.KhaNangHoatDong = 1 then N'Tốt' 
			when b.KhaNangHoatDong = 0 then N'Hỏng' 
			else N'Không xác định' end as [Trạng thái]
		from ChiTietHangThietBi a, DanhSachThietBi b where a.ID = b.IDHangSanXuat and @idh = b.IDHangSanXuat
	end
	else 
	begin
		print N'Không có ID hãng.'
	end
go
exec Dstb '2'
drop proc Dstb
select * from ChiTietHangThietBi
select * from DanhSachThietBi


select * from ChiTietChucVu
select * from ChiTietGoiTap
select * from ChiTietHangThietBi
select * from DanhSachNhanVien
select * from DanhSachThietBi
select * from HoaDon
select * from HocVien
go