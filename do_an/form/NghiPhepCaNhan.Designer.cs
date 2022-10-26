
namespace do_an.form
{
    partial class NghiPhepCaNhan
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
            this.cbb_mouth = new System.Windows.Forms.ComboBox();
            this.cbb_year = new System.Windows.Forms.ComboBox();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.dgv_Luong = new System.Windows.Forms.DataGridView();
            this.lb_mouth = new System.Windows.Forms.Label();
            this.lb_year = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Luong)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(582, 29);
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
            this.lb_title.Location = new System.Drawing.Point(21, 19);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(360, 49);
            this.lb_title.TabIndex = 17;
            this.lb_title.Text = "Nghỉ phép";
            this.lb_title.Click += new System.EventHandler(this.lb_title_Click);
            // 
            // cbb_mouth
            // 
            this.cbb_mouth.FormattingEnabled = true;
            this.cbb_mouth.Location = new System.Drawing.Point(151, 95);
            this.cbb_mouth.Name = "cbb_mouth";
            this.cbb_mouth.Size = new System.Drawing.Size(121, 24);
            this.cbb_mouth.TabIndex = 19;
            this.cbb_mouth.SelectedIndexChanged += new System.EventHandler(this.cbb_mouth_SelectedIndexChanged);
            // 
            // cbb_year
            // 
            this.cbb_year.FormattingEnabled = true;
            this.cbb_year.Location = new System.Drawing.Point(336, 95);
            this.cbb_year.Name = "cbb_year";
            this.cbb_year.Size = new System.Drawing.Size(121, 24);
            this.cbb_year.TabIndex = 20;
            this.cbb_year.SelectedIndexChanged += new System.EventHandler(this.cbb_year_SelectedIndexChanged);
            // 
            // btn_Loc
            // 
            this.btn_Loc.Location = new System.Drawing.Point(500, 95);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(75, 24);
            this.btn_Loc.TabIndex = 21;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = true;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // dgv_Luong
            // 
            this.dgv_Luong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Luong.Location = new System.Drawing.Point(27, 140);
            this.dgv_Luong.Name = "dgv_Luong";
            this.dgv_Luong.RowHeadersWidth = 51;
            this.dgv_Luong.RowTemplate.Height = 24;
            this.dgv_Luong.Size = new System.Drawing.Size(662, 278);
            this.dgv_Luong.TabIndex = 22;
            this.dgv_Luong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Luong_CellContentClick);
            // 
            // lb_mouth
            // 
            this.lb_mouth.AutoSize = true;
            this.lb_mouth.Location = new System.Drawing.Point(96, 98);
            this.lb_mouth.Name = "lb_mouth";
            this.lb_mouth.Size = new System.Drawing.Size(49, 17);
            this.lb_mouth.TabIndex = 23;
            this.lb_mouth.Text = "Tháng";
            this.lb_mouth.Click += new System.EventHandler(this.lb_mouth_Click);
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.Location = new System.Drawing.Point(293, 98);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(37, 17);
            this.lb_year.TabIndex = 24;
            this.lb_year.Text = "Năm";
            this.lb_year.Click += new System.EventHandler(this.lb_year_Click);
            // 
            // NghiPhepCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.lb_year);
            this.Controls.Add(this.lb_mouth);
            this.Controls.Add(this.dgv_Luong);
            this.Controls.Add(this.btn_Loc);
            this.Controls.Add(this.cbb_year);
            this.Controls.Add(this.cbb_mouth);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_title);
            this.Name = "NghiPhepCaNhan";
            this.Text = "NghiPhepCaNhan";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Luong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.ComboBox cbb_mouth;
        private System.Windows.Forms.ComboBox cbb_year;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.DataGridView dgv_Luong;
        private System.Windows.Forms.Label lb_mouth;
        private System.Windows.Forms.Label lb_year;
    }
}