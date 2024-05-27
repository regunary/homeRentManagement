
namespace QuanLyNhaTroMain.QuanLy
{
    partial class dichvu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dichvu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvQLDV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.tbTenDichVu = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbTenDichVu = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.lbDanhSachDichVu = new System.Windows.Forms.Label();
            this.lbChucNang = new System.Windows.Forms.Label();
            this.lbThongTinDichVu = new System.Windows.Forms.Label();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvQLDV);
            this.panel1.Location = new System.Drawing.Point(13, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 591);
            this.panel1.TabIndex = 0;
            // 
            // dgvQLDV
            // 
            this.dgvQLDV.AllowUserToAddRows = false;
            this.dgvQLDV.AllowUserToDeleteRows = false;
            this.dgvQLDV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQLDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvQLDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQLDV.Location = new System.Drawing.Point(0, 0);
            this.dgvQLDV.Name = "dgvQLDV";
            this.dgvQLDV.ReadOnly = true;
            this.dgvQLDV.RowHeadersWidth = 51;
            this.dgvQLDV.RowTemplate.Height = 24;
            this.dgvQLDV.Size = new System.Drawing.Size(656, 587);
            this.dgvQLDV.TabIndex = 0;
            this.dgvQLDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLDV_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbDonGia);
            this.panel2.Controls.Add(this.tbTenDichVu);
            this.panel2.Controls.Add(this.tbID);
            this.panel2.Controls.Add(this.lbDonGia);
            this.panel2.Controls.Add(this.lbTenDichVu);
            this.panel2.Controls.Add(this.lbID);
            this.panel2.Location = new System.Drawing.Point(693, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 259);
            this.panel2.TabIndex = 1;
            // 
            // tbDonGia
            // 
            this.tbDonGia.Enabled = false;
            this.tbDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDonGia.Location = new System.Drawing.Point(207, 170);
            this.tbDonGia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbDonGia.Multiline = true;
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(382, 40);
            this.tbDonGia.TabIndex = 5;
            // 
            // tbTenDichVu
            // 
            this.tbTenDichVu.Enabled = false;
            this.tbTenDichVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenDichVu.Location = new System.Drawing.Point(207, 96);
            this.tbTenDichVu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbTenDichVu.Multiline = true;
            this.tbTenDichVu.Name = "tbTenDichVu";
            this.tbTenDichVu.Size = new System.Drawing.Size(382, 40);
            this.tbTenDichVu.TabIndex = 4;
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(207, 21);
            this.tbID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(382, 43);
            this.tbID.TabIndex = 3;
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDonGia.Location = new System.Drawing.Point(47, 187);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(82, 23);
            this.lbDonGia.TabIndex = 2;
            this.lbDonGia.Text = "Đơn giá:";
            // 
            // lbTenDichVu
            // 
            this.lbTenDichVu.AutoSize = true;
            this.lbTenDichVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenDichVu.Location = new System.Drawing.Point(47, 113);
            this.lbTenDichVu.Name = "lbTenDichVu";
            this.lbTenDichVu.Size = new System.Drawing.Size(113, 23);
            this.lbTenDichVu.TabIndex = 1;
            this.lbTenDichVu.Text = "Tên dịch vụ:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbID.Location = new System.Drawing.Point(47, 41);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(38, 23);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btXoa);
            this.panel3.Controls.Add(this.btSua);
            this.panel3.Controls.Add(this.btThem);
            this.panel3.Location = new System.Drawing.Point(697, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 173);
            this.panel3.TabIndex = 2;
            // 
            // btXoa
            // 
            this.btXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Location = new System.Drawing.Point(454, 58);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(142, 53);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.Appearance.Options.UseFont = true;
            this.btSua.Location = new System.Drawing.Point(264, 58);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(145, 53);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.Appearance.Options.UseFont = true;
            this.btThem.Location = new System.Drawing.Point(87, 58);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(144, 53);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // lbDanhSachDichVu
            // 
            this.lbDanhSachDichVu.AutoSize = true;
            this.lbDanhSachDichVu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDanhSachDichVu.ForeColor = System.Drawing.Color.Green;
            this.lbDanhSachDichVu.Location = new System.Drawing.Point(33, -1);
            this.lbDanhSachDichVu.Name = "lbDanhSachDichVu";
            this.lbDanhSachDichVu.Size = new System.Drawing.Size(237, 32);
            this.lbDanhSachDichVu.TabIndex = 0;
            this.lbDanhSachDichVu.Text = "Danh sách dịch vụ";
            // 
            // lbChucNang
            // 
            this.lbChucNang.AutoSize = true;
            this.lbChucNang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChucNang.ForeColor = System.Drawing.Color.Green;
            this.lbChucNang.Location = new System.Drawing.Point(740, 300);
            this.lbChucNang.Name = "lbChucNang";
            this.lbChucNang.Size = new System.Drawing.Size(147, 32);
            this.lbChucNang.TabIndex = 3;
            this.lbChucNang.Text = "Chức năng";
            // 
            // lbThongTinDichVu
            // 
            this.lbThongTinDichVu.AutoSize = true;
            this.lbThongTinDichVu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThongTinDichVu.ForeColor = System.Drawing.Color.Green;
            this.lbThongTinDichVu.Location = new System.Drawing.Point(720, -1);
            this.lbThongTinDichVu.Name = "lbThongTinDichVu";
            this.lbThongTinDichVu.Size = new System.Drawing.Size(229, 32);
            this.lbThongTinDichVu.TabIndex = 4;
            this.lbThongTinDichVu.Text = "Thông tin dịch vụ";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Location = new System.Drawing.Point(854, 522);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(157, 53);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(1107, 522);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(6);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(188, 53);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 775);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lbThongTinDichVu);
            this.Controls.Add(this.lbChucNang);
            this.Controls.Add(this.lbDanhSachDichVu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dichvu";
            this.Text = "Dịch Vụ";
            this.Load += new System.EventHandler(this.dichvu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvQLDV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbDonGia;
        private System.Windows.Forms.TextBox tbTenDichVu;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbTenDichVu;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private System.Windows.Forms.Label lbDanhSachDichVu;
        private System.Windows.Forms.Label lbChucNang;
        private System.Windows.Forms.Label lbThongTinDichVu;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}