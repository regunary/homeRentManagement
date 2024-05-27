
namespace QuanLyNhaTroMain.Chuc_nang
{
    partial class formTraPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTraPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbKV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvPhong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbMaKhach = new System.Windows.Forms.Label();
            this.lbNgheNghiep = new System.Windows.Forms.Label();
            this.lbQueQuan = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lvKhach = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbTienDatCoc = new System.Windows.Forms.Label();
            this.lbPhong = new System.Windows.Forms.Label();
            this.dtNgayThue = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbKV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1485, 57);
            this.panel1.TabIndex = 0;
            // 
            // cbKV
            // 
            this.cbKV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKV.FormattingEnabled = true;
            this.cbKV.Location = new System.Drawing.Point(128, 4);
            this.cbKV.Name = "cbKV";
            this.cbKV.Size = new System.Drawing.Size(351, 34);
            this.cbKV.TabIndex = 1;
            this.cbKV.SelectedIndexChanged += new System.EventHandler(this.cbKV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khu vực:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 266);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lvPhong);
            this.panel3.Location = new System.Drawing.Point(11, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(731, 240);
            this.panel3.TabIndex = 0;
            // 
            // lvPhong
            // 
            this.lvPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPhong.FullRowSelect = true;
            this.lvPhong.GridLines = true;
            this.lvPhong.HideSelection = false;
            this.lvPhong.Location = new System.Drawing.Point(0, 0);
            this.lvPhong.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lvPhong.Name = "lvPhong";
            this.lvPhong.Size = new System.Drawing.Size(727, 236);
            this.lvPhong.TabIndex = 4;
            this.lvPhong.UseCompatibleStateImageBehavior = false;
            this.lvPhong.View = System.Windows.Forms.View.Details;
            this.lvPhong.Click += new System.EventHandler(this.lvPhong_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phòng";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Phòng";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Loại Phòng";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dãy";
            this.columnHeader4.Width = 100;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lbMaKhach);
            this.panel4.Controls.Add(this.lbNgheNghiep);
            this.panel4.Controls.Add(this.lbQueQuan);
            this.panel4.Controls.Add(this.lbCMND);
            this.panel4.Controls.Add(this.lbGioiTinh);
            this.panel4.Controls.Add(this.lbHoTen);
            this.panel4.Controls.Add(this.dtNgaySinh);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(815, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(602, 265);
            this.panel4.TabIndex = 2;
            // 
            // lbMaKhach
            // 
            this.lbMaKhach.AutoSize = true;
            this.lbMaKhach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhach.ForeColor = System.Drawing.Color.Red;
            this.lbMaKhach.Location = new System.Drawing.Point(459, 17);
            this.lbMaKhach.Name = "lbMaKhach";
            this.lbMaKhach.Size = new System.Drawing.Size(102, 22);
            this.lbMaKhach.TabIndex = 21;
            this.lbMaKhach.Text = "lbMaKhach";
            // 
            // lbNgheNghiep
            // 
            this.lbNgheNghiep.AutoSize = true;
            this.lbNgheNghiep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgheNghiep.Location = new System.Drawing.Point(191, 220);
            this.lbNgheNghiep.Name = "lbNgheNghiep";
            this.lbNgheNghiep.Size = new System.Drawing.Size(124, 22);
            this.lbNgheNghiep.TabIndex = 12;
            this.lbNgheNghiep.Text = "lbNgheNghiep";
            // 
            // lbQueQuan
            // 
            this.lbQueQuan.AutoSize = true;
            this.lbQueQuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQueQuan.Location = new System.Drawing.Point(191, 182);
            this.lbQueQuan.Name = "lbQueQuan";
            this.lbQueQuan.Size = new System.Drawing.Size(99, 22);
            this.lbQueQuan.TabIndex = 11;
            this.lbQueQuan.Text = "lbQueQuan";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.Location = new System.Drawing.Point(191, 138);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(84, 22);
            this.lbCMND.TabIndex = 10;
            this.lbCMND.Text = "lbCMND";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.Location = new System.Drawing.Point(191, 98);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(97, 22);
            this.lbGioiTinh.TabIndex = 9;
            this.lbGioiTinh.Text = "lbGioiTinh";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(191, 17);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(79, 22);
            this.lbHoTen.TabIndex = 8;
            this.lbHoTen.Text = "lbHoTen";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Enabled = false;
            this.dtNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(195, 51);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(150, 30);
            this.dtNgaySinh.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(24, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 23);
            this.label13.TabIndex = 6;
            this.label13.Text = "Ngày sinh:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(24, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 23);
            this.label12.TabIndex = 5;
            this.label12.Text = "Giới tính:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(24, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "CMND:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(24, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Quê quán:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(24, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nghề nghiệp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(24, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Họ và tên:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(6, 375);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(767, 319);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lvKhach);
            this.panel6.Location = new System.Drawing.Point(15, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(723, 305);
            this.panel6.TabIndex = 0;
            // 
            // lvKhach
            // 
            this.lvKhach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvKhach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvKhach.FullRowSelect = true;
            this.lvKhach.GridLines = true;
            this.lvKhach.HideSelection = false;
            this.lvKhach.Location = new System.Drawing.Point(-2, -1);
            this.lvKhach.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lvKhach.Name = "lvKhach";
            this.lvKhach.Size = new System.Drawing.Size(719, 302);
            this.lvKhach.TabIndex = 2;
            this.lvKhach.UseCompatibleStateImageBehavior = false;
            this.lvKhach.View = System.Windows.Forms.View.Details;
            this.lvKhach.Click += new System.EventHandler(this.lvKhach_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã khách";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Họ và tên";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giới tính";
            this.columnHeader7.Width = 100;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.lbTienDatCoc);
            this.panel7.Controls.Add(this.lbPhong);
            this.panel7.Controls.Add(this.dtNgayThue);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(815, 375);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(601, 210);
            this.panel7.TabIndex = 4;
            // 
            // lbTienDatCoc
            // 
            this.lbTienDatCoc.AutoSize = true;
            this.lbTienDatCoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienDatCoc.Location = new System.Drawing.Point(200, 136);
            this.lbTienDatCoc.Name = "lbTienDatCoc";
            this.lbTienDatCoc.Size = new System.Drawing.Size(121, 22);
            this.lbTienDatCoc.TabIndex = 20;
            this.lbTienDatCoc.Text = "lbTienDatCoc";
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhong.Location = new System.Drawing.Point(201, 22);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(74, 22);
            this.lbPhong.TabIndex = 13;
            this.lbPhong.Text = "lbPhong";
            // 
            // dtNgayThue
            // 
            this.dtNgayThue.Enabled = false;
            this.dtNgayThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayThue.Location = new System.Drawing.Point(204, 72);
            this.dtNgayThue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtNgayThue.Name = "dtNgayThue";
            this.dtNgayThue.Size = new System.Drawing.Size(141, 30);
            this.dtNgayThue.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(25, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tiền đặt cọc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(25, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ngày thuê:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(25, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 23);
            this.label14.TabIndex = 16;
            this.label14.Text = "Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(1007, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thông tin chủ thuê";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(232, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Danh sách khách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(209, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Danh sách phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(992, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Thông tin thuê";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(816, 602);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 23);
            this.label15.TabIndex = 17;
            this.label15.Text = "Ngày trả phòng:";
            // 
            // dtNgayTraPhong
            // 
            this.dtNgayTraPhong.Enabled = false;
            this.dtNgayTraPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTraPhong.Location = new System.Drawing.Point(816, 640);
            this.dtNgayTraPhong.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtNgayTraPhong.Name = "dtNgayTraPhong";
            this.dtNgayTraPhong.Size = new System.Drawing.Size(247, 30);
            this.dtNgayTraPhong.TabIndex = 14;
            // 
            // btXacNhan
            // 
            this.btXacNhan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXacNhan.Location = new System.Drawing.Point(1106, 629);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(311, 58);
            this.btXacNhan.TabIndex = 18;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click_1);
            // 
            // formTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 756);
            this.Controls.Add(this.btXacNhan);
            this.Controls.Add(this.dtNgayTraPhong);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formTraPhong";
            this.Text = "Trả Phòng";
            this.Load += new System.EventHandler(this.formTraPhong_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvPhong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView lvKhach;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtNgayTraPhong;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.DateTimePicker dtNgayThue;
        private System.Windows.Forms.ComboBox cbKV;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbQueQuan;
        private System.Windows.Forms.Label lbNgheNghiep;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.Label lbTienDatCoc;
        private System.Windows.Forms.Label lbMaKhach;
    }
}