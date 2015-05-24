using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSGCM.UI
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        double primeiro_numero = 0;
        double calculo = 0;
        double valor_porcento = 0;

        string operacao = "";

        bool cliquei_primeiro_numero = false;
        bool ja_li_virgula = false;
        bool cliquei_botao_operacao = false;
        bool mostrar_calculo = false;

        private void Ler(string numero)
        {
            if (cliquei_botao_operacao == false)
            {
                if (cliquei_primeiro_numero == false)
                {
                    tbxTela.Text = numero;
                    cliquei_primeiro_numero = true;
                }
                else
                {
                    tbxTela.Text += numero;
                }
            }
            else
            {
                tbxTela.Text = numero;
                cliquei_botao_operacao = false;
            }
        }


        private void Botao_Operacao(string qual_operacao)
        {
            cliquei_botao_operacao = true;

            if (mostrar_calculo == true)
                Calcular_Mostrar();

            operacao = qual_operacao;
            primeiro_numero = Convert.ToDouble(tbxTela.Text);
            mostrar_calculo = true;
        }

        private void Calcular_Mostrar()
        {
            if (operacao == "+")
                calculo = primeiro_numero + (Convert.ToDouble(tbxTela.Text));
            else if (operacao == "-")
                calculo = primeiro_numero - (Convert.ToDouble(tbxTela.Text));
            else if (operacao == "*")
                calculo = primeiro_numero * (Convert.ToDouble(tbxTela.Text));
            else if (operacao == "/")
                calculo = primeiro_numero / (Convert.ToDouble(tbxTela.Text));
            //      (operacao == "sqrt")
            //        calculo = primeiro_numero + Convert.ToDouble(tbxTela.Text);
            tbxTela.Text = calculo.ToString();
        }


        private void btn0_Click(object sender, EventArgs e)
        {
            if (tbxTela.Text.Equals("0"))
                Ler("");
            else
                Ler("0");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //Ler o texto do button e insere em btn
            int btn = Convert.ToInt32(((Button)sender).Text);       
  
            if (tbxTela.Text.Equals("0"))
            {
                tbxTela.Text = "";
                Ler(Convert.ToString(btn));
            }
            else
            { Ler(Convert.ToString(btn)); }
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (cliquei_primeiro_numero == false || cliquei_botao_operacao == true)
            {
                Ler("0,");
                ja_li_virgula = true;
            }
            else if (ja_li_virgula == false)
            {
                Ler(",");
                ja_li_virgula = true;
            }
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {
            calculo = -1 * (Convert.ToDouble(tbxTela.Text));
            tbxTela.Text = calculo.ToString();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            Botao_Operacao("+");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            Botao_Operacao("-");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Botao_Operacao("*");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Botao_Operacao("/");
        }

        private void btnIgualdade_Click(object sender, EventArgs e)
        {
            Calcular_Mostrar();
            mostrar_calculo = false;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            calculo = Math.Sqrt(Convert.ToDouble(tbxTela.Text));
            tbxTela.Text = calculo.ToString();
        }

        private void btnInverso_Click(object sender, EventArgs e)
        {
            calculo = 1 / Convert.ToDouble(tbxTela.Text);
            tbxTela.Text = calculo.ToString();
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            valor_porcento = primeiro_numero * (Convert.ToDouble(tbxTela.Text) / 100);
            if (operacao == "+")
                calculo = primeiro_numero + valor_porcento;
            else if (operacao == "-")
                calculo = primeiro_numero - valor_porcento;
            else if (operacao == "*")
                calculo = primeiro_numero * valor_porcento;
            else if (operacao == "/")
                calculo = primeiro_numero / valor_porcento;

            tbxTela.Text = calculo.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            primeiro_numero = 0;
            calculo = 0;
            valor_porcento = 0;
            operacao = "";
            cliquei_primeiro_numero = false;
            ja_li_virgula = false;
            cliquei_botao_operacao = false;
            mostrar_calculo = false;
            tbxTela.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbxTela.Text = "0";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int tamanho = tbxTela.Text.Length;

            if (tamanho > 0)
                tbxTela.Text = tbxTela.Text.Substring(0, tamanho - 1);
        }
    }
}


