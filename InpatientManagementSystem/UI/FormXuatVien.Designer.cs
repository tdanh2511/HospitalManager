namespace Quan_li_benh_vien
{
partial class FormXuatVien
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
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.colCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDaThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.txtTongChiPhi = new System.Windows.Forms.TextBox();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.txtNgayVao = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblTongChiPhi = new System.Windows.Forms.Label();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.lblNgayVao = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.groupBoxThongTin.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(750, 49);
            this.panelTop.TabIndex = 4;
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
            this.lblTitle.Text = "🚑 XUẤT VIỆN";
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDanhSach.Controls.Add(this.dgvBenhNhan);
            this.groupBoxDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(15, 61);
            this.groupBoxDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDanhSach.Size = new System.Drawing.Size(720, 244);
            this.groupBoxDanhSach.TabIndex = 3;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách BN đã thanh toán";
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.AllowUserToAddRows = false;
            this.dgvBenhNhan.AllowUserToDeleteRows = false;
            this.dgvBenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCCCD,
            this.colHoTen,
            this.colPhong,
            this.colNgayVao,
            this.colDaThanhToan});
            this.dgvBenhNhan.Location = new System.Drawing.Point(8, 24);
            this.dgvBenhNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBenhNhan.MultiSelect = false;
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.ReadOnly = true;
            this.dgvBenhNhan.RowHeadersWidth = 51;
            this.dgvBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBenhNhan.Size = new System.Drawing.Size(705, 211);
            this.dgvBenhNhan.TabIndex = 0;
            // 
            // colCCCD
            // 
            this.colCCCD.HeaderText = "CCCD";
            this.colCCCD.MinimumWidth = 6;
            this.colCCCD.Name = "colCCCD";
            this.colCCCD.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colPhong
            // 
            this.colPhong.HeaderText = "Phòng";
            this.colPhong.MinimumWidth = 6;
            this.colPhong.Name = "colPhong";
            this.colPhong.ReadOnly = true;
            // 
            // colNgayVao
            // 
            this.colNgayVao.HeaderText = "Ngày vào";
            this.colNgayVao.MinimumWidth = 6;
            this.colNgayVao.Name = "colNgayVao";
            this.colNgayVao.ReadOnly = true;
            // 
            // colDaThanhToan
            // 
            this.colDaThanhToan.HeaderText = "Đã thanh toán";
            this.colDaThanhToan.MinimumWidth = 6;
            this.colDaThanhToan.Name = "colDaThanhToan";
            this.colDaThanhToan.ReadOnly = true;
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxThongTin.Controls.Add(this.txtTongChiPhi);
            this.groupBoxThongTin.Controls.Add(this.txtSoNgay);
            this.groupBoxThongTin.Controls.Add(this.txtNgayVao);
            this.groupBoxThongTin.Controls.Add(this.txtPhong);
            this.groupBoxThongTin.Controls.Add(this.txtHoTen);
            this.groupBoxThongTin.Controls.Add(this.lblTongChiPhi);
            this.groupBoxThongTin.Controls.Add(this.lblSoNgay);
            this.groupBoxThongTin.Controls.Add(this.lblNgayVao);
            this.groupBoxThongTin.Controls.Add(this.lblPhong);
            this.groupBoxThongTin.Controls.Add(this.lblHoTen);
            this.groupBoxThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxThongTin.Location = new System.Drawing.Point(15, 317);
            this.groupBoxThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxThongTin.Size = new System.Drawing.Size(720, 126);
            this.groupBoxThongTin.TabIndex = 2;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Thông tin BN đã chọn";
            // 
            // txtTongChiPhi
            // 
            this.txtTongChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.txtTongChiPhi.ForeColor = System.Drawing.Color.Red;
            this.txtTongChiPhi.Location = new System.Drawing.Point(133, 94);
            this.txtTongChiPhi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTongChiPhi.Name = "txtTongChiPhi";
            this.txtTongChiPhi.ReadOnly = true;
            this.txtTongChiPhi.Size = new System.Drawing.Size(151, 24);
            this.txtTongChiPhi.TabIndex = 0;
            this.txtTongChiPhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(465, 62);
            this.txtSoNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.ReadOnly = true;
            this.txtSoNgay.Size = new System.Drawing.Size(91, 23);
            this.txtSoNgay.TabIndex = 1;
            // 
            // txtNgayVao
            // 
            this.txtNgayVao.Location = new System.Drawing.Point(465, 32);
            this.txtNgayVao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNgayVao.Name = "txtNgayVao";
            this.txtNgayVao.ReadOnly = true;
            this.txtNgayVao.Size = new System.Drawing.Size(114, 23);
            this.txtNgayVao.TabIndex = 2;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(112, 62);
            this.txtPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(114, 23);
            this.txtPhong.TabIndex = 3;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(112, 32);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(226, 23);
            this.txtHoTen.TabIndex = 4;
            // 
            // lblTongChiPhi
            // 
            this.lblTongChiPhi.AutoSize = true;
            this.lblTongChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongChiPhi.Location = new System.Drawing.Point(15, 97);
            this.lblTongChiPhi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongChiPhi.Name = "lblTongChiPhi";
            this.lblTongChiPhi.Size = new System.Drawing.Size(105, 18);
            this.lblTongChiPhi.TabIndex = 5;
            this.lblTongChiPhi.Text = "Tổng chi phí:";
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Location = new System.Drawing.Point(360, 64);
            this.lblSoNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(64, 17);
            this.lblSoNgay.TabIndex = 6;
            this.lblSoNgay.Text = "Số ngày:";
            // 
            // lblNgayVao
            // 
            this.lblNgayVao.AutoSize = true;
            this.lblNgayVao.Location = new System.Drawing.Point(360, 35);
            this.lblNgayVao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayVao.Name = "lblNgayVao";
            this.lblNgayVao.Size = new System.Drawing.Size(72, 17);
            this.lblNgayVao.TabIndex = 7;
            this.lblNgayVao.Text = "Ngày vào:";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(15, 64);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(53, 17);
            this.lblPhong.TabIndex = 8;
            this.lblPhong.Text = "Phòng:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(15, 35);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(54, 17);
            this.lblHoTen.TabIndex = 9;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnInPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnInPhieu.ForeColor = System.Drawing.Color.White;
            this.btnInPhieu.Location = new System.Drawing.Point(390, 455);
            this.btnInPhieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(135, 41);
            this.btnInPhieu.TabIndex = 0;
            this.btnInPhieu.Text = "🖨️ In phiếu XV";
            this.btnInPhieu.UseVisualStyleBackColor = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXacNhan.BackColor = System.Drawing.Color.ForestGreen;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(195, 455);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(177, 41);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "✓ Xác nhận xuất";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormXuatVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(750, 544);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.groupBoxThongTin);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormXuatVien";
            this.panelTop.ResumeLayout(false);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.ResumeLayout(false);

}

private System.Windows.Forms.Panel panelTop;
private System.Windows.Forms.Label lblTitle;
private System.Windows.Forms.GroupBox groupBoxDanhSach;
private System.Windows.Forms.DataGridView dgvBenhNhan;
private System.Windows.Forms.DataGridViewTextBoxColumn colCCCD;
private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
private System.Windows.Forms.DataGridViewTextBoxColumn colNgayVao;
private System.Windows.Forms.DataGridViewTextBoxColumn colDaThanhToan;
private System.Windows.Forms.GroupBox groupBoxThongTin;
private System.Windows.Forms.TextBox txtTongChiPhi;
private System.Windows.Forms.TextBox txtSoNgay;
private System.Windows.Forms.TextBox txtNgayVao;
private System.Windows.Forms.TextBox txtPhong;
private System.Windows.Forms.TextBox txtHoTen;
private System.Windows.Forms.Label lblTongChiPhi;
private System.Windows.Forms.Label lblSoNgay;
private System.Windows.Forms.Label lblNgayVao;
private System.Windows.Forms.Label lblPhong;
private System.Windows.Forms.Label lblHoTen;
private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Button btnXacNhan;
    }
}
