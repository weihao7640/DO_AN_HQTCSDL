using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an.form
{
    public partial class Home_admin : Form
    {
        public Home_admin()
        {
            InitializeComponent();
        }

        private void btn_Log_out_Click(object sender, EventArgs e)
        {
            form.Log_in f1 = new form.Log_in();
            Form1.homee.load_form(f1);
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            ThongtinTaiKhoan f1 = new ThongtinTaiKhoan();
            Form1.homee.load_form(f1);
        }

        private void btn_ds_nhanvien_Click(object sender, EventArgs e)
        {
            DanhSachNV f1 = new DanhSachNV();
            Form1.homee.load_form(f1);
        }

        private void btn_ds_phongban_Click(object sender, EventArgs e)
        {

        }

        private void btn_ds_kyluat_khenthuong_Click(object sender, EventArgs e)
        {
            DanhSachKyLuat_KhenThuong f1 = new DanhSachKyLuat_KhenThuong();
            Form1.homee.load_form(f1);
        }

        private void Home_admin_Load(object sender, EventArgs e)
        {

        }

        private void btn_ds_Luong_Click(object sender, EventArgs e)
        {
            DanhSachLuong f1 = new DanhSachLuong(); 
            Form1.homee.load_form(f1);
        }

        private void btn_ds_nghiPhep_Click(object sender, EventArgs e)
        {
            DanhSachNghiPhep f1 = new DanhSachNghiPhep();
            Form1.homee.load_form(f1);
        }
    }
}
