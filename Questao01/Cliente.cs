using System;
using System.Collections.Generic;
using System.Text;

namespace Questao07
{
    public class Cliente
    {
        public string Nome { get; set; }

        public long CPF { get; set; }

        public DateTime DataNascimento { get; set; }
        
        public float RendaMensal { get; set; }

        public char EstadoCivil { get; set; }

        public int Dependentes { get; set; }

        public Cliente(string nome, long cpf, DateTime dataNascimento, float RendaMensal, Char estadoCivil, int dependentes)

        {
            this.Nome = nome;
            
            this.CPF = cpf;

            this.DataNascimento = dataNascimento;

            this.RendaMensal = RendaMensal;

            this.EstadoCivil = estadoCivil;

            this.Dependentes = dependentes;




        }


     


        public override string ToString()
        {
            return "Nome:" + " " + Nome + "\n" +
                   "CPF:" + " " + CPF.ToString("D11") + "\n" +
                   "Data de nascimento :" + " " + DataNascimento.ToString("dd/MM/yyyy") + "\n" +
                   "Renda Mensal:" + " " + RendaMensal.ToString("F") + "\n" +
                   "Estado Civil:" + " " + EstadoCivil + "\n" +
                   "Dependentes:" + " " + Dependentes + "\n";



        }


    }
}
