
namespace QuanLyNhaTroMain.QuanLy
{
    partial class formThemPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formThemPhong));
            this.lbThemPhong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbtHuy = new DevExpress.XtraEditors.SimpleButton();
            this.sbtThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbKV = new System.Windows.Forms.ComboBox();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.lbKhuVuc = new System.Windows.Forms.Label();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbThemPhong
            // 
            this.lbThemPhong.AutoSize = true;
            this.lbThemPhong.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemPhong.Location = new System.Drawing.Point(465, 34);
            this.lbThemPhong.Name = "lbThemPhong";
            this.lbThemPhong.Size = new System.Drawing.Size(235, 46);
            this.lbThemPhong.TabIndex = 0;
            this.lbThemPhong.Text = "Thêm Phòng";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.sbtHuy);
            this.panel1.Controls.Add(this.sbtThem);
            this.panel1.Controls.Add(this.txtDay);
            this.panel1.Controls.Add(this.txtTenPhong);
            this.panel1.Controls.Add(this.txtMaPhong);
            this.panel1.Controls.Add(this.cbLoaiPhong);
            this.panel1.Controls.Add(this.cbKV);
            this.panel1.Controls.Add(this.lbTenPhong);
            this.panel1.Controls.Add(this.lbLoaiPhong);
            this.panel1.Controls.Add(this.lbDay);
            this.panel1.Controls.Add(this.lbKhuVuc);
            this.panel1.Controls.Add(this.lbMaPhong);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(47, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 533);
            this.panel1.TabIndex = 1;
            // 
            // sbtHuy
            // 
            this.sbtHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.sbtHuy.Appearance.Options.UseFont = true;
            this.sbtHuy.Location = new System.Drawing.Point(643, 417);
            this.sbtHuy.Name = "sbtHuy";
            this.sbtHuy.Size = new System.Drawing.Size(119, 56);
            this.sbtHuy.TabIndex = 14;
            this.sbtHuy.Text = "Hủy";
            this.sbtHuy.Click += new System.EventHandler(this.sbtHuy_Click);
            // 
            // sbtThem
            // 
            this.sbtThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.sbtThem.Appearance.Options.UseFont = true;
            this.sbtThem.Location = new System.Drawing.Point(440, 417);
            this.sbtThem.Name = "sbtThem";
            this.sbtThem.Size = new System.Drawing.Size(133, 56);
            this.sbtThem.TabIndex = 13;
            this.sbtThem.Text = "Thêm";
            this.sbtThem.Click += new System.EventHandler(this.sbtThem_Click);
            // 
            // txtDay
            // 
            this.txtDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDay.Location = new System.Drawing.Point(240, 322);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(246, 30);
            this.txtDay.TabIndex = 12;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(840, 220);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(186, 30);
            this.txtTenPhong.TabIndex = 11;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(240, 117);
            this.txtMaPhong.Multiline = true;
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(246, 33);
            this.txtMaPhong.TabIndex = 10;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(840, 120);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(186, 30);
            this.cbLoaiPhong.TabIndex = 9;
            // 
            // cbKV
            // 
            this.cbKV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKV.FormattingEnabled = true;
            this.cbKV.Location = new System.Drawing.Point(240, 220);
            this.cbKV.Name = "cbKV";
            this.cbKV.Size = new System.Drawing.Size(246, 30);
            this.cbKV.TabIndex = 8;
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenPhong.Location = new System.Drawing.Point(678, 224);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(128, 26);
            this.lbTenPhong.TabIndex = 4;
            this.lbTenPhong.Text = "Tên phòng:";
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.AutoSize = true;
            this.lbLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLoaiPhong.Location = new System.Drawing.Point(678, 124);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(136, 26);
            this.lbLoaiPhong.TabIndex = 3;
            this.lbLoaiPhong.Text = "Loại phòng:";
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDay.Location = new System.Drawing.Point(80, 326);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(61, 26);
            this.lbDay.TabIndex = 2;
            this.lbDay.Text = "Dãy:";
            // 
            // lbKhuVuc
            // 
            this.lbKhuVuc.AutoSize = true;
            this.lbKhuVuc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKhuVuc.Location = new System.Drawing.Point(80, 228);
            this.lbKhuVuc.Name = "lbKhuVuc";
            this.lbKhuVuc.Size = new System.Drawing.Size(107, 26);
            this.lbKhuVuc.TabIndex = 1;
            this.lbKhuVuc.Text = "Khu vực:";
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaPhong.Location = new System.Drawing.Point(80, 124);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(124, 26);
            this.lbMaPhong.TabIndex = 0;
            this.lbMaPhong.Text = "Mã phòng:";
            // 
            // formThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 634);
            this.Controls.Add(this.lbThemPhong);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formThemPhong";
            this.Text = "Thêm Phòng";
            this.Load += new System.EventHandler(this.formThemPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThemPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Label lbLoaiPhong;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Label lbKhuVuc;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.ComboBox cbKV;
        private DevExpress.XtraEditors.SimpleButton sbtHuy;
        private DevExpress.XtraEditors.SimpleButton sbtThem;
    }
}