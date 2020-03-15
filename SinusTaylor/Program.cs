using System;

namespace SinusTaylor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Podaj jednostke {Environment.NewLine}1. Radiany {Environment.NewLine}2. Stopnie");
            var success = int.TryParse(Console.ReadLine(), out int unit);

            if (success && (unit == 1 || unit == 2))
            {
                Console.WriteLine("Podaj kąt");
                success = double.TryParse(Console.ReadLine(), out double angle);
                if (success)
                {
                    if (unit == 2)
                    {
                        angle = Utilities.ConvertToRadians(angle);
                    }
                    var mathLibraryResult = Math.Sin(angle);
                    for (int i = 1; i < 11; i++)
                    {
                        var taylorResult = Sine.CalculateSinus(angle, i);
                        var diff = decimal.Parse(Math.Abs(taylorResult - mathLibraryResult).ToString(), System.Globalization.NumberStyles.Float);
                        Console.WriteLine($"Term: {i} Taylor Result: {taylorResult} MathLibrary Result: {mathLibraryResult} ABS Difference: {Math.Abs(diff)}");
                    }
                }
                else
                {
                    Console.WriteLine("Podałeś nieprawidłową wartość");
                }
            }
            else
            {
                Console.WriteLine("Podałeś nieprawidłową wartość");
            }


        }
    }
}
