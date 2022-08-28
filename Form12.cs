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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form25 f25 = new Form25();
            f25.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form27 f27 = new Form27();
            f27.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form28 f28 = new Form28();
            f28.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form29 f29 = new Form29();
            f29.ShowDialog();
        }
    }
}
