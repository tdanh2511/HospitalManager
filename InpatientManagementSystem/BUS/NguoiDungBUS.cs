using InpatientManagementSystem.DAO;
using InpatientManagementSystem.DTO;
using System;
using System.Collections.Generic;

namespace InpatientManagementSystem.BUS
{
    public class NguoiDungBUS
    {
        private NguoiDungDAO nguoiDungDAO = new NguoiDungDAO();

        // Thêm người dùng
        public bool ThemNguoiDung(NguoiDungDTO nguoiDungDTO)
        {
            if (string.IsNullOrEmpty(nguoiDungDTO.TenDangNhap) ||
                string.IsNullOrEmpty(nguoiDungDTO.MatKhau) ||
                string.IsNullOrEmpty(nguoiDungDTO.HoTen) ||
                string.IsNullOrEmpty(nguoiDungDTO.VaiTro))
            {
                throw new ArgumentException("Thông tin người dùng không hợp lệ.");
            }

            return nguoiDungDAO.Insert(nguoiDungDTO);
        }

        // Lấy tất cả người dùng
        public List<NguoiDungDTO> LayDanhSachNguoiDung()
        {
            return nguoiDungDAO.GetAll();
        }

        // Lấy người dùng theo mã
        public NguoiDungDTO LayNguoiDungTheoMa(string maNguoiDung)
        {
            if (string.IsNullOrEmpty(maNguoiDung))
            {
                throw new ArgumentException("Mã người dùng không hợp lệ.");
            }
            return nguoiDungDAO.GetById(maNguoiDung);
        }

        // Cập nhật người dùng
        public bool CapNhatNguoiDung(NguoiDungDTO nguoiDungDTO)
        {
            if (string.IsNullOrEmpty(nguoiDungDTO.MaNguoiDung) ||
                string.IsNullOrEmpty(nguoiDungDTO.TenDangNhap) ||
                string.IsNullOrEmpty(nguoiDungDTO.MatKhau) ||
                string.IsNullOrEmpty(nguoiDungDTO.HoTen) ||
                string.IsNullOrEmpty(nguoiDungDTO.VaiTro))
            {
                throw new ArgumentException("Thông tin người dùng không hợp lệ.");
            }

            return nguoiDungDAO.Update(nguoiDungDTO);
        }

        // Xóa người dùng
        public bool XoaNguoiDung(string maNguoiDung)
        {
            if (string.IsNullOrEmpty(maNguoiDung))
            {
                throw new ArgumentException("Mã người dùng không hợp lệ.");
            }
            return nguoiDungDAO.Delete(maNguoiDung);
        }

        // Tìm kiếm người dùng
        public List<NguoiDungDTO> TimKiemNguoiDung(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return LayDanhSachNguoiDung();
            }
            return nguoiDungDAO.Search(keyword);
        }
    }
}
