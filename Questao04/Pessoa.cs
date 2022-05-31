using System;
using System.Collections.Generic;
using System.Text;

namespace Questao04
{
    public class Pessoa
    {

        public string Nome { get; private set; }

        public CertidaoNascimento Certidao { get; private set; }


        public Pessoa(string nome)
        {

            this.Nome = nome;


        }

        

        public void AdicionarCertidao(CertidaoNascimento certidao)
        {

            if (this.Certidao == null)
            {

                this.Certidao = certidao;
                Console.WriteLine("Certidão adicicionada com sucesso!");

            }
            else
            {

                Console.WriteLine("Já existe uma certidão associada essa pessoa!");

            }

        }


        public override string ToString()
        {
            return "Nome: " + this.Nome;
        }
    }
}
