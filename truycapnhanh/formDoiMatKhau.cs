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

namespace QuanLyNhaTroMain.truycapnhanh
{
    public partial class formDoiMatKhau : Form
    {
        private string id, pass;
        public formDoiMatKhau()
        {
            InitializeComponent();
        }
        public formDoiMatKhau(string username, string pas) : this()
        {
            id = username;
            pass = pas;
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            string oldP, newP, rewrite;
            oldP = txtOldPass.Text;
            newP = txtNewPass.Text;
            rewrite = txtRewrite.Text;
            if (oldP == "" || newP == "" || rewrite == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (pass == oldP)
                {
                    if (newP == rewrite)
                    {
                        int i = new DangNhapBUS().ChangePass(id, newP);
                        MessageBox.Show("Thay đổi thành công");
                        Close();
                    }
                    else
                        MessageBox.Show("Vui lòng nhập lại mật khẩu mới", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Mật khẩu không đúng", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
