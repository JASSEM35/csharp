using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            Class1 newName = new Class1("jassem");
            
            MessageBox.Show(newName.FirstName);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
