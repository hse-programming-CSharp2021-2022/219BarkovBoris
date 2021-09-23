using System;

namespace task04
{
    class Program
    {

        static void getAns(int x) {
            int a = x % 10;
            x /= 10;
            int b = x % 10;
            x /= 10;
            int c = x % 10;
            x /= 10;
            int d = x;
            Console.WriteLine("" + a + b + c + d);
        }
        static void Main()
        {
            string s;
            Console.WriteLine("Хотите выполнить задание? Если нет, напишите \"exit\"");
            s = Console.ReadLine();
            while (s != "exit")
            {
                int.TryParse(s, out int a);
                getAns(a);
                s = Console.ReadLine();
            }
        }
    }
}
