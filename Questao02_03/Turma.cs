using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Questao03
{
    public class Turma : IEquatable<Turma>
    {

        private long _cod;
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


        public List<Aluno> Alunos { get; set; } = new List<Aluno>();


        public Curso Curso { get; private set; }


        public Turma()
        {
            this.Cod = 0;

        }

        public Turma(Curso curso)
        {
            this.Cod = 0;

            this.Curso = curso;



        }



        public void InserirAluno(Aluno aluno)
        {
            var existir = Alunos.Contains(aluno);

            if (existir == true)

            {

                Console.WriteLine("Aluno já está nessa turma");


            }
            else
            {
                Alunos.Add(aluno);
                Console.WriteLine("Cadastrado com Sucesso!");



            }

        }
            public void RemoverAluno(Aluno aluno)
            {
                var existir = Alunos.Contains(aluno);

                if (existir == true)

                {

                    Console.WriteLine("Aluno removido com sucesso!");


                }
                else
                {
                Console.WriteLine("Aluno já não está nessa turma");



            }



            }

            public void ImprimirALunos()
            {

            if (Alunos.Count == 0)
            {

                Console.WriteLine("Sem alunos cadastrados!");


            }

            else
            {


                foreach (var lista in Alunos.OrderBy(x => x.Nome).ToList())
                {
                    Console.WriteLine(lista.DadosAlunos());

                }

            }



            }

        public void ListarALunos()
        {

            if (Alunos.Count == 0)
            {

                Console.WriteLine("Sem alunos cadastrados!");


            }

            else
            {


                foreach (var lista in Alunos.OrderBy(x => x.Nome).ToList())
                {
                    Console.WriteLine(lista.ImprimirAlunos());

                }

            }



        }


        public void ImprimirEstatistica()
            {

            double mediaP1 = 0;

            double mediaP2 = 0;

            double mediaTurma = 0;

            var aluno = Alunos.OrderBy(x => x.NF).Max();




            for (int i = 0; i < Alunos.Count; i ++)
            {

                mediaP1 = Alunos[i].P1 + mediaP1;

                mediaP2 = (Alunos[i].P2 + mediaP2);

                mediaTurma = (Alunos[i].NF + mediaTurma); 



            }





            mediaP1 = mediaP1/Alunos.Count;

            mediaP2 = mediaP2/Alunos.Count ;
            
            mediaTurma = mediaTurma/Alunos.Count;




            Console.WriteLine("As Estatísticas da Turma:");

            Console.WriteLine();

            Console.WriteLine("A média da P1: " + mediaP1.ToString("N2"));
            Console.WriteLine("A média da P2: " + mediaP2.ToString("N2"));
            Console.WriteLine("A média da Turma: " + mediaTurma.ToString("N2"));
            Console.WriteLine("Maior nota da turma: " + Alunos.Max(x => x.NF));
            Console.WriteLine();
            Console.WriteLine("Aluno com maior nota: \n");
            Console.WriteLine(aluno.DadosAlunos());


        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Turma);
        }

        public bool Equals(Turma turmaComparação)
        {

            if (turmaComparação == null)
                return false;

            return this.Cod.Equals(turmaComparação.Cod) &&
         (
             object.ReferenceEquals(this.Cod, turmaComparação.Cod) ||
             this.Cod != null &&
             this.Cod.Equals(turmaComparação.Cod)
         ) &&
         (
             object.ReferenceEquals(this.Curso, turmaComparação.Curso) ||
             this.Curso != null &&
             this.Curso.Equals(turmaComparação.Curso)
         ) &&
         (
          object.ReferenceEquals(this.Alunos, turmaComparação.Alunos) ||
             this.Alunos != null &&
             this.Alunos.Equals(turmaComparação.Alunos)
         );
        }


        public override string ToString()
        {
            return "Turma código: " + this.Cod;
        }

    }
}
