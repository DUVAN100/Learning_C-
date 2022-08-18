using System;

namespace bucle_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //programa para intentar adivinar un numero aleatorio generado por el programa
            //para crear un numero aleatorio666
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int minumero;
            int intentoss = 0;
            Console.WriteLine("introduce un numeero aleatorio entre 0 y  100");

            do
            {
                intentoss++;
                try
                {
                    minumero = int.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("no has introducido un valor numerico valido");
                    minumero = 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ha habdo un error, se toma como numero el 0 ");
                    minumero = 0;
                    Console.WriteLine(ex.Message);

                }

                //catch(OverflowException ex) 
                //{
                //    Console.WriteLine("has ingrasado un valor demasiado alto");
                //    minumero = 0;

                //}


                if (minumero > aleatorio) Console.WriteLine("el numero es mas bajo");
                if (minumero < aleatorio) Console.WriteLine("el numero es mas alto");

            } while (aleatorio != minumero);
                Console.WriteLine($"has necesitado {intentoss} intentos "); 

        }
    }
}
