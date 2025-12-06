using InpatientManagementSystem.DAL;
using InpatientManagementSystem.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InpatientManagementSystem.DAO
{
    public class BacSiDAO
    {
        private DBConnection DBConnection = new DBConnection();

        // Thêm bác sĩ
        public bool Insert(BacSiDTO bs)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO BacSi (MaNguoiDung, HoTen, NgaySinh, GioiTinh, CMNDCCCD, DiaChi, KinhNghiem, ChuyenKhoa) " +
                                   "VALUES (@MaNguoiDung, @HoTen, @NgaySinh, @GioiTinh, @CMNDCCCD, @DiaChi, @KinhNghiem, @ChuyenKhoa)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNguoiDung", bs.MaNguoiDung);
                        cmd.Parameters.AddWithValue("@HoTen", bs.HoTen ?? "");
                        cmd.Parameters.AddWithValue("@NgaySinh", bs.NgaySinh);
                        cmd.Parameters.AddWithValue("@GioiTinh", bs.GioiTinh ?? "");
                        cmd.Parameters.AddWithValue("@CMNDCCCD", bs.CMNDCCCD ?? "");
                        cmd.Parameters.AddWithValue("@DiaChi", bs.DiaChi ?? "");
                        cmd.Parameters.AddWithValue("@KinhNghiem", bs.KinhNghiem);
                        cmd.Parameters.AddWithValue("@ChuyenKhoa", bs.ChuyenKhoa ?? "");
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm bác sĩ: " + ex.Message);
            }
        }

        // Cập nhật thông tin bác sĩ
        public bool Update(BacSiDTO bs)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE BacSi SET 
     HoTen = @HoTen,
     NgaySinh = @NgaySinh, 
     GioiTinh = @GioiTinh, 
                  CMNDCCCD = @CMNDCCCD, 
          DiaChi = @DiaChi, 
 KinhNghiem = @KinhNghiem, 
   ChuyenKhoa = @ChuyenKhoa
 WHERE MaBacSi = @MaBacSi";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaBacSi", bs.MaBacSi);
                        cmd.Parameters.AddWithValue("@HoTen", bs.HoTen ?? "");
                        cmd.Parameters.AddWithValue("@NgaySinh", bs.NgaySinh);
                        cmd.Parameters.AddWithValue("@GioiTinh", bs.GioiTinh ?? "");
                        cmd.Parameters.AddWithValue("@CMNDCCCD", bs.CMNDCCCD ?? "");
                        cmd.Parameters.AddWithValue("@DiaChi", bs.DiaChi ?? "");
                        cmd.Parameters.AddWithValue("@KinhNghiem", bs.KinhNghiem);
                        cmd.Parameters.AddWithValue("@ChuyenKhoa", bs.ChuyenKhoa ?? "");
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật bác sĩ: " + ex.Message);
            }
        }

        // Xóa bác sĩ
        public bool Delete(int maBacSi)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM BacSi WHERE MaBacSi = @MaBacSi";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaBacSi", maBacSi);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa bác sĩ: " + ex.Message);
            }
        }

        // Lấy thông tin bác sĩ theo mã
        public BacSiDTO GetById(int maBacSi)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT 
           b.MaBacSi, 
        b.MaNguoiDung, 
        b.NgaySinh, 
b.GioiTinh, 
           b.CMNDCCCD, 
        b.DiaChi, 
        b.KinhNghiem, 
             b.ChuyenKhoa,
         n.HoTen, 
        n.SoDienThoai AS SDT, 
      n.Email, 
  n.TrangThai 
                FROM BacSi b 
     INNER JOIN NguoiDung n ON b.MaNguoiDung = n.MaNguoiDung 
   WHERE b.MaBacSi = @MaBacSi";
   using (MySqlCommand cmd = new MySqlCommand(query, conn))
      {
        cmd.Parameters.AddWithValue("@MaBacSi", maBacSi);
     using (MySqlDataReader reader = cmd.ExecuteReader())
  {
  if (reader.Read())
      {
           return new BacSiDTO
                 {
   MaBacSi = reader.GetInt32("MaBacSi"),
        MaNguoiDung = reader.GetInt32("MaNguoiDung"),
         HoTen = reader.GetString("HoTen"),
   NgaySinh = reader.GetDateTime("NgaySinh"),
 GioiTinh = reader.GetString("GioiTinh"),
        SDT = reader.GetString("SDT"),
         Email = reader.GetString("Email"),
            CMNDCCCD = reader.GetString("CMNDCCCD"),
    DiaChi = reader.GetString("DiaChi"),
            KinhNghiem = reader.GetInt32("KinhNghiem"),
     ChuyenKhoa = reader.GetString("ChuyenKhoa"),
             TrangThai = reader.GetBoolean("TrangThai")
            };
            }
       }
      }
    }
         }
      catch (Exception ex)
            {
throw new Exception("Lỗi khi lấy thông tin bác sĩ: " + ex.Message);
 }
            return null;
  }

        // Lấy tất cả bác sĩ (với thông tin từ bảng NguoiDung)
        public List<BacSiDTO> GetAll()
   {
            List<BacSiDTO> list = new List<BacSiDTO>();
 try
         {
     using (MySqlConnection conn = DBConnection.GetConnection())
                {
         conn.Open();
      string query = @"SELECT 
    b.MaBacSi, 
     b.MaNguoiDung, 
              b.NgaySinh, 
                 b.GioiTinh, 
          b.CMNDCCCD, 
            b.DiaChi, 
      b.KinhNghiem, 
            b.ChuyenKhoa,
        n.HoTen, 
                n.SoDienThoai AS SDT, 
       n.Email, 
          n.TrangThai 
         FROM BacSi b 
       INNER JOIN NguoiDung n ON b.MaNguoiDung = n.MaNguoiDung 
        ORDER BY b.MaBacSi ASC";
        using (MySqlCommand cmd = new MySqlCommand(query, conn))
   {
     using (MySqlDataReader reader = cmd.ExecuteReader())
        {
         while (reader.Read())
   {
         BacSiDTO bs = new BacSiDTO
    {
 MaBacSi = reader.GetInt32("MaBacSi"),
      MaNguoiDung = reader.GetInt32("MaNguoiDung"),
             HoTen = reader.GetString("HoTen"),
    NgaySinh = reader.GetDateTime("NgaySinh"),
     GioiTinh = reader.GetString("GioiTinh"),
   SDT = reader.GetString("SDT"),
Email = reader.GetString("Email"),
        CMNDCCCD = reader.GetString("CMNDCCCD"),
    DiaChi = reader.GetString("DiaChi"),
      KinhNghiem = reader.GetInt32("KinhNghiem"),
        ChuyenKhoa = reader.GetString("ChuyenKhoa"),
   TrangThai = reader.GetBoolean("TrangThai")
      };
  list.Add(bs);
     }
          }
           }
           }
      }
 catch (Exception ex)
        {
   throw new Exception("Lỗi khi lấy danh sách bác sĩ: " + ex.Message);
   }
            return list;
        }

        // Lấy danh sách MaNguoiDung đã có trong bảng BacSi dưới dạng string
        public List<string> GetExistingMaNguoiDungList()
        {
   List<string> list = new List<string>();
            try
            {
      using (MySqlConnection conn = DBConnection.GetConnection())
         {
  conn.Open();
         string query = "SELECT MaNguoiDung FROM BacSi";
     using (MySqlCommand cmd = new MySqlCommand(query, conn))
                  {
    using (MySqlDataReader reader = cmd.ExecuteReader())
             {
       while (reader.Read())
                 {
            object val = reader["MaNguoiDung"];
 if (val != null && val != DBNull.Value)
  {
    list.Add(val.ToString());
     }
    }
         }
            }
  }
 }
  catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách MaNguoiDung từ BacSi: " + ex.Message);
     }
            return list;
        }

        // Tìm kiếm bác sĩ theo từ khóa
        public List<BacSiDTO> Search(string keyword)
    {
       List<BacSiDTO> list = new List<BacSiDTO>();
            try
    {
     using (MySqlConnection conn = DBConnection.GetConnection())
                {
          conn.Open();
    string query = @"SELECT 
     b.MaBacSi, 
              b.MaNguoiDung, 
        b.NgaySinh, 
          b.GioiTinh, 
          b.CMNDCCCD, 
    b.DiaChi, 
  b.KinhNghiem, 
       b.ChuyenKhoa,
     n.HoTen, 
             n.SoDienThoai AS SDT, 
 n.Email, 
      n.TrangThai 
    FROM BacSi b 
         INNER JOIN NguoiDung n ON b.MaNguoiDung = n.MaNguoiDung 
          WHERE n.HoTen LIKE @keyword 
         OR b.ChuyenKhoa LIKE @keyword 
       OR b.CMNDCCCD LIKE @keyword 
    OR n.Email LIKE @keyword 
   OR n.SoDienThoai LIKE @keyword
             ORDER BY b.MaBacSi ASC";
    using (MySqlCommand cmd = new MySqlCommand(query, conn))
     {
        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
         
         using (MySqlDataReader reader = cmd.ExecuteReader())
     {
    while (reader.Read())
            {
   BacSiDTO bs = new BacSiDTO
       {
 MaBacSi = reader.GetInt32("MaBacSi"),
    MaNguoiDung = reader.GetInt32("MaNguoiDung"),
        HoTen = reader.GetString("HoTen"),
       NgaySinh = reader.GetDateTime("NgaySinh"),
  GioiTinh = reader.GetString("GioiTinh"),
    SDT = reader.GetString("SDT"),
         Email = reader.GetString("Email"),
     CMNDCCCD = reader.GetString("CMNDCCCD"),
     DiaChi = reader.GetString("DiaChi"),
             KinhNghiem = reader.GetInt32("KinhNghiem"),
    ChuyenKhoa = reader.GetString("ChuyenKhoa"),
    TrangThai = reader.GetBoolean("TrangThai")
     };
         list.Add(bs);
     }
          }
     }
              }
 }
     catch (Exception ex)
            {
           throw new Exception("Lỗi khi tìm kiếm bác sĩ: " + ex.Message);
            }
            return list;
        }
    }
}
