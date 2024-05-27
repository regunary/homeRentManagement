using QuanLyNhaTroMain.cntdatafrm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTroMain.QuanLy
{
    public partial class formQuanLyLoaiPhong : Form
    {
        int request;
        string maloaiphong;
        public formQuanLyLoaiPhong()
        {
            InitializeComponent();
        }

        private void formQuanLyLoaiPhong_Load(object sender, EventArgs e)
        {
            Load_datagrid();
        }

        private void Load_datagrid()
        {
            dgvQLLP.Rows.Clear();

            dgvQLLP.ColumnCount = 4;
            dgvQLLP.Columns[0].Name = "Mã Loại Phòng";
            dgvQLLP.Columns[1].Name = "Tên Loại Phòng";
            dgvQLLP.Columns[2].Name = "Diện tích";
            dgvQLLP.Columns[3].Name = "Giá";

            string sql = "SELECT * From LoaiPhong";
            var dsphong = new Room().GetDataPhong(sql);

            for (int i = 0; i < dsphong.Rows.Count; i++)
            {
                ArrayList row = new ArrayList();
                row.Add(dsphong.Rows[i][0].ToString());
                row.Add(dsphong.Rows[i][1].ToString());
                row.Add(dsphong.Rows[i][2].ToString());
                row.Add(dsphong.Rows[i][3].ToString());
                dgvQLLP.Rows.Add(row.ToArray());
            }
        }

        private void dgvQLLP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQLLP.SelectedCells.Count > 0)
            {
                int index = dgvQLLP.SelectedCells[0].RowIndex;
                DataGridViewRow selectedrow = dgvQLLP.Rows[index];
                maloaiphong = Convert.ToString(selectedrow.Cells["Mã Loại Phòng"].Value);

                var data = new Room().GetDataPhong("SELECT * From LoaiPhong WHERE MaLoaiPhong='" + maloaiphong + "'");
                txtMLP.Text = data.Rows[0][0].ToString();
                txtTLP.Text = data.Rows[0][1].ToString();
                txtDT.Text = data.Rows[0][2].ToString();
                txtGia.Text = data.Rows[0][3].ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            request = 1;
            //Enable + Clear
            txtMLP.Text = ""; txtTLP.Text = ""; txtDT.Text = ""; txtGia.Text = "";
            txtMLP.Enabled = true; txtTLP.Enabled = true; txtDT.Enabled = true; txtGia.Enabled = true;
            btLuu.Visible = true; btHuy.Visible = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            switch (request)
            {
                case 1:
                    {

                        //Them Loai Phong
                        string sql = "INSERT INTO LoaiPhong (MaLoaiPhong,TenLoaiPhong,DienTichPhong,DonGia) VALUES(@maloaiphong,@tenloaiphong,@dientich,@gia)";
                        string maloaiphong = txtMLP.Text.ToString(),
                                tenloaiphong = txtTLP.Text.ToString();
                        double dientich = Convert.ToDouble(txtDT.Text),
                                gia = Convert.ToDouble(txtGia.Text);

                        int i = new PhongBUS().themloaiphong(sql, maloaiphong, tenloaiphong, dientich, gia);

                        MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btLuu.Visible = false; btHuy.Visible = false;
                        btSua.Enabled = true; btXoa.Enabled = true;
                        disable_textbox();
                        Load_datagrid();
                        txtMLP.Text = ""; txtTLP.Text = ""; txtDT.Text = ""; txtGia.Text = "";
                    }
                    break;
                case 2:
                    {

                        //SuaLoaiPhong

                        string sql = "UPDATE LoaiPhong SET MaLoaiPhong=@maloaiphong, TenLoaiPhong=@tenloaiphong, DienTichPhong=@dientich,DonGia=@gia WHERE MaLoaiPhong='" + maloaiphong + "'";
                        string mlp = txtMLP.Text.ToString(),
                                tenloaiphong = txtTLP.Text.ToString();
                        double dientich = Convert.ToDouble(txtDT.Text),
                                gia = Convert.ToDouble(txtGia.Text);

                        int i = new PhongBUS().themloaiphong(sql, maloaiphong, tenloaiphong, dientich, gia);

                        MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btLuu.Visible = false; btHuy.Visible = false;
                        btThem.Enabled = true; btXoa.Enabled = true;
                        disable_textbox();
                        Load_datagrid();
                        txtMLP.Text = ""; txtTLP.Text = ""; txtDT.Text = ""; txtGia.Text = "";
                    }
                    break;

                default:
                    break;
            }
        }

        private void disable_textbox()
        {
            txtMLP.Enabled = false; txtTLP.Enabled = false; txtDT.Enabled = false; txtGia.Enabled = false;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            request = 2;
            txtMLP.Enabled = true; txtTLP.Enabled = true; txtDT.Enabled = true; txtGia.Enabled = true;
            btLuu.Visible = true; btHuy.Visible = true;
            btThem.Enabled = false;
            btXoa.Enabled = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa loại phòng: " + txtTLP.Text + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE From LoaiPhong WHERE MaLoaiPhong='" + maloaiphong + "'";
                int i = new PhongBUS().XoaLoaiPhong(sql);

                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_datagrid();

            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Load_datagrid();
            btLuu.Visible = false; btHuy.Visible = false;
            txtMLP.Enabled = false; txtTLP.Enabled = false; txtDT.Enabled = false; txtGia.Enabled = false;
            btSua.Enabled = true; btXoa.Enabled = true; btThem.Enabled = true;
        }
    }
}
