using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1cd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||) 
            {
                MessageBox.Show("Töltsön ki minden mezőt!");
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int év)|| év < 1989)
            
            {
                MessageBox.Show("Hiba! Az évszám nem megfelelő!");
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
