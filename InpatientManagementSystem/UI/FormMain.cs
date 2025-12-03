using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_li_benh_vien
{
    public partial class FormMain : Form
    {
        private string userRole; // Admin, BacSi, LeTan
   private string userName;
        private Form currentChildForm;

        public FormMain(string role, string name)
   {
        InitializeComponent();
       userRole = role;
     userName = name;
        LoadUserInterface();
   }

 private void LoadUserInterface()
        {
            // Hiển thị tên người dùng và vai trò
     lblUserInfo.Text = $"Xin chào: {userName} ({userRole})";

        // Ẩn/hiện menu dựa trên quyền
      SetMenuVisibility();
   }

   private void SetMenuVisibility()
    {
    // Tất cả role đều thấy Đăng xuất
     btnLogout.Visible = true;

      // Admin: Thấy tất cả
            if (userRole == "Admin")
   {
        btnQuanLyNguoiDung.Visible = true;
         btnDanhMucThuoc.Visible = true;
       btnDanhMucDichVu.Visible = true;
       btnDanhMucPhong.Visible = true;
                btnBenhNhan.Visible = true;
           btnNhapVien.Visible = true;
    btnBacSi.Visible = true;
          btnKhamBenh.Visible = true;
          btnThanhToan.Visible = true;
       btnXuatVien.Visible = true;
       btnThongKe.Visible = true;
       }
    // Bác sĩ: Chỉ thấy phần Khám chữa bệnh
       else if (userRole == "BacSi")
    {
    btnQuanLyNguoiDung.Visible = false;
    btnDanhMucThuoc.Visible = false;
       btnDanhMucDichVu.Visible = false;
   btnDanhMucPhong.Visible = false;
     btnBenhNhan.Visible = false;
     btnNhapVien.Visible = false;
          btnBacSi.Visible = true;
btnKhamBenh.Visible = true;
      btnThanhToan.Visible = false;
  btnXuatVien.Visible = false;
  btnThongKe.Visible = true;
            }
            // Lễ tân: Tiếp nhận BN, Thanh toán, Xuất viện
       else if (userRole == "LeTan")
    {
btnQuanLyNguoiDung.Visible = false;
      btnDanhMucThuoc.Visible = false;
     btnDanhMucDichVu.Visible = false;
          btnDanhMucPhong.Visible = false;
     btnBenhNhan.Visible = true;
        btnNhapVien.Visible = true;
    btnBacSi.Visible = false;
             btnKhamBenh.Visible = false;
     btnThanhToan.Visible = true;
       btnXuatVien.Visible = true;
   btnThongKe.Visible = true;
 }
        }

 private void OpenChildForm(Form childForm, string title)
   {
      // Đóng và dispose form con hiện tại nếu có
  if (currentChildForm != null)
      {
         currentChildForm.Close();
            currentChildForm.Dispose();
      }

     // Xóa tất cả controls trong panelContent
        panelContent.Controls.Clear();

       currentChildForm = childForm;
       lblMainTitle.Text = title;

        // Cấu hình form con
 childForm.TopLevel = false;
     childForm.FormBorderStyle = FormBorderStyle.None;
   childForm.Dock = DockStyle.Fill;
        
        // Thêm form con vào panel và hiển thị
  panelContent.Controls.Add(childForm);
  panelContent.Tag = childForm;
      childForm.BringToFront();
        childForm.Show();
        }

   // Event handlers cho các nút menu
   private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
  {
   OpenChildForm(new FormQuanLyNguoiDung(), "QUẢN LÝ NGƯỜI DÙNG");
    }

  private void btnDanhMucThuoc_Click(object sender, EventArgs e)
 {
  OpenChildForm(new FormDanhMucThuoc(), "DANH MỤC THUỐC");
   }

        private void btnDanhMucDichVu_Click(object sender, EventArgs e)
     {
     OpenChildForm(new FormDanhMucDichVu(), "DANH MỤC DỊCH VỤ");
 }

        private void btnDanhMucPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhMucPhong(), "DANH MỤC PHÒNG");
      }

   private void btnBenhNhan_Click(object sender, EventArgs e)
  {
      OpenChildForm(new FormBenhNhan(), "QUẢN LÝ BỆNH NHÂN");
  }

    private void btnNhapVien_Click(object sender, EventArgs e)
     {
       OpenChildForm(new FormNhapVien(), "NHẬP VIỆN");
        }

        private void btnBacSi_Click(object sender, EventArgs e)
        {
        // Mở Form2 (Quản lý bác sĩ)
        OpenChildForm(new FormQuanLyBacSi(), "QUẢN LÝ BÁC SĨ");
   }

     private void btnKhamBenh_Click(object sender, EventArgs e)
   {
      OpenChildForm(new FormKhamBenh(), "KHÁM CHỮA BỆNH");
        }

   private void btnThanhToan_Click(object sender, EventArgs e)
 {
            OpenChildForm(new FormThanhToan(), "THANH TOÁN VIỆN PHÍ");
        }

        private void btnXuatVien_Click(object sender, EventArgs e)
     {
       OpenChildForm(new FormXuatVien(), "XUẤT VIỆN");
 }

 private void btnThongKe_Click(object sender, EventArgs e)
     {
   OpenChildForm(new FormThongKe(), "THỐNG KÊ & BÁO CÁO");
   }

        private void btnLogout_Click(object sender, EventArgs e)
        {
     DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn đăng xuất?",
    "Xác nhận",
          MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
  );

            if (result == DialogResult.Yes)
       {
         this.Hide();
        FormLogin loginForm = new FormLogin();
       loginForm.ShowDialog();
       this.Close();
   }
 }
    }
}
