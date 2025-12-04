using InpatientManagementSystem.DAO;
using InpatientManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InpatientManagementSystem.BUS
{
    public class BenhNhanBUS
    {
        private BenhNhanDAO benhNhanDAO = new BenhNhanDAO();

        public bool ThemBenhNhan(BenhNhanDTO benhNhanDTO) 
        {
            if (string.IsNullOrEmpty(benhNhanDTO.HoTen) ||
                benhNhanDTO.NgaySinh == default(DateTime) ||
                string.IsNullOrEmpty(benhNhanDTO.GioiTinh) ||
                string.IsNullOrEmpty(benhNhanDTO.DiaChi) ||
                string.IsNullOrEmpty(benhNhanDTO.SoDienThoai) ||
                string.IsNullOrEmpty(benhNhanDTO.CCCD) ||
                string.IsNullOrEmpty(benhNhanDTO.BHYT))
            {
                throw new ArgumentException("Thông tin bệnh nhân không hợp lệ.");
            }

            return benhNhanDAO.Insert(benhNhanDTO);
        }
    }
}
