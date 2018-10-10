using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ortalamaFormu = new Form2();
            ortalamaFormu.ShowDialog();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bT709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 bt709Formu = new Form3();
            bt709Formu.ShowDialog();
        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 lumaFormu = new Form4();
            lumaFormu.ShowDialog();
        }

        private void açıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 açıklıkFormu = new Form5();
            açıklıkFormu.ShowDialog();
        }

        private void kanalÇıkarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 kanalFormu = new Form6();
            kanalFormu.ShowDialog();
        }
    }
}
