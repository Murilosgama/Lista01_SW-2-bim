using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paineldecarro
{
    class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        private int velocidade;

        public int Velocidade
        {
            get { return velocidade; }
            private set { velocidade = value; }
        }

        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
            Velocidade = 0;
        }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Frear()
        {
            Velocidade -= 10;
            if (Velocidade < 0)
            {
                Velocidade = 0;
            }
        }
    }
}