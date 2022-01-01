using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void databsesystemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.databsesystemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Databsesystem' table. You can move, or remove it, as needed.
            this.databsesystemTableAdapter.Fill(this.database1DataSet.Databsesystem);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f__2 = new Home();
            f__2.Show();
        }
    }
}
