using System;

namespace task03
{
    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            int.TryParse(s, out int x);
            Console.WriteLine((char)x);
        }
    }
}
