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
    public partial class Mdiform : Form
    {
        public Mdiform()
        {
            InitializeComponent();
        }

        private void Mdiform_Load(object sender, EventArgs e)
        {

        }

        private void employeeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form2 form=new Form2();
            form.MdiParent=this;
            form.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepad obj= new notepad();  
            obj.MdiParent=this;
            obj.Show();

        }
    }
}
