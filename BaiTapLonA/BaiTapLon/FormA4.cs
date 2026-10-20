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
    public partial class FormA4 : Form
    {
        public FormA4()
        {
            InitializeComponent();
        }

        private void FormA4_Load(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            double chiSoDau, chiSoCuoi;
            if (double.TryParse(txtChiSoDau.Text, out chiSoDau) && double.TryParse(txtChiSoCuoi.Text, out chiSoCuoi))
            {
                if (chiSoCuoi < chiSoDau)
                {
                    MessageBox.Show("Chi so cuoi phai lon hon hoac bang chi so dau");
                    return;
                }

                double soKw = chiSoCuoi - chiSoDau;
                double thanhTien = 0;

                if (soKw <= 100)
                {
                    thanhTien = soKw * 500;
                }
                else if (soKw <= 250)
                {
                    thanhTien = 100 * 500 + (soKw - 100) * 600;
                }
                else if (soKw <= 300)
                {
                    thanhTien = 100 * 500 + 150 * 600 + (soKw - 250) * 800;
                }
                else
                {
                    thanhTien = 100 * 500 + 150 * 600 + 50 * 800 + (soKw - 300) * 1000;
                }

                txtSoTien.Text = thanhTien.ToString("N2");
            }
            else
            {
                MessageBox.Show("Vui long nhap chi so hop le");
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtChiSoDau.Clear();
            txtChiSoCuoi.Clear();
            txtSoTien.Clear();
            txtChiSoDau.Focus();
        }
    }
}