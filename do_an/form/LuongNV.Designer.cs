
namespace do_an.form
{
    partial class LuongNV
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
            this.dgv_Luong = new System.Windows.Forms.DataGridView();
            this.lb_year = new System.Windows.Forms.Label();
            this.lb_mouth = new System.Windows.Forms.Label();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.cbb_year = new System.Windows.Forms.ComboBox();
            this.cbb_mouth = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Luong)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(668, 21);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 29;
            this.btn_back.Text = "<<<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(12, 18);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(563, 49);
            this.lb_title.TabIndex = 28;
            this.lb_title.Text = "Lương";
            // 
            // dgv_Luong
            // 
            this.dgv_Luong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Luong.Location = new System.Drawing.Point(32, 153);
            this.dgv_Luong.Name = "dgv_Luong";
            this.dgv_Luong.RowHeadersWidth = 51;
            this.dgv_Luong.RowTemplate.Height = 24;
            this.dgv_Luong.Size = new System.Drawing.Size(698, 267);
            this.dgv_Luong.TabIndex = 30;
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.Location = new System.Drawing.Point(362, 102);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(37, 17);
            this.lb_year.TabIndex = 35;
            this.lb_year.Text = "Năm";
            // 
            // lb_mouth
            // 
            this.lb_mouth.AutoSize = true;
            this.lb_mouth.Location = new System.Drawing.Point(165, 102);
            this.lb_mouth.Name = "lb_mouth";
            this.lb_mouth.Size = new System.Drawing.Size(49, 17);
            this.lb_mouth.TabIndex = 34;
            this.lb_mouth.Text = "Tháng";
            // 
            // btn_Loc
            // 
            this.btn_Loc.Location = new System.Drawing.Point(569, 99);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(75, 24);
            this.btn_Loc.TabIndex = 33;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = true;
            // 
            // cbb_year
            // 
            this.cbb_year.FormattingEnabled = true;
            this.cbb_year.Location = new System.Drawing.Point(405, 99);
            this.cbb_year.Name = "cbb_year";
            this.cbb_year.Size = new System.Drawing.Size(121, 24);
            this.cbb_year.TabIndex = 32;
            // 
            // cbb_mouth
            // 
            this.cbb_mouth.FormattingEnabled = true;
            this.cbb_mouth.Location = new System.Drawing.Point(220, 99);
            this.cbb_mouth.Name = "cbb_mouth";
            this.cbb_mouth.Size = new System.Drawing.Size(121, 24);
            this.cbb_mouth.TabIndex = 31;
            // 
            // LuongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_year);
            this.Controls.Add(this.lb_mouth);
            this.Controls.Add(this.btn_Loc);
            this.Controls.Add(this.cbb_year);
            this.Controls.Add(this.cbb_mouth);
            this.Controls.Add(this.dgv_Luong);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_title);
            this.Name = "LuongNV";
            this.Text = "LuongNV";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Luong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.DataGridView dgv_Luong;
        private System.Windows.Forms.Label lb_year;
        private System.Windows.Forms.Label lb_mouth;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.ComboBox cbb_year;
        private System.Windows.Forms.ComboBox cbb_mouth;
    }
}