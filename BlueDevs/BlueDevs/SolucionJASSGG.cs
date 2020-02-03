using System;
using System.Collections.Generic;
using System.Text;

namespace BlueDevs
{
    class SolucionJASSGG
    {


        /// <summary>
        /// First, define recursive function of Fibonacci sequence.
        /// This function will help us to simplify all other functions. 
        /// </summary>
        /// <param name="num"></param>
        /// <returns>int</returns>
        private int FibonacciJASSGG(int num)
        {
            // single method approach
            // Example> 0, 1, 1, 2 ...
            if (num > 2)
                return FibonacciJASSGG(num - 1) + FibonacciJASSGG(num - 2); // Simplest Algorithm for Fibonnaci sequence. 
            else if (num == 2) // num is position, not value. num = 2 should return 1 for this Fibonacci sequence. 
                return 1;
            else // positions lower or equal to 1 return 0.
                return 0;
        }

        /// <summary>
        /// This is my own solution for SerieFibonacci - J4SSGG
        /// </summary>
        /// <param name="num">User input</param>
        /// <returns>string</returns>

        public string SerieFibonacciJASSGG(int num, ref string resultado)
        {
            if (num == 0)
                return resultado;
            else
                //resultado += FibonacciJASSGG(num) + ", "; // 34, 21, 13, 8, .... 1, 1, 0
                resultado = FibonacciJASSGG(num) + ", " + resultado; // to invert order, since this functions is "descending"...
            return SerieFibonacciJASSGG(num - 1, ref resultado);


        }

        /// <summary>
        /// This is my own solution for SumatoriaFibonacci - J4SSGG
        /// </summary>
        /// <param name="num">User input</param>
        /// <returns>int</returns>
        public int SumatoriaFibonacciJASSGG(int num, int resultado)
        {
            if (num == 0)
                return resultado;
            else
                resultado += FibonacciJASSGG(num);
            return SumatoriaFibonacciJASSGG(num - 1, resultado);
        }


        public int[,] filledMatrix(int size)
        {
            int[,] tempMatrix = new int[size, size];

            for(int i=0; i < size; i++)
            for(int j=0; j < size; j++)
                    tempMatrix[i, j] = i +j;

            return tempMatrix;
        }

    }
}
