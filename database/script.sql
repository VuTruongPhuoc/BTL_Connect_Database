create database [Quanli_CuaHangBanTV]
go
USE [Quanli_CuaHangBanTV]
GO
/****** Object:  Table [dbo].[tChiTietHDB]    Script Date: 10/31/2022 9:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tChiTietHDB](
	[SoHDB] [nvarchar](10) NOT NULL,
	[MaSP] [nvarchar](10) NOT NULL,
	[SLBan] [int] NULL,
	[Khuyenmai] [float] NULL,
 CONSTRAINT [PK_tChiTietHDB] PRIMARY KEY CLUSTERED 
(
	[SoHDB] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tChitietHDN]    Script Date: 10/31/2022 9:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tChitietHDN](
	[SoHDN] [nvarchar](10) NOT NULL,
	[MaSP] [nvarchar](10) NOT NULL,
	[SLNhap] [int] NULL,
 CONSTRAINT [PK_tChiTietHDN] PRIMARY KEY CLUSTERED 
(
	[SoHDN] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tChucVu]    Script Date: 10/31/2022 9:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tChucVu](
	[MaNV] [nvarchar](10) NOT NULL,
	[Chucvu] [nvarchar](20) NULL,
 CONSTRAINT [PK_tChucVu] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tHoaDonBan]    Script Date: 10/31/2022 9:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tHoaDonBan](
	[SoHDB] [nvarchar](10) NOT NULL,
	[MaNV] [nvarchar](10) NULL,
	[MaKH] [nvarchar](10) NULL,
	[NgayLap] [datetime] NULL,
	[Thanhtien] [money] NULL,
 CONSTRAINT [PK_tHoaDonBan] PRIMARY KEY CLUSTERED 
(
	[SoHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tHoaDonNhap]    Script Date: 10/31/2022 9:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tHoaDonNhap](
	[SoHDN] [nvarchar](10) NOT NULL,
	[MaNCC] [nvarchar](10) NULL,
	[MaNV] [nvarchar](10) NULL,
	[NgayNhap] [datetime] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_tHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[SoHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tKhachHang]    Script Date: 10/31/2022 9:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tKhachHang](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](20) NOT NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](40) NULL,
 CONSTRAINT [PK_tKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tNhaCungCap]    Script Date: 10/31/2022 9:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tNhaCungCap](
	[MaNCC] [nvarchar](10) NOT NULL,
	[TenNCC] [nvarchar](40) NOT NULL,
	[DienThoai] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](40) NULL,
 CONSTRAINT [PK_tNhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tNhanVien]    Script Date: 10/31/2022 9:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tNhanVien](
	[MaNV] [nvarchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](150) NULL,
	[DienThoai] [nvarchar](15) NULL,
 CONSTRAINT [PK_tNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tSanPham]    Script Date: 10/31/2022 9:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tSanPham](
	[MaSP] [nvarchar](10) NOT NULL,
	[TenSP] [nvarchar](20) NOT NULL,
	[MaTH] [nvarchar](10) NULL,
	[KichThuoc] [nvarchar](10) NULL,
	[DoPhanGiai] [nvarchar](15) NULL,
	[ManHinh] [nvarchar](15) NULL,
	[SoLuong] [int] NULL,
	[DonGiaNhap] [money] NULL,
	[DonGiaBan] [money] NULL,
	[HinhAnh] [nvarchar](20) NULL,
	[ThoiGianBaoHanh] [nvarchar](10) NULL,
	[GhiChu] [nvarchar](255) NULL,
 CONSTRAINT [PK_tSanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tThuongHieu]    Script Date: 10/31/2022 9:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tThuongHieu](
	[MaTH] [nvarchar](10) NOT NULL,
	[TenTH] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tThuongHieu] PRIMARY KEY CLUSTERED 
(
	[MaTH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_tChiTietHDB_tHoaDonBan] FOREIGN KEY([SoHDB])
REFERENCES [dbo].[tHoaDonBan] ([SoHDB])
GO
ALTER TABLE [dbo].[tChiTietHDB] CHECK CONSTRAINT [FK_tChiTietHDB_tHoaDonBan]
GO
ALTER TABLE [dbo].[tChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_tChiTietHDB_tSanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tSanPham] ([MaSP])
GO
ALTER TABLE [dbo].[tChiTietHDB] CHECK CONSTRAINT [FK_tChiTietHDB_tSanPham]
GO
ALTER TABLE [dbo].[tChitietHDN]  WITH CHECK ADD  CONSTRAINT [FK_tChiTietHDB_tHoaDonNhap] FOREIGN KEY([SoHDN])
REFERENCES [dbo].[tHoaDonNhap] ([SoHDN])
GO
ALTER TABLE [dbo].[tChitietHDN] CHECK CONSTRAINT [FK_tChiTietHDB_tHoaDonNhap]
GO
ALTER TABLE [dbo].[tChitietHDN]  WITH CHECK ADD  CONSTRAINT [FK_tChiTietHDN_tSanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tSanPham] ([MaSP])
GO
ALTER TABLE [dbo].[tChitietHDN] CHECK CONSTRAINT [FK_tChiTietHDN_tSanPham]
GO
ALTER TABLE [dbo].[tHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_tHoaDonBan_tKhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tKhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tHoaDonBan] CHECK CONSTRAINT [FK_tHoaDonBan_tKhachHang]
GO
ALTER TABLE [dbo].[tHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_tHoaDonBan_tNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tHoaDonBan] CHECK CONSTRAINT [FK_tHoaDonBan_tNhanVien]
GO
ALTER TABLE [dbo].[tHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tHoaDonNhap_tNhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tNhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[tHoaDonNhap] CHECK CONSTRAINT [FK_tHoaDonNhap_tNhaCungCap]
GO
ALTER TABLE [dbo].[tHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tHoaDonNhap_tNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tHoaDonNhap] CHECK CONSTRAINT [FK_tHoaDonNhap_tNhanVien]
GO
ALTER TABLE [dbo].[tNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tSanPham_tChucvu] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tChucVu] ([MaNV])
GO
ALTER TABLE [dbo].[tNhanVien] CHECK CONSTRAINT [FK_tSanPham_tChucvu]
GO
ALTER TABLE [dbo].[tSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tSanPham_tThuongHieu] FOREIGN KEY([MaTH])
REFERENCES [dbo].[tThuongHieu] ([MaTH])
GO
ALTER TABLE [dbo].[tSanPham] CHECK CONSTRAINT [FK_tSanPham_tThuongHieu]
GO
ALTER TABLE [dbo].[tKhachHang]  WITH CHECK ADD  CONSTRAINT [CHK_KhachHang_SODIENTHOAI] CHECK  (([DIENTHOAI] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [DIENTHOAI] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [DIENTHOAI] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[tKhachHang] CHECK CONSTRAINT [CHK_KhachHang_SODIENTHOAI]
GO
ALTER TABLE [dbo].[tNhaCungCap]  WITH CHECK ADD  CONSTRAINT [CHK_NhaCungCap_SODIENTHOAI] CHECK  (([DIENTHOAI] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [DIENTHOAI] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [DIENTHOAI] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[tNhaCungCap] CHECK CONSTRAINT [CHK_NhaCungCap_SODIENTHOAI]
GO
ALTER TABLE [dbo].[tNhanVien]  WITH CHECK ADD  CONSTRAINT [CHK_NHANVIEN_SODIENTHOAI] CHECK  (([DIENTHOAI] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [DIENTHOAI] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [DIENTHOAI] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[tNhanVien] CHECK CONSTRAINT [CHK_NHANVIEN_SODIENTHOAI]
GO
insert tThuongHieu values(N'TH001', 'Sonny')
insert tThuongHieu values(N'TH002', 'SamSung')
insert tThuongHieu values(N'TH003', 'LG')

insert tSanPham values('SP001', 'Tivi Sony', 'TH002', '24 inch', 'Full HD', 'Oled', 13, 5000000, 12000000, null, '2 nam', null)
insert tSanPham values('SP002', 'Tivi Samsung', 'TH003', '24 inch', 'Full HD', 'Oled', 16, 4000000, 10000000, null, '2 nam', null)

--hien thi sanpham
create proc [dbo].[SP_HienThiSP]
as
begin
    select * from tSanPham
end
--them san pham
create proc [dbo].[SP_ThemSP]
@masp nvarchar(50),@tensp nvarchar(50),@math nvarchar(50), @kichthuoc nvarchar(50), @dpg nvarchar(50), 
@manhinh nvarchar(50), @sl int , @dgn money , @dgb money, @hinhanh nvarchar(50), @bh nvarchar(50), @mota nvarchar(1000)
as
begin
    Insert into tSanPham values(@masp,@tensp,@math,@kichthuoc,@dpg,@manhinh,@sl,@dgn,@dgb,@hinhanh,@bh,@mota)
end
--sua san pham
create proc [dbo].[SP_SuaSP]
@masp nvarchar(50),@tensp nvarchar(50),@math nvarchar(50), @kichthuoc nvarchar(50), @dpg nvarchar(50), 
@manhinh nvarchar(50), @sl int , @dgn money , @dgb money, @hinhanh nvarchar(50), @bh nvarchar(50), @mota nvarchar(1000)
as
begin
    update tSanPham set
	TenSP = @tensp, MaTH = @math, KichThuoc = @kichthuoc , DoPhanGiai = @dpg, ManHinh = @manhinh,
	SoLuong = @sl, DonGiaNhap = @dgn, DonGiaBan = @dgb , HinhAnh = @hinhanh, ThoiGianBaoHanh = @bh, GhiChu = @mota
	where MaSP = @masp
end
--xoa san pham
create proc [dbo].[SP_XoaSP]
@masp nvarchar(50)
as
begin
    delete tSanPham where MaSP = @masp
end

create proc [dbo].[SP_HienThiTH]
as
begin
    select * from tThuongHieu
end