using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] NumArray = {0,1,2,3,4,5,6,7,8,9};
            string [] NameArray = {"Tim", "Nikki", "Sara"};
            bool [] BoolArray = {true, false, true, false, true, false, true, false, true, false};

            List<string> IceCream = new List<string>();
            IceCream.Add("Chocolate");
            IceCream.Add("Vanilla");
            IceCream.Add("Chocolate Chip");
            IceCream.Add("Mint");
            IceCream.Add("Biirthday Cake");
            IceCream.Add("Chocolate Chip Cookie Dough");
            Console.WriteLine(IceCream.Count);
            Console.WriteLine(IceCream[2]);
            IceCream.Remove(IceCream[2]);
            Console.WriteLine(IceCream.Count);

            Dictionary<string, string> people = new Dictionary<string, string>();
            Random num = new Random();
            foreach(var name in NameArray )
            {
                people.Add(name, IceCream[num.Next(0,6)]);
            }
            foreach (var item in people)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
