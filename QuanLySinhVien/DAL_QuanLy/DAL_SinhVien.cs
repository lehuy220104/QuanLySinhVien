using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_SinhVien : DBConnect
    {
        public DataTable LayDanhSachSinhVien()
        {
            string sql = "SELECT * FROM SinhVien";
            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool ThemSinhVien(DTO_SinhVien sv)
        {
            string sql = "INSERT INTO SinhVien (MaSV, HoTen, MaLop) VALUES (@MaSV, @HoTen, @MaLop)";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@MaSV", sv.MaSV);
            cmd.Parameters.AddWithValue("@HoTen", sv.HoTen);
            cmd.Parameters.AddWithValue("@MaLop", sv.MaLop);

            _conn.Open();
            int rows = cmd.ExecuteNonQuery();
            _conn.Close();
            return rows > 0;
        }

        public bool CapNhatSinhVien(DTO_SinhVien sv)
        {
            string sql = "UPDATE SinhVien SET HoTen = @HoTen, MaLop = @MaLop WHERE MaSV = @MaSV";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@HoTen", sv.HoTen);
            cmd.Parameters.AddWithValue("@MaLop", sv.MaLop);
            cmd.Parameters.AddWithValue("@MaSV", sv.MaSV);

            _conn.Open();
            int rows = cmd.ExecuteNonQuery();
            _conn.Close();
            return rows > 0;
        }

        public bool XoaSinhVien(string maSV)
        {
            string sql = "DELETE FROM SinhVien WHERE MaSV = @MaSV";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@MaSV", maSV);

            _conn.Open();
            int rows = cmd.ExecuteNonQuery();
            _conn.Close();
            return rows > 0;
        }
    }
}
