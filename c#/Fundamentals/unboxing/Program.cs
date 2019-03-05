using System;
using System.Collections.Generic;

namespace unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> MyList = new List<object>();
            MyList.Add(7);
            MyList.Add(28);
            MyList.Add(-1);
            MyList.Add(true);
            MyList.Add("Chair");

            int sum = 0;
            foreach(var item in MyList)
            {
                Console.WriteLine(item);
                if(item is int)
                {
                    sum = sum + (int)item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
