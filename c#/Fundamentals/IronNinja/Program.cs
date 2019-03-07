using System;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet MyBuffet = new Buffet();
            SweetTooth Michael = new SweetTooth();
            SpiceHound Ali = new SpiceHound();
            while(Michael.IsFull != true)
            {
                IConsumable item = MyBuffet.Serve();
                Michael.Consume(item);
            }
            while(Ali.IsFull != true)
            {
                IConsumable item = MyBuffet.Serve();
                Ali.Consume(item);
            }
            int MichaelCount = Michael.ConsumptionHistory.Count;
            int AliCount = Ali.ConsumptionHistory.Count;
            Console.WriteLine("                                                     ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("----------------------RESULTS------------------------");
            Console.WriteLine("-----------------------------------------------------");
            if(MichaelCount > AliCount)
            {
                Console.WriteLine($"Michael consumed {MichaelCount} items");
                Console.WriteLine($"Ali consumed {AliCount} items");
                Console.WriteLine($"MICHAEL CONSUMED THE MOST ITEMS!");
            }
            if(MichaelCount < AliCount)
            {
                Console.WriteLine($"Michael consumed {MichaelCount} items");
                Console.WriteLine($"Ali consumed {AliCount} items");
                Console.WriteLine($"ALI CONSUMED THE MOST ITEMS!");
            }

        }
    }
}
