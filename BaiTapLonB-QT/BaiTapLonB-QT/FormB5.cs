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
    public partial class FormB5 : Form
    {
        public FormB5()
        {
            InitializeComponent();
        }

        private void FormB5_Load(object sender, EventArgs e)
        {

        }

        private void btnNhapSo_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtNhapSo.Text, out n))
            {
                lsbDaySo.Items.Add(n);
                txtNhapSo.Clear();
                txtNhapSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui long nhap so nguyen hop le");
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int val = Convert.ToInt32(lsbDaySo.Items[i]);
                lsbDaySo.Items[i] = val + 2;
            }
        }

        private void btnChanDau_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                if (Convert.ToInt32(lsbDaySo.Items[i]) % 2 == 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Khong co so chan trong day");
        }

        private void btnLeCuoi_Click(object sender, EventArgs e)
        {
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(lsbDaySo.Items[i]) % 2 != 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Khong co so le trong day");
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.SelectedIndex != -1)
            {
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
            }
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
            {
                lsbDaySo.Items.RemoveAt(0);
            }
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
            {
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
            }
        }

        private void btnXoaDaySo_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}