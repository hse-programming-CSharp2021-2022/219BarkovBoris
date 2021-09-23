using System;

namespace task06
{
    class Program
    {
        static double fact(int x)
        {
            double ans = 1;
            for (int i = 1; i <= x; i++)
            {
                ans *= i;
            }
            return ans;
        }
        static double get1(double x)
        {
            double ans = x * x;
            for (int i = 0; i < 200; i++)
            {
                if (i % 2 == 0)
                {
                    ans -= Math.Pow(2, 3 + 2 * i) * Math.Pow(x, 4 + 2 * i) / fact(4 + 2 * i);
                }
                else
                {
                    ans += Math.Pow(2, 3 + 2 * i) * Math.Pow(x, 4 + 2 * i) / fact(4 + 2 * i);
                }
            }
            return ans;
        }
        static double get2(double x)
        {
            double ans = 1;
            for (int i = 1; i < 200; i++)
            {
                ans += Math.Pow(x, i) / fact(i);
            }
            return ans;
        }
        static void Main()
        {
            string s;
            s = Console.ReadLine();
            double.TryParse(s, out double x);
            Console.WriteLine(get1(x));
            Console.WriteLine(get2(x));
        }
    }
}
