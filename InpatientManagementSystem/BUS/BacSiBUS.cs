using InpatientManagementSystem.DAO;
using InpatientManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InpatientManagementSystem.BUS
{
    public class BacSiBUS
    {
        private BacSiDAO bacSiDAO = new BacSiDAO();

        // Thêm bác sĩ
        public bool ThemBacSi(BacSiDTO bacSiDTO)
        {
            if (bacSiDTO.KinhNghiem < 0 ||
                bacSiDTO.NgaySinh == default(DateTime) ||
                string.IsNullOrEmpty(bacSiDTO.GioiTinh) ||
                string.IsNullOrEmpty(bacSiDTO.CMNDCCCD) ||
                string.IsNullOrEmpty(bacSiDTO.DiaChi) ||
                string.IsNullOrEmpty(bacSiDTO.ChuyenKhoa))
            {
                throw new ArgumentException("Thông tin bác sĩ không hợp lệ.");
            }

            return bacSiDAO.Insert(bacSiDTO);
        }

        // Lấy danh sách bác sĩ
        public List<BacSiDTO> LayDanhSachBacSi()
        {
            return bacSiDAO.GetAll();
        }
    }
}
