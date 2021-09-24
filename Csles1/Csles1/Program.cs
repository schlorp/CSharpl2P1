using System;

namespace Csles1
{
    using System.Threading;
    class Program
    {
        public int dmg = 10;

        static void Main(string[] args)
        {
            int dmg = 10;
            Peter peet = new Peter("beter peter");
            peet.Hp = 100;
            peet.BierFlesjeDMG = 20;
            peet.WalkingSpeed = 15;
            
            while(peet.Hp > 0)
            {
                peet.getDamage(dmg);
                Console.WriteLine("HP: " + peet.Hp);
                Thread.Sleep(1000);
                
            }

            Peter peet2 = new Peter(10, "gerard", "jemoeder is single singel");


        }

        

    }
}
