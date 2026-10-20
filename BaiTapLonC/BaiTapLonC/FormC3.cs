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
    public partial class FormC3 : Form
    {
        private int[] mang;

        public FormC3()
        {
            InitializeComponent();
        }

        private void FormC3_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtNhapN.Text, out n) && n > 0)
            {
                mang = new int[n];
                Random rd = new Random();
                string s = "";
                for (int i = 0; i < n; i++)
                {
                    mang[i] = rd.Next(1, 100);
                    s += mang[i] + "   ";
                }
                txtDaySo.Text = s;
                txtKetQua.Clear();
                txtKetQuaSapXep.Clear();
            }
            else
            {
                MessageBox.Show("Vui long nhap N hop le");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (mang == null || mang.Length == 0) { MessageBox.Show("Chua co mang"); return; }
            if (rdoMax.Checked)
            {
                int max = mang.Max();
                txtKetQua.Text = max.ToString();
            }
            else
            {
                int min = mang.Min();
                txtKetQua.Text = min.ToString();
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (mang == null || mang.Length == 0) { MessageBox.Show("Chua co mang"); return; }
            int[] temp = (int[])mang.Clone();
            if (rdoTang.Checked)
            {
                Array.Sort(temp);
            }
            else
            {
                Array.Sort(temp);
                Array.Reverse(temp);
            }
            string s = "";
            for (int i = 0; i < temp.Length; i++)
            {
                s += temp[i] + "   ";
            }
            txtKetQuaSapXep.Text = s;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}