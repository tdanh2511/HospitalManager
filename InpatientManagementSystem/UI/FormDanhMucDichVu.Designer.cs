namespace Quan_li_benh_vien
{
partial class FormDanhMucDichVu
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
  this.txtLoaiDichVu = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenDichVu = new System.Windows.Forms.TextBox();
            this.txtMaDichVu = new System.Windows.Forms.TextBox();
            this.lblLoaiDichVu = new System.Windows.Forms.Label();
        this.lblGia = new System.Windows.Forms.Label();
     this.lblTenDichVu = new System.Windows.Forms.Label();
       this.lblMaDichVu = new System.Windows.Forms.Label();
          this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.colMaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colLoaiDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
       this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
          this.btnXoa = new System.Windows.Forms.Button();
      this.btnLamMoi = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
    this.groupBoxInfo.SuspendLayout();
          this.groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
      this.SuspendLayout();
            // panelTop
  this.panelTop.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
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
            this.lblTitle.Text = "🔬 DANH MỤC DỊCH VỤ";
       // groupBoxInfo
     this.groupBoxInfo.Controls.Add(this.txtLoaiDichVu);
    this.groupBoxInfo.Controls.Add(this.txtGia);
   this.groupBoxInfo.Controls.Add(this.txtTenDichVu);
            this.groupBoxInfo.Controls.Add(this.txtMaDichVu);
       this.groupBoxInfo.Controls.Add(this.lblLoaiDichVu);
            this.groupBoxInfo.Controls.Add(this.lblGia);
  this.groupBoxInfo.Controls.Add(this.lblTenDichVu);
 this.groupBoxInfo.Controls.Add(this.lblMaDichVu);
 this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxInfo.Location = new System.Drawing.Point(20, 80);
       this.groupBoxInfo.Name = "groupBoxInfo";
    this.groupBoxInfo.Size = new System.Drawing.Size(450, 250);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
       this.groupBoxInfo.Text = "Thông tin dịch vụ";
        // txtLoaiDichVu
            this.txtLoaiDichVu.Location = new System.Drawing.Point(150, 200);
         this.txtLoaiDichVu.Name = "txtLoaiDichVu";
            this.txtLoaiDichVu.Size = new System.Drawing.Size(280, 26);
     this.txtLoaiDichVu.TabIndex = 7;
      // txtGia
            this.txtGia.Location = new System.Drawing.Point(150, 150);
            this.txtGia.Name = "txtGia";
       this.txtGia.Size = new System.Drawing.Size(280, 26);
            this.txtGia.TabIndex = 6;
            // txtTenDichVu
 this.txtTenDichVu.Location = new System.Drawing.Point(150, 100);
  this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(280, 26);
          this.txtTenDichVu.TabIndex = 5;
            // txtMaDichVu
      this.txtMaDichVu.Location = new System.Drawing.Point(150, 50);
  this.txtMaDichVu.Name = "txtMaDichVu";
   this.txtMaDichVu.Size = new System.Drawing.Size(280, 26);
   this.txtMaDichVu.TabIndex = 4;
            // lblLoaiDichVu
         this.lblLoaiDichVu.AutoSize = true;
    this.lblLoaiDichVu.Location = new System.Drawing.Point(20, 203);
            this.lblLoaiDichVu.Name = "lblLoaiDichVu";
         this.lblLoaiDichVu.Size = new System.Drawing.Size(100, 20);
            this.lblLoaiDichVu.Text = "Loại dịch vụ:";
            // lblGia
            this.lblGia.AutoSize = true;
  this.lblGia.Location = new System.Drawing.Point(20, 153);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(78, 20);
      this.lblGia.Text = "Giá tiền:";
    // lblTenDichVu
   this.lblTenDichVu.AutoSize = true;
        this.lblTenDichVu.Location = new System.Drawing.Point(20, 103);
  this.lblTenDichVu.Name = "lblTenDichVu";
   this.lblTenDichVu.Size = new System.Drawing.Size(102, 20);
   this.lblTenDichVu.Text = "Tên dịch vụ:";
         // lblMaDichVu
   this.lblMaDichVu.AutoSize = true;
        this.lblMaDichVu.Location = new System.Drawing.Point(20, 53);
 this.lblMaDichVu.Name = "lblMaDichVu";
            this.lblMaDichVu.Size = new System.Drawing.Size(97, 20);
    this.lblMaDichVu.Text = "Mã dịch vụ:";
            // groupBoxList
      this.groupBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
 | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxList.Controls.Add(this.dgvDichVu);
   this.groupBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.groupBoxList.Location = new System.Drawing.Point(20, 350);
   this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(960, 300);
        this.groupBoxList.TabIndex = 2;
 this.groupBoxList.TabStop = false;
         this.groupBoxList.Text = "Danh sách dịch vụ";
            // dgvDichVu
   this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
    this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
   this.colMaDichVu,
            this.colTenDichVu,
    this.colGia,
    this.colLoaiDichVu});
       this.dgvDichVu.Location = new System.Drawing.Point(10, 30);
 this.dgvDichVu.Name = "dgvDichVu";
          this.dgvDichVu.ReadOnly = true;
     this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(940, 260);
          this.dgvDichVu.TabIndex = 0;
   // colMaDichVu
            this.colMaDichVu.HeaderText = "Mã dịch vụ";
    this.colMaDichVu.Name = "colMaDichVu";
       this.colMaDichVu.ReadOnly = true;
    // colTenDichVu
            this.colTenDichVu.HeaderText = "Tên dịch vụ";
   this.colTenDichVu.Name = "colTenDichVu";
    this.colTenDichVu.ReadOnly = true;
  // colGia
    this.colGia.HeaderText = "Giá tiền";
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            // colLoaiDichVu
            this.colLoaiDichVu.HeaderText = "Loại dịch vụ";
          this.colLoaiDichVu.Name = "colLoaiDichVu";
            this.colLoaiDichVu.ReadOnly = true;
            // btnThem
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
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
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
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
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
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
  this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(117, 117, 117);
       this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
       this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(640, 165);
     this.btnLamMoi.Name = "btnLamMoi";
    this.btnLamMoi.Size = new System.Drawing.Size(120, 45);
            this.btnLamMoi.TabIndex = 6;
  this.btnLamMoi.Text = "Làm mới";
         this.btnLamMoi.UseVisualStyleBackColor = false;
  // FormDanhMucDichVu
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
     this.ClientSize = new System.Drawing.Size(1000, 670);
            this.Controls.Add(this.btnLamMoi);
        this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
    this.Controls.Add(this.btnThem);
          this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhMucDichVu";
          this.Text = "Danh mục dịch vụ";
    this.panelTop.ResumeLayout(false);
         this.groupBoxInfo.ResumeLayout(false);
    this.groupBoxInfo.PerformLayout();
  this.groupBoxList.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
         this.ResumeLayout(false);
 }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox txtLoaiDichVu;
        private System.Windows.Forms.TextBox txtGia;
  private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.TextBox txtMaDichVu;
        private System.Windows.Forms.Label lblLoaiDichVu;
    private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenDichVu;
    private System.Windows.Forms.Label lblMaDichVu;
   private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.DataGridView dgvDichVu;
 private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
 private System.Windows.Forms.Button btnLamMoi;
      private System.Windows.Forms.DataGridViewTextBoxColumn colMaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiDichVu;
    }
}
