using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmMain_Load : Form
    {
        public TextBox txtTentk;
        public frmMain_Load()
        {
            InitializeComponent();
        }
        

        private void frmMain_Load_Load(object sender, EventArgs e)
        {

        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu chatLieu = new frmDMChatLieu();
            chatLieu.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien nhanVien = new frmDMNhanVien();
            nhanVien.ShowDialog();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhach khachhang = new frmDMKhach();
            khachhang.ShowDialog();
        }

        private void mnuHang_Click(object sender, EventArgs e)
        {
            frmDMHang hang = new frmDMHang();
            hang.ShowDialog();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            frmDMHoaDon donBan = new frmDMHoaDon();
            donBan.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
