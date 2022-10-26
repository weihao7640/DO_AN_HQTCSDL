
namespace do_an.form
{
    partial class PhongBan
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
            this.dgv_DS_PhongBan = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DS_PhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(398, 96);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(96, 23);
            this.btn_search.TabIndex = 32;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // txt_keysearch
            // 
            this.txt_keysearch.Location = new System.Drawing.Point(18, 95);
            this.txt_keysearch.Name = "txt_keysearch";
            this.txt_keysearch.Size = new System.Drawing.Size(358, 22);
            this.txt_keysearch.TabIndex = 31;
            this.txt_keysearch.Text = "Nhập từ khóa tìm kiếm";
            // 
            // dgv_DS_PhongBan
            // 
            this.dgv_DS_PhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DS_PhongBan.Location = new System.Drawing.Point(18, 143);
            this.dgv_DS_PhongBan.Name = "dgv_DS_PhongBan";
            this.dgv_DS_PhongBan.RowHeadersWidth = 51;
            this.dgv_DS_PhongBan.RowTemplate.Height = 24;
            this.dgv_DS_PhongBan.Size = new System.Drawing.Size(734, 250);
            this.dgv_DS_PhongBan.TabIndex = 28;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(668, 29);
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
            this.lb_title.Location = new System.Drawing.Point(12, 26);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(563, 49);
            this.lb_title.TabIndex = 26;
            this.lb_title.Text = "Danh sách nhân viên tại Phòng ban";
            // 
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_keysearch);
            this.Controls.Add(this.dgv_DS_PhongBan);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_title);
            this.Name = "PhongBan";
            this.Text = "PhongBan";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DS_PhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_keysearch;
        private System.Windows.Forms.DataGridView dgv_DS_PhongBan;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_title;
    }
}