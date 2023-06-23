using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGeradorLoterias.Formularios
{
    public partial class FormLotoFacil : Form
    {
        public List<int> NumeroDaSorte = new List<int>();

        public FormLotoFacil()
        {
            InitializeComponent();
        }

        private void Comparacao(int par, int impar)
        {
            lbPar.Text = "PARES: " + par;
            lbImpar.Text = "ÍMPARES: " + impar;
            if (impar == 8 && par == 7) { lbClass.Text = "MUITO ALTO!"; lbClass.ForeColor = Color.Green; }// Fim do if
            if (impar == 7 && par == 8) { lbClass.Text = "ALTO!"; lbClass.ForeColor = Color.Green; }// Fim do if
            if (impar == 9 && par == 6) { lbClass.Text = "MÉDIO!"; lbClass.ForeColor = Color.Orange; }// Fim do if
            if (impar == 6 && par == 9) { lbClass.Text = "BAIXO!"; lbClass.ForeColor = Color.Red; }// Fim do if
            if (impar == 5 && par == 10) { lbClass.Text = "MUITO BAIXO"; lbClass.ForeColor = Color.Red; }// Fim do if
            if (impar == 10 && par == 5) { lbClass.Text = "MUITO BAIXO"; lbClass.ForeColor = Color.Red; }// Fim do if
        }//Fim da Função

        public void GerarNumeros()
        {
            int numero = 0;
            int cont = 0;
            int qtdpar = 0;//quantidade de núemro pares
            int qtdimpar = 0;//qauntidade de números ímpares
            Random radNum = new Random();//Obj para gerar números aleatórios
            NumeroDaSorte.Clear();

            while (cont < 15)
            {
                numero = radNum.Next(1 , 26);//números aleatórios nesse raio
                if (!NumeroDaSorte.Contains(numero))
                {
                    NumeroDaSorte.Add(numero);
                    if (numero % 2 ==  0) qtdpar++;
                    if (numero % 2 == 1) qtdimpar++;
                    cont++;
                }//Fim o if
            }//Fim do laço
            NumeroDaSorte = NumeroDaSorte.OrderBy(num => num).ToList();//Colocar em ordem crescente
            Comparacao(qtdpar, qtdimpar);
            dtvNumeros.DataSource = NumeroDaSorte.Select(Numeros => new { numero = Numeros }).ToList();
            //Colocar os números no GRID (Tabela)
        }//Fim da função

        public void LimparTabela()
        {
            NumeroDaSorte.Clear();
            dtvNumeros.DataSource = NumeroDaSorte.Select(Numeros => new {Numero = Numeros}).ToList();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparTabela();
            lbClass.Text = "CLASSIFICAÇÃO";
            lbPar.Text = "PARES";
            lbImpar.Text = "ÍMPARES";
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            GerarNumeros();
        }
    }
}
