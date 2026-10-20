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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.Text = "Chuong trinh chinh - Quan ly bai tap Phan B";
        }

        private void MoFormCon(Form formCon)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formCon.GetType())
                {
                    f.Activate();
                    return;
                }
            }
            formCon.MdiParent = this;
            formCon.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bai1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormB1());
        }

        private void bai2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormB2());
        }

        private void bai3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormB3());
        }

        private void bai4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormB4());
        }

        private void bai5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormB5());
        }

        private void bai6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormB6());
        }

        private void bai7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormB7());
        }
    }
}