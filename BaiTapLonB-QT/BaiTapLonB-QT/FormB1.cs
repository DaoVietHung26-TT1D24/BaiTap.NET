using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonB_QT
{
    public partial class FormB1 : Form
    {
        public FormB1()
        {
            InitializeComponent();
        }

        private void FormB1_Load(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            double moi, cu;
            if (double.TryParse(txtChiSoMoi.Text, out moi) && double.TryParse(txtChiSoCu.Text, out cu))
            {
                if (moi < cu)
                {
                    MessageBox.Show("Chi so moi phai lon hon hoac bang chi so cu");
                    return;
                }
                double kw = moi - cu;
                double donGia = rdoCaNhan.Checked ? 5000 : 6000;
                double thanhTien = kw * donGia;
                double vat = thanhTien * 0.10;
                double tong = thanhTien + vat;

                txtSoKw.Text = kw.ToString();
                txtThanhTien.Text = thanhTien.ToString("N0");
                txtThueVAT.Text = vat.ToString("N0");
                txtTongCong.Text = tong.ToString("N0");
            }
            else
            {
                MessageBox.Show("Vui long nhap chi so hop le");
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            txtChiSoMoi.Clear();
            txtChiSoCu.Clear();
            txtSoKw.Clear();
            txtThanhTien.Clear();
            txtThueVAT.Clear();
            txtTongCong.Clear();
            rdoCaNhan.Checked = true;
            txtChiSoMoi.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}