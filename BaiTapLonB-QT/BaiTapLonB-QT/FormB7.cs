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
    public partial class FormB7 : Form
    {
        public FormB7()
        {
            InitializeComponent();
        }

        private void FormB7_Load(object sender, EventArgs e)
        {
            cboMaNV.Items.Add("A001");
            cboMaNV.Items.Add("B002");
            cboMaNV.Items.Add("C003");
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaNV.SelectedItem != null)
            {
                string ma = cboMaNV.SelectedItem.ToString();
                if (ma.StartsWith("A"))
                {
                    txtTenNV.Text = "Giang Thanh Tron";
                    txtLuongCoBan.Text = "500000";
                }
                else if (ma.StartsWith("B"))
                {
                    txtTenNV.Text = "Nguyen Van A";
                    txtLuongCoBan.Text = "450000";
                }
                else if (ma.StartsWith("C"))
                {
                    txtTenNV.Text = "Tran Thi B";
                    txtLuongCoBan.Text = "400000";
                }
            }
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            double lcb, ngayCong, heSo;
            if (double.TryParse(txtLuongCoBan.Text, out lcb) &&
                double.TryParse(txtSoNgayCong.Text, out ngayCong) &&
                double.TryParse(txtHeSoPhuCap.Text, out heSo))
            {
                double phuCap = 0;
                string ma = cboMaNV.Text;
                if (ma.StartsWith("A")) phuCap = 500000;
                else if (ma.StartsWith("B")) phuCap = 300000;
                else if (ma.StartsWith("C")) phuCap = 200000;

                double thuong = ngayCong * 50000;
                double luongTG = 0;
                if (ngayCong > 22)
                {
                    luongTG = (22 * lcb) + ((ngayCong - 22) * lcb * 2);
                }
                else
                {
                    luongTG = ngayCong * lcb;
                }

                double tong = luongTG + phuCap + thuong;

                txtPhuCapCV.Text = phuCap.ToString("N0");
                txtThuongNgay.Text = thuong.ToString("N0");
                txtLuongThoiGian.Text = luongTG.ToString("N0");
                txtTongCong.Text = tong.ToString("N0");
            }
            else
            {
                MessageBox.Show("Vui long nhap dung luong co ban, so ngay cong va he so");
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            cboMaNV.SelectedIndex = -1;
            txtTenNV.Clear();
            txtLuongCoBan.Clear();
            txtSoNgayCong.Clear();
            txtHeSoPhuCap.Clear();
            txtPhuCapCV.Clear();
            txtThuongNgay.Clear();
            txtLuongThoiGian.Clear();
            txtTongCong.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}