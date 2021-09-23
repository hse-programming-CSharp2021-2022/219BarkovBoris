using System;

namespace task01
{
    class Program
    {
        static void Main()
        {
            string s;
            s = Console.ReadLine();
            int x;
            while (int.TryParse(s, out x))
            {
                int a = x * x;
                Console.WriteLine(12 * a * a + 9 * x * a - 3 * a + 2 * x - 4);
                s = Console.ReadLine();
            }
        }
    }
}
