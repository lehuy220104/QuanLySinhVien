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
    public partial class GUI_Admin : Form
    {
        private string maADDangNhap;
        public GUI_Admin(string maAD)
        {
            InitializeComponent();
            maADDangNhap = maAD;
        }
        public GUI_Admin()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
