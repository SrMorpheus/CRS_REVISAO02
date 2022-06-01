using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Questao01
{
    public class Validador
    {

        private Error _errorCliente =  new Error();



        public  bool  ValidarNome( string nome)
        {

            if (string.IsNullOrWhiteSpace(nome))
            {
                _errorCliente.ErrosNome(2);

                return false;


            }
             else if (nome.Length < 5)
            {
                _errorCliente.ErrosNome(1);

                return false;


            }

             return true;

        }


        public bool ValidarCpf(string cpf )
        {

            if(cpf.Length < 11)
            {
                _errorCliente.ErrosCpf(1);

             

                if (!Regex.IsMatch(cpf, @"^[0-9]+$"))
                {

                    _errorCliente.ErrosCpf(3);

                }
                return false;


            } else if(cpf.Length > 11)
            {

                _errorCliente.ErrosCpf(2);


                if (!Regex.IsMatch(cpf, @"^[0-9]+$"))
                {

                    _errorCliente.ErrosCpf(3);


                }
                return false;


            }
            else
            {

                if(!Regex.IsMatch(cpf, @"^[0-9]+$"))
                {

                    _errorCliente.ErrosCpf(3);

                    return false;


                }else if(!ValidacaoCpfRepetido(cpf))
                {
                    _errorCliente.ErrosCpf(4);

                    return false;

                }
                else if(!ValidacaoCPF(cpf))
                {
                    _errorCliente.ErrosCpf(5);

                    return false;


                }


                


            }

            return true;
            
        }

        public bool ValidarData(string data)
        {

            DateTime dataAtual;

            bool datavalida = DateTime.TryParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataAtual);


            if(!datavalida)
            {
                _errorCliente.ErrosData(1);

                return false;

            }

         

            else if(datavalida)
            {

                var dataNascimento = DateTime.ParseExact(data, "dd/MM/yyyy", null);

                var idade = CalculoIdade(dataNascimento);

                if(idade < 18)
                {
                    _errorCliente.ErrosData(2);

                    return false;

                }



            }

            return true;

        }


        public bool ValidarRenda(string renda)
        {
            float rendaMensal;

            if (!float.TryParse(renda, NumberStyles.Any, CultureInfo.CreateSpecificCulture("pt-BR"), out rendaMensal) || !renda.Contains(","))
            {

                _errorCliente.ErrosRenda(1);

                return false;

            }
            else
            {
                if (rendaMensal < 0 )
                {
                    _errorCliente.ErrosRenda(2);
                    return false;

                }

            }




            return true;

        }



        public bool ValidarEstadoCivil(string EstadoCivil)
        {
            if (string.IsNullOrEmpty(EstadoCivil))
            {
                _errorCliente.ErrosEstadoCivil(1);

                return false;

            }
            else if(EstadoCivil.Length > 1)
            {
                _errorCliente.ErrosEstadoCivil(2);

                return false;

            }

            else if(!ValidacaoEstadoCivil(EstadoCivil))
            {

                _errorCliente.ErrosEstadoCivil(3);


                return false;

            }

            return true;
        }


        public bool ValidarDependentes(string dependentes)
        {
            int dependentesInt;

            var exiti = int.TryParse(dependentes, NumberStyles.Any, CultureInfo.CreateSpecificCulture("pt-BR"),out dependentesInt);

            

            if(!exiti)
            {

                _errorCliente.ErrosDependetes(2);

                return false;



            }
            else
            {
                if (dependentesInt < 0 || dependentesInt > 10)
                {
                    _errorCliente.ErrosDependetes(1);

                    return false;


                }


            }


         


                return true;

        }


        private bool ValidacaoEstadoCivil(string estadoCivil)
        {
           
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;


            if (comparer.Compare(estadoCivil.ToUpper(), "C") == 0)
            {

                return true;

            }
            else if (comparer.Compare(estadoCivil.ToUpper(), "S") == 0)
            {

                return true;

            }
            else if (comparer.Compare(estadoCivil.ToUpper(), "D") == 0)
            {

                return true;

            }
            else if (comparer.Compare(estadoCivil.ToUpper(), "V") == 0)
            {

                return true;
            }


            return false;
        }

        private int CalculoIdade(DateTime dataNascimento)
        { 
            
          int idade = DateTime.Now.Year - dataNascimento.Year;

           if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
               idade = idade - 1;
            }
             
            return idade;


            


        }

        private bool ValidacaoCPF(string cpf)
        {



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


            if (resto < 2)
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



            if (resto < 2)
            {

                digitoK = 0;

            }
            else if (resto >= 2 && resto <= 10)
            {

                digitoK = 11 - resto;

            }


            var digitosFinais = digitoJ.ToString() + digitoK.ToString();

            if (digitosFinais == Parte02Cpf)
            {

                return true;

            }
            else
            {

                return false;

            }





    }

            private bool ValidacaoCpfRepetido(string cpf)
        {
            var isRepeated = true;

            for (int i = 1; i < cpf.Length; i++)
            {
                if (cpf[0] != cpf[i])
                {
                    isRepeated = false;
                    break;
                }
            }

            if (isRepeated)
            {
                return false;
            }

            return true;


        }



        public  void ListaDeErrosDadosGeral ()
        {

            _errorCliente.ListaDeErros();


        }

        public void ListaDeErrosDadosEspecifica(ErrosCliente errosCliente )
        {

            _errorCliente.ListaDeErros(errosCliente);

        }

    }
}
