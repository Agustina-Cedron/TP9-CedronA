using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tamaño = int.Parse(textBox1.Text);
            double tamañoMb= tamaño * 1000;
          
            double tamañof = tamañoMb / 700;
            
            label2.Text = "El numero necesario es: " + Math.Ceiling(tamañof);
        }
    }
}
