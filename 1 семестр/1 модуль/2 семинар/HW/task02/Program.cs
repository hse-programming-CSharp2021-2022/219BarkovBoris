using System;

namespace task02
{
    class Program
    {
        static int get(int a, int b, int c)
        {
            return a * 100 + b * 10 + c;
        }
        static void Main()
        {
            string s;
            s = Console.ReadLine();
            int x;
            while (int.TryParse(s, out x))
            {
                if (x / 100 == 0)
                {
                    Console.WriteLine("неверный ввод");
                }
                else
                {
                    // abc
                    // acb
                    // bac
                    // bca
                    // cab
                    // cba
                    int a = x % 10;
                    x /= 10;
                    int b = x % 10;
                    x /= 10;
                    int c = x % 10;
                    x /= 10;

                    int ans = -1;
                    ans = (get(a, b, c) > ans ? get(a, b, c) : ans);
                    ans = (get(a, c, b) > ans ? get(a, c, b) : ans);

                    ans = (get(b, a, c) > ans ? get(b, a, c) : ans);
                    ans = (get(b, c, a) > ans ? get(b, c, a) : ans);

                    ans = (get(c, a, b) > ans ? get(c, a, b) : ans);
                    ans = (get(c, b, a) > ans ? get(c, b, a) : ans);

                    Console.WriteLine(ans);
                }
                s = Console.ReadLine();
            }
        }
    }
}
