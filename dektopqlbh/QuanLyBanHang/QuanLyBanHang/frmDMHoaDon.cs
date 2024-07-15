using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmDMHoaDon : Form
    {
        string connectionString = @"Data Source=LAPTOP-E3A674CF;Initial Catalog=qanlibanhang;Integrated Security=True;";
        SqlConnection cnn;

        public frmDMHoaDon()
        {
            InitializeComponent();
            cnn = new SqlConnection(connectionString);
        }

        private void frmDMHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvHoaDonBan.DataSource = GetHoaDon();
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            cboMaNhanVien.DataSource = GetNhanVien();
            cboMaNhanVien.DisplayMember = "TenNhanVien";
            cboMaNhanVien.ValueMember = "MaNhanVien";

            cboMaKhach.DataSource = GetKhachHang();
            cboMaKhach.DisplayMember = "TenKhach";
            cboMaKhach.ValueMember = "MaKhach";

            cboMaHang.DataSource = GetHang();
            cboMaHang.DisplayMember = "MaHang";
            cboMaHang.ValueMember = "MaHang";
        }

        private DataTable GetHoaDon()
        {
            string query = @"SELECT tblHDBan.MaHDBan, tblHDBan.MaNhanVien, tblHDBan.NgayBan, tblHDBan.MaKhach, tblChiTietHD.MaHang, tblChiTietHD.SoLuong 
                             FROM tblHDBan 
                             JOIN tblChiTietHD ON tblHDBan.MaHDBan = tblChiTietHD.MaHDBan";
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }

        private DataTable GetNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblNhanVien", cnn);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }

        private DataTable GetKhachHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblKhach", cnn);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }

        private DataTable GetHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaHang FROM tblHang", cnn);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlTransaction transaction = cnn.BeginTransaction();

            // Insert into tblHDBan
            string sqlHDBan = "INSERT INTO tblHDBan (MaHDBan, MaNhanVien, NgayBan, MaKhach) VALUES (@MaHDBan, @MaNhanVien, @NgayBan, @MaKhach)";
            SqlCommand cmdHDBan = new SqlCommand(sqlHDBan, cnn, transaction);
            cmdHDBan.Parameters.AddWithValue("@MaHDBan", txtMaHD.Text);
            cmdHDBan.Parameters.AddWithValue("@MaNhanVien", cboMaNhanVien.SelectedValue);
            cmdHDBan.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Value);
            cmdHDBan.Parameters.AddWithValue("@MaKhach", cboMaKhach.SelectedValue);

            cmdHDBan.ExecuteNonQuery();

            // Insert into tblChiTietHD
            string sqlChiTietHD = "INSERT INTO tblChiTietHD (MaHDBan, MaHang, SoLuong) VALUES (@MaHDBan, @MaHang, @SoLuong)";
            SqlCommand cmdChiTietHD = new SqlCommand(sqlChiTietHD, cnn, transaction);
            cmdChiTietHD.Parameters.AddWithValue("@MaHDBan", txtMaHD.Text);
            cmdChiTietHD.Parameters.AddWithValue("@MaHang", cboMaHang.SelectedValue);
            cmdChiTietHD.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);

            cmdChiTietHD.ExecuteNonQuery();

            transaction.Commit();

            MessageBox.Show("Thêm thành công.", "Thông báo");
            dgvHoaDonBan.DataSource = GetHoaDon();
            cnn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlTransaction transaction = cnn.BeginTransaction();

            // Delete from tblChiTietHD
            string sqlChiTietHD = "DELETE FROM tblChiTietHD WHERE MaHDBan = @MaHDBan";
            SqlCommand cmdChiTietHD = new SqlCommand(sqlChiTietHD, cnn, transaction);
            cmdChiTietHD.Parameters.AddWithValue("@MaHDBan", txtMaHD.Text);

            cmdChiTietHD.ExecuteNonQuery();

            // Delete from tblHDBan
            string sqlHDBan = "DELETE FROM tblHDBan WHERE MaHDBan = @MaHDBan";
            SqlCommand cmdHDBan = new SqlCommand(sqlHDBan, cnn, transaction);
            cmdHDBan.Parameters.AddWithValue("@MaHDBan", txtMaHD.Text);

            cmdHDBan.ExecuteNonQuery();

            transaction.Commit();

            MessageBox.Show("Xóa thành công.", "Thông báo");
            dgvHoaDonBan.DataSource = GetHoaDon();
            cnn.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlTransaction transaction = cnn.BeginTransaction();

            // Update tblHDBan
            string sqlHDBan = "UPDATE tblHDBan SET MaNhanVien = @MaNhanVien, NgayBan = @NgayBan, MaKhach = @MaKhach WHERE MaHDBan = @MaHDBan";
            SqlCommand cmdHDBan = new SqlCommand(sqlHDBan, cnn, transaction);
            cmdHDBan.Parameters.AddWithValue("@MaNhanVien", cboMaNhanVien.SelectedValue);
            cmdHDBan.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Value);
            cmdHDBan.Parameters.AddWithValue("@MaKhach", cboMaKhach.SelectedValue);
            cmdHDBan.Parameters.AddWithValue("@MaHDBan", txtMaHD.Text);

            cmdHDBan.ExecuteNonQuery();

            // Update tblChiTietHD
            string sqlChiTietHD = "UPDATE tblChiTietHD SET MaHang = @MaHang, SoLuong = @SoLuong WHERE MaHDBan = @MaHDBan";
            SqlCommand cmdChiTietHD = new SqlCommand(sqlChiTietHD, cnn, transaction);
            cmdChiTietHD.Parameters.AddWithValue("@MaHang", cboMaHang.SelectedValue);
            cmdChiTietHD.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
            cmdChiTietHD.Parameters.AddWithValue("@MaHDBan", txtMaHD.Text);

            cmdChiTietHD.ExecuteNonQuery();

            transaction.Commit();

            MessageBox.Show("Sửa thành công.", "Thông báo");
            dgvHoaDonBan.DataSource = GetHoaDon();
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
