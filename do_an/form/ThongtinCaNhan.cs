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
    public partial class ThongtinCaNhan : Form
    {
        public ThongtinCaNhan()
        {
            InitializeComponent();
        }

        private void ThongtinCaNhan_Load(object sender, EventArgs e)
        {
            hide_show_btn(1);
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            hide_show_btn(0);
        }

        void hide_show_btn(int i)
        {
            if (i==1)
            {
                btn_change.Show();
                btn_save.Hide();
                btn_huy.Hide();
            }    
            else
            {
                btn_change.Hide();
                btn_huy.Show();
                btn_save.Show();
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (Form1.radiu == 1)
            { Home_nhanVien f1 = new Home_nhanVien(); Form1.homee.load_form(f1); }
            else if (Form1.radiu == 2)
            { Home_quanLy f1 = new Home_quanLy(); Form1.homee.load_form(f1); }
            else
            { Home_admin f1 = new Home_admin(); Form1.homee.load_form(f1); }
        }
    }
}
