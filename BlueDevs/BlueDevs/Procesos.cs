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
            int tempVal = num1 + num2;
            cadena += ", " + tempVal;
            num--;

            if (num > 0)
                SerieFibonacci(num2, tempVal, num, ref cadena);
        }
    }
}
