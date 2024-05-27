using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using QuanLyNhaTroMain.Chuc_nang;
using QuanLyNhaTroMain.QuanLy;
using QuanLyNhaTroMain.Taikhoan;
using QuanLyNhaTroMain.truycapnhanh;
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
    public partial class GiaoDienAdmin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public GiaoDienAdmin()
        {
            InitializeComponent();
        }

        private void GiaoDienAdmin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dockPanel1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonTrangThaiThue_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new formTrangThaiThuePhong();
            
                foreach (var child in MdiChildren) //tìm kiếm
                {
                    if (child.Name == form.Name) //kiểm tra trước đó
                    {
                        child.Activate(); //active
                        return;
                    }
                }
            
            form.MdiParent = this;
            form.Show();
        }
        

        private void buttonThuTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new formThuTien();
            foreach (var child in MdiChildren) //tìm kiếm
            {
                if (child.Name == form.Name) //kiểm tra trước đó
                {
                    child.Activate(); //active
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void buttonTraPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new formTraPhong();
            foreach (var child in MdiChildren) //tìm kiếm
            {
                if (child.Name == form.Name) //kiểm tra trước đó
                {
                    child.Activate(); //active
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void btnThemNguoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new formThemNguoi();
            foreach (var child in MdiChildren) //tìm kiếm
            {
                if (child.Name == form.Name) //kiểm tra trước đó
                {
                    child.Activate(); //active
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void btnDKPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new formSapPhong();
            foreach (var child in MdiChildren) //tìm kiếm
            {
                if (child.Name == form.Name) //kiểm tra trước đó
                {
                    child.Activate(); //active
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new formQuanLyLoaiPhong();
            foreach (var child in MdiChildren) //tìm kiếm
            {
                if (child.Name == form.Name) //kiểm tra trước đó
                {
                    child.Activate(); //active
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new formDoanhThu();
            foreach (var child in MdiChildren) //tìm kiếm
            {
                if (child.Name == form.Name) //kiểm tra trước đó
                {
                    child.Activate(); //active
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new formQuanLyPhongTro();
            foreach (var child in MdiChildren) //tìm kiếm
            {
                if (child.Name == form.Name) //kiểm tra trước đó
                {
                    child.Activate(); //active
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnTienPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new formThanhToan();
            foreach (var child in MdiChildren) //tìm kiếm
            {
                if (child.Name == form.Name) //kiểm tra trước đó
                {
                    child.Activate(); //active
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new formQuanLyKhach();
            foreach (var child in MdiChildren) //tìm kiếm
            {
                if (child.Name == form.Name) //kiểm tra trước đó
                {
                    child.Activate(); //active
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void Btninfor1_Click(object sender, EventArgs e)
        {
            AccountInformation infor1 = new AccountInformation();
            infor1.Show();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            formDoiMatKhau change = new formDoiMatKhau();
            change.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new formQuanLyKhach();
            foreach (var child in MdiChildren) //tìm kiếm
            {
                if (child.Name == form.Name) //kiểm tra trước đó
                {
                    child.Activate(); //active
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void btnDV_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
    

        private void tkdoanhthu_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new formDoanhThu();
            foreach (var child in MdiChildren) //tìm kiếm
            {
                if (child.Name == form.Name) //kiểm tra trước đó
                {
                    child.Activate(); //active
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void btnnguoidung_ItemClick(object sender, ItemClickEventArgs e)
        {
            formThemTaiKhoan add = new formThemTaiKhoan();
            add.Show();
        }

        private void btnaccadmin_ItemClick(object sender, ItemClickEventArgs e)
        {
            formDoiMatKhau change = new formDoiMatKhau();
            change.Show();
        }

        private void btninfor_ItemClick(object sender, ItemClickEventArgs e)
        {
            AccountInformation acc = new AccountInformation();
            acc.Show();
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var form = new dichvu();
            foreach (var child in MdiChildren) //tìm kiếm
            {
                if (child.Name == form.Name) //kiểm tra trước đó
                {
                    child.Activate(); //active
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }
    }
}