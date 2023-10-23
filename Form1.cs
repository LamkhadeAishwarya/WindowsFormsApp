using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2Password_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && textpassword.Text == "admin")
            {
                MessageBox.Show("Login Successfully");
               Mdiform obj = new Mdiform();
                obj.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Login Cancel");
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();

            textpassword.Clear();

        }
    }
}
