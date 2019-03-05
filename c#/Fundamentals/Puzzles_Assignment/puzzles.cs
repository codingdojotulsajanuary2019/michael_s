using System;
using System.Collections.Generic;

namespace Puzzles_Assignment
{
    class PuzzleMeths
    {
        public static int[] RandArr()
        {
            int [] NewArray = new int[10]; 
            Random num = new Random();
            int Max  = NewArray[0];
            int Min = 26;
            int Sum = 0;
            for(int i = 0; i < NewArray.Length; i++)
            {
                NewArray[i] = num.Next(5,26);
                Sum += NewArray[i];
                if(NewArray[i] > Max)
                {
                    Max = NewArray[i];
                }
                if(NewArray[i] < Min)
                {
                    Min = NewArray[i];
                }
            }
            Console.WriteLine($"Max: {Max}");
            Console.WriteLine($"Min: {Min}");
            Console.WriteLine($"Sum: {Sum}");
            return NewArray;
        }

        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            Random num = new Random();
            int side = num.Next(1,3);

            if(side == 1)
            {
                Console.WriteLine("HEADS");
                return ("Heads");
            }
            else
            {
                Console.WriteLine("TAILS");
                return ("Tails");
            }

        }

        public static double TossMultipleCoins(int num)
        {
            int head_count = 0;
            int tail_count = 0;
            string Toss;

            for(int i = 0; i <= num; i++)
            {
                Toss = TossCoin();
                if(Toss == "Heads")
                {
                    head_count ++;
                }
                if(Toss == "Tails")
                {
                    tail_count ++;
                }
            }
            Console.WriteLine($"Tossing {num} coins");
            Console.WriteLine(num/head_count);
            return(num/head_count);
        }

        
    }
}