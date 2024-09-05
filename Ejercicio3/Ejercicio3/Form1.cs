using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2=int.Parse(textBox2.Text);
            int ecu1 = (num1+num2)*(num1-num2);
            label2.Text = ecu1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(textBox1.Text);
            int valor2 = int.Parse(textBox2.Text);
            int ecu2 = (valor1*valor1) - (valor2*valor2);
            label2.Text = ecu2.ToString();
        }
    }
}
