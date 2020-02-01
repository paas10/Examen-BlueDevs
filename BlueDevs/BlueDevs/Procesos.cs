using System;
namespace BlueDevs
{
    public class Procesos
    {

        public void SerieFibonacci(int num, ref string cadena)
        {
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

        private static void SerieFibonacci(int num1, int num2, int num, ref string cadena)
        {
            int valTemp = num1 + num2;
            cadena += ", " + valTemp;
            num--;

            if (num > 0)
                SerieFibonacci(num2, valTemp, num, ref cadena);
        }


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
