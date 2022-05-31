using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Questao05
{
    public class Motor
    {

        private double _cilindrada;

        public double Cilindrada {


            get
            {

                return _cilindrada;
            }

            private set
            {
                if(value < 1.0)
                {
                    Console.WriteLine("Coloque um valor da cilindrada maior que 1.0");

                }
                else
                {
                    _cilindrada = value;

                }


            }
        
        }

        public Carro Carro { get; private set; }


        public Motor(double cilindrada)
        {

  


            this.Cilindrada = cilindrada;



        }



        public void InstalarMotor(Carro carro)

        {
           

            this.Carro = carro;


        }


        public void RemoveCarro ()

        {
            if(this.Carro != null)
            {

                this.Carro = null;

            }

          


        }



        public override string ToString()
        {

            return "Cilindrada do Motor: " + this.Cilindrada.ToString("N1", CultureInfo.CreateSpecificCulture("en-US"));

        }




    }
}
