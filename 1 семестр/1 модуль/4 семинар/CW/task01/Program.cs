using System;

namespace task01
{
    class Program
    {
        static void swap(ref uint a, ref uint b)
        {
            uint c = a;
            a = b;
            b = c;
        }
        static bool Transform(ref uint numb)
        {
            if (numb / 100 == 0)
            {
                return false;
            }
            uint[] a = new uint[3];
            for (int i = 0; i < 3; i++)
            {
                a[i] = numb % 10;
                numb /= 10;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 2; j >= 1; j--)
                {
                    if (a[j] > a[j - 1])
                    {
                        swap(ref a[j], ref a[j - 1]);
                    }
                }
            }
            numb = a[0] * 100 + a[1] * 10 + a[2];
            return true;
        }
        static void Main(string[] args)
        {
            uint.TryParse(Console.ReadLine(), out uint x);
            Console.WriteLine(Transform(ref x));
            Console.WriteLine(x);
        }
    }
}
