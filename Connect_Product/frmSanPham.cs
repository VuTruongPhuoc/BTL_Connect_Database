using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Product
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        
        public void HienThiDSSP()
        {
            SqlConnection conn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            //lấy chuỗi kết nối từ file App.config
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            try
            {
                //mở chuỗi kết nối
                conn.Open();
                //khai báo đối tượng SqlCommand trong SqlDataAdapter
                da.SelectCommand = new SqlCommand();
                //gọi thủ tục từ SQL
                da.SelectCommand.CommandText = "SP_HienThiSP";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //gán chuỗi kết nối
                da.SelectCommand.Connection = conn;
                //sử dụng phương thức fill để điền dữ liệu từ datatable vào SqlDataAdapter
                da.Fill(dt);
                //gán dữ liệu từ datatable vào datagridview
                dgvSanPham.DataSource = dt;
                //đóng chuỗi kết nối
                conn.Close();
            }
            catch (Exception ex)
            {   
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable HienThiTH()
        {
            SqlConnection conn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            //lấy chuỗi kết nối từ file App.config
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            try
            {
                //mở chuỗi kết nối
                conn.Open();
                //khai báo đối tượng SqlCommand trong SqlDataAdapter
                da.SelectCommand = new SqlCommand();
                //gọi thủ tục từ SQL
                da.SelectCommand.CommandText = "SP_HienThiTH";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //gán chuỗi kết nối
                da.SelectCommand.Connection = conn;
                //sử dụng phương thức fill để điền dữ liệu từ datatable vào SqlDataAdapter
                da.Fill(dt);
                //gán dữ liệu từ datatable vào datagridview
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            cboMaHSX.DataSource = HienThiTH();
            cboMaHSX.DisplayMember = "TenTH";
            cboMaHSX.ValueMember = "MaTH";
            HienThiDSSP();
        }
        public bool KiemTraThongTin()
        {
            if (txtMaSP.TextLength == 0) { MessageBox.Show("Vui lòng nhập Mã SP !", "Thông báo"); return false; }
            else if (txtTenSP.TextLength == 0) { MessageBox.Show("Vui lòng nhập Tên SP !", "Thông báo"); return false; }
            else if (cboMaHSX.SelectedIndex == -1) { MessageBox.Show("Vui lòng nhập Thương Hiệu SX !", "Thông báo"); return false; }
            else if (txtKichThuoc.TextLength == 0) { MessageBox.Show("Vui lòng nhập Kích Thước SP !", "Thông báo"); return false; }
            else if (txtPhanGiai.TextLength == 0) { MessageBox.Show("Vui lòng nhập Độ Phân Giải !", "Thông báo"); return false; }
            else if (txtManHinh.TextLength == 0) { MessageBox.Show("Vui lòng nhập kích thước Mành Hình !", "Thông báo"); return false; }
            else if (numSoLuong.Value == 0) { MessageBox.Show("Vui Lòng Nhập Số Lượng của SP", "Thông báo"); return false; }
            else if (txtDonGiaNhap.TextLength == 0) { MessageBox.Show("Vui lòng nhập Đơn Giá Nhập của SP"); return false; }
            else if (txtDonGiaBan.TextLength == 0) { MessageBox.Show("Vui lòng nhập Đơn Giá Bán của SP"); return false; }
            else if (txtBaoHanh.TextLength == 0) { MessageBox.Show("Vui lòng nhập Thời gian bảo hành của SP"); return false; }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SP_ThemSP";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@masp", SqlDbType.NVarChar).Value = txtMaSP.Text;
                    cmd.Parameters.Add("@tensp", SqlDbType.NVarChar).Value = txtTenSP.Text;
                    cmd.Parameters.Add("@math", SqlDbType.NVarChar).Value = cboMaHSX.Text;
                    cmd.Parameters.Add("@kichthuoc", SqlDbType.NVarChar).Value = txtKichThuoc.Text;
                    cmd.Parameters.Add("@dpg", SqlDbType.NVarChar).Value = txtPhanGiai.Text;
                    cmd.Parameters.Add("@manhinh", SqlDbType.NVarChar).Value = txtManHinh.Text;
                    cmd.Parameters.Add("@sl", SqlDbType.Int).Value = numSoLuong.Value;
                    cmd.Parameters.Add("@dgn", SqlDbType.Money).Value = SqlMoney.Parse(txtDonGiaNhap.Text);
                    cmd.Parameters.Add("@dgb", SqlDbType.Money).Value = SqlMoney.Parse(txtDonGiaBan.Text);
                    cmd.Parameters.Add("@hinhanh", SqlDbType.NVarChar).Value = txtHinhAnh.Text;
                    cmd.Parameters.Add("@bh", SqlDbType.NVarChar).Value = txtBaoHanh.Text;
                    cmd.Parameters.Add("@mota", SqlDbType.NVarChar).Value = txtGhiChu.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    HienThiDSSP();
                    Reset();
                    MessageBox.Show("Đã thêm mới sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSP.Focus();
            }
            else if (KiemTraThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "SP_SuaSP";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@masp", SqlDbType.NVarChar).Value = txtMaSP.Text;
                    cmd.Parameters.Add("@tensp", SqlDbType.NVarChar).Value = txtTenSP.Text;
                    cmd.Parameters.Add("@math", SqlDbType.NVarChar).Value = cboMaHSX.Text;
                    cmd.Parameters.Add("@kichthuoc", SqlDbType.NVarChar).Value = txtKichThuoc.Text;
                    cmd.Parameters.Add("@dpg", SqlDbType.NVarChar).Value = txtPhanGiai.Text;
                    cmd.Parameters.Add("@manhinh", SqlDbType.NVarChar).Value = txtManHinh.Text;
                    cmd.Parameters.Add("@sl", SqlDbType.Int).Value = numSoLuong.Value;
                    cmd.Parameters.Add("@dgn", SqlDbType.Money).Value = SqlMoney.Parse(txtDonGiaNhap.Text);
                    cmd.Parameters.Add("@dgb", SqlDbType.Money).Value = SqlMoney.Parse(txtDonGiaBan.Text);
                    cmd.Parameters.Add("@hinhanh", SqlDbType.NVarChar).Value = txtHinhAnh.Text;
                    cmd.Parameters.Add("@bh", SqlDbType.NVarChar).Value = txtBaoHanh.Text;
                    cmd.Parameters.Add("@mota", SqlDbType.NVarChar).Value = txtGhiChu.Text;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    HienThiDSSP();
                    Reset();
                    MessageBox.Show("Đã sửa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSP.Focus();
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "SP_XoaSP";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@masp", SqlDbType.NVarChar).Value =txtMaSP.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    HienThiDSSP();
                    Reset();
                    MessageBox.Show("Đã xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void Reset()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cboMaHSX.SelectedIndex = -1;
            txtKichThuoc.Text = "";
            txtPhanGiai.Text = "";
            txtManHinh.Text = "";
            numSoLuong.Value = 0;
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            txtBaoHanh.Text = "";
            txtHinhAnh.Text = "";
            txtGhiChu.Text = "";
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            cboMaHSX.SelectedItem = dgvSanPham.CurrentRow.Cells[2].Value.ToString(); ;
            txtKichThuoc.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
            txtPhanGiai.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
            txtManHinh.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
            numSoLuong.Value = Int32.Parse(dgvSanPham.CurrentRow.Cells[6].Value.ToString());
            txtDonGiaNhap.Text = dgvSanPham.CurrentRow.Cells[7].Value.ToString();
            txtDonGiaBan.Text = dgvSanPham.CurrentRow.Cells[8].Value.ToString();         
            txtHinhAnh.Text = dgvSanPham.CurrentRow.Cells[10].Value.ToString();
            txtBaoHanh.Text = dgvSanPham.CurrentRow.Cells[9].Value.ToString();
            txtGhiChu.Text = dgvSanPham.CurrentRow.Cells[11].Value.ToString();
        }
    }
}
