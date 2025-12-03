namespace Quan_li_benh_vien
{
  partial class FormThongKe
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
   this.SuspendLayout();
   // lblTitle
      this.lblTitle.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
  this.lblTitle.ForeColor = System.Drawing.Color.White;
 this.lblTitle.Location = new System.Drawing.Point(0, 0);
       this.lblTitle.Name = "lblTitle";
     this.lblTitle.Size = new System.Drawing.Size(1000, 60);
this.lblTitle.Text = "📊 THỐNG KÊ & BÁO CÁO";
    this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
// FormThongKe
this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
       this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
       this.ClientSize = new System.Drawing.Size(1000, 670);
this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
       this.Name = "FormThongKe";
     this.ResumeLayout(false);
  }

        private System.Windows.Forms.Label lblTitle;
    }
}
