using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Etornam
{
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Avanuse_777";
            string Query = "insert into etornam.customer(NAME,ID,PRODUCT,QUANTITY,PRICE) values ( '" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + " ' );";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            MessageBox.Show("Purchase Successful");
            //MessageBox.Show("Fee has been successfully Submitted");

            Form26 f26 = new Form26();
            this.Hide();
            f26.label6.Text = textBox1.Text.ToString();
            f26.label7.Text = textBox2.Text.ToString();
            f26.label8.Text = textBox3.Text.ToString();
            f26.label9.Text = textBox4.Text.ToString();
            f26.label10.Text = textBox5.Text.ToString();
            int n1 = int.Parse(textBox5.Text);
            int n2 = int.Parse(textBox2.Text);
            int n3 = int.Parse(textBox4.Text);
            f26.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.ShowDialog();
        }
    }
}
