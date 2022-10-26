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
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void btn_dangKy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng đăng nhập dưới quyền admin hoặc quản lý để đăng ký nhân viên","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            if (radiBtn_nhanVien.Checked == true)
            {
                Form1.radiu = 1;
                form.Home_nhanVien f1 = new form.Home_nhanVien();
                Form1.homee.load_form(f1);
            }
            if (radiBtn_quanLy.Checked==true)
            {
                Form1.radiu = 2;
                form.Home_quanLy f1 = new form.Home_quanLy();
                Form1.homee.load_form(f1);
            }    
            if (radiBtn_admin.Checked==true)
            {
                Form1.radiu = 3;
                form.Home_admin f1 = new form.Home_admin();
                Form1.homee.load_form(f1);
            }    
        }

        private void lb_quenMK_Click(object sender, EventArgs e)
        {
            Form1.mk = 1;
            form.QuenMK f1 = new QuenMK();
            Form1.homee.load_form(f1);
        }
    }
}
