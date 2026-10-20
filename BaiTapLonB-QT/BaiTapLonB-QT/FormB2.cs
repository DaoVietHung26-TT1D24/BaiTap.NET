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
    public partial class FormB2 : Form
    {
        public FormB2()
        {
            InitializeComponent();
        }

        private void FormB2_Load(object sender, EventArgs e)
        {

        }

        private void btnTinhDiem_Click(object sender, EventArgs e)
        {
            double csharp, tt, mnm, qtm;
            if (double.TryParse(txtCSharp.Text, out csharp) &&
                double.TryParse(txtTruyenThong.Text, out tt) &&
                double.TryParse(txtMaNguonMo.Text, out mnm) &&
                double.TryParse(txtQuanTriMang.Text, out qtm))
            {
                double dtb = (csharp + tt + mnm + qtm) / 4.0;
                txtDTB.Text = dtb.ToString("N2");

                if (dtb >= 8.0) txtXepLoai.Text = "Gioi";
                else if (dtb >= 7.0) txtXepLoai.Text = "Kha";
                else if (dtb >= 5.0) txtXepLoai.Text = "Trung binh";
                else txtXepLoai.Text = "Yeu";
            }
            else
            {
                MessageBox.Show("Vui long nhap du 4 mon diem hop le");
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtCSharp.Clear();
            txtTruyenThong.Clear();
            txtMaNguonMo.Clear();
            txtQuanTriMang.Clear();
            txtDTB.Clear();
            txtXepLoai.Clear();
            rdoNam.Checked = true;
            txtMaSV.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}