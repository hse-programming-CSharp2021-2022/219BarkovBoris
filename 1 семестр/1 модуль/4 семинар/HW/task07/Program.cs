using System;

namespace task07
{
    class Program
    {

        static int getGcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return getGcd(b, a % b);
        }
        static void getAns(int a, int b, out int gcd, out int lcm)
        {
            gcd = getGcd(a, b);
            lcm = a * b / gcd;
        }
        static void Main()
        {
            string s;
            s = Console.ReadLine();
            int.TryParse(s, out int a);
            s = Console.ReadLine();
            int.TryParse(s, out int b);

            int gcd, lcm;
            getAns(a, b, out gcd, out lcm);
            Console.WriteLine("" + gcd + " " + lcm);
        }
    }
}
