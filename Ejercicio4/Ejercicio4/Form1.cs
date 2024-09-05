using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vocal = (textBox1.Text);
            string a = "a";
            string ee = "e";
            string i = "i";
            string o= "o";
            string u = "u";


            if (vocal==a ||vocal==ee||vocal==i||vocal==o||vocal==u )
            {
                label2.Text = "Es vocal";
            }
            else 
            {
                label2.Text ="No es vocal";
            }
        }
    }
}
