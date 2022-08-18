using System;

namespace ejemploPOO1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   circulo micirculo;*/ // creacion de un objeto, una variable objeto de tipo circulo
            /*micirculo = new circulo();*/ //iniciacion de variable de tipo circulo, o tambien instanciar una clase
                                           //Console.WriteLine(micirculo.calculoArea(5));
                                           //segunda instancia
                                           //circulo micirculo2 = new circulo();
                                           //Console.WriteLine(micirculo2.calculoArea(9));
            ConversorEuroDolar obj = new ConversorEuroDolar();
            obj.CambiaValorEuro(12.85);//metodo de acceso para cambiar el valor ddl euro
            Console.WriteLine(obj.convierte(50));//instanciando la clase ConversorEuroDolar
            






        }
    }
    class circulo
    {
        const double pi = 3.1416; //propiedad de la clase circulo, campo de clase
        public double calculoArea(int radio)// metodo de clase o comportamiento 
        {
            return pi * radio * radio;
        }



    }
    class ConversorEuroDolar
    {
        private double euro = 4.540;
        //metodo para convertir euros a dolares
        public double convierte(double cantidad)
        {
            return cantidad * euro;
        }

        //metodo para cambiar el valor del euro 
        public void CambiaValorEuro(double nuevoValor) 
        {
            if (nuevoValor < 0) nuevoValor = 4.540;

            else
                euro = nuevoValor; 
        }
        
        


    }
}
