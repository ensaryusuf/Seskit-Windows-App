using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seskitapp
{
    public partial class seskit : Form
    {
        public seskit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void seskit_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(width, height);
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Bu Masaüstü uygulaması seskit için özel geliştirilmiş kod arabirimidir. Sesli kitap deneyiminizi en üst seviyeye taşımak için tasarlanmıştır. Copyright © 2020 EYY Studio";
            string title = "seskit - Türkçe Sesli Kitaplar";
            MessageBox.Show(message, title);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void güncellemeKontrolüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://seskit.com/windows/versiyon");

        }
    }
}
