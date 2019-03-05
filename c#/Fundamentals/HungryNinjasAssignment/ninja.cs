using System;
using System.Collections.Generic;

namespace HungryNinjasAssignment
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string FoodName, int FoodCals, bool spicy, bool sweet)
        {
            Name = FoodName;
            Calories = FoodCals;
            IsSpicy = spicy;
            IsSweet = sweet;

        }
    }

    class Buffet
    {
        public List<Food> Menu;
        
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Chicken", 350, false, false),
                new Food("Steak", 450, false, false),
                new Food("Fried Rice", 250, true, false),
                new Food("Candy", 375, false, true),
                new Food("Ice Cream", 1000, false, true),
                new Food("Green Beans", 150, false, true),
                new Food("Soup", 400, true, false),
                new Food("Salad", 250, false, false)
            };
        }
        
        public Food Serve()
        {
            Random rand = new Random();

            return Menu[rand.Next(0,Menu.Count)];
        }
    }

    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        
        // add a public "getter" property called "IsFull"
        public bool IsFull
        {
            get
            {
                if(calorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        // build out the Eat method
        public void Eat(Food item)
        {
            if(IsFull ==true)
            {
                Console.WriteLine($"Ninja has consumed {calorieIntake} is FULL and cannot eat anymore");
            }
            if(IsFull == false)
            {
                FoodHistory.Add(item);
                string spicy = null;
                string sweet = null;
                if(item.IsSpicy == true)
                {
                    spicy = "Extra";
                }
                if(item.IsSpicy == false)
                {
                    spicy = "not very";
                }
                if(item.IsSweet == true)
                {
                    sweet = "Nice and";
                }
                if(item.IsSweet == false)
                {
                    sweet = "not very";
                }

                Console.WriteLine($"The Ninja ate {item.Name} and it was {spicy} spciy and it was {sweet} sweet.");
            }
        }
    }
}