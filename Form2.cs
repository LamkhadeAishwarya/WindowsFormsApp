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
    public partial class Form2 : Form
    {
        List<string> dept = new List<string>()
        {
            "hra","development","testing"
        };
        public Form2()
        {
            InitializeComponent();
        }

        private void textEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxDepartment.DataSource = dept;   
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
           
        }

        private void labeLGross_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double bs = Convert.ToDouble(textsalary.Text);
            double hra = bs * 45;
            double da = bs * 67.7;
            double ta = bs * 45.6;
            double pf = bs * 56.7;
            double gross = (hra + da + ta + bs) - pf;
            textHRA.Text = hra.ToString();
            textDA.Text =da. ToString();
            textTA.Text = ta.ToString();
            textPF.Text = pf.ToString();
            textgross.Text =gross. ToString();



        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string msg=textEmpid.Text+""+textEmp_name.Text+""+comboBoxDepartment.Text+""+textgross.Text;
            lbltynhg.Text = msg;
        }
    }
}
