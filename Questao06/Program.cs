using System;

namespace Questao06
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Realizando Progessão aritmética e geométrica \n");

            Console.WriteLine("Progessão Aritmética \n");

            Console.WriteLine("Dados para Progessão Aritmética \n");

            Console.WriteLine("Coloque a Posição inicial:");

            var posicaoInicial = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Coloque a Razão:");

            var razao = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Coloque a quantidade de posições:");

            var quanntidade  = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Progessão Geométrica \n");

            Console.WriteLine("Dados para Progessão Geométrica \n");

            Console.WriteLine("Coloque a Posição inicial:");

            var posicaoInicialGeometrica = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Coloque a Razão:");

            var razaoGeometrica = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Coloque a quantidade de posições:");

            var quanntidadeGeometrica = int.Parse(Console.ReadLine());

            Console.WriteLine();


            ProgressaoAritmetica progressaoAritmetica = new ProgressaoAritmetica(posicaoInicial, razao, quanntidade);

            Console.WriteLine("Progessão Aritmética \n");

            progressaoAritmetica.PA();

            Console.WriteLine("\n");

            ProgressaoGeometrica progressaoGeometrica = new ProgressaoGeometrica(posicaoInicialGeometrica, razaoGeometrica, quanntidadeGeometrica);


            Console.WriteLine("Progessão Geométrica \n");

            progressaoGeometrica.PG();

            Console.WriteLine();








        }
    }
}


