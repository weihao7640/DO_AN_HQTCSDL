
namespace do_an.form
{
    partial class QuenMK
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_yc = new System.Windows.Forms.Label();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.pn_timkiem = new System.Windows.Forms.Panel();
            this.btn_layMK = new System.Windows.Forms.Button();
            this.lb_maXN = new System.Windows.Forms.Label();
            this.txt_maXN = new System.Windows.Forms.TextBox();
            this.btn_checkEmail = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_hoTenNV = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_hotenNV = new System.Windows.Forms.Label();
            this.pictureBox_anhNV = new System.Windows.Forms.PictureBox();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.pn_timkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anhNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quên mật khẩu";
            // 
            // lb_yc
            // 
            this.lb_yc.AutoSize = true;
            this.lb_yc.Location = new System.Drawing.Point(86, 77);
            this.lb_yc.Name = "lb_yc";
            this.lb_yc.Size = new System.Drawing.Size(188, 17);
            this.lb_yc.TabIndex = 1;
            this.lb_yc.Text = "Vui lòng nhập mã nhân viên ";
            // 
            // txt_maNV
            // 
            this.txt_maNV.Location = new System.Drawing.Point(304, 77);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(100, 22);
            this.txt_maNV.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(210, 114);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(234, 26);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Tìm kiếm tài khoản";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pn_timkiem
            // 
            this.pn_timkiem.Controls.Add(this.btn_layMK);
            this.pn_timkiem.Controls.Add(this.lb_maXN);
            this.pn_timkiem.Controls.Add(this.txt_maXN);
            this.pn_timkiem.Controls.Add(this.btn_checkEmail);
            this.pn_timkiem.Controls.Add(this.txt_email);
            this.pn_timkiem.Controls.Add(this.txt_hoTenNV);
            this.pn_timkiem.Controls.Add(this.lb_email);
            this.pn_timkiem.Controls.Add(this.lb_hotenNV);
            this.pn_timkiem.Controls.Add(this.pictureBox_anhNV);
            this.pn_timkiem.Location = new System.Drawing.Point(46, 160);
            this.pn_timkiem.Name = "pn_timkiem";
            this.pn_timkiem.Size = new System.Drawing.Size(516, 229);
            this.pn_timkiem.TabIndex = 4;
            // 
            // btn_layMK
            // 
            this.btn_layMK.Location = new System.Drawing.Point(254, 176);
            this.btn_layMK.Name = "btn_layMK";
            this.btn_layMK.Size = new System.Drawing.Size(155, 40);
            this.btn_layMK.TabIndex = 8;
            this.btn_layMK.Text = "Reset lại mật khẩu";
            this.btn_layMK.UseVisualStyleBackColor = true;
            this.btn_layMK.Click += new System.EventHandler(this.btn_layMK_Click);
            // 
            // lb_maXN
            // 
            this.lb_maXN.AutoSize = true;
            this.lb_maXN.Location = new System.Drawing.Point(185, 139);
            this.lb_maXN.Name = "lb_maXN";
            this.lb_maXN.Size = new System.Drawing.Size(126, 17);
            this.lb_maXN.TabIndex = 7;
            this.lb_maXN.Text = "Nhập mã xác nhận";
            // 
            // txt_maXN
            // 
            this.txt_maXN.Location = new System.Drawing.Point(317, 136);
            this.txt_maXN.Name = "txt_maXN";
            this.txt_maXN.Size = new System.Drawing.Size(178, 22);
            this.txt_maXN.TabIndex = 6;
            // 
            // btn_checkEmail
            // 
            this.btn_checkEmail.Location = new System.Drawing.Point(302, 93);
            this.btn_checkEmail.Name = "btn_checkEmail";
            this.btn_checkEmail.Size = new System.Drawing.Size(193, 23);
            this.btn_checkEmail.TabIndex = 5;
            this.btn_checkEmail.Text = "Gửi mã xác nhận về email";
            this.btn_checkEmail.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(245, 65);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(250, 22);
            this.txt_email.TabIndex = 4;
            this.txt_email.Text = "*********67@gmail.com";
            // 
            // txt_hoTenNV
            // 
            this.txt_hoTenNV.Location = new System.Drawing.Point(245, 24);
            this.txt_hoTenNV.Name = "txt_hoTenNV";
            this.txt_hoTenNV.Size = new System.Drawing.Size(250, 22);
            this.txt_hoTenNV.TabIndex = 3;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(182, 68);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(46, 17);
            this.lb_email.TabIndex = 2;
            this.lb_email.Text = "Email:";
            // 
            // lb_hotenNV
            // 
            this.lb_hotenNV.AutoSize = true;
            this.lb_hotenNV.Location = new System.Drawing.Point(179, 27);
            this.lb_hotenNV.Name = "lb_hotenNV";
            this.lb_hotenNV.Size = new System.Drawing.Size(50, 17);
            this.lb_hotenNV.TabIndex = 1;
            this.lb_hotenNV.Text = "Họ tên";
            // 
            // pictureBox_anhNV
            // 
            this.pictureBox_anhNV.Location = new System.Drawing.Point(30, 27);
            this.pictureBox_anhNV.Name = "pictureBox_anhNV";
            this.pictureBox_anhNV.Size = new System.Drawing.Size(143, 163);
            this.pictureBox_anhNV.TabIndex = 0;
            this.pictureBox_anhNV.TabStop = false;
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Location = new System.Drawing.Point(237, 168);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(160, 17);
            this.lb_thongbao.TabIndex = 5;
            this.lb_thongbao.Text = "Chưa tìm thấy nhân viên";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(487, 20);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 19;
            this.btn_back.Text = "<<<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 401);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_thongbao);
            this.Controls.Add(this.pn_timkiem);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_maNV);
            this.Controls.Add(this.lb_yc);
            this.Controls.Add(this.label1);
            this.Name = "QuenMK";
            this.Text = "QuenMK";
            this.Load += new System.EventHandler(this.QuenMK_Load);
            this.pn_timkiem.ResumeLayout(false);
            this.pn_timkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anhNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_yc;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel pn_timkiem;
        private System.Windows.Forms.Button btn_checkEmail;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_hoTenNV;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_hotenNV;
        private System.Windows.Forms.PictureBox pictureBox_anhNV;
        private System.Windows.Forms.Button btn_layMK;
        private System.Windows.Forms.Label lb_maXN;
        private System.Windows.Forms.TextBox txt_maXN;
        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.Button btn_back;
    }
}