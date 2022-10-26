
namespace do_an.form
{
    partial class DanhSachNV
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
            this.dgv_DS_nhanVien = new System.Windows.Forms.DataGridView();
            this.txt_keysearch = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.cbb_loc_theo_phongBan = new System.Windows.Forms.ComboBox();
            this.cbb_loc_theo_chucVu = new System.Windows.Forms.ComboBox();
            this.grB_thongtinNV = new System.Windows.Forms.GroupBox();
            this.dateTime_ngSinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_chucVu = new System.Windows.Forms.ComboBox();
            this.cbb_phongban = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_CMND_CCCD = new System.Windows.Forms.TextBox();
            this.cbb_gioiTinh = new System.Windows.Forms.ComboBox();
            this.txt_hotenNV = new System.Windows.Forms.TextBox();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pictureBox_anhNV = new System.Windows.Forms.PictureBox();
            this.lb_CV = new System.Windows.Forms.Label();
            this.lb_phongBan = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_Sdt = new System.Windows.Forms.Label();
            this.lb_diaChi = new System.Windows.Forms.Label();
            this.lb_CMND = new System.Windows.Forms.Label();
            this.lb_sex = new System.Windows.Forms.Label();
            this.lb_ngSinh = new System.Windows.Forms.Label();
            this.lb_hotenNV = new System.Windows.Forms.Label();
            this.lb_maNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_loadAnh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DS_nhanVien)).BeginInit();
            this.grB_thongtinNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anhNV)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(449, 19);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 20;
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
            this.lb_title.TabIndex = 19;
            this.lb_title.Text = "Danh sách nhân viên";
            // 
            // dgv_DS_nhanVien
            // 
            this.dgv_DS_nhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DS_nhanVien.Location = new System.Drawing.Point(18, 102);
            this.dgv_DS_nhanVien.Name = "dgv_DS_nhanVien";
            this.dgv_DS_nhanVien.RowHeadersWidth = 51;
            this.dgv_DS_nhanVien.RowTemplate.Height = 24;
            this.dgv_DS_nhanVien.Size = new System.Drawing.Size(506, 360);
            this.dgv_DS_nhanVien.TabIndex = 21;
            // 
            // txt_keysearch
            // 
            this.txt_keysearch.Location = new System.Drawing.Point(18, 63);
            this.txt_keysearch.Name = "txt_keysearch";
            this.txt_keysearch.Size = new System.Drawing.Size(181, 22);
            this.txt_keysearch.TabIndex = 22;
            this.txt_keysearch.Text = "Nhập từ khóa tìm kiếm";
            this.txt_keysearch.Click += new System.EventHandler(this.txt_keysearch_Click);
            this.txt_keysearch.Leave += new System.EventHandler(this.txt_keysearch_Leave);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(432, 63);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(92, 24);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cbb_loc_theo_phongBan
            // 
            this.cbb_loc_theo_phongBan.FormattingEnabled = true;
            this.cbb_loc_theo_phongBan.Location = new System.Drawing.Point(205, 63);
            this.cbb_loc_theo_phongBan.Name = "cbb_loc_theo_phongBan";
            this.cbb_loc_theo_phongBan.Size = new System.Drawing.Size(102, 24);
            this.cbb_loc_theo_phongBan.TabIndex = 24;
            // 
            // cbb_loc_theo_chucVu
            // 
            this.cbb_loc_theo_chucVu.FormattingEnabled = true;
            this.cbb_loc_theo_chucVu.Location = new System.Drawing.Point(313, 63);
            this.cbb_loc_theo_chucVu.Name = "cbb_loc_theo_chucVu";
            this.cbb_loc_theo_chucVu.Size = new System.Drawing.Size(102, 24);
            this.cbb_loc_theo_chucVu.TabIndex = 25;
            // 
            // grB_thongtinNV
            // 
            this.grB_thongtinNV.Controls.Add(this.btn_loadAnh);
            this.grB_thongtinNV.Controls.Add(this.btn_delete);
            this.grB_thongtinNV.Controls.Add(this.dateTime_ngSinh);
            this.grB_thongtinNV.Controls.Add(this.cbb_chucVu);
            this.grB_thongtinNV.Controls.Add(this.cbb_phongban);
            this.grB_thongtinNV.Controls.Add(this.txt_email);
            this.grB_thongtinNV.Controls.Add(this.txt_phone);
            this.grB_thongtinNV.Controls.Add(this.txt_diaChi);
            this.grB_thongtinNV.Controls.Add(this.txt_CMND_CCCD);
            this.grB_thongtinNV.Controls.Add(this.cbb_gioiTinh);
            this.grB_thongtinNV.Controls.Add(this.txt_hotenNV);
            this.grB_thongtinNV.Controls.Add(this.txt_maNV);
            this.grB_thongtinNV.Controls.Add(this.btn_change);
            this.grB_thongtinNV.Controls.Add(this.btn_huy);
            this.grB_thongtinNV.Controls.Add(this.btn_save);
            this.grB_thongtinNV.Controls.Add(this.pictureBox_anhNV);
            this.grB_thongtinNV.Controls.Add(this.lb_CV);
            this.grB_thongtinNV.Controls.Add(this.lb_phongBan);
            this.grB_thongtinNV.Controls.Add(this.lb_email);
            this.grB_thongtinNV.Controls.Add(this.lb_Sdt);
            this.grB_thongtinNV.Controls.Add(this.lb_diaChi);
            this.grB_thongtinNV.Controls.Add(this.lb_CMND);
            this.grB_thongtinNV.Controls.Add(this.lb_sex);
            this.grB_thongtinNV.Controls.Add(this.lb_ngSinh);
            this.grB_thongtinNV.Controls.Add(this.lb_hotenNV);
            this.grB_thongtinNV.Controls.Add(this.lb_maNV);
            this.grB_thongtinNV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grB_thongtinNV.Location = new System.Drawing.Point(555, 9);
            this.grB_thongtinNV.Name = "grB_thongtinNV";
            this.grB_thongtinNV.Size = new System.Drawing.Size(500, 409);
            this.grB_thongtinNV.TabIndex = 26;
            this.grB_thongtinNV.TabStop = false;
            // 
            // dateTime_ngSinh
            // 
            this.dateTime_ngSinh.Location = new System.Drawing.Point(251, 88);
            this.dateTime_ngSinh.Name = "dateTime_ngSinh";
            this.dateTime_ngSinh.Size = new System.Drawing.Size(224, 22);
            this.dateTime_ngSinh.TabIndex = 51;
            // 
            // cbb_chucVu
            // 
            this.cbb_chucVu.FormattingEnabled = true;
            this.cbb_chucVu.Location = new System.Drawing.Point(365, 315);
            this.cbb_chucVu.Name = "cbb_chucVu";
            this.cbb_chucVu.Size = new System.Drawing.Size(110, 24);
            this.cbb_chucVu.TabIndex = 50;
            // 
            // cbb_phongban
            // 
            this.cbb_phongban.FormattingEnabled = true;
            this.cbb_phongban.Location = new System.Drawing.Point(136, 314);
            this.cbb_phongban.Name = "cbb_phongban";
            this.cbb_phongban.Size = new System.Drawing.Size(120, 24);
            this.cbb_phongban.TabIndex = 49;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(102, 282);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(373, 22);
            this.txt_email.TabIndex = 48;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(102, 245);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(260, 22);
            this.txt_phone.TabIndex = 47;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(102, 209);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(373, 22);
            this.txt_diaChi.TabIndex = 46;
            // 
            // txt_CMND_CCCD
            // 
            this.txt_CMND_CCCD.Location = new System.Drawing.Point(252, 164);
            this.txt_CMND_CCCD.Name = "txt_CMND_CCCD";
            this.txt_CMND_CCCD.Size = new System.Drawing.Size(223, 22);
            this.txt_CMND_CCCD.TabIndex = 45;
            // 
            // cbb_gioiTinh
            // 
            this.cbb_gioiTinh.FormattingEnabled = true;
            this.cbb_gioiTinh.Location = new System.Drawing.Point(252, 126);
            this.cbb_gioiTinh.Name = "cbb_gioiTinh";
            this.cbb_gioiTinh.Size = new System.Drawing.Size(121, 24);
            this.cbb_gioiTinh.TabIndex = 44;
            // 
            // txt_hotenNV
            // 
            this.txt_hotenNV.Location = new System.Drawing.Point(251, 51);
            this.txt_hotenNV.Name = "txt_hotenNV";
            this.txt_hotenNV.Size = new System.Drawing.Size(224, 22);
            this.txt_hotenNV.TabIndex = 43;
            // 
            // txt_maNV
            // 
            this.txt_maNV.Location = new System.Drawing.Point(251, 18);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(179, 22);
            this.txt_maNV.TabIndex = 42;
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(86, 360);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(155, 29);
            this.btn_change.TabIndex = 39;
            this.btn_change.Text = "Chỉnh sửa thông tin";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(291, 360);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(155, 29);
            this.btn_huy.TabIndex = 41;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(86, 360);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(155, 29);
            this.btn_save.TabIndex = 40;
            this.btn_save.Text = "Lưu thay đổi";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pictureBox_anhNV
            // 
            this.pictureBox_anhNV.Location = new System.Drawing.Point(8, 18);
            this.pictureBox_anhNV.Name = "pictureBox_anhNV";
            this.pictureBox_anhNV.Size = new System.Drawing.Size(134, 166);
            this.pictureBox_anhNV.TabIndex = 38;
            this.pictureBox_anhNV.TabStop = false;
            // 
            // lb_CV
            // 
            this.lb_CV.AutoSize = true;
            this.lb_CV.Location = new System.Drawing.Point(271, 318);
            this.lb_CV.Name = "lb_CV";
            this.lb_CV.Size = new System.Drawing.Size(80, 17);
            this.lb_CV.TabIndex = 37;
            this.lb_CV.Text = "Mã chức vụ";
            // 
            // lb_phongBan
            // 
            this.lb_phongBan.AutoSize = true;
            this.lb_phongBan.Location = new System.Drawing.Point(5, 318);
            this.lb_phongBan.Name = "lb_phongBan";
            this.lb_phongBan.Size = new System.Drawing.Size(124, 17);
            this.lb_phongBan.TabIndex = 36;
            this.lb_phongBan.Text = "Thuộc phòng ban:";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(5, 285);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(42, 17);
            this.lb_email.TabIndex = 35;
            this.lb_email.Text = "Email";
            // 
            // lb_Sdt
            // 
            this.lb_Sdt.AutoSize = true;
            this.lb_Sdt.Location = new System.Drawing.Point(5, 245);
            this.lb_Sdt.Name = "lb_Sdt";
            this.lb_Sdt.Size = new System.Drawing.Size(91, 17);
            this.lb_Sdt.TabIndex = 34;
            this.lb_Sdt.Text = "Số điện thoại";
            // 
            // lb_diaChi
            // 
            this.lb_diaChi.AutoSize = true;
            this.lb_diaChi.Location = new System.Drawing.Point(5, 209);
            this.lb_diaChi.Name = "lb_diaChi";
            this.lb_diaChi.Size = new System.Drawing.Size(51, 17);
            this.lb_diaChi.TabIndex = 33;
            this.lb_diaChi.Text = "Địa chỉ";
            // 
            // lb_CMND
            // 
            this.lb_CMND.AutoSize = true;
            this.lb_CMND.Location = new System.Drawing.Point(148, 167);
            this.lb_CMND.Name = "lb_CMND";
            this.lb_CMND.Size = new System.Drawing.Size(93, 17);
            this.lb_CMND.TabIndex = 32;
            this.lb_CMND.Text = "CMND_CCCD";
            // 
            // lb_sex
            // 
            this.lb_sex.AutoSize = true;
            this.lb_sex.Location = new System.Drawing.Point(148, 129);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(60, 17);
            this.lb_sex.TabIndex = 31;
            this.lb_sex.Text = "Giới tính";
            // 
            // lb_ngSinh
            // 
            this.lb_ngSinh.AutoSize = true;
            this.lb_ngSinh.Location = new System.Drawing.Point(148, 93);
            this.lb_ngSinh.Name = "lb_ngSinh";
            this.lb_ngSinh.Size = new System.Drawing.Size(75, 17);
            this.lb_ngSinh.TabIndex = 30;
            this.lb_ngSinh.Text = "Ngày sinh:";
            // 
            // lb_hotenNV
            // 
            this.lb_hotenNV.AutoSize = true;
            this.lb_hotenNV.Location = new System.Drawing.Point(148, 54);
            this.lb_hotenNV.Name = "lb_hotenNV";
            this.lb_hotenNV.Size = new System.Drawing.Size(54, 17);
            this.lb_hotenNV.TabIndex = 29;
            this.lb_hotenNV.Text = "Họ tên:";
            // 
            // lb_maNV
            // 
            this.lb_maNV.AutoSize = true;
            this.lb_maNV.Location = new System.Drawing.Point(148, 18);
            this.lb_maNV.Name = "lb_maNV";
            this.lb_maNV.Size = new System.Drawing.Size(97, 17);
            this.lb_maNV.TabIndex = 28;
            this.lb_maNV.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(738, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Chọn nhân viên";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(291, 360);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(155, 29);
            this.btn_delete.TabIndex = 52;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(641, 434);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(360, 28);
            this.btn_Add.TabIndex = 28;
            this.btn_Add.Text = "Thêm nhân viên";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_loadAnh
            // 
            this.btn_loadAnh.Location = new System.Drawing.Point(67, 167);
            this.btn_loadAnh.Name = "btn_loadAnh";
            this.btn_loadAnh.Size = new System.Drawing.Size(75, 23);
            this.btn_loadAnh.TabIndex = 53;
            this.btn_loadAnh.Text = "Tải ảnh";
            this.btn_loadAnh.UseVisualStyleBackColor = true;
            // 
            // DanhSachNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 472);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.grB_thongtinNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_loc_theo_chucVu);
            this.Controls.Add(this.cbb_loc_theo_phongBan);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_keysearch);
            this.Controls.Add(this.dgv_DS_nhanVien);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_title);
            this.Name = "DanhSachNV";
            this.Text = "DanhSachNV";
            this.Load += new System.EventHandler(this.DanhSachNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DS_nhanVien)).EndInit();
            this.grB_thongtinNV.ResumeLayout(false);
            this.grB_thongtinNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anhNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.DataGridView dgv_DS_nhanVien;
        private System.Windows.Forms.TextBox txt_keysearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbb_loc_theo_phongBan;
        private System.Windows.Forms.ComboBox cbb_loc_theo_chucVu;
        private System.Windows.Forms.GroupBox grB_thongtinNV;
        private System.Windows.Forms.DateTimePicker dateTime_ngSinh;
        private System.Windows.Forms.ComboBox cbb_chucVu;
        private System.Windows.Forms.ComboBox cbb_phongban;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_CMND_CCCD;
        private System.Windows.Forms.ComboBox cbb_gioiTinh;
        private System.Windows.Forms.TextBox txt_hotenNV;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox pictureBox_anhNV;
        private System.Windows.Forms.Label lb_CV;
        private System.Windows.Forms.Label lb_phongBan;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_Sdt;
        private System.Windows.Forms.Label lb_diaChi;
        private System.Windows.Forms.Label lb_CMND;
        private System.Windows.Forms.Label lb_sex;
        private System.Windows.Forms.Label lb_ngSinh;
        private System.Windows.Forms.Label lb_hotenNV;
        private System.Windows.Forms.Label lb_maNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_loadAnh;
    }
}