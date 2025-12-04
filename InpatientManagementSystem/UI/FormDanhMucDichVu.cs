using InpatientManagementSystem.BUS;
using InpatientManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quan_li_benh_vien
{
    public partial class FormDanhMucDichVu : Form
    {
        private DichVuBUS dichVuBUS = new DichVuBUS();
        private string maDichVuDangChon = "";

        public FormDanhMucDichVu()
        {
            InitializeComponent();
        }

        private void FormDanhMucDichVu_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
            ClearForm();
        }

        // Thêm dịch vụ
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DichVuDTO dv = new DichVuDTO
                {
                    TenDichVu = txtTenDichVu.Text.Trim(),
                    LoaiDichVu = txtLoaiDichVu.Text.Trim(),
                    DonGia = decimal.Parse(txtDonGia.Text.Trim()),
                    DonViTinh = txtDonViTinh.Text.Trim(),
                    MoTa = txtMoTa.Text.Trim(),
                    TrangThai = chkTrangThai.Checked
                };

                bool result = dichVuBUS.ThemDichVu(dv);

                if (result)
                {
                    MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSach();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sửa dịch vụ
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(maDichVuDangChon))
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DichVuDTO dv = new DichVuDTO
                {
                    MaDichVu = maDichVuDangChon,
                    TenDichVu = txtTenDichVu.Text.Trim(),
                    LoaiDichVu = txtLoaiDichVu.Text.Trim(),
                    DonGia = decimal.Parse(txtDonGia.Text.Trim()),
                    DonViTinh = txtDonViTinh.Text.Trim(),
                    MoTa = txtMoTa.Text.Trim(),
                    TrangThai = chkTrangThai.Checked
                };

                bool result = dichVuBUS.CapNhatDichVu(dv);

                if (result)
                {
                    MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSach();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Cập nhật dịch vụ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa dịch vụ
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(maDichVuDangChon))
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa dịch vụ này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    bool result = dichVuBUS.XoaDichVu(maDichVuDangChon);

                    if (result)
                    {
                        MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSach();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa dịch vụ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tìm kiếm dịch vụ
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimKiem.Text.Trim();
                List<DichVuDTO> danhSach = dichVuBUS.TimKiemDichVu(keyword);

                dgvDichVu.DataSource = null;
                dgvDichVu.DataSource = danhSach;

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
                List<DichVuDTO> danhSach = dichVuBUS.LayDanhSachDichVu();
                dgvDichVu.DataSource = null;
                dgvDichVu.DataSource = danhSach;

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
            if (dgvDichVu.Columns.Count > 0)
            {
                dgvDichVu.Columns["MaDichVu"].HeaderText = "Mã DV";
                dgvDichVu.Columns["MaDichVu"].Width = 80;

                dgvDichVu.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
                dgvDichVu.Columns["TenDichVu"].Width = 200;

                dgvDichVu.Columns["LoaiDichVu"].HeaderText = "Loại dịch vụ";
                dgvDichVu.Columns["LoaiDichVu"].Width = 150;

                dgvDichVu.Columns["DonGia"].HeaderText = "Đơn giá";
                dgvDichVu.Columns["DonGia"].Width = 100;
                dgvDichVu.Columns["DonGia"].DefaultCellStyle.Format = "N0";

                dgvDichVu.Columns["DonViTinh"].HeaderText = "ĐVT";
                dgvDichVu.Columns["DonViTinh"].Width = 60;

                dgvDichVu.Columns["MoTa"].HeaderText = "Mô tả";
                dgvDichVu.Columns["MoTa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvDichVu.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvDichVu.Columns["TrangThai"].Width = 80;
            }
        }

        // Click vào dòng
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];

                    maDichVuDangChon = row.Cells["MaDichVu"].Value.ToString();
                    txtTenDichVu.Text = row.Cells["TenDichVu"].Value.ToString();
                    txtLoaiDichVu.Text = row.Cells["LoaiDichVu"].Value.ToString();
                    txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                    txtDonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
                    txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
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
            maDichVuDangChon = "";
            txtTenDichVu.Clear();
            txtLoaiDichVu.Clear();
            txtDonGia.Clear();
            txtDonViTinh.Clear();
            txtMoTa.Clear();
            chkTrangThai.Checked = true;
            txtTenDichVu.Focus();
        }
    }
}
