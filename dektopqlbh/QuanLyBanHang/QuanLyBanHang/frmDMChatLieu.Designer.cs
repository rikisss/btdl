namespace QuanLyBanHang
{
    partial class frmDMChatLieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaChatLieu = new System.Windows.Forms.TextBox();
            this.txtTenChatLieu = new System.Windows.Forms.TextBox();
            this.dgvChatLieu = new System.Windows.Forms.DataGridView();
            this.btnXoaa = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(228, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "DANH MỤC CHẤT LIỆU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(58, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Chất Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(58, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Chất Liệu";
            // 
            // txtMaChatLieu
            // 
            this.txtMaChatLieu.Location = new System.Drawing.Point(250, 101);
            this.txtMaChatLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaChatLieu.Name = "txtMaChatLieu";
            this.txtMaChatLieu.Size = new System.Drawing.Size(246, 22);
            this.txtMaChatLieu.TabIndex = 8;
            // 
            // txtTenChatLieu
            // 
            this.txtTenChatLieu.Location = new System.Drawing.Point(250, 182);
            this.txtTenChatLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenChatLieu.Name = "txtTenChatLieu";
            this.txtTenChatLieu.Size = new System.Drawing.Size(246, 22);
            this.txtTenChatLieu.TabIndex = 9;
            // 
            // dgvChatLieu
            // 
            this.dgvChatLieu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChatLieu.Location = new System.Drawing.Point(-2, 310);
            this.dgvChatLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChatLieu.Name = "dgvChatLieu";
            this.dgvChatLieu.RowHeadersWidth = 62;
            this.dgvChatLieu.RowTemplate.Height = 28;
            this.dgvChatLieu.Size = new System.Drawing.Size(764, 158);
            this.dgvChatLieu.TabIndex = 10;
            // 
            // btnXoaa
            // 
            this.btnXoaa.BackColor = System.Drawing.Color.Orange;
            this.btnXoaa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoaa.Location = new System.Drawing.Point(418, 257);
            this.btnXoaa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaa.Name = "btnXoaa";
            this.btnXoaa.Size = new System.Drawing.Size(105, 33);
            this.btnXoaa.TabIndex = 13;
            this.btnXoaa.Text = "Xóa";
            this.btnXoaa.UseVisualStyleBackColor = false;
            this.btnXoaa.Click += new System.EventHandler(this.btnXoaa_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(219, 257);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnSua";
            this.btnXoa.Size = new System.Drawing.Size(105, 33);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Sửa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(32, 257);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 33);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(602, 257);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 33);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDMChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(764, 460);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaa);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvChatLieu);
            this.Controls.Add(this.txtTenChatLieu);
            this.Controls.Add(this.txtMaChatLieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDMChatLieu";
            this.Text = "Danh mục chất liệu";
            this.Load += new System.EventHandler(this.frmDMChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaChatLieu;
        private System.Windows.Forms.TextBox txtTenChatLieu;
        private System.Windows.Forms.DataGridView dgvChatLieu;
        private System.Windows.Forms.Button btnXoaa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
    }
}