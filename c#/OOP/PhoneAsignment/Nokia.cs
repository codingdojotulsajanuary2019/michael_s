using System;

namespace PhoneAsignment
{
    public class Nokia : Phone, IRingable 
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            // your code here
            Console.WriteLine($"RINGING......{this.RingTone}");
            return this.RingTone;
        }
        public string Unlock() 
        {
            // your code here
            Console.WriteLine($"Your {this.Version} has been UNLOCKED via Fingerprint Scanner");
            return this.Version;
        }
        public override void DisplayInfo() 
        {
            // your code here            
            Console.WriteLine("-------------Phone Info-------------");
            Console.WriteLine($"Model: {this.Version}");
            Console.WriteLine($"Battery Charge: {this.Battery}%");
            Console.WriteLine($"Carrier: {this.Carrier}");
            Console.WriteLine($"RingTone: {this.RingTone}");
            Console.WriteLine("------------------------------------");
        }
    }
       
}