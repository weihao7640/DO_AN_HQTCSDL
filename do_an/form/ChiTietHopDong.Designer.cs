
namespace do_an.form
{
    partial class ChiTietHopDong
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ngayKyHopDong = new System.Windows.Forms.Label();
            this.date_ngayKyHopDong = new System.Windows.Forms.DateTimePicker();
            this.lb_ngayHetHanHopDong = new System.Windows.Forms.Label();
            this.date_HanHopDong = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(672, 19);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 22;
            this.btn_back.Text = "<<<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(12, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(360, 49);
            this.lb_title.TabIndex = 21;
            this.lb_title.Text = "Chi tiết hợp đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Viết gì cũng được";
            // 
            // lb_ngayKyHopDong
            // 
            this.lb_ngayKyHopDong.AutoSize = true;
            this.lb_ngayKyHopDong.Location = new System.Drawing.Point(67, 228);
            this.lb_ngayKyHopDong.Name = "lb_ngayKyHopDong";
            this.lb_ngayKyHopDong.Size = new System.Drawing.Size(123, 17);
            this.lb_ngayKyHopDong.TabIndex = 24;
            this.lb_ngayKyHopDong.Text = "Ngày ký hợp đồng";
            // 
            // date_ngayKyHopDong
            // 
            this.date_ngayKyHopDong.Location = new System.Drawing.Point(212, 228);
            this.date_ngayKyHopDong.Name = "date_ngayKyHopDong";
            this.date_ngayKyHopDong.Size = new System.Drawing.Size(200, 22);
            this.date_ngayKyHopDong.TabIndex = 25;
            // 
            // lb_ngayHetHanHopDong
            // 
            this.lb_ngayHetHanHopDong.AutoSize = true;
            this.lb_ngayHetHanHopDong.Location = new System.Drawing.Point(70, 272);
            this.lb_ngayHetHanHopDong.Name = "lb_ngayHetHanHopDong";
            this.lb_ngayHetHanHopDong.Size = new System.Drawing.Size(98, 17);
            this.lb_ngayHetHanHopDong.TabIndex = 26;
            this.lb_ngayHetHanHopDong.Text = "Hạn hợp đồng";
            // 
            // date_HanHopDong
            // 
            this.date_HanHopDong.Location = new System.Drawing.Point(212, 266);
            this.date_HanHopDong.Name = "date_HanHopDong";
            this.date_HanHopDong.Size = new System.Drawing.Size(200, 22);
            this.date_HanHopDong.TabIndex = 27;
            // 
            // ChiTietHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.date_HanHopDong);
            this.Controls.Add(this.lb_ngayHetHanHopDong);
            this.Controls.Add(this.date_ngayKyHopDong);
            this.Controls.Add(this.lb_ngayKyHopDong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_title);
            this.Name = "ChiTietHopDong";
            this.Text = "ChiTietHopDong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_ngayKyHopDong;
        private System.Windows.Forms.DateTimePicker date_ngayKyHopDong;
        private System.Windows.Forms.Label lb_ngayHetHanHopDong;
        private System.Windows.Forms.DateTimePicker date_HanHopDong;
    }
}