using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Questao07
{
    public class Propriedades
    {
        private string _path; 
        public string Path { 
            
            get
            {
                return _path;


            }
            set
            {
                if (File.Exists(value))
                {

                    _path = value;
                    LerPropriedades();



                }
                else if (Directory.Exists(value))
                {

                    throw new FileNotFoundException("Existe apenas o  diretório  sem arquivo");



                }
                else
                {
                    throw new FileNotFoundException("não existe o diretório e arquivo");


                }

            }
                
                
                }    

        private  Dictionary<string, string>  _propriedades = new Dictionary<string, string>();



        public Propriedades()
        {
        }


        public Propriedades( string path)
        {
            
            this.Path = path;


        }

        private void LerPropriedades()
        {
            

            var Texto  = File.ReadAllLines(Path);

                      
            

            foreach (var texto in Texto)
            {
                
                    var textoSeparado = texto.Split("=");

                    var chave = textoSeparado[0];

                    var valor = textoSeparado[1];

                    _propriedades.Add(chave, valor);

              


                }
              




            



        }


      


    public void AlterarValor(string chave, string valor)
        {
            var existe = _propriedades.ContainsKey(chave);

            if(existe)
            {

                _propriedades[chave] = valor;

                Console.WriteLine("Alteração com sucesso!");


            }

            else
            {

                throw new FileNotFoundException("Não existe o valor");

            }



        }




        public string RecuperarValor(string chave)
        {
            string valor;

          


            var existe = _propriedades.TryGetValue(chave, out valor);

            if(existe)
            {

                return valor; 


            }else
            {
                Console.WriteLine("error aqui");


                return null;


            }




        }


        public void VerificarChave(string chave)
        {
          var existe =  _propriedades.ContainsKey(chave);

            if(existe)
            {

                Console.WriteLine("Chave existe");


            }
            else
            {

                Console.WriteLine("Chave não existe");



            }




           





        }

        public void IncluirChave(string chave, string valor)

        {
            var existe = _propriedades.ContainsKey(chave);

            if (existe)
            {

                throw new FileNotFoundException("Jã existe essa chave na propriedade");


            }

            else
            {
                _propriedades.Add(chave, valor);

                Console.WriteLine("Adicionado com sucesso");


            }



        }


        public void SalvarPropriedade()

        {
            StreamWriter sw = new StreamWriter(this.Path);

            foreach( var listPropriedades in _propriedades)
            {
                sw.WriteLine(listPropriedades.Key + "=" + listPropriedades.Value);



            }

            sw.Close();


        }
    



    }
}
