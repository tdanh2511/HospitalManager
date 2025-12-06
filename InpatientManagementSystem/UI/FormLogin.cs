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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Kiểm tra đăng nhập (Hard-code để demo, sau này kết nối database)
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = "";
            string fullName = "";

            // Tài khoản mẫu
            if (username == "admin" && password == "admin")
            {
                role = "Admin";
                fullName = "Quản trị viên";
            }
            else if (username == "bacsi" && password == "123")
            {
                role = "BacSi";
                fullName = "Bác sĩ Nguyễn Văn A";
            }
            else if (username == "letan" && password == "123")
            {
                role = "LeTan";
                fullName = "Lễ tân Trần Thị B";
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            // Đăng nhập thành công
            MessageBox.Show($"Đăng nhập thành công!\nXin chào {fullName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mở FormMain với quyền tương ứng
            FormMain mainForm = new FormMain(role, fullName);
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblSystemName_Click(object sender, EventArgs e)
        {

        }
    }
}
