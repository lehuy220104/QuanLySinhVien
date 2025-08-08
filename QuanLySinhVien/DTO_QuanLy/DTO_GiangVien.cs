using System;

namespace DTO_QuanLy
{
    public class DTO_GiangVien
    {
        public string MaGV { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }

        public DTO_GiangVien() { }

        public DTO_GiangVien(string maGV, string hoTen, string email, string sdt, string gioiTinh, DateTime ngaySinh)
        {
            MaGV = maGV;
            HoTen = hoTen;
            Email = email;
            SDT = sdt;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
        }
    }
}
