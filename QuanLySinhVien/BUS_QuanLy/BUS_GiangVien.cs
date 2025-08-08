using DAL_QuanLy;
using DTO_QuanLy;
using System.Data;

namespace BUS_QuanLy
{
    public class BUS_GiangVien
    {
        private DAL_GiangVien dal = new DAL_GiangVien();

        public DataTable LayDanhSachGiangVien() => dal.LayDanhSachGiangVien();

        public bool ThemGiangVien(DTO_GiangVien gv) => dal.ThemGiangVien(gv);

        public bool SuaGiangVien(DTO_GiangVien gv) => dal.CapNhatGiangVien(gv);

        public bool XoaGiangVien(string maGV) => dal.XoaGiangVien(maGV);
    }
}
