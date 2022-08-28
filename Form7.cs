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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.ShowDialog();
        }
    }
}
