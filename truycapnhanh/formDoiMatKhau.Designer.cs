
namespace QuanLyNhaTroMain.truycapnhanh
{
    partial class formDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDoiMatKhau));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btHuyBo = new System.Windows.Forms.Button();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.txtRewrite = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.lbNhapLaiMatKhauMoi = new System.Windows.Forms.Label();
            this.lbMatKhauMoi = new System.Windows.Forms.Label();
            this.lbMatKhauCu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btHuyBo);
            this.panel1.Controls.Add(this.btXacNhan);
            this.panel1.Controls.Add(this.txtRewrite);
            this.panel1.Controls.Add(this.txtNewPass);
            this.panel1.Controls.Add(this.txtOldPass);
            this.panel1.Controls.Add(this.lbNhapLaiMatKhauMoi);
            this.panel1.Controls.Add(this.lbMatKhauMoi);
            this.panel1.Controls.Add(this.lbMatKhauCu);
            this.panel1.Location = new System.Drawing.Point(29, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 385);
            this.panel1.TabIndex = 0;
            // 
            // btHuyBo
            // 
            this.btHuyBo.BackColor = System.Drawing.Color.Red;
            this.btHuyBo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHuyBo.Location = new System.Drawing.Point(562, 307);
            this.btHuyBo.Name = "btHuyBo";
            this.btHuyBo.Size = new System.Drawing.Size(145, 46);
            this.btHuyBo.TabIndex = 7;
            this.btHuyBo.Text = "Hủy bỏ";
            this.btHuyBo.UseVisualStyleBackColor = false;
            this.btHuyBo.Click += new System.EventHandler(this.btHuyBo_Click);
            // 
            // btXacNhan
            // 
            this.btXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btXacNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXacNhan.Location = new System.Drawing.Point(379, 307);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(145, 46);
            this.btXacNhan.TabIndex = 6;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = false;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // txtRewrite
            // 
            this.txtRewrite.Location = new System.Drawing.Point(379, 205);
            this.txtRewrite.Multiline = true;
            this.txtRewrite.Name = "txtRewrite";
            this.txtRewrite.Size = new System.Drawing.Size(327, 44);
            this.txtRewrite.TabIndex = 5;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(379, 131);
            this.txtNewPass.Multiline = true;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(327, 44);
            this.txtNewPass.TabIndex = 4;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(379, 51);
            this.txtOldPass.Multiline = true;
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(327, 44);
            this.txtOldPass.TabIndex = 3;
            // 
            // lbNhapLaiMatKhauMoi
            // 
            this.lbNhapLaiMatKhauMoi.AutoSize = true;
            this.lbNhapLaiMatKhauMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbNhapLaiMatKhauMoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNhapLaiMatKhauMoi.ForeColor = System.Drawing.Color.Black;
            this.lbNhapLaiMatKhauMoi.Location = new System.Drawing.Point(57, 205);
            this.lbNhapLaiMatKhauMoi.Name = "lbNhapLaiMatKhauMoi";
            this.lbNhapLaiMatKhauMoi.Size = new System.Drawing.Size(254, 26);
            this.lbNhapLaiMatKhauMoi.TabIndex = 2;
            this.lbNhapLaiMatKhauMoi.Text = "Nhập lại mật khẩu mới:";
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.AutoSize = true;
            this.lbMatKhauMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbMatKhauMoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMatKhauMoi.ForeColor = System.Drawing.Color.Black;
            this.lbMatKhauMoi.Location = new System.Drawing.Point(57, 131);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(165, 26);
            this.lbMatKhauMoi.TabIndex = 1;
            this.lbMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // lbMatKhauCu
            // 
            this.lbMatKhauCu.AutoSize = true;
            this.lbMatKhauCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbMatKhauCu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMatKhauCu.ForeColor = System.Drawing.Color.Black;
            this.lbMatKhauCu.Location = new System.Drawing.Point(57, 57);
            this.lbMatKhauCu.Name = "lbMatKhauCu";
            this.lbMatKhauCu.Size = new System.Drawing.Size(150, 26);
            this.lbMatKhauCu.TabIndex = 0;
            this.lbMatKhauCu.Text = "Mật khẩu cũ:";
            // 
            // formDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 441);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.formDoiMatKhau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNhapLaiMatKhauMoi;
        private System.Windows.Forms.Label lbMatKhauMoi;
        private System.Windows.Forms.Label lbMatKhauCu;
        private System.Windows.Forms.Button btHuyBo;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.TextBox txtRewrite;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtOldPass;
    }
}