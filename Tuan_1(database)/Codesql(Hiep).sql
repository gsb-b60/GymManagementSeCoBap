Use [Gym Mangagement]
go
Select * from ChiTietChucVu
Select * from ChiTietGoiTap
Select * from ChiTietHangThietBi
Select * from DanhSachNhanVien
Select * from DanhSachThietBi
Select * from HoaDon
Select * from HocVien

create function TimGoiThangHonNuaNam() returns Table
As
return (
	Select * 
	from ChiTietGoiTap
	where ThoiGianGoi_Thang = 6 and ThoiGianGoi_Thang > 6
)
go

drop function TimGoiThangHonNuaNam

Select * from TimGoiThangHonNuaNam()

create function NhanVienTheoChucVu (@IDChucVu int) returns Table
as
return(
	Select B.ID, TenNhanVien, ChucVu
	from ChiTietChucVu A, DanhSachNhanVien B
	where B.IDChucVu = @IDChucVu and A.ID = @IDChucVu 
)
go

drop function NhanVienTheoChucVu

Select * from NhanVienTheoChucVu('1')
Select * from NhanVienTheoChucVu('2')
Select * from NhanVienTheoChucVu('3')

Create function TimHocVienTheoGoiHoc(@IDGoiTap int) returns table
as
return (
	select A.ID, Ten, A.IDGoiTap, ThoiGianGoi_Thang, GiaTriGoi
	from HocVien A, ChiTietGoiTap B
	Where A.IDGoiTap = @IDGoiTap and @IDGoiTap =B.ID
)
go

drop function TimHocVienTheoGoiHoc

Select * from TimHocVienTheoGoiHoc('1')
Select * from TimHocVienTheoGoiHoc('2')
Select * from TimHocVienTheoGoiHoc('3')

Create function TongTienTrongMotThang(@Thang int) returns int
as
	begin
	declare @Tong int
		if exists(select * from HoaDon where Month(NgayTra) = @Thang)
			begin 
			select @Tong = sum(SoTienThu)
			from HoaDon
			where Month(NgayTra) = @Thang
			end
	return @Tong
	end
go

drop function TongTienTrongMotThang

print dbo.TongTienTrongMotThang('11')

Create function TongTienTrongMotNam(@Nam int) returns int
as
	begin
	declare @Tong int
		if exists(select * from HoaDon where Year(NgayTra) = @Nam)
			begin 
			select @Tong = sum(SoTienThu)
			from HoaDon
			where Year(NgayTra) = @Nam
			end
	return @Tong
	end
go

drop function TongTienTrongMotNam

print dbo.TongTienTrongMotNam('2025')

Create function TongTienTheoGoi(@IDGoiTap int) returns int
as
	begin
	declare @Tong int
		if exists(select * from HocVien where IDGoiTap = @IDGoiTap)
			begin 
			select @Tong = sum(GiaTriGoi)
			from ChiTietGoiTap A, HocVien B
			where A.ID = B.IDGoiTap and B.IDGoiTap = @IDGoiTap
			end
	return @Tong
	end
go

drop function TongTienTheoGoi

print dbo.TongTienTheoGoi('1')
print dbo.TongTienTheoGoi('2')
print dbo.TongTienTheoGoi('3')

create function CoGiamGiaKhong(@IDHoaDon int) returns nvarchar(30)
As
	begin
	declare @ThongBao nvarchar(30)
		if exists(Select A.IDHoaDon 
				from HoaDon A
				where A.IDHoaDon = @IDHoaDon and KhuyenMai > 0)
		Set @ThongBao = 'Có khuyến mãi'
	else 
		set @ThongBao = 'Không có khuyến mãi'
	return @ThongBao
end


drop function CoGiamGiaKhong

print dbo.CoGiamGiaKhong('1')
print dbo.CoGiamGiaKhong('2')
print dbo.CoGiamGiaKhong('3')

create function CoHuHongKhong(@IDThietBi int) returns nvarchar(30)
As
	begin
	declare @ThongBao nvarchar(30)
		if exists(Select A.ID 
				from DanhSachThietBi A
				where A.ID = @IDThietBi and KhaNangHoatDong = 0)
		Set @ThongBao = 'Hư hỏng'
	else 
		set @ThongBao = 'Bình thường'
	return @ThongBao
end


drop function CoHuHongKhong

print dbo.CoHuHongKhong('1')
print dbo.CoHuHongKhong('2')

create function LietKeThietBiTheoIDHang (@IDHang int) returns table
as
return(
	Select B.ID, TenThietBi, B.IDHangSanXuat, TenHangThietBi
	from ChiTietHangThietBi A, DanhSachThietBi B
	where A.ID = @IDHang and @IDHang = B.IDHangSanXuat
)
go

drop function LietKeThietBiTheoIDHang

select * from LietKeThietBiTheoIDHang('1')
select * from LietKeThietBiTheoIDHang('2')
select * from LietKeThietBiTheoIDHang('3')


create function LietKeThietBiTheoTenHang (@TenHang nvarchar(20)) returns table
as
return(
	Select B.ID, TenThietBi, B.IDHangSanXuat, TenHangThietBi
	from ChiTietHangThietBi A, DanhSachThietBi B
	where A.TenHangThietBi = @TenHang and A.ID = B.IDHangSanXuat
)
go

drop function LietKeThietBiTheoTenHang

select * from LietKeThietBiTheoTenHang('TechNoGym')
select * from LietKeThietBiTheoTenHang('Humanity')
select * from LietKeThietBiTheoTenHang('HiaMusscle')