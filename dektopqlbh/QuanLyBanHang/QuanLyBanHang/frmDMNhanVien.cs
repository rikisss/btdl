using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmDMNhanVien : Form
    {
        string st = @"Data Source=LAPTOP-E3A674CF;Initial Catalog=qanlibanhang;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection cnn;
        SqlDataAdapter da;
        DataSet ds;

        public frmDMNhanVien()
        {
            InitializeComponent();
            cnn = new SqlConnection(st);
        }

        public DataTable getNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien, TenNhanVien, DienThoai, NgaySinh from tblNhanVien", cnn);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string sql = "insert into tblNhanVien (MaNhanVien, TenNhanVien, DienThoai, NgaySinh) values (@MaNhanVien, @TenNhanVien, @DienThoai, @NgaySinh)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
            cmd.Parameters.AddWithValue("@TenNhanVien", txtTenNhanVien.Text);
            cmd.Parameters.AddWithValue("@DienThoai", mtbDienThoai.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", mskNgaySinh.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo");
                dgvNhanVien.DataSource = getNhanVien();
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
            string sql = "delete from tblNhanVien where MaNhanVien = @MaNhanVien";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Xóa thành công.", "Thông báo");
                dgvNhanVien.DataSource = getNhanVien();
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
            string sql = "update tblNhanVien set TenNhanVien = @TenNhanVien, DienThoai = @DienThoai, NgaySinh = @NgaySinh where MaNhanVien = @MaNhanVien";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@TenNhanVien", txtTenNhanVien.Text);
            cmd.Parameters.AddWithValue("@DienThoai", mtbDienThoai.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", mskNgaySinh.Text);
            cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Sửa thành công.", "Thông báo");
                dgvNhanVien.DataSource = getNhanVien();
            }
            else
            {
                MessageBox.Show("Sửa không thành công.", "Thông báo");
            }
            cnn.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Thật sự muốn Thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmDMNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = getNhanVien();
        }
    }
}
