
namespace QuanLyNhaTroMain.Chuc_nang
{
    partial class formSapPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSapPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listDanhSachKhachDangKy = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvPhong = new System.Windows.Forms.ListView();
            this.maphonga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenphonga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lbPKC = new System.Windows.Forms.Label();
            this.lbnhapPKC = new System.Windows.Forms.Panel();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtTienDatCoc = new System.Windows.Forms.TextBox();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbPCK1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btClear = new DevExpress.XtraEditors.SimpleButton();
            this.rdnTuNhap = new System.Windows.Forms.RadioButton();
            this.cbKV = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.buttonX2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.lbnhapPKC.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.listDanhSachKhachDangKy);
            this.panel1.Location = new System.Drawing.Point(27, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 277);
            this.panel1.TabIndex = 0;
            // 
            // listDanhSachKhachDangKy
            // 
            this.listDanhSachKhachDangKy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listDanhSachKhachDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDanhSachKhachDangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDanhSachKhachDangKy.FullRowSelect = true;
            this.listDanhSachKhachDangKy.GridLines = true;
            this.listDanhSachKhachDangKy.HideSelection = false;
            this.listDanhSachKhachDangKy.Location = new System.Drawing.Point(0, 0);
            this.listDanhSachKhachDangKy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listDanhSachKhachDangKy.Name = "listDanhSachKhachDangKy";
            this.listDanhSachKhachDangKy.Size = new System.Drawing.Size(585, 273);
            this.listDanhSachKhachDangKy.TabIndex = 1;
            this.listDanhSachKhachDangKy.UseCompatibleStateImageBehavior = false;
            this.listDanhSachKhachDangKy.View = System.Windows.Forms.View.Details;
            this.listDanhSachKhachDangKy.Click += new System.EventHandler(this.listDanhSachKhachDangKy_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã khách";
            this.columnHeader1.Width = 185;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 400;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lvPhong);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(27, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 228);
            this.panel2.TabIndex = 1;
            // 
            // lvPhong
            // 
            this.lvPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maphonga,
            this.tenphonga});
            this.lvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPhong.HideSelection = false;
            this.lvPhong.Location = new System.Drawing.Point(0, 77);
            this.lvPhong.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lvPhong.Name = "lvPhong";
            this.lvPhong.Size = new System.Drawing.Size(585, 147);
            this.lvPhong.TabIndex = 62;
            this.lvPhong.UseCompatibleStateImageBehavior = false;
            //this.lvPhong.SelectedIndexChanged += new System.EventHandler(this.lvPhong_SelectedIndexChanged);
            this.lvPhong.Click += new System.EventHandler(this.lvPhong_Click);
            // 
            // maphonga
            // 
            this.maphonga.Text = "Mã phòng";
            // 
            // tenphonga
            // 
            this.tenphonga.Text = "Tên phòng";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbLoaiPhong);
            this.panel6.Controls.Add(this.lbPKC);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(585, 77);
            this.panel6.TabIndex = 0;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(226, 22);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(127, 30);
            this.cbLoaiPhong.TabIndex = 16;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // lbPKC
            // 
            this.lbPKC.AutoSize = true;
            this.lbPKC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPKC.Location = new System.Drawing.Point(3, 29);
            this.lbPKC.Name = "lbPKC";
            this.lbPKC.Size = new System.Drawing.Size(197, 23);
            this.lbPKC.TabIndex = 11;
            this.lbPKC.Text = "Loại phòng khách đặt:";
            // 
            // lbnhapPKC
            // 
            this.lbnhapPKC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbnhapPKC.Controls.Add(this.cbGioiTinh);
            this.lbnhapPKC.Controls.Add(this.txtTienDatCoc);
            this.lbnhapPKC.Controls.Add(this.txtNgheNghiep);
            this.lbnhapPKC.Controls.Add(this.txtQueQuan);
            this.lbnhapPKC.Controls.Add(this.txtCMND);
            this.lbnhapPKC.Controls.Add(this.dtpNgaySinh);
            this.lbnhapPKC.Controls.Add(this.txtTen);
            this.lbnhapPKC.Controls.Add(this.txtHo);
            this.lbnhapPKC.Controls.Add(this.label14);
            this.lbnhapPKC.Controls.Add(this.label13);
            this.lbnhapPKC.Controls.Add(this.label12);
            this.lbnhapPKC.Controls.Add(this.label11);
            this.lbnhapPKC.Controls.Add(this.label10);
            this.lbnhapPKC.Controls.Add(this.label9);
            this.lbnhapPKC.Controls.Add(this.label8);
            this.lbnhapPKC.Location = new System.Drawing.Point(651, 75);
            this.lbnhapPKC.Name = "lbnhapPKC";
            this.lbnhapPKC.Size = new System.Drawing.Size(772, 340);
            this.lbnhapPKC.TabIndex = 2;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(207, 58);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(116, 30);
            this.cbGioiTinh.TabIndex = 64;
            // 
            // txtTienDatCoc
            // 
            this.txtTienDatCoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDatCoc.Location = new System.Drawing.Point(207, 291);
            this.txtTienDatCoc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTienDatCoc.Name = "txtTienDatCoc";
            this.txtTienDatCoc.Size = new System.Drawing.Size(300, 30);
            this.txtTienDatCoc.TabIndex = 63;
            this.txtTienDatCoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienDatCoc_KeyPress);
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgheNghiep.Location = new System.Drawing.Point(207, 243);
            this.txtNgheNghiep.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(300, 30);
            this.txtNgheNghiep.TabIndex = 60;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.Location = new System.Drawing.Point(207, 193);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(300, 30);
            this.txtQueQuan.TabIndex = 58;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(207, 146);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(300, 30);
            this.txtCMND.TabIndex = 57;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(207, 98);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(145, 30);
            this.dtpNgaySinh.TabIndex = 56;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(384, 13);
            this.txtTen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(123, 30);
            this.txtTen.TabIndex = 54;
            // 
            // txtHo
            // 
            this.txtHo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Location = new System.Drawing.Point(205, 13);
            this.txtHo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(169, 30);
            this.txtHo.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(54, 298);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 23);
            this.label14.TabIndex = 6;
            this.label14.Text = "Tiền đặt cọc:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(54, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 23);
            this.label13.TabIndex = 5;
            this.label13.Text = "Nghề nghiệp:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(54, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Quê quán:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(54, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "CMND:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(54, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Giới tính:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(54, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(54, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Họ và tên:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lbPCK1);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.lbGia);
            this.panel4.Controls.Add(this.lbTenPhong);
            this.panel4.Controls.Add(this.lbMaPhong);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(649, 435);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(773, 77);
            this.panel4.TabIndex = 3;
            // 
            // lbPCK1
            // 
            this.lbPCK1.AutoSize = true;
            this.lbPCK1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPCK1.ForeColor = System.Drawing.Color.Red;
            this.lbPCK1.Location = new System.Drawing.Point(551, 33);
            this.lbPCK1.Name = "lbPCK1";
            this.lbPCK1.Size = new System.Drawing.Size(51, 22);
            this.lbPCK1.TabIndex = 72;
            this.lbPCK1.Text = "Loại ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label19.Location = new System.Drawing.Point(433, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 23);
            this.label19.TabIndex = 71;
            this.label19.Text = "Loại Phòng:";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.ForeColor = System.Drawing.Color.Red;
            this.lbGia.Location = new System.Drawing.Point(693, 33);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(39, 22);
            this.lbGia.TabIndex = 70;
            this.lbGia.Text = "Giá";
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPhong.ForeColor = System.Drawing.Color.Red;
            this.lbTenPhong.Location = new System.Drawing.Point(322, 33);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(93, 22);
            this.lbTenPhong.TabIndex = 69;
            this.lbTenPhong.Text = "Tên Phòng";
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhong.ForeColor = System.Drawing.Color.Red;
            this.lbMaPhong.Location = new System.Drawing.Point(141, 33);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(89, 22);
            this.lbMaPhong.TabIndex = 68;
            this.lbMaPhong.Text = "Mã Phòng";
            this.lbMaPhong.Click += new System.EventHandler(this.lbMaPhong_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(639, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 23);
            this.label17.TabIndex = 67;
            this.label17.Text = "Giá:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(247, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 23);
            this.label16.TabIndex = 66;
            this.label16.Text = "Phòng:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(33, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 23);
            this.label15.TabIndex = 65;
            this.label15.Text = "Mã Phòng:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.dtpNgayThue);
            this.panel5.Location = new System.Drawing.Point(660, 562);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(334, 54);
            this.panel5.TabIndex = 4;
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThue.Location = new System.Drawing.Point(14, 12);
            this.dtpNgayThue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(302, 30);
            this.dtpNgayThue.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn khu vực:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(195, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Danh sách đăng ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(935, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thông tin phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(195, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Danh sách phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(935, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thông tin đăng ký";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(729, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày thuê:";
            // 
            // btLuu
            // 
            this.btLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLuu.Appearance.Options.UseFont = true;
            this.btLuu.Location = new System.Drawing.Point(8655, 5336);
            this.btLuu.Margin = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(1135, 531);
            this.btLuu.TabIndex = 11;
            this.btLuu.Text = "Lưu";
            // 
            // btClear
            // 
            this.btClear.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClear.Appearance.Options.UseFont = true;
            this.btClear.Location = new System.Drawing.Point(10062, 5336);
            this.btClear.Margin = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(1135, 531);
            this.btClear.TabIndex = 12;
            this.btClear.Text = "Clear";
            // 
            // rdnTuNhap
            // 
            this.rdnTuNhap.AutoSize = true;
            this.rdnTuNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdnTuNhap.Location = new System.Drawing.Point(649, 19);
            this.rdnTuNhap.Name = "rdnTuNhap";
            this.rdnTuNhap.Size = new System.Drawing.Size(304, 30);
            this.rdnTuNhap.TabIndex = 14;
            this.rdnTuNhap.Text = "Tự nhập thông tin đăng ký";
            this.rdnTuNhap.UseVisualStyleBackColor = true;
            this.rdnTuNhap.CheckedChanged += new System.EventHandler(this.rdnTuNhap_CheckedChanged);
            // 
            // cbKV
            // 
            this.cbKV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKV.FormattingEnabled = true;
            this.cbKV.Location = new System.Drawing.Point(198, 18);
            this.cbKV.Name = "cbKV";
            this.cbKV.Size = new System.Drawing.Size(216, 30);
            this.cbKV.TabIndex = 15;
            this.cbKV.SelectedIndexChanged += new System.EventHandler(this.cbKV_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(1037, 566);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 42);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX2.Location = new System.Drawing.Point(1230, 566);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(167, 42);
            this.buttonX2.TabIndex = 17;
            this.buttonX2.Text = "Huỷ";
            this.buttonX2.UseVisualStyleBackColor = false;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // formSapPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 684);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbKV);
            this.Controls.Add(this.rdnTuNhap);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbnhapPKC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formSapPhong";
            this.Text = "Khách đăng ký Phòng";
            this.Load += new System.EventHandler(this.formSapPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.lbnhapPKC.ResumeLayout(false);
            this.lbnhapPKC.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel lbnhapPKC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView listDanhSachKhachDangKy;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvPhong;
        private System.Windows.Forms.ColumnHeader maphonga;
        private System.Windows.Forms.ColumnHeader tenphonga;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbPKC;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtTienDatCoc;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.SimpleButton btClear;
        private System.Windows.Forms.RadioButton rdnTuNhap;
        private System.Windows.Forms.ComboBox cbKV;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button buttonX2;
        private System.Windows.Forms.Label lbPCK1;
        private System.Windows.Forms.Label label19;
    }
}