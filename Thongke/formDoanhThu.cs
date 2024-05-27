using QuanLyNhaTroMain.cntdatafrm;
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
    public partial class formDoanhThu : Form
    {
        public formDoanhThu()
        {
            InitializeComponent();
        }

        private void lvThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lvHD.Items.Clear();
                ListViewItem item = lvThang.SelectedItems[0];
                string thang = item.Text;
                label4.Text = thang;
                string sql = "SELECT MaPT, NgayLap, MaPhong FROM PhieuThu WHERE Cast(MONTH(NgayLap) as nvarchar) + '/' + Cast(YEAR(NgayLap) as nvarchar) = '" + thang + "' AND TrangThai = N'Đã thu'";
                DataTable table = new Room().GetDataPhong(sql);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    ListViewItem items = new ListViewItem(table.Rows[i][0].ToString().TrimEnd());
                    items.SubItems.Add(table.Rows[i][1].ToString().TrimEnd());
                    items.SubItems.Add(table.Rows[i][2].ToString().TrimEnd());
                    lvHD.Items.Add(items);
                }


                string sql1 = "SELECT SUM(TongTien) AS tongtienn FROM PhieuThu WHERE Cast(MONTH(NgayLap) as nvarchar) + '/' + Cast(YEAR(NgayLap) as nvarchar) = '" + thang + "' AND TrangThai = N'Đã thu'";
                DataTable table1 = new Room().GetDataPhong(sql1);
                txtTTT.Text = string.Format("{0:#,##0}", Int32.Parse(table1.Rows[0][0].ToString().TrimEnd()));
            }
            catch
            {

            }

            
            //lvHD.Items.Clear();
            //ListViewItem item = lvThang.SelectedItems[0];
            //string thang = item.Text;
            //label4.Text = thang;
            //string sql = "SELECT MaPT, NgayLap, MaPhong FROM PhieuThu WHERE Cast(MONTH(NgayLap) as nvarchar) + '/' + Cast(YEAR(NgayLap) as nvarchar) = '" + thang + "' AND TrangThai = N'Đã thu'";
            //DataTable table = new Room().GetDataPhong(sql);
            //for (int i = 0; i < table.Rows.Count; i++)
            //{
            //    ListViewItem items = new ListViewItem(table.Rows[i][0].ToString().TrimEnd());
            //    items.SubItems.Add(table.Rows[i][1].ToString().TrimEnd());
            //    items.SubItems.Add(table.Rows[i][2].ToString().TrimEnd());
            //    lvHD.Items.Add(items);
            //}


            //string sql1 = "SELECT SUM(TongTien) AS tongtienn FROM PhieuThu WHERE Cast(MONTH(NgayLap) as nvarchar) + '/' + Cast(YEAR(NgayLap) as nvarchar) = '" + thang + "' AND TrangThai = N'Đã thu'";
            //DataTable table1 = new Room().GetDataPhong(sql1);
            //txtTTT.Text = string.Format("{0:#,##0}", Int32.Parse(table1.Rows[0][0].ToString().TrimEnd()));
        }

        private void formDoanhThu_Load(object sender, EventArgs e)
        {
            LoadThang();
            string sql = "SELECT SUM(TongTien) AS tongtienn FROM PhieuThu WHERE TrangThai = N'Đã thu'";
            DataTable table = new Room().GetDataPhong(sql);
            txtTDT.Text = string.Format("{0:#,##0}", Int32.Parse(table.Rows[0][0].ToString().TrimEnd()));
        }

        private void LoadThang()
        {
            List<string> list = new List<string>();
            string sql = "SELECT Cast(MONTH(NgayLap) as nvarchar) + '/' + Cast(YEAR(NgayLap) as nvarchar) AS thang from PhieuThu ORDER BY NgayLap asc";
            DataTable table = new Room().GetDataPhong(sql);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string item = table.Rows[i][0].ToString().TrimEnd();
                if (!list.Contains(item.ToString()))
                    list.Add(item.ToString());
            }
            foreach (string i in list)
                lvThang.Items.Add(i);
        }

        private void lvHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lvTP.Items.Clear();
                ListViewItem item = lvHD.SelectedItems[0];
                string thang = item.Text;
                string sql = "SELECT MaPhong, TienNha FROM PhieuThu WHERE MaPT = '" + thang + "'";
                DataTable table = new Room().GetDataPhong(sql);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    ListViewItem items = new ListViewItem(table.Rows[i][0].ToString().TrimEnd());
                    label6.Text = table.Rows[i][0].ToString().TrimEnd();
                    items.SubItems.Add(string.Format("{0:#,##0}", Int32.Parse(table.Rows[i][1].ToString().TrimEnd())));
                    lvTP.Items.Add(items);
                }

                lvDV.Items.Clear();
                string sql1 = "SELECT TienDien, TienNuoc FROM PhieuThu WHERE MaPT = '" + thang + "'";
                DataTable table1 = new Room().GetDataPhong(sql1);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    ListViewItem items1 = new ListViewItem(string.Format("{0:#,##0}", Int32.Parse(table1.Rows[i][0].ToString().TrimEnd())));
                    items1.SubItems.Add(string.Format("{0:#,##0}", Int32.Parse(table1.Rows[i][1].ToString().TrimEnd())));
                    lvDV.Items.Add(items1);
                }

                string sql12 = "SELECT TongTien FROM PhieuThu WHERE MaPT = '" + thang + "' AND TrangThai = N'Đã thu'";
                DataTable table12 = new Room().GetDataPhong(sql12);
                txtTTP.Text = string.Format("{0:#,##0}", Int32.Parse(table12.Rows[0][0].ToString().TrimEnd()));
            }
            catch
            {

            }
            
        }


    }
}
