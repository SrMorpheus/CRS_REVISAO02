using Questao07;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Questao01
{
    public class View
    {

       private Validador _validador = new Validador() ;

        public bool NomeView(out string nomeRetorno)
        {
            

            Console.WriteLine("Coloque seu nome:");

            var nome = Console.ReadLine();

            var resposta = _validador.ValidarNome(nome);

            nomeRetorno = nome;

            return resposta;


        }

        public bool CPFView(out string cpfRetorno )
        {
            Console.WriteLine("Coloque seu CPF:");
            
            var cpf = Console.ReadLine();

            var resposta = _validador.ValidarCpf(cpf);

            cpfRetorno = cpf;

            return resposta;


        }


        public bool DataView(out string dataNascimento)
        {
            Console.WriteLine("Coloque sua Data de Nascimento: ");

            var data = Console.ReadLine();

            var resposta = _validador.ValidarData(data);

            dataNascimento = data;

            return resposta;


        }


        public bool RendaView(out string rendaMensal)
        {
            Console.WriteLine("Coloque sua Renda mensal:");

            var renda = Console.ReadLine();

            var resposta = _validador.ValidarRenda(renda);

            rendaMensal = renda;

            return resposta;


        }


        public bool EstadoCivilView(out string estadoCivil)
        {
            Console.WriteLine("Coloque seu Estado Civil:");

            var Civil = Console.ReadLine();


            var resposta = _validador.ValidarEstadoCivil(Civil);

            estadoCivil = Civil;

            return resposta;


        }


        public bool DependentesView(out string dependentes)
        {
            Console.WriteLine("Coloque a quantidade dos seus dependentes:");

            var dependente = Console.ReadLine();


            var resposta = _validador.ValidarDependentes(dependente);

            dependentes = dependente;

            return resposta;



        }


        public void  MainView()
        {
            string nome;

            var boolNome = NomeView(out nome);

            Console.WriteLine();


            string cpf;

            var boolCpf = CPFView(out cpf);

            Console.WriteLine();


            string data;

            var boolData = DataView(out data);

            Console.WriteLine();



            string renda;

            var boolRenda = RendaView(out renda);

            Console.WriteLine();


            string EstadoCivil;

            var boolCivil = EstadoCivilView(out EstadoCivil);

            Console.WriteLine();


            string dependentes;

            var boolDependentes = DependentesView(out dependentes);

            Console.WriteLine();


            if (boolNome == true && boolCpf == true && boolData == true && boolRenda == true && boolCivil == true && boolDependentes == true)
            {

                Cliente cliente = new Cliente(nome, long.Parse(cpf), DateTime.Parse(data), float.Parse(renda), char.Parse(EstadoCivil), int.Parse(dependentes));

                Console.WriteLine(cliente.ToString());


            }
            else
            {
                while (!(boolNome == true && boolCpf == true && boolData == true && boolRenda == true && boolCivil == true && boolDependentes == true))

                {
                    if (boolNome == false)
                    {

                        Console.WriteLine();

                        _validador.ListaDeErrosDadosEspecifica(ErrosCliente.Nome);

                        Console.WriteLine();

                        boolNome = NomeView(out nome);

                        Console.WriteLine();

                    }

                    if (boolCpf == false)
                    {


                        Console.WriteLine();

                        _validador.ListaDeErrosDadosEspecifica(ErrosCliente.CPF);

                        Console.WriteLine();

                        boolCpf = CPFView(out cpf);

                        Console.WriteLine();



                    }
                    if (boolData == false)
                    {


                        Console.WriteLine();

                        _validador.ListaDeErrosDadosEspecifica(ErrosCliente.DataNascimento);

                        Console.WriteLine();

                        boolData = DataView(out data);

                        Console.WriteLine();



                    }
                    if (boolRenda == false)
                    {
                        Console.WriteLine();

                        _validador.ListaDeErrosDadosEspecifica(ErrosCliente.RendaMensal);

                        Console.WriteLine();

                        boolRenda = RendaView(out renda);

                        Console.WriteLine();



                    }
                    if (boolCivil == false)
                    {

                        Console.WriteLine();

                        _validador.ListaDeErrosDadosEspecifica(ErrosCliente.EstadoCivil);

                        Console.WriteLine();

                        boolCivil = EstadoCivilView(out EstadoCivil);

                        Console.WriteLine();


                    }
                    if (boolDependentes == false)
                    {

                        Console.WriteLine();

                        _validador.ListaDeErrosDadosEspecifica(ErrosCliente.Dependentes);

                        Console.WriteLine();

                        boolDependentes = DependentesView(out dependentes);

                        Console.WriteLine();

                    }



                }
                Cliente cliente = new Cliente(nome, long.Parse(cpf), DateTime.Parse(data), float.Parse(renda), char.Parse(EstadoCivil), int.Parse(dependentes));

                Console.WriteLine(cliente.ToString());

            }


            }




        }


    }
    
