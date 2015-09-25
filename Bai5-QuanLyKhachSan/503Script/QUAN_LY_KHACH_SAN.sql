create database QUAN_LY_KHACH_SAN
go
create table KHACHHANG
(	ID_KhachHang varchar(10) not null, TenKhachHang nvarchar(50), CMND varchar(10), SDT bigint 
)
create table DODUNG
(	ID_DoDung varchar(10) not null, TenDoDung nvarchar(50), TinhTrang varchar(10) check(TinhTrang in('bt','hong')), SOLUONG int
)
create table DICHVU
(	ID_DichVu varchar(10) not null, TenDichVu nvarchar(50), Gia bigint
)
create table NHANVIEN
(	ID_NhanVien varchar(10) not null, TenNhanVien nvarchar(50), CMND varchar(10), SDT bigint 
)
create table PHONG
(	ID_Phong varchar(10) not null, TinhTrang nvarchar(10), GhiChu nvarchar(50)
)

create table QUANLYPHONG
(	ID_Phong varchar(10) not null, ID_KhachHang varchar(10) not null, ID_NhanVien varchar(10) not null,NgayThue date, NgayTra date, GhiChu nvarchar(50)
)

create table CHITIETTHUEPHONG
(	ID_Phong varchar(10) not null, ID_DichVu varchar(10) not null
)
create table QUANLYDODUNG 
(	ID_Phong varchar(10) not null, ID_DoDung varchar(10) not null, SoLuong int
)

create table THANHTOAN
(	ID_Phong varchar(10) not null, NgayTra date, TongTien bigint 
)
 
go
insert into KHACHHANG values
('KH001',N'Lê Thị Ngọc Anh','174200022','0928182732'),
('KH002',N'Phan Duy Nam','174232022','0982716273'),
('KH003',N'Đào Văn Thành','174200202','0982628174'),
('KH004',N'Bùi Anh Tuấn','174200974','029182837'),
('KH005',N'Nguyễn Minh Quân','174232321','0192837172'),
('KH006',N'Trần Văn Tý','174254333','0123737180'),
('KH007',N'Đỗ Hoài Thu','174209172','0192837172'),
('KH008',N'Tạ Đình Chiến','174203232','019283162'),
('KH009',N'Võ Văn Bình','174289002','0182764718'),
('KH010',N'Nguyễn Duy Quang','174294828','0182736271')

go 
insert into DODUNG values 
('DD001A',N'TiVi','bt','10'),('DD001B',N'TiVi','hong','2'),
('DD002A',N'Tủ Lạnh','bt','6'),('DD002B',N'Tủ Lạnh','hong','2'),
('DD003A',N'Điều Hòa 2 chiều','bt','8'),('DD003B',N'Điều Hòa 2 chiều','hong','1'),
('DD004A',N'Giường','bt','7'),('DD004B',N'Giường','hong','2'),
('DD005A',N'Kệ TiVi','bt','9'),('DD005B',N'Kệ TiVi','hong','3'),
('DD006A',N'Bàn trang điểm','bt','15'),('DD006B',N'Bàn trang điểm','hong','4'),
('DD007A',N'Thùng rác','bt','9'),('DD007B',N'Thùng rác','hong','4'),
('DD008A',N'Rèm cửa','bt','11'),('DD008B',N'Rèm cửa','hong','5'),
('DD009A',N'Điều khiển','bt','12'),('DD009B',N'Điều khiển','hong','3'),
('DD010A',N'Máy giặt','bt','10'),('DD010B',N'Máy giặt','hong','4')

go 
insert into DICHVU values
('DV001',N'Dịch vụ 1','350000'),
('DV002',N'Dịch vụ 2','450000'),
('DV003',N'Dịch vụ 3','550000'),
('DV004',N'Dịch vụ 4','250000'),
('DV005',N'Dịch vụ 5','550000'),
('DV006',N'Dịch vụ 6','300000'),
('DV007',N'Dịch vụ 7','400000'),
('DV008',N'Dịch vụ 8','500000'),
('DV009',N'Dịch vụ 9','600000'),
('DV010',N'Dịch vụ 10','200000')
 go 
 insert into NHANVIEN values
('NV001',N'Lê Thị Ngọc','174200022','0928182732'),
('NV002',N'Phan Duy Nguyên','174232022','0982716273'),
('NV003',N'Đào Văn Thanh','174200202','0982628174'),
('NV004',N'Bùi Anh Huy','174200974','029182837'),
('NV005',N'Nguyễn Minh Thái','174232321','0192837172'),
('NV006',N'Trần Văn Anh','174254333','0123737180'),
('NV007',N'Đỗ Hoài Thu','174209172','0192837172'),
('NV008',N'Tạ Đình Chiến','174203232','019283162'),
('NV009',N'Võ Văn Đệ','174289002','0182764718'),
('NV010',N'Nguyễn Duy Long','174294828','0182736271')

go
insert into PHONG values
('Ph001',N'',''),
('Ph002',N'',''),
('Ph003',N'',''),
('Ph004',N'',''),
('Ph005',N'',''),
('Ph006',N'',''),
('Ph007',N'',''),
('Ph008',N'',''),
('Ph009',N'',''),
('Ph010',N'',''),
('Ph011',N'',''),
('Ph012',N'',''),
('Ph013',N'',''),
('Ph014',N'',''),
('Ph015',N'','')

go 
insert into QUANLYDODUNG values
('Ph001','DD001A','1'),('Ph001','DD002A','1'),
('Ph001','DD003A','1'),('Ph001','DD005B','1'),
('Ph001','DD007A','1'),('Ph001','DD009B','1'),
('Ph002','DD002A','1'),('Ph002','DD003A','1'),
('Ph002','DD004B','1'),('Ph002','DD006B','1'),
('Ph002','DD007A','1'),('Ph003','DD002B','1'),
('Ph003','DD009A','1'),('Ph003','DD007A','1'),
('Ph004','DD005A','1'),('Ph004','DD008A','1'),
('Ph004','DD009A','1'),('Ph004','DD010A','1'),
('Ph005','DD002A','1'),('Ph005','DD003A','1'),
('Ph006','DD005B','1'),('Ph006','DD006A','1'),
('Ph007','DD009A','1'),('Ph007','DD006A','1'),
('Ph008','DD001B','1'),('Ph008','DD002B','1'),
('Ph009','DD003A','1'),('Ph009','DD005A','1'),
('Ph009','DD007B','1'),('Ph010','DD010B','1')

go 
insert into QUANLYPHONG values
('Ph001','KH002','NV003','1/1/2015','3/1/2015',N''),
('Ph002','KH003','NV004','2/2/2015','3/3/2015',N''),
('Ph003','KH004','NV005','3/3/2015','4/3/2015',N''),
('Ph004','KH005','NV006','3/4/2015','7/4/2015',N''),
('Ph005','KH006','NV007','5/5/2015','9/5/2015',N''),
('Ph006','KH007','NV008','6/7/2015','10/7/2015',N''),
('Ph007','KH008','NV009','8/8/2015','',N''),
('Ph008','KH009','NV010','9/8/2017','',N'')

go 
insert into CHITIETTHUEPHONG values
('Ph001','DV001'),('Ph001','DV002'),('Ph001','DV003'),('Ph001','DV004'),
('Ph002','DV002'),('Ph002','DV003'),('Ph002','DV004'),
('Ph003','DV003'),('Ph003','DV005'),('Ph003','DV006'),
('Ph004','DV004'),('Ph004','DV008'),
('Ph005','DV005'),('Ph005','DV006'),('Ph005','DV007'),('Ph005','DV009'),
('Ph006','DV006'),('Ph006','DV009'),
('Ph007','DV003'),('Ph007','DV006'),('Ph007','DV008'),
('Ph008','DV001'),('Ph008','DV002'),('Ph008','DV010')

alter table KHACHHANG add constraint PK_KH primary key (ID_KhachHang)
alter table DODUNG add constraint PK_DD primary key (ID_DoDung)
alter table DICHVU add constraint PK_DV primary key (ID_DichVu)
alter table NHANVIEN add constraint PK_NV primary key (ID_NhanVien)
alter table PHONG add constraint PK_Ph primary key (ID_Phong)

alter table CHITIETTHUEPHONG add constraint PK_CTTP primary key (ID_Phong, ID_DichVu),
	constraint PK_CTTP_Ph foreign key(ID_Phong) references PHONG(ID_Phong),
	constraint PK_CTTP_DV foreign key(ID_DichVu) references DICHVU(ID_DichVu)

alter table QUANLYDODUNG add constraint PK_QLDD primary key (ID_Phong, ID_DoDung),
	constraint PK_QLDD_Ph foreign key (ID_Phong) references PHONG(ID_Phong),
	constraint PK_QLDD_DD foreign key (ID_DoDung) references DODUNG(ID_DoDung)
	
alter table QUANLYPHONG add constraint PK_QLP primary key (ID_Phong, ID_KhachHang,ID_NhanVien),
	constraint PK_QLP_Ph foreign key (ID_Phong) references PHONG(ID_Phong),
	constraint PK_QLP_NV foreign key (ID_NhanVien) references NHANVIEN(ID_NhanVien),
	constraint PK_QLP_KH foreign key (ID_KhachHang) references KHACHHANG(ID_KhachHang)

create table DANGNHAP
(	Username varchar(50) not null,
	Pass varchar(50)
)

alter table DANGNHAP add constraint PK_DN primary key (Username)
insert into DANGNHAP values
('khuonghoang','hoanglaota'),
('tuananh','anhle123'),
('vokhuonglinh','linh123'),
('quangtruong','truong123'),
('anhtuan','tuan123'),
('hongquan','quan123')