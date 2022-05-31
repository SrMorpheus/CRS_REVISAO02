using System;

namespace Questao04
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Criando certidão\n");

            Console.WriteLine("Coloque o nome da pessoa da certidão:");

            var nome = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome);

            Console.WriteLine();
            CertidaoNascimento certidaoNascimento = new CertidaoNascimento(DateTime.Now, pessoa);

            Console.WriteLine();
            Console.WriteLine(certidaoNascimento.ToString());

            





        }
    }
}
