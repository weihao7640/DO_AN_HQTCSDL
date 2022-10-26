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
    public partial class NghiPhepCaNhan : Form
    {
        public NghiPhepCaNhan()
        {
            InitializeComponent();
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

        private void lb_mouth_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Luong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {

        }

        private void cbb_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbb_mouth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_year_Click(object sender, EventArgs e)
        {

        }

        private void lb_title_Click(object sender, EventArgs e)
        {

        }
    }
}
