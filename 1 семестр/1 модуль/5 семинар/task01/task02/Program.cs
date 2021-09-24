using System;

namespace task02
{
    class Program
    {
        // 1 2 4 8
        static int binPow(int x, int p)
        {
            int ans = 0;
            for (int i = 0; i < p; i++)
            {
                ans += ans;
                ans += 1;
            }
            return ans + 1;
        }

        static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            int.TryParse(Console.ReadLine(), out int m);
            int x = binPow(2, n) + binPow(2, m);
            Console.WriteLine(x);
        }
    }
}
