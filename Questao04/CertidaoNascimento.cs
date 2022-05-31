using System;
using System.Collections.Generic;
using System.Text;

namespace Questao04
{
    public class CertidaoNascimento
    {

        public DateTime dataEmissao { get; private set; }

        public Pessoa Pessoa { get; private set; }

        public CertidaoNascimento(DateTime DataEmissao, Pessoa pessoa)
        {

            this.dataEmissao = DataEmissao;
            this.Pessoa = pessoa;

            pessoa.AdicionarCertidao(this);
           

        }

        public override string ToString()
        {

            return "Data de Emissão: " + this.dataEmissao + " \n" +
                    Pessoa.ToString();

        }


    }
}
