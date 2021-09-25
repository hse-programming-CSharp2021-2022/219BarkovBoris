using System;

namespace task01
{
    class Program
    {
        static bool G(double x, double y)
        {
            if (Math.Sqrt(x * x + y * y) <= 2 && x >= 0 && y >= -2 && x <= Math.Sqrt(2) && y <= Math.Sqrt(2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            Console.WriteLine(G(x, y));
        }
    }
}
