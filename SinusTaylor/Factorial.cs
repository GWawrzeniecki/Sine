using System;
using System.Collections.Generic;
using System.Text;

namespace SinusTaylor
{
    public static class Factorial
    {
        public static long GetFactorial(int number)
        {
            long result;
            result = number;
            for (int i = number - 1; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
