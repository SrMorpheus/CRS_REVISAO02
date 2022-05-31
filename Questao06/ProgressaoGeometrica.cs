using System;
using System.Collections.Generic;
using System.Text;

namespace Questao06
{
    public class ProgressaoGeometrica : Progressao
    {
        private int _inicilizador;

      

        public override int ProximoValor
        {

            get
            {

                _inicilizador++;

                return TermoAt(_inicilizador);

            }


        }

        public int Quantidade { get; private set; }


        public ProgressaoGeometrica(int primeiro, int razao, int quantidade) : base(primeiro, razao)
        {
            
            this.Quantidade = quantidade;

        }



        public override void Reinicializar()
        {

            _inicilizador = 0;

        }

        public override int TermoAt(int posicao)
        {

            var termo = Primeiro * (int) Math.Pow(Razao, posicao - 1);

            return termo;

        } 

        public void PG()
        {
            for (int i = 1; i < (Quantidade + 1); i++)
            {
                Console.Write(TermoAt(i) + " ");

            }


        }

    }  
}
