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

namespace QuanLyNhaTroMain.Taikhoan
{
    public partial class formThemTaiKhoan : Form
    {
        public formThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string pass = txtpassword.Text;
            DangNhap dn = new DangNhap(id, pass);
            string sql = "INSERT INTO DangNhap(ID,PassWord) VALUES(@id,@pass)";
            int i = new DangNhapBUS().ThemTK(sql, dn);
            if (i == 1)
                MessageBox.Show("Thêm thành công!");
            this.Close();
        }
    }
}
