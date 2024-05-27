
namespace QuanLyNhaTroMain.Chuc_nang
{
    partial class TraPhong
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1440, 46);
            this.panel1.TabIndex = 0;
            // 
            // cbKV
            // 
            this.cbKV.FormattingEnabled = true;
            this.cbKV.Location = new System.Drawing.Point(144, 11);
            this.cbKV.Name = "cbKV";
            this.cbKV.Size = new System.Drawing.Size(597, 24);
            this.cbKV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 7);
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
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phòng";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Phòng";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Loại Phòng";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dãy";
            this.columnHeader4.Width = 87;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(6, 375);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(767, 227);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lvKhach);
            this.panel6.Location = new System.Drawing.Point(15, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(723, 207);
            this.panel6.TabIndex = 0;
            // 
            // lvKhach
            // 
            this.lvKhach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKhach.FullRowSelect = true;
            this.lvKhach.GridLines = true;
            this.lvKhach.HideSelection = false;
            this.lvKhach.Location = new System.Drawing.Point(0, 0);
            this.lvKhach.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lvKhach.Name = "lvKhach";
            this.lvKhach.Size = new System.Drawing.Size(719, 203);
            this.lvKhach.TabIndex = 2;
            this.lvKhach.UseCompatibleStateImageBehavior = false;
            this.lvKhach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã khách";
            this.columnHeader5.Width = 82;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Họ và tên";
            this.columnHeader6.Width = 177;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giới tính";
            this.columnHeader7.Width = 99;
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
            this.panel7.Location = new System.Drawing.Point(815, 86);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(601, 213);
            this.panel7.TabIndex = 4;
            // 
            // lbTienDatCoc
            // 
            this.lbTienDatCoc.AutoSize = true;
            this.lbTienDatCoc.Location = new System.Drawing.Point(207, 104);
            this.lbTienDatCoc.Name = "lbTienDatCoc";
            this.lbTienDatCoc.Size = new System.Drawing.Size(93, 17);
            this.lbTienDatCoc.TabIndex = 20;
            this.lbTienDatCoc.Text = "lbTienDatCoc";
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Location = new System.Drawing.Point(207, 26);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(60, 17);
            this.lbPhong.TabIndex = 14;
            this.lbPhong.Text = "lbPhong";
            // 
            // dtNgayThue
            // 
            this.dtNgayThue.Enabled = false;
            this.dtNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayThue.Location = new System.Drawing.Point(210, 58);
            this.dtNgayThue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtNgayThue.Name = "dtNgayThue";
            this.dtNgayThue.Size = new System.Drawing.Size(247, 22);
            this.dtNgayThue.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tiền đặt cọc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(25, 58);
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
            this.label6.Location = new System.Drawing.Point(1057, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Thông tin thuê";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(840, 338);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 23);
            this.label15.TabIndex = 17;
            this.label15.Text = "Ngày trả phòng:";
            // 
            // dtNgayTraPhong
            // 
            this.dtNgayTraPhong.Enabled = false;
            this.dtNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTraPhong.Location = new System.Drawing.Point(815, 375);
            this.dtNgayTraPhong.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtNgayTraPhong.Name = "dtNgayTraPhong";
            this.dtNgayTraPhong.Size = new System.Drawing.Size(247, 22);
            this.dtNgayTraPhong.TabIndex = 14;
            // 
            // btXacNhan
            // 
            this.btXacNhan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXacNhan.Location = new System.Drawing.Point(1105, 531);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(311, 58);
            this.btXacNhan.TabIndex = 18;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(840, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số Tiền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1024, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "lbSotien";
            // 
            // TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1440, 617);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btXacNhan);
            this.Controls.Add(this.dtNgayTraPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TraPhong";
            this.Text = "Trả Phòng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtNgayTraPhong;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.DateTimePicker dtNgayThue;
        private System.Windows.Forms.ComboBox cbKV;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.Label lbTienDatCoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}