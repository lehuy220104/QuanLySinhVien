namespace GUI_QuanLy
{
    partial class GUI_GiangVien
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
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lbTenSV = new System.Windows.Forms.Label();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.cbLopHP = new System.Windows.Forms.ComboBox();
            this.maGV = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHocKyTK = new System.Windows.Forms.ComboBox();
            this.cbThongKe = new System.Windows.Forms.ComboBox();
            this.tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(800, 450);
            this.tabcontrol.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Controls.Add(this.btnSua);
            this.tabPage1.Controls.Add(this.btnNhap);
            this.tabPage1.Controls.Add(this.lbTenSV);
            this.tabPage1.Controls.Add(this.lbMaSV);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtDiem);
            this.tabPage1.Controls.Add(this.dgvDSSV);
            this.tabPage1.Controls.Add(this.cbLopHP);
            this.tabPage1.Controls.Add(this.maGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cập nhật";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Lớp:";
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(681, 201);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 35);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa Điểm";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(348, 201);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 35);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa điểm";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            this.btnNhap.Enabled = false;
            this.btnNhap.Location = new System.Drawing.Point(66, 201);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(118, 35);
            this.btnNhap.TabIndex = 20;
            this.btnNhap.Text = "Nhập điểm";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lbTenSV
            // 
            this.lbTenSV.AutoSize = true;
            this.lbTenSV.Location = new System.Drawing.Point(344, 133);
            this.lbTenSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenSV.Name = "lbTenSV";
            this.lbTenSV.Size = new System.Drawing.Size(16, 16);
            this.lbTenSV.TabIndex = 17;
            this.lbTenSV.Text = "...";
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(128, 133);
            this.lbMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(34, 16);
            this.lbMaSV.TabIndex = 16;
            this.lbMaSV.Text = "SV...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Điểm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã SV:";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(580, 129);
            this.txtDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(148, 22);
            this.txtDiem.TabIndex = 12;
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Location = new System.Drawing.Point(13, 256);
            this.dgvDSSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.RowHeadersWidth = 51;
            this.dgvDSSV.Size = new System.Drawing.Size(851, 374);
            this.dgvDSSV.TabIndex = 11;
            // 
            // cbLopHP
            // 
            this.cbLopHP.FormattingEnabled = true;
            this.cbLopHP.Location = new System.Drawing.Point(66, 49);
            this.cbLopHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLopHP.Name = "cbLopHP";
            this.cbLopHP.Size = new System.Drawing.Size(180, 24);
            this.cbLopHP.TabIndex = 10;
            // 
            // maGV
            // 
            this.maGV.AutoSize = true;
            this.maGV.Location = new System.Drawing.Point(9, 5);
            this.maGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maGV.Name = "maGV";
            this.maGV.Size = new System.Drawing.Size(57, 16);
            this.maGV.TabIndex = 9;
            this.maGV.Text = "MaGV:...";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbHocKyTK);
            this.tabPage2.Controls.Add(this.cbThongKe);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(884, 649);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chọn học kỳ cần thống kê:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Chọn loại thống kê:";
            // 
            // cbHocKyTK
            // 
            this.cbHocKyTK.FormattingEnabled = true;
            this.cbHocKyTK.Location = new System.Drawing.Point(229, 92);
            this.cbHocKyTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHocKyTK.Name = "cbHocKyTK";
            this.cbHocKyTK.Size = new System.Drawing.Size(141, 24);
            this.cbHocKyTK.TabIndex = 2;
            // 
            // cbThongKe
            // 
            this.cbThongKe.FormattingEnabled = true;
            this.cbThongKe.Items.AddRange(new object[] {
            "Điểm TB toàn trường",
            "Điểm TB theo khoa",
            "Điểm TB theo lớp",
            "Số lượng SV cảnh cáo học vụ",
            "Top 10 GPA toàn trường",
            "Top 10 GPA theo học kỳ"});
            this.cbThongKe.Location = new System.Drawing.Point(229, 40);
            this.cbThongKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbThongKe.Name = "cbThongKe";
            this.cbThongKe.Size = new System.Drawing.Size(141, 24);
            this.cbThongKe.TabIndex = 1;
            // 
            // GUI_GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabcontrol);
            this.Name = "GUI_GiangVien";
            this.Text = "GUI_GiangVien";
            this.tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label lbTenSV;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.ComboBox cbLopHP;
        private System.Windows.Forms.Label maGV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbHocKyTK;
        private System.Windows.Forms.ComboBox cbThongKe;
    }
}