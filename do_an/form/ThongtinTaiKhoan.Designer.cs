
namespace do_an.form
{
    partial class ThongtinTaiKhoan
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
            this.btn_back = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.pictureBox_anhNV = new System.Windows.Forms.PictureBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_ngaycap = new System.Windows.Forms.Label();
            this.btn_doiMK = new System.Windows.Forms.Button();
            this.lb_quenMK = new System.Windows.Forms.Label();
            this.lb_loadmaNV = new System.Windows.Forms.Label();
            this.dateTime_ngayCap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anhNV)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(501, 9);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "<<<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(12, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(461, 49);
            this.lb_title.TabIndex = 17;
            this.lb_title.Text = "Thông tin tài khoản đăng nhập";
            // 
            // pictureBox_anhNV
            // 
            this.pictureBox_anhNV.Location = new System.Drawing.Point(33, 61);
            this.pictureBox_anhNV.Name = "pictureBox_anhNV";
            this.pictureBox_anhNV.Size = new System.Drawing.Size(127, 147);
            this.pictureBox_anhNV.TabIndex = 19;
            this.pictureBox_anhNV.TabStop = false;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(194, 62);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(77, 17);
            this.lb_username.TabIndex = 20;
            this.lb_username.Text = "Username:";
            // 
            // lb_ngaycap
            // 
            this.lb_ngaycap.AutoSize = true;
            this.lb_ngaycap.Location = new System.Drawing.Point(197, 106);
            this.lb_ngaycap.Name = "lb_ngaycap";
            this.lb_ngaycap.Size = new System.Drawing.Size(130, 17);
            this.lb_ngaycap.TabIndex = 21;
            this.lb_ngaycap.Text = "Ngày cấp tài khoản";
            // 
            // btn_doiMK
            // 
            this.btn_doiMK.Location = new System.Drawing.Point(345, 173);
            this.btn_doiMK.Name = "btn_doiMK";
            this.btn_doiMK.Size = new System.Drawing.Size(231, 35);
            this.btn_doiMK.TabIndex = 22;
            this.btn_doiMK.Text = "Đổi mật khẩu đăng nhập";
            this.btn_doiMK.UseVisualStyleBackColor = true;
            this.btn_doiMK.Click += new System.EventHandler(this.btn_doiMK_Click);
            // 
            // lb_quenMK
            // 
            this.lb_quenMK.AutoSize = true;
            this.lb_quenMK.Location = new System.Drawing.Point(463, 224);
            this.lb_quenMK.Name = "lb_quenMK";
            this.lb_quenMK.Size = new System.Drawing.Size(113, 17);
            this.lb_quenMK.TabIndex = 23;
            this.lb_quenMK.Text = "Quên mật khẩu?";
            this.lb_quenMK.Click += new System.EventHandler(this.lb_quenMK_Click);
            // 
            // lb_loadmaNV
            // 
            this.lb_loadmaNV.AutoSize = true;
            this.lb_loadmaNV.Location = new System.Drawing.Point(291, 61);
            this.lb_loadmaNV.Name = "lb_loadmaNV";
            this.lb_loadmaNV.Size = new System.Drawing.Size(182, 17);
            this.lb_loadmaNV.TabIndex = 24;
            this.lb_loadmaNV.Text = "mã nhân viên được load lên";
            // 
            // dateTime_ngayCap
            // 
            this.dateTime_ngayCap.Location = new System.Drawing.Point(345, 106);
            this.dateTime_ngayCap.Name = "dateTime_ngayCap";
            this.dateTime_ngayCap.Size = new System.Drawing.Size(231, 22);
            this.dateTime_ngayCap.TabIndex = 25;
            // 
            // ThongtinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 283);
            this.Controls.Add(this.dateTime_ngayCap);
            this.Controls.Add(this.lb_loadmaNV);
            this.Controls.Add(this.lb_quenMK);
            this.Controls.Add(this.btn_doiMK);
            this.Controls.Add(this.lb_ngaycap);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.pictureBox_anhNV);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_title);
            this.Name = "ThongtinTaiKhoan";
            this.Text = "ThongtinTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anhNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.PictureBox pictureBox_anhNV;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_ngaycap;
        private System.Windows.Forms.Button btn_doiMK;
        private System.Windows.Forms.Label lb_quenMK;
        private System.Windows.Forms.Label lb_loadmaNV;
        private System.Windows.Forms.DateTimePicker dateTime_ngayCap;
    }
}