using BUS_QuanLy;
using DTO_QuanLy;
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
        private BUS_TaiKhoan bus = new BUS_TaiKhoan();
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
            DTO_TaiKhoan tk = new DTO_TaiKhoan(txtTenDN.Text.Trim(), txtMatKhau.Text.Trim(), cbVaiTro.Text);
            if (bus.ThemTaiKhoan(tk))
                MessageBox.Show("Thêm thành công!");
            else
                MessageBox.Show("Thêm thất bại!");
            LoadTaiKhoan();
            Reset();
        }

        private void GUI_Admin_Load(object sender, EventArgs e)
        {
            maAD.Text = maADDangNhap;
            cbVaiTro.Items.AddRange(new string[] { "SV", "GV", "AD" });
            LoadTaiKhoan();
        }

        private void LoadTaiKhoan()
        {
            dgvTaiKhoan.DataSource = bus.LayTatCaTaiKhoan();
        }

        private void Reset()
        {
            txtTenDN.Clear();
            txtMatKhau.Clear();
            cbVaiTro.SelectedIndex = -1;
            txtTenDN.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_TaiKhoan tk = new DTO_TaiKhoan(txtTenDN.Text.Trim(), txtMatKhau.Text.Trim(), cbVaiTro.Text);
            if (bus.SuaTaiKhoan(tk))
                MessageBox.Show("Sửa thành công!");
            else
                MessageBox.Show("Sửa thất bại!");
            LoadTaiKhoan();
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bus.XoaTaiKhoan(txtTenDN.Text.Trim()))
                MessageBox.Show("Xóa thành công!");
            else
                MessageBox.Show("Xóa thất bại!");
            LoadTaiKhoan();
            Reset();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = bus.TimKiemTaiKhoan(txtTimKiem.Text.Trim());
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                txtTenDN.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                cbVaiTro.Text = row.Cells["VaiTro"].Value.ToString();
            }
        }
    }
}
