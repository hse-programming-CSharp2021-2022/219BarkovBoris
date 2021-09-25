using System;

namespace task05
{
    class Program
    {
        static void GetAns(int n)
        {
            double summ = 0;
            for (int k = 1; k <= n; k++)
            {
                summ += (double)(k + 0.3) / (double)(3 * k * k + 5);
                Console.WriteLine(summ);
            }
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int x);
            GetAns(x);
        }
    }
}
