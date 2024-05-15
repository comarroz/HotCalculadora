using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BotoesCalculadora
{
    public partial class HotCalculadora : Form
    {
        public decimal Mostrar { get; set; }

        public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }

        private  enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
            

        }
        public HotCalculadora()
        {
            InitializeComponent();
        }

        

        private void Menos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(Resultado.Text);
            Resultado.Text = "";

            

        }//Fim do Input Menos 

        private void Mais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(Resultado.Text);
             Resultado.Text = "";
           

        }// fim do input Mais

        private void Limpar_Click(object sender, EventArgs e)
        {

        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {

            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(Resultado.Text);
            Resultado.Text ="";
           

        }//Fim do Input Multiplicar 

        private void Igual_Click(object sender, EventArgs e)
        {
            Resultado.Text += "=";


        }//Fim do Input Igual 

        private void button1_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Mostrar = Valor + Convert.ToDecimal(Resultado.Text);
                    break; 
                case Operacao.Subtracao:
                    Mostrar = Valor - Convert.ToDecimal(Resultado.Text);

                    break;
                case Operacao.Multiplicacao:
                    Mostrar = Valor * Convert.ToDecimal(Resultado.Text);

                    break;
                case Operacao.Divisao:
                    Mostrar = Valor / Convert.ToDecimal(Resultado.Text);

                    break;


            }// fim do Switch
              Resultado.Text = Convert.ToString(Valor);
           
        }// Fim do Input Zero

        private void Um_Click(object sender, EventArgs e)
        {
            Resultado.Text += "1";

        }//Fim do Input 1

        private void Cinco_Click(object sender, EventArgs e)
        {
            Resultado.Text += "5";

        }

        private void Seis_Click(object sender, EventArgs e)
        {
            Resultado.Text += "6";

        }//Fim do Input 6

        private void Novo_Click(object sender, EventArgs e)
        {
            Resultado.Text += "9";

        }//Fim do input 9

        private void Oito_Click(object sender, EventArgs e)
        {
            Resultado.Text += "8";

        }//Fim do Input 8

        private void Sete_Click(object sender, EventArgs e)
        {
            Resultado.Text += "7";

        }// Fim do input 7

        private void Resultado_TextChanged(object sender, EventArgs e)
        {
            //return Resultado;

        }

        private void Dois_Click(object sender, EventArgs e)
        {
            Resultado.Text += "2";
        }//Fim do Input 2

        private void Tres_Click(object sender, EventArgs e)
        {
            Resultado.Text += "3";
        }//fim do Input 3

        private void Quatro_Click(object sender, EventArgs e)
        {
            Resultado.Text += "4";

        }//Fim do Input 4

        private void Divisão_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(Resultado.Text);
            Resultado.Text = "";
            


        }//fim da divisão
    }
}
