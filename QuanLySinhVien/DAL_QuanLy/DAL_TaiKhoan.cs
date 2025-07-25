using System;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_TaiKhoan : DBConnect
    {
        public bool KiemTraDangNhap(DTO_TaiKhoan tk)
        {
            try
            {
                _conn.Open();
                string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @user AND MatKhau = @pass";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@user", tk.TenDangNhap);
                cmd.Parameters.AddWithValue("@pass", tk.MatKhau);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public string LayVaiTro(DTO_TaiKhoan tk)
        {
            try
            {
                _conn.Open();
                string sql = "SELECT VaiTro FROM TaiKhoan WHERE TenDangNhap = @user AND MatKhau = @pass";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@user", tk.TenDangNhap);
                cmd.Parameters.AddWithValue("@pass", tk.MatKhau);

                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : null;
            }
            catch
            {
                return null;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}