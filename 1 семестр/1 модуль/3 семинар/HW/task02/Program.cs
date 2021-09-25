using System;

namespace task02
{
    class Program
    {
        static double G(double x, double y)
        {
            if (x < y && x > 0)
            {
                return x + Math.Sin(y);
            }
            else if (x > y && x < 0)
            {
                return y - Math.Cos(x);
            } else
            {
                return 0.5 * x * y;
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
