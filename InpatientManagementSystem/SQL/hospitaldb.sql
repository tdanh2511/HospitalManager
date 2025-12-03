CREATE DATABASE IF NOT EXISTS hospitaldb;
USE hospitaldb;

CREATE TABLE benhnhan (
    MaBenhNhan INT auto_increment PRIMARY KEY,         
    CCCD VARCHAR(20) UNIQUE,                     
    HoTen VARCHAR(100) NOT NULL,                       
    NgaySinh DATE NOT NULL,                                
    GioiTinh ENUM('Nam','Nữ') NOT NULL,              
    SoDienThoai VARCHAR(10) UNIQUE CHECK (CHAR_LENGTH(SoDienThoai) = 10),           
    BHYT VARCHAR(20) UNIQUE,                              
    DiaChi TEXT NOT NULL                               
);

select * from benhnhan