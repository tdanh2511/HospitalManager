using System;

namespace InpatientManagementSystem.DTO
{
    public class PhongDTO
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string LoaiPhong { get; set; }
        public string Tang { get; set; }
        public int SoGiuong { get; set; }
        public int SoGiuongTrong { get; set; }
        public decimal GiaTien { get; set; }
        public string TrangThai { get; set; }
        public string MoTa { get; set; }
    }
}
