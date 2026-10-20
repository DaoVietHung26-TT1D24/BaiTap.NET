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
    public partial class FormB6 : Form
    {
        public FormB6()
        {
            InitializeComponent();
        }

        private void FormB6_Load(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            long tong = 0;
            if (chkTinA.Checked) tong += 300000;
            if (chkTinB.Checked) tong += 500000;
            if (chkTiengAnhA.Checked) tong += 400000;
            if (chkTiengAnhB.Checked) tong += 600000;

            txtTongTien.Text = tong.ToString("N0") + " dong";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            chkTinA.Checked = false;
            chkTinB.Checked = false;
            chkTiengAnhA.Checked = false;
            chkTiengAnhB.Checked = false;
            txtTongTien.Clear();
            txtHoTen.Clear();
            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}