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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
