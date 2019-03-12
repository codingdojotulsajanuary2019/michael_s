using System;

namespace Dojoachi.Models
{
    public class Pet
    {
       public int Happiness {get; set;}
       public int Fullness {get; set;}
       public int Energy {get; set;}
       public int Meals {get; set;}

       public void New()
       {
            this.Happiness = 20;
            this.Fullness = 20;
            this.Energy = 50;
            this.Meals = 3;

       }
       
 
    }
}