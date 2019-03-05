using System;

namespace HungryNinjasAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet MyBuffet = new Buffet();
            Food ThisFood = MyBuffet.Serve();
            Console.WriteLine(ThisFood.Name);
            Ninja NewNinja = new Ninja();
            NewNinja.Eat(ThisFood);
        }
    }
}
