
namespace QuanLyNhaTroMain.QuanLy
{
    partial class formQuanLyPhongTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuanLyPhongTro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbKV = new System.Windows.Forms.ComboBox();
            this.btThemPhongMoi = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lbKhuVuc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvQLPhong = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbKV);
            this.panel1.Controls.Add(this.btThemPhongMoi);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btTimKiem);
            this.panel1.Controls.Add(this.btRefresh);
            this.panel1.Controls.Add(this.lbKhuVuc);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1569, 87);
            this.panel1.TabIndex = 1;
            // 
            // cbKV
            // 
            this.cbKV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKV.FormattingEnabled = true;
            this.cbKV.Location = new System.Drawing.Point(160, 25);
            this.cbKV.Name = "cbKV";
            this.cbKV.Size = new System.Drawing.Size(182, 34);
            this.cbKV.TabIndex = 7;
            this.cbKV.SelectedIndexChanged += new System.EventHandler(this.cbKV_SelectedIndexChanged);
            // 
            // btThemPhongMoi
            // 
            this.btThemPhongMoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemPhongMoi.Appearance.Options.UseFont = true;
            this.btThemPhongMoi.Location = new System.Drawing.Point(484, 25);
            this.btThemPhongMoi.Name = "btThemPhongMoi";
            this.btThemPhongMoi.Size = new System.Drawing.Size(221, 43);
            this.btThemPhongMoi.TabIndex = 6;
            this.btThemPhongMoi.Text = "Thêm Phòng Mới";
            this.btThemPhongMoi.Click += new System.EventHandler(this.btThemPhongMoi_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(884, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(316, 43);
            this.txtSearch.TabIndex = 5;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Appearance.Options.UseFont = true;
            this.btTimKiem.Location = new System.Drawing.Point(1208, 25);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(182, 43);
            this.btTimKiem.TabIndex = 2;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.Appearance.Options.UseFont = true;
            this.btRefresh.Location = new System.Drawing.Point(738, 25);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(138, 43);
            this.btRefresh.TabIndex = 1;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // lbKhuVuc
            // 
            this.lbKhuVuc.AutoSize = true;
            this.lbKhuVuc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhuVuc.Location = new System.Drawing.Point(38, 32);
            this.lbKhuVuc.Name = "lbKhuVuc";
            this.lbKhuVuc.Size = new System.Drawing.Size(101, 27);
            this.lbKhuVuc.TabIndex = 0;
            this.lbKhuVuc.Text = "Khu vực:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvQLPhong);
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1569, 603);
            this.panel2.TabIndex = 2;
            // 
            // dgvQLPhong
            // 
            this.dgvQLPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQLPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLPhong.Location = new System.Drawing.Point(0, 6);
            this.dgvQLPhong.Name = "dgvQLPhong";
            this.dgvQLPhong.RowHeadersWidth = 51;
            this.dgvQLPhong.RowTemplate.Height = 24;
            this.dgvQLPhong.Size = new System.Drawing.Size(1569, 597);
            this.dgvQLPhong.TabIndex = 0;
            // 
            // formQuanLyPhongTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 690);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formQuanLyPhongTro";
            this.Text = "Danh sách phòng";
            this.Load += new System.EventHandler(this.formQuanLyPhongTro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton btTimKiem;
        private DevExpress.XtraEditors.SimpleButton btRefresh;
        private System.Windows.Forms.Label lbKhuVuc;
        private DevExpress.XtraEditors.SimpleButton btThemPhongMoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvQLPhong;
        private System.Windows.Forms.ComboBox cbKV;
    }
}