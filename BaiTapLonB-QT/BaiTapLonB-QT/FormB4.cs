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
    public partial class FormB4 : Form
    {
        public FormB4()
        {
            InitializeComponent();
        }

        private void FormB4_Load(object sender, EventArgs e)
        {

        }

        private int USCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(txtSoA.Text, out a) && int.TryParse(txtSoB.Text, out b))
            {
                int u = USCLN(a, b);
                if (rdoUSCLN.Checked)
                {
                    txtKetQua.Text = u.ToString();
                }
                else
                {
                    if (u == 0) txtKetQua.Text = "0";
                    else
                    {
                        long bscnn = (long)Math.Abs(a * b) / u;
                        txtKetQua.Text = bscnn.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui long nhap hai so nguyen a va b");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}