using System;
using System.Collections.Generic;
using System.Text;

namespace Questao05
{
    public class Carro
    {

        private string _placa;

        private string _modelo;

        private Motor _motor;

        public string Placa 
        
            { 
            get
            {

                return _placa;
            }


            private set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Esse campo é obrigatório");
                }

                else
                {
                    _placa = value;


                }

            }



            }

              

        public string Modelo {

            get
            {

                return _modelo;
            
            } 
            private set
            {

                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Esse campo é obrigatório");
                }

                else
                {
                    _modelo = value;


                }


            } 
        
        }  

        public Motor Motor
        {

            get
            {

                return _motor;

            }

             private set
            {
                if(value == null)
                {

                    Console.WriteLine("Esse campo é obrigatório");

                }

               else if (value.Carro != null)
                {
                    //Console.WriteLine("Esse Moto já esta instalado em outro carro");
                     throw new ArgumentException("Esse Moto já esta instalado carro");

                }
                else
                {
                    _motor = value;

                    _motor.InstalarMotor(this);

                }
                         
                     
                        

            }

        }


        public Carro(string placa , string modelo , Motor motor)
        {

            this.Placa = placa;

            this.Modelo = modelo;

            this.Motor = motor;

            motor.InstalarMotor(this);



           



        }


        public void TrocarMotor( Motor motor)
        {

            this.Motor.RemoveCarro();


            this.Motor = motor;

            motor.InstalarMotor(this);




        }


        public string VelocidadeMaxima()
        {

            if(Motor.Cilindrada == 1.0)
            {

                return "A velocidade máxima do carro é 140km/h";


            }

            else if  (Motor.Cilindrada == 1.6)
            {

                return "A velocidade máxima do carro é 160km/h";

            }

            else if (Motor.Cilindrada == 2.0)
            {

                return "A velocidade máxima do carro é 180km/h";

            }

            else if (Motor.Cilindrada > 2.0)
            {

                return "A velocidade máxima do carro é 220 km/h";

            }

            else
            {
                return null ;

            }


        }


        public override string ToString()
        {

            return "Placa do Carro: " + this.Placa + "\n" +
                   "Modelo do Carro: " + this.Modelo + "\n" +
                   "Motor do Carro: " + this.Motor;

        }

    }
}
