using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Etornam
{
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPG|*.jpg" })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    BarcodeReader reader = new BarcodeReader();
                    var result = reader.Decode((Bitmap)pictureBox1.Image);
                    if (result != null)
                        textBox1.Text = result.ToString();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.ShowDialog();
        }
    }
}
