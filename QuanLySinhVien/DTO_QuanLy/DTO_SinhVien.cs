using System;

namespace DTO_QuanLy
{
    public class DTO_SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string MaLop { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }

        public DTO_SinhVien() { }

        public DTO_SinhVien(string maSV, string hoTen, string maLop, string gioiTinh, DateTime ngaySinh, string email, string sdt)
        {
            MaSV = maSV;
            HoTen = hoTen;
            MaLop = maLop;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Email = email;
            SDT = sdt;
        }
    }
}
