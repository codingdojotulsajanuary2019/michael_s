using System;

namespace RandomValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for(int val = 0; val < 10; val++)
            {
                Console.WriteLine(rand.Next(2,8));
            }
        }
    }
}
