create database QUAN_LY_NHAN_SU
go 
use [QUAN_LY_NHAN_SU]
go
create table NhanVien
(
	ID_NhanVien varchar(10)not null,
	HoTen nvarchar(50)null,
	NgaySinh date null,
	GioiTinh varchar(3)null,
	DiaChi nvarchar(50)null,
	Luong int null,
	ID_DonVi varchar(10)null,
	ID_NQL varchar(10)null
)
go
create table ThanNhan
(
	ID_ThanNhan varchar(10) not null,
	ID_NhanVien varchar(10)not null,
	TenTN nvarchar(50)not null,
	GioiTinh varchar(3)null,
	NgaySinh date null,
	QuanHe nvarchar(3)null
)
go
create table DeAn
(
	ID_DeAn varchar(10)not null,
	TenDA nvarchar(50)null,
	DiaDiem nvarchar(50)null,
	ID_DonVi varchar(10)null,
	ThoiGian decimal(3,1) null,
)
go
create table DonVi
(
	ID_DonVi varchar(10)not null,
	TenDV nvarchar(50)null,
	ID_TP varchar(10)not null
)
go
create table PhanCong
(
	ID_NhanVien varchar(10)not null,
	ID_DeAn varchar(10)not null,
	ThoiGian int null,
)
go
insert into ThanNhan(ID_ThanNhan, ID_NhanVien, TenTN, GioiTinh, NgaySinh, QuanHe)
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
go
insert into NhanVien(ID_NhanVien,HoTen,NgaySinh,GioiTinh,DiaChi,Luong,ID_DonVi,ID_NQL)
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
go
insert into DonVi(ID_DonVi,TenDV,ID_TP)
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
go
insert into DeAn(ID_DeAn,TenDA,DiaDiem,ID_DonVi,ThoiGian)
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
go
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
go
alter table NhanVien add constraint pk_nv_id primary key (ID_NhanVien)
alter table ThanNhan add constraint pk_tn_id primary key (ID_ThanNhan)
alter table DeAn add constraint pk_da_id primary key (ID_DeAn)
alter table DonVi add constraint pk_dv_id primary key(ID_DonVi)
alter table PhanCong add constraint pk_pc_id primary key clustered
(
	ID_NhanVien asc,
	ID_DeAn asc
)
go
alter table NhanVien add constraint fk_dv_nv_id foreign key(ID_DonVi) references  DonVi (ID_DonVi)on delete cascade on update cascade
alter table ThanNhan add constraint fk_nv_tn_id foreign key(ID_NhanVien) references  NhanVien (ID_NhanVien)on delete cascade on update cascade 
alter table DeAn add constraint fk_dv_da_id foreign key(ID_DonVi) references  DonVi (ID_DonVi)on delete cascade on update cascade
alter table PhanCong add constraint fk_fc_nv_id foreign key(ID_NhanVien) references  NhanVien (ID_NhanVien)
alter table PhanCong add constraint fk_fc_da_id foreign key(ID_DeAn) references  DeAn (ID_DeAn)
go
--Xuat bang
create proc OutPutTable
(
	@core int
)	
as
begin
	if @core=1
		select*from NhanVien
	else if @core=2
		select*from ThanNhan
	else if @core=3
		select*from DeAn
	else if @core=4
		select*from DonVi
	else select *from PhanCong
end
go
--Them vao bang
create proc AddObject
(
	@core int,
	@ID1 varchar(10),
	@ID2 varchar(10),
	@ID3 varchar(10),
	@Name nvarchar(50),
	@Place nvarchar(50),
	@DoB date,
	@Gender varchar(3),
	@Relate varchar(3),
	@Salary int,
	@Time int
)
as
begin
	if @core=1
		insert into NhanVien(ID_NhanVien,HoTen,NgaySinh,GioiTinh,DiaChi,Luong,ID_DonVi,ID_NQL)
		values (@ID1,@Name,@DoB,@Gender,@Place,@Salary,@ID2,@ID3)
	else if @core=2
		insert into ThanNhan(ID_ThanNhan,ID_NhanVien,TenTN,GioiTinh,NgaySinh,QuanHe)
		values(@ID1,@ID2,@Name,@Gender,@DoB,@Relate)
	else if @core=3
		insert into DeAn(ID_DeAn,TenDA,DiaDiem,ThoiGian,ID_DonVi)
		values(@ID1,@Name,@Place,@Time,@ID2)
	else if @core=4
		insert into DonVi(ID_DonVi,TenDV,ID_TP)
		values(@ID1,@Name,@ID2)
	else insert into PhanCong(ID_NhanVien,ID_DeAn,ThoiGian)
		values (@ID1,@ID2,@Time)
end
--Xoa trong bang
go
create proc DeleteObject
(
	@core int,
	@ID1 varchar(10),
	@ID2 varchar(10)
)
as
begin
	if @core=1
		delete from NhanVien where ID_NhanVien=@ID1
	else if @core=2
		delete from ThanNhan where ID_ThanNhan=@ID1
	else if @core=3
		delete from DeAn where ID_DeAn =@ID1
	else if @core=4
		delete from DonVi where ID_DonVi =@ID1
	else delete from PhanCong where ID_DeAn=@ID1 and ID_NhanVien=@ID2
end
go
--Cap nhap
create proc EditObject
(
	@core int,
	@ID1 varchar(10),
	@ID2 varchar(10),
	@ID3 varchar(10),
	@Name nvarchar(50),
	@Place nvarchar(50),
	@DoB date,
	@Gender varchar(3),
	@Relate varchar(3),
	@Salary int,
	@Time int
)
as
begin
	if @core=1
		update NhanVien set HoTen=@Name,NgaySinh=@DoB,GioiTinh=@Gender,DiaChi=@Place,Luong=@Salary,ID_DonVi=@ID2,ID_NQL=@ID3
		where ID_NhanVien=@ID1 
	else if @core=2
		update ThanNhan set ID_NhanVien=@ID2,TenTN=@Name,GioiTinh=@Gender,NgaySinh=@DoB,QuanHe=@Relate
		where ID_ThanNhan=@ID1
	else if @core=3
		update DeAn set TenDA=@Name,DiaDiem=@Place,ThoiGian=@Time,ID_DonVi=@ID2
		where ID_DeAn=@ID1
	else if @core=4
		update DonVi set TenDV=@Name,ID_TP=@ID2
		where ID_DonVi=@ID1
	else update PhanCong set ID_DeAn=@ID2,ThoiGian=@Time
		where ID_NhanVien=@ID1
end
go
--TimKiem
create proc FindObject
(
	@core int,
	@Part nvarchar(50)
)
as
begin
	if @core=1
		select distinct *from NhanVien where ID_NhanVien like ('%'+@Part+'%') or HoTen like ('%'+@Part+'%') or GioiTinh like ('%'+@Part+'%') or DiaChi like ('%'+@Part+'%') or Luong like ('%'+@Part+'%') or NgaySinh like ('%'+@Part+'%')
	else if @core=2
		select distinct*from ThanNhan where ID_ThanNhan like ('%'+@Part+'%') or TenTN like ('%'+@Part+'%') or GioiTinh like ('%'+@Part+'%') or QuanHe like ('%'+@Part+'%') or NgaySinh like ('%'+@Part+'%') or ID_NhanVien like ('%'+@Part+'%')
	else if @core=3
		select distinct*from DeAn where ID_DeAn like ('%'+@Part+'%') or ID_DonVi like ('%'+@Part+'%') or TenDA like ('%'+@Part+'%') or DiaDiem like ('%'+@Part+'%')
	else if @core=4
		select distinct*from DonVi where ID_DonVi like ('%'+@Part+'%') or TenDV like ('%'+@Part+'%') 
	else select distinct*from PhanCong where ID_DeAn like ('%'+@Part+'%') or ID_NhanVien like ('%'+@Part+'%')
end
go