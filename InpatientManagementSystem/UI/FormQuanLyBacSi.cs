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
        private int maBacSiDangChon = 0;

        public FormQuanLyBacSi()
        {
            InitializeComponent();
        }

        private void FormQuanLyBacSi_Load(object sender, EventArgs e)
        {
            LoadDanhSachBacSi();
            LoadNguoiDungCombo();
            ClearForm();
        }

        // Hiển thị danh sách bác sĩ
        private void LoadDanhSachBacSi()
        {
            try
            {
                List<BacSiDTO> danhSach = bacSiBUS.LayDanhSachBacSi();
                dgvBacSi.DataSource = null;
                dgvBacSi.DataSource = danhSach;

                CustomizeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tùy chỉnh hiển thị DataGridView
        private void CustomizeDataGridView()
        {
            if (dgvBacSi.Columns.Count > 0)
      {
     // CÀI ĐẶT QUAN TRỌNG: Đảm bảo thanh cuộn hoạt động
          dgvBacSi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
       dgvBacSi.ScrollBars = ScrollBars.Both;
     dgvBacSi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
   dgvBacSi.RowTemplate.Height = 30;

     // Đặt tiêu đề và độ rộng cột
   if (dgvBacSi.Columns["MaBacSi"] != null)
                {
dgvBacSi.Columns["MaBacSi"].HeaderText = "Mã BS";
            dgvBacSi.Columns["MaBacSi"].Width = 80;
      dgvBacSi.Columns["MaBacSi"].DisplayIndex = 0;
      }

                if (dgvBacSi.Columns["HoTen"] != null)
      {
        dgvBacSi.Columns["HoTen"].HeaderText = "Họ và Tên";
       dgvBacSi.Columns["HoTen"].Width = 180;
    dgvBacSi.Columns["HoTen"].DisplayIndex = 1;
                }

       if (dgvBacSi.Columns["NgaySinh"] != null)
         {
        dgvBacSi.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
              dgvBacSi.Columns["NgaySinh"].Width = 110;
    dgvBacSi.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
          dgvBacSi.Columns["NgaySinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      dgvBacSi.Columns["NgaySinh"].DisplayIndex = 2;
          }

     if (dgvBacSi.Columns["GioiTinh"] != null)
        {
          dgvBacSi.Columns["GioiTinh"].HeaderText = "Giới Tính";
   dgvBacSi.Columns["GioiTinh"].Width = 90;
          dgvBacSi.Columns["GioiTinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvBacSi.Columns["GioiTinh"].DisplayIndex = 3;
    }

  if (dgvBacSi.Columns["SDT"] != null)
   {
           dgvBacSi.Columns["SDT"].HeaderText = "Số Điện Thoại";
        dgvBacSi.Columns["SDT"].Width = 120;
  dgvBacSi.Columns["SDT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
  dgvBacSi.Columns["SDT"].DisplayIndex = 4;
                }

      if (dgvBacSi.Columns["Email"] != null)
    {
        dgvBacSi.Columns["Email"].HeaderText = "Email";
  dgvBacSi.Columns["Email"].Width = 200;
        dgvBacSi.Columns["Email"].DisplayIndex = 5;
       }

         if (dgvBacSi.Columns["CMNDCCCD"] != null)
       {
         dgvBacSi.Columns["CMNDCCCD"].HeaderText = "CMND/CCCD";
                dgvBacSi.Columns["CMNDCCCD"].Width = 130;
          dgvBacSi.Columns["CMNDCCCD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
     dgvBacSi.Columns["CMNDCCCD"].DisplayIndex = 6;
    }

    if (dgvBacSi.Columns["ChuyenKhoa"] != null)
        {
        dgvBacSi.Columns["ChuyenKhoa"].HeaderText = "Chuyên Khoa";
  dgvBacSi.Columns["ChuyenKhoa"].Width = 150;
        dgvBacSi.Columns["ChuyenKhoa"].DisplayIndex = 7;
           }

       if (dgvBacSi.Columns["KinhNghiem"] != null)
    {
        dgvBacSi.Columns["KinhNghiem"].HeaderText = "Kinh Nghiệm (năm)";
           dgvBacSi.Columns["KinhNghiem"].Width = 130;
            dgvBacSi.Columns["KinhNghiem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
       dgvBacSi.Columns["KinhNghiem"].DisplayIndex = 8;
                }

          if (dgvBacSi.Columns["DiaChi"] != null)
        {
         dgvBacSi.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                  dgvBacSi.Columns["DiaChi"].Width = 250;
                    dgvBacSi.Columns["DiaChi"].DisplayIndex = 9;
        }

    if (dgvBacSi.Columns["TrangThai"] != null)
         {
  dgvBacSi.Columns["TrangThai"].HeaderText = "Trạng Thái";
          dgvBacSi.Columns["TrangThai"].Width = 100;
          dgvBacSi.Columns["TrangThai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
     dgvBacSi.Columns["TrangThai"].DisplayIndex = 10;
            }

  // Ẩn cột MaNguoiDung (không cần thiết hiển thị)
       if (dgvBacSi.Columns["MaNguoiDung"] != null)
             {
         dgvBacSi.Columns["MaNguoiDung"].Visible = false;
            }

      // Cài đặt chung cho DataGridView
       dgvBacSi.AllowUserToAddRows = false;
      dgvBacSi.AllowUserToDeleteRows = false;
        dgvBacSi.ReadOnly = true;
     dgvBacSi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
     dgvBacSi.MultiSelect = false;
             dgvBacSi.RowHeadersVisible = true;
 dgvBacSi.RowHeadersWidth = 30;

                // Cho phép resize cột bằng cách kéo
        dgvBacSi.AllowUserToResizeColumns = true;
                dgvBacSi.AllowUserToResizeRows = false;

     // Đặt màu xen kẽ cho dễ đọc
          dgvBacSi.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
      dgvBacSi.BackgroundColor = System.Drawing.Color.White;

              // Đảm bảo hiển thị đầy đủ các dòng
                dgvBacSi.ColumnHeadersHeight = 35;
          }
        }

        // Load danh sách người dùng chưa là bác sĩ
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
                        string display = $"{u.MaNguoiDung} - {u.HoTen} - {u.TenDangNhap}";
                        items.Add(new KeyValuePair<string, string>(u.MaNguoiDung, display));
                    }
                }

                cmbMaND.DataSource = null;
                cmbMaND.DataSource = items;
                cmbMaND.DisplayMember = "Value";
                cmbMaND.ValueMember = "Key";
                cmbMaND.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Khi chọn người dùng từ combo box
        private void cmbMaND_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbMaND.SelectedIndex < 0) return;

                var selected = cmbMaND.SelectedValue as string;
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

        // Click vào dòng trong DataGridView
        private void dgvBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvBacSi.Rows[e.RowIndex];

                    // Lưu mã bác sĩ đang chọn
                    maBacSiDangChon = Convert.ToInt32(row.Cells["MaBacSi"].Value);

                    // Hiển thị thông tin lên form
                    txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                    cmbGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                    txtSDT.Text = row.Cells["SDT"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    txtCMND.Text = row.Cells["CMNDCCCD"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                    txtKinhNghiem.Text = row.Cells["KinhNghiem"].Value.ToString();
                    txtChuyenKhoa.Text = row.Cells["ChuyenKhoa"].Value.ToString();
                    chkTrangThai.Checked = Convert.ToBoolean(row.Cells["TrangThai"].Value);

                    // Ẩn combo người dùng khi đang sửa
                    cmbMaND.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // THÊM BÁC SĨ
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã chọn người dùng chưa
                if (cmbMaND.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn tài khoản người dùng để liên kết với bác sĩ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra kinh nghiệm
                if (!int.TryParse(txtKinhNghiem.Text.Trim(), out int kinhNghiem) || kinhNghiem < 0)
                {
                    MessageBox.Show("Kinh nghiệm phải là số nguyên lớn hơn hoặc bằng 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy mã người dùng
                string selectedMaNguoiDung = cmbMaND.SelectedValue as string;
                if (!int.TryParse(selectedMaNguoiDung, out int maNguoiDungInt))
                {
                    MessageBox.Show("Mã người dùng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo object bác sĩ
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

                // Thêm vào database
                bool result = bacSiBUS.ThemBacSi(bs);

                if (result)
                {
                    MessageBox.Show("Thêm bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachBacSi();
                    LoadNguoiDungCombo();
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

        // SỬA BÁC SĨ
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã chọn bác sĩ chưa
                if (maBacSiDangChon == 0)
                {
                    MessageBox.Show("Vui lòng chọn bác sĩ cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra kinh nghiệm
                if (!int.TryParse(txtKinhNghiem.Text.Trim(), out int kinhNghiem) || kinhNghiem < 0)
                {
                    MessageBox.Show("Kinh nghiệm phải là số nguyên lớn hơn hoặc bằng 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo object bác sĩ
                BacSiDTO bs = new BacSiDTO
                {
                    MaBacSi = maBacSiDangChon,
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = cmbGioiTinh.Text,
                    CMNDCCCD = txtCMND.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    KinhNghiem = kinhNghiem,
                    ChuyenKhoa = txtChuyenKhoa.Text.Trim()
                };

                // Cập nhật database
                bool result = bacSiBUS.CapNhatBacSi(bs);

                if (result)
                {
                    MessageBox.Show("Cập nhật bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachBacSi();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Cập nhật bác sĩ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // XÓA BÁC SĨ
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã chọn bác sĩ chưa
                if (maBacSiDangChon == 0)
                {
                    MessageBox.Show("Vui lòng chọn bác sĩ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận xóa
                DialogResult confirm = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa bác sĩ này?\n\nLưu ý: Việc xóa bác sĩ có thể ảnh hưởng đến các dữ liệu liên quan.",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    // Xóa khỏi database
                    bool result = bacSiBUS.XoaBacSi(maBacSiDangChon);

                    if (result)
                    {
                        MessageBox.Show("Xóa bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachBacSi();
                        LoadNguoiDungCombo();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa bác sĩ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // TÌM KIẾM BÁC SĨ
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimKiem.Text.Trim();
    
                if (string.IsNullOrEmpty(keyword))
                {
                    // Nếu không có từ khóa, hiển thị tất cả
                    LoadDanhSachBacSi();
                    return;
                }

                // Tìm kiếm bác sĩ
                List<BacSiDTO> ketQua = bacSiBUS.TimKiemBacSi(keyword);

                dgvBacSi.DataSource = null;
                dgvBacSi.DataSource = ketQua;
                CustomizeDataGridView();

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy bác sĩ nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // LÀM MỚI
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachBacSi();
            LoadNguoiDungCombo();
            ClearForm();
            txtTimKiem.Clear();
        }

        // XÓA FORM
        private void ClearForm()
        {
            maBacSiDangChon = 0;
            cmbMaND.SelectedIndex = -1;
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now.AddYears(-25);
            cmbGioiTinh.SelectedIndex = -1;
            txtSDT.Clear();
            txtEmail.Clear();
            txtCMND.Clear();
            txtDiaChi.Clear();
            txtChuyenKhoa.Clear();
            txtKinhNghiem.Clear();
            chkTrangThai.Checked = true;
            cmbMaND.Enabled = true;
            txtHoTen.Focus();
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

        private void dgvBacSi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
