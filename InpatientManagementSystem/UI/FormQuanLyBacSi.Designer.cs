namespace Quan_li_benh_vien
{
    partial class FormQuanLyBacSi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.cmbMaND = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKinhNghiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtChuyenKhoa = new System.Windows.Forms.TextBox();
            this.lblChuyenKhoa = new System.Windows.Forms.Label();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvBacSi = new System.Windows.Forms.DataGridView();
            this.colMaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKinhNghiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBoxThongTin.SuspendLayout();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Controls.Add(this.cmbMaND);
            this.groupBoxThongTin.Controls.Add(this.label4);
            this.groupBoxThongTin.Controls.Add(this.label2);
            this.groupBoxThongTin.Controls.Add(this.txtHoTen);
            this.groupBoxThongTin.Controls.Add(this.label3);
            this.groupBoxThongTin.Controls.Add(this.txtKinhNghiem);
            this.groupBoxThongTin.Controls.Add(this.label1);
            this.groupBoxThongTin.Controls.Add(this.txtDiaChi);
            this.groupBoxThongTin.Controls.Add(this.lblDiaChi);
            this.groupBoxThongTin.Controls.Add(this.txtCMND);
            this.groupBoxThongTin.Controls.Add(this.lblCMND);
            this.groupBoxThongTin.Controls.Add(this.lblEmail);
            this.groupBoxThongTin.Controls.Add(this.cmbGioiTinh);
            this.groupBoxThongTin.Controls.Add(this.lblGioiTinh);
            this.groupBoxThongTin.Controls.Add(this.dtpNgaySinh);
            this.groupBoxThongTin.Controls.Add(this.lblNgaySinh);
            this.groupBoxThongTin.Controls.Add(this.txtChuyenKhoa);
            this.groupBoxThongTin.Controls.Add(this.lblChuyenKhoa);
            this.groupBoxThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThongTin.Location = new System.Drawing.Point(15, 60);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Size = new System.Drawing.Size(700, 240);
            this.groupBoxThongTin.TabIndex = 0;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Thông Tin Bác Sĩ";
            // 
            // cmbMaND
            // 
            this.cmbMaND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaND.FormattingEnabled = true;
            this.cmbMaND.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác",
            "Nam",
            "Nữ",
            "Khác"});
            this.cmbMaND.Location = new System.Drawing.Point(132, 59);
            this.cmbMaND.Name = "cmbMaND";
            this.cmbMaND.Size = new System.Drawing.Size(166, 24);
            this.cmbMaND.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mã ND:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 21;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(132, 106);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(166, 23);
            this.txtHoTen.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Họ tên:";
            // 
            // txtKinhNghiem
            // 
            this.txtKinhNghiem.Location = new System.Drawing.Point(516, 66);
            this.txtKinhNghiem.Name = "txtKinhNghiem";
            this.txtKinhNghiem.Size = new System.Drawing.Size(160, 23);
            this.txtKinhNghiem.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kinh Nghiệm:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(516, 186);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(160, 23);
            this.txtDiaChi.TabIndex = 16;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(443, 186);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(55, 17);
            this.lblDiaChi.TabIndex = 15;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(516, 146);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(160, 23);
            this.txtCMND.TabIndex = 14;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(406, 149);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(93, 17);
            this.lblCMND.TabIndex = 13;
            this.lblCMND.Text = "CMND/CCCD:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(425, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 17);
            this.lblEmail.TabIndex = 11;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(132, 146);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(73, 24);
            this.cmbGioiTinh.TabIndex = 8;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(22, 152);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(69, 17);
            this.lblGioiTinh.TabIndex = 7;
            this.lblGioiTinh.Text = "Giới Tính:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(132, 186);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(166, 23);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(22, 189);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(77, 17);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // txtChuyenKhoa
            // 
            this.txtChuyenKhoa.Location = new System.Drawing.Point(516, 109);
            this.txtChuyenKhoa.Name = "txtChuyenKhoa";
            this.txtChuyenKhoa.Size = new System.Drawing.Size(160, 23);
            this.txtChuyenKhoa.TabIndex = 4;
            // 
            // lblChuyenKhoa
            // 
            this.lblChuyenKhoa.AutoSize = true;
            this.lblChuyenKhoa.Location = new System.Drawing.Point(406, 112);
            this.lblChuyenKhoa.Name = "lblChuyenKhoa";
            this.lblChuyenKhoa.Size = new System.Drawing.Size(97, 17);
            this.lblChuyenKhoa.TabIndex = 3;
            this.lblChuyenKhoa.Text = "Chuyên Khoa:";
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDanhSach.Controls.Add(this.dgvBacSi);
            this.groupBoxDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDanhSach.Location = new System.Drawing.Point(15, 320);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(1292, 336);
            this.groupBoxDanhSach.TabIndex = 1;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh Sách Bác Sĩ";
            // 
            // dgvBacSi
            // 
            this.dgvBacSi.AllowUserToAddRows = false;
            this.dgvBacSi.AllowUserToDeleteRows = false;
            this.dgvBacSi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBacSi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBacSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBacSi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBS,
            this.colHoTen,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colSDT,
            this.colEmail,
            this.colCMND,
            this.colDiaChi,
            this.colKinhNghiem,
            this.colChuyenKhoa,
            this.colTrangThai});
            this.dgvBacSi.Location = new System.Drawing.Point(6, 25);
            this.dgvBacSi.MultiSelect = false;
            this.dgvBacSi.Name = "dgvBacSi";
            this.dgvBacSi.ReadOnly = true;
            this.dgvBacSi.RowHeadersWidth = 51;
            this.dgvBacSi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBacSi.Size = new System.Drawing.Size(1280, 301);
            this.dgvBacSi.TabIndex = 0;
            // 
            // colMaBS
            // 
            this.colMaBS.HeaderText = "Mã Bác Sĩ";
            this.colMaBS.MinimumWidth = 6;
            this.colMaBS.Name = "colMaBS";
            this.colMaBS.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.HeaderText = "Ngày Sinh";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "SĐT";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            this.colSDT.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colCMND
            // 
            this.colCMND.HeaderText = "CMND/CCCD";
            this.colCMND.MinimumWidth = 6;
            this.colCMND.Name = "colCMND";
            this.colCMND.ReadOnly = true;
            // 
            // colDiaChi
            // 
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            // 
            // colKinhNghiem
            // 
            this.colKinhNghiem.HeaderText = "Kinh Nghiệm";
            this.colKinhNghiem.MinimumWidth = 6;
            this.colKinhNghiem.Name = "colKinhNghiem";
            this.colKinhNghiem.ReadOnly = true;
            this.colKinhNghiem.Visible = false;
            // 
            // colChuyenKhoa
            // 
            this.colChuyenKhoa.HeaderText = "Chuyên Khoa";
            this.colChuyenKhoa.MinimumWidth = 6;
            this.colChuyenKhoa.Name = "colChuyenKhoa";
            this.colChuyenKhoa.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Hoạt Động";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(751, 126);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(928, 126);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(751, 218);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(928, 221);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 40);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblTitle.Location = new System.Drawing.Point(262, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 29);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "QUẢN LÝ BÁC SĨ";
            this.lblTitle.Visible = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(721, 60);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(251, 20);
            this.txtTimKiem.TabIndex = 20;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(978, 53);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 31);
            this.btnTimKiem.TabIndex = 21;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // FormQuanLyBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 620);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Controls.Add(this.groupBoxThongTin);
            this.Name = "FormQuanLyBacSi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bác Sĩ";
            this.Load += new System.EventHandler(this.FormQuanLyBacSi_Load);
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.TextBox txtChuyenKhoa;
        private System.Windows.Forms.Label lblChuyenKhoa;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.DataGridView dgvBacSi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKinhNghiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenKhoa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtKinhNghiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
    }
}