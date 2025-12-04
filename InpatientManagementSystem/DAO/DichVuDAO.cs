using InpatientManagementSystem.DAL;
using InpatientManagementSystem.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace InpatientManagementSystem.DAO
{
    public class DichVuDAO
    {
        private DBConnection dbConnection = new DBConnection();

        // Thêm dịch vụ
        public bool Insert(DichVuDTO dv)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO dichvu 
                        (TenDichVu, LoaiDichVu, DonGia, DonViTinh, MoTa, TrangThai)
                        VALUES
                        (@TenDichVu, @LoaiDichVu, @DonGia, @DonViTinh, @MoTa, @TrangThai)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@TenDichVu", dv.TenDichVu);
                    cmd.Parameters.AddWithValue("@LoaiDichVu", dv.LoaiDichVu);
                    cmd.Parameters.AddWithValue("@DonGia", dv.DonGia);
                    cmd.Parameters.AddWithValue("@DonViTinh", dv.DonViTinh);
                    cmd.Parameters.AddWithValue("@MoTa", dv.MoTa);
                    cmd.Parameters.AddWithValue("@TrangThai", dv.TrangThai);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm dịch vụ: " + ex.Message);
            }
        }

        // Lấy tất cả dịch vụ
        public List<DichVuDTO> GetAll()
        {
            List<DichVuDTO> list = new List<DichVuDTO>();
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM dichvu ORDER BY MaDichVu DESC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DichVuDTO dv = new DichVuDTO
                            {
                                MaDichVu = reader["MaDichVu"].ToString(),
                                TenDichVu = reader["TenDichVu"].ToString(),
                                LoaiDichVu = reader["LoaiDichVu"].ToString(),
                                DonGia = Convert.ToDecimal(reader["DonGia"]),
                                DonViTinh = reader["DonViTinh"].ToString(),
                                MoTa = reader["MoTa"].ToString(),
                                TrangThai = Convert.ToBoolean(reader["TrangThai"])
                            };
                            list.Add(dv);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy danh sách dịch vụ: " + ex.Message);
            }
            return list;
        }

        // Lấy dịch vụ theo mã
        public DichVuDTO GetById(string maDichVu)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM dichvu WHERE MaDichVu = @MaDichVu";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaDichVu", maDichVu);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DichVuDTO
                            {
                                MaDichVu = reader["MaDichVu"].ToString(),
                                TenDichVu = reader["TenDichVu"].ToString(),
                                LoaiDichVu = reader["LoaiDichVu"].ToString(),
                                DonGia = Convert.ToDecimal(reader["DonGia"]),
                                DonViTinh = reader["DonViTinh"].ToString(),
                                MoTa = reader["MoTa"].ToString(),
                                TrangThai = Convert.ToBoolean(reader["TrangThai"])
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy thông tin dịch vụ: " + ex.Message);
            }
            return null;
        }

        // Cập nhật dịch vụ
        public bool Update(DichVuDTO dv)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE dichvu SET 
                        TenDichVu = @TenDichVu, 
                        LoaiDichVu = @LoaiDichVu, 
                        DonGia = @DonGia, 
                        DonViTinh = @DonViTinh, 
                        MoTa = @MoTa, 
                        TrangThai = @TrangThai
                        WHERE MaDichVu = @MaDichVu";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaDichVu", dv.MaDichVu);
                    cmd.Parameters.AddWithValue("@TenDichVu", dv.TenDichVu);
                    cmd.Parameters.AddWithValue("@LoaiDichVu", dv.LoaiDichVu);
                    cmd.Parameters.AddWithValue("@DonGia", dv.DonGia);
                    cmd.Parameters.AddWithValue("@DonViTinh", dv.DonViTinh);
                    cmd.Parameters.AddWithValue("@MoTa", dv.MoTa);
                    cmd.Parameters.AddWithValue("@TrangThai", dv.TrangThai);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi cập nhật dịch vụ: " + ex.Message);
            }
        }

        // Xóa dịch vụ
        public bool Delete(string maDichVu)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM dichvu WHERE MaDichVu = @MaDichVu";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaDichVu", maDichVu);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi xóa dịch vụ: " + ex.Message);
            }
        }

        // Tìm kiếm dịch vụ
        public List<DichVuDTO> Search(string keyword)
        {
            List<DichVuDTO> list = new List<DichVuDTO>();
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT * FROM dichvu 
                        WHERE TenDichVu LIKE @keyword 
                        OR LoaiDichVu LIKE @keyword 
                        OR MoTa LIKE @keyword
                        ORDER BY MaDichVu DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DichVuDTO dv = new DichVuDTO
                            {
                                MaDichVu = reader["MaDichVu"].ToString(),
                                TenDichVu = reader["TenDichVu"].ToString(),
                                LoaiDichVu = reader["LoaiDichVu"].ToString(),
                                DonGia = Convert.ToDecimal(reader["DonGia"]),
                                DonViTinh = reader["DonViTinh"].ToString(),
                                MoTa = reader["MoTa"].ToString(),
                                TrangThai = Convert.ToBoolean(reader["TrangThai"])
                            };
                            list.Add(dv);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tìm kiếm dịch vụ: " + ex.Message);
            }
            return list;
        }
    }
}
