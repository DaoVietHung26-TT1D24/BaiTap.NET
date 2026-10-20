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
    public partial class FormB3 : Form
    {
        public FormB3()
        {
            InitializeComponent();
        }

        private void FormB3_Load(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int sl;
            double donGia;
            if (int.TryParse(txtSoLuong.Text, out sl) && double.TryParse(txtDonGia.Text, out donGia) && sl > 0 && donGia > 0)
            {
                double thanhTien = sl * donGia;
                double vat = thanhTien * 0.10;
                double giamGia = rdoCaNhan.Checked ? (thanhTien * 0.03) : (thanhTien * 0.05);
                double tong = (thanhTien + vat) - giamGia;

                txtThanhTien.Text = thanhTien.ToString("N0");
                txtThueVAT.Text = vat.ToString("N0");
                txtGiamGia.Text = giamGia.ToString("N0");
                txtTongCong.Text = tong.ToString("N0");
            }
            else
            {
                MessageBox.Show("Vui long nhap so luong va don gia lon hon 0");
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            txtDiaChi.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
            txtThueVAT.Clear();
            txtGiamGia.Clear();
            txtTongCong.Clear();
            rdoCaNhan.Checked = true;
            txtTenKhach.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}