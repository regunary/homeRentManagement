using QuanLyNhaTroMain.cntdatafrm;
using QuanLyNhaTroMain.getset;
using QuanLyNhaTroMain.Taikhoan;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void btndnhap_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Count(*) FROM DangNhap WHERE ID=@id AND PassWord=@pw";
            string a = txtLogin.Text;
            string b = txtPassword.Text;
            int x = new DangNhapBUS().Log(sql, a, b);
            if (txtLogin.Text == "") MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else 
            if (txtPassword.Text == "") MessageBox.Show("Bạn chưa nhập mật khẩu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            if (x == 1)
            {
                GiaoDienAdmin frmM = new GiaoDienAdmin();
                frmM.Show();
                AccountInformation acc = new AccountInformation();
                acc.Taikhoan = txtLogin.Text;
                acc.Matkhau= b = txtPassword.Text;

                if (cbSave.Checked)
                {
                    int i = new DangNhapBUS().Save(a, b);
                }
                else
                {
                    int j = new DangNhapBUS().Xoa();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cbSave.Checked = true;
            string sql = "SELECT * FROM GhiNho";
            List<GhiNho> tmp = new DangNhapBUS().getGN(sql);
            txtLogin.DataBindings.Add("Text", tmp, "ID");
            txtPassword.DataBindings.Add("Text", tmp, "Pass");
        }
        private void btReset_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
