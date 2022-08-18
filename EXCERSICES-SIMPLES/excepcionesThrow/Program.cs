using System;

namespace excepcionesThrow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite el numero del mes que desea espectar");
            int numeromes = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(nombredelmes(numeromes));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"mensaaje dde la excepcion: {ex.Message}"   );
            }

        }
        //aqui va l nombre de la excepcion o que? 
        //no, con eso solo capturamos el mensaje que da si algo falla
        public static string nombredelmes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "enero";
                case 2:
                    return "febrero";
                case 3:
                    return "marzo";
                case 4:
                    return "abril";
                case 5:
                    return "mayo";
                case 6:
                    return "junio";
                case 7:
                    return "julio";
                case 8:
                    return "agosto";
                case 9:
                    return "septiembre";
                case 10:
                    return "octubre";
                case 11:
                    return "noviembre";
                case 12:
                    return "diciembre";
                default:
                    throw new ArgumentOutOfRangeException();


            }


        }







    }
}


