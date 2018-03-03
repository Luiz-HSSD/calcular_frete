using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.br.com.correios.ws;

namespace WindowsFormsApplication1
{
    public class Frete
    {
        public Frete() 
        {
            ws = new CalcPrecoPrazoWS();
        }
        private CalcPrecoPrazoWS ws;
        private decimal comprimento;
        public decimal Comprimento
        {
            get { return comprimento; }
            set { comprimento = value; }
        }
        private decimal altura;
        public decimal Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        private decimal largura;
        public decimal Largura
        {
            get { return largura; }
            set { largura = value; }
        }
        private string peso;
        public string Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        private string cep;
        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }
        public cResultado calcular() 
        {
            return ws.CalcPrecoPrazo("", "", "40010 , 40045 , 40215 , 40290 , 41106", "08563010", CEP, Peso, 1, Comprimento, Altura, Largura, 0, "N", 18.5m, "S");
        } 
    }
}
