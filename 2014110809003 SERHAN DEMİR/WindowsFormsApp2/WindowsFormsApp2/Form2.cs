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
    public partial class Form2 : Form
    {
        Bitmap kaynak, islem;
        public Form2()
       
        {
            InitializeComponent();
        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        
        private void kaydetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }

        private void ortlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = (renkliRenk.R + renkliRenk.G + renkliRenk.B) / 3;
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }

            islemBox.Image = islem;

        }

        private void açToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }
        }

        private void kapatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
