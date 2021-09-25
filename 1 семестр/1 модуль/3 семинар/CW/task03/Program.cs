using System;

namespace task03
{
    class Program
    {
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double a);
            double.TryParse(Console.ReadLine(), out double eps);

            double now = 0;
            double ans = 0;
            while (now < a)
            {
                double S = eps * ((now * now) + (now + eps) * (now + eps)) / 2;
                now += eps;
                ans += S;
            }
            Console.WriteLine(ans);
        }
    }
}
