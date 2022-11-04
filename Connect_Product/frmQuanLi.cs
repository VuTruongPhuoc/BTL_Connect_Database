using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Product
{
    public partial class frmQuanLi : Form
    {
        public frmQuanLi()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmView frm = new frmView();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
