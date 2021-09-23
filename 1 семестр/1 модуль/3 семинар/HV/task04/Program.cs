using System;

namespace task04
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            int.TryParse(a, out int aVal);
            int.TryParse(b, out int bVal);
            int.TryParse(c, out int cVal);

            if (a[0] != b[0] && a[0] != c[0])
            {
                Console.WriteLine(a);
            }
            else if (a[0] == b[0] && a[0] == c[0])
            {
                Console.WriteLine(Math.Min(Math.Min(aVal, bVal), cVal));
            }
            else if (a[0] == b[0])
            {
                Console.WriteLine(Math.Min(aVal, bVal));
            }
            else
            {
                Console.WriteLine(Math.Min(aVal, cVal));
            }
        }
    }
}
