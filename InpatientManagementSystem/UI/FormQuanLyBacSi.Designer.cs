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
            this.txtChuyenKhoa = new System.Windows.Forms.TextBox();
            this.txtKinhNghiem = new System.Windows.Forms.TextBox();
            this.txtTenBS = new System.Windows.Forms.TextBox();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.lblChuyenKhoa = new System.Windows.Forms.Label();
            this.lblKinhNghiem = new System.Windows.Forms.Label();
            this.lblTenBS = new System.Windows.Forms.Label();
            this.lblMaBS = new System.Windows.Forms.Label();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvBacSi = new System.Windows.Forms.DataGridView();
            this.colMaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKinhNghiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxThongTin.SuspendLayout();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Controls.Add(this.txtChuyenKhoa);
            this.groupBoxThongTin.Controls.Add(this.txtKinhNghiem);
            this.groupBoxThongTin.Controls.Add(this.txtTenBS);
            this.groupBoxThongTin.Controls.Add(this.txtMaBS);
            this.groupBoxThongTin.Controls.Add(this.lblChuyenKhoa);
            this.groupBoxThongTin.Controls.Add(this.lblKinhNghiem);
            this.groupBoxThongTin.Controls.Add(this.lblTenBS);
            this.groupBoxThongTin.Controls.Add(this.lblMaBS);
            this.groupBoxThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThongTin.Location = new System.Drawing.Point(15, 60);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Size = new System.Drawing.Size(400, 200);
            this.groupBoxThongTin.TabIndex = 0;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Thông Tin Bác Sĩ";
            // 
            // txtChuyenKhoa
            // 
            this.txtChuyenKhoa.Location = new System.Drawing.Point(150, 155);
            this.txtChuyenKhoa.Name = "txtChuyenKhoa";
            this.txtChuyenKhoa.Size = new System.Drawing.Size(230, 23);
            this.txtChuyenKhoa.TabIndex = 7;
            this.txtChuyenKhoa.TextChanged += new System.EventHandler(this.txtChuyenKhoa_TextChanged);
            // 
            // txtKinhNghiem
            // 
            this.txtKinhNghiem.Location = new System.Drawing.Point(150, 115);
            this.txtKinhNghiem.Name = "txtKinhNghiem";
            this.txtKinhNghiem.Size = new System.Drawing.Size(230, 23);
            this.txtKinhNghiem.TabIndex = 6;
            this.txtKinhNghiem.TextChanged += new System.EventHandler(this.txtKinhNghiem_TextChanged);
            // 
            // txtTenBS
            // 
            this.txtTenBS.Location = new System.Drawing.Point(150, 75);
            this.txtTenBS.Name = "txtTenBS";
            this.txtTenBS.Size = new System.Drawing.Size(230, 23);
            this.txtTenBS.TabIndex = 5;
            this.txtTenBS.TextChanged += new System.EventHandler(this.txtTenBS_TextChanged);
            // 
            // txtMaBS
            // 
            this.txtMaBS.Location = new System.Drawing.Point(150, 35);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(230, 23);
            this.txtMaBS.TabIndex = 4;
            this.txtMaBS.TextChanged += new System.EventHandler(this.txtMaBS_TextChanged);
            // 
            // lblChuyenKhoa
            // 
            this.lblChuyenKhoa.AutoSize = true;
            this.lblChuyenKhoa.Location = new System.Drawing.Point(20, 158);
            this.lblChuyenKhoa.Name = "lblChuyenKhoa";
            this.lblChuyenKhoa.Size = new System.Drawing.Size(97, 17);
            this.lblChuyenKhoa.TabIndex = 3;
            this.lblChuyenKhoa.Text = "Chuyên Khoa:";
            // 
            // lblKinhNghiem
            // 
            this.lblKinhNghiem.AutoSize = true;
            this.lblKinhNghiem.Location = new System.Drawing.Point(20, 118);
            this.lblKinhNghiem.Name = "lblKinhNghiem";
            this.lblKinhNghiem.Size = new System.Drawing.Size(92, 17);
            this.lblKinhNghiem.TabIndex = 2;
            this.lblKinhNghiem.Text = "Kinh Nghiệm:";
            // 
            // lblTenBS
            // 
            this.lblTenBS.AutoSize = true;
            this.lblTenBS.Location = new System.Drawing.Point(20, 78);
            this.lblTenBS.Name = "lblTenBS";
            this.lblTenBS.Size = new System.Drawing.Size(59, 17);
            this.lblTenBS.TabIndex = 1;
            this.lblTenBS.Text = "Tên BS:";
            // 
            // lblMaBS
            // 
            this.lblMaBS.AutoSize = true;
            this.lblMaBS.Location = new System.Drawing.Point(20, 38);
            this.lblMaBS.Name = "lblMaBS";
            this.lblMaBS.Size = new System.Drawing.Size(53, 17);
            this.lblMaBS.TabIndex = 0;
            this.lblMaBS.Text = "Mã BS:";
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDanhSach.Controls.Add(this.dgvBacSi);
            this.groupBoxDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDanhSach.Location = new System.Drawing.Point(15, 280);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(825, 280);
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
            this.colTenBS,
            this.colKinhNghiem,
            this.colChuyenKhoa});
            this.dgvBacSi.Location = new System.Drawing.Point(6, 25);
            this.dgvBacSi.MultiSelect = false;
            this.dgvBacSi.Name = "dgvBacSi";
            this.dgvBacSi.ReadOnly = true;
            this.dgvBacSi.RowHeadersWidth = 51;
            this.dgvBacSi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBacSi.Size = new System.Drawing.Size(810, 245);
            this.dgvBacSi.TabIndex = 0;
            // 
            // colMaBS
            // 
            this.colMaBS.HeaderText = "Mã Bác Sĩ";
            this.colMaBS.MinimumWidth = 6;
            this.colMaBS.Name = "colMaBS";
            this.colMaBS.ReadOnly = true;
            // 
            // colTenBS
            // 
            this.colTenBS.HeaderText = "Tên Bác Sĩ";
            this.colTenBS.MinimumWidth = 6;
            this.colTenBS.Name = "colTenBS";
            this.colTenBS.ReadOnly = true;
            // 
            // colKinhNghiem
            // 
            this.colKinhNghiem.HeaderText = "Kinh Nghiệm";
            this.colKinhNghiem.MinimumWidth = 6;
            this.colKinhNghiem.Name = "colKinhNghiem";
            this.colKinhNghiem.ReadOnly = true;
            // 
            // colChuyenKhoa
            // 
            this.colChuyenKhoa.HeaderText = "Chuyên Khoa";
            this.colChuyenKhoa.MinimumWidth = 6;
            this.colChuyenKhoa.Name = "colChuyenKhoa";
            this.colChuyenKhoa.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(450, 98);
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
            this.btnSua.Location = new System.Drawing.Point(585, 98);
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
            this.btnXoa.Location = new System.Drawing.Point(450, 166);
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
            this.btnLamMoi.Location = new System.Drawing.Point(585, 166);
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
            // FormQuanLyBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 572);
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
        private System.Windows.Forms.TextBox txtKinhNghiem;
        private System.Windows.Forms.TextBox txtTenBS;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.Label lblChuyenKhoa;
        private System.Windows.Forms.Label lblKinhNghiem;
        private System.Windows.Forms.Label lblTenBS;
        private System.Windows.Forms.Label lblMaBS;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.DataGridView dgvBacSi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKinhNghiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenKhoa;
    }
}