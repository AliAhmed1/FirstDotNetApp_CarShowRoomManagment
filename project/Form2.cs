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
    public partial class Form2 : Form
    {
        public static string passingtext;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.database1DataSet.table1);

        }

        private void table1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Are you Sure you want to Buy this Car?";
            string title = "Buy Car";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No)
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else
            {
                Form3 frm = new Form3(car_TextBox.Text, manufacture_yearTextBox.Text, companyTextBox.Text, priceTextBox.Text);
                frm.Show();
                this.Hide();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
