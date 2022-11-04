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
    public partial class frmThuTuc : Form
    {
        public frmThuTuc()
        {
            InitializeComponent();
        }
        public void Thongke()
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
                da.SelectCommand.CommandText = "SP_Dan";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //gán chuỗi kết nối
                da.SelectCommand.Connection = conn;
                //sử dụng phương thức fill để điền dữ liệu từ datatable vào SqlDataAdapter
                da.Fill(dt);
                //gán dữ liệu từ datatable vào datagridview
                dgvKetQua.DataSource = dt;
                //đóng chuỗi kết nối
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void HienThiDSNCC()
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
                da.SelectCommand.CommandText = "SP_HienThiNCC";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //gán chuỗi kết nối
                da.SelectCommand.Connection = conn;
                //sử dụng phương thức fill để điền dữ liệu từ datatable vào SqlDataAdapter
                da.Fill(dt);
                //gán dữ liệu từ datatable vào datagridview
                dgvKetQua.DataSource = dt;
                //đóng chuỗi kết nối
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ThongKeSanPhamTheoNhaCungCap";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mancc", SqlDbType.NVarChar).Value = txtMaNCC.Text;
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đã thêm mới sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
