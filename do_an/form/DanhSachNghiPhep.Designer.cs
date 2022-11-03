
namespace do_an.form
{
    partial class DanhSachNghiPhep
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
            this.lb_year = new System.Windows.Forms.Label();
            this.lb_mouth = new System.Windows.Forms.Label();
            this.dgv_Luong = new System.Windows.Forms.DataGridView();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.cbb_year = new System.Windows.Forms.ComboBox();
            this.cbb_mouth = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.grB_thoiGian = new System.Windows.Forms.GroupBox();
            this.grB_phongBan = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_phongBan = new System.Windows.Forms.Label();
            this.txt_keysearch = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Luong)).BeginInit();
            this.grB_thoiGian.SuspendLayout();
            this.grB_phongBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.Location = new System.Drawing.Point(124, 34);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(37, 17);
            this.lb_year.TabIndex = 32;
            this.lb_year.Text = "Năm";
            // 
            // lb_mouth
            // 
            this.lb_mouth.AutoSize = true;
            this.lb_mouth.Location = new System.Drawing.Point(6, 34);
            this.lb_mouth.Name = "lb_mouth";
            this.lb_mouth.Size = new System.Drawing.Size(49, 17);
            this.lb_mouth.TabIndex = 31;
            this.lb_mouth.Text = "Tháng";
            // 
            // dgv_Luong
            // 
            this.dgv_Luong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Luong.Location = new System.Drawing.Point(29, 199);
            this.dgv_Luong.Name = "dgv_Luong";
            this.dgv_Luong.RowHeadersWidth = 51;
            this.dgv_Luong.RowTemplate.Height = 24;
            this.dgv_Luong.Size = new System.Drawing.Size(662, 239);
            this.dgv_Luong.TabIndex = 30;
            // 
            // btn_Loc
            // 
            this.btn_Loc.Location = new System.Drawing.Point(263, 30);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(75, 24);
            this.btn_Loc.TabIndex = 29;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = true;
            // 
            // cbb_year
            // 
            this.cbb_year.FormattingEnabled = true;
            this.cbb_year.Location = new System.Drawing.Point(167, 31);
            this.cbb_year.Name = "cbb_year";
            this.cbb_year.Size = new System.Drawing.Size(75, 24);
            this.cbb_year.TabIndex = 28;
            // 
            // cbb_mouth
            // 
            this.cbb_mouth.FormattingEnabled = true;
            this.cbb_mouth.Location = new System.Drawing.Point(61, 31);
            this.cbb_mouth.Name = "cbb_mouth";
            this.cbb_mouth.Size = new System.Drawing.Size(57, 24);
            this.cbb_mouth.TabIndex = 27;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(584, 19);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "<<<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(23, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(360, 49);
            this.lb_title.TabIndex = 25;
            this.lb_title.Text = "Danh sách nghỉ phép";
            // 
            // grB_thoiGian
            // 
            this.grB_thoiGian.Controls.Add(this.lb_mouth);
            this.grB_thoiGian.Controls.Add(this.lb_year);
            this.grB_thoiGian.Controls.Add(this.btn_Loc);
            this.grB_thoiGian.Controls.Add(this.cbb_mouth);
            this.grB_thoiGian.Controls.Add(this.cbb_year);
            this.grB_thoiGian.Location = new System.Drawing.Point(347, 112);
            this.grB_thoiGian.Name = "grB_thoiGian";
            this.grB_thoiGian.Size = new System.Drawing.Size(344, 68);
            this.grB_thoiGian.TabIndex = 33;
            this.grB_thoiGian.TabStop = false;
            this.grB_thoiGian.Text = "Lọc theo thời gian";
            // 
            // grB_phongBan
            // 
            this.grB_phongBan.Controls.Add(this.comboBox1);
            this.grB_phongBan.Controls.Add(this.lb_phongBan);
            this.grB_phongBan.Location = new System.Drawing.Point(29, 112);
            this.grB_phongBan.Name = "grB_phongBan";
            this.grB_phongBan.Size = new System.Drawing.Size(283, 68);
            this.grB_phongBan.TabIndex = 34;
            this.grB_phongBan.TabStop = false;
            this.grB_phongBan.Text = "Lọc theo phòng ban";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // lb_phongBan
            // 
            this.lb_phongBan.AutoSize = true;
            this.lb_phongBan.Location = new System.Drawing.Point(16, 33);
            this.lb_phongBan.Name = "lb_phongBan";
            this.lb_phongBan.Size = new System.Drawing.Size(77, 17);
            this.lb_phongBan.TabIndex = 0;
            this.lb_phongBan.Text = "Phòng ban";
            // 
            // txt_keysearch
            // 
            this.txt_keysearch.Location = new System.Drawing.Point(29, 73);
            this.txt_keysearch.Name = "txt_keysearch";
            this.txt_keysearch.Size = new System.Drawing.Size(560, 22);
            this.txt_keysearch.TabIndex = 35;
            this.txt_keysearch.Text = "Nhập từ khóa tìm kiếm";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(596, 68);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(95, 33);
            this.btn_search.TabIndex = 36;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // DanhSachNghiPhep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_keysearch);
            this.Controls.Add(this.grB_phongBan);
            this.Controls.Add(this.grB_thoiGian);
            this.Controls.Add(this.dgv_Luong);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_title);
            this.Name = "DanhSachNghiPhep";
            this.Text = "DanhSachNghiPhep";
            this.Load += new System.EventHandler(this.DanhSachNghiPhep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Luong)).EndInit();
            this.grB_thoiGian.ResumeLayout(false);
            this.grB_thoiGian.PerformLayout();
            this.grB_phongBan.ResumeLayout(false);
            this.grB_phongBan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_year;
        private System.Windows.Forms.Label lb_mouth;
        private System.Windows.Forms.DataGridView dgv_Luong;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.ComboBox cbb_year;
        private System.Windows.Forms.ComboBox cbb_mouth;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.GroupBox grB_thoiGian;
        private System.Windows.Forms.GroupBox grB_phongBan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb_phongBan;
        private System.Windows.Forms.TextBox txt_keysearch;
        private System.Windows.Forms.Button btn_search;
    }
}