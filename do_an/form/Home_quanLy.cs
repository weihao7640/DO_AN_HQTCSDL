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
    public partial class Home_quanLy : Form
    {
        public Home_quanLy()
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

        private void btn_Luong_Click(object sender, EventArgs e)
        {
            LuongNV f1 = new LuongNV();
            Form1.homee.load_form(f1);
        }

        private void btn_phongBan_Click(object sender, EventArgs e)
        {
            DanhSachNV f1 = new DanhSachNV();
            Form1.homee.load_form(f1);
        }

        private void btn_nghiPhepCaNhan_Click(object sender, EventArgs e)
        {
            NghiPhepCaNhan f1 = new NghiPhepCaNhan();
            Form1.homee.load_form(f1);
        }

        private void btn_nghiPhepTaiPhongBan_Click(object sender, EventArgs e)
        {
            DanhSachNghiPhep f1 = new DanhSachNghiPhep();
            Form1.homee.load_form(f1);
        }

        private void btn_chitietHopDong_Click(object sender, EventArgs e)
        {
            ChiTietHopDong f1 = new ChiTietHopDong();
            Form1.homee.load_form(f1);
        }

        private void btn_kyluat_khenthuong_Click(object sender, EventArgs e)
        {
            DanhSachKyLuat_KhenThuong f1 = new DanhSachKyLuat_KhenThuong();
            Form1.homee.load_form(f1);
        }

        private void btn_luong_nhanVien_Click(object sender, EventArgs e)
        {
            DanhSachLuong f1 = new DanhSachLuong();
            Form1.homee.load_form(f1);
        }
    }
}
