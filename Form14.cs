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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //This is the connection string  assigned to the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=Avanuse_777";
                //This is the insert query puposed to accept input from the user through windows forms
                string Query = "insert into etornam.product(ID,CATEGORY,PRICE,NAME,QUANTITY) values ( '" + this.textBox1.Text +"','" +this.textBox2.Text + "','" + this.textBox3.Text  +"','" + this.textBox4.Text +"','" + this.textBox5.Text + " ' );";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Succesful");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
