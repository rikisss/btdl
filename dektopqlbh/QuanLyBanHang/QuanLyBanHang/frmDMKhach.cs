using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmDMKhach : Form
    {
        string connectionString = @"Data Source=LAPTOP-E3A674CF;Initial Catalog=qanlibanhang;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection cnn;
        SqlDataAdapter da;
        DataSet ds;

        public frmDMKhach()
        {
            InitializeComponent();
            cnn = new SqlConnection(connectionString);
        }

        public DataTable getKhach()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaKhach, TenKhach, DienThoai, DiaChi FROM tblKhach", cnn);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string sql = "INSERT INTO tblKhach (MaKhach, TenKhach, DienThoai, DiaChi) VALUES (@MaKhach, @TenKhach, @DienThoai, @DiaChi)";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@MaKhach", txtMaKhachHang.Text);
                cmd.Parameters.AddWithValue("@TenKhach", txtTenKhachHang.Text);
                cmd.Parameters.AddWithValue("@DienThoai", mtbDienThoai.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo");
                    dgvKhach.DataSource = getKhach();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
            finally
            {
                cnn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string sql = "DELETE FROM tblKhach WHERE MaKhach = @MaKhach";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@MaKhach", txtMaKhachHang.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo");
                    dgvKhach.DataSource = getKhach();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
            finally
            {
                cnn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string sql = "UPDATE tblKhach SET TenKhach = @TenKhach, DienThoai = @DienThoai, DiaChi = @DiaChi WHERE MaKhach = @MaKhach";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@TenKhach", txtTenKhachHang.Text);
                cmd.Parameters.AddWithValue("@DienThoai", mtbDienThoai.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@MaKhach", txtMaKhachHang.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công.", "Thông báo");
                    dgvKhach.DataSource = getKhach();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
            finally
            {
                cnn.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Thật sự muốn Thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmDMKhach_Load(object sender, EventArgs e)
        {
            dgvKhach.DataSource = getKhach();
        }
    }
}
