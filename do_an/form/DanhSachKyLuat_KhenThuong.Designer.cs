
namespace do_an.form
{
    partial class DanhSachKyLuat_KhenThuong
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
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_keysearch = new System.Windows.Forms.TextBox();
            this.cbb_Loc = new System.Windows.Forms.ComboBox();
            this.btn_loc = new System.Windows.Forms.Button();
            this.dgv_DS_KL_KT = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DS_KL_KT)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(398, 95);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(96, 23);
            this.btn_search.TabIndex = 32;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // txt_keysearch
            // 
            this.txt_keysearch.Location = new System.Drawing.Point(18, 94);
            this.txt_keysearch.Name = "txt_keysearch";
            this.txt_keysearch.Size = new System.Drawing.Size(358, 22);
            this.txt_keysearch.TabIndex = 31;
            this.txt_keysearch.Text = "Nhập từ khóa tìm kiếm";
            // 
            // cbb_Loc
            // 
            this.cbb_Loc.FormattingEnabled = true;
            this.cbb_Loc.Location = new System.Drawing.Point(522, 94);
            this.cbb_Loc.Name = "cbb_Loc";
            this.cbb_Loc.Size = new System.Drawing.Size(139, 24);
            this.cbb_Loc.TabIndex = 30;
            // 
            // btn_loc
            // 
            this.btn_loc.Location = new System.Drawing.Point(677, 94);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(75, 23);
            this.btn_loc.TabIndex = 29;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = true;
            // 
            // dgv_DS_KL_KT
            // 
            this.dgv_DS_KL_KT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DS_KL_KT.Location = new System.Drawing.Point(18, 142);
            this.dgv_DS_KL_KT.Name = "dgv_DS_KL_KT";
            this.dgv_DS_KL_KT.RowHeadersWidth = 51;
            this.dgv_DS_KL_KT.RowTemplate.Height = 24;
            this.dgv_DS_KL_KT.Size = new System.Drawing.Size(734, 250);
            this.dgv_DS_KL_KT.TabIndex = 28;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(668, 28);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 27;
            this.btn_back.Text = "<<<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(12, 25);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(461, 49);
            this.lb_title.TabIndex = 26;
            this.lb_title.Text = "Danh sách Kỷ luật/ Khen thưởng";
            // 
            // DanhSachKyLuat_KhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_keysearch);
            this.Controls.Add(this.cbb_Loc);
            this.Controls.Add(this.btn_loc);
            this.Controls.Add(this.dgv_DS_KL_KT);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_title);
            this.Name = "DanhSachKyLuat_KhenThuong";
            this.Text = "DanhSachKyLuat_KhenThuong";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DS_KL_KT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_keysearch;
        private System.Windows.Forms.ComboBox cbb_Loc;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.DataGridView dgv_DS_KL_KT;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_title;
    }
}