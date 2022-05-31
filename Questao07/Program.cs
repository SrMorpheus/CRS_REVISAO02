using System;
using System.IO;

namespace Questao07
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            { 


                Console.WriteLine("Coloque o caminho do seu arquivo:");
                
                var caminho = Console.ReadLine();
          


                Propriedades propriedades = new Propriedades(@caminho);



                Console.WriteLine("Escolha a opção que deseja:\n");

                Console.WriteLine("1:Incluir uma nova\n");

                Console.WriteLine("2:Alterar o Valor de uma chave :\n");

                Console.WriteLine("3:Recuperar o valor de uma chave:\n");

                Console.WriteLine("4:verificar se uma chave existe ou não:\n");

                Console.WriteLine("5:Salvar as propriedades :\n");

                Console.WriteLine("0:Sair:\n");

                var opcao = Console.ReadLine();

                do
                {

                    switch(opcao)
                    {

                        case "1":
                         Console.WriteLine();

                         Console.WriteLine("Coloque a nova chave:");
                         var chave = Console.ReadLine();

                         Console.WriteLine();

                         Console.WriteLine("Coloque o novo valor:");
                         var valor = Console.ReadLine();

                         Console.WriteLine();
                         propriedades.IncluirChave(chave, valor);
                         Console.WriteLine();



                            break;

                        case "2":

                            Console.WriteLine();
                            Console.WriteLine("Coloque a chave:");
                            chave = Console.ReadLine();

                            Console.WriteLine();

                            Console.WriteLine("Coloque o novo valor:");
                            valor = Console.ReadLine();

                            Console.WriteLine();
                            propriedades.AlterarValor(chave, valor);
                            Console.WriteLine();



                            break;

                            case "3":

                            Console.WriteLine();
                            Console.WriteLine("Coloque a chave:");
                            chave = Console.ReadLine();

                            Console.WriteLine();

                          


                            valor = propriedades.RecuperarValor(chave);

                            Console.WriteLine("o valor é: " + valor);
                            Console.WriteLine();

                            break;

                             case "4":

                            Console.WriteLine();
                            Console.WriteLine("Coloque a chave:");
                            chave = Console.ReadLine();

                            Console.WriteLine();



                            Console.WriteLine();
                            propriedades.VerificarChave(chave);

                            Console.WriteLine();


                            break;

                            case "5":

                            Console.WriteLine();
                            Console.WriteLine("Salvando......");

                            propriedades.SalvarPropriedade();
                            Console.WriteLine("Salvo!!");

                            Console.WriteLine();



                            break;

                            case "0":
                            Console.WriteLine();
                            Console.WriteLine("Saindo.....");
                            Console.WriteLine();



                            break;

                            default:
                            Console.WriteLine();

                            Console.WriteLine("Opção Inválida");

                            Console.WriteLine();

                            break;


                    }



                    Console.WriteLine("Escolha a opção que deseja:\n");

                    Console.WriteLine("1:Incluir uma nova\n");

                    Console.WriteLine("2:Alterar o Valor de uma chave :\n");

                    Console.WriteLine("3:Recuperar o valor de uma chave:\n");

                    Console.WriteLine("4:verificar se uma chave existe ou não:\n");

                    Console.WriteLine("5:Salvar as propriedades :\n");

                    Console.WriteLine("0:Sair:\n");

                    opcao = Console.ReadLine();




                } while (opcao != "0");







            }
            catch (Exception e)
            {

                Console.WriteLine("error: " + e);

            }

        }
    }
}
