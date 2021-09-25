using System;

namespace task03
{
    class Program
    {
        static void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (i + 1 < n)
                {
                    if ((arr[i] + arr[i + 1]) % 3 == 0)
                    {
                        arr[i] = arr[i] * arr[i + 1];
                        for (int j = i + 1; j + 1 < n; j++)
                        {
                            swap(ref arr[j], ref arr[j + 1]);
                        }
                        n--;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != -1)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
