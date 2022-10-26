
namespace do_an.form
{
    partial class Log_in
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiBtn_admin = new System.Windows.Forms.RadioButton();
            this.radiBtn_quanLy = new System.Windows.Forms.RadioButton();
            this.radiBtn_nhanVien = new System.Windows.Forms.RadioButton();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.btn_dangKy = new System.Windows.Forms.Button();
            this.lb_tenDangNhap = new System.Windows.Forms.Label();
            this.lb_mk = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_quenMK = new System.Windows.Forms.Label();
            this.check_password = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(159, 79);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(257, 22);
            this.txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(159, 141);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(257, 22);
            this.txt_password.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiBtn_admin);
            this.groupBox1.Controls.Add(this.radiBtn_quanLy);
            this.groupBox1.Controls.Add(this.radiBtn_nhanVien);
            this.groupBox1.Location = new System.Drawing.Point(33, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 46);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // radiBtn_admin
            // 
            this.radiBtn_admin.AutoSize = true;
            this.radiBtn_admin.Location = new System.Drawing.Point(269, 19);
            this.radiBtn_admin.Name = "radiBtn_admin";
            this.radiBtn_admin.Size = new System.Drawing.Size(68, 21);
            this.radiBtn_admin.TabIndex = 2;
            this.radiBtn_admin.TabStop = true;
            this.radiBtn_admin.Text = "Admin";
            this.radiBtn_admin.UseVisualStyleBackColor = true;
            // 
            // radiBtn_quanLy
            // 
            this.radiBtn_quanLy.AutoSize = true;
            this.radiBtn_quanLy.Location = new System.Drawing.Point(126, 19);
            this.radiBtn_quanLy.Name = "radiBtn_quanLy";
            this.radiBtn_quanLy.Size = new System.Drawing.Size(78, 21);
            this.radiBtn_quanLy.TabIndex = 1;
            this.radiBtn_quanLy.TabStop = true;
            this.radiBtn_quanLy.Text = "Quản lý";
            this.radiBtn_quanLy.UseVisualStyleBackColor = true;
            // 
            // radiBtn_nhanVien
            // 
            this.radiBtn_nhanVien.AutoSize = true;
            this.radiBtn_nhanVien.Location = new System.Drawing.Point(7, 19);
            this.radiBtn_nhanVien.Name = "radiBtn_nhanVien";
            this.radiBtn_nhanVien.Size = new System.Drawing.Size(93, 21);
            this.radiBtn_nhanVien.TabIndex = 0;
            this.radiBtn_nhanVien.TabStop = true;
            this.radiBtn_nhanVien.Text = "Nhân viên";
            this.radiBtn_nhanVien.UseVisualStyleBackColor = true;
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Location = new System.Drawing.Point(33, 275);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(383, 39);
            this.btn_dangNhap.TabIndex = 3;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // btn_dangKy
            // 
            this.btn_dangKy.Location = new System.Drawing.Point(33, 361);
            this.btn_dangKy.Name = "btn_dangKy";
            this.btn_dangKy.Size = new System.Drawing.Size(383, 36);
            this.btn_dangKy.TabIndex = 4;
            this.btn_dangKy.Text = "Đăng ký";
            this.btn_dangKy.UseVisualStyleBackColor = true;
            this.btn_dangKy.Click += new System.EventHandler(this.btn_dangKy_Click);
            // 
            // lb_tenDangNhap
            // 
            this.lb_tenDangNhap.AutoSize = true;
            this.lb_tenDangNhap.Location = new System.Drawing.Point(30, 82);
            this.lb_tenDangNhap.Name = "lb_tenDangNhap";
            this.lb_tenDangNhap.Size = new System.Drawing.Size(105, 17);
            this.lb_tenDangNhap.TabIndex = 5;
            this.lb_tenDangNhap.Text = "Tên đăng nhập";
            // 
            // lb_mk
            // 
            this.lb_mk.AutoSize = true;
            this.lb_mk.Location = new System.Drawing.Point(30, 144);
            this.lb_mk.Name = "lb_mk";
            this.lb_mk.Size = new System.Drawing.Size(66, 17);
            this.lb_mk.TabIndex = 6;
            this.lb_mk.Text = "Mật khẩu";
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(13, 13);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(445, 39);
            this.lb_title.TabIndex = 7;
            this.lb_title.Text = "Đăng nhập";
            // 
            // lb_quenMK
            // 
            this.lb_quenMK.AutoSize = true;
            this.lb_quenMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_quenMK.Location = new System.Drawing.Point(156, 328);
            this.lb_quenMK.Name = "lb_quenMK";
            this.lb_quenMK.Size = new System.Drawing.Size(113, 17);
            this.lb_quenMK.TabIndex = 8;
            this.lb_quenMK.Text = "Quên mật khẩu?";
            this.lb_quenMK.Click += new System.EventHandler(this.lb_quenMK_Click);
            // 
            // check_password
            // 
            this.check_password.AutoSize = true;
            this.check_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_password.Location = new System.Drawing.Point(159, 169);
            this.check_password.Name = "check_password";
            this.check_password.Size = new System.Drawing.Size(109, 19);
            this.check_password.TabIndex = 9;
            this.check_password.Text = "Hiện mật khẩu";
            this.check_password.UseVisualStyleBackColor = true;
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 428);
            this.Controls.Add(this.check_password);
            this.Controls.Add(this.lb_quenMK);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.lb_mk);
            this.Controls.Add(this.lb_tenDangNhap);
            this.Controls.Add(this.btn_dangKy);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Name = "Log_in";
            this.Text = "Log_in";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiBtn_admin;
        private System.Windows.Forms.RadioButton radiBtn_quanLy;
        private System.Windows.Forms.RadioButton radiBtn_nhanVien;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.Button btn_dangKy;
        private System.Windows.Forms.Label lb_tenDangNhap;
        private System.Windows.Forms.Label lb_mk;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_quenMK;
        private System.Windows.Forms.CheckBox check_password;
    }
}