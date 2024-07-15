using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmDMChatLieu : Form
    {
        private readonly string connectionString = @"Data Source=LAPTOP-E3A674CF;Initial Catalog=qanlibanhang;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable table;

        public frmDMChatLieu()
        {
            InitializeComponent();
        }

        private void frmDMChatLieu_Load(object sender, EventArgs e)
        {
            // Khởi tạo kết nối và adapter
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("SELECT * FROM tblChatLieu", connection);
            table = new DataTable();

            // Lấy dữ liệu và hiển thị trong DataGridView
            adapter.Fill(table);
            dgvChatLieu.DataSource = table;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maChatLieu = txtMaChatLieu.Text;
            string tenChatLieu = txtTenChatLieu.Text;

            // Mở kết nối
            connection.Open();

            // Tạo câu lệnh SQL cho việc thêm mới
            string sql = $"INSERT INTO tblChatLieu (MaChatLieu, TenChatLieu) VALUES (N'{maChatLieu}', N'{tenChatLieu}')";

            // Thực thi câu lệnh SQL
            SqlCommand command = new SqlCommand(sql, connection);
            int rowsAffected = command.ExecuteNonQuery();

            // Đóng kết nối
            connection.Close();

            // Kiểm tra và thông báo kết quả
            if (rowsAffected > 0)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo");
                RefreshData();
            }
            else
            {
                MessageBox.Show("Thêm không thành công.", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maChatLieu = txtMaChatLieu.Text;
            string tenChatLieu = txtTenChatLieu.Text;

            // Mở kết nối
            connection.Open();

            // Tạo câu lệnh SQL cho việc cập nhật
            string sql = $"UPDATE tblChatLieu SET TenChatLieu = N'{tenChatLieu}' WHERE MaChatLieu = N'{maChatLieu}'";

            // Thực thi câu lệnh SQL
            SqlCommand command = new SqlCommand(sql, connection);
            int rowsAffected = command.ExecuteNonQuery();

            // Đóng kết nối
            connection.Close();

            // Kiểm tra và thông báo kết quả
            if (rowsAffected > 0)
            {
                MessageBox.Show("Sửa thành công.", "Thông báo");
                RefreshData();
            }
            else
            {
                MessageBox.Show("Sửa không thành công.", "Thông báo");
            }
        }

        private void btnXoaa_Click(object sender, EventArgs e)
        {
            string maChatLieu = txtMaChatLieu.Text;

            // Mở kết nối
            connection.Open();

            // Tạo câu lệnh SQL cho việc xóa
            string sql = $"DELETE FROM tblChatLieu WHERE MaChatLieu = N'{maChatLieu}'";

            // Thực thi câu lệnh SQL
            SqlCommand command = new SqlCommand(sql, connection);
            int rowsAffected = command.ExecuteNonQuery();

            // Đóng kết nối
            connection.Close();

            // Kiểm tra và thông báo kết quả
            if (rowsAffected > 0)
            {
                MessageBox.Show("Xóa thành công.", "Thông báo");
                RefreshData();
            }
            else
            {
                MessageBox.Show("Xóa không thành công.", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RefreshData()
        {
            // Xóa dữ liệu cũ và lấy dữ liệu mới từ cơ sở dữ liệu
            table.Clear();
            adapter.Fill(table);

            // Cập nhật dữ liệu trong DataGridView
            dgvChatLieu.DataSource = table;
        }
    }
}
