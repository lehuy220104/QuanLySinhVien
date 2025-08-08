using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_GiangVien : DBConnect
    {
        public DataTable LayDanhSachGiangVien()
        {
            string sql = "SELECT * FROM GiangVien";
            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool ThemGiangVien(DTO_GiangVien gv)
        {
            string sql = "INSERT INTO GiangVien (MaGV, HoTen) VALUES (@MaGV, @HoTen)";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@MaGV", gv.MaGV);
            cmd.Parameters.AddWithValue("@HoTen", gv.HoTen);

            _conn.Open();
            int rows = cmd.ExecuteNonQuery();
            _conn.Close();
            return rows > 0;
        }

        public bool CapNhatGiangVien(DTO_GiangVien gv)
        {
            string sql = "UPDATE GiangVien SET HoTen = @HoTen WHERE MaGV = @MaGV";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@HoTen", gv.HoTen);
            cmd.Parameters.AddWithValue("@MaGV", gv.MaGV);

            _conn.Open();
            int rows = cmd.ExecuteNonQuery();
            _conn.Close();
            return rows > 0;
        }

        public bool XoaGiangVien(string maGV)
        {
            string sql = "DELETE FROM GiangVien WHERE MaGV = @MaGV";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@MaGV", maGV);

            _conn.Open();
            int rows = cmd.ExecuteNonQuery();
            _conn.Close();
            return rows > 0;
        }
    }
}
