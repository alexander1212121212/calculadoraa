using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_CSharp
{
    public partial class Form1 : Form
    {
        Double valor_final;
        Double conta;
        String operador;

        private void Limpar()
        {
            conta = 0;
            valor_final = 0;
            operador = "+";
            ContaF.Text = "0";
        }
        private void Calcular()
        {
            switch (operador)
            {
                case "+":
                    conta = conta + valor_final;
                    break;
                case "-":
                    conta = conta - valor_final;
                    break;
                case "*":
                    conta = conta * valor_final;
                    break;
                case "/":
                    conta = conta / valor_final;
                    break;
            }
            ContaF.Text = conta.ToString();
            valor_final = 0;
        }
        public Form1()
        {
            InitializeComponent();
            Limpar();
        }

        public void BotaodeLimpar(object sender, EventArgs e)
        {
            Limpar();
        }

        
        private void BotaoNumero(object sender, EventArgs e)
        {
            if (valor_final == 0)
            {
                ContaF.Text = (sender as Button).Text;
            }
            else
            {
                ContaF.Text = ContaF.Text + (sender as Button).Text;
                }
            valor_final = Convert.ToDouble(ContaF.Text);
        }

        private void Operacao(object sender, EventArgs e)
        {
            valor_final = Convert.ToDouble(ContaF.Text);
            Calcular();
            operador = (sender as Button).Text;
        } 

        private void BotaoResultadoFinal(object sender, EventArgs e)
        {
            valor_final = valor_final = Convert.ToDouble(ContaF.Text);
            Calcular();
            operador = "0";
            conta = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

