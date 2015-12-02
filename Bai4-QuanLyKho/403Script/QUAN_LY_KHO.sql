create database QUAN_LY_KHO
go
use  QUAN_LY_KHO
go 
create table HANGHOA
( 
	ID_HangHoa varchar(10) not null , 
	TenHangHoa nvarchar(50), 
	Gia bigint, 
	ID_NhaCC varchar(10) not null
)
go
create table NHACUNGCAP
( 
	ID_NhaCC varchar(10) not null, 
	TenNhaCC nvarchar(50), 
	SDT bigint, 
	Email varchar(50), 
	DiaChi nvarchar(50)
)
go 
create table PHIEU 
( 
	ID_Phieu varchar(10) not null, 
	Ngay date, 
	LoaiPhieu varchar(1) check (LoaiPhieu in ('N','X')) 
)
create table DANGNHAP
(	
	Username varchar(50) not null,
	Pass varchar(50)
)
go
create table CHITIETPHIEU
( 
	ID_Phieu varchar(10) not null, 
	ID_HangHoa varchar(10) not null, 
	GhiChu nvarchar(50)
)
go
insert into HANGHOA (ID_HangHoa, TenHangHoa,Gia,ID_NhaCC) values
 ('HH001',N'Nước Giải Khát','15000','NCC001'),
 ('HH002',N'Xúc xích','6000','NCC001'),
 ('HH003',N'Bánh mì ruốc','4500','NCC002'),
 ('HH004',N'Mì tôm omachi','6000','NCC003'),
 ('HH005',N'Bánh trứng','30000','NCC003'),
 ('HH006',N'Bánh đậu xanh','34000','NCC002'),
 ('HH007',N'Bánh quy','18000','NCC002'),
 ('HH008',N'Bánh trung thu loại 1','50000','NCC001'),
 ('HH009',N'Bánh trung thu loại 2','45000','NCC004'),
 ('HH010',N'Bánh Gạo','18000','NCC001'),
 ('HH011',N'Mì tôm hảo hảo','3000','NCC004'),
 ('HH012',N'Phồng tôm','4500','NCC005'),
 ('HH013',N'Bánh bông lan','24000','NCC005'),
 ('HH014',N'Nước cam ép','9000','NCC003'),
 ('HH015',N'Bánh mì sài gòn','5500','NCC002'),
 ('HH016',N'Bánh đa nem','3400','NCC001'),
 ('HH017',N'Bánh Gai','2500','NCC005'),
 ('HH018',N'Bia Hà Nội','10000','NCC004'),
 ('HH019',N'Trà bí đao','100','NCC002'),
 ('HH020',N'Trà xanh 0 độ','11000','NCC004')
go 
insert into NHACUNGCAP values
('NCC001',N'Công ty Habeco','043718293',N'habeco@gmail.com',N'Thanh Xuân, Hà Nội'),
('NCC002',N'Công ty TNHH abc','04829182',N'tnhhabc@gmail.com',N'Đống Đa, Hà Nội'),
('NCC003',N'Nhà máy X10','0927261622',N'x10@gmail.com',N'Thường Tín, Hà Nội'),
('NCC004',N'Xí nghiệp 20',N'03821232',N'xn20@yahoo.com',N'Cấu Diễn, Hà Nội'),
('NCC005',N'Công ty cổ phần SHB','08271623',N'shbbank@yahoo.com',N'Tây Hồ, Hà Nội')
go 
insert into PHIEU values 
('Ph001','1/1/2015','N'),
('Ph002','2/2/2015','X'),
('Ph003','4/7/2015','N'),
('Ph004','10/9/2015','X'),
('Ph005','6/8/2014','N'),
('Ph006','2/4/2013','X'),
('Ph007','7/10/2015','N')
go
insert into CHITIETPHIEU values
('Ph001','HH001',N''),
('Ph001','HH002',N''),
('Ph001','HH003',N''),
('Ph001','HH005',N''),
('Ph002','HH001',N''),
('Ph002','HH004',N''),
('Ph002','HH009',N''),
('Ph002','HH010',N''),
('Ph003','HH011',N''),
('Ph003','HH012',N''),
('Ph003','HH015',N''),
('Ph004','HH019',N''),
('Ph004','HH008',N''),
('Ph004','HH009',N''),
('Ph005','HH012',N''),
('Ph005','HH018',N''),
('Ph005','HH020',N''),
('Ph006','HH016',N''),
('Ph006','HH004',N''),
('Ph006','HH001',N''),
('Ph007','HH013',N''),
('Ph007','HH014',N'')
insert into DANGNHAP values
('khuonghoang','hoanglaota'),
('tuananh','anhle123'),
('vokhuonglinh','linh123'),
('quangtruong','truong123'),
('anhtuan','tuan123'),
('hongquan','quan123')
alter table NHACUNGCAP add constraint PK_NCC primary key (ID_NhaCC)
alter table PHIEU add constraint PK_PHIEU primary key (ID_Phieu)
alter table HANGHOA add constraint PK_HH primary key(ID_HangHoa)
alter table HANGHOA add constraint PK_HH_NCC foreign key (ID_NhaCC) references NHACUNGCAP(ID_NhaCC)
alter table DANGNHAP add constraint PK_DN primary key (Username)
alter table CHITIETPHIEU add constraint PK_CCP primary key (ID_Phieu, ID_HangHoa),
constraint PK_CTP_Ph foreign key (ID_Phieu) references PHIEU(ID_Phieu),
constraint PK_CTP_HH foreign key (ID_HangHoa) references HANGHOA(ID_HangHoa)
go
Create proc INSERTHANGHOA
(
	@ID CHAR(10),
	@NAME NVARCHAR(50),
	@GIA BIGINT,
	@IDNSX NVARCHAR(50),
	@CHECK INT OUTPUT
)
AS
BEGIN
	IF(@ID IN (SELECT HANGHOA.ID_HangHoa FROM HANGHOA)) 
	BEGIN 
		SET @CHECK=1 
		RETURN 
	END
	IF(@IDNSX NOT IN (SELECT NHACUNGCAP.ID_NhaCC FROM NHACUNGCAP))
	BEGIN 
		SET @CHECK=2 
		RETURN 
	END
    SET @CHECK=0
	INSERT INTO HANGHOA VALUES(@ID,@NAME,@GIA,@IDNSX) 
END
GO
CREATE PROC DELETEHANGHOA
(
	@ID CHAR(10)
)
AS
BEGIN
	DELETE HANGHOA WHERE @ID=HANGHOA.ID_HangHoa 
END
GO
CREATE PROC DELETENHACUNGCAP 
(
	@ID CHAR(10)
)
AS
BEGIN
	DELETE NHACUNGCAP WHERE @ID=NHACUNGCAP.ID_NhaCC 
END
GO
CREATE PROC DELETEPHIEUNHAP 
(
	@ID CHAR(10)
)
AS
BEGIN 
	DELETE PHIEU WHERE @ID=PHIEU.ID_Phieu
	DELETE CHITIETPHIEU WHERE @ID=CHITIETPHIEU.ID_Phieu
END
GO
CREATE PROC DELETECHITIETPHIEU 
(
	@ID CHAR(10)
)
AS
BEGIN 
	DELETE CHITIETPHIEU WHERE @ID=CHITIETPHIEU.ID_Phieu
END
GO
CREATE PROC INSERTNHACUNGCAP
(
	@ID CHAR(10),
	@NAME NVARCHAR(50),
	@SDT VARCHAR(20),
	@EMAIL NVARCHAR(50),
	@ADDRESS NVARCHAR(50),
	@CHECK INT OUTPUT
)
AS
BEGIN
	IF(@ID IN (SELECT ID_NhaCC FROM NHACUNGCAP))
	BEGIN 
		SET @CHECK=1 
		RETURN 
	END
	SET @CHECK=0
	INSERT INTO NHACUNGCAP VALUES(@ID,@NAME,@SDT,@EMAIL,@ADDRESS)
END
GO
CREATE PROC INSERTCHITIETPHIEU 
(
	@ID CHAR(10),
	@IDHH CHAR(10),
	@GC NVARCHAR(50),
	@CHECK INT OUTPUT
)
AS
BEGIN
    IF(@ID NOT IN (SELECT ID_Phieu FROM CHITIETPHIEU))
	BEGIN 
		SET @CHECK=1 
		RETURN 
	END
	IF(@IDHH NOT IN (SELECT ID_HangHoa FROM HANGHOA))
	BEGIN 
		SET @CHECK=2 
		RETURN 
	END
	SET @CHECK=0
	INSERT INTO CHITIETPHIEU VALUES(@ID,@IDHH,@GC)
END
GO
CREATE PROC INSERTPHIEUNHAP
(
	@ID CHAR(10),
	@DATE DATETIME,
	@TYPE VARCHAR(50),
	@CHECK INT OUTPUT
)
AS
BEGIN
	IF(@ID IN (SELECT ID_Phieu FROM PHIEU))
	BEGIN 
		SET @CHECK=1 
		RETURN 
	END
	SET @CHECK=0
	INSERT INTO PHIEU VALUES (@ID,@DATE,@TYPE)
END
GO
CREATE PROC UPDATEPHIEU
(
	@ID CHAR(10),
	@DATE DATETIME,
	@TYPE VARCHAR(50),
	@CHECK INT OUTPUT
)
AS
BEGIN 
	SET @CHECK=0
	UPDATE PHIEU SET Ngay=@DATE,LoaiPhieu=@TYPE WHERE ID_Phieu=@ID
END
GO
CREATE PROC UPDATENHACUNGCAP
(
	@ID CHAR(10),
	@NAME NVARCHAR(50),
	@SDT VARCHAR(20),
	@EMAIL NVARCHAR(50),
	@ADDRESS NVARCHAR(50),
	@CHECK INT OUTPUT
)
AS
BEGIN 
	SET @CHECK=0
	UPDATE NHACUNGCAP SET TenNhaCC=@NAME,SDT=@SDT,Email=@EMAIL,DiaChi=@ADDRESS WHERE ID_NhaCC=@ID
END
GO
Create proc UPDATEHANGHOA
(
	@ID CHAR(10),
	@NAME NVARCHAR(50),
	@GIA BIGINT,
	@IDNSX NVARCHAR(50),
	@CHECK INT OUTPUT
)
AS
BEGIN
	IF(@IDNSX NOT IN (SELECT NHACUNGCAP.ID_NhaCC FROM NHACUNGCAP))
	BEGIN 
		SET @CHECK=2 
		RETURN 
	END
	SET @CHECK=0 UPDATE HANGHOA SET TenHangHoa=@NAME,Gia=@GIA,ID_NhaCC=@IDNSX WHERE ID_HangHoa=@ID
END
GO
CREATE PROC UPDATECHITIETPHIEU 
(
	@ID CHAR(10),
	@IDHH CHAR(10),
	@GC NVARCHAR(50),
	@CHECK INT OUTPUT
)
AS
BEGIN
    IF(@ID NOT IN (SELECT ID_Phieu FROM CHITIETPHIEU))
	BEGIN 
		SET @CHECK=1 
		RETURN 
	END
	IF(@IDHH NOT IN (SELECT ID_HangHoa FROM HANGHOA))
	BEGIN 
		SET @CHECK=2 
		RETURN 
	END
	SET @CHECK=0
	UPDATE CHITIETPHIEU SET ID_HangHoa=@IDHH,ID_Phieu=@ID,GhiChu=@GC WHERE ID_HangHoa=@IDHH AND ID_Phieu=@ID
END
GO