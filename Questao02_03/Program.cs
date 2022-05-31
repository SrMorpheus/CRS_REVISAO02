using System;

namespace Questao03
{
        public class Program
    {
        static void Main(string[] args)
        {

            Turma turma = new Turma();

         


            Curso curso = new Curso("Sistema da Informação");

            var turmaTeste = curso.CriarTurma();

            Aluno aluno = new Aluno("Mr Pratik Skaggs.");
            Aluno aluno1 = new Aluno("Mr Pratik Skaggs.");
            Aluno aluno2 = new Aluno("Mr Edison Drye");

            aluno.AssociarTurma(turmaTeste);
            aluno1.AssociarTurma(turmaTeste);
            aluno2.AssociarTurma(turmaTeste);

     

            turmaTeste.InserirAluno(aluno);
            turmaTeste.InserirAluno(aluno1);
            turmaTeste.InserirAluno(aluno2);

            aluno.LancarNota(2.0, 1);
            aluno.LancarNota(7.0, 2);

            aluno1.LancarNota(2.0, 1);
            aluno1.LancarNota(4.0, 2);

            aluno2.LancarNota(2.0, 1);
            aluno2.LancarNota(4.0, 2);


            turmaTeste.ImprimirALunos();

            Console.WriteLine();

            turmaTeste.ImprimirEstatistica();


           


            Aluno aluno3 = new Aluno("Ms Mihoko Scholl");

            Aluno aluno4 = new Aluno("Mr Ajani Harding");

            Aluno aluno5 = new Aluno("Ms Vinaya Justus");


            var turmaTeste2 = curso.CriarTurma();



            turmaTeste2.InserirAluno(aluno3);
            turmaTeste2.InserirAluno(aluno4);
            turmaTeste2.InserirAluno(aluno5);


            aluno3.AssociarTurma(turmaTeste2);
            aluno4.AssociarTurma(turmaTeste2);
            aluno5.AssociarTurma(turmaTeste2);



            curso.ListarTurma();

            Console.WriteLine();

            
            



        }
    }
}
