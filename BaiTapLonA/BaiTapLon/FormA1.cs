using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonA
{
    public partial class FormA1 : Form
    {
        public FormA1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double r;
            if (double.TryParse(txtBanKinh.Text, out r) && r > 0)
            {
                double cv = 2 * Math.PI * r;
                double dt = Math.PI * r * r;
                txtChuVi.Text = cv.ToString("N2");
                txtDienTich.Text = dt.ToString("N2");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập bán kính là số lớn hơn 0");
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtBanKinh.Clear();
            txtChuVi.Clear();
            txtDienTich.Clear();
            txtBanKinh.Focus();
        }
    }
}