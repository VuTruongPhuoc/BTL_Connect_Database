using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Product
{
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }
        public void HienThiview()
        {

            SqlConnection conn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            try
            {
                conn.Open();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "select * from dbo.cau1";
                da.SelectCommand.Connection = conn;
                da.Fill(dt);
                dgvHienThi.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void HienThiview_2()
        {

            SqlConnection conn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            try
            {
                conn.Open();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "select * from dbo.cau2";
                da.SelectCommand.Connection = conn;
                da.Fill(dt);
                dgvHienThi.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void HienThithutuc()
        {

            SqlConnection conn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            try
            {
                conn.Open();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "select * from dbo.cau1";
                da.SelectCommand.Connection = conn;
                da.Fill(dt);
                dgvHienThi.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmQuanLi_Load(object sender, EventArgs e)
        {
            HienThiview();
        }
    }
}
