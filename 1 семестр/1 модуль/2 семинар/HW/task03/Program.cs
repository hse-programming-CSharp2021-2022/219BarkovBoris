using System;

namespace task03
{
    class Program
    {

        static string getAns(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return (d == 0 ? "" + (x1) : "" + (x1) + " " + (x2));
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

                double d = b * b - 4 * a * c;

                Console.WriteLine((d >= 0) ? getAns(a, b, c) : "Нет корней");
            }
        }
    }
}
