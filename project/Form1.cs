using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username, password;
            username = ID.Text;
            password = Password.Text;


            if (username == "admin" && password == "abc123")
            {
                MessageBox.Show("You are logged in");
                Form2 newform = new Form2();
                newform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Input");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
        }    
    }
}
