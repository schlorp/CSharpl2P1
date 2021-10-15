using System;
using System.Collections.Generic;
using System.Text;

namespace CSles5
{
    class HealPotion : Equipment
    {

        public override void Use()
        {
            base.Use();
            Console.WriteLine("*used HealthPotion*");
        }
    }
}
