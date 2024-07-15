namespace QuanLyBanHang
{
    partial class frmDMHoaDon
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
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.cboMaKhach = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvHoaDonBan = new System.Windows.Forms.DataGridView();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(346, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "DANH MỤC HOÁ ĐƠN";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.splitContainer1.Panel1.Controls.Add(this.cboMaHang);
            this.splitContainer1.Panel1.Controls.Add(this.dtpNgayBan);
            this.splitContainer1.Panel1.Controls.Add(this.cboMaNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.cboMaKhach);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoLuong);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaHD);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.splitContainer1.Panel2.Controls.Add(this.btnThoat);
            this.splitContainer1.Panel2.Controls.Add(this.btnSua);
            this.splitContainer1.Panel2.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel2.Controls.Add(this.btnThem);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 335);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 10;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Location = new System.Drawing.Point(185, 173);
            this.dtpNgayBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(238, 22);
            this.dtpNgayBan.TabIndex = 24;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(185, 119);
            this.cboMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(238, 24);
            this.cboMaNhanVien.TabIndex = 23;
            // 
            // cboMaKhach
            // 
            this.cboMaKhach.FormattingEnabled = true;
            this.cboMaKhach.Location = new System.Drawing.Point(605, 65);
            this.cboMaKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaKhach.Name = "cboMaKhach";
            this.cboMaKhach.Size = new System.Drawing.Size(220, 24);
            this.cboMaKhach.TabIndex = 21;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(605, 174);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(220, 22);
            this.txtSoLuong.TabIndex = 20;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(185, 63);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(238, 22);
            this.txtMaHD.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(458, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(458, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(458, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã Khách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(36, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày Bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(36, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Hóa Đơn Bán";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(725, 28);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 33);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(508, 28);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 33);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(274, 28);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 33);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(68, 28);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 33);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvHoaDonBan
            // 
            this.dgvHoaDonBan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonBan.Location = new System.Drawing.Point(3, 326);
            this.dgvHoaDonBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHoaDonBan.Name = "dgvHoaDonBan";
            this.dgvHoaDonBan.RowHeadersWidth = 62;
            this.dgvHoaDonBan.RowTemplate.Height = 28;
            this.dgvHoaDonBan.Size = new System.Drawing.Size(1008, 138);
            this.dgvHoaDonBan.TabIndex = 29;
            // 
            // cboMaHang
            // 
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(605, 118);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(220, 24);
            this.cboMaHang.TabIndex = 25;
            // 
            // frmDMHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1007, 505);
            this.Controls.Add(this.dgvHoaDonBan);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDMHoaDon";
            this.Text = "Danh mục hóa đơn";
            this.Load += new System.EventHandler(this.frmDMHoaDon_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.ComboBox cboMaKhach;
        private System.Windows.Forms.DataGridView dgvHoaDonBan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.ComboBox cboMaHang;
    }
}