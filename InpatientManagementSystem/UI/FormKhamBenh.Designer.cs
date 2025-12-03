namespace Quan_li_benh_vien
{
    partial class FormKhamBenh
    {
  private System.ComponentModel.IContainer components = null;
protected override void Dispose(bool disposing)
{
     if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
  }

  private void InitializeComponent()
     {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxBenhNhan = new System.Windows.Forms.GroupBox();
            this.btnXemHS = new System.Windows.Forms.Button();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cboBenhNhan = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblBenhNhan = new System.Windows.Forms.Label();
            this.groupBoxToDieuTri = new System.Windows.Forms.GroupBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txtDienBien = new System.Windows.Forms.TextBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblDienBien = new System.Windows.Forms.Label();
            this.groupBoxThuoc = new System.Windows.Forms.GroupBox();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.txtLieuLuong = new System.Windows.Forms.TextBox();
            this.cboThuoc = new System.Windows.Forms.ComboBox();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.colThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLieuLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLieuLuong = new System.Windows.Forms.Label();
            this.lblThuoc = new System.Windows.Forms.Label();
            this.groupBoxDichVu = new System.Windows.Forms.GroupBox();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.cboDichVu = new System.Windows.Forms.ComboBox();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.colDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.lblTongChi = new System.Windows.Forms.Label();
            this.txtTongChi = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.groupBoxBenhNhan.SuspendLayout();
            this.groupBoxToDieuTri.SuspendLayout();
            this.groupBoxThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.groupBoxDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(932, 49);
            this.panelTop.TabIndex = 8;
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
            this.lblTitle.Text = "🩺 KHÁM CHỮA BỆNH";
            // 
            // groupBoxBenhNhan
            // 
            this.groupBoxBenhNhan.Controls.Add(this.btnXemHS);
            this.groupBoxBenhNhan.Controls.Add(this.txtPhong);
            this.groupBoxBenhNhan.Controls.Add(this.txtKhoa);
            this.groupBoxBenhNhan.Controls.Add(this.txtHoTen);
            this.groupBoxBenhNhan.Controls.Add(this.cboBenhNhan);
            this.groupBoxBenhNhan.Controls.Add(this.lblPhong);
            this.groupBoxBenhNhan.Controls.Add(this.lblKhoa);
            this.groupBoxBenhNhan.Controls.Add(this.lblHoTen);
            this.groupBoxBenhNhan.Controls.Add(this.lblBenhNhan);
            this.groupBoxBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxBenhNhan.Location = new System.Drawing.Point(15, 61);
            this.groupBoxBenhNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxBenhNhan.Name = "groupBoxBenhNhan";
            this.groupBoxBenhNhan.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxBenhNhan.Size = new System.Drawing.Size(868, 89);
            this.groupBoxBenhNhan.TabIndex = 7;
            this.groupBoxBenhNhan.TabStop = false;
            this.groupBoxBenhNhan.Text = "Bệnh nhân đang điều trị";
            // 
            // btnXemHS
            // 
            this.btnXemHS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnXemHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemHS.ForeColor = System.Drawing.Color.White;
            this.btnXemHS.Location = new System.Drawing.Point(369, 24);
            this.btnXemHS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemHS.Name = "btnXemHS";
            this.btnXemHS.Size = new System.Drawing.Size(75, 23);
            this.btnXemHS.TabIndex = 0;
            this.btnXemHS.Text = "Xem HS";
            this.btnXemHS.UseVisualStyleBackColor = false;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(559, 56);
            this.txtPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(84, 23);
            this.txtPhong.TabIndex = 1;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(411, 56);
            this.txtKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.ReadOnly = true;
            this.txtKhoa.Size = new System.Drawing.Size(91, 23);
            this.txtKhoa.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(112, 54);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(211, 23);
            this.txtHoTen.TabIndex = 3;
            // 
            // cboBenhNhan
            // 
            this.cboBenhNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBenhNhan.FormattingEnabled = true;
            this.cboBenhNhan.Location = new System.Drawing.Point(112, 24);
            this.cboBenhNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBenhNhan.Name = "cboBenhNhan";
            this.cboBenhNhan.Size = new System.Drawing.Size(211, 24);
            this.cboBenhNhan.TabIndex = 4;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(508, 58);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(53, 17);
            this.lblPhong.TabIndex = 5;
            this.lblPhong.Text = "Phòng:";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(366, 58);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(45, 17);
            this.lblKhoa.TabIndex = 6;
            this.lblKhoa.Text = "Khoa:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(15, 54);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(54, 17);
            this.lblHoTen.TabIndex = 7;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblBenhNhan
            // 
            this.lblBenhNhan.AutoSize = true;
            this.lblBenhNhan.Location = new System.Drawing.Point(15, 27);
            this.lblBenhNhan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBenhNhan.Name = "lblBenhNhan";
            this.lblBenhNhan.Size = new System.Drawing.Size(68, 17);
            this.lblBenhNhan.TabIndex = 8;
            this.lblBenhNhan.Text = "Chọn BN:";
            // 
            // groupBoxToDieuTri
            // 
            this.groupBoxToDieuTri.Controls.Add(this.dtpNgay);
            this.groupBoxToDieuTri.Controls.Add(this.txtDienBien);
            this.groupBoxToDieuTri.Controls.Add(this.lblNgay);
            this.groupBoxToDieuTri.Controls.Add(this.lblDienBien);
            this.groupBoxToDieuTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxToDieuTri.Location = new System.Drawing.Point(15, 188);
            this.groupBoxToDieuTri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxToDieuTri.Name = "groupBoxToDieuTri";
            this.groupBoxToDieuTri.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxToDieuTri.Size = new System.Drawing.Size(868, 106);
            this.groupBoxToDieuTri.TabIndex = 6;
            this.groupBoxToDieuTri.TabStop = false;
            this.groupBoxToDieuTri.Text = "Tờ điều trị";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(167, 20);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(151, 23);
            this.dtpNgay.TabIndex = 0;
            // 
            // txtDienBien
            // 
            this.txtDienBien.Location = new System.Drawing.Point(167, 53);
            this.txtDienBien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDienBien.Multiline = true;
            this.txtDienBien.Name = "txtDienBien";
            this.txtDienBien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDienBien.Size = new System.Drawing.Size(594, 45);
            this.txtDienBien.TabIndex = 1;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(15, 27);
            this.lblNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(45, 17);
            this.lblNgay.TabIndex = 2;
            this.lblNgay.Text = "Ngày:";
            // 
            // lblDienBien
            // 
            this.lblDienBien.AutoSize = true;
            this.lblDienBien.Location = new System.Drawing.Point(15, 55);
            this.lblDienBien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDienBien.Name = "lblDienBien";
            this.lblDienBien.Size = new System.Drawing.Size(145, 17);
            this.lblDienBien.TabIndex = 3;
            this.lblDienBien.Text = "Diễn biến/Chẩn đoán:";
            // 
            // groupBoxThuoc
            // 
            this.groupBoxThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxThuoc.Controls.Add(this.btnThemThuoc);
            this.groupBoxThuoc.Controls.Add(this.txtLieuLuong);
            this.groupBoxThuoc.Controls.Add(this.cboThuoc);
            this.groupBoxThuoc.Controls.Add(this.dgvThuoc);
            this.groupBoxThuoc.Controls.Add(this.lblLieuLuong);
            this.groupBoxThuoc.Controls.Add(this.lblThuoc);
            this.groupBoxThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxThuoc.Location = new System.Drawing.Point(15, 327);
            this.groupBoxThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxThuoc.Name = "groupBoxThuoc";
            this.groupBoxThuoc.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxThuoc.Size = new System.Drawing.Size(542, 195);
            this.groupBoxThuoc.TabIndex = 5;
            this.groupBoxThuoc.TabStop = false;
            this.groupBoxThuoc.Text = "Chỉ định thuốc";
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnThemThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemThuoc.ForeColor = System.Drawing.Color.White;
            this.btnThemThuoc.Location = new System.Drawing.Point(453, 19);
            this.btnThemThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(82, 29);
            this.btnThemThuoc.TabIndex = 0;
            this.btnThemThuoc.Text = "+ Thêm";
            this.btnThemThuoc.UseVisualStyleBackColor = false;
            // 
            // txtLieuLuong
            // 
            this.txtLieuLuong.Location = new System.Drawing.Point(216, 22);
            this.txtLieuLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLieuLuong.Name = "txtLieuLuong";
            this.txtLieuLuong.Size = new System.Drawing.Size(85, 23);
            this.txtLieuLuong.TabIndex = 1;
            // 
            // cboThuoc
            // 
            this.cboThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuoc.FormattingEnabled = true;
            this.cboThuoc.Location = new System.Drawing.Point(57, 23);
            this.cboThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboThuoc.Name = "cboThuoc";
            this.cboThuoc.Size = new System.Drawing.Size(91, 24);
            this.cboThuoc.TabIndex = 2;
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AllowUserToAddRows = false;
            this.dgvThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThuoc,
            this.colLieuLuong,
            this.colDonVi,
            this.colGiaThuoc});
            this.dgvThuoc.Location = new System.Drawing.Point(8, 53);
            this.dgvThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.Size = new System.Drawing.Size(527, 134);
            this.dgvThuoc.TabIndex = 3;
            // 
            // colThuoc
            // 
            this.colThuoc.HeaderText = "Thuốc";
            this.colThuoc.MinimumWidth = 6;
            this.colThuoc.Name = "colThuoc";
            // 
            // colLieuLuong
            // 
            this.colLieuLuong.HeaderText = "Liều lượng";
            this.colLieuLuong.MinimumWidth = 6;
            this.colLieuLuong.Name = "colLieuLuong";
            // 
            // colDonVi
            // 
            this.colDonVi.HeaderText = "Đơn vị";
            this.colDonVi.MinimumWidth = 6;
            this.colDonVi.Name = "colDonVi";
            // 
            // colGiaThuoc
            // 
            this.colGiaThuoc.HeaderText = "Giá";
            this.colGiaThuoc.MinimumWidth = 6;
            this.colGiaThuoc.Name = "colGiaThuoc";
            // 
            // lblLieuLuong
            // 
            this.lblLieuLuong.AutoSize = true;
            this.lblLieuLuong.Location = new System.Drawing.Point(173, 26);
            this.lblLieuLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLieuLuong.Name = "lblLieuLuong";
            this.lblLieuLuong.Size = new System.Drawing.Size(39, 17);
            this.lblLieuLuong.TabIndex = 4;
            this.lblLieuLuong.Text = "Liều:";
            // 
            // lblThuoc
            // 
            this.lblThuoc.AutoSize = true;
            this.lblThuoc.Location = new System.Drawing.Point(8, 26);
            this.lblThuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThuoc.Name = "lblThuoc";
            this.lblThuoc.Size = new System.Drawing.Size(52, 17);
            this.lblThuoc.TabIndex = 5;
            this.lblThuoc.Text = "Thuốc:";
            // 
            // groupBoxDichVu
            // 
            this.groupBoxDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDichVu.Controls.Add(this.btnThemDV);
            this.groupBoxDichVu.Controls.Add(this.cboDichVu);
            this.groupBoxDichVu.Controls.Add(this.dgvDichVu);
            this.groupBoxDichVu.Controls.Add(this.lblDichVu);
            this.groupBoxDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxDichVu.Location = new System.Drawing.Point(565, 327);
            this.groupBoxDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDichVu.Name = "groupBoxDichVu";
            this.groupBoxDichVu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDichVu.Size = new System.Drawing.Size(352, 195);
            this.groupBoxDichVu.TabIndex = 4;
            this.groupBoxDichVu.TabStop = false;
            this.groupBoxDichVu.Text = "Chỉ định dịch vụ/XN";
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnThemDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDV.ForeColor = System.Drawing.Color.White;
            this.btnThemDV.Location = new System.Drawing.Point(265, 19);
            this.btnThemDV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(81, 28);
            this.btnThemDV.TabIndex = 0;
            this.btnThemDV.Text = "+ Thêm";
            this.btnThemDV.UseVisualStyleBackColor = false;
            // 
            // cboDichVu
            // 
            this.cboDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDichVu.FormattingEnabled = true;
            this.cboDichVu.Location = new System.Drawing.Point(75, 24);
            this.cboDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDichVu.Name = "cboDichVu";
            this.cboDichVu.Size = new System.Drawing.Size(174, 24);
            this.cboDichVu.TabIndex = 1;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDichVu,
            this.colGiaDV});
            this.dgvDichVu.Location = new System.Drawing.Point(8, 53);
            this.dgvDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.Size = new System.Drawing.Size(338, 134);
            this.dgvDichVu.TabIndex = 2;
            // 
            // colDichVu
            // 
            this.colDichVu.HeaderText = "Dịch vụ";
            this.colDichVu.MinimumWidth = 6;
            this.colDichVu.Name = "colDichVu";
            // 
            // colGiaDV
            // 
            this.colGiaDV.HeaderText = "Giá";
            this.colGiaDV.MinimumWidth = 6;
            this.colGiaDV.Name = "colGiaDV";
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.Location = new System.Drawing.Point(8, 26);
            this.lblDichVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(59, 17);
            this.lblDichVu.TabIndex = 3;
            this.lblDichVu.Text = "Dịch vụ:";
            // 
            // lblTongChi
            // 
            this.lblTongChi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTongChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongChi.Location = new System.Drawing.Point(258, 557);
            this.lblTongChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongChi.Name = "lblTongChi";
            this.lblTongChi.Size = new System.Drawing.Size(201, 20);
            this.lblTongChi.TabIndex = 3;
            this.lblTongChi.Text = "Tổng chi phí hôm nay:";
            this.lblTongChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTongChi
            // 
            this.txtTongChi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTongChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.txtTongChi.Location = new System.Drawing.Point(473, 557);
            this.txtTongChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTongChi.Name = "txtTongChi";
            this.txtTongChi.ReadOnly = true;
            this.txtTongChi.Size = new System.Drawing.Size(128, 24);
            this.txtTongChi.TabIndex = 2;
            this.txtTongChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(319, 594);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(140, 37);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "💾 Lưu tờ điều trị";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(473, 594);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(128, 37);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "❌ Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // FormKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(932, 647);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTongChi);
            this.Controls.Add(this.lblTongChi);
            this.Controls.Add(this.groupBoxDichVu);
            this.Controls.Add(this.groupBoxThuoc);
            this.Controls.Add(this.groupBoxToDieuTri);
            this.Controls.Add(this.groupBoxBenhNhan);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormKhamBenh";
            this.panelTop.ResumeLayout(false);
            this.groupBoxBenhNhan.ResumeLayout(false);
            this.groupBoxBenhNhan.PerformLayout();
            this.groupBoxToDieuTri.ResumeLayout(false);
            this.groupBoxToDieuTri.PerformLayout();
            this.groupBoxThuoc.ResumeLayout(false);
            this.groupBoxThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.groupBoxDichVu.ResumeLayout(false);
            this.groupBoxDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

}

 private System.Windows.Forms.Panel panelTop;
     private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxBenhNhan;
        private System.Windows.Forms.Button btnXemHS;
 private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.TextBox txtHoTen;
      private System.Windows.Forms.ComboBox cboBenhNhan;
    private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblBenhNhan;
        private System.Windows.Forms.GroupBox groupBoxToDieuTri;
    private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.TextBox txtDienBien;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblDienBien;
 private System.Windows.Forms.GroupBox groupBoxThuoc;
   private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.TextBox txtLieuLuong;
        private System.Windows.Forms.ComboBox cboThuoc;
        private System.Windows.Forms.DataGridView dgvThuoc;
 private System.Windows.Forms.DataGridViewTextBoxColumn colThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLieuLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaThuoc;
   private System.Windows.Forms.Label lblLieuLuong;
   private System.Windows.Forms.Label lblThuoc;
        private System.Windows.Forms.GroupBox groupBoxDichVu;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.ComboBox cboDichVu;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaDV;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.Label lblTongChi;
        private System.Windows.Forms.TextBox txtTongChi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}
