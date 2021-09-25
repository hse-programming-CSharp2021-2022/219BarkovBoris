using System;

namespace task05
{
    class Program
    {
        static void Main(string[] args)
        {
            float ans = 0;
            for (int i = 1; i < 100; i++)
            {
                ans += (float)1 / (i * (i + 1) * (i + 2));
            }
            Console.WriteLine(ans);
        }
    }
}
