using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dữ liệu bênh nhân
namespace InpatientManagementSystem.DTO
{
    public class BenhNhanDTO
    {
        public string MaBenhNhan { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string CCCD { get; set; }

        public string BHYT { get; set; }
    }
}
