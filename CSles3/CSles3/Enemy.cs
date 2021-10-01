using System;
using System.Collections.Generic;
using System.Text;

namespace CSles3
{
    class Enemy
    {
        public int Hp { get; set; }
        public void getDamage(int damage)
        {
            Hp -= damage;
            if (Hp <= 0)
            {
                Console.WriteLine("dead");
            }
        }

        public void Logic()
        {
            Console.WriteLine("cheese");
        }
    }
}
