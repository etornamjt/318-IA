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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.ShowDialog();
        }
    }
}
