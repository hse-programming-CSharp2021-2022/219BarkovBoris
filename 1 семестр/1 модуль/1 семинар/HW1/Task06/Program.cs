using System;

namespace Task06
{
    class Program
    {
        static void Main()
        {
            string s;
            s = Console.ReadLine();
            double.TryParse(s, out double a);
            s = Console.ReadLine();
            double.TryParse(s, out double b);
            Console.WriteLine(Math.Sqrt(a * a + b * b));
        }
    }
}
