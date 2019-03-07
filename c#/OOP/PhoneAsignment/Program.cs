using System;

namespace PhoneAsignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100,  "T-Mobile", "Dooo do doo doooo");
            Nokia elevenHundred = new Nokia("1100", 60, "AT&T", "Ringgg ring ringgg");
            s8.DisplayInfo();
            s8.Ring();
            s8.Unlock();
            Console.WriteLine("");

            elevenHundred.DisplayInfo();
            elevenHundred.Ring();
            elevenHundred.Unlock();
            Console.WriteLine("");
        }
    }
}
