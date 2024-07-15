using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmDMHang : Form
    {
        string connectionString = @"Data Source=LAPTOP-E3A674CF;Initial Catalog=qanlibanhang;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection cnn;
        SqlDataAdapter da;
        DataSet ds;

        public frmDMHang()
        {
            InitializeComponent();
            cnn = new SqlConnection(connectionString);
        }

        public DataTable getHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaHang, TenHang, MaChatLieu, SoLuong FROM tblHang", cnn);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }

        private void frmDMHang_Load(object sender, EventArgs e)
        {
            dgvHang.DataSource = getHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string sql = "INSERT INTO tblHang (MaHang, TenHang, MaChatLieu, SoLuong) VALUES (@MaHang, @TenHang, @MaChatLieu, @SoLuong)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@MaHang", txtMaHang.Text);
            cmd.Parameters.AddWithValue("@TenHang", txtTenHang.Text);
            cmd.Parameters.AddWithValue("@MaChatLieu", cboMaChatLieu.Text);
            cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo");
                dgvHang.DataSource = getHang();
            }
            else
            {
                MessageBox.Show("Thêm không thành công.", "Thông báo");
            }

            cnn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string sql = "DELETE FROM tblHang WHERE MaHang = @MaHang";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@MaHang", txtMaHang.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Xóa thành công.", "Thông báo");
                dgvHang.DataSource = getHang();
            }
            else
            {
                MessageBox.Show("Xóa không thành công.", "Thông báo");
            }

            cnn.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string sql = "UPDATE tblHang SET TenHang = @TenHang, MaChatLieu = @MaChatLieu, SoLuong = @SoLuong WHERE MaHang = @MaHang";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@TenHang", txtTenHang.Text);
            cmd.Parameters.AddWithValue("@MaChatLieu", cboMaChatLieu.Text);
            cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("@MaHang", txtMaHang.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Sửa thành công.", "Thông báo");
                dgvHang.DataSource = getHang();
            }
            else
            {
                MessageBox.Show("Sửa không thành công.", "Thông báo");
            }

            cnn.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
