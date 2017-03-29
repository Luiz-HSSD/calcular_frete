using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.br.com.correios.ws;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Frete freteagr = new Frete();
        cResultado resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            freteagr.Comprimento =Convert.ToDecimal(textBox1.Text);
            freteagr.Largura = Convert.ToDecimal(textBox2.Text);
            freteagr.Altura = Convert.ToDecimal(textBox3.Text);
            freteagr.Peso = textBox4.Text;
            freteagr.CEP = textBox5.Text;
            resultado = freteagr.calcular();
            MessageBox.Show("Sedex Varejo \n Preço:" + resultado.Servicos.ElementAt(0).Valor + "\n Prazo em dias:" + resultado.Servicos.ElementAt(0).PrazoEntrega + "\n" + resultado.Servicos.ElementAt(0).MsgErro + "\n Sedex A Cobrar Varejo \n Preço:" + resultado.Servicos.ElementAt(1).Valor + "\n Prazo em dias:" + resultado.Servicos.ElementAt(1).PrazoEntrega + "\n" + resultado.Servicos.ElementAt(1).MsgErro + "\n Sedex 10 Varejo \n Preço:" + resultado.Servicos.ElementAt(2).Valor + "\n Prazo em dias:" + resultado.Servicos.ElementAt(2).PrazoEntrega + "\n" + resultado.Servicos.ElementAt(2).MsgErro + "\nSedex Hoje Varejo \n Preço:" + resultado.Servicos.ElementAt(3).Valor + "\n Prazo em dias:" + resultado.Servicos.ElementAt(3).PrazoEntrega + "\n" + resultado.Servicos.ElementAt(3).MsgErro + "\n PAC Varejo \n Preço:" + resultado.Servicos.ElementAt(4).Valor + "\n Prazo em dias:" + resultado.Servicos.ElementAt(4).PrazoEntrega + "\n" + resultado.Servicos.ElementAt(4).MsgErro);
        }
    }
}
