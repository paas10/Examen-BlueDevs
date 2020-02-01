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
                Console.WriteLine("Bienvenido\nIngrese el numero del problema que quiere seleccionar.\n" +
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
                            Console.Write("PROBLEMA 2\n" +
                                "Ingrese un número entre 0 y 15: ");

                            try
                            {
                                num = Convert.ToInt16(Console.ReadLine());

                                string resultado = "";

                                if (num >= 0 && num <= 15)
                                {
                                    proc.SerieFibonacci(num, ref resultado);
                                    Console.WriteLine("\nSerie de Fibonacci: " + resultado + "\n");
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese un número válido\n");
                                }

                            }
                            catch
                            {
                                num = -1;
                                Console.WriteLine("Ingrese un número válido\n");
                            }


                        } while (num < 0 || num > 15);

                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();

                    }
                    else if (seleccion == 3)
                    {
                        int num;

                        do
                        {
                            Console.Write("PROBLEMA 3\n" +
                                "Ingrese un número entre 0 y 15: ");

                            try
                            {
                                num = Convert.ToInt16(Console.ReadLine());

                                int resultado = 0;

                                if (num >= 0 && num <= 15)
                                {
                                    resultado = proc.SumatoriaFibonacci(num);
                                    Console.WriteLine("\nSumatoria de Fibonacci (" + num + "): " + resultado + "\n");
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese un número válido\n");
                                }

                            }
                            catch
                            {
                                num = -1;
                                Console.WriteLine("Ingrese un número válido\n");
                            }


                        } while (num < 0 || num > 15);

                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    else if (seleccion == 4)
                    {
                        int num;

                        do
                        {
                            Console.Write("PROBLEMA 4\n" +
                                "Ingrese un número entre 0 y 15: ");

                            try
                            {
                                num = Convert.ToInt16(Console.ReadLine());

                                if (num >= 0 && num <= 15)
                                {
                                    int[,] matriz = new int[num, num];

                                    // Rellenado de la matriz
                                    for (int i = 0; i < num; i++)
                                    {
                                        for (int j = 0; j < num; j++)
                                        {
                                            matriz[i, j] = i + j;
                                        }
                                    }

                                    Console.WriteLine("\nMatriz:");
                                    // Impresion de la matriz
                                    for (int i = 0; i < num; i++)
                                    {
                                        Console.WriteLine();
                                        for (int j = 0; j < num; j++)
                                        {
                                            Console.Write(matriz[i, j] + "\t");
                                        }
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Ingrese un número válido\n");
                                }

                            }
                            catch
                            {
                                num = -1;
                                Console.WriteLine("Ingrese un número válido\n");
                            }


                        } while (num < 0 || num > 15);

                        Console.WriteLine("\n\nPress any key to continue...");
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
