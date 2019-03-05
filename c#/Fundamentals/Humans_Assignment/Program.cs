using System;

namespace Humans_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Human1 = new Human("Michael",100,100,100,100);
            Human Human2 = new Human("Jermey");
            Human Human3 = new Human("Kunle");
            Human Human4 = new Human("Skyler");
            Human Human5 = new Human("Cros");
            Console.WriteLine(Human2.HealthProp);
            Human5.Attack(Human2);
            Console.WriteLine(Human2.HealthProp);
        }
    }
}
