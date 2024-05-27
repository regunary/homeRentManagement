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
    public partial class AccountInformation : Form
    {
        private string _taikhoan;
        private string _matkhau;
        public AccountInformation()
        {
            InitializeComponent();
        }
        public string Taikhoan
        {
            get { return _taikhoan; }
            set { _taikhoan = value; }
        }
        public string Matkhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }

        private void AccountInformation_Load(object sender, EventArgs e)
        {
            //string sql = "SELECT * FROM GhiNho";
            //List<GhiNho> tmp = new DangNhapBUS().getGN(sql);
            //txtLogin.DataBindings.Add("Text", tmp, "ID");
            //lbShowName.Text = ;
            
            label5.Text = _matkhau;
            label7.Text = "Đã kích hoạt";
        }
    }
}
