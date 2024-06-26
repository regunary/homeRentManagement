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

namespace QuanLyNhaTroMain
{
    public partial class formThuTien : Form
    {
        string maphong;
        int idhoadon;
        public formThuTien()
        {
            InitializeComponent();
        }
        
        private void LoadCB()
        {
            Room data = new Room();
            DataTable kv = data.GetDataTW();
            cbKhuVuc.DisplayMember = "TenKhuVuc";
            cbKhuVuc.ValueMember = "MaKhuVuc";
            cbKhuVuc.DataSource = kv;
        }
        private void LoadList()
        {
            string makv = cbKhuVuc.SelectedValue.ToString();

            string sql = "SELECT MaPT, pt.MaPhong, TongTien FROM PhieuThu pt, Phong p WHERE p.MaKhuVuc = '" + makv + "' AND pt.TrangThai = N'Chưa thu' AND pt.MaPhong = p.MaPhong";
            Room ListLoai = new Room();
            var loaiphong = ListLoai.GetDataPhong(sql);
            for (int i = 0; i < loaiphong.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(loaiphong.Rows[i][0].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][1].ToString().TrimEnd());
                item.SubItems.Add(string.Format("{0:#,##0}", Int32.Parse(loaiphong.Rows[i][2].ToString().TrimEnd())));

                listHoaDon.Items.Add(item);
            }
        }

        private void btDongTien_Click(object sender, EventArgs e)
        {
            DateTime ngaythu = dtNgayThu2.Value;
            var ngaythu3 = ngaythu.ToString("yyyy-MM-dd");
            if (MessageBox.Show("Thời gian thu: " + ngaythu.ToString() + "\nMã Phòng: " + maphong, "Xác nhận thanh toán hóa đơn: " + idhoadon, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListViewItem item = listHoaDon.SelectedItems[0];
                string thang = item.Text;
                string sql_xn = "UPDATE PhieuThu SET NgayThu='" + ngaythu3 + "',TrangThai=N'Đã thu' WHERE MaPT=@id";
                int i = new PhieuThuBUS().XNDongTien(sql_xn, thang);
                MessageBox.Show("Đã đóng thành công!");
                listHoaDon.Items.Clear();
                grCTHD.Text = "Chi tiết hóa đơn số: ";
                lbLp.Text = "";
                lbTienPhong.Text = "";
                lbDienSK.Text = "" ;
                lbTienDien.Text = "";
                lbNuocSK.Text = "";
                lbTienNuoc.Text = "";
                lbTT.Text = "";
                LoadList();
            }
        }

        private void cbKhuVuc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listHoaDon.Items.Clear();
            LoadList();
        }

        private void formThuTien_Load(object sender, EventArgs e)
        {
            LoadCB();
            grCTHD.Text = "Chi tiết hóa đơn số: ";
            lbLp.Text = "";
            lbTienPhong.Text = "";
            lbDienSK.Text = "";
            lbTienDien.Text = "";
            lbNuocSK.Text = "";
            lbTienNuoc.Text = "";
            lbTT.Text = "";
        }

        private void listHoaDon_Click(object sender, EventArgs e)
        {
            ListViewItem item = listHoaDon.SelectedItems[0];
            string thang = item.Text;
            maphong = thang;
            string sql = "SELECT * FROM PhieuThu WHERE MaPT = '" + thang + "'";
            DataTable table = new Room().GetDataPhong(sql);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                grCTHD.Text = "Chi tiết hóa đơn số: " + table.Rows[i][0].ToString().TrimEnd();
                lbLp.Text = table.Rows[i][1].ToString().TrimEnd();
                lbTienPhong.Text = string.Format("{0:#,##0}", Int32.Parse(table.Rows[i][4].ToString().TrimEnd()));
                lbDienSK.Text = table.Rows[i][5].ToString().TrimEnd();
                lbTienDien.Text = string.Format("{0:#,##0}", Int32.Parse(table.Rows[i][6].ToString().TrimEnd()));
                lbNuocSK.Text = table.Rows[i][7].ToString().TrimEnd();
                lbTienNuoc.Text = string.Format("{0:#,##0}", Int32.Parse(table.Rows[i][8].ToString().TrimEnd()));
                lbTT.Text = string.Format("{0:#,##0}", Int32.Parse(table.Rows[i][9].ToString().TrimEnd())) + " vnd";
            }
            idhoadon = Convert.ToInt32(table.Rows[0][0].ToString());
        }
    }
}
