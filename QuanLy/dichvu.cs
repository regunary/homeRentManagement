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
    public partial class dichvu : Form
    {
        string id;
        int request;
        public dichvu()
        {
            InitializeComponent();
        }

        private void dichvu_Load(object sender, EventArgs e)
        {
            Load_datagrid();
        }

        private void Load_datagrid()
        {
            dgvQLDV.Rows.Clear();

            dgvQLDV.ColumnCount = 3;
            dgvQLDV.Columns[0].Name = "Mã dịch vụ";
            dgvQLDV.Columns[1].Name = "Tên dịch vụ";
            dgvQLDV.Columns[2].Name = "Đơn giá";

            string sql = "SELECT * From DichVu";
            var dsphong = new Room().GetDataPhong(sql);

            for (int i = 0; i < dsphong.Rows.Count; i++)
            {
                ArrayList row = new ArrayList();
                row.Add(dsphong.Rows[i][0].ToString());
                row.Add(dsphong.Rows[i][1].ToString());
                row.Add(dsphong.Rows[i][2].ToString());
                dgvQLDV.Rows.Add(row.ToArray());
            }
        }

        private void dgvQLDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQLDV.SelectedCells.Count > 0)
            {
                int index = dgvQLDV.SelectedCells[0].RowIndex;
                DataGridViewRow selectedrow = dgvQLDV.Rows[index];
                id = Convert.ToString(selectedrow.Cells["Mã dịch vụ"].Value);

                var data = new Room().GetDataPhong("SELECT * From DichVu WHERE Id='" + id + "'");
                tbID.Text = data.Rows[0][0].ToString();
                tbTenDichVu.Text = data.Rows[0][1].ToString();
                tbDonGia.Text = data.Rows[0][2].ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            request = 1;
            tbID.Text = ""; tbTenDichVu.Text = ""; tbDonGia.Text = "";
            tbID.Enabled = true; tbTenDichVu.Enabled = true; tbDonGia.Enabled = true;
            btnLuu.Visible = true; btnHuy.Visible = true;
            btSua.Enabled = false;
            btSua.Enabled = false;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            request = 2;
            tbID.Enabled = true; tbTenDichVu.Enabled = true; tbDonGia.Enabled = true;
            btnLuu.Visible = true; btnHuy.Visible = true;
            btThem.Enabled = false;
            btXoa.Enabled = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dịch vụ: " + tbTenDichVu.Text + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE From DichVu WHERE Id='" + id + "'";
                int i = new PhongBUS().XoaLoaiPhong(sql);

                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_datagrid();

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (request)
            {
                case 1:
                    {

                        //Them Loai Phong
                        string sql = "INSERT INTO DichVu (Id,TenDichVu,Gia) VALUES(@id,@tendichvu,@gia)";
                        string tendichvu = tbTenDichVu.Text;
                        double gia = Convert.ToDouble(tbDonGia.Text);
                        int i = new PhongBUS().themdichvu(sql, id, tendichvu, gia);
                        MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLuu.Visible = false; btnHuy.Visible = false;
                        btSua.Enabled = true; btXoa.Enabled = true;
                        disable_textbox();
                        Load_datagrid();

                    }
                    break;
                case 2:
                    {

                        //SuaLoaiPhong

                        string sql = "UPDATE DichVu SET Id=@id, TenDichVu=@tendichvu,Gia=@gia WHERE Id='" + id + "'";
                        string ma = tbID.Text,
                            tendichvu = tbTenDichVu.Text;
                        double gia = Convert.ToDouble(tbDonGia.Text);
                        int i = new PhongBUS().themdichvu(sql, ma, tendichvu, gia);
                        MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLuu.Visible = false; btnHuy.Visible = false;
                        btThem.Enabled = true; btXoa.Enabled = true;
                        disable_textbox();
                        Load_datagrid();

                    }
                    break;

                default:
                    break;
            }
        }

        private void disable_textbox()
        {
            tbID.Enabled = false; tbDonGia.Enabled = false; tbTenDichVu.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Load_datagrid();
            btnLuu.Visible = false; btnHuy.Visible = false;
            tbID.Enabled = false; tbID.Enabled = false; tbDonGia.Enabled = false;
            btSua.Enabled = true; btXoa.Enabled = true; btThem.Enabled = true;
        }
    }
}
