using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaTDD
{
    public class Funciones
    {
        public static long CalcularFactorial(int n)
        {
            long resultado = 1;

            if (n < 0)
                resultado = -1;

            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
