using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            for(int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int start = 0;
            int end = 5;

            for (int i = start; i<=end; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = start; i < end; i++)
            {
                Console.WriteLine(i);
            }

            int x = 1;
            while(x < 6)
            {
                Console.WriteLine(x);
                x = x + 1;
            }

        }
    }
}
