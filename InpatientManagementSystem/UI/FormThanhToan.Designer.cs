namespace Quan_li_benh_vien
{
    partial class FormThanhToan
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
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.numBHYT = new System.Windows.Forms.NumericUpDown();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.txtNgayVao = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cboBenhNhan = new System.Windows.Forms.ComboBox();
            this.lblBHYT = new System.Windows.Forms.Label();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.lblNgayVao = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblBenhNhan = new System.Windows.Forms.Label();
            this.groupBoxChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.colDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTienDV = new System.Windows.Forms.Label();
            this.txtTienDV = new System.Windows.Forms.TextBox();
            this.lblDanhSachDV = new System.Windows.Forms.Label();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.colThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTienThuoc = new System.Windows.Forms.Label();
            this.txtTienThuoc = new System.Windows.Forms.TextBox();
            this.lblDanhSachThuoc = new System.Windows.Forms.Label();
            this.lblTienPhong = new System.Windows.Forms.Label();
            this.txtTienPhong = new System.Windows.Forms.TextBox();
            this.lblTinhPhong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.lblBaoHiem = new System.Windows.Forms.Label();
            this.txtBaoHiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBNPhaiDong = new System.Windows.Forms.Label();
            this.txtBNPhaiDong = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.groupBoxBenhNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBHYT)).BeginInit();
            this.groupBoxChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(1016, 49);
            this.panelTop.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(375, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "💰 THANH TOÁN VIỆN PHÍ";
            // 
            // groupBoxBenhNhan
            // 
            this.groupBoxBenhNhan.Controls.Add(this.btnTinhTien);
            this.groupBoxBenhNhan.Controls.Add(this.numBHYT);
            this.groupBoxBenhNhan.Controls.Add(this.txtSoNgay);
            this.groupBoxBenhNhan.Controls.Add(this.txtNgayVao);
            this.groupBoxBenhNhan.Controls.Add(this.txtPhong);
            this.groupBoxBenhNhan.Controls.Add(this.txtCCCD);
            this.groupBoxBenhNhan.Controls.Add(this.txtHoTen);
            this.groupBoxBenhNhan.Controls.Add(this.cboBenhNhan);
            this.groupBoxBenhNhan.Controls.Add(this.lblBHYT);
            this.groupBoxBenhNhan.Controls.Add(this.lblSoNgay);
            this.groupBoxBenhNhan.Controls.Add(this.lblNgayVao);
            this.groupBoxBenhNhan.Controls.Add(this.lblPhong);
            this.groupBoxBenhNhan.Controls.Add(this.lblCCCD);
            this.groupBoxBenhNhan.Controls.Add(this.lblHoTen);
            this.groupBoxBenhNhan.Controls.Add(this.lblBenhNhan);
            this.groupBoxBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxBenhNhan.Location = new System.Drawing.Point(15, 61);
            this.groupBoxBenhNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxBenhNhan.Name = "groupBoxBenhNhan";
            this.groupBoxBenhNhan.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxBenhNhan.Size = new System.Drawing.Size(866, 176);
            this.groupBoxBenhNhan.TabIndex = 3;
            this.groupBoxBenhNhan.TabStop = false;
            this.groupBoxBenhNhan.Text = "Chọn bệnh nhân";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTinhTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnTinhTien.ForeColor = System.Drawing.Color.White;
            this.btnTinhTien.Location = new System.Drawing.Point(615, 23);
            this.btnTinhTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(148, 24);
            this.btnTinhTien.TabIndex = 0;
            this.btnTinhTien.Text = "🧮 Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            // 
            // numBHYT
            // 
            this.numBHYT.Location = new System.Drawing.Point(563, 131);
            this.numBHYT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numBHYT.Name = "numBHYT";
            this.numBHYT.ReadOnly = true;
            this.numBHYT.Size = new System.Drawing.Size(75, 23);
            this.numBHYT.TabIndex = 1;
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(344, 130);
            this.txtSoNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.ReadOnly = true;
            this.txtSoNgay.Size = new System.Drawing.Size(131, 23);
            this.txtSoNgay.TabIndex = 2;
            // 
            // txtNgayVao
            // 
            this.txtNgayVao.Location = new System.Drawing.Point(90, 130);
            this.txtNgayVao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNgayVao.Name = "txtNgayVao";
            this.txtNgayVao.ReadOnly = true;
            this.txtNgayVao.Size = new System.Drawing.Size(174, 23);
            this.txtNgayVao.TabIndex = 3;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(562, 64);
            this.txtPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(76, 23);
            this.txtPhong.TabIndex = 4;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(343, 64);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.ReadOnly = true;
            this.txtCCCD.Size = new System.Drawing.Size(132, 23);
            this.txtCCCD.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(90, 64);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(174, 23);
            this.txtHoTen.TabIndex = 6;
            // 
            // cboBenhNhan
            // 
            this.cboBenhNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBenhNhan.FormattingEnabled = true;
            this.cboBenhNhan.Location = new System.Drawing.Point(90, 24);
            this.cboBenhNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBenhNhan.Name = "cboBenhNhan";
            this.cboBenhNhan.Size = new System.Drawing.Size(511, 24);
            this.cboBenhNhan.TabIndex = 7;
            // 
            // lblBHYT
            // 
            this.lblBHYT.AutoSize = true;
            this.lblBHYT.Location = new System.Drawing.Point(494, 135);
            this.lblBHYT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBHYT.Name = "lblBHYT";
            this.lblBHYT.Size = new System.Drawing.Size(65, 17);
            this.lblBHYT.TabIndex = 8;
            this.lblBHYT.Text = "% BHYT:";
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Location = new System.Drawing.Point(276, 132);
            this.lblSoNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(64, 17);
            this.lblSoNgay.TabIndex = 9;
            this.lblSoNgay.Text = "Số ngày:";
            // 
            // lblNgayVao
            // 
            this.lblNgayVao.AutoSize = true;
            this.lblNgayVao.Location = new System.Drawing.Point(12, 132);
            this.lblNgayVao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayVao.Name = "lblNgayVao";
            this.lblNgayVao.Size = new System.Drawing.Size(72, 17);
            this.lblNgayVao.TabIndex = 10;
            this.lblNgayVao.Text = "Ngày vào:";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(506, 65);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(53, 17);
            this.lblPhong.TabIndex = 11;
            this.lblPhong.Text = "Phòng:";
            this.lblPhong.Click += new System.EventHandler(this.lblPhong_Click);
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(291, 68);
            this.lblCCCD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(49, 17);
            this.lblCCCD.TabIndex = 12;
            this.lblCCCD.Text = "CCCD:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(27, 64);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(54, 17);
            this.lblHoTen.TabIndex = 13;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblBenhNhan
            // 
            this.lblBenhNhan.AutoSize = true;
            this.lblBenhNhan.Location = new System.Drawing.Point(15, 26);
            this.lblBenhNhan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBenhNhan.Name = "lblBenhNhan";
            this.lblBenhNhan.Size = new System.Drawing.Size(68, 17);
            this.lblBenhNhan.TabIndex = 14;
            this.lblBenhNhan.Text = "Chọn BN:";
            // 
            // groupBoxChiTiet
            // 
            this.groupBoxChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxChiTiet.Controls.Add(this.dgvDichVu);
            this.groupBoxChiTiet.Controls.Add(this.lblTienDV);
            this.groupBoxChiTiet.Controls.Add(this.txtTienDV);
            this.groupBoxChiTiet.Controls.Add(this.lblDanhSachDV);
            this.groupBoxChiTiet.Controls.Add(this.dgvThuoc);
            this.groupBoxChiTiet.Controls.Add(this.lblTienThuoc);
            this.groupBoxChiTiet.Controls.Add(this.txtTienThuoc);
            this.groupBoxChiTiet.Controls.Add(this.lblDanhSachThuoc);
            this.groupBoxChiTiet.Controls.Add(this.lblTienPhong);
            this.groupBoxChiTiet.Controls.Add(this.txtTienPhong);
            this.groupBoxChiTiet.Controls.Add(this.lblTinhPhong);
            this.groupBoxChiTiet.Controls.Add(this.panel1);
            this.groupBoxChiTiet.Controls.Add(this.lblTongCong);
            this.groupBoxChiTiet.Controls.Add(this.txtTongCong);
            this.groupBoxChiTiet.Controls.Add(this.lblBaoHiem);
            this.groupBoxChiTiet.Controls.Add(this.txtBaoHiem);
            this.groupBoxChiTiet.Controls.Add(this.panel2);
            this.groupBoxChiTiet.Controls.Add(this.lblBNPhaiDong);
            this.groupBoxChiTiet.Controls.Add(this.txtBNPhaiDong);
            this.groupBoxChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxChiTiet.Location = new System.Drawing.Point(15, 242);
            this.groupBoxChiTiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxChiTiet.Name = "groupBoxChiTiet";
            this.groupBoxChiTiet.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxChiTiet.Size = new System.Drawing.Size(986, 352);
            this.groupBoxChiTiet.TabIndex = 2;
            this.groupBoxChiTiet.TabStop = false;
            this.groupBoxChiTiet.Text = "Chi tiết viện phí (tự động tính)";
            this.groupBoxChiTiet.Enter += new System.EventHandler(this.groupBoxChiTiet_Enter);
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDichVu,
            this.colGiaDV});
            this.dgvDichVu.Location = new System.Drawing.Point(375, 126);
            this.dgvDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.Size = new System.Drawing.Size(596, 81);
            this.dgvDichVu.TabIndex = 0;
            // 
            // colDichVu
            // 
            this.colDichVu.HeaderText = "Dịch vụ";
            this.colDichVu.MinimumWidth = 6;
            this.colDichVu.Name = "colDichVu";
            this.colDichVu.ReadOnly = true;
            // 
            // colGiaDV
            // 
            this.colGiaDV.HeaderText = "Giá";
            this.colGiaDV.MinimumWidth = 6;
            this.colGiaDV.Name = "colGiaDV";
            this.colGiaDV.ReadOnly = true;
            // 
            // lblTienDV
            // 
            this.lblTienDV.AutoSize = true;
            this.lblTienDV.Location = new System.Drawing.Point(375, 214);
            this.lblTienDV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTienDV.Name = "lblTienDV";
            this.lblTienDV.Size = new System.Drawing.Size(20, 17);
            this.lblTienDV.TabIndex = 1;
            this.lblTienDV.Text = "= ";
            // 
            // txtTienDV
            // 
            this.txtTienDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtTienDV.Location = new System.Drawing.Point(390, 211);
            this.txtTienDV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTienDV.Name = "txtTienDV";
            this.txtTienDV.ReadOnly = true;
            this.txtTienDV.Size = new System.Drawing.Size(151, 23);
            this.txtTienDV.TabIndex = 2;
            this.txtTienDV.Text = "0";
            this.txtTienDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDanhSachDV
            // 
            this.lblDanhSachDV.AutoSize = true;
            this.lblDanhSachDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDanhSachDV.Location = new System.Drawing.Point(375, 106);
            this.lblDanhSachDV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhSachDV.Name = "lblDanhSachDV";
            this.lblDanhSachDV.Size = new System.Drawing.Size(121, 17);
            this.lblDanhSachDV.TabIndex = 3;
            this.lblDanhSachDV.Text = "3. Tiền dịch vụ:";
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AllowUserToAddRows = false;
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThuoc,
            this.colSoLuong,
            this.colGiaThuoc});
            this.dgvThuoc.Location = new System.Drawing.Point(15, 126);
            this.dgvThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.ReadOnly = true;
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.Size = new System.Drawing.Size(345, 81);
            this.dgvThuoc.TabIndex = 4;
            // 
            // colThuoc
            // 
            this.colThuoc.HeaderText = "Thuốc";
            this.colThuoc.MinimumWidth = 6;
            this.colThuoc.Name = "colThuoc";
            this.colThuoc.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "SL";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colGiaThuoc
            // 
            this.colGiaThuoc.HeaderText = "Giá";
            this.colGiaThuoc.MinimumWidth = 6;
            this.colGiaThuoc.Name = "colGiaThuoc";
            this.colGiaThuoc.ReadOnly = true;
            // 
            // lblTienThuoc
            // 
            this.lblTienThuoc.AutoSize = true;
            this.lblTienThuoc.Location = new System.Drawing.Point(15, 214);
            this.lblTienThuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTienThuoc.Name = "lblTienThuoc";
            this.lblTienThuoc.Size = new System.Drawing.Size(20, 17);
            this.lblTienThuoc.TabIndex = 5;
            this.lblTienThuoc.Text = "= ";
            // 
            // txtTienThuoc
            // 
            this.txtTienThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtTienThuoc.Location = new System.Drawing.Point(30, 211);
            this.txtTienThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTienThuoc.Name = "txtTienThuoc";
            this.txtTienThuoc.ReadOnly = true;
            this.txtTienThuoc.Size = new System.Drawing.Size(151, 23);
            this.txtTienThuoc.TabIndex = 6;
            this.txtTienThuoc.Text = "0";
            this.txtTienThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDanhSachThuoc
            // 
            this.lblDanhSachThuoc.AutoSize = true;
            this.lblDanhSachThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDanhSachThuoc.Location = new System.Drawing.Point(15, 106);
            this.lblDanhSachThuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhSachThuoc.Name = "lblDanhSachThuoc";
            this.lblDanhSachThuoc.Size = new System.Drawing.Size(109, 17);
            this.lblDanhSachThuoc.TabIndex = 7;
            this.lblDanhSachThuoc.Text = "2. Tiền thuốc:";
            // 
            // lblTienPhong
            // 
            this.lblTienPhong.AutoSize = true;
            this.lblTienPhong.Location = new System.Drawing.Point(15, 73);
            this.lblTienPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTienPhong.Name = "lblTienPhong";
            this.lblTienPhong.Size = new System.Drawing.Size(20, 17);
            this.lblTienPhong.TabIndex = 8;
            this.lblTienPhong.Text = "= ";
            // 
            // txtTienPhong
            // 
            this.txtTienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtTienPhong.Location = new System.Drawing.Point(30, 71);
            this.txtTienPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTienPhong.Name = "txtTienPhong";
            this.txtTienPhong.ReadOnly = true;
            this.txtTienPhong.Size = new System.Drawing.Size(151, 23);
            this.txtTienPhong.TabIndex = 9;
            this.txtTienPhong.Text = "0";
            this.txtTienPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTinhPhong
            // 
            this.lblTinhPhong.AutoSize = true;
            this.lblTinhPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTinhPhong.Location = new System.Drawing.Point(15, 28);
            this.lblTinhPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTinhPhong.Name = "lblTinhPhong";
            this.lblTinhPhong.Size = new System.Drawing.Size(114, 17);
            this.lblTinhPhong.TabIndex = 10;
            this.lblTinhPhong.Text = "1. Tiền phòng:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(15, 240);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 2);
            this.panel1.TabIndex = 11;
            // 
            // lblTongCong
            // 
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongCong.Location = new System.Drawing.Point(300, 248);
            this.lblTongCong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(119, 20);
            this.lblTongCong.TabIndex = 12;
            this.lblTongCong.Text = "TỔNG CỘNG:";
            // 
            // txtTongCong
            // 
            this.txtTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTongCong.ForeColor = System.Drawing.Color.Red;
            this.txtTongCong.Location = new System.Drawing.Point(412, 245);
            this.txtTongCong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.ReadOnly = true;
            this.txtTongCong.Size = new System.Drawing.Size(166, 26);
            this.txtTongCong.TabIndex = 13;
            this.txtTongCong.Text = "0";
            this.txtTongCong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBaoHiem
            // 
            this.lblBaoHiem.AutoSize = true;
            this.lblBaoHiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBaoHiem.Location = new System.Drawing.Point(240, 276);
            this.lblBaoHiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaoHiem.Name = "lblBaoHiem";
            this.lblBaoHiem.Size = new System.Drawing.Size(155, 18);
            this.lblBaoHiem.TabIndex = 14;
            this.lblBaoHiem.Text = "Bảo hiểm trả (____%):";
            // 
            // txtBaoHiem
            // 
            this.txtBaoHiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtBaoHiem.Location = new System.Drawing.Point(412, 274);
            this.txtBaoHiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBaoHiem.Name = "txtBaoHiem";
            this.txtBaoHiem.ReadOnly = true;
            this.txtBaoHiem.Size = new System.Drawing.Size(166, 24);
            this.txtBaoHiem.TabIndex = 15;
            this.txtBaoHiem.Text = "0";
            this.txtBaoHiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(225, 301);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 2);
            this.panel2.TabIndex = 16;
            // 
            // lblBNPhaiDong
            // 
            this.lblBNPhaiDong.AutoSize = true;
            this.lblBNPhaiDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblBNPhaiDong.ForeColor = System.Drawing.Color.Red;
            this.lblBNPhaiDong.Location = new System.Drawing.Point(188, 309);
            this.lblBNPhaiDong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBNPhaiDong.Name = "lblBNPhaiDong";
            this.lblBNPhaiDong.Size = new System.Drawing.Size(158, 22);
            this.lblBNPhaiDong.TabIndex = 17;
            this.lblBNPhaiDong.Text = "BN PHẢI ĐÓNG:";
            // 
            // txtBNPhaiDong
            // 
            this.txtBNPhaiDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtBNPhaiDong.ForeColor = System.Drawing.Color.Red;
            this.txtBNPhaiDong.Location = new System.Drawing.Point(338, 305);
            this.txtBNPhaiDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBNPhaiDong.Name = "txtBNPhaiDong";
            this.txtBNPhaiDong.ReadOnly = true;
            this.txtBNPhaiDong.Size = new System.Drawing.Size(241, 29);
            this.txtBNPhaiDong.TabIndex = 18;
            this.txtBNPhaiDong.Text = "0";
            this.txtBNPhaiDong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(358, 607);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(150, 41);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "✓ Xác nhận ";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnInHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnInHoaDon.Location = new System.Drawing.Point(523, 607);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(135, 41);
            this.btnInHoaDon.TabIndex = 0;
            this.btnInHoaDon.Text = "🖨️ In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1016, 656);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.groupBoxChiTiet);
            this.Controls.Add(this.groupBoxBenhNhan);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormThanhToan";
            this.panelTop.ResumeLayout(false);
            this.groupBoxBenhNhan.ResumeLayout(false);
            this.groupBoxBenhNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBHYT)).EndInit();
            this.groupBoxChiTiet.ResumeLayout(false);
            this.groupBoxChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.ResumeLayout(false);

 }

 private System.Windows.Forms.Panel panelTop;
 private System.Windows.Forms.Label lblTitle;
 private System.Windows.Forms.GroupBox groupBoxBenhNhan;
 private System.Windows.Forms.Button btnTinhTien;
 private System.Windows.Forms.NumericUpDown numBHYT;
 private System.Windows.Forms.TextBox txtSoNgay;
 private System.Windows.Forms.TextBox txtNgayVao;
 private System.Windows.Forms.TextBox txtPhong;
 private System.Windows.Forms.TextBox txtCCCD;
 private System.Windows.Forms.TextBox txtHoTen;
 private System.Windows.Forms.ComboBox cboBenhNhan;
 private System.Windows.Forms.Label lblBHYT;
 private System.Windows.Forms.Label lblSoNgay;
 private System.Windows.Forms.Label lblNgayVao;
 private System.Windows.Forms.Label lblPhong;
 private System.Windows.Forms.Label lblCCCD;
 private System.Windows.Forms.Label lblHoTen;
 private System.Windows.Forms.Label lblBenhNhan;
 private System.Windows.Forms.GroupBox groupBoxChiTiet;
 private System.Windows.Forms.DataGridView dgvDichVu;
 private System.Windows.Forms.DataGridViewTextBoxColumn colDichVu;
 private System.Windows.Forms.DataGridViewTextBoxColumn colGiaDV;
 private System.Windows.Forms.Label lblTienDV;
 private System.Windows.Forms.TextBox txtTienDV;
 private System.Windows.Forms.Label lblDanhSachDV;
 private System.Windows.Forms.DataGridView dgvThuoc;
 private System.Windows.Forms.DataGridViewTextBoxColumn colThuoc;
 private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
 private System.Windows.Forms.DataGridViewTextBoxColumn colGiaThuoc;
 private System.Windows.Forms.Label lblTienThuoc;
 private System.Windows.Forms.TextBox txtTienThuoc;
 private System.Windows.Forms.Label lblDanhSachThuoc;
 private System.Windows.Forms.Label lblTienPhong;
 private System.Windows.Forms.TextBox txtTienPhong;
 private System.Windows.Forms.Label lblTinhPhong;
 private System.Windows.Forms.Panel panel1;
 private System.Windows.Forms.Label lblTongCong;
 private System.Windows.Forms.TextBox txtTongCong;
 private System.Windows.Forms.Label lblBaoHiem;
 private System.Windows.Forms.TextBox txtBaoHiem;
 private System.Windows.Forms.Panel panel2;
 private System.Windows.Forms.Label lblBNPhaiDong;
 private System.Windows.Forms.TextBox txtBNPhaiDong;
 private System.Windows.Forms.Button btnThanhToan;
 private System.Windows.Forms.Button btnInHoaDon;
 }
}
