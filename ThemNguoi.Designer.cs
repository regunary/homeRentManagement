﻿
namespace QuanLyNhaTroMain
{
    partial class ThemNguoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemNguoi));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn khu vực:";
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dropDownButton1.ImageOptions.Image")));
            this.dropDownButton1.Location = new System.Drawing.Point(122, 5);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(169, 37);
            this.dropDownButton1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(12, 48);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(422, 227);
            this.panelControl1.TabIndex = 2;
            // 
            // ThemNguoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 449);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dropDownButton1);
            this.Controls.Add(this.labelControl1);
            this.Name = "ThemNguoi";
            this.Text = "ThemNguoi";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}