create database QUAN_LY_SIEU_THI
use QUAN_LY_SIEU_THI
go
create table KHACHHANG
(	ID_KhachHang varchar(10) not null, TenKhachHang nvarchar(50), CMND varchar(10), SDT bigint 
)
create table NHANVIEN
(	ID_NhanVien varchar(10) not null, TenNhanVien nvarchar(50), CMND varchar(10), SDT bigint 
)
create table CHITIETHOADON
(	ID_HoaDon varchar(10) not null, ID_HangHoa varchar(10) not null, SoLuong int
)

create table HANGHOA
(	ID_HangHoa varchar(10) not null, TenHangHoa nvarchar(50), SoLuong int, Gia bigint 
)
create table HOADON
(	ID_HoaDon varchar(10) not null, ID_NhanVien varchar(10) not null, ID_KhachHang varchar(10) not null, Ngay date
)
create table DANGNHAP
(	Username varchar(50) not null,
	Pass varchar(50)
)
drop table HOADON
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
insert into HANGHOA values
('HH001',N'Sữa ông thọ','100','10000'),
('HH002',N'Sữa chua VINAMILK','90','5000'),
('HH003',N'Bia HALIDA','80','110000'),
('HH004',N'Bia Hà Nội','70','200000'),
('HH005',N'Dầu ăn Tường An','80','50000'),
('HH006',N'Bánh quy Hải Châu','90','20000'),
('HH007',N'Bánh bông lan','100','24000'),
('HH008',N'Bánh ngọt Chocopice','120','290000'),
('HH009',N'Xúc xích Đức Việt','110','7000'),
('HH010',N'Bánh đa nem','65','10000'),
('HH011',N'Bánh gai Tứ Trụ','100','8000'),
('HH012',N'Bánh cáy Thái Bình','110','30000'),
('HH013',N'Bánh Cu-Đơ','120','40000'),
('HH014',N'Bánh đậu xanh Rồng Vàng','120','60000'),
('HH015',N'Bánh kẹo Hải Hà','140','9200')

go
insert into HOADON values
('HD001','NV001','KH001','1/1/2015'),
('HD002','NV002','KH002','2/2/2015'),
('HD003','NV002','KH002','3/3/2015'),
('HD004','NV003','KH003','4/4/2015'),
('HD005','NV002','KH003','5/5/2015'),
('HD006','NV003','KH004','6/6/2015'),
('HD007','NV004','KH005','7/7/2015'),
('HD008','NV005','KH006','8/8/2015'),
('HD009','NV006','KH007','9/9/2015'),
('HD010','NV009','KH008','10/10/2015')

go
insert into CHITIETHOADON values
('HD001','HH001','2'),('HD001','HH002','2'),('HD001','HH003','3'),
('HD002','HH004','5'),('HD002','HH005','4'),
('HD003','HH005','6'),('HD003','HH006','7'),('HD003','HH009','1'),
('HD004','HH010','2'),('HD004','HH012','4'),('HD004','HH015','2'),
('HD005','HH002','6'),('HD005','HH007','5'),('HD005','HH009','3'),
('HD006','HH010','5'),('HD006','HH011','5'),
('HD007','HH007','4'),('HD007','HH012','2'),
('HD008','HH013','2'),('HD008','HH014','3'),
('HD009','HH011','2'),
('HD010','HH009','1'),('HD010','HH006','3')

insert into DANGNHAP values
('khuonghoang','hoanglaota'),
('tuananh','anhle123'),
('vokhuonglinh','linh123'),
('quangtruong','truong123'),
('anhtuan','tuan123'),
('hongquan','quan123')

alter table KHACHHANG add constraint PK_KH primary key(ID_KhachHang)
alter table NHANVIEN add constraint PK_NV primary key(ID_NhanVien)
alter table HANGHOA add constraint PK_HH primary key(ID_HangHoa)
alter table DANGNHAP add constraint PK_DN primary key (Username)

alter table CHITIETHOADON add constraint PK_CTHD primary key (ID_HoaDon, ID_HangHoa)
alter table CHITIETHOADON add	constraint PK_CTHD_HD foreign key (ID_HoaDon) references HOADON (ID_HoaDon)
alter table CHITIETHOADON add	constraint PK_CTHD_HH foreign key (ID_HangHoa) references HANGHOA (ID_HangHoa)

alter table HOADON add constraint PK_HD primary key (ID_HoaDon)
alter table HOADON add	constraint PK_HD_NV foreign key (ID_NhanVien) references NHANVIEN (ID_NhanVien)
alter table HOADON add	constraint PK_HD_KH foreign key (ID_KhachHang) references KHACHHANG(ID_KhachHang)
