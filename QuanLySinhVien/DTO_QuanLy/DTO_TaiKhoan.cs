using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_TaiKhoan
    {
        private string _TENDANGNHAP;
        private string _MATKHAU;
        private string _VAITRO;

        /* ************* GETTER/SETTER ************* */
        public string TENDANGNHAP
        {
            get { return _TENDANGNHAP; }
            set { _TENDANGNHAP = value; }
        }

        public string MATKHAU
        {
            get { return _MATKHAU; }
            set { _MATKHAU = value; }
        }

        public string VAITRO
        {
            get { return _VAITRO; }
            set { _VAITRO = value; }
        }

        /* === Constructor === */
        public DTO_TaiKhoan() { }

        public DTO_TaiKhoan(string tenDangNhap, string matKhau, string vaiTro)
        {
            this.TENDANGNHAP = tenDangNhap;
            this.MATKHAU = matKhau;
            this.VAITRO = vaiTro;
        }
    }
}