using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class GUI_SinhVien : Form
    {
        private string maSVDangNhap;
        DataTable dt = new DataTable();
        public GUI_SinhVien(string maSV)
        {
            InitializeComponent();
            maSVDangNhap = maSV;
        }
        public GUI_SinhVien()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

        }
    }
}
