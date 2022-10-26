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
    public partial class Home_nhanVien : Form
    {
        public Home_nhanVien()
        {
            InitializeComponent();
        }

        private void btn_Log_out_Click(object sender, EventArgs e)
        {
            form.Log_in f1 = new form.Log_in();
            Form1.homee.load_form(f1);
        }

        private void btn_thongtinCaNhan_Click(object sender, EventArgs e)
        {
            ThongtinCaNhan f1 = new ThongtinCaNhan();
            Form1.homee.load_form(f1);
        }

        private void btn_taikhoanDangNhap_Click(object sender, EventArgs e)
        {
            ThongtinTaiKhoan f1 = new ThongtinTaiKhoan();
            Form1.homee.load_form(f1);
        }

        private void btn_nghiPhep_Click(object sender, EventArgs e)
        {
            NghiPhepCaNhan f1 = new NghiPhepCaNhan();
            Form1.homee.load_form(f1);
        }

        private void btn_Luong_Click(object sender, EventArgs e)
        {
            LuongNV f1 = new LuongNV();
            Form1.homee.load_form(f1);
        }

        private void btn_Chitiethopdong_Click(object sender, EventArgs e)
        {
            ChiTietHopDong f1 = new ChiTietHopDong();
            Form1.homee.load_form(f1);
        }
    }
}
