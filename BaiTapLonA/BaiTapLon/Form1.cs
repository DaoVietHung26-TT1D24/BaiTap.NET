using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.Text = "Chương trình chính - Quản lý bài tập C#";
        }

        private void MoFormCon(Form formCon)
        {
            foreach (Form f in this.MdiChildren) { if (f.GetType() == formCon.GetType()) { f.Activate(); return; } }
            formCon.MdiParent = this;
            formCon.Show();
        }

        private void bai1PhanAToolStripMenuItem_Click(object sender, EventArgs e) => MoFormCon(new FormA1());

        private void bai2PhanAToolStripMenuItem_Click(object sender, EventArgs e) => MoFormCon(new FormA2());

        private void bai3PhanAToolStripMenuItem_Click(object sender, EventArgs e) => MoFormCon(new FormA3());

        private void bai4PhanAToolStripMenuItem_Click(object sender, EventArgs e) => MoFormCon(new FormA4());
    }
}