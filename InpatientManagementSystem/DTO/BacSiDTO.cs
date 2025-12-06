using System;

namespace InpatientManagementSystem.DTO
{
    public class BacSiDTO
    {
        public int MaBacSi { get; set; }
        public int MaNguoiDung { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string CMNDCCCD { get; set; }
        public string DiaChi { get; set; }
        public int KinhNghiem { get; set; }
        public string ChuyenKhoa { get; set; }
        public bool TrangThai { get; set; }
    }

}