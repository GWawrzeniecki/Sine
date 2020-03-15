using System;
using System.Collections.Generic;
using System.Text;

namespace SinusTaylor
{
    static class Utilities
    {
        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public static double ConvertToDegrees(double angle)
        {
            return (180 / Math.PI) * angle;
        }

        /// <summary>
        /// Bringing an angle to 0..2 PI
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double PrepareDegree(double angle)
        {
            while (angle > 360)
            {
                angle -= 360;
            }

            return angle;
        }
    }
}
