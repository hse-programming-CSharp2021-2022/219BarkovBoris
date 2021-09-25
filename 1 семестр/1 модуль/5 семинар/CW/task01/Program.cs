using System;

namespace CW
{
    class Program
    {
        static void Main()
        {
            int.TryParse(Console.ReadLine(), out int x);

            int ans = 0;
            int tmp_len = 0;
            int tmp_x = x;
            while (tmp_x != 0)
            {
                tmp_len++;
                tmp_x /= 10;
            }
            for (int i = 0; i < tmp_len; i++)
            {
                int tmp = x;
                int mx = x % 10;
                int ind = 0;
                int len = 0;
                while (tmp != 0)
                {
                    if (tmp % 10 > mx)
                    {
                        mx = tmp % 10;
                        ind = len;
                    }
                    len++;
                    tmp /= 10;
                }
                len = Math.Max(len, 1);
                ans = ans * 10 + mx;

                int new_x = 0;
                tmp = x;
                int zero = 0;
                for (int j = 0; j < len; j++)
                {
                    if (j != ind)
                    {
                        if (tmp % 10 != 0)
                        {
                            new_x = new_x * 10 + (tmp % 10);
                        }
                        else
                        {
                            zero++;
                        }
                    }
                    tmp /= 10;
                }
                for (int j = 0; j < zero; j++)
                {
                    new_x *= 10;
                }
                x = new_x;
            }


            Console.WriteLine(ans);

        }
    }
}
