﻿namespace GUI_QuanLy
{
    partial class GUI_SinhVien
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnALL = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.dgvDK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnHuyDangKy = new System.Windows.Forms.Button();
            this.dgvXemDK = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHocKy2 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvTKB = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHocKy3 = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbGPA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHocKy4 = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDK)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDK)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1030, 632);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnALL);
            this.tabPage1.Controls.Add(this.btnDangKy);
            this.tabPage1.Controls.Add(this.dgvDK);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbHocKy);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1022, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ĐKMH";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnALL
            // 
            this.btnALL.Location = new System.Drawing.Point(351, 18);
            this.btnALL.Name = "btnALL";
            this.btnALL.Size = new System.Drawing.Size(96, 36);
            this.btnALL.TabIndex = 18;
            this.btnALL.Text = "All";
            this.btnALL.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(487, 566);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(100, 31);
            this.btnDangKy.TabIndex = 3;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // dgvDK
            // 
            this.dgvDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDK.Location = new System.Drawing.Point(24, 69);
            this.dgvDK.Name = "dgvDK";
            this.dgvDK.RowHeadersWidth = 51;
            this.dgvDK.Size = new System.Drawing.Size(1013, 481);
            this.dgvDK.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn học kỳ để lọc môn:";
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(207, 23);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(121, 24);
            this.cbHocKy.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnHuyDangKy);
            this.tabPage2.Controls.Add(this.dgvXemDK);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cbHocKy2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xem môn đã đăng ký";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnHuyDangKy
            // 
            this.btnHuyDangKy.Location = new System.Drawing.Point(450, 574);
            this.btnHuyDangKy.Name = "btnHuyDangKy";
            this.btnHuyDangKy.Size = new System.Drawing.Size(120, 31);
            this.btnHuyDangKy.TabIndex = 7;
            this.btnHuyDangKy.Text = "Hủy Đăng Ký";
            this.btnHuyDangKy.UseVisualStyleBackColor = true;
            // 
            // dgvXemDK
            // 
            this.dgvXemDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXemDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemDK.Location = new System.Drawing.Point(18, 68);
            this.dgvXemDK.Name = "dgvXemDK";
            this.dgvXemDK.RowHeadersWidth = 51;
            this.dgvXemDK.Size = new System.Drawing.Size(1031, 500);
            this.dgvXemDK.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn học kỳ:";
            // 
            // cbHocKy2
            // 
            this.cbHocKy2.FormattingEnabled = true;
            this.cbHocKy2.Location = new System.Drawing.Point(120, 22);
            this.cbHocKy2.Name = "cbHocKy2";
            this.cbHocKy2.Size = new System.Drawing.Size(121, 24);
            this.cbHocKy2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvTKB);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cbHocKy3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(896, 482);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xem thời khóa biểu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvTKB
            // 
            this.dgvTKB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKB.Location = new System.Drawing.Point(18, 68);
            this.dgvTKB.Name = "dgvTKB";
            this.dgvTKB.RowHeadersWidth = 51;
            this.dgvTKB.Size = new System.Drawing.Size(1026, 535);
            this.dgvTKB.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chọn học kỳ:";
            // 
            // cbHocKy3
            // 
            this.cbHocKy3.FormattingEnabled = true;
            this.cbHocKy3.Location = new System.Drawing.Point(131, 22);
            this.cbHocKy3.Name = "cbHocKy3";
            this.cbHocKy3.Size = new System.Drawing.Size(121, 24);
            this.cbHocKy3.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbGPA);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.dgvDiem);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.cbHocKy4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(896, 482);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Xem điểm";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbGPA
            // 
            this.lbGPA.AutoSize = true;
            this.lbGPA.Location = new System.Drawing.Point(78, 590);
            this.lbGPA.Name = "lbGPA";
            this.lbGPA.Size = new System.Drawing.Size(14, 16);
            this.lbGPA.TabIndex = 16;
            this.lbGPA.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 590);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "GPA:";
            // 
            // dgvDiem
            // 
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Location = new System.Drawing.Point(18, 70);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.Size = new System.Drawing.Size(1033, 505);
            this.dgvDiem.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Chọn học kỳ:";
            // 
            // cbHocKy4
            // 
            this.cbHocKy4.FormattingEnabled = true;
            this.cbHocKy4.Location = new System.Drawing.Point(131, 24);
            this.cbHocKy4.Name = "cbHocKy4";
            this.cbHocKy4.Size = new System.Drawing.Size(121, 24);
            this.cbHocKy4.TabIndex = 12;
            // 
            // GUI_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 632);
            this.Controls.Add(this.tabControl);
            this.Name = "GUI_SinhVien";
            this.Text = "GUI_SinhVien";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDK)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDK)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnALL;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.DataGridView dgvDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnHuyDangKy;
        private System.Windows.Forms.DataGridView dgvXemDK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHocKy2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvTKB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHocKy3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lbGPA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHocKy4;
    }
}