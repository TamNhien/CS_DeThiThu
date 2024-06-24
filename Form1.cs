using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_DeThiThu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình tiện ích", "Thông tin", MessageBoxButtons.OK);
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dinhdang dinhdang = new dinhdang();
            dinhdang.ShowDialog();
        }

        private void giảiPhươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaiPTBac2 giaiPTBac2 = new GiaiPTBac2();
            giaiPTBac2.ShowDialog();
        }

        private void đăngKíMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangkimh dangkimh = new dangkimh();
            dangkimh.ShowDialog();
        }
    }
}
