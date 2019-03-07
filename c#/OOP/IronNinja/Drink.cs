using System;
using System.Collections.Generic;

namespace IronNinja
{
    class Drink : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get; set;}

        // Implement a GetInfo Method
        public string GetInfo()
        {
            return $"{Name}: (Drink), Calories: {Calories}, Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
        // Add a constructor method
        public Drink(string name, int cals, bool spicy)
        {
            Name = name;
            Calories = cals;
            IsSpicy = spicy;
            IsSweet = true; 
        }

    }
}