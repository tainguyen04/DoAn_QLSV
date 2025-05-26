Use QLSV;
DELETE FROM DiemRenLuyen;
DELETE FROM DiemHocTap;
DELETE FROM TaiKhoan;
DELETE FROM ThongTinSinhVien;
DELETE FROM HocKy;
DELETE FROM MonHoc;
DELETE FROM Lop;
DELETE FROM Khoa;



INSERT INTO Khoa (maKhoa, tenKhoa) 
VALUES 
('CNTT', N'Công nghệ thông tin');

INSERT INTO Lop (maLop, tenLop, maKhoa) 
VALUES 
('L01', N'Lớp DH23PM', 'CNTT');

INSERT INTO ThongTinSinhVien (MSSV, hoTen, gioiTinh, soDienThoai, diaChi, ngaySinh, hinhAnh, lopID, KhoamaKhoa)
VALUES
('DPM225425', N'Nguyễn Văn An', N'Nam', '0909123451', N'123 Đường Lê Lợi, Hà Nội', '2001-01-15', 'no-image.jpg', 'L01', 'CNTT'),
('DPM225426', N'Trần Thị Bình', N'Nữ', '0909123452', N'45 Phố Huế, Hà Nội', '2001-03-22', 'no-image.jpg', 'L01', 'CNTT'),
('DPM225427', N'Lê Minh Cường', N'Nam', '0909123453', N'789 Nguyễn Trãi, Hà Nội', '2000-12-05', 'no-image.jpg', 'L01', 'CNTT'),
('DPM225428', N'Phạm Thị Duyên', N'Nữ', '0909123454', N'56 Trần Hưng Đạo, Hà Nội', '2001-07-09', 'no-image.jpg', 'L01', 'CNTT'),
('DPM225429', N'Võ Quang Hải', N'Nam', '0909123455', N'321 Bạch Mai, Hà Nội', '2000-11-11', 'no-image.jpg', 'L01', 'CNTT'),
('DPM225430', N'Ngô Thị Hoa', N'Nữ', '0909123456', N'67 Hoàng Hoa Thám, Hà Nội', '2001-02-18', 'no-image.jpg', 'L01', 'CNTT'),
('DPM225431', N'Đỗ Văn Khang', N'Nam', '0909123457', N'89 Láng Hạ, Hà Nội', '2000-08-25', 'no-image.jpg', 'L01', 'CNTT'),
('DPM225432', N'Bùi Thị Lan', N'Nữ', '0909123458', N'23 Tây Sơn, Hà Nội', '2001-04-03', 'no-image.jpg', 'L01', 'CNTT'),
('DPM225433', N'Hồ Văn Minh', N'Nam', '0909123459', N'101 Xã Đàn, Hà Nội', '2000-10-19', 'no-image.jpg', 'L01', 'CNTT'),
('DPM225434', N'Nguyễn Thị Nga', N'Nữ', '0909123460', N'55 Trúc Bạch, Hà Nội', '2001-06-30', 'no-image.jpg', 'L01', 'CNTT'),
('DPM225435', N'Phan Văn Quý', N'Nam', '0909123461', N'78 Kim Mã, Hà Nội', '2000-09-14', 'no-image.jpg', 'L01', 'CNTT');

INSERT INTO TaiKhoan (tenDangNhap, matKhau, phanQuyen, MSSV)
VALUES
('DPM225425', '123456', N'SinhVien', 'DPM225425'),
('DPM225426', '123456', N'SinhVien', 'DPM225426'),
('DPM225427', '123456', N'SinhVien', 'DPM225427'),
('DPM225428', '123456', N'SinhVien', 'DPM225428'),
('DPM225429', '123456', N'SinhVien', 'DPM225429'),
('DPM225430', '123456', N'SinhVien', 'DPM225430'),
('DPM225431', '123456', N'SinhVien', 'DPM225431'),
('DPM225432', '123456', N'SinhVien', 'DPM225432'),
('DPM225433', '123456', N'SinhVien', 'DPM225433'),
('DPM225434', '123456', N'SinhVien', 'DPM225434'),
('DPM225435', '123456', N'SinhVien', 'DPM225435');

INSERT INTO MonHoc (maMonHoc, tenMonHoc, soTinChi)
VALUES
('MH01', N'Toán Cao Cấp', 3),
('MH02', N'Lập Trình Cơ Bản', 4),
('MH03', N'Cơ Sở Dữ Liệu', 3),
('MH04', N'Mạng Máy Tính', 3),
('MH05', N'Kỹ Thuật Lập Trình', 4);

INSERT INTO HocKy (maHocKy, tenHocKy, namHoc)
VALUES
('HK01', N'Học kỳ 1', N'2024-2025'),
('HK02', N'Học kỳ 2', N'2024-2025');

INSERT INTO DiemHocTap (MSSV, maHocKy, maMonHoc, diemHocTap, diemHe4, xepLoaiHocTap)
VALUES
('DPM225425', 'HK01', 'MH01', 8.5, 3.5, N'Khá'),
('DPM225425', 'HK01', 'MH02', 7.0, 2.5, N'Khá'),
('DPM225426', 'HK01', 'MH01', 9.0, 4.0, N'Giỏi'),
('DPM225426', 'HK01', 'MH03', 6.0, 2.0, N'Trung bình'),
('DPM225427', 'HK02', 'MH02', 8.0, 3.0, N'Khá'),
('DPM225428', 'HK02', 'MH04', 7.5, 3.0, N'Khá'),
('DPM225429', 'HK01', 'MH05', 6.5, 2.5, N'Trung bình'),
('DPM225430', 'HK01', 'MH01', 9.0, 4.0, N'Giỏi'),
('DPM225431', 'HK02', 'MH03', 5.5, 1.5, N'Yếu'),
('DPM225432', 'HK02', 'MH02', 7.0, 2.5, N'Khá');

INSERT INTO DiemRenLuyen (MSSV, maHocKy, diemRenLuyen, xepLoaiRenLuyen)
VALUES
('DPM225425', 'HK01', 85, N'Khá'),
('DPM225426', 'HK01', 90, N'Giỏi'),
('DPM225427', 'HK02', 75, N'Trung bình'),
('DPM225428', 'HK02', 80, N'Khá'),
('DPM225429', 'HK01', 70, N'Trung bình'),
('DPM225430', 'HK01', 95, N'Xuất sắc'),
('DPM225431', 'HK02', 65, N'Yếu'),
('DPM225432', 'HK02', 78, N'Trung bình'),
('DPM225433', 'HK01', 88, N'Khá'),
('DPM225434', 'HK01', 92, N'Giỏi');
