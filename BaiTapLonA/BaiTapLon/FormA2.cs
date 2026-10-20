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
    public partial class FormA2 : Form
    {
        public FormA2()
        {
            InitializeComponent();
        }

        private void FormA2_Load(object sender, EventArgs e)
        {
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double dai, rong;
            if (double.TryParse(txtChieuDai.Text, out dai) && double.TryParse(txtChieuRong.Text, out rong) && dai > 0 && rong > 0)
            {
                double cv = 2 * (dai + rong);
                double dt = dai * rong;
                txtChuVi.Text = cv.ToString();
                txtDienTich.Text = dt.ToString();
            }
            else
            {
                MessageBox.Show("Vui long nhap chieu dai va chieu rong hop le");
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtChieuDai.Clear();
            txtChieuRong.Clear();
            txtChuVi.Clear();
            txtDienTich.Clear();
            txtChieuDai.Focus();
        }
    }
}