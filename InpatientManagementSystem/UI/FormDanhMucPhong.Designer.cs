namespace Quan_li_benh_vien
{
    partial class FormDanhMucPhong
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
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblGiaPhong = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 60);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🛏️ DANH MỤC PHÒNG";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.cboTrangThai);
            this.groupBoxInfo.Controls.Add(this.txtGiaPhong);
            this.groupBoxInfo.Controls.Add(this.txtTenPhong);
            this.groupBoxInfo.Controls.Add(this.txtMaPhong);
            this.groupBoxInfo.Controls.Add(this.lblTrangThai);
            this.groupBoxInfo.Controls.Add(this.lblGiaPhong);
            this.groupBoxInfo.Controls.Add(this.lblTenPhong);
            this.groupBoxInfo.Controls.Add(this.lblMaPhong);
            this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxInfo.Location = new System.Drawing.Point(20, 80);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(474, 250);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin phòng";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Đã có người"});
            this.cboTrangThai.Location = new System.Drawing.Point(177, 195);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(280, 28);
            this.cboTrangThai.TabIndex = 8;
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(177, 147);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(280, 26);
            this.txtGiaPhong.TabIndex = 6;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(177, 103);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(280, 26);
            this.txtTenPhong.TabIndex = 5;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(177, 53);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(280, 26);
            this.txtMaPhong.TabIndex = 4;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(20, 203);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(89, 20);
            this.lblTrangThai.TabIndex = 9;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // lblGiaPhong
            // 
            this.lblGiaPhong.AutoSize = true;
            this.lblGiaPhong.Location = new System.Drawing.Point(20, 153);
            this.lblGiaPhong.Name = "lblGiaPhong";
            this.lblGiaPhong.Size = new System.Drawing.Size(130, 20);
            this.lblGiaPhong.TabIndex = 10;
            this.lblGiaPhong.Text = "Giá phòng/ngày:";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(20, 103);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(92, 20);
            this.lblTenPhong.TabIndex = 11;
            this.lblTenPhong.Text = "Tên phòng:";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(20, 53);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(87, 20);
            this.lblMaPhong.TabIndex = 12;
            this.lblMaPhong.Text = "Mã phòng:";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxList.Controls.Add(this.dgvPhong);
            this.groupBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxList.Location = new System.Drawing.Point(20, 350);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(960, 300);
            this.groupBoxList.TabIndex = 2;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Danh sách phòng";
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
    this.colMaPhong, this.colTenPhong, this.colGiaPhong, this.colTrangThai});
 this.dgvPhong.Location = new System.Drawing.Point(10, 30);
            this.dgvPhong.Name = "dgvPhong";
   this.dgvPhong.ReadOnly = true;
   this.dgvPhong.RowHeadersWidth = 51;
   this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
 this.dgvPhong.Size = new System.Drawing.Size(940, 260);
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
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(534, 121);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 45);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(725, 121);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 45);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(534, 183);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 45);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(725, 183);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 45);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // FormDanhMucPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1000, 670);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhMucPhong";
            this.panelTop.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);

  }

        private System.Windows.Forms.Panel panelTop;
  private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.GroupBox groupBoxInfo;
private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
   private System.Windows.Forms.Label lblTrangThai;
   private System.Windows.Forms.Label lblGiaPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.DataGridView dgvPhong;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
     private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
