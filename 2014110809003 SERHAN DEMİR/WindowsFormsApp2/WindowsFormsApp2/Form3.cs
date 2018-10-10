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
    public partial class Form3 : Form
    {
        Bitmap kaynak, islem;
        public Form3()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap (openFileDialog1.FileName);
                kaynakBox.Image =kaynak;
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bT709ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = (renkliRenk.R*2125) + (renkliRenk.G*7154) + (renkliRenk.B*720);
                    gri = gri / 10000;
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }

            islemBox.Image = islem;
        }
    }
}
