using System;
using System.Collections.Generic;

namespace Humans_Assignment
{
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        // add a public "getter" property to access health
         public string HealthProp
         {
             get
             {
                 return $"Health = {health}";
             }
         }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string MyName)
        {
            Name = MyName;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;

        }
        // Add a constructor to assign custom values to all fields
        public Human(string Myname, int MyStrength, int MyIntelligence, int MyDex, int MyHealth)
        {
            Name = Myname;
            Strength = MyStrength;
            Intelligence = MyIntelligence;
            Dexterity = MyDex;
            health = MyHealth;

        }
        // Build Attack method
        public int Attack(Human target)
        {
            int damage = 5*this.Strength; 
            target.health -= damage;

            return health;
        }
    }
}