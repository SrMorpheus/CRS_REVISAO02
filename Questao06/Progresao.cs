using System;
using System.Collections.Generic;
using System.Text;

namespace Questao06
{
    public abstract class Progressao
    {

        public int Primeiro { get; set; }

        public int Razao { get; set; }

        public abstract int ProximoValor
        {

            get;

        }


        public Progressao(int primeiro, int razao)

        {


            this.Primeiro = primeiro;

            this.Razao = razao;

        }

        public abstract int TermoAt(int posicao);

        public abstract void Reinicializar();




    }
}