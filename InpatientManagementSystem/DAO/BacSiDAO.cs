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
                    string query = "INSERT INTO BacSi (MaNguoiDung, NgaySinh, GioiTinh, CMNDCCCD, DiaChi, KinhNghiem, ChuyenKhoa) " +
                                   "VALUES (@MaNguoiDung, @NgaySinh, @GioiTinh, @CMNDCCCD, @DiaChi, @KinhNghiem, @ChuyenKhoa)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNguoiDung", bs.MaNguoiDung);
                        cmd.Parameters.AddWithValue("@NgaySinh", bs.NgaySinh);
                        cmd.Parameters.AddWithValue("@GioiTinh", bs.GioiTinh);
                        cmd.Parameters.AddWithValue("@CMNDCCCD", bs.CMNDCCCD);
                        cmd.Parameters.AddWithValue("@DiaChi", bs.DiaChi);
                        cmd.Parameters.AddWithValue("@KinhNghiem", bs.KinhNghiem);
                        cmd.Parameters.AddWithValue("@ChuyenKhoa", bs.ChuyenKhoa);
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

        // Lấy tất cả bác sĩ
        public List<BacSiDTO> GetAll()
        {
            List<BacSiDTO> list = new List<BacSiDTO>();
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM BacSi ORDER BY MaBacSi ASC";
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
                                    NgaySinh = reader.GetDateTime("NgaySinh"),
                                    GioiTinh = reader.GetString("GioiTinh"),
                                    CMNDCCCD = reader.GetString("CMNDCCCD"),
                                    DiaChi = reader.GetString("DiaChi"),
                                    KinhNghiem = reader.GetInt32("KinhNghiem"),
                                    ChuyenKhoa = reader.GetString("ChuyenKhoa")
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
    }
}
