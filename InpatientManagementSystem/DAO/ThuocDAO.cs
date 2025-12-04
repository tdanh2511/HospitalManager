using InpatientManagementSystem.DAL;
using InpatientManagementSystem.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace InpatientManagementSystem.DAO
{
    public class ThuocDAO
    {
        private DBConnection dbConnection = new DBConnection();

        // Thêm thuốc
        public bool Insert(ThuocDTO thuoc)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO thuoc 
                        (TenThuoc, DonViTinh, DonGia, SoLuongTon, HangSanXuat, CongDung, NgayHetHan, TrangThai)
                        VALUES
                        (@TenThuoc, @DonViTinh, @DonGia, @SoLuongTon, @HangSanXuat, @CongDung, @NgayHetHan, @TrangThai)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@TenThuoc", thuoc.TenThuoc);
                    cmd.Parameters.AddWithValue("@DonViTinh", thuoc.DonViTinh);
                    cmd.Parameters.AddWithValue("@DonGia", thuoc.DonGia);
                    cmd.Parameters.AddWithValue("@SoLuongTon", thuoc.SoLuongTon);
                    cmd.Parameters.AddWithValue("@HangSanXuat", thuoc.HangSanXuat);
                    cmd.Parameters.AddWithValue("@CongDung", thuoc.CongDung);
                    cmd.Parameters.AddWithValue("@NgayHetHan", thuoc.NgayHetHan);
                    cmd.Parameters.AddWithValue("@TrangThai", thuoc.TrangThai);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm thuốc: " + ex.Message);
            }
        }

        // Lấy tất cả thuốc
        public List<ThuocDTO> GetAll()
        {
            List<ThuocDTO> list = new List<ThuocDTO>();
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM thuoc ORDER BY MaThuoc DESC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ThuocDTO thuoc = new ThuocDTO
                            {
                                MaThuoc = reader["MaThuoc"].ToString(),
                                TenThuoc = reader["TenThuoc"].ToString(),
                                DonViTinh = reader["DonViTinh"].ToString(),
                                DonGia = Convert.ToDecimal(reader["DonGia"]),
                                SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                                HangSanXuat = reader["HangSanXuat"].ToString(),
                                CongDung = reader["CongDung"].ToString(),
                                NgayHetHan = Convert.ToDateTime(reader["NgayHetHan"]),
                                TrangThai = Convert.ToBoolean(reader["TrangThai"])
                            };
                            list.Add(thuoc);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy danh sách thuốc: " + ex.Message);
            }
            return list;
        }

        // Lấy thuốc theo mã
        public ThuocDTO GetById(string maThuoc)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM thuoc WHERE MaThuoc = @MaThuoc";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaThuoc", maThuoc);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ThuocDTO
                            {
                                MaThuoc = reader["MaThuoc"].ToString(),
                                TenThuoc = reader["TenThuoc"].ToString(),
                                DonViTinh = reader["DonViTinh"].ToString(),
                                DonGia = Convert.ToDecimal(reader["DonGia"]),
                                SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                                HangSanXuat = reader["HangSanXuat"].ToString(),
                                CongDung = reader["CongDung"].ToString(),
                                NgayHetHan = Convert.ToDateTime(reader["NgayHetHan"]),
                                TrangThai = Convert.ToBoolean(reader["TrangThai"])
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy thông tin thuốc: " + ex.Message);
            }
            return null;
        }

        // Cập nhật thuốc
        public bool Update(ThuocDTO thuoc)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE thuoc SET 
                        TenThuoc = @TenThuoc, 
                        DonViTinh = @DonViTinh, 
                        DonGia = @DonGia, 
                        SoLuongTon = @SoLuongTon, 
                        HangSanXuat = @HangSanXuat, 
                        CongDung = @CongDung, 
                        NgayHetHan = @NgayHetHan, 
                        TrangThai = @TrangThai
                        WHERE MaThuoc = @MaThuoc";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaThuoc", thuoc.MaThuoc);
                    cmd.Parameters.AddWithValue("@TenThuoc", thuoc.TenThuoc);
                    cmd.Parameters.AddWithValue("@DonViTinh", thuoc.DonViTinh);
                    cmd.Parameters.AddWithValue("@DonGia", thuoc.DonGia);
                    cmd.Parameters.AddWithValue("@SoLuongTon", thuoc.SoLuongTon);
                    cmd.Parameters.AddWithValue("@HangSanXuat", thuoc.HangSanXuat);
                    cmd.Parameters.AddWithValue("@CongDung", thuoc.CongDung);
                    cmd.Parameters.AddWithValue("@NgayHetHan", thuoc.NgayHetHan);
                    cmd.Parameters.AddWithValue("@TrangThai", thuoc.TrangThai);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi cập nhật thuốc: " + ex.Message);
            }
        }

        // Xóa thuốc
        public bool Delete(string maThuoc)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM thuoc WHERE MaThuoc = @MaThuoc";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaThuoc", maThuoc);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi xóa thuốc: " + ex.Message);
            }
        }

        // Tìm kiếm thuốc
        public List<ThuocDTO> Search(string keyword)
        {
            List<ThuocDTO> list = new List<ThuocDTO>();
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT * FROM thuoc 
                        WHERE TenThuoc LIKE @keyword 
                        OR HangSanXuat LIKE @keyword 
                        OR CongDung LIKE @keyword
                        ORDER BY MaThuoc DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ThuocDTO thuoc = new ThuocDTO
                            {
                                MaThuoc = reader["MaThuoc"].ToString(),
                                TenThuoc = reader["TenThuoc"].ToString(),
                                DonViTinh = reader["DonViTinh"].ToString(),
                                DonGia = Convert.ToDecimal(reader["DonGia"]),
                                SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                                HangSanXuat = reader["HangSanXuat"].ToString(),
                                CongDung = reader["CongDung"].ToString(),
                                NgayHetHan = Convert.ToDateTime(reader["NgayHetHan"]),
                                TrangThai = Convert.ToBoolean(reader["TrangThai"])
                            };
                            list.Add(thuoc);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tìm kiếm thuốc: " + ex.Message);
            }
            return list;
        }
    }
}
