using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int suma = numero1 + numero2;
            label2.Text = "La suma es "+suma;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(textBox1.Text);
            int valor2 = int.Parse(textBox2.Text);
            int mul=valor1 * valor2;
            label2.Text = "la multiplicacion es: " + mul;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int div=n1 / n2;
            label2.Text = "la division es: " + div;
        }
    }
}
