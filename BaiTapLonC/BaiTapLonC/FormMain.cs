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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.Text = "Chương trình chính Phần C";
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

        private void bai2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormC2());
        }

        private void bai3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormC3());
        }
    }
}