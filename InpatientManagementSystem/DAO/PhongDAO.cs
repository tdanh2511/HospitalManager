using InpatientManagementSystem.DAL;
using InpatientManagementSystem.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace InpatientManagementSystem.DAO
{
    public class PhongDAO
    {
        private DBConnection dbConnection = new DBConnection();

        // Thêm phòng
        public bool Insert(PhongDTO phong)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO phong 
                    (TenPhong, LoaiPhong, Tang, SoGiuong, SoGiuongTrong, GiaTien, TrangThai, MoTa)
                    VALUES
                    (@TenPhong, @LoaiPhong, @Tang, @SoGiuong, @SoGiuongTrong, @GiaTien, @TrangThai, @MoTa)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@TenPhong", phong.TenPhong);
                    cmd.Parameters.AddWithValue("@LoaiPhong", phong.LoaiPhong);
                    cmd.Parameters.AddWithValue("@Tang", phong.Tang);
                    cmd.Parameters.AddWithValue("@SoGiuong", phong.SoGiuong);
                    cmd.Parameters.AddWithValue("@SoGiuongTrong", phong.SoGiuongTrong);
                    cmd.Parameters.AddWithValue("@GiaTien", phong.GiaTien);
                    cmd.Parameters.AddWithValue("@TrangThai", phong.TrangThai);
                    cmd.Parameters.AddWithValue("@MoTa", phong.MoTa);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm phòng: " + ex.Message);
            }
        }

        // Lấy tất cả phòng
        public List<PhongDTO> GetAll()
        {
            List<PhongDTO> list = new List<PhongDTO>();
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM phong ORDER BY MaPhong DESC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PhongDTO phong = new PhongDTO
                            {
                                MaPhong = reader["MaPhong"].ToString(),
                                TenPhong = reader["TenPhong"].ToString(),
                                LoaiPhong = reader["LoaiPhong"].ToString(),
                                Tang = reader["Tang"].ToString(),
                                SoGiuong = Convert.ToInt32(reader["SoGiuong"]),
                                SoGiuongTrong = Convert.ToInt32(reader["SoGiuongTrong"]),
                                GiaTien = Convert.ToDecimal(reader["GiaTien"]),
                                TrangThai = reader["TrangThai"].ToString(),
                                MoTa = reader["MoTa"].ToString()
                            };
                            list.Add(phong);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy danh sách phòng: " + ex.Message);
            }
            return list;
        }

        // Lấy phòng theo mã
        public PhongDTO GetById(string maPhong)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM phong WHERE MaPhong = @MaPhong";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new PhongDTO
                            {
                                MaPhong = reader["MaPhong"].ToString(),
                                TenPhong = reader["TenPhong"].ToString(),
                                LoaiPhong = reader["LoaiPhong"].ToString(),
                                Tang = reader["Tang"].ToString(),
                                SoGiuong = Convert.ToInt32(reader["SoGiuong"]),
                                SoGiuongTrong = Convert.ToInt32(reader["SoGiuongTrong"]),
                                GiaTien = Convert.ToDecimal(reader["GiaTien"]),
                                TrangThai = reader["TrangThai"].ToString(),
                                MoTa = reader["MoTa"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy thông tin phòng: " + ex.Message);
            }
            return null;
        }

        // Cập nhật phòng
        public bool Update(PhongDTO phong)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE phong SET 
                        TenPhong = @TenPhong, 
                        LoaiPhong = @LoaiPhong, 
                        Tang = @Tang, 
                        SoGiuong = @SoGiuong, 
                        SoGiuongTrong = @SoGiuongTrong, 
                        GiaTien = @GiaTien, 
                        TrangThai = @TrangThai, 
                        MoTa = @MoTa
                        WHERE MaPhong = @MaPhong";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPhong", phong.MaPhong);
                    cmd.Parameters.AddWithValue("@TenPhong", phong.TenPhong);
                    cmd.Parameters.AddWithValue("@LoaiPhong", phong.LoaiPhong);
                    cmd.Parameters.AddWithValue("@Tang", phong.Tang);
                    cmd.Parameters.AddWithValue("@SoGiuong", phong.SoGiuong);
                    cmd.Parameters.AddWithValue("@SoGiuongTrong", phong.SoGiuongTrong);
                    cmd.Parameters.AddWithValue("@GiaTien", phong.GiaTien);
                    cmd.Parameters.AddWithValue("@TrangThai", phong.TrangThai);
                    cmd.Parameters.AddWithValue("@MoTa", phong.MoTa);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi cập nhật phòng: " + ex.Message);
            }
        }

        // Xóa phòng
        public bool Delete(string maPhong)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM phong WHERE MaPhong = @MaPhong";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi xóa phòng: " + ex.Message);
            }
        }

        // Tìm kiếm phòng
        public List<PhongDTO> Search(string keyword)
        {
            List<PhongDTO> list = new List<PhongDTO>();
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT * FROM phong 
                        WHERE TenPhong LIKE @keyword 
                        OR LoaiPhong LIKE @keyword 
                        OR Tang LIKE @keyword 
                        OR TrangThai LIKE @keyword
                        ORDER BY MaPhong DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PhongDTO phong = new PhongDTO
                            {
                                MaPhong = reader["MaPhong"].ToString(),
                                TenPhong = reader["TenPhong"].ToString(),
                                LoaiPhong = reader["LoaiPhong"].ToString(),
                                Tang = reader["Tang"].ToString(),
                                SoGiuong = Convert.ToInt32(reader["SoGiuong"]),
                                SoGiuongTrong = Convert.ToInt32(reader["SoGiuongTrong"]),
                                GiaTien = Convert.ToDecimal(reader["GiaTien"]),
                                TrangThai = reader["TrangThai"].ToString(),
                                MoTa = reader["MoTa"].ToString()
                            };
                            list.Add(phong);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tìm kiếm phòng: " + ex.Message);
            }
            return list;
        }
    }
}
