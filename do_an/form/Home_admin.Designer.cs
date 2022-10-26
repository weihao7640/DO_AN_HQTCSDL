
namespace do_an.form
{
    partial class Home_admin
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
            this.lb_tenNV = new System.Windows.Forms.Label();
            this.lb_maNV = new System.Windows.Forms.Label();
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_ds_kyluat_khenthuong = new System.Windows.Forms.Button();
            this.btn_ds_nhanvien = new System.Windows.Forms.Button();
            this.btn_ds_Luong = new System.Windows.Forms.Button();
            this.btn_ds_phongban = new System.Windows.Forms.Button();
            this.btn_ds_nghiPhep = new System.Windows.Forms.Button();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.txt_tenNV = new System.Windows.Forms.TextBox();
            this.btn_Log_out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_tenNV
            // 
            this.lb_tenNV.AutoSize = true;
            this.lb_tenNV.Location = new System.Drawing.Point(22, 48);
            this.lb_tenNV.Name = "lb_tenNV";
            this.lb_tenNV.Size = new System.Drawing.Size(99, 17);
            this.lb_tenNV.TabIndex = 11;
            this.lb_tenNV.Text = "Tên nhân viên";
            // 
            // lb_maNV
            // 
            this.lb_maNV.AutoSize = true;
            this.lb_maNV.Location = new System.Drawing.Point(22, 19);
            this.lb_maNV.Name = "lb_maNV";
            this.lb_maNV.Size = new System.Drawing.Size(93, 17);
            this.lb_maNV.TabIndex = 10;
            this.lb_maNV.Text = "Mã nhân viên";
            // 
            // btn_account
            // 
            this.btn_account.Location = new System.Drawing.Point(25, 90);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(193, 108);
            this.btn_account.TabIndex = 9;
            this.btn_account.Text = "Tài khoản đăng nhập";
            this.btn_account.UseVisualStyleBackColor = true;
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
            // 
            // btn_ds_kyluat_khenthuong
            // 
            this.btn_ds_kyluat_khenthuong.Location = new System.Drawing.Point(25, 232);
            this.btn_ds_kyluat_khenthuong.Name = "btn_ds_kyluat_khenthuong";
            this.btn_ds_kyluat_khenthuong.Size = new System.Drawing.Size(193, 108);
            this.btn_ds_kyluat_khenthuong.TabIndex = 8;
            this.btn_ds_kyluat_khenthuong.Text = "Danh sách kỷ luật/khen thưởng";
            this.btn_ds_kyluat_khenthuong.UseVisualStyleBackColor = true;
            this.btn_ds_kyluat_khenthuong.Click += new System.EventHandler(this.btn_ds_kyluat_khenthuong_Click);
            // 
            // btn_ds_nhanvien
            // 
            this.btn_ds_nhanvien.Location = new System.Drawing.Point(253, 90);
            this.btn_ds_nhanvien.Name = "btn_ds_nhanvien";
            this.btn_ds_nhanvien.Size = new System.Drawing.Size(193, 108);
            this.btn_ds_nhanvien.TabIndex = 7;
            this.btn_ds_nhanvien.Text = "Danh sách nhân viên";
            this.btn_ds_nhanvien.UseVisualStyleBackColor = true;
            this.btn_ds_nhanvien.Click += new System.EventHandler(this.btn_ds_nhanvien_Click);
            // 
            // btn_ds_Luong
            // 
            this.btn_ds_Luong.Location = new System.Drawing.Point(253, 238);
            this.btn_ds_Luong.Name = "btn_ds_Luong";
            this.btn_ds_Luong.Size = new System.Drawing.Size(193, 97);
            this.btn_ds_Luong.TabIndex = 12;
            this.btn_ds_Luong.Text = "Danh sách Lương";
            this.btn_ds_Luong.UseVisualStyleBackColor = true;
            this.btn_ds_Luong.Click += new System.EventHandler(this.btn_ds_Luong_Click);
            // 
            // btn_ds_phongban
            // 
            this.btn_ds_phongban.Location = new System.Drawing.Point(476, 90);
            this.btn_ds_phongban.Name = "btn_ds_phongban";
            this.btn_ds_phongban.Size = new System.Drawing.Size(193, 108);
            this.btn_ds_phongban.TabIndex = 13;
            this.btn_ds_phongban.Text = "Danh sách phòng ban";
            this.btn_ds_phongban.UseVisualStyleBackColor = true;
            this.btn_ds_phongban.Click += new System.EventHandler(this.btn_ds_phongban_Click);
            // 
            // btn_ds_nghiPhep
            // 
            this.btn_ds_nghiPhep.Location = new System.Drawing.Point(476, 238);
            this.btn_ds_nghiPhep.Name = "btn_ds_nghiPhep";
            this.btn_ds_nghiPhep.Size = new System.Drawing.Size(193, 97);
            this.btn_ds_nghiPhep.TabIndex = 14;
            this.btn_ds_nghiPhep.Text = "Danh sách nghỉ phép";
            this.btn_ds_nghiPhep.UseVisualStyleBackColor = true;
            this.btn_ds_nghiPhep.Click += new System.EventHandler(this.btn_ds_nghiPhep_Click);
            // 
            // txt_maNV
            // 
            this.txt_maNV.Location = new System.Drawing.Point(213, 16);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(137, 22);
            this.txt_maNV.TabIndex = 15;
            // 
            // txt_tenNV
            // 
            this.txt_tenNV.Location = new System.Drawing.Point(132, 48);
            this.txt_tenNV.Name = "txt_tenNV";
            this.txt_tenNV.Size = new System.Drawing.Size(218, 22);
            this.txt_tenNV.TabIndex = 16;
            // 
            // btn_Log_out
            // 
            this.btn_Log_out.Location = new System.Drawing.Point(560, 367);
            this.btn_Log_out.Name = "btn_Log_out";
            this.btn_Log_out.Size = new System.Drawing.Size(113, 32);
            this.btn_Log_out.TabIndex = 17;
            this.btn_Log_out.Text = "Đăng xuất";
            this.btn_Log_out.UseVisualStyleBackColor = true;
            this.btn_Log_out.Click += new System.EventHandler(this.btn_Log_out_Click);
            // 
            // Home_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 415);
            this.Controls.Add(this.btn_Log_out);
            this.Controls.Add(this.txt_tenNV);
            this.Controls.Add(this.txt_maNV);
            this.Controls.Add(this.btn_ds_nghiPhep);
            this.Controls.Add(this.btn_ds_phongban);
            this.Controls.Add(this.btn_ds_Luong);
            this.Controls.Add(this.lb_tenNV);
            this.Controls.Add(this.lb_maNV);
            this.Controls.Add(this.btn_account);
            this.Controls.Add(this.btn_ds_kyluat_khenthuong);
            this.Controls.Add(this.btn_ds_nhanvien);
            this.Name = "Home_admin";
            this.Text = "Home_admin";
            this.Load += new System.EventHandler(this.Home_admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_tenNV;
        private System.Windows.Forms.Label lb_maNV;
        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Button btn_ds_kyluat_khenthuong;
        private System.Windows.Forms.Button btn_ds_nhanvien;
        private System.Windows.Forms.Button btn_ds_Luong;
        private System.Windows.Forms.Button btn_ds_phongban;
        private System.Windows.Forms.Button btn_ds_nghiPhep;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.TextBox txt_tenNV;
        private System.Windows.Forms.Button btn_Log_out;
    }
}