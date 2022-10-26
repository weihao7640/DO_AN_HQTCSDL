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
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
        }

        private void QuenMK_Load(object sender, EventArgs e)
        {
            pn_timkiem.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            lb_thongbao.Hide();
            pn_timkiem.Show();
        }

        private void btn_layMK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mật khẩu của bạn đã được đặt về ban đầu!\n Vui lòng nhập CMND/CCCD tương ứng để đăng nhập!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (Form1.mk == 1)
            { Log_in f1 = new Log_in(); Form1.homee.load_form(f1); }    
            else
            { ThongtinTaiKhoan f1 = new ThongtinTaiKhoan(); Form1.homee.load_form(f1); }    
           

        }
    }
}
