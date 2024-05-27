
namespace QuanLyNhaTroMain.Chuc_nang
{
    partial class formDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDoanhThu));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lvThang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lvHD = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lvTP = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lvDV = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTDT = new System.Windows.Forms.TextBox();
            this.txtTTT = new System.Windows.Forms.TextBox();
            this.txtTTP = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(461, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(617, 76);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thống kê hóa đơn";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(21, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 336);
            this.panel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lvThang);
            this.panel5.Location = new System.Drawing.Point(8, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(169, 300);
            this.panel5.TabIndex = 0;
            // 
            // lvThang
            // 
            this.lvThang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvThang.FullRowSelect = true;
            this.lvThang.HideSelection = false;
            this.lvThang.Location = new System.Drawing.Point(0, 0);
            this.lvThang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lvThang.Name = "lvThang";
            this.lvThang.Size = new System.Drawing.Size(165, 296);
            this.lvThang.TabIndex = 1;
            this.lvThang.UseCompatibleStateImageBehavior = false;
            this.lvThang.View = System.Windows.Forms.View.Details;
            this.lvThang.SelectedIndexChanged += new System.EventHandler(this.lvThang_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tháng";
            this.columnHeader1.Width = 78;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(259, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 336);
            this.panel2.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lvHD);
            this.panel6.Location = new System.Drawing.Point(15, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(430, 303);
            this.panel6.TabIndex = 0;
            // 
            // lvHD
            // 
            this.lvHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHD.FullRowSelect = true;
            this.lvHD.HideSelection = false;
            this.lvHD.Location = new System.Drawing.Point(0, 0);
            this.lvHD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lvHD.Name = "lvHD";
            this.lvHD.Size = new System.Drawing.Size(426, 299);
            this.lvHD.TabIndex = 1;
            this.lvHD.UseCompatibleStateImageBehavior = false;
            this.lvHD.View = System.Windows.Forms.View.Details;
            this.lvHD.SelectedIndexChanged += new System.EventHandler(this.lvHD_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã HD";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày lập";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã phòng";
            this.columnHeader4.Width = 104;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Location = new System.Drawing.Point(750, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 108);
            this.panel3.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.lvTP);
            this.panel7.Location = new System.Drawing.Point(14, 17);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(607, 75);
            this.panel7.TabIndex = 0;
            // 
            // lvTP
            // 
            this.lvTP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTP.HideSelection = false;
            this.lvTP.Location = new System.Drawing.Point(0, 0);
            this.lvTP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lvTP.Name = "lvTP";
            this.lvTP.Size = new System.Drawing.Size(603, 71);
            this.lvTP.TabIndex = 1;
            this.lvTP.UseCompatibleStateImageBehavior = false;
            this.lvTP.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã phòng";
            this.columnHeader5.Width = 171;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giá tiền";
            this.columnHeader6.Width = 174;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Location = new System.Drawing.Point(747, 227);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 202);
            this.panel4.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.lvDV);
            this.panel8.Location = new System.Drawing.Point(18, 14);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(604, 173);
            this.panel8.TabIndex = 0;
            // 
            // lvDV
            // 
            this.lvDV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lvDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDV.HideSelection = false;
            this.lvDV.Location = new System.Drawing.Point(0, 0);
            this.lvDV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lvDV.Name = "lvDV";
            this.lvDV.Size = new System.Drawing.Size(600, 169);
            this.lvDV.TabIndex = 1;
            this.lvDV.UseCompatibleStateImageBehavior = false;
            this.lvDV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tiền điện";
            this.columnHeader7.Width = 171;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tiền nước";
            this.columnHeader8.Width = 172;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(67, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(993, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tiền dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(394, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Danh sách hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(1021, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tiền phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(27, 466);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tổng doanh thu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(373, 466);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tổng doanh thu tháng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(778, 466);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tổng tiền phòng";
            // 
            // txtTDT
            // 
            this.txtTDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDT.Location = new System.Drawing.Point(33, 512);
            this.txtTDT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTDT.Name = "txtTDT";
            this.txtTDT.Size = new System.Drawing.Size(273, 30);
            this.txtTDT.TabIndex = 15;
            // 
            // txtTTT
            // 
            this.txtTTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTT.Location = new System.Drawing.Point(378, 512);
            this.txtTTT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTTT.Name = "txtTTT";
            this.txtTTT.Size = new System.Drawing.Size(323, 30);
            this.txtTTT.TabIndex = 16;
            // 
            // txtTTP
            // 
            this.txtTTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTP.Location = new System.Drawing.Point(784, 512);
            this.txtTTP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTTP.Name = "txtTTP";
            this.txtTTP.Size = new System.Drawing.Size(323, 30);
            this.txtTTP.TabIndex = 17;
            // 
            // formDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 568);
            this.Controls.Add(this.txtTTP);
            this.Controls.Add(this.txtTTT);
            this.Controls.Add(this.txtTDT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formDoanhThu";
            this.Text = "Doanh Thu";
            this.Load += new System.EventHandler(this.formDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ListView lvThang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvHD;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvTP;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvDV;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTDT;
        private System.Windows.Forms.TextBox txtTTT;
        private System.Windows.Forms.TextBox txtTTP;
    }
}