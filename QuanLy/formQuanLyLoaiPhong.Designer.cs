
namespace QuanLyNhaTroMain.QuanLy
{
    partial class formQuanLyLoaiPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuanLyLoaiPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvQLLP = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtTLP = new System.Windows.Forms.TextBox();
            this.txtMLP = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbDienTich = new System.Windows.Forms.Label();
            this.lbTenLoaiPhong = new System.Windows.Forms.Label();
            this.lbMaLoaiPhong = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.lbDanhSachLoaiPhong = new System.Windows.Forms.Label();
            this.lbThongTinLoaiPhong = new System.Windows.Forms.Label();
            this.lbChucNang = new System.Windows.Forms.Label();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLLP)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvQLLP);
            this.panel1.Location = new System.Drawing.Point(17, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 561);
            this.panel1.TabIndex = 0;
            // 
            // dgvQLLP
            // 
            this.dgvQLLP.AllowUserToAddRows = false;
            this.dgvQLLP.AllowUserToDeleteRows = false;
            this.dgvQLLP.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvQLLP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvQLLP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQLLP.Location = new System.Drawing.Point(0, 0);
            this.dgvQLLP.Name = "dgvQLLP";
            this.dgvQLLP.ReadOnly = true;
            this.dgvQLLP.RowHeadersWidth = 51;
            this.dgvQLLP.RowTemplate.Height = 24;
            this.dgvQLLP.Size = new System.Drawing.Size(632, 557);
            this.dgvQLLP.TabIndex = 0;
            this.dgvQLLP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLLP_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtGia);
            this.panel2.Controls.Add(this.txtDT);
            this.panel2.Controls.Add(this.txtTLP);
            this.panel2.Controls.Add(this.txtMLP);
            this.panel2.Controls.Add(this.lbGia);
            this.panel2.Controls.Add(this.lbDienTich);
            this.panel2.Controls.Add(this.lbTenLoaiPhong);
            this.panel2.Controls.Add(this.lbMaLoaiPhong);
            this.panel2.Location = new System.Drawing.Point(677, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 255);
            this.panel2.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.ForeColor = System.Drawing.Color.Red;
            this.txtGia.Location = new System.Drawing.Point(242, 192);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(287, 32);
            this.txtGia.TabIndex = 12;
            // 
            // txtDT
            // 
            this.txtDT.Enabled = false;
            this.txtDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT.Location = new System.Drawing.Point(242, 144);
            this.txtDT.Multiline = true;
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(287, 32);
            this.txtDT.TabIndex = 11;
            // 
            // txtTLP
            // 
            this.txtTLP.Enabled = false;
            this.txtTLP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTLP.Location = new System.Drawing.Point(242, 87);
            this.txtTLP.Multiline = true;
            this.txtTLP.Name = "txtTLP";
            this.txtTLP.Size = new System.Drawing.Size(287, 32);
            this.txtTLP.TabIndex = 10;
            // 
            // txtMLP
            // 
            this.txtMLP.Enabled = false;
            this.txtMLP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMLP.Location = new System.Drawing.Point(242, 34);
            this.txtMLP.Multiline = true;
            this.txtMLP.Name = "txtMLP";
            this.txtMLP.Size = new System.Drawing.Size(287, 32);
            this.txtMLP.TabIndex = 8;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(118, 202);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(45, 22);
            this.lbGia.TabIndex = 3;
            this.lbGia.Text = "Giá:";
            // 
            // lbDienTich
            // 
            this.lbDienTich.AutoSize = true;
            this.lbDienTich.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDienTich.Location = new System.Drawing.Point(41, 154);
            this.lbDienTich.Name = "lbDienTich";
            this.lbDienTich.Size = new System.Drawing.Size(131, 22);
            this.lbDienTich.TabIndex = 2;
            this.lbDienTich.Text = "Diện tích (m2):";
            // 
            // lbTenLoaiPhong
            // 
            this.lbTenLoaiPhong.AutoSize = true;
            this.lbTenLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLoaiPhong.Location = new System.Drawing.Point(38, 97);
            this.lbTenLoaiPhong.Name = "lbTenLoaiPhong";
            this.lbTenLoaiPhong.Size = new System.Drawing.Size(134, 22);
            this.lbTenLoaiPhong.TabIndex = 1;
            this.lbTenLoaiPhong.Text = "Tên loại phòng:";
            // 
            // lbMaLoaiPhong
            // 
            this.lbMaLoaiPhong.AutoSize = true;
            this.lbMaLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiPhong.Location = new System.Drawing.Point(38, 44);
            this.lbMaLoaiPhong.Name = "lbMaLoaiPhong";
            this.lbMaLoaiPhong.Size = new System.Drawing.Size(130, 22);
            this.lbMaLoaiPhong.TabIndex = 0;
            this.lbMaLoaiPhong.Text = "Mã loại phòng:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btSua);
            this.panel3.Controls.Add(this.btXoa);
            this.panel3.Controls.Add(this.btThem);
            this.panel3.Location = new System.Drawing.Point(677, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(606, 133);
            this.panel3.TabIndex = 2;
            // 
            // btSua
            // 
            this.btSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.Appearance.Options.UseFont = true;
            this.btSua.Location = new System.Drawing.Point(242, 43);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(136, 51);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Location = new System.Drawing.Point(438, 43);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(128, 51);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.Appearance.Options.UseFont = true;
            this.btThem.Location = new System.Drawing.Point(38, 43);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(130, 51);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // lbDanhSachLoaiPhong
            // 
            this.lbDanhSachLoaiPhong.AutoSize = true;
            this.lbDanhSachLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDanhSachLoaiPhong.Location = new System.Drawing.Point(27, 15);
            this.lbDanhSachLoaiPhong.Name = "lbDanhSachLoaiPhong";
            this.lbDanhSachLoaiPhong.Size = new System.Drawing.Size(231, 26);
            this.lbDanhSachLoaiPhong.TabIndex = 5;
            this.lbDanhSachLoaiPhong.Text = "Danh sách loại phòng";
            // 
            // lbThongTinLoaiPhong
            // 
            this.lbThongTinLoaiPhong.AutoSize = true;
            this.lbThongTinLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThongTinLoaiPhong.Location = new System.Drawing.Point(693, 15);
            this.lbThongTinLoaiPhong.Name = "lbThongTinLoaiPhong";
            this.lbThongTinLoaiPhong.Size = new System.Drawing.Size(224, 26);
            this.lbThongTinLoaiPhong.TabIndex = 6;
            this.lbThongTinLoaiPhong.Text = "Thông tin loại phòng";
            // 
            // lbChucNang
            // 
            this.lbChucNang.AutoSize = true;
            this.lbChucNang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChucNang.Location = new System.Drawing.Point(700, 322);
            this.lbChucNang.Name = "lbChucNang";
            this.lbChucNang.Size = new System.Drawing.Size(123, 26);
            this.lbChucNang.TabIndex = 7;
            this.lbChucNang.Text = "Chức năng";
            // 
            // btLuu
            // 
            this.btLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLuu.Appearance.Options.UseFont = true;
            this.btLuu.Location = new System.Drawing.Point(767, 531);
            this.btLuu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(202, 80);
            this.btLuu.TabIndex = 3;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btHuy
            // 
            this.btHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHuy.Appearance.Options.UseFont = true;
            this.btHuy.Location = new System.Drawing.Point(1081, 531);
            this.btHuy.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(202, 80);
            this.btHuy.TabIndex = 8;
            this.btHuy.Text = "Huỷ";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // formQuanLyLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 651);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.lbChucNang);
            this.Controls.Add(this.lbThongTinLoaiPhong);
            this.Controls.Add(this.lbDanhSachLoaiPhong);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formQuanLyLoaiPhong";
            this.Text = "Loại Phòng";
            this.Load += new System.EventHandler(this.formQuanLyLoaiPhong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLLP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvQLLP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtTLP;
        private System.Windows.Forms.TextBox txtMLP;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbDienTich;
        private System.Windows.Forms.Label lbTenLoaiPhong;
        private System.Windows.Forms.Label lbMaLoaiPhong;
        private System.Windows.Forms.Label lbDanhSachLoaiPhong;
        private System.Windows.Forms.Label lbThongTinLoaiPhong;
        private System.Windows.Forms.Label lbChucNang;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.SimpleButton btHuy;
    }
}