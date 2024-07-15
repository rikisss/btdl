namespace QuanLyBanHang
{
    partial class frmMain_Load
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChatLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuHeThong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(711, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.BackColor = System.Drawing.Color.LightCoral;
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChatLieu,
            this.mnuNhanVien,
            this.mnuKhachHang,
            this.mnuHang,
            this.mnuHoaDon});
            this.mnuDanhMuc.ForeColor = System.Drawing.Color.Brown;
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhMuc.Text = "Danh Mục";
            // 
            // mnuChatLieu
            // 
            this.mnuChatLieu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.mnuChatLieu.ForeColor = System.Drawing.Color.Brown;
            this.mnuChatLieu.Name = "mnuChatLieu";
            this.mnuChatLieu.Size = new System.Drawing.Size(224, 26);
            this.mnuChatLieu.Text = "Chất liệu";
            this.mnuChatLieu.Click += new System.EventHandler(this.mnuChatLieu_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.BackColor = System.Drawing.Color.PaleTurquoise;
            this.mnuNhanVien.ForeColor = System.Drawing.Color.Brown;
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(224, 26);
            this.mnuNhanVien.Text = "Nhân Viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.BackColor = System.Drawing.Color.PaleTurquoise;
            this.mnuKhachHang.ForeColor = System.Drawing.Color.Brown;
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(224, 26);
            this.mnuKhachHang.Text = "Khách Hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuHang
            // 
            this.mnuHang.BackColor = System.Drawing.Color.PaleTurquoise;
            this.mnuHang.ForeColor = System.Drawing.Color.Brown;
            this.mnuHang.Name = "mnuHang";
            this.mnuHang.Size = new System.Drawing.Size(224, 26);
            this.mnuHang.Text = "Hàng";
            this.mnuHang.Click += new System.EventHandler(this.mnuHang_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.mnuHoaDon.ForeColor = System.Drawing.Color.Brown;
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(224, 26);
            this.mnuHoaDon.Text = "Hóa Đơn";
            this.mnuHoaDon.Click += new System.EventHandler(this.mnuHoaDon_Click);
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.BackColor = System.Drawing.Color.MistyRose;
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuHeThong.ForeColor = System.Drawing.Color.Brown;
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(88, 24);
            this.mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuThoat
            // 
            this.mnuThoat.BackColor = System.Drawing.Color.PaleTurquoise;
            this.mnuThoat.ForeColor = System.Drawing.Color.Brown;
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(224, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(180, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Bán Hàng";
            // 
            // frmMain_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.bán_hàng_là_gì;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain_Load";
            this.Text = "Quản Lý Bán Hàng";
            this.Load += new System.EventHandler(this.frmMain_Load_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuChatLieu;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuHang;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.Label label1;
    }
}