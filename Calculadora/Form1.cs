using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal primeiroValor = 0;
        decimal segundoValor = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textoResultado.Text +=  "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textoResultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textoResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textoResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textoResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textoResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textoResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textoResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textoResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textoResultado.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textoResultado.Text += ".";
        }


        private void button14_Click(object sender, EventArgs e)
        {

            segundoValor = decimal.Parse(textoResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
              textoResultado.Text = Convert.ToString(primeiroValor + segundoValor);
            }
            else if (operacao == "SUBTRACAO")
            {
                textoResultado.Text = Convert.ToString(primeiroValor - segundoValor);
            }
            else if (operacao == "MULTIPLICACAO")
            {
                textoResultado.Text = Convert.ToString(primeiroValor * segundoValor);
            }
            else
            {
                textoResultado.Text = Convert.ToString(primeiroValor / segundoValor);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (textoResultado.Text != "")
            {
                primeiroValor = decimal.Parse(textoResultado.Text, CultureInfo.InvariantCulture);

                operacao = "SOMA";
                labelOperacao.Text = "+";
                textoResultado.Text = "";
            }
            else
            {
                MessageBox.Show("Informe um valor para continuar a operação!");
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            primeiroValor = decimal.Parse(textoResultado.Text, CultureInfo.InvariantCulture);

            operacao = "SUBTRACAO";
            labelOperacao.Text = "-";
            textoResultado.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            primeiroValor = decimal.Parse(textoResultado.Text, CultureInfo.InvariantCulture);

            operacao = "MULTIPLICACAO";
            labelOperacao.Text = "x";
            textoResultado.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            primeiroValor = decimal.Parse(textoResultado.Text, CultureInfo.InvariantCulture);

            operacao = "DIVISAO";
            labelOperacao.Text = "/";
            textoResultado.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textoResultado.Text = "";
            primeiroValor = 0;
            segundoValor = 0;
            labelOperacao.Text = "";
        }
    }
}
