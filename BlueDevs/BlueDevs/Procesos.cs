using System;
namespace BlueDevs
{
    public class Procesos
    {
        /// <summary>
        /// Método visitble al main que recibe la cantidad de elementos de la
        /// serie de fibonacci se solicitan y una variable por referencia que
        /// almacena la cadena de retorno requerida.
        /// </summary>
        /// <param name="num">Cantidad de elementos que se solicitan.</param>
        /// <param name="cadena">Variable string por referencia que contiene el resultado</param>
        public void SerieFibonacci(int num, ref string cadena)
        {
            // Num juega el papel de las iteraciones requeridas en la recursividad.

            if (num == 0)
                cadena = "";
            else if (num == 1)
                cadena = "0";
            else if (num == 2)
                cadena = "0, 1";
            else
            {
                cadena = "0, 1";
                num = num - 2;
                SerieFibonacci(0, 1, num, ref cadena);
            }
                
        }

        /// <summary>
        /// Metodo recursivo que realiza los calculos de la serie de fibonacci
        /// y almacena los resultados en la variable por referencia.
        /// </summary>
        /// <param name="num1">Primer numero antecesor de la serie de fibonacci</param>
        /// <param name="num2">Segundo numero antecesor de la serie de fibonacci</param>
        /// <param name="num">Cantidad de iteraciones restantes</param>
        /// <param name="cadena">Variable por referencia que almacena el resultado</param>
        private static void SerieFibonacci(int num1, int num2, int num, ref string cadena)
        {
            int valTemp = num1 + num2;
            cadena += ", " + valTemp;
            num--;

            if (num > 0)
                SerieFibonacci(num2, valTemp, num, ref cadena);
        }


        /// <summary>
        /// Método que recibe un numero que indica cuantos numeros de la serie de
        /// fibonacci se requieren. Retorna un entero que es el resultado.
        /// </summary>
        /// <param name="num">Cantidad de numeros que se requieren de la serie
        /// de fibonacci</param>
        /// <returns>Retorna un entero, el cual es la suma de todos los numeros
        /// de la serie de fibonacci</returns>
        public int SumatoriaFibonacci(int num)
        {
            if (num == 0)
                return 0;
            else if (num == 1)
                return 0;
            else if (num == 2)
                return 1;
            else
                return 1 + SumatoriaFibonacci(0, 1, num - 2);

        }

        /// <summary>
        /// Método que realiza la sumatoria y realiza iteraciones recursivamente.
        /// </summary>
        /// <param name="num1">Primer numero antecesor de la serie de fibonacci</param>
        /// <param name="num2">Segundo numero antecesor de la serie de fibonacci</param>
        /// <param name="num">Cantidad de iteracines restantes</param>
        /// <returns></returns>
        private static int SumatoriaFibonacci(int num1, int num2, int num)
        {
            int valTemp = num1 + num2;
            num--;

            if (num > 0)
                return  valTemp + SumatoriaFibonacci(num2, valTemp, num);
            else
                return valTemp;
        }


    }
}
