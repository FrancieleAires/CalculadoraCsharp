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


namespace CalculadoraCsharp
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = lblOperacao.Text += "7";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = lblOperacao.Text +=  "0"; 

        }

        private void button11_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = lblOperacao.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = lblOperacao.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = lblOperacao.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = lblOperacao.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = lblOperacao.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = lblOperacao.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = lblOperacao.Text += "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = lblOperacao.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = lblOperacao.Text += ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(lblOperacao.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
               lblOperacao.Text = Convert.ToString(valor1 + valor2);
                
            }
            else if (operacao == "DIV")
            {
                lblOperacao.Text = Convert.ToString(valor1 / valor2);
            }
            else if (operacao == "SUB")
            {
                lblOperacao.Text = Convert.ToString(valor1 - valor2);
            }
            else 
            {
                lblOperacao.Text = Convert.ToString(valor1 * valor2);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "")
            {
                valor1 = decimal.Parse(lblOperacao.Text, CultureInfo.InvariantCulture);

            lblOperacao.Text = "";
            operacao = "SUB";
            }
            else
            {
                MessageBox.Show("Por favor, informe um valor para efetuar a subtração: ");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "")
            {
                valor1 = decimal.Parse(lblOperacao.Text, CultureInfo.InvariantCulture);

            lblOperacao.Text = "";
            operacao = "MULT";
            }
            else
            {
                MessageBox.Show("Por favor, informe um valor para efetuar a multiplicação: ");
            }
}

        private void button18_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "")
            {
                valor1 = decimal.Parse(lblOperacao.Text, CultureInfo.InvariantCulture);

            lblOperacao.Text = "";
            operacao = "DIV";
            }
            else
            {
                MessageBox.Show("Por favor, informe um valor para efetuar a divisão: ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = ""; 
        }

        private void button8_Click(object sender, EventArgs e)
        {

            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (lblOperacao.Text != "")
            {
                valor1 = decimal.Parse(lblOperacao.Text, CultureInfo.InvariantCulture);

                lblOperacao.Text = "";
                operacao = "SOMA";

            }
            else
            {
                MessageBox.Show("Por favor, informe um valor para efetuar a soma: ");
            }

        }
    }
}
