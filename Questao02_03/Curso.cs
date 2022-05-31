using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questao03
{
    public class Curso
    {
        private string _nome;

        public string Nome
        {

            get
            {

                return _nome;

            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {

                    Console.WriteLine("O nome é obrigatório.");

                }
                else
                {

                    _nome = value;

                }

            }
        }

        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();

        public List<Turma> Turmas { get; private set; } = new List<Turma> { };

        public Curso(string nome)
        {
            
            this.Nome = nome;

            
        }


        public void MatricularAluno( Aluno aluno)
        {
            var existir = Alunos.Contains(aluno);

            if(existir == true)
            {

                Console.WriteLine("Esse aluno já está nesse curso!");

            }
            else
            {

                Alunos.Add(aluno);

                Console.WriteLine("Aluno adicionado no curso com sucesso!");

            }




        }


        public void RemoverAluno (Aluno aluno)
        {

            if(aluno.Turma == null)
            {
                var existir = Alunos.Contains(aluno);
                
                if(existir == true)
                {
                    
                    Alunos.Remove(aluno);

                    Console.WriteLine("Aluno removido com sucesso!");


                }else
                {
                    Console.WriteLine("Esse aluno não existe nesse curso!");


                }



            }
            else
            {
                Console.WriteLine("Esse aluno está associado a uma turma");


            }



        }



        public Turma CriarTurma()
        {
                
            Turma turma = new Turma(this);

            Turmas.Add(turma);

            return turma;


        }


        public void RemoverTurma(Turma turma)
        {

            var existir = Turmas.Contains(turma);

            if( existir == true)
               {

                if(turma.Alunos.Count == 0)
                {
                    Turmas.Remove(turma);

                    Console.WriteLine("Turma Removida com sucesso!");


                }
                else
                {

                    Console.WriteLine("Turma com alunos!");

                }
            
                }
                 else
                 {

                    Console.WriteLine("Turma não existe!");

                 }
                
                
           

        }


        public void ListarTurmaEspecifca (long cod)
        {

            var existir = Turmas.Exists(x => x.Cod == cod);

            if(existir == true)
            {

                var listaTurma = Turmas.Find( x=> x.Cod == cod);

                Console.WriteLine("Alunos da Turma com código: " + cod);
                Console.WriteLine();

                listaTurma.ListarALunos();




            }else

            {
                Console.WriteLine("Turma não existe!");


            }



           




        }

        public void ListarTurma()
        {
            var existir = Turmas.Exists(x => x.Alunos.Count != 0);

            

            if(existir == true)

            {
                var listarTurma = Turmas.FindAll(x => x.Alunos.Count != 0);

                Console.WriteLine();

                Console.WriteLine("Turmas do curso " + this.Nome);

                Console.WriteLine();

                foreach (var turma in listarTurma.OrderBy(x => x.Cod).ToList())
                {

                    Console.WriteLine(turma);

                    var listaTurmaAlunos = Turmas.Find(x => x.Cod == turma.Cod);

                    Console.WriteLine();

                    Console.WriteLine("Alunos da Turma com código: " + turma.Cod);

                    Console.WriteLine();

                    listaTurmaAlunos.ListarALunos();



                }




            }

        




        }




    }
}
