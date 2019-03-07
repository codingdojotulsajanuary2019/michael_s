using System;
using System.Collections.Generic;

namespace IronNinja
{
    class SweetTooth : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        public override bool IsFull
        {
            get
            {
                if(this.calorieIntake >= 1500)
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
                if(item.IsSweet == true)
                {
                    item.Calories += 10;
                }
                this.ConsumptionHistory.Add(item);
                Console.WriteLine($"{this} just Consumed {item.GetInfo()} YUMMMM!");
                Console.WriteLine($"{this} has {1500 - this.calorieIntake} calories left.");

            }
            if(IsFull == true)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("--------------SWEETTOOTH is FULL!!!!---------------");
                Console.WriteLine("---------------------------------------------------");
            }
        }
}

}
