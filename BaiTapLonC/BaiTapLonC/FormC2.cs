using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonC
{
    public partial class FormC2 : Form
    {
        private int[] a;

        public FormC2()
        {
            InitializeComponent();
        }

        private void FormC2_Load(object sender, EventArgs e)
        {

        }

        private void btnXuatNgauNhien_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            a = new int[10];
            string s = "";
            for (int i = 0; i < 10; i++)
            {
                a[i] = rd.Next(1, 100);
                s += a[i] + " ";
            }
            txtMangGoc.Text = s;
            txtKetQua.Clear();
        }

        private void btnDemSoLe_Click(object sender, EventArgs e)
        {
            if (a == null) return;
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0) dem++;
            }
            txtKetQua.Text = "So luong so le: " + dem;
        }

        private void btnTongSoLe_Click(object sender, EventArgs e)
        {
            if (a == null) return;
            int tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0) tong += a[i];
            }
            txtKetQua.Text = "Tong cac so le: " + tong;
        }

        private void btnSapXepTang_Click(object sender, EventArgs e)
        {
            if (a == null) return;
            Array.Sort(a);
            string s = "";
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i] + " ";
            }
            txtKetQua.Text = s;
        }

        private void btnTimMin_Click(object sender, EventArgs e)
        {
            if (a == null) return;
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min) min = a[i];
            }
            txtKetQua.Text = "Phan tu nho nhat: " + min;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}