using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
        Form6 f6 = new Form6();
        int attemp = 0;

        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           Form9 f____9 = new Form9();
            f____9.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f___6 = new Form6();
            f___6.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f___5 = new Form5();
            f___5.Show();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f___4 = new Form4();
            f___4.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f___8 = new Form8();
            f___8.Show();
        }
    }
}
