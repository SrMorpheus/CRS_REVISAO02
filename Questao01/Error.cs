using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MoreLinq;

namespace Questao01
{
    public class Error
    {
        
        public ErrosCliente TipoErrosCliente { get; set; }

        public string DescricaoError { get; private set; }

        List<Error> ListaError  = new List<Error> ();



        public  void  ErrosNome(int opçao)
        {

            Error nomeErro = new Error ();

            if(opçao == 1)
            {
                nomeErro.DescricaoError = "Existe menos de 5 caracteres";

                nomeErro.TipoErrosCliente = ErrosCliente.Nome;

                ListaError.Add(nomeErro);
              

            } else if(opçao == 2)
            {
                nomeErro.DescricaoError = "Nome está vazio";

                nomeErro.TipoErrosCliente = ErrosCliente.Nome;

                ListaError.Add(nomeErro);


            }

            

        }


        public void ErrosCpf(int opcao)
        {
            Error ErrorCpf = new Error();


            if (opcao == 1)
            {
                ErrorCpf.DescricaoError = "Existe menos de 11 Dígitos";

                ErrorCpf.TipoErrosCliente = ErrosCliente.CPF;

                ListaError.Add(ErrorCpf);


            }
            else if (opcao == 2)
            {
                ErrorCpf.DescricaoError = "Existe mais de 11 Dígitos";

                ErrorCpf.TipoErrosCliente = ErrosCliente.CPF;

                ListaError.Add(ErrorCpf);


            }
            else if (opcao == 3)
            {
                ErrorCpf.DescricaoError = "O CPF precisa ser apenas números";

                ErrorCpf.TipoErrosCliente = ErrosCliente.CPF;

                ListaError.Add(ErrorCpf);


            }
            else if (opcao == 4)
            {
                ErrorCpf.DescricaoError = "O CPF está com tods números repetidos";

                ErrorCpf.TipoErrosCliente = ErrosCliente.CPF;

                ListaError.Add(ErrorCpf);


            
            }
            else if (opcao == 5)
            {
                ErrorCpf.DescricaoError = "O CPF não é válido";

                ErrorCpf.TipoErrosCliente = ErrosCliente.CPF;

                ListaError.Add(ErrorCpf);


            }


        }


        public void ErrosData(int opçao)
        {
            Error ErrorData = new Error();

            if (opçao == 1)
            {
                ErrorData.DescricaoError = "Formato da data  não é válido(formato certo DD/MM/AAAA)";

                ErrorData.TipoErrosCliente = ErrosCliente.DataNascimento;

                ListaError.Add(ErrorData);


            }
            else if (opçao == 2)
            {
                ErrorData.DescricaoError = "O cliente precisa ser maior de 18 anos";

                ErrorData.TipoErrosCliente = ErrosCliente.DataNascimento;

                ListaError.Add(ErrorData);


            }



        }


        public void ErrosRenda(int opçao)
        {
            Error ErrorRenda = new Error();


            if (opçao == 1)
            {
                ErrorRenda.DescricaoError = "Formato da renda  não é válido(formato certo 0,00)";

                ErrorRenda.TipoErrosCliente = ErrosCliente.RendaMensal;

                ListaError.Add(ErrorRenda);


            }
            else if (opçao == 2)
            {
                ErrorRenda.DescricaoError = "A renda precisa ser maior que 0";

                ErrorRenda.TipoErrosCliente = ErrosCliente.RendaMensal;

                ListaError.Add(ErrorRenda);


            }



        }


        public void ErrosEstadoCivil(int opçao)
        {
            Error ErroEstadoCivil = new Error();


            if (opçao == 1)
            {
                ErroEstadoCivil.DescricaoError = "O estado civil não pode ser vazio";

                ErroEstadoCivil.TipoErrosCliente = ErrosCliente.EstadoCivil;

                ListaError.Add(ErroEstadoCivil);


            }
            else if (opçao == 2)
            {
                ErroEstadoCivil.DescricaoError = "Estado civil são apenas as  letras C, S, V ou D (maiúsculo ou minúsculo)";

                ErroEstadoCivil.TipoErrosCliente = ErrosCliente.EstadoCivil;

                ListaError.Add(ErroEstadoCivil);


            }
            else if (opçao == 3)
            {
                ErroEstadoCivil.DescricaoError = "Os estados civis permitidos C, S, V ou D (maiúsculo ou minúsculo)";

                ErroEstadoCivil.TipoErrosCliente = ErrosCliente.EstadoCivil;

                ListaError.Add(ErroEstadoCivil);




            }
        }

        public void ErrosDependetes(int opçao)
        {
            Error ErrorDependetes = new Error();


            if (opçao == 1)
            {
                ErrorDependetes.DescricaoError = "Os dependentes precisa está entre 0 a 10";

                ErrorDependetes.TipoErrosCliente = ErrosCliente.Dependentes;

                ListaError.Add(ErrorDependetes);


            }else if(opçao == 2)
            {

                ErrorDependetes.DescricaoError = "Os dependentes precisa está entre 0 a 10 e apenas número são aceitos";

                ErrorDependetes.TipoErrosCliente = ErrosCliente.Dependentes;

                ListaError.Add(ErrorDependetes);


            }
          
        }


        public void ListaDeErros()
        {


            var listaFinal = ListaError.DistinctBy(x => x.DescricaoError);

            foreach (var lista in listaFinal)
            {

                Console.WriteLine(lista);

            }

        }

        public void ListaDeErros(ErrosCliente errosCliente)
        {

            var listaNova = ListaError.Where(x => x.TipoErrosCliente == errosCliente).Distinct();


            var listaFinal = listaNova.DistinctBy(x => x.DescricaoError);

            foreach (var lista in listaFinal)
            {

                Console.WriteLine(lista);

            }

        }
        public override string ToString()
        {
            return "Tipo de Erro: " + TipoErrosCliente + "\n" +
                   "Descrição do Erro: " + DescricaoError;
                

        }



    }
}
