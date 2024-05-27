
namespace QuanLyNhaTroMain
{
    partial class formThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formThuTien));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbKhuVuc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grCTHD = new System.Windows.Forms.GroupBox();
            this.lbTT = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lbTienNuoc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbNuocSK = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lbTienDien = new System.Windows.Forms.Label();
            this.lbDienSK = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lbLp = new System.Windows.Forms.Label();
            this.lbTienPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btDongTien = new System.Windows.Forms.Button();
            this.DSThuTien = new System.Windows.Forms.Label();
            this.dtNgayThu2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.grCTHD.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbKhuVuc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(20, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(488, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn khu vực";
            // 
            // cbKhuVuc
            // 
            this.cbKhuVuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhuVuc.FormattingEnabled = true;
            this.cbKhuVuc.Location = new System.Drawing.Point(146, 44);
            this.cbKhuVuc.Name = "cbKhuVuc";
            this.cbKhuVuc.Size = new System.Drawing.Size(254, 30);
            this.cbKhuVuc.TabIndex = 1;
            this.cbKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cbKhuVuc_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khu vực:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listHoaDon);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox6.Location = new System.Drawing.Point(15, 177);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox6.Size = new System.Drawing.Size(500, 430);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hóa đơn";
            // 
            // listHoaDon
            // 
            this.listHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.listHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHoaDon.FullRowSelect = true;
            this.listHoaDon.GridLines = true;
            this.listHoaDon.HideSelection = false;
            this.listHoaDon.Location = new System.Drawing.Point(5, 31);
            this.listHoaDon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listHoaDon.Name = "listHoaDon";
            this.listHoaDon.Size = new System.Drawing.Size(490, 395);
            this.listHoaDon.TabIndex = 2;
            this.listHoaDon.UseCompatibleStateImageBehavior = false;
            this.listHoaDon.View = System.Windows.Forms.View.Details;
            this.listHoaDon.Click += new System.EventHandler(this.listHoaDon_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MãHD";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã Phòng";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tổng tiền";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 200;
            // 
            // grCTHD
            // 
            this.grCTHD.Controls.Add(this.lbTT);
            this.grCTHD.Controls.Add(this.lbTongTien);
            this.grCTHD.Controls.Add(this.groupBox10);
            this.grCTHD.Controls.Add(this.groupBox9);
            this.grCTHD.Controls.Add(this.groupBox8);
            this.grCTHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grCTHD.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grCTHD.Location = new System.Drawing.Point(541, 62);
            this.grCTHD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grCTHD.Name = "grCTHD";
            this.grCTHD.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grCTHD.Size = new System.Drawing.Size(424, 547);
            this.grCTHD.TabIndex = 6;
            this.grCTHD.TabStop = false;
            this.grCTHD.Text = "Chi tiết hóa đơn số:";
            // 
            // lbTT
            // 
            this.lbTT.AutoSize = true;
            this.lbTT.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTT.ForeColor = System.Drawing.Color.Red;
            this.lbTT.Location = new System.Drawing.Point(182, 456);
            this.lbTT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTT.Name = "lbTT";
            this.lbTT.Size = new System.Drawing.Size(125, 32);
            this.lbTT.TabIndex = 4;
            this.lbTT.Text = "Tổng tiền";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.Red;
            this.lbTongTien.Location = new System.Drawing.Point(10, 456);
            this.lbTongTien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(141, 32);
            this.lbTongTien.TabIndex = 2;
            this.lbTongTien.Text = "Tổng tiền: ";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lbTienNuoc);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Controls.Add(this.lbNuocSK);
            this.groupBox10.Controls.Add(this.label9);
            this.groupBox10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox10.Location = new System.Drawing.Point(9, 296);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox10.Size = new System.Drawing.Size(415, 102);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Nước";
            // 
            // lbTienNuoc
            // 
            this.lbTienNuoc.AutoSize = true;
            this.lbTienNuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienNuoc.ForeColor = System.Drawing.Color.Red;
            this.lbTienNuoc.Location = new System.Drawing.Point(288, 48);
            this.lbTienNuoc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTienNuoc.Name = "lbTienNuoc";
            this.lbTienNuoc.Size = new System.Drawing.Size(65, 22);
            this.lbTienNuoc.TabIndex = 1;
            this.lbTienNuoc.Text = "Số tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số khối:";
            // 
            // lbNuocSK
            // 
            this.lbNuocSK.AutoSize = true;
            this.lbNuocSK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuocSK.ForeColor = System.Drawing.Color.Black;
            this.lbNuocSK.Location = new System.Drawing.Point(88, 48);
            this.lbNuocSK.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNuocSK.Name = "lbNuocSK";
            this.lbNuocSK.Size = new System.Drawing.Size(70, 22);
            this.lbNuocSK.TabIndex = 1;
            this.lbNuocSK.Text = "Số khối";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(175, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thành tiền: ";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lbTienDien);
            this.groupBox9.Controls.Add(this.lbDienSK);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox9.Location = new System.Drawing.Point(10, 171);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox9.Size = new System.Drawing.Size(414, 106);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Điện";
            // 
            // lbTienDien
            // 
            this.lbTienDien.AutoSize = true;
            this.lbTienDien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienDien.ForeColor = System.Drawing.Color.Red;
            this.lbTienDien.Location = new System.Drawing.Point(287, 48);
            this.lbTienDien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTienDien.Name = "lbTienDien";
            this.lbTienDien.Size = new System.Drawing.Size(71, 22);
            this.lbTienDien.TabIndex = 1;
            this.lbTienDien.Text = "Số Tiền";
            // 
            // lbDienSK
            // 
            this.lbDienSK.AutoSize = true;
            this.lbDienSK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDienSK.ForeColor = System.Drawing.Color.Black;
            this.lbDienSK.Location = new System.Drawing.Point(87, 48);
            this.lbDienSK.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDienSK.Name = "lbDienSK";
            this.lbDienSK.Size = new System.Drawing.Size(62, 22);
            this.lbDienSK.TabIndex = 1;
            this.lbDienSK.Text = "lbSoki";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số kí:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(174, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thành tiền: ";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lbLp);
            this.groupBox8.Controls.Add(this.lbTienPhong);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox8.Location = new System.Drawing.Point(10, 44);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox8.Size = new System.Drawing.Size(414, 119);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Phòng";
            // 
            // lbLp
            // 
            this.lbLp.AutoSize = true;
            this.lbLp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLp.ForeColor = System.Drawing.Color.Red;
            this.lbLp.Location = new System.Drawing.Point(161, 42);
            this.lbLp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbLp.Name = "lbLp";
            this.lbLp.Size = new System.Drawing.Size(48, 22);
            this.lbLp.TabIndex = 2;
            this.lbLp.Text = "lbLP";
            // 
            // lbTienPhong
            // 
            this.lbTienPhong.AutoSize = true;
            this.lbTienPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienPhong.ForeColor = System.Drawing.Color.Black;
            this.lbTienPhong.Location = new System.Drawing.Point(161, 79);
            this.lbTienPhong.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTienPhong.Name = "lbTienPhong";
            this.lbTienPhong.Size = new System.Drawing.Size(100, 22);
            this.lbTienPhong.TabIndex = 1;
            this.lbTienPhong.Text = "lb Giá Tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(45, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá tiền: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDongTien);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(988, 425);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(303, 180);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xác nhận đóng tiền";
            // 
            // btDongTien
            // 
            this.btDongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDongTien.BackColor = System.Drawing.Color.Lime;
            this.btDongTien.ForeColor = System.Drawing.Color.White;
            this.btDongTien.Location = new System.Drawing.Point(79, 51);
            this.btDongTien.Name = "btDongTien";
            this.btDongTien.Size = new System.Drawing.Size(143, 88);
            this.btDongTien.TabIndex = 0;
            this.btDongTien.Text = "Đã đóng";
            this.btDongTien.UseVisualStyleBackColor = false;
            this.btDongTien.Click += new System.EventHandler(this.btDongTien_Click);
            // 
            // DSThuTien
            // 
            this.DSThuTien.AutoSize = true;
            this.DSThuTien.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DSThuTien.Location = new System.Drawing.Point(425, 0);
            this.DSThuTien.Name = "DSThuTien";
            this.DSThuTien.Size = new System.Drawing.Size(334, 45);
            this.DSThuTien.TabIndex = 8;
            this.DSThuTien.Text = "Danh sách thu tiền";
            // 
            // dtNgayThu2
            // 
            this.dtNgayThu2.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayThu2.Enabled = false;
            this.dtNgayThu2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayThu2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayThu2.Location = new System.Drawing.Point(1033, 345);
            this.dtNgayThu2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtNgayThu2.Name = "dtNgayThu2";
            this.dtNgayThu2.Size = new System.Drawing.Size(191, 30);
            this.dtNgayThu2.TabIndex = 20;
            // 
            // formThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 710);
            this.Controls.Add(this.dtNgayThu2);
            this.Controls.Add(this.DSThuTien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grCTHD);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formThuTien";
            this.Text = "Thu Tiền";
            this.Load += new System.EventHandler(this.formThuTien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.grCTHD.ResumeLayout(false);
            this.grCTHD.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKhuVuc;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView listHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox grCTHD;
        private System.Windows.Forms.Label lbTT;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lbTienNuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbNuocSK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lbTienDien;
        private System.Windows.Forms.Label lbDienSK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btDongTien;
        private System.Windows.Forms.Label DSThuTien;
        private System.Windows.Forms.Label lbLp;
        private System.Windows.Forms.DateTimePicker dtNgayThu2;
        private System.Windows.Forms.Label lbTienPhong;
    }
}