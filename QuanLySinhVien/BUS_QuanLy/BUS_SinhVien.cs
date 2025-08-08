using DAL_QuanLy;
using DTO_QuanLy;
using System.Data;

namespace BUS_QuanLy
{
    public class BUS_SinhVien
    {
        private DAL_SinhVien dal = new DAL_SinhVien();

        public DataTable LayDanhSachSinhVien() => dal.LayDanhSachSinhVien();

        public bool ThemSinhVien(DTO_SinhVien sv) => dal.ThemSinhVien(sv);

        public bool SuaSinhVien(DTO_SinhVien sv) => dal.CapNhatSinhVien(sv);

        public bool XoaSinhVien(string maSV) => dal.XoaSinhVien(maSV);
    }
}
