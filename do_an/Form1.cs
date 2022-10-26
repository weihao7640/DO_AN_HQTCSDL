using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form activeForm;

        public static int radiu;
        public int Radiu {
            get => radiu; private set => radiu = value;
        }
        public static int mk;
        public int Mk
        {
            get => mk; private set => mk = value;
        }

        public static Form1 homee;
        public Form1 Homee { get => homee; private set => homee = value; }
        public void load_form(Form f1)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = f1;
            f1.TopLevel = false;
            pn_content.Controls.Add(f1);
            pn_content.Tag = f1;
            f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            f1.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            homee = this;
            form.Log_in f1 = new form.Log_in();
            load_form(f1);
        }
    }
}
