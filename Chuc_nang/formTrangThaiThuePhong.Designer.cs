
namespace QuanLyNhaTroMain
{
    partial class formTrangThaiThuePhong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTrangThaiThuePhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbKV = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numRent = new System.Windows.Forms.Label();
            this.numTrong = new System.Windows.Forms.Label();
            this.grTTPT = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDienTich = new System.Windows.Forms.Label();
            this.lbgia = new System.Windows.Forms.Label();
            this.grKhach = new System.Windows.Forms.GroupBox();
            this.listKhach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.TwImgList = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grTTPT.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grKhach.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.grTTPT);
            this.panel1.Controls.Add(this.grKhach);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 729);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbKV);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.numRent);
            this.groupBox4.Controls.Add(this.numTrong);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(1002, 454);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Size = new System.Drawing.Size(358, 220);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thống kê";
            // 
            // cbKV
            // 
            this.cbKV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKV.FormattingEnabled = true;
            this.cbKV.Location = new System.Drawing.Point(115, 29);
            this.cbKV.Name = "cbKV";
            this.cbKV.Size = new System.Drawing.Size(179, 30);
            this.cbKV.TabIndex = 2;
            this.cbKV.SelectedIndexChanged += new System.EventHandler(this.cbKV_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Số phòng trống:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số phòng đã thuê:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Khu vực:";
            // 
            // numRent
            // 
            this.numRent.AutoSize = true;
            this.numRent.BackColor = System.Drawing.Color.White;
            this.numRent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRent.ForeColor = System.Drawing.Color.Black;
            this.numRent.Location = new System.Drawing.Point(230, 143);
            this.numRent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.numRent.Name = "numRent";
            this.numRent.Size = new System.Drawing.Size(61, 22);
            this.numRent.TabIndex = 3;
            this.numRent.Text = "label1";
            // 
            // numTrong
            // 
            this.numTrong.AutoSize = true;
            this.numTrong.BackColor = System.Drawing.Color.White;
            this.numTrong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTrong.ForeColor = System.Drawing.Color.Black;
            this.numTrong.Location = new System.Drawing.Point(230, 108);
            this.numTrong.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.numTrong.Name = "numTrong";
            this.numTrong.Size = new System.Drawing.Size(61, 22);
            this.numTrong.TabIndex = 3;
            this.numTrong.Text = "label1";
            // 
            // grTTPT
            // 
            this.grTTPT.Controls.Add(this.panel2);
            this.grTTPT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTTPT.ForeColor = System.Drawing.Color.Blue;
            this.grTTPT.Location = new System.Drawing.Point(993, 15);
            this.grTTPT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grTTPT.Name = "grTTPT";
            this.grTTPT.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grTTPT.Size = new System.Drawing.Size(367, 306);
            this.grTTPT.TabIndex = 4;
            this.grTTPT.TabStop = false;
            this.grTTPT.Text = "Thông tin phòng trống";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbLoaiPhong);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbDienTich);
            this.panel2.Controls.Add(this.lbgia);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(9, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 260);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá (vnd):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(189, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Diện tích:";
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.AutoSize = true;
            this.lbLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.lbLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiPhong.ForeColor = System.Drawing.Color.Blue;
            this.lbLoaiPhong.Location = new System.Drawing.Point(189, 66);
            this.lbLoaiPhong.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(74, 26);
            this.lbLoaiPhong.TabIndex = 3;
            this.lbLoaiPhong.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại phòng:";
            // 
            // lbDienTich
            // 
            this.lbDienTich.AutoSize = true;
            this.lbDienTich.BackColor = System.Drawing.Color.Transparent;
            this.lbDienTich.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDienTich.ForeColor = System.Drawing.Color.Blue;
            this.lbDienTich.Location = new System.Drawing.Point(189, 107);
            this.lbDienTich.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDienTich.Name = "lbDienTich";
            this.lbDienTich.Size = new System.Drawing.Size(74, 26);
            this.lbDienTich.TabIndex = 3;
            this.lbDienTich.Text = "label1";
            // 
            // lbgia
            // 
            this.lbgia.AutoSize = true;
            this.lbgia.BackColor = System.Drawing.Color.Transparent;
            this.lbgia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgia.ForeColor = System.Drawing.Color.Blue;
            this.lbgia.Location = new System.Drawing.Point(189, 144);
            this.lbgia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbgia.Name = "lbgia";
            this.lbgia.Size = new System.Drawing.Size(74, 26);
            this.lbgia.TabIndex = 3;
            this.lbgia.Text = "label1";
            // 
            // grKhach
            // 
            this.grKhach.Controls.Add(this.listKhach);
            this.grKhach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grKhach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grKhach.ForeColor = System.Drawing.Color.Green;
            this.grKhach.Location = new System.Drawing.Point(14, 454);
            this.grKhach.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grKhach.Name = "grKhach";
            this.grKhach.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grKhach.Size = new System.Drawing.Size(961, 254);
            this.grKhach.TabIndex = 2;
            this.grKhach.TabStop = false;
            this.grKhach.Text = "Danh sách khách thuê";
            // 
            // listKhach
            // 
            this.listKhach.BackColor = System.Drawing.Color.LightBlue;
            this.listKhach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listKhach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader8});
            this.listKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listKhach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listKhach.FullRowSelect = true;
            this.listKhach.GridLines = true;
            this.listKhach.HideSelection = false;
            this.listKhach.Location = new System.Drawing.Point(5, 31);
            this.listKhach.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listKhach.MultiSelect = false;
            this.listKhach.Name = "listKhach";
            this.listKhach.Size = new System.Drawing.Size(951, 219);
            this.listKhach.TabIndex = 0;
            this.listKhach.UseCompatibleStateImageBehavior = false;
            this.listKhach.View = System.Windows.Forms.View.Details;
            this.listKhach.Click += new System.EventHandler(this.listKhach_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã khách";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ngày sinh";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Quê quán";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 300;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nghề nghiệp";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(975, 442);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRẠNG THÁI THUÊ PHÒNG TRỌ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.treeView2);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(446, 33);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Size = new System.Drawing.Size(524, 401);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách các phòng còn trống";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(478, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // treeView2
            // 
            this.treeView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView2.Location = new System.Drawing.Point(14, 23);
            this.treeView2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(502, 370);
            this.treeView2.TabIndex = 1;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(9, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(427, 402);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các phòng đã được thuê";
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.Location = new System.Drawing.Point(10, 24);
            this.treeView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(407, 370);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // TwImgList
            // 
            this.TwImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.TwImgList.ImageSize = new System.Drawing.Size(32, 32);
            this.TwImgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // formTrangThaiThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 734);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formTrangThaiThuePhong";
            this.Text = "Trạng Thái thuê Phòng";
            this.Load += new System.EventHandler(this.formTrangThaiThuePhong_Load_1);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grTTPT.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grKhach.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label numRent;
        private System.Windows.Forms.Label numTrong;
        private System.Windows.Forms.GroupBox grKhach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listKhach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox grTTPT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbLoaiPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDienTich;
        private System.Windows.Forms.Label lbgia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbKV;
        private System.Windows.Forms.ImageList TwImgList;
    }
}