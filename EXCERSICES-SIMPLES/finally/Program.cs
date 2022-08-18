using System;

namespace EjeploFinally
{
    class Program
{
    static void Main(string[] args)
    {
            System.IO.StreamReader archivo = null;
            try
            {
                string linea;
                int counter = 0;
                string paht = @"C:\Users\Administrador\Desktop\fichero.txt";
                archivo = new System.IO.StreamReader(paht);
                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    counter++;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("error con la lectura del archivo");
            }
            finally
            {
                if (archivo != null) archivo.Close();
                Console.WriteLine("conexion del fichero cerrado");
            }
    }
}
}
