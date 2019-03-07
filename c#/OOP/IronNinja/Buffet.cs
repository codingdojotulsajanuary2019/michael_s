using System;
using System.Collections.Generic;

namespace IronNinja
{
    class Buffet
    {
        public List<IConsumable> Menu;
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
            new Drink("Dr. Pepper", 200, false),
            new Drink("Bloody Mary", 300, true),
            new Drink("Beer", 90, false),
            new Drink("Lemonade", 100, false),
            new Food("Jalepeno Cheesburger", 500, true, false),
            new Food("Chili Cheese HotDog", 325, false, false),
            new Food("Ice Cream", 400, false, true),
            new Food("Brownie", 340, false, true),
            new Food ("Steak", 500, false, false),
            };
        }
        public IConsumable Serve()
        {
            Random rand = new Random();

            return Menu[rand.Next(0,Menu.Count)];
        }

    }
}