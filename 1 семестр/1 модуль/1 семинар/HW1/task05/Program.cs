using System;

namespace task05
{
    class Program
    {
        static void Main()
        {
            string s;
            s = Console.ReadLine();
            double.TryParse(s, out double u);
            s = Console.ReadLine();
            double.TryParse(s, out double r);
            double i = u / r;
            double p = u * u / r;
            Console.WriteLine($"I = {i}, P = {p}");
        }
    }
}
