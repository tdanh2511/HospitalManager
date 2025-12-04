using InpatientManagementSystem.BUS;
using InpatientManagementSystem.DTO;
using System;
using System.Windows.Forms;

namespace Quan_li_benh_vien
{
    public partial class FormBenhNhan : Form
    {
        private BenhNhanBUS benhNhanBUS = new BenhNhanBUS();
        public FormBenhNhan()
      {
  InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo object BenhNhan từ dữ liệu người dùng nhập
                BenhNhanDTO bn = new BenhNhanDTO
                {
                    CCCD = txtCCCD.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = cbGioiTinh.Text,
                    SoDienThoai = txtSoDienThoai.Text.Trim(),
                    BHYT = txtBHYT.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim()
                };

                bool result = benhNhanBUS.ThemBenhNhan(bn);

                if (result)
                {
                    MessageBox.Show("Thêm bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSach(); // Hàm load lại DataGridView, bạn tự tạo
                    ClearForm();    // Hàm xóa dữ liệu trong form
                }
                else
                {
                    MessageBox.Show("Thêm bệnh nhân thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtCCCD.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtBHYT.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void LoadDanhSach()
        {
            // Đây là chỗ load lại DataGridView từ DB
            // Bạn có thể tạo hàm GetAll trong DAO và BUS
        }
    }
}
