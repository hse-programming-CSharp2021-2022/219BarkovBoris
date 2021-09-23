using System;

namespace task03
{
    class Program
    {
        static double G(double x)
        {
            if (x <= 0.5)
            {
                return Math.Sin(Math.PI / 2);
            }
            else
            {
                return Math.Sin(Math.PI * (x - 1) / 2);
            }
        }
        static void Main()
        {
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine(G(x));
        }
    }
}
