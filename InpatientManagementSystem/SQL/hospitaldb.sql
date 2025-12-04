CREATE DATABASE IF NOT EXISTS hospitaldb;
USE hospitaldb;

-- =====================================================
-- 1. BẢNG NGƯỜI DÙNG
-- =====================================================
CREATE TABLE IF NOT EXISTS nguoidung (
  MaNguoiDung INT AUTO_INCREMENT PRIMARY KEY,
    TenDangNhap VARCHAR(50) UNIQUE NOT NULL,
    MatKhau VARCHAR(255) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    VaiTro VARCHAR(20) NOT NULL, -- Admin, BacSi, LeTan
    Email VARCHAR(100),
    SoDienThoai VARCHAR(15),
    TrangThai BOOLEAN DEFAULT TRUE,
    NgayTao DATETIME DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Thêm dữ liệu mẫu người dùng
INSERT INTO nguoidung (TenDangNhap, MatKhau, HoTen, VaiTro, Email, SoDienThoai, TrangThai)
VALUES 
    ('admin', '21232f297a57a5a743894a0e4a801fc3', 'Quản trị viên', 'Admin', 'admin@hospital.com', '0123456789', TRUE),
    ('bacsi', '202cb962ac59075b964b07152d234b70', 'Bác sĩ Nguyễn Văn A', 'BacSi', 'bacsi@hospital.com', '0987654321', TRUE),
    ('letan', '202cb962ac59075b964b07152d234b70', 'Lễ tân Trần Thị B', 'LeTan', 'letan@hospital.com', '0912345678', TRUE);

-- =====================================================
-- 2. BẢNG THUỐC
-- =====================================================
CREATE TABLE IF NOT EXISTS thuoc (
    MaThuoc INT AUTO_INCREMENT PRIMARY KEY,
    TenThuoc NVARCHAR(200) NOT NULL,
    DonViTinh NVARCHAR(50) NOT NULL,
  DonGia DECIMAL(18, 2) NOT NULL DEFAULT 0,
 SoLuongTon INT NOT NULL DEFAULT 0,
    HangSanXuat NVARCHAR(200),
    CongDung NVARCHAR(500),
    NgayHetHan DATE,
    TrangThai BOOLEAN DEFAULT TRUE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Thêm dữ liệu mẫu thuốc
INSERT INTO thuoc (TenThuoc, DonViTinh, DonGia, SoLuongTon, HangSanXuat, CongDung, NgayHetHan, TrangThai)
VALUES 
    ('Paracetamol 500mg', 'Viên', 2000, 1000, 'Pymepharco', 'Giảm đau, hạ sốt', '2026-12-31', TRUE),
    ('Amoxicillin 500mg', 'Viên', 3500, 500, 'Domesco', 'Kháng sinh', '2025-06-30', TRUE),
    ('Vitamin C 500mg', 'Viên', 1500, 2000, 'DHG Pharma', 'Bổ sung Vitamin C', '2027-03-15', TRUE),
    ('Omeprazole 20mg', 'Viên', 4000, 300, 'Teva', 'Điều trị loét dạ dày', '2026-08-20', TRUE);

-- =====================================================
-- 3. BẢNG DỊCH VỤ
-- =====================================================
CREATE TABLE IF NOT EXISTS dichvu (
    MaDichVu INT AUTO_INCREMENT PRIMARY KEY,
    TenDichVu NVARCHAR(200) NOT NULL,
    LoaiDichVu NVARCHAR(100) NOT NULL,
    DonGia DECIMAL(18, 2) NOT NULL DEFAULT 0,
    DonViTinh NVARCHAR(50),
    MoTa NVARCHAR(500),
    TrangThai BOOLEAN DEFAULT TRUE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Thêm dữ liệu mẫu dịch vụ
INSERT INTO dichvu (TenDichVu, LoaiDichVu, DonGia, DonViTinh, MoTa, TrangThai)
VALUES 
    ('Xét nghiệm máu tổng quát', 'Xét nghiệm', 150000, 'Lần', 'Xét nghiệm công thức máu', TRUE),
    ('Chụp X-Quang ngực', 'Chẩn đoán hình ảnh', 200000, 'Lần', 'Chụp X-Quang phổi', TRUE),
    ('Siêu âm bụng tổng quát', 'Chẩn đoán hình ảnh', 300000, 'Lần', 'Siêu âm gan, lách, thận...', TRUE),
    ('Khám tổng quát', 'Khám bệnh', 100000, 'Lần', 'Khám sức khỏe tổng quát', TRUE),
    ('Chụp CT Scanner', 'Chẩn đoán hình ảnh', 1500000, 'Lần', 'Chụp cắt lớp vi tính', TRUE);

-- =====================================================
-- 4. BẢNG PHÒNG
-- =====================================================
CREATE TABLE IF NOT EXISTS phong (
    MaPhong INT AUTO_INCREMENT PRIMARY KEY,
    TenPhong NVARCHAR(100) NOT NULL,
    LoaiPhong NVARCHAR(50) NOT NULL,
    Tang NVARCHAR(20),
    SoGiuong INT NOT NULL DEFAULT 0,
    SoGiuongTrong INT NOT NULL DEFAULT 0,
    GiaTien DECIMAL(18, 2) NOT NULL DEFAULT 0,
    TrangThai NVARCHAR(50) DEFAULT 'Hoạt động',
    MoTa NVARCHAR(500)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Thêm dữ liệu mẫu phòng
INSERT INTO phong (TenPhong, LoaiPhong, Tang, SoGiuong, SoGiuongTrong, GiaTien, TrangThai, MoTa)
VALUES 
    ('Phòng 101', 'Phòng bệnh thường', 'Tầng 1', 4, 4, 200000, 'Hoạt động', 'Phòng 4 giường'),
    ('Phòng 102', 'Phòng bệnh thường', 'Tầng 1', 4, 2, 200000, 'Hoạt động', 'Phòng 4 giường'),
    ('Phòng 201', 'Phòng VIP', 'Tầng 2', 1, 1, 800000, 'Hoạt động', 'Phòng VIP 1 giường'),
    ('Phòng 202', 'Phòng VIP', 'Tầng 2', 2, 0, 500000, 'Hoạt động', 'Phòng VIP 2 giường'),
    ('Phòng khám 1', 'Phòng khám', 'Tầng 1', 0, 0, 0, 'Hoạt động', 'Phòng khám bệnh'),
 ('Phòng mổ 1', 'Phòng mổ', 'Tầng 3', 1, 1, 0, 'Hoạt động', 'Phòng phẫu thuật');

-- =====================================================
-- 5. BẢNG BỆNH NHÂN (CẬP NHẬT)
-- =====================================================
CREATE TABLE IF NOT EXISTS benhnhan (
    MaBenhNhan INT AUTO_INCREMENT PRIMARY KEY,  
    CCCD VARCHAR(20) UNIQUE NOT NULL,          
    HoTen VARCHAR(100) NOT NULL,       
    NgaySinh DATE NOT NULL,           
    GioiTinh ENUM('Nam','Nữ') NOT NULL,              
    SoDienThoai VARCHAR(10) UNIQUE CHECK (CHAR_LENGTH(SoDienThoai) = 10),           
    BHYT VARCHAR(20) UNIQUE,         
    DiaChi TEXT NOT NULL,
    NgayTao DATETIME DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =====================================================
-- INDEX ĐỂ TỐI ƠI TRUY VẤN
-- =====================================================
CREATE INDEX idx_nguoidung_tendangnhap ON nguoidung(TenDangNhap);
CREATE INDEX idx_thuoc_tenthuoc ON thuoc(TenThuoc);
CREATE INDEX idx_dichvu_tendichvu ON dichvu(TenDichVu);
CREATE INDEX idx_phong_tenphong ON phong(TenPhong);
CREATE INDEX idx_benhnhan_cccd ON benhnhan(CCCD);

-- =====================================================
-- KIỂM TRA KẾT QUẢ
-- =====================================================
SELECT 'Database hospitaldb đã được tạo thành công!' AS Message;

SELECT 
    'nguoidung' AS TableName, 
    COUNT(*) AS RecordCount 
FROM nguoidung
UNION ALL
SELECT 'thuoc', COUNT(*) FROM thuoc
UNION ALL
SELECT 'dichvu', COUNT(*) FROM dichvu
UNION ALL
SELECT 'phong', COUNT(*) FROM phong
UNION ALL
SELECT 'benhnhan', COUNT(*) FROM benhnhan;

-- Xem tất cả dữ liệu
SELECT * FROM nguoidung;
SELECT * FROM thuoc;
SELECT * FROM dichvu;
SELECT * FROM phong;
SELECT * FROM benhnhan;CREATE DATABASE IF NOT EXISTS hospitaldb;
USE hospitaldb;

-- =====================================================
-- 1. BẢNG NGƯỜI DÙNG
-- =====================================================
CREATE TABLE IF NOT EXISTS nguoidung (
  MaNguoiDung INT AUTO_INCREMENT PRIMARY KEY,
    TenDangNhap VARCHAR(50) UNIQUE NOT NULL,
    MatKhau VARCHAR(255) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    VaiTro VARCHAR(20) NOT NULL, -- Admin, BacSi, LeTan
    Email VARCHAR(100),
    SoDienThoai VARCHAR(15),
    TrangThai BOOLEAN DEFAULT TRUE,
    NgayTao DATETIME DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Thêm dữ liệu mẫu người dùng
INSERT INTO nguoidung (TenDangNhap, MatKhau, HoTen, VaiTro, Email, SoDienThoai, TrangThai)
VALUES 
    ('admin', '21232f297a57a5a743894a0e4a801fc3', 'Quản trị viên', 'Admin', 'admin@hospital.com', '0123456789', TRUE),
    ('bacsi', '202cb962ac59075b964b07152d234b70', 'Bác sĩ Nguyễn Văn A', 'BacSi', 'bacsi@hospital.com', '0987654321', TRUE),
    ('letan', '202cb962ac59075b964b07152d234b70', 'Lễ tân Trần Thị B', 'LeTan', 'letan@hospital.com', '0912345678', TRUE);

-- =====================================================
-- 2. BẢNG THUỐC
-- =====================================================
CREATE TABLE IF NOT EXISTS thuoc (
    MaThuoc INT AUTO_INCREMENT PRIMARY KEY,
    TenThuoc NVARCHAR(200) NOT NULL,
    DonViTinh NVARCHAR(50) NOT NULL,
  DonGia DECIMAL(18, 2) NOT NULL DEFAULT 0,
 SoLuongTon INT NOT NULL DEFAULT 0,
    HangSanXuat NVARCHAR(200),
    CongDung NVARCHAR(500),
    NgayHetHan DATE,
    TrangThai BOOLEAN DEFAULT TRUE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Thêm dữ liệu mẫu thuốc
INSERT INTO thuoc (TenThuoc, DonViTinh, DonGia, SoLuongTon, HangSanXuat, CongDung, NgayHetHan, TrangThai)
VALUES 
    ('Paracetamol 500mg', 'Viên', 2000, 1000, 'Pymepharco', 'Giảm đau, hạ sốt', '2026-12-31', TRUE),
    ('Amoxicillin 500mg', 'Viên', 3500, 500, 'Domesco', 'Kháng sinh', '2025-06-30', TRUE),
    ('Vitamin C 500mg', 'Viên', 1500, 2000, 'DHG Pharma', 'Bổ sung Vitamin C', '2027-03-15', TRUE),
    ('Omeprazole 20mg', 'Viên', 4000, 300, 'Teva', 'Điều trị loét dạ dày', '2026-08-20', TRUE);

-- =====================================================
-- 3. BẢNG DỊCH VỤ
-- =====================================================
CREATE TABLE IF NOT EXISTS dichvu (
    MaDichVu INT AUTO_INCREMENT PRIMARY KEY,
    TenDichVu NVARCHAR(200) NOT NULL,
    LoaiDichVu NVARCHAR(100) NOT NULL,
    DonGia DECIMAL(18, 2) NOT NULL DEFAULT 0,
    DonViTinh NVARCHAR(50),
    MoTa NVARCHAR(500),
    TrangThai BOOLEAN DEFAULT TRUE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Thêm dữ liệu mẫu dịch vụ
INSERT INTO dichvu (TenDichVu, LoaiDichVu, DonGia, DonViTinh, MoTa, TrangThai)
VALUES 
    ('Xét nghiệm máu tổng quát', 'Xét nghiệm', 150000, 'Lần', 'Xét nghiệm công thức máu', TRUE),
    ('Chụp X-Quang ngực', 'Chẩn đoán hình ảnh', 200000, 'Lần', 'Chụp X-Quang phổi', TRUE),
    ('Siêu âm bụng tổng quát', 'Chẩn đoán hình ảnh', 300000, 'Lần', 'Siêu âm gan, lách, thận...', TRUE),
    ('Khám tổng quát', 'Khám bệnh', 100000, 'Lần', 'Khám sức khỏe tổng quát', TRUE),
    ('Chụp CT Scanner', 'Chẩn đoán hình ảnh', 1500000, 'Lần', 'Chụp cắt lớp vi tính', TRUE);

-- =====================================================
-- 4. BẢNG PHÒNG
-- =====================================================
CREATE TABLE IF NOT EXISTS phong (
    MaPhong INT AUTO_INCREMENT PRIMARY KEY,
    TenPhong NVARCHAR(100) NOT NULL,
    LoaiPhong NVARCHAR(50) NOT NULL,
    Tang NVARCHAR(20),
    SoGiuong INT NOT NULL DEFAULT 0,
    SoGiuongTrong INT NOT NULL DEFAULT 0,
    GiaTien DECIMAL(18, 2) NOT NULL DEFAULT 0,
    TrangThai NVARCHAR(50) DEFAULT 'Hoạt động',
    MoTa NVARCHAR(500)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Thêm dữ liệu mẫu phòng
INSERT INTO phong (TenPhong, LoaiPhong, Tang, SoGiuong, SoGiuongTrong, GiaTien, TrangThai, MoTa)
VALUES 
    ('Phòng 101', 'Phòng bệnh thường', 'Tầng 1', 4, 4, 200000, 'Hoạt động', 'Phòng 4 giường'),
    ('Phòng 102', 'Phòng bệnh thường', 'Tầng 1', 4, 2, 200000, 'Hoạt động', 'Phòng 4 giường'),
    ('Phòng 201', 'Phòng VIP', 'Tầng 2', 1, 1, 800000, 'Hoạt động', 'Phòng VIP 1 giường'),
    ('Phòng 202', 'Phòng VIP', 'Tầng 2', 2, 0, 500000, 'Hoạt động', 'Phòng VIP 2 giường'),
    ('Phòng khám 1', 'Phòng khám', 'Tầng 1', 0, 0, 0, 'Hoạt động', 'Phòng khám bệnh'),
 ('Phòng mổ 1', 'Phòng mổ', 'Tầng 3', 1, 1, 0, 'Hoạt động', 'Phòng phẫu thuật');

-- =====================================================
-- 5. BẢNG BỆNH NHÂN (CẬP NHẬT)
-- =====================================================
CREATE TABLE IF NOT EXISTS benhnhan (
    MaBenhNhan INT AUTO_INCREMENT PRIMARY KEY,  
    CCCD VARCHAR(20) UNIQUE NOT NULL,          
    HoTen VARCHAR(100) NOT NULL,       
 NgaySinh DATE NOT NULL,           
    GioiTinh ENUM('Nam','Nữ') NOT NULL,              
    SoDienThoai VARCHAR(10) UNIQUE CHECK (CHAR_LENGTH(SoDienThoai) = 10),           
    BHYT VARCHAR(20) UNIQUE,         
    DiaChi TEXT NOT NULL,
    NgayTao DATETIME DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =====================================================
-- INDEX ĐỂ TỐI ƠI TRUY VẤN
-- =====================================================
CREATE INDEX idx_nguoidung_tendangnhap ON nguoidung(TenDangNhap);
CREATE INDEX idx_thuoc_tenthuoc ON thuoc(TenThuoc);
CREATE INDEX idx_dichvu_tendichvu ON dichvu(TenDichVu);
CREATE INDEX idx_phong_tenphong ON phong(TenPhong);
CREATE INDEX idx_benhnhan_cccd ON benhnhan(CCCD);

-- =====================================================
-- KIỂM TRA KẾT QUẢ
-- =====================================================
SELECT 'Database hospitaldb đã được tạo thành công!' AS Message;

SELECT 
    'nguoidung' AS TableName, 
    COUNT(*) AS RecordCount 
FROM nguoidung
UNION ALL
SELECT 'thuoc', COUNT(*) FROM thuoc
UNION ALL
SELECT 'dichvu', COUNT(*) FROM dichvu
UNION ALL
SELECT 'phong', COUNT(*) FROM phong
UNION ALL
SELECT 'benhnhan', COUNT(*) FROM benhnhan;

-- Xem tất cả dữ liệu
SELECT * FROM nguoidung;
SELECT * FROM thuoc;
SELECT * FROM dichvu;
SELECT * FROM phong;
SELECT * FROM benhnhan;