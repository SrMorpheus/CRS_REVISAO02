using System;
using System.Globalization;

namespace Questao05
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Criando seu Carro\n");

            Console.WriteLine("Dados do seu carro\n");

            Console.WriteLine("Placa do seu Carro:");

            var placa = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Modelo do seu Carro:");

            var modelo = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Cilindrada do motor do seu Carro:");

            var Cilindrada = double.Parse(Console.ReadLine(), new CultureInfo("en-US") );

            Console.WriteLine("\n");

            Motor motor = new Motor(Cilindrada);

            Carro carro = new Carro(placa, modelo, motor);


            Console.WriteLine("Informações do seu carro:\n");


            Console.WriteLine(carro.ToString());

            Console.WriteLine();

            Console.WriteLine(carro.VelocidadeMaxima()); 

            







        }
    }
}
