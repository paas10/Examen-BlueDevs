using System;

namespace BlueDevs
{
    class Program
    {
        static void Main(string[] args)
        {
            var seleccion = 0;
            Procesos proc = new Procesos();

            while (seleccion != 5)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido\n Ingrese el numero del problema que quiere seleccionar.\n\n" +
                    "2. Problema 2\n" +
                    "3. Problema 3\n" +
                    "4. Problema 4\n" +
                    "5. Salir");

                try
                {
                    seleccion = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine();

                    if (seleccion == 2)
                    {
                        int num;

                        do
                        {
                            Console.WriteLine("PROBLEMA 2\n" +
                                "Ingrese un número entre 0 y 15");

                            try
                            {
                                num = Convert.ToInt16(Console.ReadLine());

                                string resultado = "";

                                if (num >= 0 && num <= 15)
                                {
                                    proc.SerieFibonacci(num, ref resultado);
                                    Console.WriteLine("Serie de Fibonacci: " + resultado);
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese un número válido\n");
                                }

                            }
                            catch
                            {
                                num = -1;
                                Console.WriteLine("Ingrese un caracter válido\n");
                            }


                        } while (num < 0 || num > 15);

                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();

                    }
                    else if (seleccion == 3)
                    {
                        Console.WriteLine("PROBLEMA 3");

                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    else if (seleccion == 4)
                    {
                        Console.WriteLine("PROBLEMA 4");

                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                catch
                {

                }
            }
            
        }

        

        




    }
}
