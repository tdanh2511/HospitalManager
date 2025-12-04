using InpatientManagementSystem.DAO;
using InpatientManagementSystem.DTO;
using System;
using System.Collections.Generic;

namespace InpatientManagementSystem.BUS
{
    public class DichVuBUS
    {
        private DichVuDAO dichVuDAO = new DichVuDAO();

        // Thêm dịch vụ
        public bool ThemDichVu(DichVuDTO dichVuDTO)
        {
            if (string.IsNullOrEmpty(dichVuDTO.TenDichVu) ||
                string.IsNullOrEmpty(dichVuDTO.LoaiDichVu) ||
                dichVuDTO.DonGia <= 0)
            {
                throw new ArgumentException("Thông tin dịch vụ không hợp lệ.");
            }

            return dichVuDAO.Insert(dichVuDTO);
        }

        // Lấy tất cả dịch vụ
        public List<DichVuDTO> LayDanhSachDichVu()
        {
            return dichVuDAO.GetAll();
        }

        // Lấy dịch vụ theo mã
        public DichVuDTO LayDichVuTheoMa(string maDichVu)
        {
            if (string.IsNullOrEmpty(maDichVu))
            {
                throw new ArgumentException("Mã dịch vụ không hợp lệ.");
            }
            return dichVuDAO.GetById(maDichVu);
        }

        // Cập nhật dịch vụ
        public bool CapNhatDichVu(DichVuDTO dichVuDTO)
        {
            if (string.IsNullOrEmpty(dichVuDTO.MaDichVu) ||
                string.IsNullOrEmpty(dichVuDTO.TenDichVu) ||
                string.IsNullOrEmpty(dichVuDTO.LoaiDichVu) ||
                dichVuDTO.DonGia <= 0)
            {
                throw new ArgumentException("Thông tin dịch vụ không hợp lệ.");
            }

            return dichVuDAO.Update(dichVuDTO);
        }

        // Xóa dịch vụ
        public bool XoaDichVu(string maDichVu)
        {
            if (string.IsNullOrEmpty(maDichVu))
            {
                throw new ArgumentException("Mã dịch vụ không hợp lệ.");
            }
            return dichVuDAO.Delete(maDichVu);
        }

        // Tìm kiếm dịch vụ
        public List<DichVuDTO> TimKiemDichVu(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return LayDanhSachDichVu();
            }
            return dichVuDAO.Search(keyword);
        }
    }
}
