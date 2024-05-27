
namespace QuanLyNhaTroMain.Chuc_nang
{
    partial class formThemNguoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formThemNguoi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvPhong = new System.Windows.Forms.ListView();
            this.maphonga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenphonga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTienDatCoc = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.lbSoNguoi = new System.Windows.Forms.Label();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lvKhachThue = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btClear = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonX2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbKV = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lvPhong);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 431);
            this.panel1.TabIndex = 0;
            // 
            // lvPhong
            // 
            this.lvPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maphonga,
            this.tenphonga});
            this.lvPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPhong.HideSelection = false;
            this.lvPhong.Location = new System.Drawing.Point(0, 110);
            this.lvPhong.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lvPhong.Name = "lvPhong";
            this.lvPhong.Size = new System.Drawing.Size(503, 313);
            this.lvPhong.TabIndex = 62;
            this.lvPhong.UseCompatibleStateImageBehavior = false;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbLoaiPhong);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 92);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(137, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách phòng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(204, 42);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(218, 30);
            this.cbLoaiPhong.TabIndex = 72;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(7, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chọn loại phòng";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cbGioiTinh);
            this.panel3.Controls.Add(this.txtNgheNghiep);
            this.panel3.Controls.Add(this.txtQueQuan);
            this.panel3.Controls.Add(this.txtCMND);
            this.panel3.Controls.Add(this.txtTienDatCoc);
            this.panel3.Controls.Add(this.dtpNgaySinh);
            this.panel3.Controls.Add(this.txtTen);
            this.panel3.Controls.Add(this.txtHo);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(14, 518);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1038, 264);
            this.panel3.TabIndex = 1;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(169, 130);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(218, 30);
            this.cbGioiTinh.TabIndex = 73;
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgheNghiep.Location = new System.Drawing.Point(710, 155);
            this.txtNgheNghiep.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(292, 30);
            this.txtNgheNghiep.TabIndex = 66;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.Location = new System.Drawing.Point(713, 100);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(292, 30);
            this.txtQueQuan.TabIndex = 65;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(713, 49);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(292, 30);
            this.txtCMND.TabIndex = 64;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // txtTienDatCoc
            // 
            this.txtTienDatCoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDatCoc.Location = new System.Drawing.Point(168, 179);
            this.txtTienDatCoc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTienDatCoc.Name = "txtTienDatCoc";
            this.txtTienDatCoc.Size = new System.Drawing.Size(219, 30);
            this.txtTienDatCoc.TabIndex = 63;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(169, 84);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(191, 30);
            this.dtpNgaySinh.TabIndex = 56;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(372, 35);
            this.txtTen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(109, 30);
            this.txtTen.TabIndex = 54;
            // 
            // txtHo
            // 
            this.txtHo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Location = new System.Drawing.Point(169, 35);
            this.txtHo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(193, 30);
            this.txtHo.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(531, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 23);
            this.label14.TabIndex = 16;
            this.label14.Text = "Nghề nghiệp:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(572, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "CMND*:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(555, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Quê quán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(38, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Giới tính*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(24, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ngày sinh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(24, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Họ và tên*:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(3, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Tiền đặt cọc:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dtpNgayThue);
            this.panel4.Location = new System.Drawing.Point(1102, 518);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 68);
            this.panel4.TabIndex = 2;
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThue.Location = new System.Drawing.Point(57, 21);
            this.dtpNgayThue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(232, 30);
            this.dtpNgayThue.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lbGia);
            this.panel5.Controls.Add(this.lbTenPhong);
            this.panel5.Controls.Add(this.lbSoNguoi);
            this.panel5.Controls.Add(this.lbMaPhong);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(537, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(916, 426);
            this.panel5.TabIndex = 3;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGia.ForeColor = System.Drawing.Color.Red;
            this.lbGia.Location = new System.Drawing.Point(100, 68);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(56, 23);
            this.lbGia.TabIndex = 25;
            this.lbGia.Text = "lbGia";
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenPhong.ForeColor = System.Drawing.Color.Red;
            this.lbTenPhong.Location = new System.Drawing.Point(362, 25);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(108, 23);
            this.lbTenPhong.TabIndex = 24;
            this.lbTenPhong.Text = "lbTenPhong";
            // 
            // lbSoNguoi
            // 
            this.lbSoNguoi.AutoSize = true;
            this.lbSoNguoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoNguoi.ForeColor = System.Drawing.Color.Red;
            this.lbSoNguoi.Location = new System.Drawing.Point(672, 24);
            this.lbSoNguoi.Name = "lbSoNguoi";
            this.lbSoNguoi.Size = new System.Drawing.Size(91, 23);
            this.lbSoNguoi.TabIndex = 23;
            this.lbSoNguoi.Text = "lbSonguoi";
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaPhong.ForeColor = System.Drawing.Color.Red;
            this.lbMaPhong.Location = new System.Drawing.Point(142, 25);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(105, 23);
            this.lbMaPhong.TabIndex = 22;
            this.lbMaPhong.Text = "lbMaPhong";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lvKhachThue);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 111);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(912, 311);
            this.panel6.TabIndex = 21;
            // 
            // lvKhachThue
            // 
            this.lvKhachThue.BackColor = System.Drawing.Color.LightBlue;
            this.lvKhachThue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.lvKhachThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvKhachThue.GridLines = true;
            this.lvKhachThue.HideSelection = false;
            this.lvKhachThue.Location = new System.Drawing.Point(15, 0);
            this.lvKhachThue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lvKhachThue.Name = "lvKhachThue";
            this.lvKhachThue.Size = new System.Drawing.Size(880, 311);
            this.lvKhachThue.TabIndex = 63;
            this.lvKhachThue.UseCompatibleStateImageBehavior = false;
            this.lvKhachThue.View = System.Windows.Forms.View.Details;
            this.lvKhachThue.SelectedIndexChanged += new System.EventHandler(this.lvKhachThue_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Khách";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ và tên";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày Sinh";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nghề nghiệp";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 420;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(665, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 23);
            this.label15.TabIndex = 17;
            this.label15.Text = "Phòng đầy!";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(508, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(158, 23);
            this.label16.TabIndex = 18;
            this.label16.Text = "Số người hiện tại:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(273, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 23);
            this.label17.TabIndex = 19;
            this.label17.Text = "Phòng:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(26, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 20;
            this.label18.Text = "Mã phòng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(26, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn khu vực";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(841, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thông tin phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(470, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thông tin đăng ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1218, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày thuê";
            // 
            // btLuu
            // 
            this.btLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLuu.Appearance.Options.UseFont = true;
            this.btLuu.Location = new System.Drawing.Point(5400, 2374);
            this.btLuu.Margin = new System.Windows.Forms.Padding(15);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(635, 336);
            this.btLuu.TabIndex = 9;
            this.btLuu.Text = "Lưu";
            // 
            // btClear
            // 
            this.btClear.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClear.Appearance.Options.UseFont = true;
            this.btClear.Location = new System.Drawing.Point(6212, 2374);
            this.btClear.Margin = new System.Windows.Forms.Padding(15);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(635, 336);
            this.btClear.TabIndex = 10;
            this.btClear.Text = "Clear";
            // 
            // ButtonX2
            // 
            this.ButtonX2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX2.Location = new System.Drawing.Point(1132, 637);
            this.ButtonX2.Name = "ButtonX2";
            this.ButtonX2.Size = new System.Drawing.Size(107, 43);
            this.ButtonX2.TabIndex = 69;
            this.ButtonX2.Text = "Clear";
            this.ButtonX2.UseVisualStyleBackColor = true;
            this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1309, 637);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 43);
            this.btnSave.TabIndex = 70;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbKV
            // 
            this.cbKV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKV.FormattingEnabled = true;
            this.cbKV.Location = new System.Drawing.Point(184, 14);
            this.cbKV.Name = "cbKV";
            this.cbKV.Size = new System.Drawing.Size(218, 31);
            this.cbKV.TabIndex = 71;
            this.cbKV.SelectedIndexChanged += new System.EventHandler(this.cbKV_SelectedIndexChanged_1);
            // 
            // formThemNguoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 794);
            this.Controls.Add(this.cbKV);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ButtonX2);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formThemNguoi";
            this.Text = "Thêm Người";
            this.Load += new System.EventHandler(this.formThemNguoi_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView lvPhong;
        private System.Windows.Forms.ColumnHeader maphonga;
        private System.Windows.Forms.ColumnHeader tenphonga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTienDatCoc;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.SimpleButton btClear;
        private System.Windows.Forms.Button ButtonX2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.ComboBox cbKV;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label lbSoNguoi;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView lvKhachThue;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}