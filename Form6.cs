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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form20 f20 = new Form20();
            f20.ShowDialog();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();
            f18.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form19 f19 = new Form19();
            f19.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form21 f21 = new Form21();
            f21.ShowDialog();
        }
    }
}
