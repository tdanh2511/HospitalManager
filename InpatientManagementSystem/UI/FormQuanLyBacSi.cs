using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InpatientManagementSystem.BUS;
using InpatientManagementSystem.DTO;
using InpatientManagementSystem.DAO;

namespace Quan_li_benh_vien
{
    public partial class FormQuanLyBacSi : Form
    {
        private BacSiBUS bacSiBUS = new BacSiBUS();
        private NguoiDungDAO nguoiDungDAO = new NguoiDungDAO();
        private string maBSDangChon = "";

        public FormQuanLyBacSi()
        {
            InitializeComponent();
        }

        private void FormQuanLyBacSi_Load(object sender, EventArgs e)
        {
            LoadNguoiDungCombo();
            // optionally load existing doctors into grid
        }

        private void LoadNguoiDungCombo()
        {
            try
            {
                List<NguoiDungDTO> users = nguoiDungDAO.GetAll();
                List<BacSiDTO> existingBacSi = bacSiBUS.LayDanhSachBacSi();
                var existingIds = new HashSet<string>(existingBacSi.Select(b => b.MaNguoiDung.ToString()));

                var items = new List<KeyValuePair<string, string>>();
                foreach (var u in users)
                {
                    if (u.VaiTro == "BacSi" && !existingIds.Contains(u.MaNguoiDung))
                    {
                        string display = $"{u.MaNguoiDung}-{u.HoTen}-{u.TenDangNhap}";
                        items.Add(new KeyValuePair<string, string>(u.MaNguoiDung, display));
                    }
                }

                cmbNguoiDung.DataSource = null;
                cmbNguoiDung.DataSource = items;
                cmbNguoiDung.DisplayMember = "Value";
                cmbNguoiDung.ValueMember = "Key";
                cmbNguoiDung.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbNguoiDung.SelectedIndex <0) return;
                var selected = cmbNguoiDung.SelectedValue as string;
                if (string.IsNullOrEmpty(selected)) return;

                NguoiDungDTO user = nguoiDungDAO.GetById(selected);
                if (user != null)
                {
                    txtHoTen.Text = user.HoTen;
                    txtSDT.Text = user.SoDienThoai;
                    txtEmail.Text = user.Email;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbNguoiDung.SelectedIndex <0)
                {
                    MessageBox.Show("Vui lòng chọn tài khoản người dùng để liên kết với bác sĩ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convert kinh nghiem
                int kinhNghiem;
                if (!int.TryParse(txtKinhNghiem.Text.Trim(), out kinhNghiem) || kinhNghiem <0)
                {
                    MessageBox.Show("Kinh nghiệm phải là số nguyên lớn hơn hoặc bằng0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedMaNguoiDung = cmbNguoiDung.SelectedValue as string;
                if (!int.TryParse(selectedMaNguoiDung, out int maNguoiDungInt))
                {
                    MessageBox.Show("Mã người dùng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BacSiDTO bs = new BacSiDTO
                {
                    MaNguoiDung = maNguoiDungInt,
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = cmbGioiTinh.Text,
                    SDT = txtSDT.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    CMNDCCCD = txtCMND.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    KinhNghiem = kinhNghiem,
                    ChuyenKhoa = txtChuyenKhoa.Text.Trim(),
                    TrangThai = chkTrangThai.Checked
                };

                bool result = bacSiBUS.ThemBacSi(bs);
                if (result)
                {
                    MessageBox.Show("Thêm bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNguoiDungCombo(); // refresh combo: remove used user
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Thêm bác sĩ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimKiem.Text.Trim().ToLower();
                if (string.IsNullOrEmpty(keyword))
                {
                    foreach (DataGridViewRow row in dgvBacSi.Rows) row.Visible = true;
                    return;
                }

                foreach (DataGridViewRow row in dgvBacSi.Rows)
                {
                    bool match = false;
                    if (row.Cells["colHoTen"].Value != null && row.Cells["colHoTen"].Value.ToString().ToLower().Contains(keyword)) match = true;
                    if (!match && row.Cells["colChuyenKhoa"].Value != null && row.Cells["colChuyenKhoa"].Value.ToString().ToLower().Contains(keyword)) match = true;
                    if (!match && row.Cells["colEmail"].Value != null && row.Cells["colEmail"].Value.ToString().ToLower().Contains(keyword)) match = true;
                    if (!match && row.Cells["colCMND"].Value != null && row.Cells["colCMND"].Value.ToString().ToLower().Contains(keyword)) match = true;
                    if (!match && row.Cells["colSDT"].Value != null && row.Cells["colSDT"].Value.ToString().ToLower().Contains(keyword)) match = true;
                    row.Visible = match;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtTimKiem.Clear();
            foreach (DataGridViewRow row in dgvBacSi.Rows) row.Visible = true;
            LoadNguoiDungCombo();
        }

        private void txtMaBS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenBS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKinhNghiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChuyenKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            maBSDangChon = "";
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            cmbGioiTinh.SelectedIndex = -1;
            txtSDT.Clear();
            txtEmail.Clear();
            txtCMND.Clear();
            txtDiaChi.Clear();
            txtChuyenKhoa.Clear();
            txtKinhNghiem.Clear();
            chkTrangThai.Checked = true;
            cmbNguoiDung.SelectedIndex = -1;
            txtHoTen.Focus();
        }
    }
}
