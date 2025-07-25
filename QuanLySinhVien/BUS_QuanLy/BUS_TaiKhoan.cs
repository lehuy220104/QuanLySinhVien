using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dalTaiKhoan = new DAL_TaiKhoan();

        public bool DangNhap(DTO_TaiKhoan tk)
        {
            return dalTaiKhoan.KiemTraDangNhap(tk);
        }

        public string LayVaiTro(DTO_TaiKhoan tk)
        {
            return dalTaiKhoan.LayVaiTro(tk);
        }
    }
}
