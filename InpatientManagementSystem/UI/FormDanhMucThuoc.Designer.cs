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
     this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
     this.txtTenThuoc = new System.Windows.Forms.TextBox();
  this.txtMaThuoc = new System.Windows.Forms.TextBox();
       this.lblDonVi = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
 this.lblTenThuoc = new System.Windows.Forms.Label();
    this.lblMaThuoc = new System.Windows.Forms.Label();
 this.groupBoxList = new System.Windows.Forms.GroupBox();
       this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.colMaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colTenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
       this.colDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
 this.btnThem = new System.Windows.Forms.Button();
       this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
      this.btnLamMoi = new System.Windows.Forms.Button();
    this.panelTop.SuspendLayout();
  this.groupBoxInfo.SuspendLayout();
            this.groupBoxList.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
         this.SuspendLayout();
      // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
       this.panelTop.Controls.Add(this.lblTitle);
         this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
     this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
         this.panelTop.Size = new System.Drawing.Size(1000, 60);
        this.panelTop.TabIndex = 0;
  // lblTitle
     this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
    this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
      this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
    this.lblTitle.TabIndex = 0;
  this.lblTitle.Text = "💊 DANH MỤC THUỐC";
     // groupBoxInfo
  this.groupBoxInfo.Controls.Add(this.txtDonVi);
     this.groupBoxInfo.Controls.Add(this.txtGia);
      this.groupBoxInfo.Controls.Add(this.txtTenThuoc);
     this.groupBoxInfo.Controls.Add(this.txtMaThuoc);
        this.groupBoxInfo.Controls.Add(this.lblDonVi);
    this.groupBoxInfo.Controls.Add(this.lblGia);
    this.groupBoxInfo.Controls.Add(this.lblTenThuoc);
            this.groupBoxInfo.Controls.Add(this.lblMaThuoc);
       this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxInfo.Location = new System.Drawing.Point(20, 80);
            this.groupBoxInfo.Name = "groupBoxInfo";
        this.groupBoxInfo.Size = new System.Drawing.Size(450, 250);
      this.groupBoxInfo.TabIndex = 1;
    this.groupBoxInfo.TabStop = false;
     this.groupBoxInfo.Text = "Thông tin thuốc";
      // txtDonVi
     this.txtDonVi.Location = new System.Drawing.Point(150, 200);
      this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(280, 26);
 this.txtDonVi.TabIndex = 7;
// txtGia
            this.txtGia.Location = new System.Drawing.Point(150, 150);
  this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(280, 26);
            this.txtGia.TabIndex = 6;
       // txtTenThuoc
  this.txtTenThuoc.Location = new System.Drawing.Point(150, 100);
            this.txtTenThuoc.Name = "txtTenThuoc";
 this.txtTenThuoc.Size = new System.Drawing.Size(280, 26);
       this.txtTenThuoc.TabIndex = 5;
            // txtMaThuoc
            this.txtMaThuoc.Location = new System.Drawing.Point(150, 50);
            this.txtMaThuoc.Name = "txtMaThuoc";
       this.txtMaThuoc.Size = new System.Drawing.Size(280, 26);
    this.txtMaThuoc.TabIndex = 4;
 // lblDonVi
       this.lblDonVi.AutoSize = true;
          this.lblDonVi.Location = new System.Drawing.Point(20, 203);
 this.lblDonVi.Name = "lblDonVi";
 this.lblDonVi.Size = new System.Drawing.Size(64, 20);
            this.lblDonVi.TabIndex = 3;
            this.lblDonVi.Text = "Đơn vị:";
            // lblGia
  this.lblGia.AutoSize = true;
 this.lblGia.Location = new System.Drawing.Point(20, 153);
            this.lblGia.Name = "lblGia";
   this.lblGia.Size = new System.Drawing.Size(78, 20);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "Giá tiền:";
   // lblTenThuoc
            this.lblTenThuoc.AutoSize = true;
            this.lblTenThuoc.Location = new System.Drawing.Point(20, 103);
      this.lblTenThuoc.Name = "lblTenThuoc";
  this.lblTenThuoc.Size = new System.Drawing.Size(88, 20);
            this.lblTenThuoc.TabIndex = 1;
 this.lblTenThuoc.Text = "Tên thuốc:";
         // lblMaThuoc
 this.lblMaThuoc.AutoSize = true;
  this.lblMaThuoc.Location = new System.Drawing.Point(20, 53);
  this.lblMaThuoc.Name = "lblMaThuoc";
  this.lblMaThuoc.Size = new System.Drawing.Size(83, 20);
       this.lblMaThuoc.TabIndex = 0;
this.lblMaThuoc.Text = "Mã thuốc:";
    // groupBoxList
       this.groupBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
| System.Windows.Forms.AnchorStyles.Left) 
     | System.Windows.Forms.AnchorStyles.Right)));
       this.groupBoxList.Controls.Add(this.dgvThuoc);
      this.groupBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxList.Location = new System.Drawing.Point(20, 350);
 this.groupBoxList.Name = "groupBoxList";
  this.groupBoxList.Size = new System.Drawing.Size(960, 300);
    this.groupBoxList.TabIndex = 2;
    this.groupBoxList.TabStop = false;
  this.groupBoxList.Text = "Danh sách thuốc";
            // dgvThuoc
  this.dgvThuoc.AllowUserToAddRows = false;
         this.dgvThuoc.AllowUserToDeleteRows = false;
      this.dgvThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
  | System.Windows.Forms.AnchorStyles.Left) 
       | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.colMaThuoc,
   this.colTenThuoc,
   this.colGia,
            this.colDonVi});
   this.dgvThuoc.Location = new System.Drawing.Point(10, 30);
            this.dgvThuoc.Name = "dgvThuoc";
    this.dgvThuoc.ReadOnly = true;
      this.dgvThuoc.RowHeadersWidth = 51;
   this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
    this.dgvThuoc.Size = new System.Drawing.Size(940, 260);
     this.dgvThuoc.TabIndex = 0;
 // colMaThuoc
       this.colMaThuoc.HeaderText = "Mã thuốc";
 this.colMaThuoc.Name = "colMaThuoc";
   this.colMaThuoc.ReadOnly = true;
   // colTenThuoc
        this.colTenThuoc.HeaderText = "Tên thuốc";
      this.colTenThuoc.Name = "colTenThuoc";
            this.colTenThuoc.ReadOnly = true;
  // colGia
      this.colGia.HeaderText = "Giá tiền";
 this.colGia.Name = "colGia";
         this.colGia.ReadOnly = true;
            // colDonVi
    this.colDonVi.HeaderText = "Đơn vị";
       this.colDonVi.Name = "colDonVi";
 this.colDonVi.ReadOnly = true;
            // btnThem
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
   this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
    this.btnThem.ForeColor = System.Drawing.Color.White;
        this.btnThem.Location = new System.Drawing.Point(500, 100);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 45);
     this.btnThem.TabIndex = 3;
        this.btnThem.Text = "Thêm";
   this.btnThem.UseVisualStyleBackColor = false;
            // btnSua
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
       this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
    this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(640, 100);
      this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 45);
     this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
 this.btnSua.UseVisualStyleBackColor = false;
          // btnXoa
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
          this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
       this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
      this.btnXoa.Location = new System.Drawing.Point(500, 165);
       this.btnXoa.Name = "btnXoa";
 this.btnXoa.Size = new System.Drawing.Size(120, 45);
this.btnXoa.TabIndex = 5;
          this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
    this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
          this.btnLamMoi.Location = new System.Drawing.Point(640, 165);
   this.btnLamMoi.Name = "btnLamMoi";
     this.btnLamMoi.Size = new System.Drawing.Size(120, 45);
     this.btnLamMoi.TabIndex = 6;
          this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
         // FormDanhMucThuoc
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
      this.Name = "FormDanhMucThuoc";
   this.Text = "Danh mục thuốc";
        this.panelTop.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
     this.groupBoxInfo.PerformLayout();
     this.groupBoxList.ResumeLayout(false);
       ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
       this.ResumeLayout(false);
        }

    private System.Windows.Forms.Panel panelTop;
     private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtGia;
   private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txtMaThuoc;
      private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenThuoc;
        private System.Windows.Forms.Label lblMaThuoc;
 private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
  private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonVi;
    }
}
