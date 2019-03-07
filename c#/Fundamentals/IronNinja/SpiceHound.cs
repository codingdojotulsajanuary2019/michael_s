using System;
using System.Collections.Generic;

namespace IronNinja
{
    class SpiceHound : Ninja
    {
    // provide override for IsFull (Full at 1200 Calories)
        public override bool IsFull
        {
            get
            {
                if(this.calorieIntake >= 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if(IsFull == false)
            {
                this.calorieIntake += item.Calories;
                if(item.IsSpicy == true)
                {
                    this.calorieIntake -= 10;
                }
                this.ConsumptionHistory.Add(item);
                Console.WriteLine($"{this} just consumed {item.GetInfo()} YUUUMM!!");
                Console.WriteLine($"{this} has {1200 - this.calorieIntake} calories left");
            }
            if (IsFull == true)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("----------------SPICEHOUND IS FULL!!!!!!-------------");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }

    
}