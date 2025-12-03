namespace Quan_li_benh_vien
{
    partial class FormNhapVien
    {
 private System.ComponentModel.IContainer components = null;
protected override void Dispose(bool disposing)
        {
     if (disposing && (components != null)) components.Dispose();
     base.Dispose(disposing);
        }

        private void InitializeComponent()
  {
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxBenhNhan = new System.Windows.Forms.GroupBox();
            this.btnTimBN = new System.Windows.Forms.Button();
            this.txtTimBN = new System.Windows.Forms.TextBox();
            this.lblTimBN = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.groupBoxDotDieuTri = new System.Windows.Forms.GroupBox();
            this.numBHYT = new System.Windows.Forms.NumericUpDown();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.lblBHYT = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.groupBoxPhong = new System.Windows.Forms.GroupBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBoxBenhNhan.SuspendLayout();
            this.groupBoxDotDieuTri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBHYT)).BeginInit();
            this.groupBoxPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(905, 49);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "🏨 NHẬP VIỆN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxBenhNhan
            // 
            this.groupBoxBenhNhan.Controls.Add(this.btnTimBN);
            this.groupBoxBenhNhan.Controls.Add(this.txtTimBN);
            this.groupBoxBenhNhan.Controls.Add(this.lblTimBN);
            this.groupBoxBenhNhan.Controls.Add(this.txtDiaChi);
            this.groupBoxBenhNhan.Controls.Add(this.txtSDT);
            this.groupBoxBenhNhan.Controls.Add(this.txtNgaySinh);
            this.groupBoxBenhNhan.Controls.Add(this.txtHoTen);
            this.groupBoxBenhNhan.Controls.Add(this.txtCCCD);
            this.groupBoxBenhNhan.Controls.Add(this.lblDiaChi);
            this.groupBoxBenhNhan.Controls.Add(this.lblSDT);
            this.groupBoxBenhNhan.Controls.Add(this.lblNgaySinh);
            this.groupBoxBenhNhan.Controls.Add(this.lblHoTen);
            this.groupBoxBenhNhan.Controls.Add(this.lblCCCD);
            this.groupBoxBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxBenhNhan.Location = new System.Drawing.Point(15, 65);
            this.groupBoxBenhNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxBenhNhan.Name = "groupBoxBenhNhan";
            this.groupBoxBenhNhan.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxBenhNhan.Size = new System.Drawing.Size(875, 114);
            this.groupBoxBenhNhan.TabIndex = 1;
            this.groupBoxBenhNhan.TabStop = false;
            this.groupBoxBenhNhan.Text = "Chọn bệnh nhân";
            // 
            // btnTimBN
            // 
            this.btnTimBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTimBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimBN.ForeColor = System.Drawing.Color.White;
            this.btnTimBN.Location = new System.Drawing.Point(292, 25);
            this.btnTimBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimBN.Name = "btnTimBN";
            this.btnTimBN.Size = new System.Drawing.Size(84, 25);
            this.btnTimBN.TabIndex = 12;
            this.btnTimBN.Text = "🔍Tìm";
            this.btnTimBN.UseVisualStyleBackColor = false;
            // 
            // txtTimBN
            // 
            this.txtTimBN.Location = new System.Drawing.Point(122, 26);
            this.txtTimBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimBN.Name = "txtTimBN";
            this.txtTimBN.Size = new System.Drawing.Size(166, 23);
            this.txtTimBN.TabIndex = 11;
            // 
            // lblTimBN
            // 
            this.lblTimBN.AutoSize = true;
            this.lblTimBN.Location = new System.Drawing.Point(15, 28);
            this.lblTimBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimBN.Name = "lblTimBN";
            this.lblTimBN.Size = new System.Drawing.Size(109, 17);
            this.lblTimBN.TabIndex = 13;
            this.lblTimBN.Text = "Tìm BN (CCCD):";
            this.lblTimBN.Click += new System.EventHandler(this.lblTimBN_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(530, 81);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(256, 23);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(122, 84);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(166, 23);
            this.txtSDT.TabIndex = 9;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(530, 54);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.ReadOnly = true;
            this.txtNgaySinh.Size = new System.Drawing.Size(114, 23);
            this.txtNgaySinh.TabIndex = 8;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(122, 54);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(253, 23);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(530, 25);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.ReadOnly = true;
            this.txtCCCD.Size = new System.Drawing.Size(114, 23);
            this.txtCCCD.TabIndex = 6;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(455, 84);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(55, 17);
            this.lblDiaChi.TabIndex = 14;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(15, 84);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(95, 17);
            this.lblSDT.TabIndex = 15;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(455, 56);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(75, 17);
            this.lblNgaySinh.TabIndex = 16;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(15, 56);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(54, 17);
            this.lblHoTen.TabIndex = 17;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(455, 28);
            this.lblCCCD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(49, 17);
            this.lblCCCD.TabIndex = 18;
            this.lblCCCD.Text = "CCCD:";
            // 
            // groupBoxDotDieuTri
            // 
            this.groupBoxDotDieuTri.Controls.Add(this.numBHYT);
            this.groupBoxDotDieuTri.Controls.Add(this.cboKhoa);
            this.groupBoxDotDieuTri.Controls.Add(this.txtLyDo);
            this.groupBoxDotDieuTri.Controls.Add(this.lblBHYT);
            this.groupBoxDotDieuTri.Controls.Add(this.lblKhoa);
            this.groupBoxDotDieuTri.Controls.Add(this.lblLyDo);
            this.groupBoxDotDieuTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxDotDieuTri.Location = new System.Drawing.Point(15, 191);
            this.groupBoxDotDieuTri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDotDieuTri.Name = "groupBoxDotDieuTri";
            this.groupBoxDotDieuTri.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDotDieuTri.Size = new System.Drawing.Size(875, 146);
            this.groupBoxDotDieuTri.TabIndex = 2;
            this.groupBoxDotDieuTri.TabStop = false;
            this.groupBoxDotDieuTri.Text = "Thông tin đợt điều trị";
            // 
            // numBHYT
            // 
            this.numBHYT.Location = new System.Drawing.Point(112, 114);
            this.numBHYT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numBHYT.Name = "numBHYT";
            this.numBHYT.Size = new System.Drawing.Size(90, 23);
            this.numBHYT.TabIndex = 5;
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Items.AddRange(new object[] {
            "Khoa Nội",
            "Khoa Ngoại",
            "Khoa Sản",
            "Khoa Nhi",
            "Khoa Tai Mũi Họng"});
            this.cboKhoa.Location = new System.Drawing.Point(112, 85);
            this.cboKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(226, 24);
            this.cboKhoa.TabIndex = 4;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(112, 28);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLyDo.Size = new System.Drawing.Size(594, 50);
            this.txtLyDo.TabIndex = 3;
            // 
            // lblBHYT
            // 
            this.lblBHYT.AutoSize = true;
            this.lblBHYT.Location = new System.Drawing.Point(15, 115);
            this.lblBHYT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBHYT.Name = "lblBHYT";
            this.lblBHYT.Size = new System.Drawing.Size(65, 17);
            this.lblBHYT.TabIndex = 6;
            this.lblBHYT.Text = "% BHYT:";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(15, 88);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(92, 17);
            this.lblKhoa.TabIndex = 7;
            this.lblKhoa.Text = "Khoa điều trị:";
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Location = new System.Drawing.Point(15, 31);
            this.lblLyDo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(104, 17);
            this.lblLyDo.TabIndex = 8;
            this.lblLyDo.Text = "Lý do vào viện:";
            // 
            // groupBoxPhong
            // 
            this.groupBoxPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPhong.Controls.Add(this.dgvPhong);
            this.groupBoxPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxPhong.Location = new System.Drawing.Point(15, 349);
            this.groupBoxPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPhong.Name = "groupBoxPhong";
            this.groupBoxPhong.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPhong.Size = new System.Drawing.Size(875, 220);
            this.groupBoxPhong.TabIndex = 3;
            this.groupBoxPhong.TabStop = false;
            this.groupBoxPhong.Text = "Chọn phòng/giường (chỉ hiện phòng trống)";
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhong,
            this.colTenPhong,
            this.colGiaPhong,
            this.colTrangThai});
            this.dgvPhong.Location = new System.Drawing.Point(8, 24);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(860, 188);
            this.dgvPhong.TabIndex = 0;
            // 
            // colMaPhong
            // 
            this.colMaPhong.HeaderText = "Mã phòng";
            this.colMaPhong.MinimumWidth = 6;
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.ReadOnly = true;
            // 
            // colTenPhong
            // 
            this.colTenPhong.HeaderText = "Tên phòng";
            this.colTenPhong.MinimumWidth = 6;
            this.colTenPhong.Name = "colTenPhong";
            this.colTenPhong.ReadOnly = true;
            // 
            // colGiaPhong
            // 
            this.colGiaPhong.HeaderText = "Giá phòng/ngày";
            this.colGiaPhong.MinimumWidth = 6;
            this.colGiaPhong.Name = "colGiaPhong";
            this.colGiaPhong.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(377, 578);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 41);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "✓ Lưu hồ sơ";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // FormNhapVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(905, 626);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBoxPhong);
            this.Controls.Add(this.groupBoxDotDieuTri);
            this.Controls.Add(this.groupBoxBenhNhan);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormNhapVien";
            this.groupBoxBenhNhan.ResumeLayout(false);
            this.groupBoxBenhNhan.PerformLayout();
            this.groupBoxDotDieuTri.ResumeLayout(false);
            this.groupBoxDotDieuTri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBHYT)).EndInit();
            this.groupBoxPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);

}

      private System.Windows.Forms.Label lblTitle;
   private System.Windows.Forms.GroupBox groupBoxBenhNhan;
        private System.Windows.Forms.Button btnTimBN;
        private System.Windows.Forms.TextBox txtTimBN;
        private System.Windows.Forms.Label lblTimBN;
   private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtNgaySinh;
  private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
     private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSDT;
 private System.Windows.Forms.Label lblNgaySinh;
 private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblCCCD;
     private System.Windows.Forms.GroupBox groupBoxDotDieuTri;
    private System.Windows.Forms.NumericUpDown numBHYT;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.TextBox txtLyDo;
    private System.Windows.Forms.Label lblBHYT;
        private System.Windows.Forms.Label lblKhoa;
     private System.Windows.Forms.Label lblLyDo;
     private System.Windows.Forms.GroupBox groupBoxPhong;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
     private System.Windows.Forms.Button btnLuu;
    }
}
