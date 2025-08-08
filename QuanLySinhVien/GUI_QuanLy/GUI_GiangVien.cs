using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_GiangVien : Form
    {
        private string maGVDangNhap;
        private BUS_LopHocPhan busLHP = new BUS_LopHocPhan();
        private BUS_Diem busDiem = new BUS_Diem();
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
            DTO_Diem diem = TaoDiemTuForm();
            if (busDiem.ThemDiem(diem))
            {
                MessageBox.Show("Nhập điểm thành công!");
                LoadDSSinhVien(cbLopHP.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Nhập điểm thất bại!");
            }
        }

        private void GUI_GiangVien_Load(object sender, EventArgs e)
        {
            maGV.Text = maGVDangNhap;
            LoadLopHocPhan(maGVDangNhap);
            LoadHocKy();
        }
        private void LoadLopHocPhan(string maGV)
        {
            cbLopHP.DataSource = busLHP.LayDanhSachLopHP(maGV);
            cbLopHP.DisplayMember = "MaLHP";
            cbLopHP.ValueMember = "MaLHP";
        }

        private void LoadHocKy()
        {
            cbHocKyTK.DataSource = new BUS_HocKy().LayDanhSachHocKy();
            cbHocKyTK.DisplayMember = "TenHocKy";
            cbHocKyTK.ValueMember = "MaHK";
        }

        private void cbLopHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLopHP.SelectedValue != null)
            {
                string maLHP = cbLopHP.SelectedValue.ToString();
                LoadDSSinhVien(maLHP);
            }
        }
        private void LoadDSSinhVien(string maLHP)
        {
            dgvDSSV.DataSource = busDiem.LayDanhSachDiem(maLHP);
            ResetNut();
        }
        private void ResetNut()
        {
            btnNhap.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lbMaSV.Text = "...";
            lbTenSV.Text = "...";
            txtDiem.Clear();
        }

        private void dgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnNhap.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                lbMaSV.Text = dgvDSSV.Rows[e.RowIndex].Cells["MaSV"].Value.ToString();
                lbTenSV.Text = dgvDSSV.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                txtDiem.Text = dgvDSSV.Rows[e.RowIndex].Cells["Diem"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_Diem diem = TaoDiemTuForm();
            if (busDiem.SuaDiem(diem))
            {
                MessageBox.Show("Cập nhật điểm thành công!");
                LoadDSSinhVien(cbLopHP.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Cập nhật điểm thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = lbMaSV.Text;
            string maLHP = cbLopHP.SelectedValue.ToString();

            if (busDiem.XoaDiem(new DTO_Diem { MaSV = maSV, MaLHP = maLHP }))
            {
                MessageBox.Show("Xóa điểm thành công!");
                LoadDSSinhVien(maLHP);
            }
            else
            {
                MessageBox.Show("Xóa điểm thất bại!");
            }
        }
        private DTO_Diem TaoDiemTuForm()
        {
            return new DTO_Diem
            {
                MaSV = lbMaSV.Text,
                MaLHP = cbLopHP.SelectedValue.ToString(),
                Diem = float.TryParse(txtDiem.Text, out float d) ? d : 0
            };
        }

        
    }
}
