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
    public partial class Form5 : Form
    {
        public object dataGridView1 { get; private set; }

        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form24 f24 = new Form24();
            f24.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form23 f23 = new Form23();
            f23.ShowDialog();
        }
    }
}
