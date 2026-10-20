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
    public partial class FormA3 : Form
    {
        public FormA3()
        {
            InitializeComponent();
        }

        private void FormA3_Load(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            double hki, hkii;
            if (double.TryParse(txtHKI.Text, out hki) && double.TryParse(txtHKII.Text, out hkii))
            {
                double dtb = (hki + hkii * 2) / 3;
                if (dtb >= 8.0)
                {
                    txtXepLoai.Text = "Gioi";
                }
                else if (dtb >= 6.5)
                {
                    txtXepLoai.Text = "Kha";
                }
                else if (dtb >= 5.0)
                {
                    txtXepLoai.Text = "Trung binh";
                }
                else
                {
                    txtXepLoai.Text = "Yeu";
                }
            }
            else
            {
                MessageBox.Show("Vui long nhap diem hop le");
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtHKI.Clear();
            txtHKII.Clear();
            txtXepLoai.Clear();
            txtHKI.Focus();
        }
    }
}