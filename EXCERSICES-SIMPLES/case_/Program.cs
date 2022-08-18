using System;

    namespace case_
    {
        class Program
        {
#pragma warning disable IDE0060 // Quitar el parámetro no utilizado
        static void Main(string[] args)
#pragma warning restore IDE0060 // Quitar el parámetro no utilizado
        {
                Console.WriteLine(" introduce el numero del mes para el calculo de la comision ");
                int nromes = Int32.Parse(Console.ReadLine());
                Console.WriteLine("digite su salario");
                uint slri = UInt32.Parse(Console.ReadLine());
                switch (nromes)
                {
                    case 1:
                        Console.WriteLine(" su comision es de 30.000)");
                        uint salneto = slri + 30000;
                        Console.WriteLine("tu salario neto es de:" + salneto);
                        break;
                    case 2:
                        Console.WriteLine("su comision es de 50.000");
                        salneto = slri + 50000;
                        Console.WriteLine("tu salario neto es de:" + salneto);
                        break;
                    case 3:
                        Console.WriteLine("su comision es de 60.000");
                        salneto = slri + 60000;
                        Console.WriteLine("tu salario neto es de:" + salneto);
                        break;
                    case 4:
                        Console.WriteLine("su comision es de 100.000");
                        salneto = slri + 100000;
                        Console.WriteLine("tu salario neto es de:" + salneto);
                        break;
                    case 5:
                        Console.WriteLine("su comision es de 20.000");
                        salneto = slri + 20000;
                        Console.WriteLine("tu salario neto es de:" + salneto);
                        break;
                    case 6:
                        Console.WriteLine("su comision es de 90.000");
                        salneto = slri + 90000;
                        Console.WriteLine("tu salario neto es de:" + salneto);
                        break;
                    case 7:
                        Console.WriteLine("su comision es de 80.000");
                        salneto = slri + 80000;
                        Console.WriteLine("tu salario neto es de:" + salneto);
                        break;
                    case 8:
                        Console.WriteLine("su comision es de 43.000");
                        salneto = slri + 43000;
                        Console.WriteLine("tu salario neto es de:" + salneto);
                        break;
                    case 9:
                        Console.WriteLine("su comision es de 70.000");
                        salneto = slri + 70000;
                        Console.WriteLine("tu salario neto es de:" + salneto);
                        break;
                    case 10:
                        Console.WriteLine("su comision es de 95.000");
                        salneto = slri + 95000;
                        Console.WriteLine("tu salario neto es de:" + salneto);
                        break;
                    case 11:
                        Console.WriteLine("su comision es de 45.000");
                        salneto = slri + 45000;
                        Console.WriteLine("tu salario neto es de:" + salneto);
                        break;
                    case 12:
                        Console.WriteLine("su comision es de 120.000");
                        salneto = slri + 120000;
                        Console.WriteLine("tu salario neto es de:" + salneto);
                        break;
                    default:
                        Console.WriteLine("digite un numero de mes valido");
                        break;

                }
            }
        }
    }


