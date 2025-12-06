using InpatientManagementSystem.BUS;
using InpatientManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quan_li_benh_vien
{
    public partial class FormQuanLyNguoiDung : Form
    {
        private NguoiDungBUS nguoiDungBUS = new NguoiDungBUS();
        private string maNguoiDungDangChon = "";

        public FormQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void FormQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
            ClearForm();
        }

        // Thêm người dùng
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NguoiDungDTO nd = new NguoiDungDTO
                {
                    TenDangNhap = txtTenDangNhap.Text.Trim(),
                    MatKhau = txtMatKhau.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    VaiTro = cbVaiTro.Text,
                    Email = txtEmail.Text.Trim(),
                    SoDienThoai = txtSoDienThoai.Text.Trim(),
                    TrangThai = chkTrangThai.Checked
                };

                bool result = nguoiDungBUS.ThemNguoiDung(nd);

                if (result)
                {
                    MessageBox.Show("Thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSach();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sửa người dùng
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(maNguoiDungDangChon))
                {
                    MessageBox.Show("Vui lòng chọn người dùng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NguoiDungDTO nd = new NguoiDungDTO
                {
                    MaNguoiDung = maNguoiDungDangChon,
                    TenDangNhap = txtTenDangNhap.Text.Trim(),
                    MatKhau = txtMatKhau.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    VaiTro = cbVaiTro.Text,
                    Email = txtEmail.Text.Trim(),
                    SoDienThoai = txtSoDienThoai.Text.Trim(),
                    TrangThai = chkTrangThai.Checked
                };

                bool result = nguoiDungBUS.CapNhatNguoiDung(nd);

                if (result)
                {
                    MessageBox.Show("Cập nhật người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSach();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Cập nhật người dùng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa người dùng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(maNguoiDungDangChon))
                {
                    MessageBox.Show("Vui lòng chọn người dùng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show(
                   "Bạn có chắc chắn muốn xóa người dùng này?",
                    "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    bool result = nguoiDungBUS.XoaNguoiDung(maNguoiDungDangChon);

                    if (result)
                    {
                        MessageBox.Show("Xóa người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSach();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa người dùng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tìm kiếm người dùng
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimKiem.Text.Trim();
                List<NguoiDungDTO> danhSach = nguoiDungBUS.TimKiemNguoiDung(keyword);

                dgvNguoiDung.DataSource = null;
                dgvNguoiDung.DataSource = danhSach;

                CustomizeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSach();
            ClearForm();
            txtTimKiem.Clear();
        }

        // Load danh sách
        private void LoadDanhSach()
        {
            try
            {
                List<NguoiDungDTO> danhSach = nguoiDungBUS.LayDanhSachNguoiDung();
                dgvNguoiDung.DataSource = null;
                dgvNguoiDung.DataSource = danhSach;

                CustomizeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tùy chỉnh DataGridView
        private void CustomizeDataGridView()
        {
            if (dgvNguoiDung.Columns.Count > 0)
            {
                dgvNguoiDung.Columns["MaNguoiDung"].HeaderText = "Mã ND";
                dgvNguoiDung.Columns["MaNguoiDung"].Width = 80;

                dgvNguoiDung.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
                dgvNguoiDung.Columns["TenDangNhap"].Width = 120;

                dgvNguoiDung.Columns["MatKhau"].Visible = false; // Ẩn mật khẩu

                dgvNguoiDung.Columns["HoTen"].HeaderText = "Họ và tên";
                dgvNguoiDung.Columns["HoTen"].Width = 150;

                dgvNguoiDung.Columns["VaiTro"].HeaderText = "Vai trò";
                dgvNguoiDung.Columns["VaiTro"].Width = 100;

                dgvNguoiDung.Columns["Email"].HeaderText = "Email";
                dgvNguoiDung.Columns["Email"].Width = 150;

                dgvNguoiDung.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
                dgvNguoiDung.Columns["SoDienThoai"].Width = 100;

                dgvNguoiDung.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvNguoiDung.Columns["TrangThai"].Width = 80;

                dgvNguoiDung.Columns["NgayTao"].HeaderText = "Ngày tạo";
                dgvNguoiDung.Columns["NgayTao"].Width = 100;
                dgvNguoiDung.Columns["NgayTao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        // Click vào dòng trong DataGridView
        private void dgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvNguoiDung.Rows[e.RowIndex];

                    maNguoiDungDangChon = row.Cells["MaNguoiDung"].Value.ToString();
                    txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                    txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                    txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                    cbVaiTro.Text = row.Cells["VaiTro"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                    chkTrangThai.Checked = Convert.ToBoolean(row.Cells["TrangThai"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa form
        private void ClearForm()
        {
            maNguoiDungDangChon = "";
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSoDienThoai.Clear();
            cbVaiTro.SelectedIndex = -1;
            chkTrangThai.Checked = true;
            txtTenDangNhap.Focus();
        }

        private void groupBoxInfo_Enter(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
