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

        private void cmd_calcular_Click(object sender, EventArgs e)
        {
            //executa o calculo
            int parcela1;
            int parcela2;
            string operacao;
            int resultado = -11111111;

            string algoritmo = txt_operacao.Text;
            string sinais = "+-*/";
            int idenx = 0;

            foreach (var c in algoritmo)
            {
                foreach (var s in sinais)
                {
                    if (c == s)
                    {
                        //define os 3 elementos da operaçao
                        parcela1 = int.Parse(algoritmo.Substring(0, idenx));
                        //sinal da operacao
                        operacao = c.ToString();

                        parcela2 = int.Parse(algoritmo.Substring(idenx + 1));

                        //analise de operacao
                        switch (operacao)
                        {
                            case "+":
                                //adicao
                                resultado = parcela1 + parcela2;
                                break;
                            case "-":
                                //subtração
                                resultado = parcela1 - parcela2;
                                break;
                            case "*":
                                //multiplicação
                                resultado = parcela1 * parcela2;
                                break;
                            case "/":
                                //divisao
                                resultado = parcela1 / parcela2;
                                break;
                        }
                        break;
                    }
                }
                if (resultado != -11111111)
                    break;

                idenx++;
            }
            //mostra resultado
            if (resultado == -11111111)
                MessageBox.Show("Erro na operação");
            else
            {
                MessageBox.Show(algoritmo + " = " + resultado);
            }
            

            //limpa a textbox
            txt_operacao.Text = "";
            txt_operacao.Focus();
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            //encerra a aplicaçao
            Application.Exit();
        }

        private void txt_operacao_KeyDown(object sender, KeyEventArgs e)
        {
            //ao clicar em retornar realiza operacao, exeto se nao existir texto

            if (txt_operacao.Text == "") return;

            if (e.KeyCode == Keys.Return)
                cmd_calcular_Click(cmd_calcular, EventArgs.Empty);
            else if (e.KeyCode == Keys.Escape)
            {
                txt_operacao.Text = "";
                txt_operacao.Focus();
            }
        }
    }
}
