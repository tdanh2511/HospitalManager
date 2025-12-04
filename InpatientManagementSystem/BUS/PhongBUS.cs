using InpatientManagementSystem.DAO;
using InpatientManagementSystem.DTO;
using System;
using System.Collections.Generic;

namespace InpatientManagementSystem.BUS
{
    public class PhongBUS
    {
        private PhongDAO phongDAO = new PhongDAO();

        // Thêm phòng
        public bool ThemPhong(PhongDTO phongDTO)
        {
            if (string.IsNullOrEmpty(phongDTO.TenPhong) ||
                string.IsNullOrEmpty(phongDTO.LoaiPhong))
            {
                throw new ArgumentException("Thông tin phòng không hợp lệ.");
            }

            return phongDAO.Insert(phongDTO);
        }

        // Lấy tất cả phòng
        public List<PhongDTO> LayDanhSachPhong()
        {
            return phongDAO.GetAll();
        }

        // Lấy phòng theo mã
        public PhongDTO LayPhongTheoMa(string maPhong)
        {
            if (string.IsNullOrEmpty(maPhong))
            {
                throw new ArgumentException("Mã phòng không hợp lệ.");
            }
            return phongDAO.GetById(maPhong);
        }

        // Cập nhật phòng
        public bool CapNhatPhong(PhongDTO phongDTO)
        {
            if (string.IsNullOrEmpty(phongDTO.MaPhong) ||
                string.IsNullOrEmpty(phongDTO.TenPhong) ||
                string.IsNullOrEmpty(phongDTO.LoaiPhong))
            {
                throw new ArgumentException("Thông tin phòng không hợp lệ.");
            }

            return phongDAO.Update(phongDTO);
        }

        // Xóa phòng
        public bool XoaPhong(string maPhong)
        {
            if (string.IsNullOrEmpty(maPhong))
            {
                throw new ArgumentException("Mã phòng không hợp lệ.");
            }
            return phongDAO.Delete(maPhong);
        }

        // Tìm kiếm phòng
        public List<PhongDTO> TimKiemPhong(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return LayDanhSachPhong();
            }
            return phongDAO.Search(keyword);
        }
    }
}
