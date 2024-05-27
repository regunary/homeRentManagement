using QuanLyNhaTroMain.cntdatafrm;
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
    public partial class formDkyPhongTrong : Form
    {
        public formDkyPhongTrong()
        {
            InitializeComponent();
        }
        int check;
        
        private void LoadKV()
        {
            Room data = new Room();
            var kv = data.GetDataTW();
            cbKhuVuc.DisplayMember = "TenKhuVuc";
            cbKhuVuc.ValueMember = "MaKhuVuc";
            cbKhuVuc.DataSource = kv;
        }

        private void btNhapLai_Click(object sender, EventArgs e)
        {
            txtHo.Text = "";
            txtTen.Text = "";
            txtCmnd.Text = "";
            txtQuequan.Text = "";
            txtNghenghiep.Text = "";
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            try
            {
                string ho, ten, cmnd, quequan, nghenghiep, makhuvuc;
                DateTime ngaysinh;
                ThongTinDKBUS ttdk = new ThongTinDKBUS();
                string sql = "SELECT * FROM ThongTinDangKyPhong";
                var table = ttdk.GetThongTinDK(sql);
                table.PrimaryKey = new DataColumn[] { table.Columns["Id"] };
                int id, k;
                for (k = 1; k <= table.Rows.Count; k++)
                {
                    if (table.Rows.Find(k) == null)
                    {
                        break;
                    }
                }
                id = k;
                ho = txtHo.Text;
                ten = txtTen.Text;
                ngaysinh = dtiNgaySinh.Value;
                cmnd = txtCmnd.Text;
                quequan = txtQuequan.Text;
                nghenghiep = txtNghenghiep.Text;
                makhuvuc = cbKhuVuc.SelectedValue.ToString();
                if (ten == "") MessageBox.Show("Đăng nhập thất bại, thiếu Tên!!!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (cmnd == "") MessageBox.Show("Đăng nhập thất bại, thiếu số cmnd!!!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (cmnd.Length !=9 ) MessageBox.Show("Đăng nhập thất bại, số CMND không đúng, Số CMND phải 9 số ", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    string maloaiphong = lstLoaiPhong.SelectedItems[0].Text;
                    List<string> lc = new List<string>();
                    lc.Add(ho); lc.Add(ten); lc.Add(cmnd); lc.Add(lbKhuvuc.Text); lc.Add(lbLoai.Text); lc.Add(quequan);
                    lc.Add(nghenghiep); lc.Add(ngaysinh.ToString()); lc.Add(makhuvuc);
                    foreach (string c in lc)
                    {
                        if (c == "")
                        {
                            check = 1;
                        }
                    }
                    if (check == 1)
                    {
                        check = 0;
                        MessageBox.Show("Phải nhập đầy đủ thông tin!");
                    }
                    else
                    {
                        KhachDangKy kdk = new KhachDangKy(id, ho, ten, cbGioiTinh.Text, ngaysinh, cmnd, quequan, nghenghiep, makhuvuc, lstLoaiPhong.SelectedItems[0].Text);
                        string sqlInsert = "INSERT INTO ThongTinDangKyPhong(Id,Ho,Ten,GioiTinh,NgaySinh,CMND,QueQuan,NgheNghiep,MaKhuVuc,MaLoaiPhong) VALUES(@id,@ho,@ten,@gioitinh,@ngaysinh,@cmnd,@quequan,@nghenghiep,@makhuvuc,@maloaiphong)";
                        int i = new ThongTinDKBUS().Insert(sqlInsert, kdk);

                        MessageBox.Show("Đã thêm thành công!");
                    }
                }
            }
            catch (FormatException)
            {
                //MessageBox.Show("Phải nhập đầy đủ thông tin!");
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLoaiPhong.SelectedItems.Count == 0)
                return;
            else
            {
                ListViewItem item = lstLoaiPhong.SelectedItems[0];
                lbLoai.Text = item.SubItems[1].Text;
                lbKhuvuc.Text = cbKhuVuc.Text;
            }
        }

        private void cbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstLoaiPhong.Items.Clear();
            string makv = cbKhuVuc.SelectedValue.ToString();

            string sql = "SELECT DISTINCT lp.MaLoaiPhong, lp.TenLoaiPhong, lp.DienTichPhong, lp.DonGia, p.TrangThai FROM LoaiPhong lp, Phong p WHERE p.MaKhuVuc = N'" + makv + "' AND p.TrangThai = N'Trống' AND p.MaLoaiPhong = lp.MaLoaiPhong";
            Room ListLoai = new Room();
            var loaiphong = ListLoai.GetDataPhong(sql);
            for (int i = 0; i < loaiphong.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(loaiphong.Rows[i][0].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][1].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][2].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][3].ToString().TrimEnd());

                lstLoaiPhong.Items.Add(item);
            }
        }
        

        private void formDkyPhongTrong_Load(object sender, EventArgs e)
        {
            LoadKV();
            //cbGioiTinh.SelectedIndex = 0;
        }

        private void txtCmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}

