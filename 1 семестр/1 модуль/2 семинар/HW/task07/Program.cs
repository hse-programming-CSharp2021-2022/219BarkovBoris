using System;

namespace task06
{
    class Program
    {

        static void getAns1(double x)
        {
            int a = (int)x;
            double b = x - a;
            Console.WriteLine("целая часть: " + a + ", дробная часть: " + b);
        }
        static void getAns2(double x)
        {
            Console.WriteLine("квадрат числа: " + x * x + ", корень числа: " + (x >= 0 ? "" + Math.Sqrt(x) : "не существует"));
        }
        static void Main()
        {
            string s;
            Console.WriteLine("Хотите выполнить задание? Если нет, напишите \"exit\"");
            s = Console.ReadLine();
            while (s != "exit")
            {
                double.TryParse(s, out double x);
                getAns1(x);
                getAns2(x);
                s = Console.ReadLine();
            }
        }
    }
}
