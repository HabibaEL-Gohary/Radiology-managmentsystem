using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            Close();        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f__ = new Home();
            f__.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Databsesystem' table. You can move, or remove it, as needed.
            this.databsesystemTableAdapter.Fill(this.database1DataSet.Databsesystem);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
