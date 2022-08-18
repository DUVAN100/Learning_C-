using System;

namespace proyectConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREAMOS NUESTRO PRIMER OBJETO e instanciamos
            //1_nombre clase
            //2_nombre del objeto
            //3_ new
            //4_nombre del contructor
            coche coche1 = new coche();
            coche coche3 = new coche(1.80, 3.99);
            coche coche2 = new coche();
            //imprimimos la informacion atra vez de la clase llamando el metodo que garda la informacionpara poder ser imprimida " getInfoCoche "
            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche ());
            Console.WriteLine(coche3.getInfoCoche());
            //establecemos los valores de los extras del coche3 con el set
            coche3.setExtras(true, "piel");

            Console.WriteLine(coche3.getExtras());
            
        }

        partial class coche
        {
            //CREACION DEL CONSTRUTOR 
            public coche()
            {
                ruedas = 4;
                largo = 4.5;
                ancho = 2.0;
                //colocamos como estado inicial  tapiceria tela para que pordefecto todos los autos la tengan
                tapiceria = "tela";
            }
            //vamos a crear una sobre carga de constructores
            public coche(double AnchoCoche, double LargoCoche)
            {
                ruedas = 4;
                ancho = AnchoCoche;
                largo = LargoCoche;
                tapiceria = "tela";
            }
        }
//--------------------------------------------------------------------------------------------
        partial class coche { 
            //metodo de acceso para la propiedad ruedas
            public string getInfoCoche() 
            {
                return "informacion del coche:\n " + " ruedas: " + ruedas + "\n  largo: " + largo + "\n  ancho: " + ancho;
            }
            //creamos el metodo set para que le de un valor a las variables climatizader y tapiceria
            public void setExtras(bool climatizador, string tapiceria) 
            {
                //el this ayuda a diferenciar la varibale del parametro
                this.climatizador = climatizador;
                this.tapiceria = tapiceria;
            }
            //creamos el metodo get para imprimir el valor de las varibales, o para que nos de acceso a las varibals
            public string getExtras() 
            {
                return "¿el automovil tiene climatizador?  \n "+climatizador+"\n¿que tipo de tapíceria tiene el automovil?  \n" +tapiceria;
            }
            //variables o ´propiedasdes del objeto coche1 y coche2
            private int ruedas;
            private double largo;
            private double ancho;
            private bool climatizador;
            private string tapiceria="tela";


        }
    }
}
