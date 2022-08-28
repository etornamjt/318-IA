using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etornam
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barCode = textBox1.Text;
            try
            {
                Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox1.Image = brCode.Draw(barCode, 150);
            }
            catch (Exception)
            {

                //}
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
