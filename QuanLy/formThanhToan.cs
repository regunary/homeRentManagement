﻿using QuanLyNhaTroMain.cntdatafrm;
using QuanLyNhaTroMain.getset;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTroMain.Chuc_nang
{
    public partial class formThanhToan : Form
    {
        Room data = new Room();
        int tiennha, tiendien, tiennuoc, tiennuoc2, tongtien;
        public formThanhToan()
        {
            InitializeComponent();
        }

        private void lvPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Lay ma phong chon tu list
                string kv = cbKV.SelectedValue.ToString();
                string tp = lvPhong.SelectedItems[0].Text;
                string sql = "SELECT MaPhong FROM Phong WHERE TenPhong=N'" + tp + "'AND MaKhuVuc='" + kv + "'";
                var mp = data.GetDataPhong(sql);

                //Load Thong Tin Phong Thue
                string maphong = mp.Rows[0][0].ToString();
                string sql_ttp = "SELECT p.MaPhong, TenPhong, NgayThue From Phong p , ThongTinThuePhong tp Where p.MaPhong='" + maphong + "'AND TrangThai=N'Đã thuê' AND p.MaPhong=tp.MaPhong";
                var phong = data.GetDataPhong(sql_ttp);

                txtMaPhong.Text = maphong;
                txtTenPhong.Text = phong.Rows[0][1].ToString();
                string ngay = phong.Rows[0][2].ToString();
                dtNgayThue.Text = ngay;

                //Load Thong Tin Chu Thue
                string sqlkhach = "SELECT tp.MaKhachTro, Ho +' '+ Ten AS HoTen FROM ThongTinThuePhong tp, ThongTinKhach ttk WHERE tp.MaKhachTro = ttk.MaKhachTro AND tp.MaPhong='" + maphong + "'";
                var khach = data.GetDataPhong(sqlkhach);

                //combobox Ten Chu Thue
                txtSoluong.Text = khach.Rows.Count.ToString();
                cbMaKhachThue.DisplayMember = "HoTen";
                cbMaKhachThue.ValueMember = "MaKhachTro";
                cbMaKhachThue.DataSource = khach;

                //Load Thong Tin Dich Vu
                string sqldichvu = "SELECT lp.TenLoaiPhong, lp.DonGia From Phong p, LoaiPhong lp WHERE p.MaLoaiPhong=lp.MaLoaiPhong AND p.MaPhong='" + maphong + "'";
                var dichvu = data.GetDataPhong(sqldichvu);

                txtLoaiPhong.Text = dichvu.Rows[0][0].ToString();
                tiennha = Convert.ToInt32(dichvu.Rows[0][1].ToString());
                string gia = string.Format("{0:#,##0}", Int32.Parse(dichvu.Rows[0][1].ToString()));
                txtTienNha.Text = gia;
            }
            catch
            {

            }
        }

        private void cbMaKhachThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load chi tiet thong tin khach
            string makhach = cbMaKhachThue.SelectedValue.ToString();
            string sql = "SELECT CMND, NgheNghiep, QueQuan FROM ThongTinKhach WHERE MaKhachTro='" + makhach + "'";
            var thongtinkhach = data.GetDataPhong(sql);

            txtCMND.Text = thongtinkhach.Rows[0][0].ToString();
            txtNN.Text = thongtinkhach.Rows[0][1].ToString();
            txtNS.Text = thongtinkhach.Rows[0][2].ToString();
        }

        private void rdSoNguoi_CheckedChanged(object sender, EventArgs e)
        {
            pSoNguoi.Visible = true;
            if (rdSoNguoi.Checked)
            {
                int songuoi = 0;
                //Load tien dich vu
                Room data = new Room();
                var dichvu = data.GetDataPhong("SELECT Gia From DichVu Where TenDichVu=N'Nước_2'");
                txtSoNguoi.Text = txtSoluong.Text;
                string str_songuoi = txtSoNguoi.Text;
                int gia = Convert.ToInt32(dichvu.Rows[0][0].ToString());
                if (txtSoNguoi.Text != "")
                    songuoi = Convert.ToInt32(str_songuoi);
                //Tinh
                tiennuoc = songuoi * gia;
                //Xuat
                txtTienNuoc2.Text = string.Format("{0:#,##0}", Int32.Parse(tiennuoc.ToString()));
            }
        }

        private void rdNuoc_CheckedChanged(object sender, EventArgs e)
        {
            pSoNguoi.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {//số điện
            if (checkBox1.Checked)
                txtSoKi.Enabled = true;
            else
                txtSoKi.Enabled = false;
        }

        private void nuoc_cbSoKi_CheckedChanged(object sender, EventArgs e)
        {//số nước
            if (nuoc_cbSoKi.Checked)
                txtSoKhoi.Enabled = true;
            else
                txtSoKhoi.Enabled = false;
        }

        private void txtSoKi_TextChanged(object sender, EventArgs e)
        {
            int soki = 0;
            //Load tien dich vu
            Room data = new Room();
            var dichvu = data.GetDataPhong("SELECT Gia From DichVu Where TenDichVu=N'Điện'");
            string str_soki = txtSoKi.Text;
            int gia = Convert.ToInt32(dichvu.Rows[0][0].ToString());
            if (txtSoKi.Text != "")
                soki = Convert.ToInt32(str_soki);
            //Tinh
            tiendien = soki * gia;
            //Xuat
            txtTienDien2.Text = string.Format("{0:#,##0}", Int32.Parse(tiendien.ToString()));

        }

        private void txtSoKhoi_TextChanged(object sender, EventArgs e)
        {
            int sokhoi = 0;
            //Load tien dich vu
            Room data = new Room();
            var dichvu = data.GetDataPhong("SELECT Gia From DichVu Where TenDichVu=N'Nước'");

            string str_sokhoi = txtSoKhoi.Text;
            int gia = Convert.ToInt32(dichvu.Rows[0][0].ToString());
            if (txtSoKhoi.Text != "")
                sokhoi = Convert.ToInt32(str_sokhoi);
            //Tinh            
            tiennuoc2 = sokhoi * gia;
            //Xuat
            txtTienNuoc.Text = string.Format("{0:#,##0}", Int32.Parse(tiennuoc2.ToString()));
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            if (rdNuoc.Checked)
            {
                tongtien = tiennha + tiendien + tiennuoc2;
                txtTongCong.Text = string.Format("{0:#,##0}", Int32.Parse(tongtien.ToString())) + " vnd";
            }
            else
            {
                tongtien = tiennha + tiendien + tiennuoc;
                txtTongCong.Text = string.Format("{0:#,##0}", Int32.Parse(tongtien.ToString())) + " vnd";
            }
        }

        private void btLuuHoaDon_Click(object sender, EventArgs e)
        {
            //Lay du lieu bang phieu thu
            double idPT = new PhieuThuBUS().newID();
            string maphong = txtMaPhong.Text;
            DateTime ngaylap = dtLapHoaDon.Value;
            DateTime ngaythu = new DateTime();
            string TrangThai = "Chưa thu";
            int sokidien = Convert.ToInt32(txtSoKi.Text);
            int PT_tiennuoc, sokhoinuoc;
            if (rdNuoc.Checked)
            {
                sokhoinuoc = Convert.ToInt32(txtSoKhoi.Text);
                PT_tiennuoc = tiennuoc2;
            }
            else
            {
                sokhoinuoc = 0;
                PT_tiennuoc = tiennuoc;
            }

            //Xac Nhan
            if (MessageBox.Show("Thời gian lập hóa đơn: \n" + ngaylap.ToString() + "\nMã Phòng: " + maphong, "Xác nhận lập hóa đơn: " + idPT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Insert vao bang phieu thu
                PhieuThu pt = new PhieuThu(idPT, maphong, ngaylap, tiennha, sokidien, tiendien, sokhoinuoc, PT_tiennuoc, tongtien, TrangThai);
                string sql = "INSERT INTO PhieuThu(MaPT,MaPhong,NgayLap,TienNha,SkDien,TienDien,SkNuoc,TienNuoc,TongTien,TrangThai) VALUES(@mapt,@maphong,@ngaylap,@tiennha,@skdien,@tiendien,@sknuoc,@tiennuoc,@tongtien,@trangthai)";
                int i = new PhieuThuBUS().Insert(sql, pt);
                if (i == 1)
                    MessageBox.Show("Lập hóa đơn thành công");
                else
                    MessageBox.Show("Không thành công");

            }
            //Refresh
            load_phong();
            ClearAll();
        }

        private void ClearAll()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            dtNgayThue.Value = DateTime.Today;
            txtSoluong.Text = "";
            cbMaKhachThue.Text = "";
            txtCMND.Text = "";
            txtNN.Text = "";
            txtNS.Text = "";
            txtLoaiPhong.Text = "";
            txtTienNha.Text = "";
            txtSoKi.Text = "";
            txtTienDien2.Text = "";
            txtSoKhoi.Text = "";
            txtTienNuoc.Text = ""; txtTienNuoc2.Text = ""; txtSoNguoi.Text = ""; txtTongCong.Text = "";
            rdNuoc.Checked = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_phong();
        }

        private void load_phong()
        {
            lvPhong.Items.Clear();
            string makv = cbKV.SelectedValue.ToString();
            int thismonth = DateTime.Today.Month;
            int thisyear = DateTime.Today.Year;
            var phong = data.GetDataPhong("SELECT * From Phong WHERE MaPhong not in (Select MaPhong From PhieuThu Where MONTH(NgayLap)=" + thismonth + " AND YEAR(NgayLap)=" + thisyear + ") AND TrangThai=N'Đã thuê' AND MaKhuVuc='" + makv + "'");

            for (int i = 0; i < phong.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(phong.Rows[i][3].ToString());
                item.ImageIndex = 0;
                lvPhong.Items.Add(item);
            }

            gpLHD.Text = "Lập hóa đơn tháng " + thismonth;
        }

        private void formThanhToan_Load(object sender, EventArgs e)
        {
            Load_CBKV();
        }

        private void Load_CBKV()
        {
            var kv = data.GetDataTW();
            cbKV.ValueMember = "MaKhuVuc";
            cbKV.DisplayMember = "TenKhuVuc";
            cbKV.DataSource = kv;
        }
    }
}
