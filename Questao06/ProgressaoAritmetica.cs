using System;
using System.Collections.Generic;
using System.Text;

namespace Questao06
{
    public class ProgressaoAritmetica : Progressao
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



        public ProgressaoAritmetica(int primeiro, int razao, int quantidade) : base(primeiro, razao)
        {



            this.Quantidade = quantidade;

        }


        public override int TermoAt(int posicao)
        {

            var termo = Primeiro + (posicao - 1) * Razao;

            return termo;

        }





        public void PA()

        {
            for (int i = 1; i < (Quantidade + 1); i++)
            {

                Console.Write(TermoAt(i) + " ");

            }



        }

        public override void Reinicializar()
        {
            _inicilizador = 0;


        }
    }
}
