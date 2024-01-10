create database Do_an_QLSV;
go

use Do_an_QLSV;
go

CREATE TABLE DangNhap
(
  Email NVARCHAR(100) NOT NULL,
  Taikhoan NVARCHAR(50) NOT NULL PRIMARY KEY,
  Matkhau NVARCHAR(100) NOT NULL,
  Vaitro NVARCHAR(10) NOT NULL 
)
GO

CREATE TABLE Khoa
(
    Makhoa NVARCHAR(50) NOT NULL PRIMARY KEY,
    Tenkhoa NVARCHAR(50),
	Chunhiem NVARCHAR(50),
	SDT NVARCHAR(20),
	Email NVARCHAR(100)
)
GO

CREATE TABLE LopHoc
(
    Malop NVARCHAR(50) NOT NULL,
	Tenlop NVARCHAR(50) NOT NULL,
	Hedaotao NVARCHAR(50),
	Makhoa NVARCHAR(50),

	PRIMARY KEY (Malop, Tenlop),
	FOREIGN KEY (Makhoa) REFERENCES Khoa (Makhoa)
)
GO

CREATE TABLE MonHoc
(
    Mamh NVARCHAR(50) NOT NULL PRIMARY KEY,
    Tenmh NVARCHAR(50),
	Sotin INT,
    Sotiet INT
)
GO

CREATE TABLE ThongTinSinhVien
(
    Msv NVARCHAR(50) NOT NULL PRIMARY KEY,
    Hosv NVARCHAR(100),
    Ten NVARCHAR(50),
    Ns DATE,
    Phai NVARCHAR(3),
	Diachi NVARCHAR(100),
	Email NVARCHAR(100),
    Malop NVARCHAR(50) NOT NULL,
	Tenlop NVARCHAR(50) NOT NULL,
	Anh NVARCHAR(100),

	FOREIGN KEY (Malop, Tenlop) REFERENCES LopHoc (Malop, Tenlop)
)
GO

CREATE TABLE KetQua
(
    Maketqua NVARCHAR(100) PRIMARY KEY, 
    Msv NVARCHAR(50) NOT NULL,
    Mamh NVARCHAR(50) NOT NULL,
	Tenlop NVARCHAR(50) not null,
    Diemthuongky DECIMAL(4, 2) NOT NULL,
    Diemgiuaky DECIMAL(4, 2) NOT NULL,
	Diemcuoiky DECIMAL(4, 2) NOT NULL,
	Diemtongket DECIMAL(4, 2)  NOT NULL,
	XepLoai NVARCHAR(20),

	FOREIGN KEY (Msv) REFERENCES ThongTinSinhVien (Msv),
    FOREIGN KEY (Mamh) REFERENCES MonHoc (Mamh),
)
GO

CREATE TRIGGER InsertDiemTongKet
ON KetQua
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO KetQua (Maketqua,Msv, Mamh, Tenlop, Diemthuongky, Diemgiuaky, Diemcuoiky, Diemtongket, XepLoai)
    SELECT 
	    ins.Maketqua,
        ins.Msv, 
        ins.Mamh, 
        ins.Tenlop, 
        ins.Diemthuongky, 
        ins.Diemgiuaky, 
        ins.Diemcuoiky, 
        ROUND((ins.Diemthuongky + ins.Diemgiuaky + ins.Diemcuoiky) / 3, 2),
        CASE
            WHEN ROUND((ins.Diemthuongky + ins.Diemgiuaky + ins.Diemcuoiky) / 3, 2) >= 9.0 THEN N'Xuất sắc'
            WHEN ROUND((ins.Diemthuongky + ins.Diemgiuaky + ins.Diemcuoiky) / 3, 2) >= 8.0 THEN N'Giỏi'
            WHEN ROUND((ins.Diemthuongky + ins.Diemgiuaky + ins.Diemcuoiky) / 3, 2) >= 7.0 THEN N'Khá'
            WHEN ROUND((ins.Diemthuongky + ins.Diemgiuaky + ins.Diemcuoiky) / 3, 2) >= 5.0 THEN N'Trung bình'
            ELSE N'Yếu kém'
        END
    FROM inserted ins;
END;
GO

CREATE TRIGGER UpdateDiemTongKet
ON KetQua
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE KetQua
    SET Diemtongket = ROUND((ins.Diemthuongky + ins.Diemgiuaky + ins.Diemcuoiky) / 3, 2),
        XepLoai = CASE
            WHEN ROUND((ins.Diemthuongky + ins.Diemgiuaky + ins.Diemcuoiky) / 3, 2) >= 9.0 THEN N'Xuất sắc'
            WHEN ROUND((ins.Diemthuongky + ins.Diemgiuaky + ins.Diemcuoiky) / 3, 2) >= 8.0 THEN N'Giỏi'
            WHEN ROUND((ins.Diemthuongky + ins.Diemgiuaky + ins.Diemcuoiky) / 3, 2) >= 7.0 THEN N'Khá'
            WHEN ROUND((ins.Diemthuongky + ins.Diemgiuaky + ins.Diemcuoiky) / 3, 2) >= 5.0 THEN N'Trung bình'
            ELSE N'Yếu kém'
        END
    FROM inserted ins
    WHERE KetQua.Maketqua = ins.Maketqua;
END;
GO

--( Insert )
-- Thêm thông tin vào bảng 

-- Bảng đăng nhập
insert into Dangnhap(Email,Taikhoan,Matkhau,Vaitro)
values
('nguyenvytruong@gmail.com','admin','123456','ADMIN'),
('truong04@gmail.com','truong','123456','ADMIN'),
('test01@gmail.com','test','123456','USER'),
('truongvyn04@gmail.com','27000001','123456','MEMBER')

-- Bảng khoa
insert into Khoa(Makhoa,Tenkhoa,Chunhiem,SDT,Email)
values
('CNTT',N'Công Nghệ Thông Tin',N'Đào Văn Mạnh','0912345678','manhdao@gmailcom'),
('CDT',N'Cơ Điện Tử',N'Trần Văn Long','0945343546','longvantran@gmail.com'),
('NNT',N'Ngôn Ngữ Trung',N'Nguyễn Thị Lan','0974534567','lannguyenthi@gmail.com'),
('LF',N'Luật',N'Hoàng Văn Hà','0912342354','hahoang@gmail.com'),
('QTKD',N'Quản Trị Kinh Doanh',N'Trương Thị Kiểu Oanh','0965768776','kieuoanhthi@gmail.com')

-- Bảng Lớp học 
insert into LopHoc(Malop,Tenlop,Hedaotao,Makhoa)
values
('TH1','TH27.01',N'Đại học','CNTT'),
('TH1','TH27.02',N'Đại học','CNTT'),
('TH1','TH27.03',N'Đại học','CNTT'),
('TH1','TH27.04',N'Đại học','CNTT'),
('TH1','TH27.05',N'Đại học','CNTT'),

('TH2','TH27.01',N'Cao đẳng','CNTT'),
('TH2','TH27.02',N'Cao đẳng','CNTT'),
('TH2','TH27.03',N'Cao đẳng','CNTT'),
('TH2','TH27.04',N'Cao đẳng','CNTT'),
('TH2','TH27.05',N'Cao đẳng','CNTT'),

('CD1','DT27.01',N'Đại học','CDT'),
('CD1','DT27.02',N'Đại học','CDT'),
('CD1','DT27.03',N'Đại học','CDT'),
('CD1','DT27.04',N'Đại học','CDT'),
('CD1','DT27.05',N'Đại học','CDT'),

('CD2','DT27.01',N'Cao đẳng','CDT'),
('CD2','DT27.02',N'Cao đẳng','CDT'),
('CD2','DT27.03',N'Cao đẳng','CDT'),
('CD2','DT27.04',N'Cao đẳng','CDT'),
('CD2','DT27.05',N'Cao đẳng','CDT'),

('TR1','TR27.01',N'Đại học','NNT'),
('TR1','TR27.02',N'Đại học','NNT'),
('TR1','TR27.03',N'Đại học','NNT'),
('TR1','TR27.04',N'Đại học','NNT'),
('TR1','TR27.05',N'Đại học','NNT'),

('TR2','TR27.01',N'Cao đẳng','NNT'),
('TR2','TR27.02',N'Cao đẳng','NNT'),
('TR2','TR27.03',N'Cao đẳng','NNT'),
('TR2','TR27.04',N'Cao đẳng','NNT'),
('TR2','TR27.05',N'Cao đẳng','NNT'),

('L1','LP27.01',N'Đại học','LF'),
('L1','LP27.02',N'Đại học','LF'),
('L1','LP27.03',N'Đại học','LF'),
('L1','LP27.04',N'Đại học','LF'),
('L1','LP27.05',N'Đại học','LF'),

('L2','LP27.01',N'Cao đẳng','LF'),
('L2','LP27.02',N'Cao đẳng','LF'),
('L2','LP27.03',N'Cao đẳng','LF'),
('L2','LP27.04',N'Cao đẳng','LF'),
('L2','LP27.05',N'Cao đẳng','LF'),


('KD1','QT27.01',N'Đại học','QTKD'),
('KD1','QT27.02',N'Đại học','QTKD'),
('KD1','QT27.03',N'Đại học','QTKD'),
('KD1','QT27.04',N'Đại học','QTKD'),
('KD1','QT27.05',N'Đại học','QTKD'),

('KD2','QT27.01',N'Cao đẳng','QTKD'),
('KD2','QT27.02',N'Cao đẳng','QTKD'),
('KD2','QT27.03',N'Cao đẳng','QTKD'),
('KD2','QT27.04',N'Cao đẳng','QTKD'),
('KD2','QT27.05',N'Cao đẳng','QTKD')

-- Bảng môn học
insert into MonHoc(Mamh,Tenmh,Sotin,Sotiet)
values
('TCN',N'Tin Chuyên Ngành',2,30),
('XSTK',N'Xác Suất Thống Kê',3,60),
('HT',N'Hán Tự',3,60),
('LHP',N'Luật Hiến Pháp',3,60),
('KTVM',N'Kinh Tế Vĩ Mô',3,60)

-- Bảng thông tin sinh viên
insert into ThongTinSinhVien(Msv,Hosv,Ten,Ns,Phai,Diachi,Email,Malop,Tenlop,Anh)
values
('27000001',N'Nguyễn Vỹ',N'Trường','09/06/2004',N'Nam',N'Hà Nội','truongvyn04@gmail.com','TH1', 'TH27.01','Anh\nguyenvytruong.jpg'),
('27000002',N'Trương Tam',N'Phong','02/02/2004',N'Nam',N'Hà Nam','phongdz04@gmail.com','CD1','DT27.01','Anh\truongtamphong.jpg'),
('27000003',N'Trần Duy',N'Lương','03/03/2004',N'Nam',N'Hà Tĩnh','luongtranduy@gmail.com','TR1','TR27.01','Anh\tranduyluong.jpg'),
('27000004',N'Vũ Văn',N'Việt','04/04/2004',N'Nam',N'Huế','viet3k@gmail.com','L1','LP27.01','Anh\vuvanviet.jpg'),
('27000005',N'Lê Văn',N'Nam','05/05/2004',N'Nam',N'Hưng Yên','namvan22@gmail.com','KD1','QT27.01','Anh\levannam.jpg'),
('27000006',N'Phạm Thị Lan',N'Ngọc','06/04/2004',N'Nữ',N'Nghệ An','phamthingoc@gmail.com','TH1','TH27.02','Anh\phamthilanngoc.jpg'),
('27000007',N'Nguyễn Thị Lan',N'Anh','06/03/2004',N'Nữ',N'Thanh Hóa','lananhthi@gmail.com','CD1','DT27.02','Anh\nguyenthilananh.jpg'),
('27000008',N'Trương Mỹ',N'Lệ','07/02/2004',N'Nữ',N'Đà Nẵng','truongle04@gmail.com','TR1','TR27.02','Anh\truongmyle.jpg'),
('27000009',N'Đặng Thị Lưu',N'Ly','06/09/2004',N'Nữ',N'Hải Dương','luulymaiyeu@gmail.com','L1','LP27.02','Anh\dangthiluuly.jpg'),
('27000010',N'Lưu Lung',N'Linh','05/04/2004',N'Nữ',N'Bắc Giang','lungthilinh@gmail.com','KD1','QT27.02','Anh\luulunglinh.jpg'),
('27000011',N'Nguyễn Van',N'Trường','09/06/2004',N'Nam',N'Hà Nội','truongvan04@gmail.com','TH1','TH27.03','Anh\nguyenvantruong.jpg'),
('27000012',N'Trần Anh',N'Tú','10/07/2004',N'Nam',N'Hà Nội','tuanhtu04@gmail.com','CD1','DT27.03','Anh\tranahntu.jpg'),
('27000013',N'Phạm Thị',N'Hoa','11/08/2004',N'Nữ',N'Hà Nội','phamthihoa04@gmail.com','TR1','TR27.03','Anh\phamthihoa.jpg'),
('27000014',N'Lê Văn',N'Hùng','12/09/2004',N'Nam',N'Hà Nội','levanhung04@gmail.com','L1','LP27.03','Anh\levanhung.jpg'),
('27000015',N'Nguyễn Thị',N'Hương','10/10/2004',N'Nữ',N'Hà Nội','nguyenthihuong04@gmail.com','KD1','QT27.03','Anh\nguyenthihuong.jpg'),
('27000016',N'Hoàng Văn',N'Thái','09/11/2004',N'Nam',N'Hà Nội','hoangvanthai04@gmail.com','TH1','TH27.04','Anh\hoangvanthai.jpg'),
('27000017',N'Trần Thị',N'Liên','12/12/2004',N'Nữ',N'Hà Nội','tranlien04@gmail.com','CD1','DT27.04','Anh\tranlien.jpg'),
('27000018',N'Phạm Văn',N'Thành','12/01/2004',N'Nam',N'Hà Nội','phamvanthanh05@gmail.com','TR1','TR27.04','Anh\phamvanthanh.jpg'),
('27000019',N'Nguyễn Thị',N'Nhung','12/02/2004',N'Nữ',N'Hà Nội','nguyennhung05@gmail.com','L1','LP27.04','Anh\nguyennhung.jpg'),
('27000020',N'Lê Văn',N'Tùng','12/03/2004',N'Nam',N'Hà Nội','levantung05@gmail.com','KD1','QT27.04','Anh\levantung.jpg'),
('27000021',N'Trần Thị',N'Yến','12/04/2004',N'Nữ',N'Hà Nội','tranyen05@gmail.com','TH1','TH27.05','Anh\tranyen.jpg'),
('27000022',N'Phạm Văn',N'Đức','11/05/2004',N'Nam',N'Hà Nội','phamvanduc05@gmail.com','CD1','DT27.05','Anh\phamvanduc.jpg'),
('27000023',N'Nguyễn Thị',N'Thảo','04/06/2004',N'Nữ',N'Hà Nội','nguyenthithao05@gmail.com','TR1','TR27.05','Anh\nguyenthithao.jpg'),
('27000024',N'Lê Văn',N'Phúc','01/07/2004',N'Nam',N'Hà Nội','levanphuc05@gmail.com','L1','LP27.05','Anh\levanphuc.jpg'),
('27000025',N'Trần Thị',N'Phương','06/08/2004',N'Nữ',N'Hà Nội','tranphuong05@gmail.com','KD1','QT27.05','Anh\tranphuong.jpg'),
('27000026',N'Phạm Văn',N'Quang','09/09/2004',N'Nam',N'Hà Nội','phamvanquang05@gmail.com','TH1','TH27.01','Anh\phamvanquang.jpg'),
('27000027',N'Nguyễn Thị',N'Quỳnh','08/10/2004',N'Nữ',N'Hà Nội','nguyenquynh05@gmail.com','CD1','DT27.01','Anh\nguyenquynh.jpg'),
('27000028',N'Lê Văn',N'Toàn','11/11/2004',N'Nam',N'Hà Nội','levantoan05@gmail.com','TR1','TR27.01','Anh\levantoan.jpg'),
('27000029',N'Trần Thị',N'Thúy','12/12/2004',N'Nữ',N'Hà Nội','tranthuy05@gmail.com','L1','LP27.01','Anh\tranthuy.jpg'),
('27000030',N'Phạm Văn',N'Trường','06/01/2004',N'Nam',N'Hà Nội','phamvantruong06@gmail.com','KD1','QT27.01','Anh\phamvantruong.jpg')
select *from ThongTinSinhVien


-- Bảng kết quả
INSERT INTO KetQua (Maketqua,Msv, Mamh, Tenlop, Diemthuongky, Diemgiuaky, Diemcuoiky)
VALUES
(1,'27000001', 'TCN', 'TH27.01', 10, 10, 10),
(2,'27000002', 'XSTK', 'DT27.01', 9, 9, 9),
(3,'27000003', 'HT', 'TR27.01', 8, 8, 8),
(4,'27000004', 'LHP', 'LP27.01', 6, 6, 6),
(5,'27000005', 'KTVM', 'QT27.01', 5, 5, 5),
(6,'27000006', 'TCN', 'TH27.02', 9, 9, 9),
(7,'27000007', 'XSTK', 'DT27.02', 10, 10, 10),
(8,'27000008', 'HT', 'TR27.02', 6, 6, 6),
(9,'27000009', 'LHP', 'LP27.02', 8, 8, 8),
(10,'27000010', 'KTVM', 'QT27.02', 7, 7, 7),
(11,'27000011', 'TCN', 'TH27.03', 10, 10, 10),
(12,'27000012', 'XSTK', 'DT27.03', 9, 9, 9),
(13,'27000013', 'HT', 'TR27.03', 8, 8, 8),
(14,'27000014', 'LHP', 'LP27.03', 6, 6, 6),
(15,'27000015', 'KTVM', 'QT27.03', 5, 5, 5),
(16,'27000016', 'TCN', 'TH27.04', 9, 9, 9),
(17,'27000017', 'XSTK', 'DT27.04', 10, 10, 10),
(18,'27000018', 'HT', 'TR27.04', 6, 6, 6),
(19,'27000019', 'LHP', 'LP27.04', 8, 8, 8),
(20,'27000020', 'KTVM', 'QT27.04', 7, 7, 7),
(21,'27000021', 'TCN', 'TH27.05', 10, 10, 10),
(22,'27000022', 'XSTK', 'DT27.05', 9, 9, 9),
(23,'27000023', 'HT', 'TR27.05', 8, 8, 8),
(24,'27000024', 'LHP', 'LP27.05', 6, 6, 6),
(25,'27000025', 'KTVM', 'QT27.05', 5, 5, 5),
(26,'27000026', 'TCN', 'TH27.01', 9, 9, 9),
(27,'27000027', 'XSTK', 'DT27.01', 10, 10, 10),
(28,'27000028', 'HT', 'TR27.01', 6, 6, 6),
(29,'27000029', 'LHP', 'LP27.01', 8, 8, 8),
(30,'27000030', 'KTVM', 'QT27.01', 7, 7, 7),
(31,'27000001', 'HT', 'TH27.01', 10, 10, 10)
select *from KetQua
