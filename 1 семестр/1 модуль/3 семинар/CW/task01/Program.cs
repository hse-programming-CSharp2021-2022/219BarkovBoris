using System;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int x);
            switch (x) {
                case 1:
                    Console.WriteLine("неуд");
                    break;
                case 2:
                    Console.WriteLine("неуд");
                    break;
                case 3:
                    Console.WriteLine("неуд");
                    break;
                case 4:
                    Console.WriteLine("уд");
                    break;
                case 5:
                    Console.WriteLine("уд");
                    break;
                case 6:
                    Console.WriteLine("хрш");
                    break;
                case 7:
                    Console.WriteLine("хрш");
                    break;
                case 8:
                    Console.WriteLine("отл");
                    break;
                case 9:
                    Console.WriteLine("отл");
                    break;
                case 10:
                    Console.WriteLine("отл");
                    break;
                default:
                    Console.WriteLine("такой оценки нет");
                    break;

            }
        }
    }
}
