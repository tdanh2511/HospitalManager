using InpatientManagementSystem.DAO;
using InpatientManagementSystem.DTO;
using System;
using System.Collections.Generic;

namespace InpatientManagementSystem.BUS
{
    public class ThuocBUS
    {
        private ThuocDAO thuocDAO = new ThuocDAO();

        // Thêm thuốc
        public bool ThemThuoc(ThuocDTO thuocDTO)
        {
            if (string.IsNullOrEmpty(thuocDTO.TenThuoc) ||
                string.IsNullOrEmpty(thuocDTO.DonViTinh) ||
                thuocDTO.DonGia <= 0)
            {
                throw new ArgumentException("Thông tin thuốc không hợp lệ.");
            }

            return thuocDAO.Insert(thuocDTO);
        }

        // Lấy tất cả thuốc
        public List<ThuocDTO> LayDanhSachThuoc()
        {
            return thuocDAO.GetAll();
        }

        // Lấy thuốc theo mã
        public ThuocDTO LayThuocTheoMa(string maThuoc)
        {
            if (string.IsNullOrEmpty(maThuoc))
            {
                throw new ArgumentException("Mã thuốc không hợp lệ.");
            }
            return thuocDAO.GetById(maThuoc);
        }

        // Cập nhật thuốc
        public bool CapNhatThuoc(ThuocDTO thuocDTO)
        {
            if (string.IsNullOrEmpty(thuocDTO.MaThuoc) ||
                string.IsNullOrEmpty(thuocDTO.TenThuoc) ||
                string.IsNullOrEmpty(thuocDTO.DonViTinh) ||
                thuocDTO.DonGia <= 0)
            {
                throw new ArgumentException("Thông tin thuốc không hợp lệ.");
            }

            return thuocDAO.Update(thuocDTO);
        }

        // Xóa thuốc
        public bool XoaThuoc(string maThuoc)
        {
            if (string.IsNullOrEmpty(maThuoc))
            {
                throw new ArgumentException("Mã thuốc không hợp lệ.");
            }
            return thuocDAO.Delete(maThuoc);
        }

        // Tìm kiếm thuốc
        public List<ThuocDTO> TimKiemThuoc(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return LayDanhSachThuoc();
            }
            return thuocDAO.Search(keyword);
        }
    }
}
