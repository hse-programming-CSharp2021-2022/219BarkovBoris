using System;

namespace task05
{
    class Program
    {

        static void getAns(double a, double b, double c)
        {
            bool flag = (a <= b + c ? true : false);
            flag &= (b <= a + c ? true : false);
            flag &= (c <= a + b ? true : false);
            Console.WriteLine((flag ? "треугольник с такими сторонами существует" : "такого треугольника нет"));
        }
        static void Main()
        {
            string s;
            Console.WriteLine("Хотите выполнить задание? Если нет, напишите \"exit\"");
            s = Console.ReadLine();
            while (s != "exit")
            {
                double.TryParse(s, out double a);
                s = Console.ReadLine();
                double.TryParse(s, out double b);
                s = Console.ReadLine();
                double.TryParse(s, out double c);
                getAns(a, b, c);
                s = Console.ReadLine();
            }
        }
    }
}
