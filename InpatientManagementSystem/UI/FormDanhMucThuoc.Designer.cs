namespace Quan_li_benh_vien
{
    partial class FormDanhMucThuoc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.txtHangSanXuat = new System.Windows.Forms.TextBox();
            this.txtCongDung = new System.Windows.Forms.TextBox();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.lblTenThuoc = new System.Windows.Forms.Label();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.lblHangSanXuat = new System.Windows.Forms.Label();
            this.lblCongDung = new System.Windows.Forms.Label();
            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1045, 49);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "💊 DANH MỤC THUỐC";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.txtTenThuoc);
            this.groupBoxInfo.Controls.Add(this.txtDonViTinh);
            this.groupBoxInfo.Controls.Add(this.txtDonGia);
            this.groupBoxInfo.Controls.Add(this.txtSoLuongTon);
            this.groupBoxInfo.Controls.Add(this.txtHangSanXuat);
            this.groupBoxInfo.Controls.Add(this.txtCongDung);
            this.groupBoxInfo.Controls.Add(this.dtpNgayHetHan);
            this.groupBoxInfo.Controls.Add(this.chkTrangThai);
            this.groupBoxInfo.Controls.Add(this.lblTenThuoc);
            this.groupBoxInfo.Controls.Add(this.lblDonViTinh);
            this.groupBoxInfo.Controls.Add(this.lblDonGia);
            this.groupBoxInfo.Controls.Add(this.lblSoLuongTon);
            this.groupBoxInfo.Controls.Add(this.lblHangSanXuat);
            this.groupBoxInfo.Controls.Add(this.lblCongDung);
            this.groupBoxInfo.Controls.Add(this.lblNgayHetHan);
            this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxInfo.Location = new System.Drawing.Point(15, 65);
            this.groupBoxInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInfo.Size = new System.Drawing.Size(536, 203);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin thuốc";
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(107, 24);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(151, 23);
            this.txtTenThuoc.TabIndex = 0;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(107, 56);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(151, 23);
            this.txtDonViTinh.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(107, 89);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(151, 23);
            this.txtDonGia.TabIndex = 2;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(107, 122);
            this.txtSoLuongTon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(151, 23);
            this.txtSoLuongTon.TabIndex = 3;
            // 
            // txtHangSanXuat
            // 
            this.txtHangSanXuat.Location = new System.Drawing.Point(372, 24);
            this.txtHangSanXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHangSanXuat.Name = "txtHangSanXuat";
            this.txtHangSanXuat.Size = new System.Drawing.Size(151, 23);
            this.txtHangSanXuat.TabIndex = 4;
            // 
            // txtCongDung
            // 
            this.txtCongDung.Location = new System.Drawing.Point(372, 57);
            this.txtCongDung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCongDung.Name = "txtCongDung";
            this.txtCongDung.Size = new System.Drawing.Size(151, 23);
            this.txtCongDung.TabIndex = 5;
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(372, 89);
            this.dtpNgayHetHan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(151, 23);
            this.dtpNgayHetHan.TabIndex = 6;
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Checked = true;
            this.chkTrangThai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrangThai.Location = new System.Drawing.Point(361, 124);
            this.chkTrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(93, 21);
            this.chkTrangThai.TabIndex = 7;
            this.chkTrangThai.Text = "Hoạt động";
            this.chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // lblTenThuoc
            // 
            this.lblTenThuoc.AutoSize = true;
            this.lblTenThuoc.Location = new System.Drawing.Point(15, 27);
            this.lblTenThuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenThuoc.Name = "lblTenThuoc";
            this.lblTenThuoc.Size = new System.Drawing.Size(76, 17);
            this.lblTenThuoc.TabIndex = 8;
            this.lblTenThuoc.Text = "Tên thuốc:";
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Location = new System.Drawing.Point(15, 59);
            this.lblDonViTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(79, 17);
            this.lblDonViTinh.TabIndex = 9;
            this.lblDonViTinh.Text = "Đơn vị tính:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(15, 92);
            this.lblDonGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(61, 17);
            this.lblDonGia.TabIndex = 10;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Location = new System.Drawing.Point(15, 124);
            this.lblSoLuongTon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(92, 17);
            this.lblSoLuongTon.TabIndex = 11;
            this.lblSoLuongTon.Text = "Số lượng tồn:";
            // 
            // lblHangSanXuat
            // 
            this.lblHangSanXuat.AutoSize = true;
            this.lblHangSanXuat.Location = new System.Drawing.Point(271, 27);
            this.lblHangSanXuat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHangSanXuat.Name = "lblHangSanXuat";
            this.lblHangSanXuat.Size = new System.Drawing.Size(103, 17);
            this.lblHangSanXuat.TabIndex = 12;
            this.lblHangSanXuat.Text = "Hãng sản xuất:";
            // 
            // lblCongDung
            // 
            this.lblCongDung.AutoSize = true;
            this.lblCongDung.Location = new System.Drawing.Point(271, 59);
            this.lblCongDung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCongDung.Name = "lblCongDung";
            this.lblCongDung.Size = new System.Drawing.Size(81, 17);
            this.lblCongDung.TabIndex = 13;
            this.lblCongDung.Text = "Công dụng:";
            // 
            // lblNgayHetHan
            // 
            this.lblNgayHetHan.AutoSize = true;
            this.lblNgayHetHan.Location = new System.Drawing.Point(271, 92);
            this.lblNgayHetHan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayHetHan.Name = "lblNgayHetHan";
            this.lblNgayHetHan.Size = new System.Drawing.Size(97, 17);
            this.lblNgayHetHan.TabIndex = 14;
            this.lblNgayHetHan.Text = "Ngày hết hạn:";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxList.Controls.Add(this.dgvThuoc);
            this.groupBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxList.Location = new System.Drawing.Point(15, 284);
            this.groupBoxList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxList.Size = new System.Drawing.Size(1015, 244);
            this.groupBoxList.TabIndex = 2;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Danh sách thuốc";
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AllowUserToAddRows = false;
            this.dgvThuoc.AllowUserToDeleteRows = false;
            this.dgvThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Location = new System.Drawing.Point(8, 24);
            this.dgvThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.ReadOnly = true;
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuoc.Size = new System.Drawing.Size(1000, 211);
            this.dgvThuoc.TabIndex = 0;
            this.dgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(572, 86);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(171, 23);
            this.txtTimKiem.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(747, 83);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(79, 28);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(578, 142);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 32);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(691, 142);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 32);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(578, 207);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 32);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(691, 207);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(82, 32);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // FormDanhMucThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1045, 544);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDanhMucThuoc";
            this.Text = "Danh mục thuốc";
            this.Load += new System.EventHandler(this.FormDanhMucThuoc_Load);
            this.panelTop.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.TextBox txtHangSanXuat;
        private System.Windows.Forms.TextBox txtCongDung;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.Label lblTenThuoc;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.Label lblHangSanXuat;
        private System.Windows.Forms.Label lblCongDung;
        private System.Windows.Forms.Label lblNgayHetHan;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}
