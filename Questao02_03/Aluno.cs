using System;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Questao03
{
    public class Aluno : IEquatable<Aluno> , IComparable<Aluno>
    {
        private string _nome;

        private long _cod;

        private string _matricula;

        private Turma _turma;

        private Curso _curso;


        public long Cod
        {
            get
            {

                return _cod;

            }
            private set
            {

                var inicio = new Random().Next(1, 782121554);

                var fim = new Random().Next(782121555, 999999999);

                var gerador = new Random().Next(inicio, fim);

                _cod = gerador;




            }
        }



        public string Nome
        {

            get
            {

                return _nome;

            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nome = value;

                }
                else
                {

                    Console.WriteLine("O nome é obrigatório.");


                }

            }



        }

        public string Matricula
        {
            get
            {

                return _matricula;

            }

            private set
            {


                var gerador = DateTime.Now.Year.ToString() + Cod.ToString("D5").Substring(1, 4) + (DateTime.Now.Day + DateTime.Now.Year + DateTime.Now.Month).ToString();

                _matricula = gerador;

            }


        }


        public double P1 { get; private set; }

        public double P2 { get; private set; }

        public double NF
        {
            get
            {

                return (P1 + P2) / 2;

            }
            private set
            {

            }
        }

        public Turma Turma {

            get
            {

                return _turma;

            }



            private set
            {

                _turma = value;


            }
            
        }

        public Curso Curso
        {

            get
            {

                return _curso;

            }



            private set
            {

                _curso = value;


            }

        }




        public Aluno (string nome)
        {
            this.Nome = nome;
            
            this.Cod = 0;

            this.Matricula = null;


        }

        public Aluno(string nome, Turma turma)
        {
            this.Nome = nome;

            this.Cod = 0;

            this.Matricula = null;

            this.Turma = turma;


        }


        public Aluno(string nome, Turma turma, Curso curso)
        {
            this.Nome = nome;

            this.Cod = 0;

            this.Matricula = null;

            this.Turma = turma;
            
            this.Curso = curso;

        }

        public void LancarNota(double nota , int opcao)
        {

            if(opcao == 1)
            {
                if(this.P1 == 0)
                {

                    this.P1 = nota;

                    Console.WriteLine("P1 lançada com sucesso!");

                }
                else
                {


                    Console.WriteLine("Ja existe uma P1 lançada para esse aluno que é: " + this.P1);
                }

            }

            else if (opcao == 2)
            {
                if (this.P2 == 0)
                {

                    this.P2 = nota;

                    Console.WriteLine("P2 lançada com sucesso!");

                }
                else
                {


                    Console.WriteLine("Ja existe uma P1 lançada para esse aluno que é: " + this.P2);
                }

            }
            else
            {
                Console.WriteLine("Opção desconhecida!");


            }





        }

        


        public string DadosAlunos()
        {

            return "Matrícula: " + this.Matricula + "\n" +
                   "Nome: " + this.Nome + "\n" +
                   "P1: " + this.P1.ToString("N2") + "\n" +
                   "P2: " + this.P2.ToString("N2") + "\n" +
                   "Nota Final: " + this.NF.ToString("N2") + "\n";

        }

        public string ImprimirAlunos()
        {

            return "Matrícula: " + this.Matricula + "\n" +
                   "Nome: " + this.Nome + "\n";
               
        }

        public void AssociarTurma( Turma turma)
        {

            this.Turma = turma;

        }




        public override bool Equals(object obj)
        {
            return this.Equals(obj as Aluno);
        }

        public bool Equals( Aluno alunosComparacao)
        {

            if (alunosComparacao == null)
                return false;

            return this.Nome.Equals(alunosComparacao.Nome) &&
         (
             object.ReferenceEquals(this.Nome, alunosComparacao.Nome) ||
             this.Nome != null &&
             this.Nome.Equals(alunosComparacao.Nome)
         ) &&
         (
             object.ReferenceEquals(this.Matricula, alunosComparacao.Matricula) ||
             this.Matricula != null &&
             this.Matricula.Equals(alunosComparacao.Matricula)
         ) &&
         (
          object.ReferenceEquals(this.Cod, alunosComparacao.Cod) ||
             this.Cod != null &&
             this.Cod.Equals(alunosComparacao.Cod)
         );
        }

        public int CompareTo(Aluno alunosComparacao)
        {


            if (this.NF == alunosComparacao.NF)
            {

                if (this.P1 == alunosComparacao.P1)
                {
                    return this.P2.CompareTo(alunosComparacao.P2);
                }
                
                else
                {

                    return this.P1.CompareTo(alunosComparacao.P1);

                }


                    
            }

            return this.NF.CompareTo(alunosComparacao.NF);

        }




    }

}
