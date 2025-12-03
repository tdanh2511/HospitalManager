using InpatientManagementSystem.DAL;
using InpatientManagementSystem.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace InpatientManagementSystem.DAO
{
    public class BenhNhanDAO
    {
        private DBConnection dbConnection = new DBConnection();

        public bool Insert(BenhNhanDTO bn)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO benhnhan 
                                    (CCCD, HoTen, NgaySinh, GioiTinh, SoDienThoai, BHYT, DiaChi)
                                     VALUES
                                    (@CCCD, @HoTen, @NgaySinh, @GioiTinh, @SoDienThoai, @BHYT, @DiaChi)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@CCCD", bn.CCCD);
                    cmd.Parameters.AddWithValue("@HoTen", bn.HoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", bn.NgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", bn.GioiTinh);
                    cmd.Parameters.AddWithValue("@SoDienThoai", bn.SoDienThoai);
                    cmd.Parameters.AddWithValue("@BHYT", bn.BHYT);
                    cmd.Parameters.AddWithValue("@DiaChi", bn.DiaChi);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm bệnh nhân: " + ex.Message);
            }
        }
    }
}
