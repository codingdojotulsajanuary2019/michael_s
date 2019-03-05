using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] MultTable = new int[10];
            for(int i = 1; i < MultTable.Length; i++)
            {
                MultTable[i-1] = i;
                Console.Write(MultTable[i-1] + " , ");
            }

        }
    }
}
