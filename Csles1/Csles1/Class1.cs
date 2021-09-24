using System;
using System.Collections.Generic;
using System.Text;

namespace Csles1
{
    public class Peter
    {
        public int Hp { get; set; }
        public int BierFlesjeDMG { get; set; }
        public int WalkingSpeed { get; set; }

        public Peter(string naam)
        {
        }

        public Peter(int age, string name, string adres)
        {
        }
        
        public void getDamage(int damage)
        {
            Hp -= damage;
            if(Hp <= 0)
            {
                Console.WriteLine("dead");
            }
        }


    }
}
