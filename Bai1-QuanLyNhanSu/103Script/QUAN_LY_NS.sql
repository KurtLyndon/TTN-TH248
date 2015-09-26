create database QUAN_LY_NHAN_SU

 go 
 create table NhanVien
(
	ID_NhanVien varchar(10)not null,
	HoTen nvarchar(50)null,
	NgaySinh date null,
	GioiTinh varchar(3)null,
	DiaChi nvarchar(50)null,
	Luong int null,
	MaDV varchar(10)null,
	MaNQL varchar(10)null
)
create table ThanNhan
(
	ID_ThanNhan varchar(10) not null,
	ID_NhanVien varchar(10)not null,
	TenTN nvarchar(50)not null,
	GioiTinh varchar(3)null,
	NgaySinh date null,
	QuanHe nvarchar(3)null
)
create table DeAn
(
	ID_DeAn varchar(10)not null,
	TenDA nvarchar(50)null,
	DiaDiem nvarchar(50)null,
	DonVi varchar(10)null,
	ThoiGian decimal(3,1) null,
)
create table DonVi
(
	ID_DonVi varchar(10)not null,
	TenDV nvarchar(50)null,
	MaTP varchar(10)not null
)

create table PhanCong
(
	ID_NhanVien varchar(10)not null,
	ID_DeAn varchar(10)not null,
	ThoiGian decimal(3,1)null,
)

insert into ThanNhan
values 
('TN001','NV001','Than nhan A','Nam','4/3/1950','Cha'),
('TN002','NV002','Than nhan B','Nu','2/6/1945','Me'),
('TN003','NV003','Than nhan c','Nu','1/7/1953','Me'),
('TN004','NV004','Than nhan D','Nam','2/12/1963','Cha'),
('TN005','NV005','Than nhan E','Nam','9/10/1938','Cha'),
('TN006','NV006','Than nhan F','Nu','11/11/1944','Me'),
('TN007','NV007','Than nhan G','Nam','2/9/1949','Cha'),
('TN008','NV008','Than nhan H','Nam','1/2/1956','Cha'),
('TN009','NV009','Than nhan M','Nu','8/2/1950','Cha'),
('TN010','NV010','Than nhan N','Nam','1/7/1951','Me')
 insert into NhanVien(ID_NhanVien,HoTen,NgaySinh,GioiTinh,DiaChi,Luong,MaDV,MaNQL)
values 
('NV001','NGUYEN CHI CONG','2/2/1992','Nam','Dia chi 1',20,'DV001','NV001'),
('NV002','NGUYEN DUC CANH','1/1/1991','Nu','Dia chi 2',14,'DV002','NV002'),
('NV003','LUONG VAN LUAN','10/10/1990','Nu','Dia chi 3',13,'DV003','NV003'),
('NV004','LE TUAN MINH','9/9/1999','Nam','Dia chi 4',11,'DV004','NV004'),
('NV005','HOANG DINH DAT','8/8/1998','Nam','Dia chi 5',7,'DV005','NV005'),
('NV006','LUU VAN LAM','7/7/1997','Nu','Dia chi 6',5,'DV006','NV006'),
('NV007','NGUYEN QUANG TRUONG','6/6/1996','Nam','Dia chi 7',6,'DV007','NV007'),
('NV008','NGO HONG QUAN','5/5/1995','Nu','Dia chi 8',6,'DV008','NV008'),
('NV009','VO KHUONG LINH','4/4/1994','Nam','Dia chi 9',18,'DV009','NV009'),
('NV010','PHI XUAN DAO','3/3/1993','Nu','Dia chi 10',15,'DV010','NV010')

insert into DonVi(ID_DonVi,TenDV,MaTP)
values 
('DV001','Don vi 1','NV001'),
('DV002','Don vi 2','NV002'),
('DV003','Don vi 3','NV003'),
('DV004','Don vi 4','NV004'),
('DV005','Don vi 5','NV005'),
('DV006','Don vi 6','NV006'),
('DV007','Don vi 7','NV007'),
('DV008','Don vi 8','NV008'),
('DV009','Don vi 9','NV009'),
('DV010','Don vi 10','NV010')
insert into DeAn(ID_DeAn,TenDA,DiaDiem,DonVi,ThoiGian)
values
('DA001','De an 1','Dia diem A','DV001',25),
('DA002','De an 2','Dia diem B','DV002',35),
('DA003','De an 3','Dia diem C','DV003',75),
('DA004','De an 4','Dia diem D','DV004',60),
('DA005','De an 5','Dia diem E','DV005',40),
('DA006','De an 6','Dia diem F','DV006',20),
('DA007','De an 7','Dia diem G','DV007',26),
('DA008','De an 8','Dia diem M','DV008',30),
('DA009','De an 9','Dia diem N','DV009',70),
('DA010','De an 10','Dia diem H','DV009',49)

insert into PhanCong(ID_NhanVien,ID_DeAn,ThoiGian)
values 
('NV001','DA001',25),
('NV002','DA002',35),
('NV003','DA003',75),
('NV004','DA004',60),
('NV005','DA005',40),
('NV006','DA006',20),
('NV007','DA007',26),
('NV008','DA008',30),
('NV009','DA009',70),
('NV010','DA010',49)

alter table ThanNhan add constraint fk_TN primary key (ID_ThanNhan),
 constraint fk_TN_NV foreign key (ID_NhanVien) references NhanVien(ID_NhanVien)


alter table DonVi add constraint fk_DV primary key(ID_DonVi)
alter table DonVi add constraint fk_DV_NV foreign key (MaTp) references NhanVien(ID_NhanVien)

alter table NhanVien add constraint fk_NV primary key (ID_NhanVien),
alter table NhanVien add constraint fk_NV_DV foreign key (MaDV) references DonVi(ID_DonVi),
	constraint fk_NV_QL foreign key (MaNQL) references NhanVien(ID_NhanVien)
alter table DeAn add constraint fk_DA primary key (ID_DeAn),
constraint fk_DA_DV foreign key (DonVi) references DonVi(ID_DonVi)

alter table PhanCong add constraint fk_PC primary key (ID_NhanVien, ID_DeAn),
	constraint fk_PC_NV foreign key (ID_NhanVien) references NhanVien(ID_NhanVien),
	constraint fk_PC_DA foreign key(ID_DeAn) references DeAn (ID_DeAn)
	