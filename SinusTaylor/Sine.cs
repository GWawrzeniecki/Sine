using System;
using System.Collections.Generic;
using System.Text;

namespace SinusTaylor
{
    public static class Sine
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="angle">angle in radians</param>
        /// <param name="term"> how many terms</param>
        /// <returns></returns>
        public static double CalculateSinus(double angle, int term)
        {
            angle = GetProperAngle(Utilities.ConvertToDegrees(angle));
            double result = 0;
            int sign = -1;
            for (int i = 1; i < term * 2; i += 2)
            {
                double pow = Math.Pow(angle, i);
                sign *= -1;
                long factorial = Factorial.GetFactorial(i);
                result += sign * pow / factorial;
            }

            return result;
        }

        /// <summary>
        /// 1 - 4 quartes
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        private static double GetProperAngle(double angle)
        {
            angle = Utilities.PrepareDegree(angle);

            if (angle <= 90)
            {
                return Utilities.ConvertToRadians(angle);
            }
            else if (angle <= 180)
            {
                return Math.PI - Utilities.ConvertToRadians(angle);
            }
            else if (angle <= 270)
            {
                return (Utilities.ConvertToRadians(angle) - Math.PI) * -1;
            }
            else
            {
                return (2 * Math.PI - Utilities.ConvertToRadians(angle)) * -1;
            }

        }

    }
}
