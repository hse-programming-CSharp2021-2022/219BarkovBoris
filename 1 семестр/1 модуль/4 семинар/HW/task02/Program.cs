using System;

namespace task02
{
    class Program
    {
        static bool getAns(ref char x)
        {
            int num = (x - 'a');
            num = (num + 4) % 26;
            x = (char)(num + 97);
            if (x - 'a' >= 0 && 'z' - x >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            string s;
            s = Console.ReadLine();
            while (s != "exit")
            {
                char.TryParse(s, out char x);
                if (getAns(ref x))
                {
                    Console.WriteLine(x);
                }
                s = Console.ReadLine();
                
            }
        }
    }
}
