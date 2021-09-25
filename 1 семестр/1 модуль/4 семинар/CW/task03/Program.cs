using System;

namespace task03
{
    class Program
    {
        static bool Triangle(double a, double b, double c, out double p, out double s)
        {
            bool flag = true;
            flag = (a <= b + c ? true : false);
            flag = (b <= a + c ? true : false);
            flag = (c <= a + b ? true : false);

            p = -1;
            s = -1;
            if (!flag)
            {
                return false;
            }
            p = (a + b + c);
            double pp = p / 2;
            s = Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
            return true;
        }
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double a);
            double.TryParse(Console.ReadLine(), out double b);
            double.TryParse(Console.ReadLine(), out double c);
            double p, s;
            Console.WriteLine(Triangle(a, b, c, out p, out s));
            Console.WriteLine($"{p}\n{s}");
        }
    }
}
