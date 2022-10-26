
namespace do_an.form
{
    partial class DoiMatKhau
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
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_old_pw = new System.Windows.Forms.Label();
            this.lb_new_pw_1 = new System.Windows.Forms.Label();
            this.lb_new_pw_2 = new System.Windows.Forms.Label();
            this.txt_old_pw = new System.Windows.Forms.TextBox();
            this.txt_new_pw_1 = new System.Windows.Forms.TextBox();
            this.txt_new_pw_2 = new System.Windows.Forms.TextBox();
            this.btn_doiMK = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(12, 18);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(152, 29);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Đổi mật khẩu";
            // 
            // lb_old_pw
            // 
            this.lb_old_pw.AutoSize = true;
            this.lb_old_pw.Location = new System.Drawing.Point(39, 85);
            this.lb_old_pw.Name = "lb_old_pw";
            this.lb_old_pw.Size = new System.Drawing.Size(154, 17);
            this.lb_old_pw.TabIndex = 1;
            this.lb_old_pw.Text = "Nhập mật khẩu hiện tại";
            // 
            // lb_new_pw_1
            // 
            this.lb_new_pw_1.AutoSize = true;
            this.lb_new_pw_1.Location = new System.Drawing.Point(39, 123);
            this.lb_new_pw_1.Name = "lb_new_pw_1";
            this.lb_new_pw_1.Size = new System.Drawing.Size(130, 17);
            this.lb_new_pw_1.TabIndex = 2;
            this.lb_new_pw_1.Text = "Nhập mật khẩu mới";
            // 
            // lb_new_pw_2
            // 
            this.lb_new_pw_2.AutoSize = true;
            this.lb_new_pw_2.Location = new System.Drawing.Point(39, 160);
            this.lb_new_pw_2.Name = "lb_new_pw_2";
            this.lb_new_pw_2.Size = new System.Drawing.Size(148, 17);
            this.lb_new_pw_2.TabIndex = 3;
            this.lb_new_pw_2.Text = "Nhập lại mật khẩu mới";
            // 
            // txt_old_pw
            // 
            this.txt_old_pw.Location = new System.Drawing.Point(199, 82);
            this.txt_old_pw.Name = "txt_old_pw";
            this.txt_old_pw.Size = new System.Drawing.Size(208, 22);
            this.txt_old_pw.TabIndex = 4;
            // 
            // txt_new_pw_1
            // 
            this.txt_new_pw_1.Location = new System.Drawing.Point(199, 120);
            this.txt_new_pw_1.Name = "txt_new_pw_1";
            this.txt_new_pw_1.Size = new System.Drawing.Size(208, 22);
            this.txt_new_pw_1.TabIndex = 5;
            // 
            // txt_new_pw_2
            // 
            this.txt_new_pw_2.Location = new System.Drawing.Point(199, 157);
            this.txt_new_pw_2.Name = "txt_new_pw_2";
            this.txt_new_pw_2.Size = new System.Drawing.Size(208, 22);
            this.txt_new_pw_2.TabIndex = 6;
            // 
            // btn_doiMK
            // 
            this.btn_doiMK.Location = new System.Drawing.Point(62, 197);
            this.btn_doiMK.Name = "btn_doiMK";
            this.btn_doiMK.Size = new System.Drawing.Size(131, 38);
            this.btn_doiMK.TabIndex = 7;
            this.btn_doiMK.Text = "Đổi mật khẩu";
            this.btn_doiMK.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(243, 197);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(131, 38);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Hủy";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 271);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_doiMK);
            this.Controls.Add(this.txt_new_pw_2);
            this.Controls.Add(this.txt_new_pw_1);
            this.Controls.Add(this.txt_old_pw);
            this.Controls.Add(this.lb_new_pw_2);
            this.Controls.Add(this.lb_new_pw_1);
            this.Controls.Add(this.lb_old_pw);
            this.Controls.Add(this.lb_title);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_old_pw;
        private System.Windows.Forms.Label lb_new_pw_1;
        private System.Windows.Forms.Label lb_new_pw_2;
        private System.Windows.Forms.TextBox txt_old_pw;
        private System.Windows.Forms.TextBox txt_new_pw_1;
        private System.Windows.Forms.TextBox txt_new_pw_2;
        private System.Windows.Forms.Button btn_doiMK;
        private System.Windows.Forms.Button btn_exit;
    }
}