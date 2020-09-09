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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prog1.Increment(10);
            if(prog1.Value==100)
            {
                this.Hide();
                seskit seskit = new seskit();
                seskit.Show();
                timer1.Stop();
            }
        }
    }
}
