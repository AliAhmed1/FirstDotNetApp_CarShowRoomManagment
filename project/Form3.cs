using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class Form3 : Form
    {
        public Form3(string value, string value2, string value3, string value4)
        {
            InitializeComponent();
            textBox1.Text = value;
            textBox2.Text = value2;
            textBox3.Text = value3;
            textBox4.Text = value4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
    }
}
