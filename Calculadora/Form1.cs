using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtValor1.Text);
            double valor2 = Convert.ToDouble(txtValor2.Text);
            
            double resultado = valor1 + valor2;

            lblResultado.Text = Convert.ToString(resultado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtValor1.Text);
            double valor2 = Convert.ToDouble(txtValor2.Text);

            double resultado = valor1 - valor2;

            lblResultado.Text = Convert.ToString(resultado);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtValor1.Text);
            double valor2 = Convert.ToDouble(txtValor2.Text);

            double resultado = valor1 * valor2;

            lblResultado.Text = Convert.ToString(resultado);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtValor1.Text);
            double valor2 = Convert.ToDouble(txtValor2.Text);

            double resultado = valor1 / valor2;

            lblResultado.Text = Convert.ToString(resultado);
        }
    }
}
