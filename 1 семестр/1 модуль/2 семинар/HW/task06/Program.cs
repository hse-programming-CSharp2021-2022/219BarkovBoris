using System;

namespace task06
{
    class Program
    {

        static void getAns(decimal a, int x)
        {
            decimal ans = a * (x / (decimal)100);
            Console.WriteLine(ans);
        }
        static void Main()
        {
            string s;
            Console.WriteLine("Хотите выполнить задание? Если нет, напишите \"exit\"");
            s = Console.ReadLine();
            while (s != "exit")
            {
                decimal.TryParse(s, out decimal a);
                s = Console.ReadLine();
                int.TryParse(s, out int x);
                getAns(a, x);
                s = Console.ReadLine();
            }
        }
    }
}
