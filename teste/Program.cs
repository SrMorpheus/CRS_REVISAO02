using System;
using System.Text.RegularExpressions;

namespace teste
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            string cpf = "888555588858";


            
         bool  tetste =   Regex.IsMatch(cpf, @"^[0-9](\w)\1");


          

            Console.WriteLine(tetste);

            var Parte01Cpf = cpf.Substring(0, 9);

            var Parte02Cpf = cpf.Substring(9, 2);

            long digitoK = 0;

            long digitoJ = 0;

            long soma = 0;

            int count = 10;

     


            foreach (var x in Parte01Cpf)
            {
             

                soma = (count * (int)char.GetNumericValue(x)) + soma;

                count--;

            }

            var resto = soma % 11;


            if ( resto < 2)
            {

                digitoJ = 0;

            }
            else if (resto >= 2 && resto <= 10)
            {

                digitoJ = 11 - resto;

            }


            Parte01Cpf = Parte01Cpf + digitoJ.ToString();


            count = 11;


            soma = 0;

            foreach (var x in Parte01Cpf)
            {

                soma = (count * (int)char.GetNumericValue(x)) + soma;

                count--;

            }

            


            resto = soma % 11;



            if ( resto < 2)
            {

                digitoK = 0;

            }
            else if (resto >= 2 && resto <= 10)
            {

                digitoK = 11 - resto;

            }


            var digitosFinais = digitoJ.ToString() + digitoK.ToString();

            if( digitosFinais == Parte02Cpf)
            {

                Console.Write("real");

            }
            else
            {

                Console.WriteLine("Não real");

            }


     


        }
    }

}