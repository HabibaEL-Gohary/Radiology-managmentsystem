using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        string connectingString = @"Data Source=DESKTOP-98DUSF1;Initial Catalog=R_System;Integrated Security=True";
        public Form3(String username)
        {
            InitializeComponent();
            label3.Text = username;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Databsesystem' table. You can move, or remove it, as needed.
            this.databsesystemTableAdapter.Fill(this.database1DataSet.Databsesystem);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f__3_ = new Home();
            f__3_.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void databsesystemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectingString)) 
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Select * from P_", sqlcon);
                DataTable dtb = new DataTable();
                sqlda.Fill(dtb);

                GVDATA.DataSource = dtb;



            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
