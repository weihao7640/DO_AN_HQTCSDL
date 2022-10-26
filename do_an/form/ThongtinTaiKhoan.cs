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
    public partial class ThongtinTaiKhoan : Form
    {
        public ThongtinTaiKhoan()
        {
            InitializeComponent();
        }

        private void lb_quenMK_Click(object sender, EventArgs e)
        {
            Form1.mk = 2;
            QuenMK f1 = new QuenMK();
            Form1.homee.load_form(f1);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (Form1.radiu==1)
            { Home_nhanVien f1 = new Home_nhanVien(); Form1.homee.load_form(f1); }    
            else if (Form1.radiu==2)
            { Home_quanLy f1 = new Home_quanLy(); Form1.homee.load_form(f1); }
            else
            { Home_admin f1 = new Home_admin(); Form1.homee.load_form(f1); }    
        }

        private void btn_doiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau f1 = new DoiMatKhau();
            Form1.homee.load_form(f1);
        }
    }
}
