using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tabuada, resultado;
            tabuada = double.Parse(textBox1.Text);
            for (int i = 0; i <= 100; i++)
            {
                resultado = tabuada * i;
                listBox1.Items.Add(tabuada + " x " + i + " = " + resultado);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            textBox1.Focus();
        }
    }
}
