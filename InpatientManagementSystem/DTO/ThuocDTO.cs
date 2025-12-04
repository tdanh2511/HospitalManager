using System;

namespace InpatientManagementSystem.DTO
{
    public class ThuocDTO
    {
        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string DonViTinh { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuongTon { get; set; }
        public string HangSanXuat { get; set; }
        public string CongDung { get; set; }
        public DateTime NgayHetHan { get; set; }
        public bool TrangThai { get; set; }
    }
}
