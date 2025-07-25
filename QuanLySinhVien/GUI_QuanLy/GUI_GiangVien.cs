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
    public partial class GUI_GiangVien : Form
    {
        private string maGVDangNhap;
        public GUI_GiangVien(string maGV)
        {
            InitializeComponent();
            maGVDangNhap = maGV;
        }
        public GUI_GiangVien()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
