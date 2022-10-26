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
    public partial class DanhSachNV : Form
    {
        public DanhSachNV()
        {
            InitializeComponent();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            hide_show_btn(0);
        }

        void hide_show_btn(int i)
        {
            if (i == 1)
            {
                btn_change.Show();
                btn_delete.Show();
                btn_save.Hide();
                btn_huy.Hide();
                btn_loadAnh.Hide();
            }
            else
            {
                btn_change.Hide();
                btn_delete.Hide();
                btn_huy.Show();
                btn_save.Show();
                btn_loadAnh.Show();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            hide_show_btn(1);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            hide_show_btn(1);
        }

        private void DanhSachNV_Load(object sender, EventArgs e)
        {
            grB_thongtinNV.Hide();
        }

        private void txt_keysearch_Click(object sender, EventArgs e)
        {
            if (txt_keysearch.Text=="Nhập từ khóa tìm kiếm") {
                txt_keysearch.Text = ""; }
        }

        private void txt_keysearch_Leave(object sender, EventArgs e)
        {
            if (txt_keysearch.Text == "")
            {
                txt_keysearch.Text = "Nhập từ khóa tìm kiếm";
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            grB_thongtinNV.Show();
            hide_show_btn(1);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (Form1.radiu == 1)
            { Home_nhanVien f1 = new Home_nhanVien(); Form1.homee.load_form(f1); }
            else if (Form1.radiu == 2)
            { Home_quanLy f1 = new Home_quanLy(); Form1.homee.load_form(f1); }
            else
            { Home_admin f1 = new Home_admin(); Form1.homee.load_form(f1); }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            grB_thongtinNV.Show();
            hide_show_btn(0);

        }
    }
}
