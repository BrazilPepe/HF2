using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF2_2
{
    

    public partial class Form2 : Form
    {
        public String szoveg;

        public Form2(String pszoveg)
        {
            InitializeComponent();

            szoveg = pszoveg;

            Text = szoveg;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            if (PS.Prime(szam) &= true)
            {
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
